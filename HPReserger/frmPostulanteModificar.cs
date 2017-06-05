﻿using System;
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
    public partial class frmPostulanteModificar : Form
    {

        DataTable ListaSolCombo;
        MemoryStream _memoryStream = new MemoryStream();
        public byte[] Foto { get; set; }
        public int Solicitud { get; set; }
        public int CodigoTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string AdjuntarCV { get; set; }
        public string nombreArchivo { get; set; }
        HPResergerCapaLogica.HPResergerCL clPostulanteModificar = new HPResergerCapaLogica.HPResergerCL();

        public frmPostulanteModificar()
        {
            InitializeComponent();
        }

        string cadenita = "";
        private void frmPostulanteModificar_Load(object sender, EventArgs e)
        {
            CargarCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");

            cboTipoDocumento.Text = TipoDocumento;
            txtDocumento.Text = NumeroDocumento;
            txtApellidoPaterno.Text = ApellidoPaterno;
            txtApellidoMaterno.Text = ApellidoMaterno;
            txtNombres.Text = Nombres;
            cadenita = txtAdjuntarCV.Text = AdjuntarCV;
            CargarFoto(CodigoTipoDocumento, NumeroDocumento);

            ListaSolCombo = clPostulanteModificar.ListarSECombo(frmLogin.CodigoUsuario, Solicitud);
            if (ListaSolCombo.Rows.Count > 0)
            {
                cboReasignarSolicitud.ValueMember = "NumeroSolicitud";
                cboReasignarSolicitud.DisplayMember = "NumeroSolicitud";
                cboReasignarSolicitud.DataSource = ListaSolCombo;
            }
            else
            {
                chkReasignarSolicitud.Enabled = false;
                cboReasignarSolicitud.Enabled = false;
            }
        }

        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clPostulanteModificar.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoPaterno.Focus();
            }
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAdjuntarCV.Focus();
            }
        }

        private void CargarFoto(int Tipo, string Numero)
        {
            if (txtAdjuntarCV.Text.Length > 0)
            {
                DataRow drFoto = clPostulanteModificar.CargarCualquierImagenPostulanteEmpleado("Foto", "TBL_Postulante", "Tipo_ID_Postulante", Tipo, "Nro_ID_Postulante", Numero);
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

        private void btnAdjuntarCV_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivo.DefaultExt = ".jpg";
            dialogoAbrirArchivo.ShowDialog(this);

            nombreArchivo = dialogoAbrirArchivo.FileName.ToString();
            if (nombreArchivo != string.Empty)
            {
                DataRow ExisteImagen = clPostulanteModificar.ExisteImagen("NombreFoto", nombreArchivo, "TBL_Postulante");
                if (cadenita != txtAdjuntarCV.Text)
                {
                    if (ExisteImagen != null)
                    {
                        MessageBox.Show("La imagen ya esta asociado a otro Postulante", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivo);
                pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                txtAdjuntarCV.Text = nombreArchivo;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDocumento.Focus();
                return;
            }

            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido Paterno", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            if (txtApellidoMaterno.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido Materno", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoMaterno.Focus();
                return;
            }

            if (txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nombres", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombres.Focus();
                return;
            }

            if (txtAdjuntarCV.Text.Length == 0 || pbFoto.Image == null)
            {
                MessageBox.Show("Seleccione Imagen", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAdjuntarCV.Focus();
                return;
            }
            if (Foto == null)
            {
                Foto = File.ReadAllBytes(txtAdjuntarCV.Text);
            }

            if (chkReasignarSolicitud.Checked == true)
            {
                Solicitud = Convert.ToInt32(cboReasignarSolicitud.Text);
            }
            DataRow ExisteCV = clPostulanteModificar.ExisteImagen("NombreFoto", txtAdjuntarCV.Text, "TBL_Postulante");
            if (cadenita != txtAdjuntarCV.Text)
            {
                if (ExisteCV != null)
                {
                    MessageBox.Show("Imagen de CV ya esta asociado a otro Postulante", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            clPostulanteModificar.PostulanteModificar(CodigoTipoDocumento, NumeroDocumento, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Foto, txtAdjuntarCV.Text, Solicitud);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void chkReasignarSolicitud_Click(object sender, EventArgs e)
        {
            if (ListaSolCombo.Rows.Count > 0)
            {
                if (chkReasignarSolicitud.Checked == true)
                {
                    cboReasignarSolicitud.Enabled = true;
                }
                else
                {
                    cboReasignarSolicitud.Enabled = false;
                }
            }
            else
            {
                cboReasignarSolicitud.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            if (pbFoto.Image != null)
            {
                FrmFoto fotito = new FrmFoto();
                fotito.fotito = pbFoto.Image;
                fotito.Show();
            }
        }
    }
}