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

        public static Boolean SoloNumerosEnteros(KeyPressEventArgs P)
        {
            string cadena = "1234567890" + (char)8;
            if (!cadena.Contains(P.KeyChar))
            {
                P.Handled = true;
            }
            return P.Handled;
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
            if(e.Control&& e.KeyCode == Keys.C)
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
            if (e.Control && e.KeyCode == Keys.C)
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
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(cajita.SelectedText);
            }
        }
        public static KeyPressEventArgs ToUpper(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            return e;
        }
    }
}
