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
namespace HPResergerFunciones
{
    public class Utilitarios
    {
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
        public static Boolean Sololetras(KeyPressEventArgs P)
        {
            string cadena = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZÑñ " + (char)8;
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
                cajita.Text = pegado;
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
                Clipboard.SetText(cajita.SelectedText);

            }
        }
        public static KeyPressEventArgs ToUpper(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            return e;
        }
        public static void ExportarAExcel(DataGridView grd, string ruta, string nombrehoja)
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
            //Recorremos el DataGridView rellenando la hoja de trabajo
            for (int i = 0; i < grd.Rows.Count - 1; i++)
            {
                nume = 0;
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    //  if (j != 0 && j != 4 && j != 6)
                    //   {
                    hoja_trabajo.Cells[i + 2, nume + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    nume++;
                    //   }
                }
            }
            numer = 0;
            for (int contador = 0; contador < grd.ColumnCount; contador++)
            {

                // if (contador != 0 && contador != 4 && contador != 6)
                //   {
                hoja_trabajo.Cells[1, numer + 1] = grd.Columns[contador].HeaderText.ToString();
                hoja_trabajo.Columns[numer + 1].AutoFit();
                numer++;
                //  }
            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }
}
