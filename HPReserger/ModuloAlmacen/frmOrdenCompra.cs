using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmOrdenCompra : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clOC = new HPResergerCapaLogica.HPResergerCL();
        public int Item { get; set; }

        DataTable dtOC;
        DataTable dtDetalle;
        public frmOrdenCompra()
        {
            InitializeComponent();
        }
        private void frmOrdenCompra_Load(object sender, EventArgs e)
        {
            Listar(frmLogin.CodigoUsuario);
        }
        private void Listar(int Usuario)
        {
            dtOC = clOC.ListarOrdenesCompra(Usuario);
            if (dtOC.Rows.Count > 0)
            {
                gridOC.DataSource = dtOC;
            }
            else
            {
                gridOC.DataSource = null;
                gridOC.Rows.Clear();
                gridOC.Refresh();
                TitulosGrid(gridOC, 0);

                gridDetalle.DataSource = null;
                gridDetalle.Rows.Clear();
                gridDetalle.Refresh();
                TitulosGrid(gridDetalle, 1);
            }
        }
        DataRow drCOT;
        byte[] ImagenC = null;
        private void gridOC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item = e.RowIndex;
            drCOT = clOC.ListarDetalleOC(Convert.ToInt32(gridOC.Rows[e.RowIndex].Cells[COTIZACION.Name].Value.ToString().Substring(2)));

            if (drCOT != null)
            {
                txtProveedor.Text = drCOT["PROVEEDOR"].ToString();
                txtImporte.Text = drCOT["IMPORTE"].ToString();
                txtFechaEntrega.Text = drCOT["FECHAENTREGA"].ToString();
                txtmoneda.Text = drCOT["MONEDA"].ToString();
                string Imagen = drCOT["IMAGEN"].ToString();
                if (Imagen.Length > 0)
                {
                    ImagenC = (byte[])drCOT["IMAGEN"];
                    MemoryStream sr = new MemoryStream(ImagenC);
                    pbCotizacion.Image = Bitmap.FromStream(sr);
                }

                dtDetalle = clOC.ListarOCDetalle(Convert.ToInt32(gridOC.Rows[e.RowIndex].Cells[ORDENPEDIDO.Name].Value.ToString().Substring(2)));

                if (dtDetalle.Rows.Count > 0)
                {
                    gridDetalle.DataSource = dtDetalle;
                }
                else
                {
                    gridDetalle.DataSource = null;
                    gridDetalle.Rows.Clear();
                    gridDetalle.Refresh();
                }

                if (gridOC.Rows[e.RowIndex].Cells[13].Value.ToString() == "0")
                {
                    TitulosGrid(gridDetalle, 1);
                }
                else
                {
                    TitulosGrid(gridDetalle, 2);
                }
            }
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        frmMensajeCorreo mensajito;
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        string Ruta = "";
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (gridOC.RowCount <= 0) { msg("No hay Datos Datos"); return; }
            if (backgroundWorker1.IsBusy) { msg("Enviando Correo..."); return; }
            //Boolean salir = false;
            OC1 = gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2);
            if (gridOC.RowCount > 0)
                if (msgp("¿ Seguro de Marcar la OC Nº " + gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2) + " como Enviado ?") == DialogResult.Yes)
                {
                    drCOT = clOC.ListarDetalleOC(Convert.ToInt32(gridOC["cotizacion", gridOC.CurrentCell.RowIndex].Value.ToString().Substring(2)));
                    if (drCOT != null)
                        if (string.IsNullOrWhiteSpace(drCOT["correo"].ToString()))
                        {
                            msg("Proveedor " + drCOT["correo"].ToString() + " no tiene correo Electrónico");
                            //if (Message Box.Show("Proveedor No tiene Correo Electrónico, Desea igual enviar", CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            //{
                            //    salir = true;                               
                            //}
                            //else
                            return;
                        }
                    ////Proceso de la Imagen
                    Ruta = Application.CommonAppDataPath + @"\Cotizacion.jpeg";
                    pbCotizacion.Image.Save(Ruta, ImageFormat.Jpeg);
                    ////Mensaje de Correo
                    mensajito = new frmMensajeCorreo();
                    mensajito.Icon = Icon;
                    mensajito.Text = "Mensaje de Aprobación";
                    mensajito.txtasunto.Text = "Cotización Aprobada";
                    //mensajito.txtmsg.Text = "Hp Reserger S.A.C. " + (char)13 + "Es para nosotros un placer aceptar su cotizacion";
                    mensajito.txtmsg.Text = "Es para nosotros un placer aceptar su cotización";
                    mensajito.txtcorreo.Text = drCOT["correo"].ToString().ToLower();
                    ////mensajito.Openfiledatos.FileName = Ruta;
                    mensajito.ShowDialog();
                    if (mensajito.ok)
                    {
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                        else { msg("Orden De compra no enviada"); return; }
                    }
                    else
                    {
                        msg("Orden De compra no enviada");
                    }
                }
            txtFechaEntrega.Text = txtImporte.Text = txtmoneda.Text = txtProveedor.Text = "";
            pbCotizacion.Image = null;
            Listar(frmLogin.CodigoUsuario);

        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (gridOC.RowCount <= 0) { msg("No hay Datos Datos"); return; }
            if (backgroundWorker1.IsBusy) { msg("Enviando Correo..."); return; }
            if (gridOC.RowCount > 0)
            {
                if (msgp("¿ Seguro de Anular la OC Nº " + gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2) + "  ?") == DialogResult.Yes)
                {
                    clOC.UpdateEstado(Convert.ToInt32(gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2)), 0);
                    string OC2 = gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2);
                    Listar(frmLogin.CodigoUsuario);
                    msgOK("La OC Nº " + OC2 + " se Anuló como éxito");
                    txtProveedor.Text = txtImporte.Text = txtFechaEntrega.Text = "";
                }

            }
            else msg("No Hay Ordenes de Compra");
        }

        private void TitulosGrid(DataGridView Grid, int Tipo)
        {
            if (Tipo == 0)
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("ORDENCOMPRA", "");
                    Grid.Columns.Add("COTIZACION", "");
                    Grid.Columns.Add("ORDENPEDIDO", "");
                    Grid.Columns.Add("CODIGOCC", "");
                    Grid.Columns.Add("CENTROCOSTO", "");
                    Grid.Columns.Add("CODIGOPP", "");
                    Grid.Columns.Add("PARTIDAPRESUPUESTO", "");
                    Grid.Columns.Add("CODIGOUSUARIO", "");
                    Grid.Columns.Add("USUARIO", "");
                    Grid.Columns.Add("CODIGOAREA", "");
                    Grid.Columns.Add("AREA", "");
                    Grid.Columns.Add("CODIGOGERENCIA", "");
                    Grid.Columns.Add("GERENCIA", "");
                    Grid.Columns.Add("TIPO", "");
                }

                Grid.Columns[0].Width = 60;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[0].HeaderText = "Nº OC";
                Grid.Columns[0].DataPropertyName = "ORDENCOMPRA";

                Grid.Columns[1].Width = 60;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[1].HeaderText = "Nº COT";
                Grid.Columns[1].DataPropertyName = "COTIZACION";

                Grid.Columns[2].Width = 60;
                Grid.Columns[2].Visible = true;
                Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[2].HeaderText = "Nº OP";
                Grid.Columns[2].DataPropertyName = "ORDENPEDIDO";

                Grid.Columns[3].Width = 0;
                Grid.Columns[3].Visible = false;
                Grid.Columns[3].DataPropertyName = "CODIGOCC";

                Grid.Columns[4].Width = 120;
                Grid.Columns[4].Visible = false;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[4].HeaderText = "CENTRO DE COSTO";
                Grid.Columns[4].DataPropertyName = "CENTROCOSTO";

                Grid.Columns[5].Width = 0;
                Grid.Columns[5].Visible = false;
                Grid.Columns[5].DataPropertyName = "CODIGOPP";

                Grid.Columns[6].Width = 120;
                Grid.Columns[6].Visible = true;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[6].HeaderText = "P. PTO";
                Grid.Columns[6].DataPropertyName = "PARTIDAPRESUPUESTO";

                Grid.Columns[7].Width = 0;
                Grid.Columns[7].Visible = false;
                Grid.Columns[7].DataPropertyName = "CODIGOUSUARIO";

                Grid.Columns[8].Width = 120;
                Grid.Columns[8].Visible = true;
                Grid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[8].HeaderText = "USUARIO";
                Grid.Columns[8].DataPropertyName = "USUARIO";

                Grid.Columns[9].Width = 0;
                Grid.Columns[9].Visible = false;
                Grid.Columns[9].DataPropertyName = "CODIGOAREA";

                Grid.Columns[10].Width = 120;
                Grid.Columns[10].Visible = true;
                Grid.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[10].HeaderText = "AREA";
                Grid.Columns[10].DataPropertyName = "AREA";

                Grid.Columns[11].Width = 0;
                Grid.Columns[11].Visible = false;
                Grid.Columns[11].DataPropertyName = "CODIGOGERENCIA";

                Grid.Columns[12].Width = 120;
                Grid.Columns[12].Visible = true;
                Grid.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[12].HeaderText = "GERENCIA";
                Grid.Columns[12].DataPropertyName = "GERENCIA";

                Grid.Columns[13].Width = 0;
                Grid.Columns[13].Visible = false;
                Grid.Columns[13].DataPropertyName = "TIPO";
            }

            if ((Tipo == 1 || Tipo == 2) && Grid.Columns.Count == 0)
            {
                Grid.Columns.Add("CODIGOARTICULO", "");
                Grid.Columns.Add("ITEM", "");
                Grid.Columns.Add("CODIGOMARCA", "");
                Grid.Columns.Add("MARCA", "");
                Grid.Columns.Add("CODIGOMODELO", "");
                Grid.Columns.Add("MODELO", "");
                Grid.Columns.Add("CANTIDAD", "");

                if (Tipo == 1)
                {
                    Grid.Columns[0].Width = 0;
                    Grid.Columns[0].Visible = false;
                    Grid.Columns[0].DataPropertyName = "CODIGOARTICULO";

                    Grid.Columns[1].Width = 100;
                    Grid.Columns[1].Visible = true;
                    Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Grid.Columns[1].HeaderText = "ITEM";
                    Grid.Columns[1].DataPropertyName = "ITEM";

                    Grid.Columns[2].Width = 0;
                    Grid.Columns[2].Visible = false;
                    Grid.Columns[2].DataPropertyName = "CODIGOMARCA";

                    Grid.Columns[3].Width = 100;
                    Grid.Columns[3].Visible = true;
                    Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Grid.Columns[3].HeaderText = "MARCA";
                    Grid.Columns[3].DataPropertyName = "MARCA";

                    Grid.Columns[4].Width = 0;
                    Grid.Columns[4].Visible = false;
                    Grid.Columns[4].DataPropertyName = "CODIGOMODELO";

                    Grid.Columns[5].Width = 100;
                    Grid.Columns[5].Visible = true;
                    Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Grid.Columns[5].HeaderText = "MODELO";
                    Grid.Columns[5].DataPropertyName = "MODELO";

                    Grid.Columns[6].Width = 100;
                    Grid.Columns[6].Visible = true;
                    Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid.Columns[6].HeaderText = "CANTIDAD";
                    Grid.Columns[6].DataPropertyName = "CANTIDAD";
                }

                if (Tipo == 2)
                {
                    Grid.Columns[0].Width = 0;
                    Grid.Columns[0].Visible = false;
                    Grid.Columns[0].DataPropertyName = "CODIGOARTICULO";

                    Grid.Columns[1].Width = 340;
                    Grid.Columns[1].Visible = true;
                    Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    Grid.Columns[1].HeaderText = "ITEM";
                    Grid.Columns[1].DataPropertyName = "ITEM";

                    Grid.Columns[2].Width = 0;
                    Grid.Columns[2].Visible = false;
                    Grid.Columns[2].DataPropertyName = "CODIGOMARCA";

                    Grid.Columns[3].Width = 0;
                    Grid.Columns[3].Visible = false;
                    Grid.Columns[3].DataPropertyName = "MARCA";

                    Grid.Columns[4].Width = 0;
                    Grid.Columns[4].Visible = false;
                    Grid.Columns[4].DataPropertyName = "CODIGOMODELO";

                    Grid.Columns[5].Width = 0;
                    Grid.Columns[5].Visible = false;
                    Grid.Columns[5].DataPropertyName = "MODELO";

                    Grid.Columns[6].Width = 340;
                    Grid.Columns[6].Visible = true;
                    Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid.Columns[6].HeaderText = "OBSERVACIONES";
                    Grid.Columns[6].DataPropertyName = "CANTIDAD";
                }
            }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) { msg("Enviando Correo..."); return; }
            Listar(frmLogin.CodigoUsuario);
        }
        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbCotizacion.Image != null)
                btndescargar.Visible = true;
        }
        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbCotizacion);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Cotización de {txtProveedor.Text}");
                foto.fotito = fotito.Image;
                foto.Text = $"Cotización de {txtProveedor.Text}";
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }

        private void pbCotizacion_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbCotizacion);
        }
        private void pbCotizacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbCotizacion.Image != null)
                btndescargar.Visible = true;
        }

        private void pbCotizacion_Click(object sender, EventArgs e)
        {

        }
        Boolean Verificar = false;
        string OC1 = "";
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Verificar = true;
                MailMessage email = new MailMessage();
                //CORREO DE PROVEEDOR
                string[] CorreosSeparados = mensajito.txtcorreo.Text.Split(';');
                string CorreoJuntos = string.Join(",", CorreosSeparados);
                email.To.Add(CorreoJuntos);
                ///
                email.From = new MailAddress("v90reyes@hotmail.com");
                email.Subject = mensajito.txtasunto.TextValido();
                email.Priority = mensajito.PrioridadCorreo();
                email.Body = mensajito.txtmsg.Text;
                //ContentType alo = new ContentType();
                //alo.MediaType = MediaTypeNames.Text.RichText;
                //AlternateView fuente;
                //fuente = AlternateView.CreateAlternateViewFromString(mensajito.txtmsg.DocumentText, alo);
                //email.AlternateViews.Add(fuente);

                //ContentType holi= new ContentType(mensajito.txtmsg.Font)
                //AlternateView fuente= AlternateView.CreateAlternateViewFromString()
                //email.AlternateViews.
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
                ////Adjuntamos la foto de la cotizacion
                Attachment Archivox = new Attachment(Ruta);
                email.Attachments.Add(Archivox);
                ////fin del adjunto
                email.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("v90reyes@hotmail.com", "Victor123");
                smtp.Send(email);
                email.Dispose();
                ////Actualizando el Estado de la Orden
                clOC.UpdateEstado(Convert.ToInt32(gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2)), 4);
            }
            catch (Exception ex)
            {
                Verificar = false;
                HPResergerFunciones.frmInformativo.MostrarDialogError("Error enviando correo electrónico: ", ex.Message);
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Verificar)
            {
                msgOK("La OC Nº " + OC1 + " se marcó como Enviado\nCorreo electrónico fue enviado a " + mensajito.txtcorreo.Text + " satisfactoriamente.");
                txtFechaEntrega.Text = txtImporte.Text = txtmoneda.Text = txtProveedor.Text = "";
                pbCotizacion.Image = null;
                btndescargar.Visible = false;
                Listar(frmLogin.CodigoUsuario);
            }
        }
        private void frmOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                e.Cancel = true;
                msg("No se Puede Cerrar, Se está Enviando el Correo …");
            }
        }
        private void btnaprobar_Click(object sender, EventArgs e)
        {
            if (gridOC.RowCount <= 0) { msg("No hay Datos Datos"); return; }
            if (backgroundWorker1.IsBusy) { msg("Enviando Correo..."); return; }
            clOC.UpdateEstado(Convert.ToInt32(gridOC.Rows[Item].Cells[0].Value.ToString().Substring(2)), 4);
            txtFechaEntrega.Text = txtImporte.Text = txtmoneda.Text = txtProveedor.Text = "";
            pbCotizacion.Image = null;
            Listar(frmLogin.CodigoUsuario); btndescargar.Visible = false;
            msgOK("La OC Nº " + OC1 + " se marcó como Enviado");
        }
    }
}
