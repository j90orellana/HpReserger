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
using System.Data.OleDb;

namespace HPResergerFunciones
{
    public class Utilitarios
    {
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
        public class RangoCelda
        {
            public string fila { get; set; }
            public string columna { get; set; }
            public string Nombre { get; set; }
            public int TamañoFuente = 0;
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
                    MessageBox.Show("Guardado Existosamente!", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                foreach (int j in OrdendelasColumnas)
                {
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1] = item.Cells[j - 1].Value;
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = item.Cells[j - 1].Style.BackColor;
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;

                    nume++;
                }
                i++;
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
            if (aplicacion != null)
                aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
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
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].Font.Bold = true;
                if (Nombres.TamañoFuente != 0)
                    hoja_trabajo.Range[Nombres.fila, Nombres.columna].Font.Size = Nombres.TamañoFuente;
                hoja_trabajo.Range[Nombres.fila, Nombres.columna].MergeCells = true;

                //hoja_trabajo.Range[hoja_trabajo.Cells[ Nombres.columna,Nombres.fila] = Nombres.Nombre;

            }
            //Recorremos el DataGridView rellenando la hoja de trabajo
            int Conta = grd.Rows.Count;
            int i = 0;
            foreach (DataGridViewRow item in grd.Rows)
            {
                nume = 0;
                foreach (int j in OrdendelasColumnas)
                {
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Value2 = item.Cells[j - 1].Value;
                    if (item.Cells[j - 1].Style.BackColor.Name != "0")
                        hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Interior.Color = item.Cells[j - 1].Style.BackColor;
                    hoja_trabajo.Cells[i + 2 + PosInicialGrilla, nume + 1].Font.Color = item.Cells[j - 1].Style.ForeColor;

                    nume++;
                }
                i++;
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
            if (aplicacion != null)
                aplicacion.Visible = true;
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                libros_trabajo.SaveAs(ruta, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
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
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
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
        public static DataTable CargarDatosDeExcelAGrilla(string ruta, string Tabla)
        {
            string strConnnectionOle = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=" + '"' + "Excel 12.0 Xml;HDR=YES" + '"';
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
        public static string ExtraerCuenta(string cuenta)
        {
            Boolean numero = false;
            string caden = "";
            foreach (char txt in cuenta)
            {
                if ((char.IsLetter(txt) || txt == '-') && numero == false)
                    numero = true;
                if ((char.IsNumber(txt) || txt == '-') && numero == true)
                    caden += txt;
                if (char.IsLetter(txt) && numero == true && caden.Length > 9)
                    return caden.Trim('-');
            }
            return caden.Trim('-');
        }
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
    }
}
