using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;

namespace SISGEM
{
    public partial class frmCargarSistema : DevExpress.XtraEditors.XtraForm
    {
        public frmCargarSistema()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD CapaDatos = new HPResergerCapaDatos.HPResergerCD();
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            gridControl1.DataSource = CapaDatos.ListaDatosSistema();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtcontenido.Text == "") { XtraMessageBox.Show("Ingresa el Contenido", "error"); return; }
            if (txtversion.Text == "") { XtraMessageBox.Show("Ingresa el version", "error"); return; }


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SISGEM (*.zip)|SISGEM*.zip";
            openFileDialog.Title = "Selecciona un archivo SISGEM.zip";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                byte[] datos = File.ReadAllBytes(rutaArchivo);

                CapaDatos.CargarSistema_Insertar(txtversion.EditValue.ToString(), txtcontenido.EditValue.ToString(), datos);
            }
            CargarDatos();
        }

        private void frmCargarSistema_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
