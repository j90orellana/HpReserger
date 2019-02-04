using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmFicSinFaactura : FormGradient
    {
        public frmFicSinFaactura()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLFicFacturas = new HPResergerCapaLogica.HPResergerCL();
        int fic = 0, proveedor = 0;
        int check = 0;
        private void frmFicSinFaactura_Load(object sender, EventArgs e)
        {
            cbodocumento.SelectedIndex = 0;
            fic = 1;
            dtgconten.DataSource = CLFicFacturas.ListarFicSinFactura(txtbuscar.Text, fic, proveedor, check, cbodocumento.SelectedIndex.ToString());
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                fic = 1;
            else fic = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                proveedor = 1;
            else proveedor = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                check = 1;
            else
                check = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void cbodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void btnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ExportarDataGridViewExcel();
                MSG("Exportado con Exito");
            }
            else
            {

            }
        }
        private void ExportarDataGridViewExcel()
        {
            //   SaveFileDialog fichero = new SaveFileDialog();
            // //  fichero.Filter = "Excel (*.xls)|*.xls";
            //   if (fichero.ShowDialog() == DialogResult.OK)
            //   {
            int nume, numer;
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            aplicacion.Visible = true;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            hoja_trabajo.Name = "Fic sin Factura";
            hoja_trabajo.Cells[1, 6] = "FIC SIN LLEGAR FACTURA";

            //FILAS
            for (int i = 0; i < dtgconten.Rows.Count; i++)
            {
                nume = 0;
                for (int j = 0; j < dtgconten.Columns.Count; j++)
                {

                    hoja_trabajo.Cells[i + 3, nume + 1] = dtgconten.Rows[i].Cells[j].Value.ToString();

                    nume++;

                }
            }
            numer = 0;
            //COLUMNAS
            for (int contador = 0; contador < dtgconten.ColumnCount; contador++)
            {

                hoja_trabajo.Cells[2, numer + 1] = dtgconten.Columns[contador].HeaderText.ToString();
                hoja_trabajo.Columns[numer + 1].AutoFit();
                numer++;
            }
            hoja_trabajo.Rows[1].Font.Bold = true;
            hoja_trabajo.Rows[2].Font.Bold = true;
            //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //libros_trabajo.Close(true);
            //aplicacion.Quit();
            //  }
        }
        frmMensajeCorreo mensajito;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                /// MSG(drCOT["correo"].ToString());
                mensajito = new frmMensajeCorreo();
                mensajito.Icon = Icon;
                mensajito.txtmsg.Text = "Es Un Placer Saludarlos para Recordarles " + (char)13 + "que";
                //mensajito.txtmsg.Text = "Hp Reserger S.A.C. " + (char)13 + "Es Un Placer Saludarlos para Recordarles " + (char)13 + "que...";
                mensajito.Text = "Solicitud de Factura";
                mensajito.txtasunto.Text = "Solicitud de Factura";
                mensajito.txtcorreo.Text = dtgconten["email", dtgconten.CurrentCell.RowIndex].Value.ToString().ToLower();
                mensajito.ShowDialog();
                if (mensajito.ok)
                {
                    //MessageBox.Show("La OC Nº " + dtgconten["oc", dtgconten.CurrentCell.RowIndex].Value.ToString() + " se marcó como Enviado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else return;
                }
                else { MSG("Cancelado"); }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                MailMessage email = new MailMessage();
                //CORREO DE PROVEEDOR
                string[] CorreosSeparados = mensajito.txtcorreo.Text.Split(';');
                string CorreoJuntos = string.Join(",", CorreosSeparados);
                email.To.Add(CorreoJuntos);
                ///
                email.From = new MailAddress("v90reyes@hotmail.com");
                email.Subject = mensajito.txtasunto.TextValido();
                email.Priority = mensajito.PrioridadCorreo();
                //email.Body = mensajito.cadena;
                //ContentType alo = new ContentType(MediaTypeNames.Text.RichText);
                //AlternateView fuente = AlternateView.CreateAlternateViewFromString(mensajito.txtmsg.DocumentText, alo);
                //email.AlternateViews.Add(fuente);
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
                email.Body = mensajito.txtmsg.Text;
                ///                       
                email.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("v90reyes@hotmail.com", "Victor123");
                smtp.Send(email);
                email.Dispose();
            }
            catch (Exception ex)
            {
                MSG("Error enviando correo electrónico: " + ex.Message);
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MSG("Correo electrónico a " + mensajito.txtcorreo.Text.ToLower() + " fue enviado satisfactoriamente.");
        }
        private void frmFicSinFaactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                e.Cancel = true;
                MSG("No se Puede Cerrar, Se está Enviando el Correo …");
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CLFicFacturas.ListarFicSinFactura(txtbuscar.Text, fic, proveedor, check, cbodocumento.SelectedIndex.ToString());
        }
    }
}
