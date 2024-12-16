using DevExpress.XtraEditors;
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

namespace SISGEM.ModuloActivoFijo
{
    public partial class frmActivosFijosC : XtraForm
    {
        public frmActivosFijosC()
        {
            InitializeComponent();

        }
        public int Id { get; set; } = 0;
        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RecargarCombos();
        }

        private void frmActivosFijosC_Load(object sender, EventArgs e)
        {
            RecargarCombos();

            CargarDatos();


        }
        public void CargarDatos()
        {
            if (Id != 0) //Activo Fijo Existente
            {
                lblEstado.Caption = "Activo Fijo Guardado";
                HPResergerCapaLogica.Contable.ActivosFijos cActivoFijo = new HPResergerCapaLogica.Contable.ActivosFijos();
                var oActivoFijo = cActivoFijo.GetById(Id);
                if (oActivoFijo != null)
                {
                    EmpresaIdTextEdit.Properties.ReadOnly = true;
                    TipoActivoFijoIdTextEdit.EditValue = oActivoFijo.TipoActivoFijoId;
                    CatalogoExistenciaIdTextEdit.EditValue = oActivoFijo.CatalogoExistenciaId;
                    ClasificacionIdTextEdit.EditValue = oActivoFijo.ClasificacionId;
                    CodigoExistenciaTextEdit.EditValue = oActivoFijo.CodigoExistencia;
                    CuentaActivoTextEdit.EditValue = oActivoFijo.CuentaActivo;
                    DepreciacionContableTextEdit.EditValue = oActivoFijo.DepreciacionContable;
                    DepreciacionTributariaTextEdit.EditValue = oActivoFijo.DepreciacionTributaria;
                    DescripcionTextEdit.EditValue = oActivoFijo.Descripcion;
                    EmpresaIdTextEdit.EditValue = oActivoFijo.EmpresaId;
                    EstadoTextEdit.EditValue = oActivoFijo.Estado;
                    EstadoActivoFijoIdTextEdit.EditValue = oActivoFijo.EstadoActivoFijoId;
                    FechaAdquisicionDateEdit.EditValue = oActivoFijo.FechaAdquisicion;
                    FechaAltaDateEdit.EditValue = oActivoFijo.FechaAlta;
                    IdTextEdit.EditValue = oActivoFijo.Id;
                    LE_FechaDateEdit.EditValue = oActivoFijo.LE_Fecha;
                    LE_FechaInicioDateEdit.EditValue = oActivoFijo.LE_FechaInicio;
                    LE_MontoTotalTextEdit.EditValue = oActivoFijo.LE_MontoTotal;
                    LE_NumeroContratoTextEdit.EditValue = oActivoFijo.LE_NumeroContrato;
                    LE_NumeroCuotasTextEdit.EditValue = oActivoFijo.LE_NumeroCuotas;
                    MarcaTextEdit.EditValue = oActivoFijo.Marca;
                    MetodoDepreciacionIdTextEdit.EditValue = oActivoFijo.MetodoDepreciacionId;
                    ModeloTextEdit.EditValue = oActivoFijo.Modelo;
                    NumeroSerieTextEdit.EditValue = oActivoFijo.NumeroSerie;
                    TipoActivoIdTextEdit.EditValue = oActivoFijo.TipoActivoId;
                    ValorActivoTextEdit.EditValue = oActivoFijo.ValorActivo;
                    ValorResidualTextEdit.EditValue = oActivoFijo.ValorResidual;
                    CodigoTextEdit.EditValue = oActivoFijo.Codigo;
                }
                else
                {
                    EmpresaIdTextEdit.Properties.ReadOnly = false;

                    XtraMessageBox.Show("No se Encontro el Activo Fijo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblEstado.Caption = "Activo Fijo NO Encontrado";
                }


            }
            else  //Activo Fijo Nuevo
            {
                lblEstado.Caption = "Activo Fijo Nuevo";
                EmpresaIdTextEdit.Properties.ReadOnly = false;
                EstadoTextEdit.EditValue = 1;


            }
        }




        public void RecargarCombos()
        {
            //EMPRESA
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            DataTable dt = CapaLogica.ListarEmpresas();
            EmpresaIdTextEdit.Properties.DataSource = dt;
            EmpresaIdTextEdit.Properties.ValueMember = "Id_Empresa";
            EmpresaIdTextEdit.Properties.DisplayMember = "Empresa";
            //VISTAS
            EmpresaIdTextEdit.Properties.View.Columns.Clear();
            EmpresaIdTextEdit.Properties.View.Columns.AddVisible("RUC", "RUC");
            EmpresaIdTextEdit.Properties.View.Columns.AddVisible("Empresa", "Empresa");
            EmpresaIdTextEdit.Properties.View.Columns[0].MaxWidth = 100;

            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (EmpresaIdTextEdit.EditValue == null && dt.Rows.Count > 0)
                EmpresaIdTextEdit.EditValue = dt.Rows[0]["Id_Empresa"];

            //TIPOS DE ACTIVOS FIJOS
            HPResergerCapaLogica.TiposActivoFijos CtipoACtivos = new HPResergerCapaLogica.TiposActivoFijos();
            DataTable TTiposAc = CtipoACtivos.GetAll();

            TipoActivoIdTextEdit.Properties.DataSource = TTiposAc;
            TipoActivoIdTextEdit.Properties.ValueMember = "pkid";
            TipoActivoIdTextEdit.Properties.DisplayMember = "Nombre";
            //VISTAS
            TipoActivoIdTextEdit.Properties.View.Columns.Clear();
            TipoActivoIdTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre");


            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (TipoActivoIdTextEdit.EditValue == null && TTiposAc.Rows.Count > 0)
                TipoActivoIdTextEdit.EditValue = TTiposAc.Rows[0]["pkid"];

            //Tipo de Depreciación
            HPResergerCapaLogica.T20MetodoDepreciacion oTipoDepreciacion = new HPResergerCapaLogica.T20MetodoDepreciacion();
            DataTable TTipoDepreciacion = oTipoDepreciacion.GetAll();

            MetodoDepreciacionIdTextEdit.Properties.DataSource = TTipoDepreciacion;
            MetodoDepreciacionIdTextEdit.Properties.ValueMember = "pkid";
            MetodoDepreciacionIdTextEdit.Properties.DisplayMember = "Nombre";
            //VISTAS
            MetodoDepreciacionIdTextEdit.Properties.View.Columns.Clear();
            MetodoDepreciacionIdTextEdit.Properties.View.Columns.AddVisible("idS", "Id Sunat");
            MetodoDepreciacionIdTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre");
            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (MetodoDepreciacionIdTextEdit.EditValue == null && TTipoDepreciacion.Rows.Count > 0)
                MetodoDepreciacionIdTextEdit.EditValue = TTipoDepreciacion.Rows[0]["pkid"];


            //Catalogo Existencia - Tabla 13
            HPResergerCapaLogica.CatalogoExistencias ocatalogo = new HPResergerCapaLogica.CatalogoExistencias();
            DataTable tCatalogo = ocatalogo.GetAll();

            CatalogoExistenciaIdTextEdit.Properties.DataSource = tCatalogo;
            CatalogoExistenciaIdTextEdit.Properties.ValueMember = "pkid";
            CatalogoExistenciaIdTextEdit.Properties.DisplayMember = "Nombre";
            //VISTAS
            CatalogoExistenciaIdTextEdit.Properties.View.Columns.Clear();
            CatalogoExistenciaIdTextEdit.Properties.View.Columns.AddVisible("idS", "Id Sunat");
            CatalogoExistenciaIdTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre");
            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (CatalogoExistenciaIdTextEdit.EditValue == null && tCatalogo.Rows.Count > 0)
                CatalogoExistenciaIdTextEdit.EditValue = tCatalogo.Rows[0]["pkid"];


            //Tipo Activo Fijo - Tabla 18
            HPResergerCapaLogica.T18TipoActivoFijo ot18tipoactivofijo = new HPResergerCapaLogica.T18TipoActivoFijo();
            DataTable TT18Activofijo = ot18tipoactivofijo.GetAll();

            TipoActivoFijoIdTextEdit.Properties.DataSource = TT18Activofijo;
            TipoActivoFijoIdTextEdit.Properties.ValueMember = "pkid";
            TipoActivoFijoIdTextEdit.Properties.DisplayMember = "Nombre";
            //VISTAS
            TipoActivoFijoIdTextEdit.Properties.View.Columns.Clear();
            TipoActivoFijoIdTextEdit.Properties.View.Columns.AddVisible("idS", "Id Sunat");
            TipoActivoFijoIdTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre");
            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (TipoActivoFijoIdTextEdit.EditValue == null && TT18Activofijo.Rows.Count > 0)
                TipoActivoFijoIdTextEdit.EditValue = TT18Activofijo.Rows[0]["pkid"];


            //Estado Activo Fijo - Tabla 19
            HPResergerCapaLogica.T19EstadoActivoFijo ot19tipoactivofijo = new HPResergerCapaLogica.T19EstadoActivoFijo();
            DataTable TT19Activofijo = ot19tipoactivofijo.GetAll();

            EstadoActivoFijoIdTextEdit.Properties.DataSource = TT19Activofijo;
            EstadoActivoFijoIdTextEdit.Properties.ValueMember = "pkid";
            EstadoActivoFijoIdTextEdit.Properties.DisplayMember = "Nombre";
            //VISTAS
            EstadoActivoFijoIdTextEdit.Properties.View.Columns.Clear();
            EstadoActivoFijoIdTextEdit.Properties.View.Columns.AddVisible("idS", "Id Sunat");
            EstadoActivoFijoIdTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre");
            // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
            if (EstadoActivoFijoIdTextEdit.EditValue == null && TT19Activofijo.Rows.Count > 0)
                EstadoActivoFijoIdTextEdit.EditValue = TT19Activofijo.Rows[0]["pkid"];
        }

        private void TipoActivoIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            layoutControlGroup5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            if (TipoActivoIdTextEdit.EditValue != null)
            {

                //TIPOS DE ACTIVOS FIJOS
                HPResergerCapaLogica.SubTiposActivoFijos cSubTipo = new HPResergerCapaLogica.SubTiposActivoFijos();
                DataTable TcSubTipo = cSubTipo.GetAllxTipo((int)TipoActivoIdTextEdit.EditValue);

                ClasificacionIdTextEdit.Properties.DataSource = TcSubTipo;
                ClasificacionIdTextEdit.Properties.ValueMember = "pkid";
                ClasificacionIdTextEdit.Properties.DisplayMember = "Descripcion";
                //VISTAS
                ClasificacionIdTextEdit.Properties.View.Columns.Clear();
                ClasificacionIdTextEdit.Properties.View.Columns.AddVisible("Descripcion", "Descripcion");
                ClasificacionIdTextEdit.Properties.View.Columns.AddVisible("Abreviatura", "Abreviatura");

                // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
                if (TcSubTipo.Rows.Count > 0)
                    ClasificacionIdTextEdit.EditValue = TcSubTipo.Rows[0]["pkid"];
                else ClasificacionIdTextEdit.EditValue = null;

                //Cuenta de Activo Fijo
                HPResergerCapaLogica.TiposActivoFijos CtipoACtivos = new HPResergerCapaLogica.TiposActivoFijos();
                DataTable TTiposAc = CtipoACtivos.GetAllCuentasContables((int)TipoActivoIdTextEdit.EditValue);

                CuentaActivoTextEdit.Properties.DataSource = TTiposAc;
                CuentaActivoTextEdit.Properties.ValueMember = "Id_Cuenta_Contable";
                CuentaActivoTextEdit.Properties.DisplayMember = "Cuenta_Contable";
                //VISTAS
                CuentaActivoTextEdit.Properties.View.Columns.Clear();
                CuentaActivoTextEdit.Properties.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable");

                // Seleccionar el primer ítem como valor inicial si no hay ningún valor seleccionado
                if (TTiposAc.Rows.Count > 0)
                    CuentaActivoTextEdit.EditValue = TTiposAc.Rows[0]["Id_Cuenta_Contable"];


                if (TipoActivoIdTextEdit.Text.Contains("LEASING"))
                {
                    layoutControlGroup5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }

            }
        }
        public void GenerarCodigoActivo()
        {
            CodigoTextEdit.EditValue = $"{ClasificacionAbreviatura}-{EmpresaAbreviatura}-0000";
            CodigoTextEdit.Properties.ReadOnly = true;
            //CodigoExistenciaTextEdit.Refresh();
        }
        public void GenerarCodigoActivoNuevo()
        {
            HPResergerCapaLogica.Contable.ActivosFijos cActivos = new HPResergerCapaLogica.Contable.ActivosFijos();
            var tdata = cActivos.GetAll((int)EmpresaIdTextEdit.EditValue);

            CodigoTextEdit.EditValue = $"{ClasificacionAbreviatura}-{EmpresaAbreviatura}-{(tdata.Rows.Count + 1).ToString("0000")}";
            CodigoTextEdit.Properties.ReadOnly = true;
            //CodigoExistenciaTextEdit.Refresh();
        }
        public string EmpresaAbreviatura { get; set; } = "";
        public string ClasificacionAbreviatura { get; set; } = "";
        private void EmpresaIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (EmpresaIdTextEdit.EditValue != null)
            {
                //CUANDO ESTA LLENO, SACAMOS EL NOMBRE REDUCIDO
                HPResergerCapaLogica.Contable.EmpresaAbreviatura CapaLogica = new HPResergerCapaLogica.Contable.EmpresaAbreviatura();
                var oEmpresa = CapaLogica.GetById((int)EmpresaIdTextEdit.EditValue);
                EmpresaAbreviatura = oEmpresa != null ? oEmpresa.Abreviatura ?? "" : "";
            }
            else EmpresaAbreviatura = "";
            GenerarCodigoActivo();
        }

        private void ClasificacionIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ClasificacionIdTextEdit.EditValue != null)
            {
                //si esto esta lleno,  PORCENTAJE DEPRECIACION 
                HPResergerCapaLogica.SubTiposActivoFijos CTipos = new HPResergerCapaLogica.SubTiposActivoFijos();
                var otipo = CTipos.GetById((int)ClasificacionIdTextEdit.EditValue);
                ClasificacionAbreviatura = otipo.Abreviatura;
                DepreciacionContableTextEdit.EditValue = otipo.PorcentajeDepreciacion;
                DepreciacionTributariaTextEdit.EditValue = otipo.PorcentajeDepreciacion;
            }
            else
                ClasificacionAbreviatura = "";
            GenerarCodigoActivo();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Id = 0;
            CargarDatos();
        }
        // Métodos auxiliares para conversiones seguras
        private int ConvertToInt(object value) => value != null ? Convert.ToInt32(value) : 0;
        private string ConvertToString(object value) => value?.ToString() ?? string.Empty;
        private decimal ConvertToDecimal(object value) => value != null ? Convert.ToDecimal(value) : 0;
        private DateTime ConvertToDateTime(object value) => value != null ? Convert.ToDateTime(value) : DateTime.MinValue;

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var resultado = XtraMessageBox.Show("¿Está seguro de que desea guardar el activo fijo?", "Confirmación de Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    HPResergerCapaLogica.Contable.ActivosFijos cActivoFijo = new HPResergerCapaLogica.Contable.ActivosFijos();
                    var oActivoFijo = new HPResergerCapaLogica.Contable.ActivosFijos.oActivoFijo();

                    // Asignaciones de los controles al objeto con validaciones
                    oActivoFijo.CatalogoExistenciaId = ConvertToInt(CatalogoExistenciaIdTextEdit.EditValue);
                    oActivoFijo.ClasificacionId = ConvertToInt(ClasificacionIdTextEdit.EditValue);
                    oActivoFijo.Codigo = ConvertToString(CodigoTextEdit.EditValue);
                    oActivoFijo.CodigoExistencia = ConvertToString(CodigoExistenciaTextEdit.EditValue);
                    oActivoFijo.CuentaActivo = ConvertToString(CuentaActivoTextEdit.EditValue);
                    oActivoFijo.DepreciacionContable = ConvertToDecimal(DepreciacionContableTextEdit.EditValue);
                    oActivoFijo.DepreciacionTributaria = ConvertToDecimal(DepreciacionTributariaTextEdit.EditValue);
                    oActivoFijo.Descripcion = ConvertToString(DescripcionTextEdit.EditValue);
                    oActivoFijo.EmpresaId = ConvertToInt(EmpresaIdTextEdit.EditValue);
                    oActivoFijo.Estado = ConvertToInt(EstadoTextEdit.EditValue);
                    oActivoFijo.EstadoActivoFijoId = ConvertToInt(EstadoActivoFijoIdTextEdit.EditValue);
                    oActivoFijo.FechaAdquisicion = ConvertToDateTime(FechaAdquisicionDateEdit.EditValue);
                    oActivoFijo.FechaAlta = ConvertToDateTime(FechaAltaDateEdit.EditValue);
                    oActivoFijo.Id = ConvertToInt(IdTextEdit.EditValue);
                    oActivoFijo.LE_Fecha = ConvertToDateTime(LE_FechaDateEdit.EditValue);
                    oActivoFijo.LE_FechaInicio = ConvertToDateTime(LE_FechaInicioDateEdit.EditValue);
                    oActivoFijo.LE_MontoTotal = ConvertToDecimal(LE_MontoTotalTextEdit.EditValue);
                    oActivoFijo.LE_NumeroContrato = ConvertToInt(LE_NumeroContratoTextEdit.EditValue);
                    oActivoFijo.LE_NumeroCuotas = ConvertToInt(LE_NumeroCuotasTextEdit.EditValue);
                    oActivoFijo.Marca = ConvertToString(MarcaTextEdit.EditValue);
                    oActivoFijo.MetodoDepreciacionId = ConvertToInt(MetodoDepreciacionIdTextEdit.EditValue);
                    oActivoFijo.Modelo = ConvertToString(ModeloTextEdit.EditValue);
                    oActivoFijo.NumeroSerie = ConvertToString(NumeroSerieTextEdit.EditValue);
                    oActivoFijo.TipoActivoFijoId = ConvertToInt(TipoActivoFijoIdTextEdit.EditValue);
                    oActivoFijo.TipoActivoId = ConvertToInt(TipoActivoIdTextEdit.EditValue);
                    oActivoFijo.ValorActivo = ConvertToDecimal(ValorActivoTextEdit.EditValue);
                    oActivoFijo.ValorResidual = ConvertToDecimal(ValorResidualTextEdit.EditValue);

                    // Guardar o actualizar el activo fijo
                    bool resultadoOperacion;
                    int resultadoOperacions = 0;

                    if (Id == 0)
                    {
                        GenerarCodigoActivoNuevo();
                        oActivoFijo.Codigo = ConvertToString(CodigoTextEdit.EditValue);
                        resultadoOperacions = cActivoFijo.Insert(oActivoFijo);
                        // Mostrar mensaje según el resultado
                        if (resultadoOperacions != 0)
                        {
                            XtraMessageBox.Show("El activo fijo se guardó correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Id = resultadoOperacions;
                            CargarDatos();
                        }
                        else
                        {
                            XtraMessageBox.Show("Ocurrió un error al guardar el activo fijo.", "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        string[] partes = oActivoFijo.Codigo.Split('-');
                        // Validar y extraer la última parte
                        if (partes.Length == 3 && int.TryParse(partes[2], out int numero))
                        {
                          if (numero == 0)
                            {
                                GenerarCodigoActivoNuevo();
                                oActivoFijo.Codigo = ConvertToString(CodigoTextEdit.EditValue);
                            }
                        }
                        resultadoOperacion = cActivoFijo.Update(oActivoFijo);
                        // Mostrar mensaje según el resultado
                        if (resultadoOperacion)
                        {
                            XtraMessageBox.Show("El activo fijo se guardó correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show(
                                "Ocurrió un error al guardar el activo fijo.", "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error
                            );
                        }
                    }


                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(
                        $"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("La operación fue cancelada por el usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bntFormatoCargaMasiva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string archivoOrigen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ModuloActivoFijo", "FORMATO CARGA ACTIVOS FIJOS.xlsx");
            if (!File.Exists(archivoOrigen))
            {
                XtraMessageBox.Show("El archivo de origen no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "FORMATO CARGA ACTIVOS FIJOS.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaDestino = saveFileDialog.FileName;

                    try
                    {
                        File.Copy(archivoOrigen, rutaDestino, true);
                        XtraMessageBox.Show("El archivo se exportó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir el archivo exportado
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = rutaDestino,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al exportar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("La operación fue cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        DataTable TdatosExcel;
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TdatosExcel = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, 1, 6, 11);
            if (TdatosExcel.Rows.Count == 0)
            {
                return false;
            }
            return true;

        }
        private void btnCargaMasiva_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                            if (TdatosExcel.Rows.Count <= 1) // Validar si hay más de una fila
                            {
                                XtraMessageBox.Show("El archivo Excel no contiene datos suficientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (XtraMessageBox.Show("Los datos se han cargado exitosamente. ¿Está seguro de que desea proceder con la carga de los activos fijos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {

                                    foreach (DataRow fila in TdatosExcel.Rows)
                                    {
                                        if (!(fila[0] == DBNull.Value || string.IsNullOrWhiteSpace(fila[0].ToString())))
                                        {
                                            if (int.TryParse(fila[0]?.ToString() ?? string.Empty, out int agua))
                                            {
                                                //MessageBox.Show("Se encontró una fila con la primera columna vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                //break;
                                                HPResergerCapaLogica.Contable.ActivosFijos cActivoFijo = new HPResergerCapaLogica.Contable.ActivosFijos();
                                                var oActivoFijo = new HPResergerCapaLogica.Contable.ActivosFijos.oActivoFijo();

                                                // Asignaciones de los controles al objeto con validaciones
                                                oActivoFijo.EmpresaId = ConvertToInt(fila["Column0"]);
                                                oActivoFijo.Codigo = ConvertToString(fila["Column1"]);
                                                oActivoFijo.TipoActivoId = ConvertToInt(fila["Column2"]);
                                                oActivoFijo.ClasificacionId = ConvertToInt(fila["Column3"]);
                                                oActivoFijo.MetodoDepreciacionId = ConvertToInt(fila["Column4"]);
                                                oActivoFijo.ValorActivo = ConvertToDecimal(fila["Column5"]);
                                                oActivoFijo.ValorResidual = ConvertToDecimal(fila["Column6"]);
                                                oActivoFijo.DepreciacionContable = ConvertToDecimal(fila["Column7"]);
                                                oActivoFijo.DepreciacionTributaria = ConvertToDecimal(fila["Column8"]);
                                                oActivoFijo.FechaAdquisicion = ConvertToDateTime(fila["Column9"]);
                                                oActivoFijo.FechaAlta = ConvertToDateTime(fila["Column10"]);
                                                oActivoFijo.Marca = ConvertToString(fila["Column11"]);
                                                oActivoFijo.Modelo = ConvertToString(fila["Column12"]);
                                                oActivoFijo.NumeroSerie = ConvertToString(fila["Column13"]);
                                                oActivoFijo.CuentaActivo = ConvertToString(fila["Column14"]);
                                                oActivoFijo.Descripcion = ConvertToString(fila["Column15"]);
                                                oActivoFijo.CatalogoExistenciaId = ConvertToInt(fila["Column16"]);
                                                oActivoFijo.CodigoExistencia = ConvertToString(fila["Column17"]);
                                                oActivoFijo.TipoActivoFijoId = ConvertToInt(fila["Column18"]);
                                                oActivoFijo.EstadoActivoFijoId = ConvertToInt(fila["Column19"]);
                                                oActivoFijo.LE_Fecha = ConvertToDateTime(fila["Column20"]);
                                                oActivoFijo.LE_NumeroContrato = ConvertToInt(fila["Column21"]);
                                                oActivoFijo.LE_FechaInicio = ConvertToDateTime(fila["Column22"]);
                                                oActivoFijo.LE_NumeroCuotas = ConvertToInt(fila["Column23"]);
                                                oActivoFijo.LE_MontoTotal = ConvertToDecimal(fila["Column24"]);
                                                oActivoFijo.Estado = ConvertToInt(fila["Column25"]);

                                                cActivoFijo.Insert(oActivoFijo);
                                            }
                                        }
                                    }

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

        private void btndesproteger_Click(object sender, EventArgs e)
        {
            CodigoTextEdit.Properties.ReadOnly = false;
        }
    }
}