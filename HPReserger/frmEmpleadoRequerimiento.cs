
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmEmpleadoRequerimiento : Form
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoRequerimiento = new HPResergerCapaLogica.HPResergerCL();

        public int CodigoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmEmpleadoRequerimiento()
        {
            InitializeComponent();
        }

        private void frmEmpleadoRequerimiento_Load(object sender, EventArgs e)
        {
            //CodigoDocumento = 1;
            //NumeroDocumento = "0701046971";

            cboCelular.SelectedIndex = cboCorreo.SelectedIndex = cboMaquina.SelectedIndex = cboOtros.SelectedIndex = 1;

            DataRow ExisteRequerimiento = clEmpleadoRequerimiento.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_Requerimiento", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExisteRequerimiento != null)
            {
                cboCelular.Text = ExisteRequerimiento["CELULAR"].ToString();
                txtObservacionesCelular.Text = ExisteRequerimiento["CELULAR_OBS"].ToString();
                cboMaquina.Text = ExisteRequerimiento["PC"].ToString();
                txtObservacionesMaquina.Text = ExisteRequerimiento["PC_OBS"].ToString();
                cboCorreo.Text = ExisteRequerimiento["CORREO"].ToString();
                txtObservacionesCorreo.Text = ExisteRequerimiento["CORREO_OBS"].ToString();
                cboOtros.Text = ExisteRequerimiento["OTROS"].ToString();
                txtObservacionesOtros.Text = ExisteRequerimiento["OTROS_OBS"].ToString();

                if (ExisteRequerimiento["Imagen"] != null && ExisteRequerimiento["Imagen"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Foto = Fotito = (byte[])ExisteRequerimiento["Imagen"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbimagen.Image = Bitmap.FromStream(ms);
                    txtimagen.Text = ExisteRequerimiento["NombreImagen"].ToString();
                }
                else
                {
                    pbimagen.Image = null;
                    Foto = null; txtimagen.Text = "";
                }
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
                btnexportar.Enabled = true;
            }
            else
            {
                btnexportar.Enabled = false;
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
            btnaceptar.Enabled = false;
            pnlconten.Enabled = false;
            lklimagen.BringToFront();
        }

        private void cboCelular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCelular.SelectedIndex == 0)
            {
                //  txtObservacionesCelular.Text = "";
                txtObservacionesCelular.ReadOnly = false;
                txtObservacionesCelular.Focus();
            }
            else
            {
                txtObservacionesCelular.Text = "";
                txtObservacionesCelular.ReadOnly = true;
            }
        }

        private void cboMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaquina.SelectedIndex == 0)
            {
                // txtObservacionesMaquina.Text = "";
                txtObservacionesMaquina.ReadOnly = false;
                txtObservacionesMaquina.Focus();
            }
            else
            {
                txtObservacionesMaquina.Text = "";
                txtObservacionesMaquina.ReadOnly = true;
            }
        }

        private void cboCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCorreo.SelectedIndex == 0)
            {
                // txtObservacionesCorreo.Text = "";
                txtObservacionesCorreo.ReadOnly = false;
                txtObservacionesCorreo.Focus();
            }
            else
            {
                txtObservacionesCorreo.Text = "";
                txtObservacionesCorreo.ReadOnly = true;
            }
        }

        private void cboOtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOtros.SelectedIndex == 0)
            {
                //  txtObservacionesOtros.Text = "";
                txtObservacionesOtros.ReadOnly = false;
                txtObservacionesOtros.Focus();
            }
            else
            {
                txtObservacionesOtros.Text = "";
                txtObservacionesOtros.ReadOnly = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            estado = 1;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
            btnexportar.Enabled = false;
        }

        private void GrabarEditar(int Opcion)
        {
            clEmpleadoRequerimiento.EmpleadoRequerimiento(CodigoDocumento, NumeroDocumento, cboCorreo.SelectedItem.ToString(), txtObservacionesCorreo.Text, cboCelular.SelectedItem.ToString(), txtObservacionesCelular.Text, cboMaquina.SelectedItem.ToString(), txtObservacionesMaquina.Text, cboOtros.SelectedItem.ToString(), txtObservacionesOtros.Text, frmLogin.CodigoUsuario, Opcion, txtimagen.Text, Foto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
            btnexportar.Enabled = false;
        }
        int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {

                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                if (estado == 1)
                {
                    btnRegistrar.Enabled = true;
                    btnModificar.Enabled = false; btnexportar.Enabled = true;
                }
                if (estado == 2)
                {
                    btnRegistrar.Enabled = false;
                    btnModificar.Enabled = true; btnexportar.Enabled = true;
                }
            }
            if (estado == 0)
            {
                this.Close();
            }
            estado = 0;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                DataRow Existe = clEmpleadoRequerimiento.ExisteBeneficioEmpleado(CodigoDocumento, NumeroDocumento, "usp_ExisteRequerimientoEmpleado");
                if (Existe != null)
                {
                    MessageBox.Show("Empleado ya cuenta el presente Benefico, NO se puede registrar", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                GrabarEditar(1);
                MessageBox.Show("Requerimiento ingresado con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false; btnModificar.Enabled = true; btnexportar.Enabled = true;
            }
            if (estado == 2)
            {
                GrabarEditar(0);
                MessageBox.Show("Requerimiento actualizado con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false; btnModificar.Enabled = true; btnexportar.Enabled = true;
            }
        }

        private void pnlconten_Paint(object sender, PaintEventArgs e)
        {

        }
        /*     private void PBExportarPDF_Click(object sender, EventArgs e, string path)
             {
                 //  try
                 //    {
                 Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                 string ReportePDF = path;
                 FileStream file = new FileStream(ReportePDF, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                 PdfWriter.GetInstance(doc, file);
                 doc.Open();
                 GenerarDocumento(doc);
                 doc.Close();
                 Process.Start(ReportePDF);
                 //       }
                 //    catch (Exception ex)
                 //   {
                 //     MessageBox.Show(ex.Message + " --" + ex.StackTrace.ToString());
                 //   }

             }*/


        public float[] GetTamanioColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        /*     public void GenerarDocumento(Document document)
             {
                 //se crea un objeto PdfTable con el numero de columnas del dataGridView 
                 PdfPTable datatable = new PdfPTable(DtgConten.ColumnCount);//asignamos algunas propiedades para el diseño del pdf 
                 datatable.DefaultCell.Padding = 3;
                 float[] headerwidths = GetTamanioColumnas(DtgConten);
                 datatable.SetWidths(headerwidths); datatable.WidthPercentage = 100;
                 datatable.DefaultCell.BorderWidth = 2;
                 datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                 //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 

                 for (int i = 0; i < DtgConten.ColumnCount; i++)
                 {
                     datatable.AddCell(DtgConten.Columns[i].HeaderText);
                 }

                 datatable.HeaderRows = 1; datatable.DefaultCell.BorderWidth = 1;
                 //SE GENERA EL CUERPO DEL PDF
                 for (int i = 0; i < DtgConten.RowCount; i++)
                 {
                     for (int j = 0; j < DtgConten.ColumnCount; j++)
                     {
                         if (DtgConten[j, i].Value.ToString()==string.Empty)
                             datatable.AddCell("");
                         else
                             datatable.AddCell(DtgConten[j, i].Value.ToString());
                     }
                     datatable.CompleteRow();
                 }

                 //SE AGREGAR LA PDFPTABLE AL DOCUMENTO
                 document.Add(datatable);
             }*/

        private void btnexportar_Click(object sender, EventArgs e)
        {
            //  savefile.FileName = NumeroDocumento + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year;

            //    if (!string.IsNullOrWhiteSpace(savefile.FileName) && savefile.ShowDialog() == DialogResult.OK)
            //    {
            //DtgConten.DataSource = clEmpleadoRequerimiento.ExportarRequerimientos(NumeroDocumento, CodigoDocumento + "");
            //PBExportarPDF_Click(sender, e, savefile.FileName);
            frmRPTExportarRequerimiento reporterequerimientos = new frmRPTExportarRequerimiento();
            reporterequerimientos.numerodocumento = NumeroDocumento;
            reporterequerimientos.codigodocumento = CodigoDocumento + "";
            reporterequerimientos.ShowDialog();
            //requeri.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, savefile.FileName);
            //   }
        }
        MemoryStream _memoryStream = new MemoryStream();
        public byte[] Foto { get; set; }
        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrirArchivoOtros = new OpenFileDialog();
            dialogoAbrirArchivoOtros.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoOtros.DefaultExt = ".jpg";
            dialogoAbrirArchivoOtros.ShowDialog(this);
            txtimagen.Text = dialogoAbrirArchivoOtros.FileName.ToString();
            if (dialogoAbrirArchivoOtros.FileName != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbimagen.Image = Image.FromFile(dialogoAbrirArchivoOtros.FileName);
                pbimagen.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivoOtros.FileName);
            }
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto("Imagen de Requerimientos");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        private void lklimagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbimagen);
        }
    }
}
