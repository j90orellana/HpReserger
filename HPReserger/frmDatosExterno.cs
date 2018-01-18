using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmDatosExterno : Form
    {
        public frmDatosExterno()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoEmpleado;
        public int NroRegsitro = 0;
        public byte[] Foto;
        MemoryStream _memoryStream = new MemoryStream();
        DataTable Valores;
        public void CargarValores()
        {
            Valores = new DataTable();
            Valores.Columns.Add("Codigo", typeof(int));
            Valores.Columns.Add("Valor", typeof(string));
            Valores.Rows.Add(0, "Retener Renta");
            Valores.Rows.Add(10, "No Retenerle Renta");
            Valores.Rows.Add(1, "Certificado de Retención de 5ta Categoría");
            Valores.Rows.Add(2, "Trabaja en otra Empresa");
            cboCertificados.ValueMember = "codigo";
            cboCertificados.DisplayMember = "valor";
            cboCertificados.DataSource = Valores;
        }
        private void frmDatosExterno_Load(object sender, EventArgs e)
        {
            CargarValores();
            lklimagen.Parent = this;
            lklimagen.Top += panel1.Top;
            lklimagen.Left += panel1.Left;
            lklimagen.BringToFront();
            lklimagen.Enabled = false;
            cboCertificados.SelectedValue = 1;

            DataTable DatosEmp = new DataTable();
            DatosEmp = CapaLogica.EmpresasExternas(0, 0, CodigoEmpleado, "", "", 0, 0, 0, null, "", 0, DateTime.Now);
            if (DatosEmp.Rows.Count > 0)
            {
                DataRow DatosF = DatosEmp.Rows[0];
                NroRegsitro = int.Parse(DatosF["Nro_registro"].ToString());
                txtruc.txt.Text = DatosF["ruc_empresa"].ToString();
                txtempresa.Text = DatosF["empresa"].ToString();
                cboCertificados.SelectedValue = int.Parse(DatosF["certificado_declaracion"].ToString());
                numimporte.Num.Text = DatosF["Importe_Ingresos"].ToString();
                numrenta.Num.Text = DatosF["importe_renta5ta"].ToString();
                txtnombreimagen.Text = DatosF["nombre_imagendocumento"].ToString();
                if (DatosF["imagen_documento"].ToString() != null && DatosF["imagen_documento"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Foto = Fotito = (byte[])DatosF["imagen_documento"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbimagen.Image = Bitmap.FromStream(ms);
                    lklimagen.Enabled = true;
                }
                else
                {
                    Foto = null; pbimagen.Image = null; lklimagen.Enabled = false;
                }
            }
            else
            {
                Foto = null; pbimagen.Image = null; lklimagen.Enabled = false;
                NroRegsitro = 0;
                txtruc.txt.Text = "";
                txtempresa.Text = "-ingrese nombre de la empresa-";
                numimporte.Num.Text = "0.00";
                cboCertificados.SelectedIndex = 0;
            }
            iniciar(false);
        }
        public void iniciar(Boolean a)
        {
            txtempresa.Enabled = a;
            txtruc.Enabled = a;
            cboCertificados.Enabled = a;
            btnaceptar.Enabled = a;
            btnModificar.Enabled = !a;
            panel1.Enabled = a;
            btnnuevo.Enabled = !a;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1 || estado == 10)
            {
                if (string.IsNullOrWhiteSpace(txtruc.txt.Text) && (int)cboCertificados.SelectedValue != 0)
                {
                    txtruc.txt.Focus();
                    msg("Ingrese Número de RUC");
                    return;
                }
                if (txtruc.txt.Text.Length < 10 && (int)cboCertificados.SelectedValue != 0)
                {
                    txtruc.txt.Focus();
                    msg("Número de RUC muy Corto");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtempresa.Text) && (int)cboCertificados.SelectedValue != 0)
                {
                    txtempresa.Focus();
                    msg("Ingrese Nombre de la Empresa");
                    return;
                }
                if (txtempresa.Text.ToLower() == "-ingrese nombre de la empresa-" && (int)cboCertificados.SelectedValue != 0)
                {
                    txtempresa.Focus();
                    msg("Ingrese Nombre de la Empresa");
                    return;
                }
                if ((int)cboCertificados.SelectedValue == 1)
                {
                    if (decimal.Parse(numimporte.Num.Text) <= 0)
                    {
                        numimporte.Num.Focus();
                        msg("Importe debe ser Mayor a Cero");
                        return;
                    }
                    if (pbimagen.Image == null)
                    {
                        btnimagen.Focus();
                        msg("Ingrese Imagen de Retención");
                        return;
                    }
                }
                if (NroRegsitro == 0)
                    CapaLogica.EmpresasExternas(1, NroRegsitro, CodigoEmpleado, txtruc.txt.Text, txtempresa.Text, (int)cboCertificados.SelectedValue, decimal.Parse(numimporte.Num.Text), decimal.Parse(numrenta.Num.Text), Foto, txtnombreimagen.Text, frmLogin.CodigoUsuario, comboMesAño1.GetFechaPRimerDia());
                else
                    CapaLogica.EmpresasExternas(2, NroRegsitro, CodigoEmpleado, txtruc.txt.Text, txtempresa.Text, (int)cboCertificados.SelectedValue, decimal.Parse(numimporte.Num.Text), decimal.Parse(numrenta.Num.Text), Foto, txtnombreimagen.Text, frmLogin.CodigoUsuario, comboMesAño1.GetFechaPRimerDia());
                msg("Guardado Con Exito");
                iniciar(false);
                estado = 0;
            }
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                iniciar(false);
                estado = 0;
            }
            else this.Close();
            if (estado == 10) NroRegsitro--;
        }

        private void cboCertificados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboCertificados.SelectedValue == 1)
            {
                panel1.Visible = true; lklimagen.Visible = true;
            }
            else { panel1.Visible = false; lklimagen.Visible = false; }
            if ((int)cboCertificados.SelectedValue == 0)
            { txtempresa.Enabled = false; txtruc.Enabled = false; }
            else { txtempresa.Enabled = true; txtruc.Enabled = true; }
        }
        int estado = 0;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto("Imagen del Certificado");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        private void lklimagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbimagen);
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrirArchivoAnexoFunciones = new OpenFileDialog();
            dialogoAbrirArchivoAnexoFunciones.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAnexoFunciones.DefaultExt = ".jpg";
            dialogoAbrirArchivoAnexoFunciones.ShowDialog(this);
            lklimagen.Enabled = false;
            if (dialogoAbrirArchivoAnexoFunciones.FileName.ToString() != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbimagen.Image = Image.FromFile(dialogoAbrirArchivoAnexoFunciones.FileName.ToString());
                pbimagen.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivoAnexoFunciones.FileName);
                txtnombreimagen.Text = dialogoAbrirArchivoAnexoFunciones.FileName.ToString();
                lklimagen.Enabled = true;
            }
        }

        private void txtempresa_Click(object sender, EventArgs e)
        {
            if (txtempresa.Text.ToUpper() == "-INGRESE NOMBRE DE LA EMPRESA-")
            {
                txtempresa.Text = "";
                txtempresa.ForeColor = Color.Gray;
            }
        }

        private void txtempresa_Leave(object sender, EventArgs e)
        {
            if (txtempresa.Text.Length == 0)
            {
                txtempresa.Text = "-INGRESE NOMBRE DE LA EMPRESA-";
                txtempresa.ForeColor = Color.Gray;
            }
            else
                txtempresa.ForeColor = Color.Black;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            NroRegsitro++;
            estado = 10;
            iniciar(true);
        }
    }
}
