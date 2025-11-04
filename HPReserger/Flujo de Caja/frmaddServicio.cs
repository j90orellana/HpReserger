using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmaddServicio : XtraForm
    {
        public frmaddServicio()
        {
            InitializeComponent();
        }

        public int Tipo { get; internal set; } = 1;
        public int Empresa { get; internal set; } = 0;

        private void frmaddServicio_Load(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case 1:
                    this.Text = "Partida de Control - SPV";
                    break;
                case 2:
                    this.Text = "Partida de Control - Servicio";
                    break;
                case 3:
                    this.Text = "Partida de Control - Holding";
                    break;
                case 4:
                    this.Text = "Partida de Control - Constructora";
                    break;
                default:
                    this.Text = "Partida de Control - Desconocido";
                    break;
            }
            bntEliminarCargaMasiva.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            bntEliminarCargaMasiva.Enabled = false;
            //CargarEmpresas();
            CargarDatos();
        }

        //private void CargarEmpresas()
        //{
        //    HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
        //    DataTable tData = oCL.Empresa();

        //    cboEmpresa.Properties.DataSource = tData;
        //    cboEmpresa.Properties.DisplayMember = "descripcion";
        //    cboEmpresa.Properties.ValueMember = "codigo";

        //    // Limpiar y configurar columnas manualmente
        //    cboEmpresa.Properties.Columns.Clear();

        //    // Agregar la columna "descripcion" y ocultar todas las demás
        //    foreach (DataColumn column in tData.Columns)
        //    {
        //        var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
        //        lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
        //        cboEmpresa.Properties.Columns.Add(lookupColumn);
        //    }

        //    // Personalizar el encabezado de la columna visible
        //    cboEmpresa.Properties.Columns["descripcion"].Caption = "Empresa";

        //    // Seleccionar el primer registro si existen filas
        //    if (tData.Rows.Count > 0)
        //    {
        //        cboEmpresa.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
        //    }

        //    // Otras opciones de personalización
        //    cboEmpresa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
        //    cboEmpresa.Properties.ShowFooter = false; // Ocultar pie de página
        //    cboEmpresa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático


        //}

        DataTable TdatosExcel;
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TdatosExcel = new DataTable();
            TdatosExcel = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, 1, 6, 11);
            if (TdatosExcel.Rows.Count == 0)
            {
                return false;
            }
            TdatosExcel.Columns.Add("tag", typeof(string));
            return true;

        }
        private void btnCarga_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataTable dataTable = new DataTable();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Seleccionar archivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        if (CargarDatosDelExcel(openFileDialog.FileName))
                        {
                            string IdCargaMasiva = HPResergerFunciones.Utilitarios.GenerarCodigoFechaHora();
                            if (TdatosExcel.Rows.Count <= 1) // Validar si hay más de una fila
                            {
                                XtraMessageBox.Show("El archivo Excel no contiene datos suficientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (XtraMessageBox.Show("Los datos se han cargado exitosamente. ¿Está seguro de que desea proceder con la carga masiva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    int i = 0;
                                    //TdatosExcel.Columns[0].ColumnName = "Tipo";
                                    for (i = 0; i < TdatosExcel.Rows.Count; i++)
                                    {
                                        DataRow item = TdatosExcel.Rows[i];
                                        if (item[0].ToString().Trim().ToUpper() == "Tipo")
                                        {
                                            break;
                                        }
                                    }
                                    //for (int j = 0; j < i; j++)
                                    //{
                                    //    TdatosExcel.Rows.RemoveAt(0);

                                    //}

                                    //if (TdatosExcel.Rows[0][0].ToString().Trim().ToUpper() == "Tipo")
                                    TdatosExcel.Rows.RemoveAt(0);

                                    TdatosExcel.Columns[0].ColumnName = "Tipo";
                                    TdatosExcel.Columns[1].ColumnName = "Det_Partida_Madre";
                                    TdatosExcel.Columns[2].ColumnName = "Cod_Partida_Madre";
                                    TdatosExcel.Columns[3].ColumnName = "Det_Sub_Partida";
                                    TdatosExcel.Columns[4].ColumnName = "Cod_Sub_Partida";

                                    foreach (DataRow item in TdatosExcel.Rows)
                                    {
                                        HPResergerCapaLogica.FlujoCaja.Partidas_Control cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();

                                        cPartidas.NTipo = item["Tipo"].ToString();
                                        cPartidas.CodigoPadre = item["Det_Partida_Madre"].ToString();
                                        cPartidas.PatidaPadre = item["Cod_Partida_Madre"].ToString();
                                        cPartidas.Codigo = item["Det_Sub_Partida"].ToString();
                                        cPartidas.Descripcion = item["Cod_Sub_Partida"].ToString();

                                        cPartidas.Tag = IdCargaMasiva;
                                        cPartidas.Tipo = Tipo;
                                        cPartidas.Cabecera = 0;
                                        cPartidas.Estado = 1;
                                        cPartidas.Insertar(cPartidas);
                                    }
                                    CargarDatos();

                                    XtraMessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    XtraMessageBox.Show($"Cancelado por el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show($"Error al leer el archivo Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al leer el archivo Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (view != null && e.RowHandle >= 0)
            {
                // Obtener el valor de la primera columna de la fila actual
                string cellValue = view.GetRowCellValue(e.RowHandle, view.Columns[1])?.ToString();

                // Validar si termina en "00"
                if (!string.IsNullOrEmpty(cellValue) && cellValue.EndsWith("00"))
                {
                    // Usar los colores predeterminados de la skin para encabezados
                    e.Appearance.Assign(view.PaintAppearance.HeaderPanel);
                    // Establecer fuente en negritas
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }


        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Empresa == 0)
            {
                XtraMessageBox.Show("Por favor, seleccione una empresa antes de continuar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                HPResergerCapaLogica.FlujoCaja.Partidas_Control cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control
                {
                    Descripcion = "Nuevo",
                    Tipo = Tipo,
                    PKempresa = Empresa
                };

                if (cPartidas.Insertar(cPartidas) == 0)
                {
                    XtraMessageBox.Show("No se pudo crear el registro. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                XtraMessageBox.Show("Registro creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //CargarEmpresas();
            CargarDatos();
        }

        private void CargarDatos()
        {
            HPResergerCapaLogica.FlujoCaja.Partidas_Control cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
            gridControl1.DataSource = cPartidas.FiltrarPorTipo(Tipo);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "id"));
            string NTipo = gridView1.GetRowCellValue(rowHandle, "NTipo").ToString();
            string CodigoPadre = (gridView1.GetRowCellValue(rowHandle, "CodigoPadre").ToString());
            string PartidaPadre = (gridView1.GetRowCellValue(rowHandle, "PatidaPadre").ToString());
            string Codigo = (gridView1.GetRowCellValue(rowHandle, "Codigo").ToString());
            string Descripcion = (gridView1.GetRowCellValue(rowHandle, "Descripcion").ToString());
            int usuario = HPReserger.frmLogin.CodigoUsuario;
            DateTime fecha = DateTime.Now;

            HPResergerCapaLogica.FlujoCaja.Partidas_Control cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();

            cPartidas.Id = id;
            cPartidas.NTipo = NTipo;
            cPartidas.CodigoPadre = CodigoPadre;
            cPartidas.PatidaPadre = PartidaPadre;
            cPartidas.Codigo = Codigo;
            cPartidas.Descripcion = Descripcion;
            cPartidas.Fecha = fecha;

            if (!cPartidas.ActualizarGrilla(cPartidas))
            {
                XtraMessageBox.Show($"Error al Actualizar el Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int idFocus = 0;
        string tagFocus = string.Empty;
        string nombreFocus = string.Empty;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Restablece valores predeterminados
            idFocus = 0;
            tagFocus = string.Empty;
            bntEliminarCargaMasiva.Enabled = false;

            // Obtén el índice de la fila seleccionada
            int focusedRowHandle = e.FocusedRowHandle;

            // Verifica si la fila es válida y contiene datos
            if (focusedRowHandle >= 0 && gridView1.IsDataRow(focusedRowHandle))
            {
                // Obtén el valor de "id" de manera segura
                object idValue = gridView1.GetRowCellValue(focusedRowHandle, "id");
                idFocus = idValue is int ? (int)idValue : 0;

                // Obtén el valor de "tag" de manera segura
                object tagValue = gridView1.GetRowCellValue(focusedRowHandle, "tag");
                object descripcionValue = gridView1.GetRowCellValue(focusedRowHandle, "Descripcion");
                tagFocus = tagValue as string ?? string.Empty;
                nombreFocus = descripcionValue as string ?? string.Empty;

                // Ajusta visibilidad si "tag" no está vacío
                if (!string.IsNullOrEmpty(tagFocus))
                {
                    bntEliminarCargaMasiva.Enabled = true;
                }
            }
        }

        private void bntEliminarCargaMasiva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(tagFocus))
            {
                HPResergerCapaLogica.FlujoCaja.Partidas_Control cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();

                var result = XtraMessageBox.Show($"¿Está seguro de que desea eliminar esta carga masiva ({tagFocus})?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    result = XtraMessageBox.Show("¿Cómo desea proceder? Sí: Eliminación física (permanente). No: Eliminación lógica (oculta).", "Confirmación de Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        cPartidas.EliminarFisicoxTag(tagFocus);
                        XtraMessageBox.Show("Eliminación física completada correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tagFocus = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        cPartidas.EliminarLogicoxTag(tagFocus);
                        XtraMessageBox.Show("Eliminación lógica completada correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tagFocus = "";
                    }
                    else
                    {
                        XtraMessageBox.Show("Operación cancelada por el usuario.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Recargar datos después de la eliminación
                    CargarDatos();
                }
                else
                {
                    XtraMessageBox.Show("Operación cancelada por el usuario.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor, seleccione un registro válido para eliminar.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarFila_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtén el índice de la fila seleccionada
            int focusedRowHandle = gridView1.FocusedRowHandle;

            // Verifica si la fila es válida y contiene datos
            if (focusedRowHandle >= 0 && gridView1.IsDataRow(focusedRowHandle))
            {
                // Obtén el valor de "id" de manera segura
                object idValue = gridView1.GetRowCellValue(focusedRowHandle, "id");
                idFocus = idValue is int ? (int)idValue : 0;

                // Obtén el valor de "tag" de manera segura
                object tagValue = gridView1.GetRowCellValue(focusedRowHandle, "tag");
                object descripcionValue = gridView1.GetRowCellValue(focusedRowHandle, "Descripcion");
                tagFocus = tagValue as string ?? string.Empty;
                nombreFocus = descripcionValue as string ?? string.Empty;
            }
            if (idFocus != 0)
            {
                var result = XtraMessageBox.Show($"¿Está seguro de eliminar esta fila ({nombreFocus})?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cPartidas = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
                    if (cPartidas.EliminarLogico(idFocus))
                    {
                        XtraMessageBox.Show("Eliminación lógica completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Operación cancelada por el usuario.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exporter = new GridExporter(gridControl1, gridView1, this.Text);
            exporter.ExportarAExcel();
        }
        public class GridExporter
        {
            private readonly GridControl _gridControl;
            private readonly GridView _gridview;
            private readonly string _appDataPath;

            private readonly string _nombre;

            public GridExporter(GridControl gridControl, GridView gridview, string name)
            {

                _gridControl = gridControl ?? throw new ArgumentNullException(nameof(gridControl));
                _gridview = gridview ?? throw new ArgumentNullException(nameof(gridview));
                _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");

                _nombre = name;

                // Crear directorio si no existe
                if (!Directory.Exists(_appDataPath))
                {
                    Directory.CreateDirectory(_appDataPath);
                }
            }
            private bool ValidarDatos()
            {
                if (_gridControl.DataSource == null || _gridControl.MainView.RowCount == 0)
                {
                    MessageBox.Show("No se puede exportar porque la grilla no contiene datos.",
                                  "Exportación cancelada",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            private void MostrarError(string mensaje)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            private void AbrirArchivo(string filePath)
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                        //MessageBox.Show($"Archivo exportado correctamente:\n{filePath}",
                        //"Éxito",
                        //                MessageBoxButtons.OK,
                        //                MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al abrir el archivo: {ex.Message}");
                }
            }

            public void ExportarAExcel()
            {
                if (!ValidarDatos())
                    return;

                string filePath = Path.Combine(_appDataPath, $"Listado de {_nombre}.xls");

                try
                {
                    var options = new XlsExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        ShowGridLines = true,
                        TextExportMode = TextExportMode.Text,
                        SheetName = $"Listado de {_nombre}",
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false,
                        DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = $"Listado de {_nombre}",
                                        Subject = $"Listado de {_nombre}"
                        }

                    };

                    // Validar si el archivo existe y está abierto
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            // Intenta abrir el archivo en modo exclusivo
                            using (var file = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                            {
                                // Si no hay excepción, el archivo no está bloqueado
                            }
                        }
                        catch (IOException)
                        {
                            // El archivo está abierto/bloqueado
                            XtraMessageBox.Show("El archivo está abierto en otro programa. Ciérrelo antes de continuar.", "Archivo en Uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Salir sin exportar
                        }
                    }
                    _gridControl.ExportToXls(filePath, options);

                    AbrirArchivo(filePath);
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al exportar a Excel: {ex.Message}");
                }
            }
        }
    }
}