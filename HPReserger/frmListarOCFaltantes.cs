using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmListarOCFaltantes : Form
    {
        public frmListarOCFaltantes()
        {
            InitializeComponent();
        }
        int opcion = 0;
        int articulo = 2;
        int servicio = 6;
        int fecha = 0;
        HPResergerCapaLogica.HPResergerCL cllistarfaltantes = new HPResergerCapaLogica.HPResergerCL();
        private void frmListarOCFaltantes_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = cllistarfaltantes.ListarOCFaltantes("", DTINICIO.Value, DTFIN.Value, articulo, servicio, 0, 0);
            DTFIN.Value = DateTime.Now;
        }

        private void btnrefres_Click(object sender, EventArgs e)
        {
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                Clipboard.SetText(dtgconten.CurrentCell.Value.ToString());
                lblmsg.Text = "Copiado";
            }
        }

        private void dtgconten_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void mensajito(string cadena)
        {
            MessageBox.Show(cadena);
        }

        private void dtgconten_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgconten.CurrentCell = dtgconten[e.ColumnIndex, e.RowIndex];
                if (e.Button == MouseButtons.Right)
                {
                    // mnopciones.Show(frmListarOCFaltantes.ActiveForm.);
                }
            }
        }

        private void mnclick_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dtgconten.CurrentCell.Value.ToString());
            lblmsg.Text = "Copiado";
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Clipboard.SetText(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
                lblmsg.Text = "Copiado";
            }
            frmlistarOrdenesfaltantes ordenes = new frmlistarOrdenesfaltantes();
            ordenes.txtcotizacion.Text = dtgconten["cot", dtgconten.CurrentCell.RowIndex].Value.ToString();
            ordenes.txtorden.Text = dtgconten["oc", dtgconten.CurrentCell.RowIndex].Value.ToString();
            ordenes.ShowDialog();
        }

        private void gb3_Enter(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgconten.DataSource = cllistarfaltantes.ListarOCFaltantes(txtbuscar.Text, DTINICIO.Value, DTFIN.Value, articulo, servicio, opcion, fecha);
            }
            catch { }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            opcion = 1;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 2;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 3;
            txtbuscar_TextChanged(sender, e);
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 4;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 5;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 5;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 6;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 7;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 8;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            opcion = 10;
            txtbuscar_TextChanged(sender, e);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 9;
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                articulo = 2;
            }
            else { articulo = 1; }
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                servicio = 6;
            }
            else { servicio = 3; }
            txtbuscar_TextChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fecha = 1;
            }
            else { fecha = 0; }
            txtbuscar_TextChanged(sender, e);
        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void DTINICIO_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void DTFIN_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        DataRow drCOT;
        private void btncorreo_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                drCOT = cllistarfaltantes.ListarDetalleOC((int)dtgconten["cot", dtgconten.CurrentCell.RowIndex].Value);
                // MSG(dtgconten["cot", dtgconten.CurrentCell.RowIndex].Value.ToString());
                if (drCOT != null)
                {
                    /// MSG(drCOT["correo"].ToString());
                    frmMensajeCorreo mensajito = new frmMensajeCorreo();
                    mensajito.txtmsg.Text = "Hp Reserger S.A.C. \nEs Un Placer Saludarlos para Recordarles " + (char)13 + "que ";
                    ///mensajito.txtmsg.Text = "Hp Reserger S.A.C. " + (char)13 + "Es Un Placer Saludarlos para Recordarles " + (char)13 + "que...";
                    mensajito.Text = "Reenvio de Mensaje de Confirmación";
                    mensajito.txtasunto.Text = "Ordenes de Compra Faltantes";
                    mensajito.ShowDialog();
                    if (mensajito.ok)
                    {
                        //MessageBox.Show("La OC Nº " + dtgconten["oc", dtgconten.CurrentCell.RowIndex].Value.ToString() + " se marcó como Enviado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            MailMessage email = new MailMessage();
                            //CORREO DE PROVEEDOR
                            email.To.Add(new MailAddress(drCOT["correo"].ToString()));
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
                            smtp.Credentials = new NetworkCredential("j90orellana@hotmail.com", "Jeffer123!");
                            smtp.Send(email);
                            email.Dispose();
                            MSG("Correo electrónico fue enviado a " + drCOT["correo"].ToString().ToLower() + " satisfactoriamente.");
                        }
                        catch (Exception ex)
                        {
                            MSG("Error enviando correo electrónico: " + ex.Source + " " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
