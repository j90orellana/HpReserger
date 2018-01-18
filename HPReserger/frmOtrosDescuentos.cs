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
    public partial class frmOtrosDescuentos : Form
    {
        public frmOtrosDescuentos()
        {
            InitializeComponent();
        }
        public int estado = 0;
        public int tipodoc; MemoryStream _memoryStreamDsc = new MemoryStream();
        string nombredescuento;
        public byte[] Foto { get; set; }
        public string numerodoc;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int desvinculacion;
        private void frmOtrosDescuentos_Load(object sender, EventArgs e)
        {
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            //txtdescuento.Text = tipodoc.ToString();
            cboTipoDocumento.SelectedValue = tipodoc;
            txtNumeroDocumento.Text = numerodoc;
            Iniciar(false);
            btneliminar.Enabled = btnmodificar.Enabled = false;
            //txt.Text = desvinculacion.ToString();
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.DesvinculacionOtrosDscto(0, desvinculacion, tipodoc, numerodoc, "", 0, null, "", frmLogin.CodigoUsuario);

        }
        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = CapaLogica.getCargoTipoContratacion(codigo, descripcion, tabla);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                Iniciar(false);
                CargarDatos();
            }
            else
            {
                this.Close();
            }
        }
        public void Iniciar(Boolean a)
        {
            txtmotivo.Enabled = a;
            txtimporte.Enabled = a;
            btnaceptar.Enabled = a;
            btnaddfoto.Enabled = a;
            btnmodificar.Enabled = !a;
            btneliminar.Enabled = !a;
            btnnuevo.Enabled = !a;
            dtgconten.Enabled = !a;
        }
        private void panelOre2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Iniciar(true);
            estado = 1;
            txtmotivo.Text = "";
            txtimporte.Num.Text = "0.00";
            txtdescuento.Text = "";
            nombredescuento = "";
            Foto = null;
        }
        int regis = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Iniciar(true);
            estado = 2;
            regis = (int)dtgconten[registro.Name, dtgconten.CurrentCell.RowIndex].Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pbdescuento.Image = null;

            var dialogoAbrirArchivoLiq = new OpenFileDialog();
            dialogoAbrirArchivoLiq.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoLiq.DefaultExt = ".jpg";
            dialogoAbrirArchivoLiq.ShowDialog(this);
            nombredescuento = dialogoAbrirArchivoLiq.FileName.ToString();
            if (nombredescuento != string.Empty)
            {
                _memoryStreamDsc.Position = 0;
                _memoryStreamDsc.SetLength(0);
                _memoryStreamDsc.Capacity = 0;

                pbdescuento.Image = Image.FromFile(nombredescuento);
                pbdescuento.Image.Save(_memoryStreamDsc, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivoLiq.FileName);
                txtdescuento.Text = nombredescuento; lkldescuento.Enabled = true;
            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0)
            {
                btnmodificar.Enabled = true; btneliminar.Enabled = true;
                txtmotivo.Text = dtgconten[Motivo.Name, fila].Value.ToString();
                txtimporte.Num.Text = dtgconten[Importe.Name, fila].Value.ToString();
                if (dtgconten[dscto.Name, fila].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Foto = Fotito = (byte[])dtgconten[dscto.Name, fila].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbdescuento.Image = Bitmap.FromStream(ms);
                    nombredescuento = txtdescuento.Text = dtgconten[nombre_dscto.Name, fila].Value.ToString();
                }
                else
                {
                    pbdescuento.Image = null;
                    Foto = null; nombredescuento = "";
                    txtdescuento.Text = "";
                }
            }
            else
            {
                btnmodificar.Enabled = false; btneliminar.Enabled = false;
            }
        }
        private void lkldescuento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbdescuento);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Imagen de Descuentos ");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.Text = "Imagen Descuento";
                foto.ShowDialog();
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtmotivo.EstaLLeno())
            {
                msg("Ingrese Motivo");
                txtmotivo.Focus();
                return;
            }
            if (decimal.Parse(txtimporte.Num.Text) <= 0)
            {
                msg("Ingrese Importe");
                txtimporte.Num.Focus();
                return;
            }
            if (estado == 1)
            {
                CapaLogica.DesvinculacionOtrosDscto(1, desvinculacion, tipodoc, numerodoc, txtmotivo.Text, decimal.Parse(txtimporte.Num.Text), Foto, nombredescuento, frmLogin.CodigoUsuario);
                msg("Agregado Con Exito");
                estado = 0;
                CargarDatos();
                Iniciar(false);
            }
            if (estado == 2)
            {
                CapaLogica.DesvinculacionOtrosDscto(2, desvinculacion, tipodoc, numerodoc, txtmotivo.Text, decimal.Parse(txtimporte.Num.Text), Foto, nombredescuento, regis);
                msg("Actualizado Con Exito");
                estado = 0;
                CargarDatos();
                Iniciar(false);
            }

        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "Hp Reseger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
                if (MSG("Desea Eliminar Registro") == DialogResult.OK)
                {
                    regis = (int)dtgconten[registro.Name, dtgconten.CurrentCell.RowIndex].Value;
                    CapaLogica.DesvinculacionOtrosDscto(10, regis, tipodoc, numerodoc, "", 0, null, "", desvinculacion);
                    msg("Eliminado Con Exito");
                    CargarDatos();
                }
        }
    }
}
