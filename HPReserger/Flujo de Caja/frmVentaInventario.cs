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

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmVentaInventario : XtraForm
    {
        public frmVentaInventario()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                            if (TdatosExcel.Rows.Count <= 1) // Validar si hay más de una fila
                            {
                                XtraMessageBox.Show("El archivo Excel no contiene datos suficientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (XtraMessageBox.Show("Los datos se han cargado exitosamente. ¿Está seguro de que desea proceder con la carga de los activos fijos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    int i = 0;
                                    for (i = 0; i < TdatosExcel.Rows.Count; i++)
                                    {
                                        DataRow item = TdatosExcel.Rows[i];
                                        if (item[0].ToString().Trim().ToUpper() == "PROYECTO")
                                        {
                                            break;
                                        }
                                    }
                                    for (int j = 0; j < i; j++)
                                    {
                                        TdatosExcel.Rows.RemoveAt(0);

                                    }

                                    if (TdatosExcel.Rows[0][0].ToString().Trim().ToUpper() == "PROYECTO")
                                        TdatosExcel.Rows.RemoveAt(0);

                                    TdatosExcel.Columns[0].ColumnName = "Proyecto";
                                    TdatosExcel.Columns[1].ColumnName = "Etapa";
                                    TdatosExcel.Columns[2].ColumnName = "Manzana";
                                    TdatosExcel.Columns[3].ColumnName = "Tipo";
                                    TdatosExcel.Columns[4].ColumnName = "Cantidad";
                                    TdatosExcel.Columns[5].ColumnName = "Uso";
                                    TdatosExcel.Columns[6].ColumnName = "AreaOcupadaVendible";
                                    TdatosExcel.Columns[7].ColumnName = "AreaEmpinada";
                                    TdatosExcel.Columns[8].ColumnName = "PrecioVentaSinEstacionamiento";
                                    TdatosExcel.Columns[9].ColumnName = "PrecioPorMetroCuadradoSinEstacionamiento";
                                    TdatosExcel.Columns[10].ColumnName = "AreaOcupadaTotal";
                                    TdatosExcel.Columns[11].ColumnName = "ListaPreciosRegular";
                                    TdatosExcel.Columns[12].ColumnName = "ListaPreciosFeria";
                                    TdatosExcel.Columns[13].ColumnName = "ListaPreciosInversionistas";
                                    TdatosExcel.Columns[14].ColumnName = "Estatus";
                                    TdatosExcel.Columns[15].ColumnName = "Comentario";
                                    TdatosExcel.Columns[16].ColumnName = "Ubicacion";
                                    TdatosExcel.Columns[17].ColumnName = "Forma";
                                    TdatosExcel.Columns[18].ColumnName = "Tamaño";
                                    TdatosExcel.Columns[19].ColumnName = "FactorUbicacion";
                                    TdatosExcel.Columns[20].ColumnName = "FactorForma";
                                    TdatosExcel.Columns[21].ColumnName = "FactorTamaño";

                                    string filterExpression = "Proyecto IS NOT NULL AND Proyecto <> '' AND " +
                              "Etapa IS NOT NULL AND " +
                              "Manzana IS NOT NULL AND Manzana <> '' AND " +
                              "Tipo IS NOT NULL";

                                    DataView dv = new DataView(TdatosExcel);
                                    dv.RowFilter = filterExpression;

                                    // Opcional: convertir el DataView filtrado nuevamente a DataTable
                                    DataTable filteredTable = dv.ToTable();


                                    HPResergerCapaLogica.FlujoCaja.InventarioVentas CInventario = new HPResergerCapaLogica.FlujoCaja.InventarioVentas();
                                    foreach (DataRow item in filteredTable.Rows)
                                    {
                                        HPResergerCapaLogica.FlujoCaja.InventarioVentas inventario = new HPResergerCapaLogica.FlujoCaja.InventarioVentas
                                        {
                                            Proyecto = item["Proyecto"].ToString(),
                                            Etapa = Convert.ToInt32(item["Etapa"]),
                                            Manzana = item["Manzana"].ToString(),
                                            Tipo = Convert.ToInt32(item["Tipo"]),
                                            Cantidad = Convert.ToInt32(item["Cantidad"]),
                                            Uso = item["Uso"].ToString(),
                                            AreaOcupadaVendible = Convert.ToDecimal(item["AreaOcupadaVendible"]),
                                            AreaEmpinada = item.IsNull("AreaEmpinada") ? (decimal?)null : Convert.ToDecimal(item["AreaEmpinada"]),
                                            PrecioVentaSinEstacionamiento = Convert.ToDecimal(item["PrecioVentaSinEstacionamiento"]),
                                            PrecioPorMetroCuadradoSinEstacionamiento = Convert.ToDecimal(item["PrecioPorMetroCuadradoSinEstacionamiento"]),
                                            AreaOcupadaTotal = Convert.ToDecimal(item["AreaOcupadaTotal"]),
                                            ListaPreciosRegular = Convert.ToDecimal(item["ListaPreciosRegular"]),
                                            ListaPreciosFeria = Convert.ToDecimal(item["ListaPreciosFeria"]),
                                            ListaPreciosInversionistas = Convert.ToDecimal(item["ListaPreciosInversionistas"]),
                                            Estatus = item["Estatus"].ToString(),
                                            Comentario = item.IsNull("Comentario") ? null : item["Comentario"].ToString(),
                                            Ubicacion = item.IsNull("Ubicacion") ? null : item["Ubicacion"].ToString(),
                                            Forma = item.IsNull("Forma") ? null : item["Forma"].ToString(),
                                            Tamaño = item.IsNull("Tamaño") ? null : item["Tamaño"].ToString(),
                                            FactorUbicacion = Convert.ToDecimal(item["FactorUbicacion"]),
                                            FactorForma = Convert.ToDecimal(item["FactorForma"]),
                                            FactorTamaño = Convert.ToDecimal(item["FactorTamaño"])
                                        };

                                        CInventario.Insertar(inventario);
                                    }

                                    CargarDatos();
                                    // Opcional: Ajustar el ancho de las columnas según su contenido
                                    gridView1.BestFitColumns();

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

        private void frmVentaInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar EstatusInventario
            HPResergerCapaLogica.FlujoCaja.EstatusInventario cInventario = new HPResergerCapaLogica.FlujoCaja.EstatusInventario();
            DataTable tinventario = cInventario.ObtenerTodos();

            // Configurar el repositoryItemSearchLookUpEdit1
            repositoryItemSearchLookUpEdit1.DataSource = tinventario;
            repositoryItemSearchLookUpEdit1.ValueMember = "IdEstatusInventario";
            repositoryItemSearchLookUpEdit1.DisplayMember = "Estatus";

            // Configurar las columnas de la vista
            repositoryItemSearchLookUpEdit1.View.Columns.Clear();

            var columnCodigo = repositoryItemSearchLookUpEdit1.View.Columns.AddVisible("IdEstatusInventario", "Código");
            columnCodigo.Width = 20; // Ancho de la columna en píxeles
            var columnEstatus = repositoryItemSearchLookUpEdit1.View.Columns.AddVisible("Estatus", "Estatus");
            columnEstatus.Width = 60; // Puedes ajustar el ancho según tu preferencia

            repositoryItemSearchLookUpEdit1.View.Columns.AddVisible("Descripcion", "Descripción");
            //repositoryItemSearchLookUpEdit1.View.BestFitColumns();
            //repositoryItemSearchLookUpEdit1View.BestFitColumns();

            // Si necesitas establecer un valor predeterminado, debes hacerlo en el control asociado.
            // Ejemplo (si el control es un GridView):
            if (tinventario.Rows.Count > 0)
            {
                gridView1.SetRowCellValue(0, "IdEstatusInventario", tinventario.Rows[0]["IdEstatusInventario"]);
            }

            // Cargar datos en el gridControl1
            HPResergerCapaLogica.FlujoCaja.InventarioVentas cInventarioVentas = new HPResergerCapaLogica.FlujoCaja.InventarioVentas();
            gridControl1.DataSource = cInventarioVentas.ObtenerTodos();

            // Ajustar las columnas del GridView
            gridView1.BestFitColumns();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            var item = gridView1.GetRow(rowHandle) as HPResergerCapaLogica.FlujoCaja.InventarioVentas; // Convertir la fila al tipo InventarioVentas

            if (item != null) // Validar que la fila no sea nula
            {
                // Crear instancia de la clase InventarioVentas con los valores de 'item'
                HPResergerCapaLogica.FlujoCaja.InventarioVentas inventario = new HPResergerCapaLogica.FlujoCaja.InventarioVentas
                {
                    Id = item.Id,
                    Proyecto = item.Proyecto,
                    Etapa = item.Etapa,
                    Manzana = item.Manzana,
                    Tipo = item.Tipo,
                    Cantidad = item.Cantidad,
                    Uso = item.Uso,
                    AreaOcupadaVendible = item.AreaOcupadaVendible,
                    AreaEmpinada = item.AreaEmpinada,
                    PrecioVentaSinEstacionamiento = item.PrecioVentaSinEstacionamiento,
                    PrecioPorMetroCuadradoSinEstacionamiento = item.PrecioPorMetroCuadradoSinEstacionamiento,
                    AreaOcupadaTotal = item.AreaOcupadaTotal,
                    ListaPreciosRegular = item.ListaPreciosRegular,
                    ListaPreciosFeria = item.ListaPreciosFeria,
                    ListaPreciosInversionistas = item.ListaPreciosInversionistas,
                    Estatus = item.Estatus,
                    Comentario = item.Comentario,
                    Ubicacion = item.Ubicacion,
                    Forma = item.Forma,
                    Tamaño = item.Tamaño,
                    FactorUbicacion = item.FactorUbicacion,
                    FactorForma = item.FactorForma,
                    FactorTamaño = item.FactorTamaño
                };

                // Aquí puedes realizar la lógica que necesites con el objeto 'inventario'
                if (!inventario.Actualizar(inventario))
                {
                    XtraMessageBox.Show("Error al actualizar el inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("No se pudo obtener la fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
