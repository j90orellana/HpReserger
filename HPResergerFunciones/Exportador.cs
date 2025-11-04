using OfficeOpenXml;
using System;
using System.Data;
using System.IO;

namespace HPResergerFunciones
{
    public class Exportador
    {
        public static void RecorrerExcel(string ruta, string NombreReporte = "Reporte")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var fileInfo = new FileInfo(ruta);


            using (var package = new ExcelPackage(new FileInfo(ruta)))
            {
                var ws = package.Workbook.Worksheets[0]; // primera hoja
                int ultimaColumna = ws.Dimension.End.Column;

                for (int col = 1; col <= ultimaColumna; col++) // Columna D = 4
                {
                    var valor = ws.Cells[1, col].Text; // fila 1
                    if (valor != "")
                    {
                        ws.Column(col).OutlineLevel = 1; // Columna A
                        ws.Column(col + 1).OutlineLevel = 1; // Columna B
                        ws.Column(col + 2).OutlineLevel = 1; // Columna C
                        ws.Column(col + 3).OutlineLevel = 1; // Columna C

                        // COLAPSAR EL GRUPO
                        ws.Column(col).Collapsed = true;
                        ws.Column(col + 1).Collapsed = true;
                        ws.Column(col + 2).Collapsed = true;
                        ws.Column(col + 3).Collapsed = true;

                        col += 4;
                    }
                    else
                    {
                        ws.View.FreezePanes(1, col + 1);                        
                    }
                }

                // Configurar para que los botones de agrupación estén arriba
                ws.OutLineSummaryBelow = false;

                package.Save();
            }
        }


        public static void ExportarConAgrupacion(DataTable dt, string ruta, string NombreReporte = "Reporte")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add(NombreReporte);

                // Cargar DataTable desde A1
                ws.Cells["A1"].LoadFromDataTable(dt, true);

                // Suponemos que la primera columna (columna A = índice 1) es la fecha
                int totalFilas = dt.Rows.Count;
                int filaInicio = 2; // La fila 1 es cabecera en Excel
                DateTime fechaActual = Convert.ToDateTime(dt.Rows[0][0]);
                int filaGrupoInicio = filaInicio;

                for (int i = 1; i < totalFilas; i++)
                {
                    DateTime fecha = Convert.ToDateTime(dt.Rows[i][0]);

                    if (fecha != fechaActual)
                    {
                        // Agrupar las filas con la misma fecha
                        if (filaGrupoInicio < filaInicio + i - 1)
                        {
                            ws.Row(filaGrupoInicio).OutlineLevel = 1;
                            for (int f = filaGrupoInicio + 1; f < filaInicio + i; f++)
                                ws.Row(f).OutlineLevel = 1;

                            ws.Row(filaGrupoInicio).Collapsed = true;
                        }

                        // Nueva fecha → actualizar
                        fechaActual = fecha;
                        filaGrupoInicio = filaInicio + i;
                    }
                }

                // Agrupar el último bloque si es necesario
                if (filaGrupoInicio < totalFilas + 1)
                {
                    ws.Row(filaGrupoInicio).OutlineLevel = 1;
                    for (int f = filaGrupoInicio + 1; f <= totalFilas + 1; f++)
                        ws.Row(f).OutlineLevel = 1;

                    ws.Row(filaGrupoInicio).Collapsed = true;
                }

                // Guardar archivo
                File.WriteAllBytes(ruta, package.GetAsByteArray());
            }
        }
    }
}
