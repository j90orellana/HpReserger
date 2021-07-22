using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Management;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using HPResergerFunciones;
using System.Drawing;
using OfficeOpenXml;
using System.Data.OleDb;
using ExcelDataReader;

namespace HPResergerFunciones
{
    public class Utilitarios
    {
        public static string Encriptar(string cadena)
        {
            cadena = Convert.ToBase64String(Encoding.Unicode.GetBytes(cadena));
            return cadena;
        }
        public static string DesEncriptar(string cadena)
        {
            cadena = Encoding.Unicode.GetString(Convert.FromBase64String(cadena), 0, Convert.FromBase64String(cadena).Length);
            return cadena;
        }
        public static string QuitarÑ(string cadena)
        {
            string Regla = "ñÑ";
            string Result = "";
            foreach (char item in cadena)
            {
                if (Regla.Contains(item))
                {
                    Result += "n";
                }
                else
                {
                    Result += item;
                }
            }
            return Result;
        }
        public static Boolean TipoCambioValido(string cadena)
        {
            if (ValorCero(cadena) == 0) return false;
            else return true;
        }
        public static decimal ValorCero(string cadena)
        {
            decimal valor = 0;
            decimal.TryParse(cadena, out valor);
            return valor;
        }
        public static void SacarPosicionActualFilaColumna(DataGridView dtg, out int fila, out int columna)
        {
            fila = dtg.CurrentRow.Index;
            columna = dtg.CurrentCell.ColumnIndex;
        }
        public static int[] SacarPosicionActualFilaColumna(DataGridView dtg)
        {
            int[] XY = new int[2];
            XY[1] = dtg.CurrentRow.Index;
            XY[0] = dtg.CurrentCell.ColumnIndex;
            return XY;
        }
        public static string Cuo(int Asiento, DateTime Fecha)
        {
            string cuo = $"{Fecha.Year.ToString().Substring(2, 2) + Fecha.Month.ToString("00")}-{Asiento.ToString("00000")}";
            return cuo;
        }
        public static string ValidarCorreo(string correo)
        {
            try
            {
                return correo = new MailAddress(correo).Address;
            }
            catch (Exception) { return ""; }
        }
        public static DateTime DeStringDiaMesAÑoaDatetime(string cadena)
        {
            string valor = "";
            valor = cadena;//.Substring(3, 2) + "/" + cadena.Substring(0, 2) + "/" + cadena.Substring(6, 4);
            return DateTime.Parse(valor);
        }
        public static Boolean SoloNumerosDecimales(KeyPressEventArgs P, string Numero)
        {
            string cadena = "1234567890." + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            if ((Numero.IndexOf(".") > 0 && Convert.ToString(P.KeyChar) == ".") || (Numero.Length == 0 && Convert.ToString(P.KeyChar) == "."))
            {
                P.Handled = true;
            }
            return P.Handled;
        }
        public static Boolean SoloNumerosDecimalesConNegativo(KeyPressEventArgs P, string Numero)
        {
            string cadena = "1234567890.-" + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            if ((Numero.IndexOf(".") > 0 && Convert.ToString(P.KeyChar) == ".") || (Numero.Length == 0 && Convert.ToString(P.KeyChar) == "."))
            {
                P.Handled = true;
            }
            if (P.KeyChar == '-')
                if (Numero.Length != 0)
                    P.Handled = true;
            return P.Handled;
        }
        public static void msgCancel(string cabecera)
        {
            frmInformativo.MostrarDialogError(cabecera);
            ////MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void msgCancel(string cabecera, string detalle)
        {
            frmInformativo.MostrarDialogError(cabecera, detalle);
            ////MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void msg(string cadena)
        {
            frmInformativo.MostrarDialog(cadena);
            ////MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }/// <summary>        
         /// </summary>
         /// <param name="cadena"></param>
         /// <returns>Regresa el Yes</returns>
        public static DialogResult msgp(string cadena)
        {
            return MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        public static DialogResult MsgAcceptCancel(string cadena)
        {
            return MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public static DialogResult msgOkCancel(string cadena)
        {
            return MessageBox.Show(cadena, Application.CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public static DialogResult msgync(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesNoCancel(cadena); }
        public static Boolean SoloNumerosDecimalesX(KeyPressEventArgs P, string Numero)
        {
            string cadena = "1234567890." + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            if ((Numero.IndexOf(".") > 1 && Convert.ToString(P.KeyChar) == ".") || (Numero.Length == 0 && Convert.ToString(P.KeyChar) == "."))
            {
                P.Handled = true;
            }
            return P.Handled;
        }
        public static Boolean SoloNumerosEnteros(KeyPressEventArgs P)
        {
            string cadena = "1234567890" + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            return P.Handled;
        }
        public static int ExtraeEnterodeCadena(string cadena)
        {
            int a;
            string matriz = "1234567890" + (char)8;
            string resul = "0";
            foreach (char item in cadena)
                if (matriz.Contains(item))
                    resul += item;
            a = int.Parse(resul);
            return a;
        }
        public static Boolean Sololetras(KeyPressEventArgs P)
        {
            string cadena = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZÑñ " + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            return P.Handled;
        }
        public static Boolean SoloLetrasMayusculas(KeyPressEventArgs P)
        {
            string cadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZÑñ " + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            return P.Handled;
        }
        public static void ValidarPegarSoloLetras(KeyEventArgs e, TextBox cajita, int tamaño)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string pegado = "";
                string cadena;
                string valido = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZÑñ" + (char)8;
                cadena = Clipboard.GetText();
                foreach (char c in cadena)
                {
                    if (pegado.Length < tamaño)
                    {
                        if (!valido.Contains(c))
                        {
                            e.Handled = true;
                        }
                        else { pegado += c.ToString(); }
                    }
                    else break;
                }
                cajita.Text = cajita.Text + pegado;
            }
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrWhiteSpace(cajita.Text))
            {
                Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static void ValidarPegarSoloLetrasyEspacio(KeyEventArgs e, TextBox cajita, int tamaño)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string pegado = "";
                string cadena;
                string valido = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZÑñ " + (char)8;
                cadena = Clipboard.GetText();
                foreach (char c in cadena)
                {
                    if (pegado.Length < tamaño)
                    {
                        if (!valido.Contains(c))
                        {
                            e.Handled = true;
                        }
                        else { pegado += c.ToString(); }
                    }
                    else break;
                }
                cajita.Text = cajita.Text + pegado;
            }
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrWhiteSpace(cajita.Text))
            {
                Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static Boolean Nada(KeyPressEventArgs P)
        {
            P.Handled = true;
            return P.Handled;
        }
        public static void Validardocumentos(KeyEventArgs e, TextBox cajita, int tamaño)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string pegado = "";
                string cadena;
                string valido = "1234567890" + (char)8;
                cadena = Clipboard.GetText();
                foreach (char c in cadena)
                {
                    if (pegado.Length < tamaño)
                    {
                        if (!valido.Contains(c))
                        {
                            e.Handled = true;
                        }
                        else { pegado += c.ToString(); }
                    }
                    else break;
                }
                cajita.Text = pegado;
            }
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrWhiteSpace(cajita.Text))
            {
                if (!string.IsNullOrWhiteSpace(cajita.SelectedText))
                    Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static void ValidarCuentaBancos(KeyEventArgs e, TextBox cajita, int tamaño)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string pegado = "";
                string cadena;
                string valido = "1234567890" + (char)8;
                cadena = Clipboard.GetText();

                foreach (char c in cadena)
                {
                    if (pegado.Length < tamaño)
                    {
                        if (!valido.Contains(c))
                        {
                            e.Handled = true;
                        }
                        else { pegado += c.ToString(); }
                    }
                    else break;
                }
                cajita.Text = pegado;
            }
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrWhiteSpace(cajita.Text))
            {
                Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static void ValidarDinero(KeyEventArgs e, TextBox cajita)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string pegado = "";
                string cadena;
                string valido = "1234567890." + (char)8;
                cadena = Clipboard.GetText();
                int conpunto = 0, concoma = 0;
                foreach (char c in cadena)
                {
                    if (!valido.Contains(c))
                    {
                        e.Handled = true;
                    }
                    else
                    {

                        if (c == '.' && conpunto == 0)
                        {
                            pegado += c; conpunto++;
                        }
                        if (c == ',' && concoma == 0)
                        {
                            pegado += c; concoma++;
                        }
                        if (c != '.' && c != ',')
                        {
                            pegado += c;
                        }
                    }

                }
                cajita.Text = pegado;
            }
            if (e.Control && e.KeyCode == Keys.C && !string.IsNullOrWhiteSpace(cajita.Text))
            {
                if (cajita.SelectedText != "")
                    Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static string ReversaCadena(string campo)
        {
            char[] a = campo.ToCharArray();
            Array.Reverse(a);
            campo = new string(a);
            return campo;
        }
        public static KeyPressEventArgs ToUpper(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            return e;
        }
        public class NombreCelda
        {
            public int fila { get; set; }
            public int columna { get; set; }
            public string Nombre { get; set; }
            public NombreCelda() { }
            public NombreCelda(int _fila, int _columna, string _nombre)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
            }
        }
        public enum Alineado
        {
            izquierda = 0, derecha, centro
        }
        public class RangoCelda
        {
            public string fila { get; set; }
            public string columna { get; set; }
            public string Nombre { get; set; }
            public string Formato = "#,##0.00";
            public decimal ValorDecimal;
            public int TamañoFuente = 0;
            public Boolean _Negrita = false;
            public Boolean _Centrar = false;
            public Color BackColor = Color.Empty;
            public Color ForeColor = Color.Empty;
            public Font Fuente = null;
            public Alineado? Alineado = null;
            public Boolean Wrap = false;
            public RangoCelda() { }
            public RangoCelda(string _fila, string _columna, string _nombre)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = 0;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Color _BackColor, Color _ForeColor)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                BackColor = _BackColor;
                ForeColor = _ForeColor;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                _Centrar = Centrar;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar, Color? _BackColor, Color? _ForeColor)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                _Centrar = Centrar;
                _Negrita = Negrita;
                _Centrar = Centrar;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar, Color _BackColor, Color _ForeColor, Font _fuente)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                _Centrar = Centrar;
                _Negrita = Negrita;
                _Centrar = Centrar;
                Fuente = _fuente;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar, Alineado _alineado, Color _BackColor, Color _ForeColor, Font _fuente)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                _Centrar = Centrar;
                _Centrar = Centrar;
                Fuente = _fuente;
                Alineado = _alineado;
            }
            public RangoCelda(string _fila, string _columna, decimal Valor, int tamaño, Boolean Negrita, Boolean Centrar, Alineado _alineado, Color _BackColor, Color _ForeColor, Font _fuente, Boolean AplicarColores)
            {
                fila = _fila;
                columna = _columna;
                Nombre = null;
                ValorDecimal = Valor;
                TamañoFuente = tamaño;
                ForeColor = _ForeColor;
                BackColor = _BackColor;
                _Negrita = Negrita;
                _Centrar = Centrar;
                _Centrar = Centrar;
                Fuente = _fuente;
                Alineado = _alineado;
            }
            public RangoCelda(string _fila, string _columna, decimal Valor, string _Formato, int tamaño, Boolean Negrita, Boolean Centrar, Alineado _alineado, Color _BackColor, Color _ForeColor, Font _fuente, Boolean AplicarColores)
            {
                fila = _fila;
                columna = _columna;
                Nombre = null;
                ValorDecimal = Valor;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                _Centrar = Centrar;
                _Centrar = Centrar;
                ForeColor = _ForeColor;
                BackColor = _BackColor;
                Fuente = _fuente;
                Alineado = _alineado;
                Formato = _Formato;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar, Alineado _alineado, Color _BackColor, Color _ForeColor, Font _fuente, Boolean AplicarColores)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                ForeColor = _ForeColor;
                BackColor = _BackColor;
                _Centrar = Centrar;
                _Centrar = Centrar;
                Fuente = _fuente;
                Alineado = _alineado;
            }
            public RangoCelda(string _fila, string _columna, string _nombre, int tamaño, Boolean Negrita, Boolean Centrar, Alineado _alineado, Color _BackColor, Color _ForeColor, Font _fuente, Boolean AplicarColores, Boolean AjustarTexto)
            {
                fila = _fila;
                columna = _columna;
                Nombre = _nombre;
                TamañoFuente = tamaño;
                _Negrita = Negrita;
                ForeColor = _ForeColor;
                BackColor = _BackColor;
                _Centrar = Centrar;
                _Centrar = Centrar;
                Fuente = _fuente;
                Alineado = _alineado;
                Wrap = AjustarTexto;
            }
        }
        public static void DescargarImagen(PictureBox Fotos)
        {
            if (Fotos.Image != null)
            {
                SaveFileDialog Savesito = new SaveFileDialog();
                Savesito.Filter = "Imagenes *.jpg|*.jpg|Imagenes *.bmp|*.bmp|Imagenes *.png|*.png";
                if (Savesito.ShowDialog() == DialogResult.OK)
                {
                    Fotos.Image.Save(Savesito.FileName);
                    msg("Guardado Existosamente!");
                }
            }
        }
        public static void ExportarAExcel(DataGridView grd, string ruta, string nombrehoja, List<NombreCelda> NombresCeldas, int PosInicialGrilla, int[] FilasNoMostrar, int[] FilasNegritas, int[] ColumnaNegritas)
        {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = true;
            else
                aplicacion.Visible = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = nombrehoja;
            ///Ponemos Nombre a las Celdas      
            foreach (NombreCelda Nombres in NombresCeldas)
            {
                hoja_trabajo.Cells[Nombres.columna, Nombres.fila] = Nombres.Nombre;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int ConCol = grd.Columns.Count;
            int Conta = grd.Rows.Count;
            for (int i = 0; i < Conta; i++)
            {
                nume = 0;
                for (int j = 0; j < ConCol; j++)
                {
                    if (!FilasNoMostrar.Contains(j + 1))
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = grd.Rows[i].Cells[j].Value;
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(grd.Rows[i].Cells[j].InheritedStyle.BackColor.ToArgb());
                        //== item.Cells[j - 1].Style.ForeColor ? Color.White : item.Cells[j - 1].InheritedStyle.BackColor;
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = grd.Rows[i].Cells[j].Style.ForeColor;
                        nume++;
                    }
                    //   }
                }
            }
            numer = 0;
            for (int contador = 0; contador < ConCol; contador++)
            {
                if (!FilasNoMostrar.Contains(contador + 1))
                {
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador].HeaderText.ToString();
                    /////color de las celadas
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    numer++;
                }
            }
            foreach (int fila in FilasNegritas)
            {
                hoja_trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            }
            foreach (int fila in ColumnaNegritas)
            {
                hoja_trabajo.Columns[fila].Font.Bold = true;
            }

            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        public static string QuitarEspacios(string v)
        {
            string valor = "";
            foreach (char item in v) if (item != ' ') valor += item;
            return valor;
        }

        public static void ExportarAExcel(DataGridView grd, string ruta, string nombrehoja, List<NombreCelda> NombresCeldas, int PosInicialGrilla, int[] FilasNoMostrar, int[] FilasNegritas, int[] ColumnaNegritas, int NumFilas)
        {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = true;
            else
                aplicacion.Visible = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = nombrehoja;
            ///Ponemos Nombre a las Celdas      
            foreach (NombreCelda Nombres in NombresCeldas)
            {
                hoja_trabajo.Cells[Nombres.columna, Nombres.fila] = Nombres.Nombre;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int ConCol = grd.Columns.Count;
            for (int i = 0; i < NumFilas; i++)
            {
                nume = 0;
                for (int j = 0; j < ConCol; j++)
                {
                    if (!FilasNoMostrar.Contains(j + 1))
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = grd.Rows[i].Cells[j].Value;
                        nume++;
                    }
                }
            }
            numer = 0;
            int Conta = grd.ColumnCount;
            for (int contador = 0; contador < Conta; contador++)
            {
                if (!FilasNoMostrar.Contains(contador + 1))
                {
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador].HeaderText.ToString();
                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    numer++;
                }
            }
            foreach (int fila in FilasNegritas)
            {
                hoja_trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            }
            foreach (int fila in ColumnaNegritas)
            {
                hoja_trabajo.Columns[fila].Font.Bold = true;
            }

            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        public static void ExportarAExcelOrdenandoColumnas(DataGridView grd, string ruta, string nombrehoja, List<NombreCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas, int[] FilasNegritas, int[] ColumnaNegritas)
        {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = false;
            else
                aplicacion.Visible = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = nombrehoja;

            ///Ponemos Nombre a las Celdas      
            foreach (NombreCelda Nombres in NombresCeldas)
            {
                hoja_trabajo.Cells[Nombres.columna, Nombres.fila] = Nombres.Nombre;
                // hoja_trabajo.Range[hoja_trabajo.Cells[Nombres.columna, Nombres.fila], hoja_trabajo.Cells[Nombres.columna , Nombres.fila+3]] = Nombres.Nombre;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int Conta = grd.Rows.Count;
            int i = 0;
            foreach (DataGridViewRow item in grd.Rows)
            {
                nume = 0;
                if (OrdendelasColumnas.Length == 0)
                {
                    foreach (DataGridViewColumn j in grd.Columns)
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = item.Cells[j.Name].Value;
                        //if (item.Cells[j - 1].InheritedStyle.BackColor.Name != "Window")
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[j.Name].InheritedStyle.BackColor.ToArgb());
                        //== item.Cells[j - 1].Style.ForeColor ? Color.White : item.Cells[j - 1].InheritedStyle.BackColor;
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j.Name].Style.ForeColor;
                        nume++;
                    }
                }
                else
                {
                    foreach (int j in OrdendelasColumnas)
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = item.Cells[j - 1].Value;
                        //if (item.Cells[j - 1].InheritedStyle.BackColor.Name != "Window")
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[j - 1].InheritedStyle.BackColor.ToArgb());
                        //== item.Cells[j - 1].Style.ForeColor ? Color.White : item.Cells[j - 1].InheritedStyle.BackColor;
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;
                        nume++;
                    }
                }
                i++;
            }
            numer = 0;
            if (OrdendelasColumnas.Length == 0)
            {
                foreach (DataGridViewColumn contador in grd.Columns)
                {
                    //if (!FilasNoMostrar.Contains(contador + 1))
                    //{
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador.Name].HeaderText.ToString().ToUpper();
                    /////color de las celadas
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;

                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    if (grd.Rows[0].Cells[contador.Name].ValueType == typeof(decimal))
                        hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
                    numer++;
                }
            }
            else
            {
                foreach (int contador in OrdendelasColumnas)
                {
                    //if (!FilasNoMostrar.Contains(contador + 1))
                    //{
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador - 1].HeaderText.ToString().ToUpper();
                    /////color de las celadas
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;

                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    if (grd.Rows[0].Cells[contador - 1].ValueType == typeof(decimal))
                        hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
                    numer++;
                    //}
                }
            }
            foreach (int fila in FilasNegritas)
            {
                hoja_trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            }
            foreach (int fila in ColumnaNegritas)
            {
                hoja_trabajo.Columns[fila].Font.Bold = true;
            }
            if (aplicacion != null)
                aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        /// <summary>
        /// Proceso de Exportacion de datos a Excel (Lento)
        /// </summary>
        /// <param name="grd"></param>
        /// <param name="ruta"></param>
        /// <param name="nombrehoja"></param>
        /// <param name="NombresCeldas"></param>
        /// <param name="PosInicialGrilla"></param>
        /// <param name="OrdendelasColumnas"></param>
        /// <param name="FilasNegritas"></param>
        /// <param name="ColumnaNegritas"></param>
        public static void ExportarAExcelOrdenandoColumnas(DataGridView grd, string ruta, string nombrehoja, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas, int[] FilasNegritas, int[] ColumnaNegritas)
        {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = false;
            else
                aplicacion.Visible = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = nombrehoja;

            ///Ponemos Nombre a las Celdas      
            foreach (RangoCelda Nombres in NombresCeldas)
            {
                //hoja_trabajo.Cells[Nombres.columna, Nombres.fila] = Nombres.Nombre;
                hoja_trabajo.Range[Nombres.fila].Value2 = Nombres.Nombre;
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].Font.Bold = Nombres._Negrita;
                if (Nombres.TamañoFuente != 0)
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].Font.Size = Nombres.TamañoFuente;
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].MergeCells = true;
                if (!Nombres._Centrar)
                {
                    //.HorizontalAlignment = xlLeft
                    //.VerticalAlignment = xlBottom
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                }
                //backcolor
                if (Nombres.BackColor != null)
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].Interior.Color = Nombres.BackColor;
                if (Nombres.ForeColor != null)
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].Font.Color = Nombres.ForeColor;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int Conta = grd.Rows.Count;
            int i = 0;
            foreach (DataGridViewRow item in grd.Rows)
            {
                nume = 0;
                foreach (int j in OrdendelasColumnas)
                {
                    if (j != 0)
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Value2 = item.Cells[j - 1].Value;
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[j - 1].InheritedStyle.BackColor.ToArgb());
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;
                    }
                    else
                    {
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[0].InheritedStyle.BackColor.ToArgb());
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[0].Style.ForeColor;
                    }
                    nume++;
                }
                i++;
            }
            numer = 0;
            foreach (int contador in OrdendelasColumnas)
            {
                //if (!FilasNoMostrar.Contains(contador + 1))
                //{
                if (contador != 0)
                {
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador - 1].HeaderText.ToString();
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
                    hoja_trabajo.Columns[numer + 1].AutoFit();
                    if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(decimal))
                        hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
                    if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(DateTime))
                        hoja_trabajo.Columns[numer + 1].NumberFormat = "dd/mm/aaaa";
                    //if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(int))
                    //    hoja_trabajo.Columns[numer + 1].NumberFormat = grd.Columns[contador-1].DefaultCellStyle.Format;
                }
                else
                {
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
                    hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
                }
                numer++;
                //}
            }
            foreach (int fila in FilasNegritas)
            {
                hoja_trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            }
            foreach (int fila in ColumnaNegritas)
            {
                hoja_trabajo.Columns[fila].Font.Bold = true;
            }
            if (aplicacion != null)
                aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        public class EstiloCelda
        {
            public Color ColorRelleno;
            public Font FuenteRelleno;
            public Color ColorFuente;
            public EstiloCelda(Color _ColorRelleno, Font _FuenteRelleno)
            {
                ColorRelleno = _ColorRelleno;
                FuenteRelleno = _FuenteRelleno;
            }
            public EstiloCelda(Color _ColorRelleno, Font _FuenteRelleno, Color _ColorFuente)
            {
                ColorRelleno = _ColorRelleno;
                FuenteRelleno = _FuenteRelleno;
                ColorFuente = _ColorFuente;
            }
        }
        public static void ExportarAExcelOrdenandoColumnas(DataTable grd, EstiloCelda CeldaCabecera, EstiloCelda CeldaDefecto, string ruta, string nombrehoja, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas, int[] FilasNegritas, int[] ColumnaNegritas)
        {
            ExportarAExcelOrdenandoColumnas(grd, CeldaCabecera, CeldaDefecto, ruta, nombrehoja, NombresCeldas, PosInicialGrilla, OrdendelasColumnas, FilasNegritas, ColumnaNegritas, "");
        }
        /// <summary>
        /// Exportar a Excel (Rapido)
        /// </summary>
        /// <param name="grd">Tabla con Datos a Exportar</param>
        /// <param name="CeldaCabecera">Formato de la Celda Cabecera</param>
        /// <param name="CeldaDefecto">Formato de la Celdas por defecto</param>
        /// <param name="NameFile">Nombre del Archivo que se va a Guardar</param>
        /// <param name="nombrehoja">Nombre de la Hoja de Trabajo</param>
        /// <param name="NombresCeldas">Celdas Extras para Insertarlas</param>
        /// <param name="PosInicialGrilla">Fila donde se va a Insertar la Tabla</param>
        /// <param name="OrdendelasColumnas">No se Usa</param>
        /// <param name="FilasNegritas">No se Usa</param>
        /// <param name="AutoAjustarColumnas">No se Usa</param>
        /// <param name="ScriptMacro">Codigo para ejecutar al momento de abrir el programa</param>      
        public static void ExportarAExcelOrdenandoColumnas(DataTable grd, EstiloCelda CeldaCabecera, EstiloCelda CeldaDefecto, string NameFile, string nombrehoja, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas
            , int[] FilasNegritas, int[] AutoAjustarColumnas, string ScriptMacro)
        {
            //Principal para generar exportacion a Excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage Excel = new ExcelPackage();
            Excel.Workbook.Worksheets.Add(nombrehoja);
            ExcelWorksheet Hoja_Trabajo = Excel.Workbook.Worksheets[0];
            Hoja_Trabajo.Name = nombrehoja;
            ///Ponemos Nombre a las Celdas      
            foreach (RangoCelda Nombres in NombresCeldas)
            {
                Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.Nombre;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.Font.Bold = Nombres._Negrita;
                if (Nombres.TamañoFuente != 0)
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Size = Nombres.TamañoFuente;
                if (!Nombres._Centrar)
                {
                    Hoja_Trabajo.Cells[Nombres.fila /*+ ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                }
                else
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Merge = true;
                if (Nombres.Fuente != null)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Name = Nombres.Fuente.Name;
                }
                if (Nombres.Alineado != null)
                {
                    if (Alineado.izquierda == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    }
                    if (Alineado.derecha == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                    }
                    if (Alineado.centro == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }
                }
                //backcolor
                //    if (Nombres.BackColor != null)
                //                    Hoja_Trabajo.Cells[Nombres.fila + Nombres.columna].Style.Fill.BackgroundColor.SetColor(Color. Nombres.BackColor);
                // if (Nombres.ForeColor != null)
                // Hoja_Trabajo.Cells[Nombres.fila + Nombres.columna].Font.Color = Nombres.ForeColor;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int Conta = grd.Rows.Count;
            //int i = 0;
            Hoja_Trabajo.Cells["a" + PosInicialGrilla].LoadFromDataTable(grd, true);
            string Extesion = "x";
            if (!string.IsNullOrWhiteSpace(ScriptMacro)) Extesion = "m";
            //Hoja_Trabajo
            FileInfo file = new FileInfo(Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1')) + nombrehoja + $"{NameFile}" + $".xls{Extesion}");
            int ConCol = grd.Columns.Count;
            for (int i = 0; i < grd.Rows.Count + 1; i++)
            {
                if (i == 0)
                {
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaCabecera.ColorRelleno);
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.Color.SetColor(CeldaCabecera.ColorFuente);
                    if (CeldaCabecera.FuenteRelleno != null)
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaCabecera.FuenteRelleno);
                }
                else if ((i % 2) == 0)
                {
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaDefecto.ColorRelleno);
                    if (CeldaDefecto.FuenteRelleno != null)
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                }
                else
                {
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(Color.White);
                    if (CeldaDefecto.FuenteRelleno != null)
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                }
            }
            int CountRows = grd.Rows.Count + PosInicialGrilla;
            foreach (DataColumn item in grd.Columns)
            {
                if (item.DataType == typeof(decimal))
                    Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = "_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * \" - \"??_ ;_ @_ ";//Formato Contabilidad
                if (item.DataType == typeof(DateTime))
                    Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            }
            if (!string.IsNullOrWhiteSpace(ScriptMacro))
            {
                Excel.Workbook.CreateVBAProject();
                var worksheet = Excel.Workbook.Worksheets.Add("HojaDeMacros");
                worksheet.CodeModule.Code = ScriptMacro.ToString();
                worksheet.CodeModule.Name = "HojaDeMacros";
                Hoja_Trabajo.Workbook.CodeModule.Code = ScriptMacro;
                Hoja_Trabajo.Workbook.Worksheets["HojaDeMacros"].Hidden = eWorkSheetHidden.Hidden;
            }
            ///Ajustamos al Texto
            ///_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * "-"??_ ;_ @_ 
            string Pos = $"{PosInicialGrilla}:{PosInicialGrilla}";
            Hoja_Trabajo.Cells[Pos].Style.WrapText = true;
            Hoja_Trabajo.Cells[Pos].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            Hoja_Trabajo.Cells[Pos].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            //AutoAjustarColumnas
            foreach (int i in AutoAjustarColumnas)
            {
                Hoja_Trabajo.Column(i).AutoFit(7);

            }
            if (grd != null)
                Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(grd.Columns.Count)}"];
            else
                Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(Hoja_Trabajo.Dimension.Columns)}"];

            Hoja_Trabajo.PrinterSettings.PaperSize = ePaperSize.A4;
            Hoja_Trabajo.PrinterSettings.FitToPage = true;
            Hoja_Trabajo.PrinterSettings.FitToHeight = 0;
            Hoja_Trabajo.PrinterSettings.Orientation = eOrientation.Portrait;
            //Fin Ajuste de Texto
            Hoja_Trabajo.View.ShowGridLines = false;
            if (!EstaArchivoAbierto(file.ToString()))
            {
                Boolean Prueba = true;
                Excel.SaveAs(file);
                if (Type.GetTypeFromProgID("Excel.Application") != null ? true : false)
                {
                    Prueba = false;
                    Process.Start(file.ToString());
                }
                else
                {
                    Prueba = false;
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "EXCEL.EXE";
                    startInfo.Arguments = file.ToString();
                    Process.Start(startInfo);
                }
                if (Prueba) msg("Excel No Instalado");
            }
            //foreach (DataGridViewRow item in grd.Rows)
            //{
            //    nume = 0;
            //    foreach (int j in OrdendelasColumnas)
            //    {
            //        if (j != 0)
            //        {
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Value2 = item.Cells[j - 1].Value;
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[j - 1].InheritedStyle.BackColor.ToArgb());
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;
            //        }
            //        else
            //        {
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[0].InheritedStyle.BackColor.ToArgb());
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[0].Style.ForeColor;
            //        }
            //        nume++;
            //    }
            //    i++;
            //}
            //numer = 0;
            //foreach (int contador in OrdendelasColumnas)
            //{
            //    if (contador != 0)
            //    {
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador - 1].HeaderText.ToString();
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
            //        hoja_trabajo.Columns[numer + 1].AutoFit();
            //        if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(decimal))
            //            hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
            //        if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(DateTime))
            //            hoja_trabajo.Columns[numer + 1].NumberFormat = "dd/mm/aaaa";
            //    }
            //    else
            //    {
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
            //    }
            //    numer++;
            //}
            //foreach (int fila in FilasNegritas)
            ////{
            ////   Hoja_Trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            //}
            //foreach (int fila in AutoAjustarColumnas)
            //{
            ////    Hoja_Trabajo.Columns[fila].Font.Bold = true;
            //}
            //if (aplicacion != null)
            //    aplicacion.Visible = true;
            //if (!string.IsNullOrWhiteSpace(NameFile))
            //{
            //    //libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //    //libros_trabajo.Close(true);
            //    //aplicacion.Quit();
            //}
        }
        public static void ExportarAExcelOrdenandoColumnasCreado(DataTable grd, EstiloCelda CeldaCabecera, EstiloCelda CeldaDefecto, string NameFile,
            string nombrehoja, int index, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas
                   , int[] FilasNegritas, int[] AutoAjustarColumnas, string ScriptMacro, Boolean ImprimirCabecera)
        {
            Boolean ForzarAutoAjustado = false;
            string Extesion = "x";
            if (!string.IsNullOrWhiteSpace(ScriptMacro)) Extesion = "m";
            NameFile = NameFile.Substring(0, NameFile.Length - 1) + Extesion;
            //if (NombresCeldas[0].BackColor != Color.Empty) ForzarAutoAjustado = true;
            //Principal para generar exportacion a Excel
            FileInfo FileName = new FileInfo(NameFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage Excel = new ExcelPackage(FileName);
            Excel.Workbook.Worksheets.Add(nombrehoja);
            ExcelWorksheet Hoja_Trabajo = Excel.Workbook.Worksheets[index - 1];
            //Hoja_Trabajo.Name = nombrehoja; 
            ///Ponemos Nombre a las Celdas      
            if (NombresCeldas != null)
                foreach (RangoCelda Nombres in NombresCeldas)
                {
                    if (Nombres.Nombre == null)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.ValorDecimal;
                        Hoja_Trabajo.Cells[Nombres.fila].Style.Numberformat.Format = Nombres.Formato;//Formato Contabilidad
                    }
                    else
                        Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.Nombre;
                    //
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.Font.Bold = Nombres._Negrita;
                    if (Nombres.TamañoFuente != 0)
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Size = Nombres.TamañoFuente;
                    if (!Nombres._Centrar)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila /*+ ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                        Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                    }
                    else
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Merge = true;
                    if (Nombres.Fuente != null)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Name = Nombres.Fuente.Name;
                    }
                    if (Nombres.Alineado != null)
                    {
                        if (Alineado.izquierda == Nombres.Alineado)
                        {
                            Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                        }
                        if (Alineado.derecha == Nombres.Alineado)
                        {
                            Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                        }
                        if (Alineado.centro == Nombres.Alineado)
                        {
                            Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }
                    }
                    //backcolor
                    if (Nombres.BackColor != Color.Empty)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.BackgroundColor.SetColor(Nombres.BackColor);
                        //ForzarAutoAjustado = true;
                    }
                    //la linea de abajo si vale solo que hay que corregir por la letra blancas
                    if (Nombres.ForeColor != Color.Empty)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Color.SetColor(Nombres.ForeColor);
                        //ForzarAutoAjustado = true;
                    }
                    if (Nombres.Wrap)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.WrapText = true;
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }
                }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            if (grd != null)
            {
                int Conta = grd.Rows.Count;
                //int i = 0;
                Hoja_Trabajo.Cells["a" + PosInicialGrilla].LoadFromDataTable(grd, ImprimirCabecera);
                //Hoja_Trabajo
                FileInfo file = new FileInfo(NameFile);//Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1')) + nombrehoja + $"{""}" + $".xls{Extesion}");
                int ConCol = grd.Columns.Count;

                for (int i = 0; i < grd.Rows.Count + 1; i++)
                {
                    if (i == 0 && ImprimirCabecera)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaCabecera.ColorRelleno);
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.Color.SetColor(CeldaCabecera.ColorFuente);
                        if (CeldaCabecera.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaCabecera.FuenteRelleno);
                    }
                    else if ((i % 2) == 0)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaDefecto.ColorRelleno);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                    else
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(Color.White);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                }
                int CountRows = grd.Rows.Count + PosInicialGrilla;
                foreach (DataColumn item in grd.Columns)
                {
                    if (item.DataType == typeof(decimal))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = "_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * \" - \"??_ ;_ @_ ";//Formato Contabilidad
                    if (item.DataType == typeof(DateTime))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
                }
                if (!string.IsNullOrWhiteSpace(ScriptMacro))
                {
                    Excel.Workbook.CreateVBAProject();
                    var worksheet = Excel.Workbook.Worksheets.Add("HojaDeMacros");
                    worksheet.CodeModule.Code = ScriptMacro.ToString();
                    worksheet.CodeModule.Name = "HojaDeMacros";
                    Hoja_Trabajo.Workbook.CodeModule.Code = ScriptMacro;
                    Hoja_Trabajo.Workbook.Worksheets["HojaDeMacros"].Hidden = eWorkSheetHidden.Hidden;
                }
            }
            ///Ajustamos al Texto
            ///_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * "-"??_ ;_ @_ 
            string Pos = $"{PosInicialGrilla}:{PosInicialGrilla}";
            //if (!ImprimirCabecera)
            Hoja_Trabajo.Cells[Pos].Style.WrapText = true;
            Hoja_Trabajo.Cells[Pos].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            Hoja_Trabajo.Cells[Pos].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            //AutoAjustarColumnas
            foreach (int i in AutoAjustarColumnas)
            {
                Hoja_Trabajo.Column(i).BestFit = true;
                Hoja_Trabajo.Column(i).AutoFit();
            }
            if (grd == null)
                Hoja_Trabajo.Cells.AutoFitColumns();
            //var ax = Hoja_Trabajo.Dimension.Address;
            if (grd != null)
                Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(grd.Columns.Count)}"];
            else
                Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(Hoja_Trabajo.Dimension.Columns)}"];

            Hoja_Trabajo.PrinterSettings.PaperSize = ePaperSize.A4;
            Hoja_Trabajo.PrinterSettings.FitToPage = true;
            Hoja_Trabajo.PrinterSettings.FitToHeight = 0;
            Hoja_Trabajo.PrinterSettings.Orientation = eOrientation.Portrait;
            Hoja_Trabajo.View.ShowGridLines = false;
            if (!string.IsNullOrWhiteSpace(NameFile))
            {
                Excel.SaveAs(FileName);
            }
        }
        public static void ExportarAExcelOrdenandoColumnasCreado(DataTable grd, EstiloCelda CeldaCabecera, EstiloCelda CeldaDefecto, string NameFile,
            string nombrehoja, int index, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas
                   , int[] FilasNegritas, int[] AutoAjustarColumnas, string ScriptMacro)
        {
            Boolean ForzarAutoAjustado = false;
            string Extesion = "x";
            if (!string.IsNullOrWhiteSpace(ScriptMacro)) Extesion = "m";
            NameFile = NameFile.Substring(0, NameFile.Length - 1) + Extesion;
            //if (NombresCeldas[0].BackColor != Color.Empty) ForzarAutoAjustado = true;
            //Principal para generar exportacion a Excel
            FileInfo FileName = new FileInfo(NameFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage Excel = new ExcelPackage(FileName);
            Excel.Workbook.Worksheets.Add(nombrehoja);
            ExcelWorksheet Hoja_Trabajo = Excel.Workbook.Worksheets[index - 1];
            //Hoja_Trabajo.Name = nombrehoja; 
            ///Ponemos Nombre a las Celdas      
            foreach (RangoCelda Nombres in NombresCeldas)
            {
                if (Nombres.Nombre == null)
                {
                    Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.ValorDecimal;
                    Hoja_Trabajo.Cells[Nombres.fila].Style.Numberformat.Format = Nombres.Formato;//Formato Contabilidad
                }
                else
                    Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.Nombre;
                //
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.Font.Bold = Nombres._Negrita;
                if (Nombres.TamañoFuente != 0)
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Size = Nombres.TamañoFuente;
                if (!Nombres._Centrar)
                {
                    Hoja_Trabajo.Cells[Nombres.fila /*+ ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                }
                else
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Merge = true;
                if (Nombres.Fuente != null)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Name = Nombres.Fuente.Name;
                }
                if (Nombres.Alineado != null)
                {
                    if (Alineado.izquierda == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    }
                    if (Alineado.derecha == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                    }
                    if (Alineado.centro == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }
                }
                //backcolor
                if (Nombres.BackColor != Color.Empty)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.BackgroundColor.SetColor(Nombres.BackColor);
                    //ForzarAutoAjustado = true;
                }
                //la linea de abajo si vale solo que hay que corregir por la letra blancas
                if (Nombres.ForeColor != Color.Empty)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Color.SetColor(Nombres.ForeColor);
                    //ForzarAutoAjustado = true;
                }
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            if (grd != null)
            {
                int Conta = grd.Rows.Count;
                //int i = 0;
                Hoja_Trabajo.Cells["a" + PosInicialGrilla].LoadFromDataTable(grd, true);
                //Hoja_Trabajo
                FileInfo file = new FileInfo(NameFile);//Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1')) + nombrehoja + $"{""}" + $".xls{Extesion}");
                int ConCol = grd.Columns.Count;

                for (int i = 0; i < grd.Rows.Count + 1; i++)
                {
                    if (i == 0)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaCabecera.ColorRelleno);
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.Color.SetColor(CeldaCabecera.ColorFuente);
                        if (CeldaCabecera.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaCabecera.FuenteRelleno);
                    }
                    else if ((i % 2) == 0)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaDefecto.ColorRelleno);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                    else
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(Color.White);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                }
                int CountRows = grd.Rows.Count + PosInicialGrilla;
                foreach (DataColumn item in grd.Columns)
                {
                    if (item.DataType == typeof(decimal))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = "_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * \" - \"??_ ;_ @_ ";//Formato Contabilidad
                    if (item.DataType == typeof(DateTime))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
                }
                if (!string.IsNullOrWhiteSpace(ScriptMacro))
                {
                    Excel.Workbook.CreateVBAProject();
                    var worksheet = Excel.Workbook.Worksheets.Add("HojaDeMacros");
                    worksheet.CodeModule.Code = ScriptMacro.ToString();
                    worksheet.CodeModule.Name = "HojaDeMacros";
                    Hoja_Trabajo.Workbook.CodeModule.Code = ScriptMacro;
                    Hoja_Trabajo.Workbook.Worksheets["HojaDeMacros"].Hidden = eWorkSheetHidden.Hidden;
                }
            }
            ///Ajustamos al Texto
            ///_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * "-"??_ ;_ @_ 
            string Pos = $"{PosInicialGrilla}:{PosInicialGrilla}";
            Hoja_Trabajo.Cells[Pos].Style.WrapText = true;
            Hoja_Trabajo.Cells[Pos].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            Hoja_Trabajo.Cells[Pos].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            //AutoAjustarColumnas
            foreach (int i in AutoAjustarColumnas)
            {
                Hoja_Trabajo.Column(i).AutoFit(7);
            }
            if (ForzarAutoAjustado)
                foreach (int i in AutoAjustarColumnas)
                {
                    Hoja_Trabajo.Column(i).BestFit = true;
                    //Hoja_Trabajo.Column(i).AutoFit(1000);
                    Hoja_Trabajo.Column(i).AutoFit();
                    Hoja_Trabajo.Cells[$"{i}:{i}"].AutoFitColumns();
                }
            if (grd == null)
                Hoja_Trabajo.Cells.AutoFitColumns();
            //AJUSTE DE AREA DE IMPRESION            
            //Hoja_Trabajo.PrinterSettings.PrintArea = null;

            Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(grd == null ? Hoja_Trabajo.Dimension.Columns : grd.Columns.Count)}"];
            Hoja_Trabajo.PrinterSettings.PaperSize = ePaperSize.A4;
            Hoja_Trabajo.PrinterSettings.FitToPage = true;
            Hoja_Trabajo.PrinterSettings.FitToHeight = 0;
            Hoja_Trabajo.PrinterSettings.Orientation = eOrientation.Portrait;
            ExcelAddress FilaRepetir = new ExcelAddress($"{PosInicialGrilla}:{PosInicialGrilla}");
            Hoja_Trabajo.PrinterSettings.RepeatRows = FilaRepetir;
            //Fin Ajuste de Texto
            Hoja_Trabajo.View.ShowGridLines = false;
            //if (!EstaArchivoAbierto(FileName.ToString()))
            //{
            //    Excel.SaveAs(FileName);
            //    if (Type.GetTypeFromProgID("Excel.Application") != null ? true : false)
            //    {
            //        Process.Start(FileName.ToString());
            //    }
            //    else msg("Excel No Instalado");
            //}
            //foreach (DataGridViewRow item in grd.Rows)
            //{
            //    nume = 0;
            //    foreach (int j in OrdendelasColumnas)
            //    {
            //        if (j != 0)
            //        {
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Value2 = item.Cells[j - 1].Value;
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[j - 1].InheritedStyle.BackColor.ToArgb());
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;
            //        }
            //        else
            //        {
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = Color.FromArgb(item.Cells[0].InheritedStyle.BackColor.ToArgb());
            //            hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[0].Style.ForeColor;
            //        }
            //        nume++;
            //    }
            //    i++;
            //}
            //numer = 0;
            //foreach (int contador in OrdendelasColumnas)
            //{
            //    if (contador != 0)
            //    {
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador - 1].HeaderText.ToString();
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
            //        hoja_trabajo.Columns[numer + 1].AutoFit();
            //        if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(decimal))
            //            hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
            //        if (grd.Rows[0].Cells[contador - 1].Value.GetType() == typeof(DateTime))
            //            hoja_trabajo.Columns[numer + 1].NumberFormat = "dd/mm/aaaa";
            //    }
            //    else
            //    {
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Interior.Color = Color.FromArgb(grd.ColumnHeadersDefaultCellStyle.BackColor.ToArgb());
            //        hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1].Font.Color = grd.ColumnHeadersDefaultCellStyle.ForeColor;
            //    }
            //    numer++;
            //}
            //foreach (int fila in FilasNegritas)
            ////{
            ////   Hoja_Trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            //}
            //foreach (int fila in AutoAjustarColumnas)
            //{
            ////    Hoja_Trabajo.Columns[fila].Font.Bold = true;
            //}
            //if (aplicacion != null)
            //    aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(NameFile))
            {
                Excel.SaveAs(FileName);
            }
        }
        public class Columnas
        {
            public int ind = 0;
            public int largo = 0;
            public Columnas(int _ind, int _largo)
            {
                ind = _ind;
                largo = _largo;
            }
        }
        public static void ExportarAExcelOrdenandoColumnasCreado(DataTable grd, EstiloCelda CeldaCabecera, EstiloCelda CeldaDefecto, string NameFile,
        string nombrehoja, int index, List<RangoCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas
              , int[] FilasNegritas, int[] AutoAjustarColumnas, string ScriptMacro, string RangoFilaRepetir, List<Columnas> ListadoColumnas)
        {
            Boolean ForzarAutoAjustado = false;
            string Extesion = "x";
            if (!string.IsNullOrWhiteSpace(ScriptMacro)) Extesion = "m";
            NameFile = NameFile.Substring(0, NameFile.Length - 1) + Extesion;
            //if (NombresCeldas[0].BackColor != Color.Empty) ForzarAutoAjustado = true;
            //Principal para generar exportacion a Excel
            FileInfo FileName = new FileInfo(NameFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage Excel = new ExcelPackage(FileName);
            Excel.Workbook.Worksheets.Add(nombrehoja);
            ExcelWorksheet Hoja_Trabajo = Excel.Workbook.Worksheets[index - 1];
            //Hoja_Trabajo.Name = nombrehoja; 
            ///Ponemos Nombre a las Celdas      
            foreach (RangoCelda Nombres in NombresCeldas)
            {
                if (Nombres.Nombre == null)
                {
                    Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.ValorDecimal;
                    Hoja_Trabajo.Cells[Nombres.fila].Style.Numberformat.Format = Nombres.Formato;//Formato Contabilidad
                }
                else
                    Hoja_Trabajo.Cells[Nombres.fila].Value = Nombres.Nombre;
                //
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.Font.Bold = Nombres._Negrita;
                if (Nombres.TamañoFuente != 0)
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Size = Nombres.TamañoFuente;
                if (!Nombres._Centrar)
                {
                    Hoja_Trabajo.Cells[Nombres.fila /*+ ":" + Nombres.columna*/].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    Hoja_Trabajo.Cells[Nombres.fila/* + ":" + Nombres.columna*/].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Bottom;
                }
                else
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Merge = true;
                if (Nombres.Fuente != null)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Name = Nombres.Fuente.Name;
                }
                if (Nombres.Alineado != null)
                {
                    if (Alineado.izquierda == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    }
                    if (Alineado.derecha == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                    }
                    if (Alineado.centro == Nombres.Alineado)
                    {
                        Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }
                }
                //backcolor
                if (Nombres.BackColor != Color.Empty)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Fill.BackgroundColor.SetColor(Nombres.BackColor);
                    //ForzarAutoAjustado = true;
                }
                //la linea de abajo si vale solo que hay que corregir por la letra blancas
                if (Nombres.ForeColor != Color.Empty)
                {
                    Hoja_Trabajo.Cells[Nombres.fila + ":" + Nombres.columna].Style.Font.Color.SetColor(Nombres.ForeColor);
                    //ForzarAutoAjustado = true;
                }
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            if (grd != null)
            {
                int Conta = grd.Rows.Count;
                //int i = 0;
                Hoja_Trabajo.Cells["a" + PosInicialGrilla].LoadFromDataTable(grd, true);
                //Hoja_Trabajo
                FileInfo file = new FileInfo(NameFile);//Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1')) + nombrehoja + $"{""}" + $".xls{Extesion}");
                int ConCol = grd.Columns.Count;

                for (int i = 0; i < grd.Rows.Count + 1; i++)
                {
                    if (i == 0)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaCabecera.ColorRelleno);
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.Color.SetColor(CeldaCabecera.ColorFuente);
                        if (CeldaCabecera.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaCabecera.FuenteRelleno);
                    }
                    else if ((i % 2) == 0)
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(CeldaDefecto.ColorRelleno);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                    else
                    {
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Fill.BackgroundColor.SetColor(Color.White);
                        if (CeldaDefecto.FuenteRelleno != null)
                            Hoja_Trabajo.Cells[i + PosInicialGrilla, 1, i + PosInicialGrilla, ConCol].Style.Font.SetFromFont(CeldaDefecto.FuenteRelleno);
                    }
                }
                int CountRows = grd.Rows.Count + PosInicialGrilla;
                foreach (DataColumn item in grd.Columns)
                {
                    if (item.DataType == typeof(decimal))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = "_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * \" - \"??_ ;_ @_ ";//Formato Contabilidad
                    if (item.DataType == typeof(DateTime))
                        Hoja_Trabajo.Cells[PosInicialGrilla, item.Ordinal + 1, CountRows, item.Ordinal + 1].Style.Numberformat.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
                }
                if (!string.IsNullOrWhiteSpace(ScriptMacro))
                {
                    Excel.Workbook.CreateVBAProject();
                    var worksheet = Excel.Workbook.Worksheets.Add("HojaDeMacros");
                    worksheet.CodeModule.Code = ScriptMacro.ToString();
                    worksheet.CodeModule.Name = "HojaDeMacros";
                    Hoja_Trabajo.Workbook.CodeModule.Code = ScriptMacro;
                    Hoja_Trabajo.Workbook.Worksheets["HojaDeMacros"].Hidden = eWorkSheetHidden.Hidden;
                }
            }
            ///Ajustamos al Texto
            ///_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * "-"??_ ;_ @_ 
            string Pos = $"{PosInicialGrilla}:{PosInicialGrilla}";
            Hoja_Trabajo.Cells[Pos].Style.WrapText = true;
            Hoja_Trabajo.Cells[Pos].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
            Hoja_Trabajo.Cells[Pos].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            //AutoAjustarColumnas
            foreach (int i in AutoAjustarColumnas)
            {
                Hoja_Trabajo.Column(i).AutoFit(7);
            }
            if (ForzarAutoAjustado)
                foreach (int i in AutoAjustarColumnas)
                {
                    Hoja_Trabajo.Column(i).BestFit = true;
                    //Hoja_Trabajo.Column(i).AutoFit(1000);
                    Hoja_Trabajo.Column(i).AutoFit();
                    Hoja_Trabajo.Cells[$"{i}:{i}"].AutoFitColumns();
                }
            if (grd == null)
                Hoja_Trabajo.Cells.AutoFitColumns();
            //AJUSTAMOS MANUALEMNTE LA COLUMNA
            if (ListadoColumnas != null)
                foreach (Columnas col in ListadoColumnas)
                    Hoja_Trabajo.Column(col.ind).Width = col.largo;

            //AJUSTE DE AREA DE IMPRESION            
            //Hoja_Trabajo.PrinterSettings.PrintArea = null;

            Hoja_Trabajo.PrinterSettings.PrintArea = Hoja_Trabajo.Cells[$"A:{ExcelRange.GetAddressCol(grd == null ? Hoja_Trabajo.Dimension.Columns : grd.Columns.Count)}"];
            Hoja_Trabajo.PrinterSettings.PaperSize = ePaperSize.A4;
            Hoja_Trabajo.PrinterSettings.FitToPage = true;
            Hoja_Trabajo.PrinterSettings.FitToHeight = 0;
            Hoja_Trabajo.PrinterSettings.Orientation = eOrientation.Portrait;
            ExcelAddress FilaRepetir = new ExcelAddress(RangoFilaRepetir);
            Hoja_Trabajo.PrinterSettings.RepeatRows = FilaRepetir;
            //Fin Ajuste de Texto
            Hoja_Trabajo.View.ShowGridLines = false;

            if (!string.IsNullOrWhiteSpace(NameFile))
            {
                Excel.SaveAs(FileName);
            }
        }
        public static Boolean EstaArchivoAbierto(string filePath)
        {
            Boolean rtnvalue = false;
            try
            {
                FileStream fs = File.OpenWrite(filePath);
                fs.Close();
            }
            catch (IOException)
            {
                rtnvalue = true;
                msg("Archivo Esta Abierto");
            }
            return rtnvalue;
        }
        public static void ExportarAExcelOrdenandoColumnas(DataGridView grd, string ruta, string nombrehoja, List<NombreCelda> NombresCeldas, int PosInicialGrilla, int[] OrdendelasColumnas, int[] FilasNegritas, int[] ColumnaNegritas, int NumFilas)
        {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = false;
            else
                aplicacion.Visible = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = nombrehoja;
            ///Ponemos Nombre a las Celdas      
            foreach (NombreCelda Nombres in NombresCeldas)
            {
                hoja_trabajo.Cells[Nombres.columna, Nombres.fila] = Nombres.Nombre;
            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            for (int i = 0; i < NumFilas; i++)
            {
                nume = 0;
                foreach (int j in OrdendelasColumnas)
                {
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = grd.Rows[i].Cells[j - 1].Value;
                    nume++;
                }
            }
            numer = 0;
            foreach (int contador in OrdendelasColumnas)
            {
                //if (!FilasNoMostrar.Contains(contador + 1))
                //{
                hoja_trabajo.Cells[1 + PosInicialGrilla, numer + 1] = grd.Columns[contador - 1].HeaderText.ToString();
                hoja_trabajo.Columns[numer + 1].AutoFit();
                if (grd.Rows[0].Cells[contador - 1].ValueType == typeof(decimal))
                    hoja_trabajo.Columns[numer + 1].NumberFormat = "#,##0.00";
                numer++;

                //}
            }
            foreach (int fila in FilasNegritas)
            {
                hoja_trabajo.Rows[fila + PosInicialGrilla].Font.Bold = true;
            }
            foreach (int fila in ColumnaNegritas)
            {
                hoja_trabajo.Columns[fila].Font.Bold = true;
            }
            if (string.IsNullOrWhiteSpace(ruta))
                aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        /*    public void EnviarMensaje(string mensaje, string titulo, string asunto, string para, string de)
             {
                 frmMensajeCorreo mensajito = new frmMensajeCorreo();
                 mensajito.txtmsg.Text = mensaje;
                 mensajito.Text = titulo;
                 mensajito.txtasunto.Text = asunto;
                 mensajito.ShowDialog();
                 if (mensajito.ok)
                 {
                     try
                     {
                         MailMessage email = new MailMessage();
                         //CORREO DE PROVEEDOR
                         email.To.Add(new MailAddress(para));
                         ///
                         email.From = new MailAddress("j90orellana@hotmail.com");
                         email.Subject = mensajito.txtasunto.Text;
                         email.Priority = mensajito.PrioridadCorreo();
                         email.Body = mensajito.txtmsg.Text;
                         if (mensajito.Adjunto())
                         {
                             foreach (string ruta in mensajito.ArchivosAdjuntos())
                             {
                                 Attachment Archivos = new Attachment(ruta);
                                 email.Attachments.Add(Archivos);
                             }
                         }
                         else
                             email.Attachments.Clear();
                         ///
                         email.IsBodyHtml = false;
                         SmtpClient smtp = new SmtpClient();
                         smtp.Host = "smtp.live.com";
                         smtp.Port = 25;
                         smtp.EnableSsl = true;
                         smtp.UseDefaultCredentials = false;
                         smtp.Credentials = new NetworkCredential("j90orellana@hotmail.com", "Jeffer123");
                         smtp.Send(email);
                         email.Dispose();
                         MSG("Correo electrónico fue enviado a " + para.ToLower() + " satisfactoriamente.");
                     }
                     catch (Exception ex)
                     {
                         MSG("Error enviando correo electrónico: " + ex.Source + " " + ex.Message);
                     }
                 }
             }
             */
        public static List<string> ListarHojasDeunExcel(string ruta)
        {
            List<string> NombresHojas = new List<string>();
            if (ruta.Length > 0)
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb;
                Microsoft.Office.Interop.Excel.Worksheet ws;
                //try
                //{
                wb = app.Workbooks.Open(ruta);
                foreach (Microsoft.Office.Interop.Excel.Worksheet item in wb.Sheets)
                {
                    NombresHojas.Add(item.Name.ToString());
                }
                wb.Close();
                return NombresHojas;
                //}
                //catch
                //{
                //    return NombresHojas;
                //}               
            }
            return NombresHojas;
            //Dim app As Excel.Application = Nothing

            //Try
            //    app = New Excel.Application()

            //    ' Abrimos el libro de trabajo
            //    '
            //    Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)

            //    ' Referenciamos la hoja cuyo índice sea 1.
            //    '
            //    Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)

            //    ' Obtenemos el nombre de la hoja.
            //    '
            //    Dim name As String = ws.Name

            //    ws = Nothing

            //    ' Cerramos el libro
            //    '
            //    wb.Close()
            //    wb = Nothing

            //    ' Devolvemos el nombre de la hoja
            //    '
            //    Return name

            //Catch ex As Exception
            //    ' Se ha producido un error; devolvemos la excepción
            //    ' al procedimiento llamador.
            //    '
            //    Throw

            //Finally
            //    ' Cerramos Excel.
            //    '
            //    If(Not app Is Nothing) Then _
            //        app.Quit()

            //    ' Disminuimos el contador de referencias y liberamos el objeto.
            //    '
            //    Runtime.InteropServices.Marshal.ReleaseComObject(app)

            //    app = Nothing

            //End Try

        }
        public static DataTable CargarDatosDeExcelAGrilla(string ruta, int iHoja, int PosCuenta, int ColCuenta)
        {
            try
            {
                FileStream fs = File.Open(ruta, FileMode.Open, FileAccess.Read);
                //IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
                DataSet result = reader.AsDataSet();
                reader.Close();
                return result.Tables[0];
                //Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                //Microsoft.Office.Interop.Excel.Workbook Libro;
                //Microsoft.Office.Interop.Excel.Worksheet Hoja;
                //Libro = ExcelApp.Workbooks.Open(ruta);
                //Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(iHoja);
                //int contador = 0;
                //string cadena = "";
                //do
                //{
                //    contador++;
                //    cadena = (((Microsoft.Office.Interop.Excel.Range)Hoja.Cells[contador, 1]).Value2??"").ToString();
                //    //Array[] Listado = new Array[ColCuenta];
                //    //for (int i = 0; i < ColCuenta; i++)
                //    //{
                //    //    Listado[i] = (((Microsoft.Office.Interop.Excel.Range)Hoja.Cells[contador, 1]).Value2);
                //    //}
                //    //Data.Rows.Add(Listado);
                //} while (PosCuenta > contador || cadena != "");
                //object Hola = new object();
                //Hoja.Range["a1", $"k{contador}"].Copy();
                //Data = Clipboard.;
                ////foreach (var item in Valor.Rows)
                ////{
                ////    Data.Rows.Add(item);
                ////}
                //contador++;
            }
            catch (Exception e)
            {
                msgCancel(e.Message, "No se Pudo Abrir el Archivo Excel");
                return new DataTable();
            };
        }
        public static DataTable CargarDatosDeExcelAGrilla(string ruta, string Tabla)
        {
            string strConnnectionOle = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=" + '"' + " Excel 12.0 Xml;HDR=YES" + '"';
            //string strConnnectionOle = @"Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + ruta + ";Extended Properties=" + '"' + "Excel 8.0 Xml;HDR=YES" + '"';
            string sqlExcel = "Select * From [" + Tabla + "$]";
            DataTable DS = new DataTable();
            OleDbConnection oledbConn = new OleDbConnection(strConnnectionOle);
            try
            {
                oledbConn.Open();
                OleDbCommand oledbCmd = new OleDbCommand(sqlExcel, oledbConn);
                OleDbDataAdapter da = new OleDbDataAdapter(oledbCmd);
                da.Fill(DS);
                oledbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DS;
        }
        public enum Direccion
        {
            derecha = 0, izquierda
        }
        public static DataTable TablaMeses()
        {
            DataTable meses = new DataTable();
            meses.Columns.Add("codigo", typeof(int));
            meses.Columns.Add("valor");
            meses.Rows.Add(new object[] { 1, "Enero" });
            meses.Rows.Add(new object[] { 2, "Febrero" });
            meses.Rows.Add(new object[] { 3, "Marzo" });
            meses.Rows.Add(new object[] { 4, "Abril" });
            meses.Rows.Add(new object[] { 5, "Mayo" });
            meses.Rows.Add(new object[] { 6, "Junio" });
            meses.Rows.Add(new object[] { 7, "Julio" });
            meses.Rows.Add(new object[] { 8, "Agosto" });
            meses.Rows.Add(new object[] { 9, "Septiembre" });
            meses.Rows.Add(new object[] { 10, "Octubre" });
            meses.Rows.Add(new object[] { 11, "Noviembre" });
            meses.Rows.Add(new object[] { 12, "Diciembre" });
            return meses;
        }
        public static string AddCaracter(string cadena, char caracter, int tamaño, Direccion direccion)
        {
            cadena = cadena.Trim();
            string cade = "";
            for (int i = cadena.Length; i < tamaño; i++)
            {
                cade += caracter;
            }
            if ((int)direccion == 0)
                cadena = cade + cadena;
            else
                cadena = cadena + cade;
            return cadena.Substring(0, tamaño);
        }
        public static string AddCaracterMultiplicarx100(string cadena, char caracter, int tamaño, Direccion direccion)
        {
            cadena = cadena.Trim();
            decimal monto = decimal.Parse(((decimal.Parse(cadena)).ToString("n2"))) * 100;
            string cade = "";
            cadena = "";
            foreach (char var in monto.ToString("n0"))
            {
                if (char.IsNumber(var))
                    cadena += var;
            }
            for (int i = cadena.Length; i < tamaño; i++)
            {
                cade += caracter;
            }
            if ((int)direccion == 0)
                cadena = cade + cadena;
            else
                cadena = cadena + cade;
            return cadena.Substring(0, tamaño);
        }
        public static string ExtraerCuentaSoloEnteros(string cuenta)
        {
            string cadena = "";
            if (cuenta != "")
            {
                foreach (var c in cuenta)
                {
                    if (char.IsDigit(c))
                    {
                        cadena += c;
                    }
                }

            }
            return cadena;
        }
        public static string ExtraerCuenta(string cuenta)
        {
            int posI = -1, posF = 0, con = 0;
            if (cuenta != "")
            {
                foreach (var c in cuenta)
                {
                    if (char.IsDigit(c))
                    {
                        if (posI < 0)
                        {
                            posI = con;
                        }
                        posF = con;
                    }
                    con++;
                }
                return cuenta.Substring(posI, posF + 1);
            }
            else return "";
        }
        //public static string ExtraerCuenta(string cuenta)
        //{
        //    Boolean numero = false;
        //    string caden = "";
        //    foreach (char txt in cuenta)
        //    {
        //        if ((char.IsLetter(txt) || txt == '-') && numero == false)
        //            numero = true;
        //        if ((char.IsNumber(txt) || txt == '-') && numero == true)
        //            caden += txt;
        //        if (char.IsLetter(txt) && numero == true && caden.Length > 9)
        //            return caden.Trim('-');
        //    }
        //    return caden.Trim('-');
        //}
        public static string QuitarCaracterCuenta(string cuenta, char caracter)
        {
            string caden = "";
            foreach (char cas in cuenta)
            {
                if (cas != caracter)
                    caden += cas;
            }
            return caden;
        }
        public static string QuitarCaracterCuenta(string cuenta, params char[] caracter)
        {
            string caden = "";
            foreach (char cas in cuenta)
            {
                if (!caracter.Contains(cas))
                    caden += cas;
            }
            return caden;
        }
        public static void ColorCeldaError(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Red;
            item.Style.BackColor = Color.Yellow;
            item.Style.SelectionBackColor = Color.FromArgb(165, 207, 75);
        }
        public static void ColorCeldaNormal(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Green;
            item.Style.BackColor = Color.Empty;
        }
        public static void ColorCeldaErrorLetras(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Red;
            item.Style.BackColor = Color.Empty;
        }
        public static void ColorCeldaDefecto(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Empty;
            item.Style.BackColor = Color.Empty;
            item.Style.SelectionBackColor = Color.Empty;
        }
        public static void ColorFilaDefecto(DataGridViewRow item)
        {
            item.DefaultCellStyle.ForeColor = Color.Empty;
            item.DefaultCellStyle.BackColor = Color.Empty;
            item.DefaultCellStyle.SelectionBackColor = Color.Empty;
        }
        public static void ColorFilaSeleccionada(DataGridViewRow item,Color ColorFondo)
        {
            item.DefaultCellStyle.ForeColor = Color.Empty;
            item.DefaultCellStyle.BackColor = ColorFondo;
            item.DefaultCellStyle.SelectionBackColor = ColorFondo;

        }
        public static void AjustarTexto(TextBox cajita, int len)
        {
            if (cajita.Text.Length > 0)
                if (cajita.Text.Length > len)
                    cajita.Text = cajita.Text.Substring(0, len);
        }
        public static void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public static void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        public static int Edad(DateTime Fecha)
        {
            Fecha = Fecha.Date;
            return DateTime.Today.AddTicks(-Fecha.Ticks).Year - 1;
        }
        public static int Edad(DateTime FechaInicial, DateTime FechaFin)
        {
            FechaFin = FechaFin.Date;
            return FechaInicial.AddTicks(-FechaFin.Ticks).Year - 1;
        }

    }
}
