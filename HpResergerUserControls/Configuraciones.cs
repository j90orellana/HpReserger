﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public class Configuraciones
    {
        //LISTADO DE APIS
        public static string PaginaTCSunat = "https://e-consulta.sunat.gob.pe/cl-at-ittipcam/tcS01Alias";
        public static string APITcDiario = "https://api.apis.net.pe/v1/tipo-cambio-sunat?fecha="; //se usa de Respaldo diario //año-mes-dia
        //public static string ApiTCSunat = "https://api.sunat.online/cambio/";//Indicar el AÑo despues del slash
        //public static string ApiTCSunat = "https://dni.optimizeperu.com/api/prod/tipo-cambio";//Indicar el AÑo despues del slash      
        public static string ApiTCSunat = "https://api.apis.net.pe/v1/tipo-cambio-sunat?";// year=2021&month=6
        public static string ApiRuc = "https://api.apis.net.pe/v1/ruc?numero=";
        public static string ApiReniec = "https://api.apis.net.pe/v1/dni?numero=";
        //FIN APIS
        public static string ApiRUCToken = "https://dniruc.apisperu.com/api/v1/ruc/";

        public static void CambiarReadOnlyGrilla(Dtgconten dtgconten, bool v, params DataGridViewTextBoxColumn[] xEmpresaOrigen)
        {
            foreach (DataGridViewTextBoxColumn item in xEmpresaOrigen)
            {
                dtgconten.Columns[item.Name].ReadOnly = v;
            }
        }
        public static string APiReniecToken = "https://dniruc.apisperu.com/api/v1/dni/";
        public static string Token = "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imo5MG9yZWxsYW5hdmVnYUBnbWFpbC5jb20ifQ.G81KqiFUZjYrdcr_87qt-Nu52L24zdGGUHOLzhXywHs";
        //COLORES POR DEFECTO
        public static Color ColordeEnabledReadOnly = Color.FromArgb(204, 218, 231);
        ///COLORES DE GRILLAS
        public static Color ColorBien = Color.FromArgb(0, 0, 192);
        public static Color ColorPrecaucion = Color.FromArgb(192, 0, 0);
        public static Color ColorBienSeleccionadas = Color.FromArgb(0, 0, 170);
        public static Color ColorPrecaucionSeleccionadas = Color.FromArgb(170, 0, 0);
        public static Color BackAlterno = Color.FromArgb(220, 230, 241);
        public static Color ForeAlterno = Color.Black;
        public static Color BackColumna = Color.FromArgb(78, 129, 189);
        public static Color ForeColumna = Color.White;
        public static Color ColorFilaSeleccionada = Color.FromArgb(255, 235, 156);
        public static void PintarDeColoresValoresUnicos(Dtgconten dtg, DataGridViewTextBoxColumn ColName)
        {
            int pos = 1;
            string cadena = "";
            foreach (DataGridViewRow item in dtg.Rows)
            {
                if (item.Cells[ColName.Name].Value.ToString() != cadena)
                {
                    pos = pos == 0 ? 1 : 0;
                }
                cadena = item.Cells[ColName.Name].Value.ToString();
                if (pos == 0)
                    item.DefaultCellStyle.BackColor = Color.White;
                else
                    item.DefaultCellStyle.BackColor = BackAlterno;
            }
        }

        ///FIN COLORES DE GRILLAS
        ///COLORES CON UI
        public static Color AzulUI = Color.FromArgb(52, 152, 219);
        public static Color AzulUISelect = Color.FromArgb(41, 128, 185);
        public static Color VerdeUI = Color.FromArgb(26, 188, 156);
        public static Color VerdeUISelect = Color.FromArgb(22, 160, 133);
        public static Color MentaUI = Color.FromArgb(46, 204, 113);
        public static Color MentaUISelect = Color.FromArgb(39, 174, 96);
        public static Color MoradoUI = Color.FromArgb(155, 89, 182);
        public static Color MoradoUISelect = Color.FromArgb(142, 68, 173);
        public static Color OscuroUI = Color.FromArgb(52, 73, 94);
        public static Color OscuroUISelect = Color.FromArgb(44, 62, 80);
        public static Color RojoUI = Color.FromArgb(231, 76, 60);
        public static Color RojoUISelect = Color.FromArgb(240, 150, 141);//Color.FromArgb(192, 57, 43)
        public static Color BlancoUI = Color.FromArgb(236, 240, 241);
        public static Color BlancoUISelect = Color.FromArgb(189, 195, 199);
        public static Color GrisUI = Color.FromArgb(149, 165, 166);
        public static Color GrisUISelect = Color.FromArgb(127, 140, 141);
        public static Color AmarilloUI = Color.FromArgb(241, 196, 15);
        public static Color AmarilloUISelect = Color.FromArgb(243, 156, 18);
        public static Color MostazaUI = Color.FromArgb(230, 126, 34);
        public static Color MostazaUISelect = Color.FromArgb(211, 84, 0);
        ///FIN COLORES CON UI
        //FUENTES
        public static Font FuenteReportesTahoma8 = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Font FuenteReportesTahoma10 = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static List<string> ExtraerListaSinDuplicados(DataTable TablaDatos, string NombreColumna)
        {
            List<string> Listado = new List<string>();
            foreach (DataRow item in TablaDatos.Rows)
            {
                string cadena = item[NombreColumna].ToString();
                if (!Listado.Contains(cadena)) Listado.Add(cadena);
            }
            return Listado;
        }
        public static string SubstringRight(string value, int length)
        {
            if (value.Length > length)
                return value.Substring(value.Length - length);
            else return value;
        }
        //FIN FUENTES 
        //VALORES PARA DOCUMENTOS
        public static int DefIdRuc = 0;
        public static string DefRuc = "99999";
        public static string DefRazonSocial = "VARIOS";
        public static int DefIdComprobante = 0;
        public static string DefNumFac = "0";
        public static string DefSerieFac = "0";
        public static int DefCentroCosto = 0;
        public static string ddMMyyyy = "ddMMyy";
        public static string ddMMyy = "ddMMyy";
        //Valores Defecto Formularios
        public static int InsertarValor = 1;
        public static int ModificarValor = 2;
        public static int EstadoActivo = 1;
        public static string MMyyyy = "MM/yyyy";
        public static string MM_yyyy = "MM-yyyy";
        public static string dd_MM_yyyy = "dd-MM-yyyy";
        public static string dd_MM_yy = "dd-MM-yy";

        //FIN VALORES PARA DOCUMENTOS
        /// <param name="cadena">Palabra a la que vamos hacer Tipo Oración</param>
        public static string FilterImagenes()
        {
            return "Archivos de Imagenes|*.Bmp;*.Emf;*.Exif;*.Gif;*.Guid;*.Icon;*.Jpeg;*.jpg;*.MemoryBmp;*.Png;*.Tiff;*.Wmf";
        }
        public static string MayusculaCadaPalabra(string cadena)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cadena.ToLower());
        }
        public static void QuitarColumnas(DataTable result, int[] v)
        {
            v = v.OrderByDescending(c => c).ToArray();
            foreach (int i in v)
                result.Columns.RemoveAt(i);
        }
        public static string DefectoSunatString(string cadena)
        {
            return cadena == "" ? "-" : cadena.Trim();
        }
        public static string ValidarRutaValida(string cadena)
        {
            string result = "";
            foreach (var item in cadena)
            {
                if (!Path.GetInvalidPathChars().Contains(item))
                    result += item;
            }
            return result;
        }
        public static string AlfaNumericoSunat(string cadena)
        {
            string resul = "";
            string Contenido = "( ),.- ";
            foreach (char item in cadena)
            {
                if (char.IsNumber(item))
                {
                    resul += item;
                }
                else if (char.IsLetter(item))
                {
                    resul += item;
                }
                else if (Contenido.Contains(item))
                {
                    resul += item;
                }
            }
            return resul;
        }
        public static string AlfaNumericoBBVA(string cadena)
        {
            string resul = "";
            string Contenido = " ";
            foreach (char item in cadena)
            {
                if (char.IsNumber(item))
                {
                    resul += item;
                }
                else if (char.IsLetter(item))
                {
                    resul += item;
                }
                else if (Contenido.Contains(item))
                {
                    resul += item;
                }
            }
            return resul;
        }
        public static string RemoverAcentosÑApostrofe(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            stringBuilder = stringBuilder.Replace("'", "");
            stringBuilder = stringBuilder.Replace("´", "");
            stringBuilder = stringBuilder.Replace("`", "");
            return stringBuilder.ToString();
        }
        public static string CadenaDelimitada(string cadena, int len)
        {
            return cadena.Length > len ? cadena.Substring(0, len) : cadena.Trim();
        }
        public static DateTime InicioDelMes(DateTime Fecha)
        {
            Fecha = new DateTime(Fecha.Year, Fecha.Month, 1);
            return Fecha;
        }
        public static DateTime FinDelMes(DateTime Fecha)
        {
            Fecha = new DateTime(Fecha.Year, Fecha.Month, 1);
            return Fecha.AddMonths(1).AddDays(-1);
        }
        public static decimal Redondear(decimal valor) { return Math.Round(valor, 2, MidpointRounding.AwayFromZero); }
        public static void TiempoEjecucionMsg(Stopwatch st)
        {
            TimeSpan tm = st.Elapsed;
            HPResergerFunciones.Utilitarios.msg($"La Operación Demoro {tm}");
        }
        public static Boolean ValidarSQLInyect(params object[] txt)
        {
            Boolean Prueba = false;
            string Text1 = "DELETE ";
            string Text2 = "DROP ";
            string Text3 = " OR ";
            string Text4 = "=";
            foreach (TextBox Textos in txt)
            {
                if (Textos.Text.ToUpper().Contains(Text1)) Prueba = true;
                if (Textos.Text.ToUpper().Contains(Text2)) Prueba = true;
                if (Textos.Text.ToUpper().Contains(Text3)) Prueba = true;
                if (Textos.Text.ToUpper().Contains(Text4)) Prueba = true;
            }
            return Prueba;
        }
        /// <param name="Datagrid">Grilla con la que vamos a trabajar</param>
        /// <param name="ColumnaImporte">Columna a la que vamos a Asignar Valores</param>
        /// <param name="MontoaRepartir">Monto que vamos a Dividir</param> 
        public static void RellenarGrillasAutomatico(Dtgconten Datagrid, DataGridViewTextBoxColumn ColumnaImporte, decimal MontoaRepartir)
        {
            Datagrid.EndEdit();
            decimal Valor = 0;
            int contador = 0;
            foreach (DataGridViewRow item in Datagrid.Rows)
            {
                if (item.Index != Datagrid.CurrentCell.RowIndex)
                {
                    if (item.Cells[ColumnaImporte.Name].Value != null)
                    {
                        if (Decimal(item.Cells[ColumnaImporte.Name].Value.ToString()) > 0)
                            Valor += Redondear(Decimal(item.Cells[ColumnaImporte.Name].Value.ToString()));
                        else contador++;
                    }
                    else { contador++; }
                }
            }
            if (contador > 0)
            {
                Valor = Redondear((MontoaRepartir - Valor) / contador);
                foreach (DataGridViewRow item in Datagrid.Rows)
                {
                    if (item.Cells[ColumnaImporte.Name].Value != null)
                        if (Decimal(item.Cells[ColumnaImporte.Name].Value.ToString()) == 0)
                            item.Cells[ColumnaImporte.Name].Value = Valor;
                    if (item.Index == Datagrid.CurrentCell.RowIndex)
                        item.Cells[ColumnaImporte.Name].Value = Redondear(Valor);
                }
                Datagrid.RefreshEdit();
                Datagrid.EndEdit();
            }
        }
        /// <param name="Datagrid">Grilla con la que vamos a trabajar</param>
        /// <param name="ColumnaOrigen">Columna con la que vamos a sacar datos</param>
        /// <param name="ColumnaDestino">Columna a la que vamos asignar valores</param>
        public static void RellenarGrillasAutomatico(Dtgconten Datagrid, DataGridViewTextBoxColumn ColumnaOrigen, DataGridViewTextBoxColumn ColumnaDestino)
        {
            Datagrid.EndEdit();
            decimal ValorOrigen = 0, ValorDestino = 0;
            int contador = 1;
            foreach (DataGridViewRow item in Datagrid.Rows)
            {
                if (item.Index != Datagrid.CurrentCell.RowIndex)
                {
                    if (item.Cells[ColumnaDestino.Name].Value != null)
                    {
                        if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) > 0)
                            ValorDestino += Redondear(Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()));
                    }
                    if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) == 0 && Decimal(item.Cells[ColumnaOrigen.Name].Value.ToString()) == 0)
                        contador++;
                }
                ValorOrigen += Redondear(Decimal(item.Cells[ColumnaOrigen.Name].Value.ToString()));
            }
            if (Decimal(Datagrid[ColumnaOrigen.Name, Datagrid.CurrentCell.RowIndex].Value.ToString()) > 0) contador--;
            if (contador > 0)
            {
                ValorOrigen = Redondear((ValorOrigen - ValorDestino) / contador);
                if (ValorOrigen > 0)
                {
                    foreach (DataGridViewRow item in Datagrid.Rows)
                    {
                        if ((decimal)item.Cells[ColumnaOrigen.Name].Value == 0)
                        {
                            if (item.Cells[ColumnaDestino.Name].Value != null)
                                if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) == 0)
                                    item.Cells[ColumnaDestino.Name].Value = ValorOrigen;
                            if (item.Index == Datagrid.CurrentCell.RowIndex)
                                item.Cells[ColumnaDestino.Name].Value = ValorOrigen;
                        }
                    }
                }
                Datagrid.RefreshEdit();
                Datagrid.EndEdit();
            }
        }
        /// <param name="datetime">Fecha que vamos a convertir a FechaSQL</param>
        public static String ToFechaSql(DateTime datetime)
        {
            string cadena = "";
            cadena = $"{datetime.Year}-{datetime.Month.ToString("00")}-{datetime.Day.ToString("00")}";
            return cadena;
        }
        public static decimal Decimal(string cadena)
        {
            try
            {
                if (cadena == "" || cadena == ".") cadena = "0";
                return decimal.Parse(cadena);
            }
            catch (Exception e) { return 0; }
        }
        /// <param name="cadena">cadena a convertirse en formato n2</param>
        /// <returns>Regreso un decimal en formato N2</returns>
        public static string ReturnDecimal(string cadena)
        {
            return decimal.Parse(cadena).ToString("n2");
        }
        public static void Activar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = false;
                    //((TextBox)x).BackColor = Color.White;
                }
                else
                    ((Control)x).Enabled = true;
            }
        }
        public static void Desactivar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = true;
                    // ((TextBox)x).BackColor = Color.FromArgb(204, 218, 231);
                }
                else
                    ((Control)x).Enabled = false;
            }
        }
        public static void CargarTextoPorDefecto(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBoxPer)x).CargarTextoporDefecto();
                }
            }
        }

        public static void CargarTextoPorDefectoDeVacios(params TextBox[] control)
        {
            foreach (TextBoxPer x in control)
                if (!x.EstaLLeno())
                    x.CargarTextoporDefecto();
        }

        public static void CambiarNombreColumnsTablaGrilla(DataTable result, DataGridViewColumnCollection columns)
        {
            foreach (DataGridViewColumn item in columns)
                try
                {
                    result.Columns[item.DataPropertyName].ColumnName = item.HeaderText;
                }
                catch (NullReferenceException) { }
        }
        public static void FechaMenorMayor(DateTime FechaMin, DateTime FechaMax)
        {
            DateTime fechaaux = FechaMin;
            if (FechaMin > FechaMax) { FechaMin = FechaMax; FechaMax = fechaaux; }
        }

        public static string ValidarTipoDocumentoSerie(string v, int idComprobante)
        {
            string cadena = "";
            if (idComprobante == 1)
            {
                if (!(new string[] { "E", "F" }).Contains(v.Substring(0, 1))) //si es una factura electronica
                {
                    cadena = "0000";
                }
                else if (v.Length > 4)
                {
                    cadena = v.Substring(0, 4);
                }
                else if (v.Length < 4)
                {
                    cadena = $"{v}{("0000").Remove(0, v.Length)}";
                }
                else cadena = v;

            }
            else if (idComprobante == 2)
            {
                if (!(new string[] { "E", "F" }).Contains(v.Substring(0, 1))) //si es una factura electronica
                {
                    cadena = "0000";
                }
                else
                {
                    cadena = $"{v.Substring(0, 1)}000".Substring(v.Length) + v;
                }
            }
            else return v;
            return cadena;
        }

        public static string ValidarTipoDocumentoNumero(string v, int idComprobante)
        {
            string cadena = v;
            if (idComprobante == 1)
            {
                if (!char.IsNumber((v.Substring(0, 1)[0]))) //si es una factura electronica
                {
                    cadena = "00000001";
                }
                else cadena = v;
            }
            else if (idComprobante == 2)
            {
                if (!(new string[] { "E", "F" }).Contains(v.Substring(0, 1))) //si es una factura electronica
                {
                    cadena = "00000001";
                }
                else
                {
                    cadena = $"{v.Substring(0, 1)}000".Substring(v.Length) + v;
                }
            }
            else return cadena.Substring(0, cadena.Length > 20 ? 20 : cadena.Length);
            cadena = cadena.Substring(0, cadena.Length > 20 ? 20 : cadena.Length);
            return cadena;
        }
    }

}
