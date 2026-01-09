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
using DevExpress.XtraEditors.Repository;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

namespace SISGEM.ModuloCompras
{
    public partial class frmRendicionesReembolso : DevExpress.XtraEditors.XtraForm
    {
        private int _EstadoReembolso = 0;
        public int eReembolso
        {
            get { return _EstadoReembolso; }
            private set
            {
                _EstadoReembolso = value;

                if (value == 1)
                {
                    lblEstado.Caption = "Nuevo Reembolso";
                }
                else if (value == 2)
                {
                    lblEstado.Caption = "Reembolso Guardado";
                }
                else if (value == 0)
                {
                    lblEstado.Caption = "Reembolso Anulado";
                }
            }
        }

        public int idReembolso = 0;
        public int Estado { get; private set; } = 1;

        public frmRendicionesReembolso()
        {
            InitializeComponent();
        }

        private void frmRendicionesReembolso_Load(object sender, EventArgs e)
        {

            txtTotal.EditValue = 0;
            txtId.ReadOnly = true;
            txtTotal.ReadOnly = true;
            eReembolso = 1;
            CargarEmpresas();
            CargarEmpleado();
            CargarMoneda();
            CargarUsuariosActivos();

            dtpFechaEmision.EditValue = DateTime.Now;

            HPResergerCapaLogica.Contable.ReembolsosMasivos oClase = new HPResergerCapaLogica.Contable.ReembolsosMasivos();
            if (idReembolso != 0)
            {
                DataTable dt = oClase.ObtenerPorID(idReembolso);

                if (dt.Rows.Count == 0)
                {
                    XtraMessageBox.Show("No se encontró la Rendición.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow row = dt.Rows[0];

                // Asignar valores a controles
                cboEmpresa.EditValue = row["IdEmpresa"];
                cboEmpleado.EditValue = row["IdEmpleado"];
                cboMoneda.EditValue = row["IdMoneda"];
                txtGlosa.EditValue = row["Glosa"];
                dtpFechaEmision.EditValue = row["FechaCreacion"];
                txtTotal.EditValue = row["Total"];

                cboUsuario.EditValue = row["IdUsuario"];
                _EstadoReembolso = (int)row["EstadoReembolso"];

                Estado = (int)row["Estado"];
                eReembolso = 2;

            }

            HPResergerCapaLogica.Mantenimiento.Empresa Cclase = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable dtComprobantes = Cclase.GetComprobantesPago();
            repositoryItemSearchLookUpEdit1.DisplayMember = "Nombre";
            repositoryItemSearchLookUpEdit1.ValueMember = "Id";
            repositoryItemSearchLookUpEdit1.NullText = "[Seleccione]";
            repositoryItemSearchLookUpEdit1.DataSource = dtComprobantes;
            // Configurar las columnas visibles
            GridView gridView = repositoryItemSearchLookUpEdit1.View as GridView;
            if (gridView != null)
            {
                gridView.Columns.Clear(); // Limpiar columnas anteriores
                gridView.Columns.AddVisible("Sufijo", "Tipo"); // Mostrar solo la columna "Nombre"
                gridView.Columns.AddVisible("Nombre", "Nombre Comprobante"); // Mostrar solo la columna "Nombre"
                gridView.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
            }

            HPResergerCapaLogica.Compras.ProveedorData ClProveedor = new HPResergerCapaLogica.Compras.ProveedorData();
            DataTable dtProveedores = ClProveedor.GetAll();
            repositoryItemSearchLookUpEdit2.DisplayMember = "razonSocial";
            repositoryItemSearchLookUpEdit2.ValueMember = "ruc";
            repositoryItemSearchLookUpEdit2.NullText = "[Seleccione]";
            repositoryItemSearchLookUpEdit2.DataSource = dtProveedores;
            // Configurar las columnas visibles
            GridView gridView1 = repositoryItemSearchLookUpEdit2.View as GridView;
            if (gridView1 != null)
            {
                gridView1.Columns.Clear(); // Limpiar columnas anteriores
                gridView1.Columns.AddVisible("ruc", "RUC"); // Mostrar solo la columna "Nombre"
                gridView1.Columns.AddVisible("razonSocial", "Razon Social"); // Mostrar solo la columna "Nombre"
                gridView1.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                gridView1.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
            }

            var configuracionEmpresa = new HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa();
            var configuracion1 = configuracionEmpresa.GetByTipo(3);
            trabajarconPartidas = (configuracion1?.Valor ?? 0) != 0;
            xPartida.Visible = trabajarconPartidas;

            //RepositoryItemButtonEdit repoAdjunto = new RepositoryItemButtonEdit();
            //repoAdjunto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //repoAdjunto.Buttons[0].Caption = "📎";
            //repoAdjunto.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            //repoAdjunto.ButtonClick += RepoSusAdjunto_ButtonClick;

            //gridControl1.RepositoryItems.Add(repoAdjunto);
            //xDocumento.ColumnEdit = repoAdjunto;
            if (eReembolso == 2)
                CargarPresupuetos((int)cboEmpresa.EditValue);


            //TRAEMOS EL DETALLE
            Tdata = oClase.GetReembolsoDetalle(idReembolso);
            gridControl1.DataSource = Tdata;

        }

        private void RepoDocAdjunto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] archivoBytes = File.ReadAllBytes(ofd.FileName);
                string nombre = Path.GetFileName(ofd.FileName);
                string extension = Path.GetExtension(ofd.FileName);

                int rowHandle = gridView1.FocusedRowHandle;

                gridView1.SetRowCellValue(rowHandle, "DocArchivoAdjunto", archivoBytes);
                gridView1.SetRowCellValue(rowHandle, "DocNombreArchivo", nombre);
                gridView1.SetRowCellValue(rowHandle, "DocExtension", extension);

                //XtraMessageBox.Show(gridView1.GetRowCellValue(rowHandle, "DocExtension").ToString());
            }
        }

        private void RepoSusAdjunto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Todos los archivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] archivoBytes = File.ReadAllBytes(ofd.FileName);
                string nombre = Path.GetFileName(ofd.FileName);
                string extension = Path.GetExtension(ofd.FileName);

                int rowHandle = gridView1.FocusedRowHandle;

                gridView1.SetRowCellValue(rowHandle, "SusArchivoAdjunto", archivoBytes);
                gridView1.SetRowCellValue(rowHandle, "SusNombreArchivo", nombre);
                gridView1.SetRowCellValue(rowHandle, "SusExtension", extension);

                //XtraMessageBox.Show(gridView1.GetRowCellValue(rowHandle, "DocExtension").ToString());
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == xDocumento.FieldName)
            {
                byte[] archivo = gridView1.GetRowCellValue(e.RowHandle, xDocArchivoAdjunto.FieldName) as byte[];

                RepositoryItemButtonEdit repo = new RepositoryItemButtonEdit();
                repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                repo.Buttons.Clear();
                repo.ButtonClick += RepoDocAdjunto_ButtonClick;


                if (archivo == null || archivo.Length == 0)
                {
                    repo.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
                        DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                    {
                        Caption = "Sin Archivo"
                    });
                }
                else
                {
                    repo.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
                        DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                    {
                        Caption = "Con Archivo"
                    });
                }

                e.RepositoryItem = repo;
            }
            else if (e.Column.FieldName == xSustento.FieldName)
            {
                byte[] archivo = gridView1.GetRowCellValue(e.RowHandle, xSusArchivoAdjunto.FieldName) as byte[];

                RepositoryItemButtonEdit repo = new RepositoryItemButtonEdit();
                repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                repo.Buttons.Clear();
                repo.ButtonClick += RepoSusAdjunto_ButtonClick;


                if (archivo == null || archivo.Length == 0)
                {
                    repo.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
                        DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                    {
                        Caption = "Sin Archivo"
                    });
                }
                else
                {
                    repo.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(
                        DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                    {
                        Caption = "Con Archivo"
                    });
                }

                e.RepositoryItem = repo;
            }
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
        private void CargarUsuariosActivos()
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cClase = new HPResergerCapaLogica.Mantenimiento.Empresa();

            DataTable tData = cClase.GetUsuariosActivos();
            cboUsuario.Properties.DataSource = tData;
            cboUsuario.Properties.DisplayMember = "Usuario";
            cboUsuario.Properties.ValueMember = "Id";

            // Limpiar y configurar columnas manualmente
            cboUsuario.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "Usuario"; // Solo la columna "descripcion" será visible
                cboUsuario.Properties.Columns.Add(lookupColumn);
            }

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboUsuario.EditValue = HPReserger.frmLogin.CodigoUsuario;
            }
            else
                cboUsuario.Properties.DataSource = null;


            // Otras opciones de personalización
            cboUsuario.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboUsuario.Properties.ShowFooter = false; // Ocultar pie de página
            cboUsuario.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void CargarEmpleado()
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cClase = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable Tdata = cClase.GetEmpleados();
            cboEmpleado.Properties.DataSource = Tdata;
            cboEmpleado.Properties.DisplayMember = "Nombre";
            cboEmpleado.Properties.ValueMember = "Id";

            cboEmpleado.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["Id"] : null;

            // Limpiar columnas
            var view = cboEmpleado.Properties.View;
            view.Columns.Clear();

            var colRuc = view.Columns.AddVisible("NroId", "Número");
            var colRazon = view.Columns.AddVisible("Nombre", "Nombre Empleado");

            colRuc.Width = 100;
            colRuc.MinWidth = 100;
            colRuc.MaxWidth = 100;
            colRuc.OptionsColumn.FixedWidth = true;

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            eReembolso = 1;
            Estado = 1;
            idReembolso = 0;
            gridControl1.DataSource = null;
            txtGlosa.EditValue = "";
            txtTotal.EditValue = 0;
            txtId.EditValue = 0;

        }

        private void FechaCreacionDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            txtId.EditValue = idReembolso;
            txtId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            txtId.Properties.DisplayFormat.FormatString = $"'{((DateTime)dtpFechaEmision.EditValue).ToString("yyyy-MM")}-'00";

        }
        DataTable Tdata;

        private void btnAddFila_Click(object sender, EventArgs e)
        {
            if (eReembolso == 1)
            {
                Tdata.Rows.Add(Tdata.NewRow());
            }
            CalcularTotalGeneral();
        }
        private void CalcularTotalGeneral()
        {
            decimal suma = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                suma += ToDec(gridView1.GetRowCellValue(i, xtotal.FieldName));
            }

            txtTotal.EditValue = suma;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (eReembolso == 1)
            {
                var Fila = gridView1.GetFocusedDataRow();
                if (Fila != null)
                {
                    Tdata.Rows.Remove(Fila);
                }
            }
            CalcularTotalGeneral();
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
        public string NumeroReembolso(int numero)
        {
            DateTime Fecha = (DateTime)dtpFechaEmision.EditValue;
            return $"{Fecha.ToString("yyyy-MM-")}{numero.ToString("00")}";
        }
        bool IsNullOrEmpty(DataRow r, string field) => string.IsNullOrWhiteSpace(r.Field<string>(field));

        bool IsNull(DataRow r, string field) => r.Field<DateTime?>(field) == null;

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Estado == 0)
            {
                XtraMessageBox.Show("Rendición Anulada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EstadoReembolso == 0)
            {
                XtraMessageBox.Show("Rendición Anulada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EstadoReembolso == 3)
            {
                XtraMessageBox.Show("Rendición tiene un documento Pagado, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EstadoReembolso == 4)
            {
                XtraMessageBox.Show("Rendición Pagada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_EstadoReembolso == 2)
            {
                XtraMessageBox.Show("Rendición Grabada, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> errores = new List<string>();
            // Empresa
            if (cboEmpresa.EditValue == null)
                errores.Add("• Debe seleccionar la *Empresa*.");
            // Proyecto
            if (cboProyecto.EditValue == null)
                errores.Add("• Debe seleccionar la *Proyecto*.");
            // Etapa
            if (cboEtapa.EditValue == null)
                errores.Add("• Debe seleccionar la *Etapa*.");

            // Tipo de Empleado
            if (cboEmpleado.EditValue == null)
                errores.Add("• Debe seleccionar el *Empleado*.");
            // Fecha Emisión
            if (dtpFechaEmision.EditValue == null)
                errores.Add("• Debe ingresar la *Fecha de Emisión*.");
            // Moneda
            if (cboMoneda.EditValue == null)
                errores.Add("• Debe seleccionar la *Moneda*.");
            // Listado de Facturas
            if (Tdata.Rows.Count == 0)
                errores.Add("• Debe agregar una Factura.");

            int a = 0;
            foreach (DataRow row in Tdata.Rows)
            {
                a++;

                if ((row.Field<int?>(xComprobante.FieldName) ?? 0) == 0)
                    errores.Add($"• Fila {a}: Debe seleccionar *Comprobante*.");

                if (IsNullOrEmpty(row, xSerie.FieldName))
                    errores.Add($"• Fila {a}: Debe ingresar *Serie*.");

                if (IsNullOrEmpty(row, xNumero.FieldName))
                    errores.Add($"• Fila {a}: Debe ingresar *Número*.");

                if (IsNullOrEmpty(row, xProveedor.FieldName))
                    errores.Add($"• Fila {a}: Debe ingresar *Proveedor*.");

                if (IsNull(row, xFechaEmision.FieldName))
                    errores.Add($"• Fila {a}: Debe ingresar *Fecha de Emisión*.");
            }
            a = 0;
            foreach (DataRow row in Tdata.Rows)
            {
                a++;
                string ruc = row[xProveedor.FieldName]?.ToString().Trim();
                string serie = row[xSerie.FieldName]?.ToString().Trim();
                string numero = row[xNumero.FieldName]?.ToString().Trim();
                int idcomprobante = row.Field<int?>(xComprobante.FieldName) ?? 0;

                DataTable Tprueba = CapaLogica.FacturaManualCabecera(ruc, serie + "-" + numero, idcomprobante);
                if (Tprueba.Rows.Count > 0)
                {
                    errores.Add($"• Fila {a}: Este documento *Ya Existe*.");
                }
            }
            // -----------------------------
            // MOSTRAR ERRORES
            // -----------------------------
            if (errores.Count > 0)
            {
                string mensaje = "Se encontraron los siguientes errores:\n\n" + string.Join("\n", errores);
                XtraMessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // no guardar
            }

            int idUsuario = HPReserger.frmLogin.CodigoUsuario;

            if (_EstadoReembolso == 1) // nuevo
            {
                HPResergerCapaLogica.Contable.ReembolsosMasivos.oReembolsoMasivo oObjeto = new HPResergerCapaLogica.Contable.ReembolsosMasivos.oReembolsoMasivo();
                HPResergerCapaLogica.Contable.ReembolsosMasivos oClase = new HPResergerCapaLogica.Contable.ReembolsosMasivos();

                oObjeto.IdEmpresa = (int)cboEmpresa.EditValue;
                oObjeto.IdEmpleado = (int)cboEmpleado.EditValue;
                oObjeto.IdMoneda = (int)cboMoneda.EditValue;
                oObjeto.IdUsuario = (int)cboUsuario.EditValue;
                oObjeto.Glosa = Convert.ToString(txtGlosa.EditValue) ?? "";
                oObjeto.FechaCreacion = (DateTime)dtpFechaEmision.EditValue;
                oObjeto.Total = ToDec(txtTotal.EditValue);
                oObjeto.EstadoReembolso = 2;
                oObjeto.Estado = 1;
                oObjeto.Fecha = DateTime.Now;

                idReembolso = oClase.Insertar(oObjeto);


                if (idReembolso != 0)
                {
                    //AGREGAMOS EL DETALLE
                    int c = 1;
                    foreach (DataRow row in Tdata.Rows)
                    {
                        var oDetalle = new HPResergerCapaLogica.Contable.ReembolsoMasivoDetalle.oReembolsoMasivoDetalle();

                        HPResergerCapaLogica.Mantenimiento.Empresa ceMPRESA = new HPResergerCapaLogica.Mantenimiento.Empresa();
                        DataTable tEmppleado = ceMPRESA.GetEmpleado((int)cboEmpleado.EditValue);
                        string _empleadoCompensacion = tEmppleado.Rows.Count > 0 ? tEmppleado.Rows[0]["tipoNroDoc"].ToString() : "";

                        DateTime _FechaEmision = row.Field<DateTime>(xFechaEmision.FieldName);
                        string _glosa = row.Field<string>(xGlosa.FieldName).ToString().Trim();
                        string _serie = row.Field<string>(xSerie.FieldName).ToString().Trim();
                        string _numero = row.Field<string>(xNumero.FieldName).ToString().Trim();
                        string _ruc = row.Field<string>(xProveedor.FieldName).ToString().Trim();
                        int _idComprobante = row.Field<int>(xComprobante.FieldName);
                        decimal _total = row.Field<decimal>(xtotal.FieldName);

                        string _DatoPresupuesto = gridView1.GetRowCellDisplayText(c, xPartida);
                        string _xDocNombreArchivo = row.Field<string>(xDocNombreArchivo.FieldName);
                        string _xDocExtension = row.Field<string>(xDocExtension.FieldName);
                        byte[] _xDocArchivoAdjunto = row.Field<byte[]>(xDocArchivoAdjunto.FieldName);

                        string _xSusNombreArchivo = row.Field<string>(xSusNombreArchivo.FieldName);
                        string _xSusExtension = row.Field<string>(xSusExtension.FieldName);
                        byte[] _xSusArchivoAdjunto = row.Field<byte[]>(xSusArchivoAdjunto.FieldName);

                        string _idPartida = (row.Field<int?>(xPartida.FieldName) ?? 0).ToString();

                        int _idfactura = 0;
                        //PROCESO DE CREAR LA FACTURA PARCIAL
                        //Reembolso = 2
                        int _TipoFactura = gridView1.GetRowCellDisplayText(c, xComprobante).Contains("NOTA") ? 2 : 1;

                        if (_TipoFactura == 1) //FACTURA
                        {
                            HPResergerCapaLogica.Compras.oFacturaManual OfACTURA = new HPResergerCapaLogica.Compras.oFacturaManual();
                            OfACTURA.ActivoFijo = 0;
                            OfACTURA.Cod_Detraccion = "";
                            OfACTURA.Compensacion = 2; //2 REEMBOLSO DE GASTOS
                            OfACTURA.Detraccion = 0;
                            OfACTURA.Empresa = (int)cboEmpresa.EditValue;
                            OfACTURA.Estado = 0;
                            OfACTURA.Etapa = (int)cboEtapa.EditValue;
                            OfACTURA.FechaCompensacion = null;
                            OfACTURA.FechaContable = _FechaEmision;
                            OfACTURA.FechaEmision = _FechaEmision;
                            OfACTURA.FechaModifica = _FechaEmision;
                            OfACTURA.FechaRecepcion = _FechaEmision;
                            OfACTURA.FechaVencimiento = _FechaEmision;
                            OfACTURA.Glosa = _glosa;
                            OfACTURA.GravaIgv = 0;
                            OfACTURA.IdComprobante = _idComprobante;
                            OfACTURA.Igv = 0;
                            OfACTURA.ImgFactura = null;
                            OfACTURA.Moneda = (int)cboMoneda.EditValue;
                            OfACTURA.NroComprobante = _serie + "-" + _numero;
                            OfACTURA.Nro_DocPago = "";
                            OfACTURA.Porcentaje = 0.18m;
                            OfACTURA.Proveedor = _ruc.Trim();
                            OfACTURA.Proyecto = (int)cboProyecto.EditValue;
                            OfACTURA.TC = 3m;
                            OfACTURA.TipoPago = 0;
                            OfACTURA.Total = _total;
                            OfACTURA.Usuario = idUsuario;
                            OfACTURA.UsuarioCompensacion = _empleadoCompensacion;

                            HPResergerCapaLogica.Compras.FacturaManualCompra cclase = new HPResergerCapaLogica.Compras.FacturaManualCompra();
                            _idfactura = cclase.Insert(OfACTURA);

                        }
                        else if (_TipoFactura == 2)
                        {

                            HPResergerCapaLogica.Compras.oNC_ND_CompraManual oNota = new HPResergerCapaLogica.Compras.oNC_ND_CompraManual();
                            //oNota.ActivoFijo = 0;
                            //oNota.Cod_Detraccion = "";
                            oNota.Compensacion = 2;
                            //oNota.Detraccion = 0;
                            oNota.Empresa = (int)cboEmpresa.EditValue;
                            oNota.Estado = 0;
                            oNota.Etapa = (int)cboEtapa.EditValue;
                            oNota.FechaCompensacion = null;
                            oNota.FechaContable = _FechaEmision;
                            oNota.FechaEmision = _FechaEmision;
                            oNota.FechaModifica = _FechaEmision;
                            oNota.FechaRecepcion = _FechaEmision;
                            oNota.FechaVencimiento = _FechaEmision;
                            oNota.Glosa = _glosa;
                            oNota.GravaIgv = 0;
                            oNota.IdComprobante = _idComprobante;
                            oNota.Igv = 0;
                            oNota.ImgFactura = null;
                            oNota.Moneda = (int)cboMoneda.EditValue;
                            oNota.NroComprobante = _serie + "-" + _numero;

                            oNota.NroComprobante_Ref = " ";

                            //oNota.Nro_DocPago = "";
                            //oNota.Porcentaje = 0.18m;
                            oNota.Proveedor = _ruc.Trim();
                            oNota.Proyecto = (int)cboProyecto.EditValue;
                            oNota.TC = 3m;
                            //oNota.TipoPago = 0;
                            oNota.Total = _total;
                            oNota.Usuario = idUsuario;
                            oNota.UsuarioCompensacion = _empleadoCompensacion;

                            HPResergerCapaLogica.Compras.NC_ND_CompraManualCompra cclase = new HPResergerCapaLogica.Compras.NC_ND_CompraManualCompra();
                            _idfactura = cclase.Insert(oNota);


                        }
                        if (_idfactura != 0)
                        {
                            oDetalle.Id = 0;
                            oDetalle.Item = c++;
                            oDetalle.IdReembolso = idReembolso;
                            oDetalle.TipoFactura = _TipoFactura;
                            oDetalle.IdFactura = _idfactura;
                            oDetalle.Usuario = idUsuario;

                            //Insertar detalle
                            oClase.Insert(oDetalle);

                            if (_DatoPresupuesto != "")
                            {
                                HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto oFacP = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                                oFacP.InsertarxNombreyCodigo(_idfactura, _TipoFactura, (int)cboEmpresa.EditValue, _idPartida);
                            }

                            if (!string.IsNullOrWhiteSpace(_xDocNombreArchivo)) // 1 documento 2 sustento
                            {
                                HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                                ccalse.GuardarAdjuntoSQL(_idfactura, _TipoFactura, 1, _xDocNombreArchivo, _xDocExtension, _xDocArchivoAdjunto);
                            }
                            if (!string.IsNullOrWhiteSpace(_xSusNombreArchivo))
                            {
                                HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                                ccalse.GuardarAdjuntoSQL(_idfactura, _TipoFactura, 2, _xSusNombreArchivo, _xSusExtension, _xSusArchivoAdjunto);

                            }
                        }

                    }
                    if (idReembolso == 0)
                    {
                        XtraMessageBox.Show("Ocurrió un problema y la Rendición no se pudo guardar.\n" +
                            "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtId.EditValue = idReembolso;
                        eReembolso = 2;
                        XtraMessageBox.Show($"La Rendición fue guardada correctamente. con ID: {NumeroReembolso(idReembolso)}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Crear instancia del reporte
                        ModuloXtraReports.Compras.xReportReembolsos reporte = new ModuloXtraReports.Compras.xReportReembolsos();

                        // Obtener el SqlDataSource del reporte
                        SqlDataSource dataSource = reporte.DataSource as SqlDataSource;

                        if (dataSource != null)
                        {
                            // Crear una nueva conexión
                            HPResergerCapaDatos.HPResergerCD capad = new HPResergerCapaDatos.HPResergerCD();
                            string nuevaConexion = capad.ObtenerConexion();

                            // Modificar la conexión
                            dataSource.ConnectionParameters = new CustomStringConnectionParameters(nuevaConexion);

                            var query = dataSource.Queries[0] as SqlQuery;
                            if (query != null)
                            {
                                query.Parameters.Clear(); // Limpia los parámetros previos
                                query.Parameters.Add(new QueryParameter("@idreembolso", typeof(int), idReembolso));

                            }

                            // ** 3.3 REFRESCAR Y LLENAR EL DATA SOURCE **
                            dataSource.RebuildResultSchema();
                            dataSource.Fill();
                        }

                        // ** 4. EVITAR QUE SE MUESTRE LA VENTANA DE PARÁMETROS**
                        foreach (var param in reporte.Parameters)
                        {
                            param.Visible = false; // Ocultar los parámetros en el visor
                        }
                        // ** 5. CONFIGURAR EL NOMBRE DEL ARCHIVO AL EXPORTAR A PDF**
                        reporte.ExportOptions.PrintPreview.DefaultFileName = "Reporte de Rendiciones";

                        // Mostrar el reporte en un visor
                        ReportPrintTool printTool = new ReportPrintTool(reporte);
                        printTool.ShowPreviewDialog();

                    }
                }
            }

            else if (_EstadoReembolso == 2)
            {
                HPResergerCapaLogica.Contable.ReembolsosMasivos.oReembolsoMasivo oObjeto = new HPResergerCapaLogica.Contable.ReembolsosMasivos.oReembolsoMasivo();
                HPResergerCapaLogica.Contable.ReembolsosMasivos oClase = new HPResergerCapaLogica.Contable.ReembolsosMasivos();

                oObjeto.Id = idReembolso;
                oObjeto.IdEmpresa = (int)cboEmpresa.EditValue;
                oObjeto.IdEmpleado = (int)cboEmpleado.EditValue;
                oObjeto.IdMoneda = (int)cboMoneda.EditValue;
                oObjeto.IdUsuario = (int)cboUsuario.EditValue;
                oObjeto.Glosa = txtGlosa.EditValue?.ToString().Trim();
                oObjeto.FechaCreacion = (DateTime)dtpFechaEmision.EditValue;
                oObjeto.Total = ToDec(txtTotal.EditValue);
                oObjeto.EstadoReembolso = 2;
                oObjeto.Estado = 1;
                oObjeto.Fecha = DateTime.Now;

                int resultado = oClase.Actualizar(oObjeto);

                if (resultado <= 0)
                {
                    XtraMessageBox.Show(
                        "No se pudo actualizar la Rendición.\n" +
                        "Verifique los datos e intente nuevamente.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar detalle anterior
                oClase.DeleteDetalle(idReembolso);

                // Insertar nuevo detalle
                //AGREGAMOS EL DETALLE
                int c = 1;
                foreach (DataRow row in Tdata.Rows)
                {
                    var oDetalle = new HPResergerCapaLogica.Contable.ReembolsoMasivoDetalle.oReembolsoMasivoDetalle();

                    oDetalle.Id = 0;
                    oDetalle.Item = c++;
                    oDetalle.IdReembolso = idReembolso;
                    oDetalle.TipoFactura = (int)row["TipoFactura"];
                    oDetalle.IdFactura = (int)row["IdFactura"];
                    oDetalle.Usuario = idUsuario;

                    //Insertar detalle
                    oClase.Insert(oDetalle);

                    //PROCESO DE CREAR LA FACTURA PARCIAL

                }

                XtraMessageBox.Show($"La Rendición: {NumeroReembolso(idReembolso)}, fue actualizada correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
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
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
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
        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
            {
                cargarProyectos((int)cboEmpresa.EditValue);
                CargarPresupuetos((int)cboEmpresa.EditValue);
            }
        }
        bool trabajarconPartidas = false;
        DataTable dtPresupuestos;
        private void CargarPresupuetos(int _idempresa)
        {
            if (trabajarconPartidas)
            {
                HPResergerCapaLogica.FlujoCaja.Partidas_Control cClase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
                dtPresupuestos = cClase.GetAllxEmpresa(_idempresa);

                repositoryItemSearchLookUpEdit3.DisplayMember = "Nombre";
                repositoryItemSearchLookUpEdit3.ValueMember = "id";
                repositoryItemSearchLookUpEdit3.NullText = "[Seleccione]";
                repositoryItemSearchLookUpEdit3.DataSource = dtPresupuestos; // Fuente de datos general

                // Configurar las columnas visibles
                GridView gridView = repositoryItemSearchLookUpEdit3.View as GridView;
                if (gridView != null)
                {
                    gridView.Columns.Clear(); // Limpiar columnas anteriores
                    gridView.Columns.AddVisible("Nombre", "Nombre del Presupuesto"); // Mostrar solo la columna "Nombre"
                    gridView.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                    gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                    gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
                }
            }
        }

        private void cboProyecto_EditValueChanged(object sender, EventArgs e)
        {
            if (cboProyecto.EditValue != null)
                cargarEtapas((int)cboProyecto.EditValue);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == xtotal.FieldName)
            {
                GridView gv = sender as GridView;
                decimal total = ToDec(gv.GetRowCellValue(e.RowHandle, xtotal.FieldName));

                CalcularTotalGeneral();
            }
        }
    }
}