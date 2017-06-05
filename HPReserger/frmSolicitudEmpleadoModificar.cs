using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HPReserger
{
    public partial class frmSolicitudEmpleadoModificar : Form
    {
        HPResergerCapaLogica.HPResergerCL clModificarSE = new HPResergerCapaLogica.HPResergerCL();
        MemoryStream _memoryStream = new MemoryStream();
        public byte[] Foto { get; set; }
        public string nombreArchivo { get; set; }

        public string Solicitud { get; set; }
        public string Busqueda { get; set; }
        public string Terna { get; set; }
        public int Puestos { get; set; }
        public string Cargo { get; set; }
        public string Tipo { get; set; }
        public string Adjuntar { get; set; }
        public string NOS { get; set; }

        public frmSolicitudEmpleadoModificar()
        {
            InitializeComponent();
        }

        private void frmSolicitudEmpleadoModificar_Load(object sender, EventArgs e)
        {
            CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
            CargarCombos(cboTipoContratacion, "Id_TipoContratacion", "TipoContratacion", "TBL_TipoContratacion");

            cboOS.ValueMember = "NOS";
            cboOS.DisplayMember = "NOS";
            cboOS.DataSource = clModificarSE.ListarComboSE(frmLogin.CodigoUsuario);

            cboBusqueda.SelectedIndex = 0;
            cboTerna.SelectedIndex = 0;

            txtSolicitud.Text = Convert.ToString(Solicitud);
            txtOS.Text = NOS;
            cboBusqueda.Text = Busqueda;
            cboTerna.Text = Terna;
            txtPuestos.Text = Convert.ToString(Puestos);
            cboCargoPuesto.Text = Cargo;
            cboTipoContratacion.Text = Tipo;
            txtAdjunto.Text = Adjuntar;
            CargarFoto(Convert.ToInt32(Solicitud.Substring(2)));

        }

        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clModificarSE.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtPuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedIndex == 1)
            {
                chkCambiar.Enabled = false;
                chkCambiar.Checked = false;
                cboOS.Enabled = false;
                txtOS.Text = "";
            }
            else
            {
                chkCambiar.Enabled = true;
                chkCambiar.Checked = true;
                cboOS.Enabled = true;

                if (NOS.Length == 0)
                {
                    txtOS.Text = cboOS.Text;
                }
                else
                {
                    txtOS.Text = NOS;
                }
            }
        }

        private void CargarFoto(int SE)
        {
            if (txtAdjunto.Text.Length > 0)
            { 
                DataRow drFoto = clModificarSE.CargarImagenSolicitudEmpleado(SE);
                if (drFoto["Foto"] != null && drFoto["Foto"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Fotito = (byte[])drFoto["Foto"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFoto.Image = Bitmap.FromStream(ms);
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void btnBuscarJPG_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivo.DefaultExt = ".jpg";
            dialogoAbrirArchivo.ShowDialog(this);

            nombreArchivo = dialogoAbrirArchivo.FileName.ToString();
            if (nombreArchivo != string.Empty)
            {
                DataRow ExisteImagen = clModificarSE.ExisteImagen("NombreFoto", nombreArchivo, "TBL_SolicitaEmpleado");
                if (ExisteImagen != null)
                {
                    MessageBox.Show("La imagen ya esta asociadao a otra Solicitud", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivo);
                pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                txtAdjunto.Text = nombreArchivo;
            }
        }

        private void chkCambiar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCambiar.Checked == true)
            {
                cboOS.Enabled = true;
            }
            else
            {
                cboOS.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Foto == null)
            {
                Foto = File.ReadAllBytes(txtAdjunto.Text);
            }

            if (txtPuestos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Cant. Puestos", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPuestos.Focus();
                return;
            }

            if (Convert.ToInt32(txtPuestos.Text) == 0)
            {
                MessageBox.Show("Cant. Puestos NO puede ser cero", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPuestos.Focus();
                return;
            }

            int OC = 0;
            if (cboBusqueda.SelectedIndex == 0 && chkCambiar.Checked == false)
            {
                OC = Convert.ToInt32(txtOS.Text.Substring(2));
            }

            if (cboBusqueda.SelectedIndex == 0 && chkCambiar.Checked == true)
            {
                if (cboOS.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Orden de Servicio", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cboOS.Focus();
                    return;
                }
                else
                {
                    OC = Convert.ToInt32(cboOS.Text.Substring(2));
                }
            }

            clModificarSE.SolicitudEmpleadoModificar(Convert.ToInt32(txtSolicitud.Text.Substring(2)), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString(), cboTerna.SelectedItem.ToString(), Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text);
            MessageBox.Show("Solicitud modificada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            FrmFoto foto = new FrmFoto();
            foto.fotito = pbFoto.Image;
            foto.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}