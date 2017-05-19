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
    public partial class frmDesvinculacion : Form
    {
        HPResergerCapaLogica.HPResergerCL clDesvinculacion = new HPResergerCapaLogica.HPResergerCL();

        public byte[] FotoLiq { get; set; }
        public byte[] FotoCTS { get; set; }
        public byte[] FotoConstanciaTrabajo { get; set; }
        public byte[] FotoRetencionRenta { get; set; }
        public byte[] FotoEvaluacionPracticas { get; set; }
        public byte[] FotoEntrevistaSalida { get; set; }

        MemoryStream _memoryStreamLiq = new MemoryStream();
        MemoryStream _memoryStreamCTS = new MemoryStream();
        MemoryStream _memoryStreamConstanciaTrabajo = new MemoryStream();
        MemoryStream _memoryStreamRetencionRenta = new MemoryStream();
        MemoryStream _memoryStreamEvaluacionPracticas = new MemoryStream();
        MemoryStream _memoryStreamEntrevistaSalida = new MemoryStream();

        public string nombreArchivoLiq { get; set; }
        public string nombreArchivoCTS { get; set; }
        public string nombreArchivoConstanciaTrabajo { get; set; }
        public string nombreArchivoRetencionRenta { get; set; }
        public string nombreArchivoEvaluacionPracticas { get; set; }
        public string nombreArchivoEntrevistaSalida { get; set; }

        public frmDesvinculacion()
        {
            InitializeComponent();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

            DataRow EmpleadoVacaciones = clDesvinculacion.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
            }
            else
            {
                txtApellidoPaterno.Text = txtApellidoMaterno.Text = txtNombres.Text = "";
            }
        }

        private void frmDesvinculacion_Load(object sender, EventArgs e)
        {

            txtNumeroDocumento.Text = "";
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");

        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clDesvinculacion.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnGenerarLiquidacion_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmLiquidacion frmLIQ = new frmLiquidacion();
            frmLIQ.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmLIQ.NumeroDocumento = txtNumeroDocumento.Text;

            frmLIQ.ShowDialog();
        }

        private void btnCTS_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmCTS frmCTS = new frmCTS();
            frmCTS.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmCTS.NumeroDocumento = txtNumeroDocumento.Text;

            frmCTS.ShowDialog();
        }

        private void btnConstanciaTrabajo_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmConstanciaTrabajo frmCT = new frmConstanciaTrabajo();
            frmCT.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmCT.NumeroDocumento = txtNumeroDocumento.Text;

            frmCT.ShowDialog();
        }

        private void btnEvaluacionPracticas_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmEvaludacionPracticas frmEP = new frmEvaludacionPracticas();
            frmEP.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmEP.NumeroDocumento = txtNumeroDocumento.Text;

            frmEP.ShowDialog();
        }

        private void btnEntrevistaSalida_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmEntrevistaSalida frmES = new frmEntrevistaSalida();
            frmES.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmES.NumeroDocumento = txtNumeroDocumento.Text;

            frmES.ShowDialog();
        }

        private void btnRetencionRenta_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmRetencionRenta frmRR = new frmRetencionRenta();
            frmRR.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmRR.NumeroDocumento = txtNumeroDocumento.Text;

            frmRR.ShowDialog();
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 15);
        }

        private void btnAdjuntarLiq_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoLiq = new OpenFileDialog();
            dialogoAbrirArchivoLiq.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoLiq.DefaultExt = ".jpg";
            dialogoAbrirArchivoLiq.ShowDialog(this);

            nombreArchivoLiq = dialogoAbrirArchivoLiq.FileName.ToString();
            if (nombreArchivoLiq != string.Empty)
            {
                _memoryStreamLiq.Position = 0;
                _memoryStreamLiq.SetLength(0);
                _memoryStreamLiq.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoLiq);
                pbFoto.Image.Save(_memoryStreamLiq, ImageFormat.Jpeg);
                FotoLiq = File.ReadAllBytes(dialogoAbrirArchivoLiq.FileName);
                txtLiq.Text = nombreArchivoLiq;
            }
        }

        private void btnAdjuntarCTS_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoCTS = new OpenFileDialog();
            dialogoAbrirArchivoCTS.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoCTS.DefaultExt = ".jpg";
            dialogoAbrirArchivoCTS.ShowDialog(this);

            nombreArchivoCTS = dialogoAbrirArchivoCTS.FileName.ToString();
            if (nombreArchivoCTS != string.Empty)
            {
                _memoryStreamCTS.Position = 0;
                _memoryStreamCTS.SetLength(0);
                _memoryStreamCTS.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoCTS);
                pbFoto.Image.Save(_memoryStreamCTS, ImageFormat.Jpeg);
                FotoCTS = File.ReadAllBytes(dialogoAbrirArchivoCTS.FileName);
                txtCTS.Text = nombreArchivoCTS;
            }
        }

        private void btnAdjuntarConstanciaTrabajo_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoConstanciaTrabajo = new OpenFileDialog();
            dialogoAbrirArchivoConstanciaTrabajo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoConstanciaTrabajo.DefaultExt = ".jpg";
            dialogoAbrirArchivoConstanciaTrabajo.ShowDialog(this);

            nombreArchivoConstanciaTrabajo = dialogoAbrirArchivoConstanciaTrabajo.FileName.ToString();
            if (nombreArchivoConstanciaTrabajo != string.Empty)
            {
                _memoryStreamConstanciaTrabajo.Position = 0;
                _memoryStreamConstanciaTrabajo.SetLength(0);
                _memoryStreamConstanciaTrabajo.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoConstanciaTrabajo);
                pbFoto.Image.Save(_memoryStreamConstanciaTrabajo, ImageFormat.Jpeg);
                FotoConstanciaTrabajo = File.ReadAllBytes(dialogoAbrirArchivoConstanciaTrabajo.FileName);
                txtConstanciaTrabajo.Text = nombreArchivoConstanciaTrabajo;
            }
        }

        private void btnAdjuntarRetencionRenta_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoRetencionRenta = new OpenFileDialog();
            dialogoAbrirArchivoRetencionRenta.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoRetencionRenta.DefaultExt = ".jpg";
            dialogoAbrirArchivoRetencionRenta.ShowDialog(this);

            nombreArchivoRetencionRenta = dialogoAbrirArchivoRetencionRenta.FileName.ToString();
            if (nombreArchivoRetencionRenta != string.Empty)
            {
                _memoryStreamRetencionRenta.Position = 0;
                _memoryStreamRetencionRenta.SetLength(0);
                _memoryStreamRetencionRenta.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoRetencionRenta);
                pbFoto.Image.Save(_memoryStreamRetencionRenta, ImageFormat.Jpeg);
                FotoRetencionRenta = File.ReadAllBytes(dialogoAbrirArchivoRetencionRenta.FileName);
                txtRetencionRenta.Text = nombreArchivoRetencionRenta;
            }
        }

        private void btnAdjuntarEvaluacionPracticas_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoEvaluacionPracticas = new OpenFileDialog();
            dialogoAbrirArchivoEvaluacionPracticas.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoEvaluacionPracticas.DefaultExt = ".jpg";
            dialogoAbrirArchivoEvaluacionPracticas.ShowDialog(this);

            nombreArchivoEvaluacionPracticas = dialogoAbrirArchivoEvaluacionPracticas.FileName.ToString();
            if (nombreArchivoEvaluacionPracticas != string.Empty)
            {
                _memoryStreamEvaluacionPracticas.Position = 0;
                _memoryStreamEvaluacionPracticas.SetLength(0);
                _memoryStreamEvaluacionPracticas.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoEvaluacionPracticas);
                pbFoto.Image.Save(_memoryStreamEvaluacionPracticas, ImageFormat.Jpeg);
                FotoEvaluacionPracticas = File.ReadAllBytes(dialogoAbrirArchivoEvaluacionPracticas.FileName);
                txtEvaluacionPracticas.Text = nombreArchivoEvaluacionPracticas;
            }
        }

        private void btnAdjuntarEntrevistaSalida_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;

            var dialogoAbrirArchivoEntrevistaSalida = new OpenFileDialog();
            dialogoAbrirArchivoEntrevistaSalida.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoEntrevistaSalida.DefaultExt = ".jpg";
            dialogoAbrirArchivoEntrevistaSalida.ShowDialog(this);

            nombreArchivoEntrevistaSalida = dialogoAbrirArchivoEntrevistaSalida.FileName.ToString();
            if (nombreArchivoEntrevistaSalida != string.Empty)
            {
                _memoryStreamEntrevistaSalida.Position = 0;
                _memoryStreamEntrevistaSalida.SetLength(0);
                _memoryStreamEntrevistaSalida.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivoEntrevistaSalida);
                pbFoto.Image.Save(_memoryStreamEntrevistaSalida, ImageFormat.Jpeg);
                FotoEntrevistaSalida = File.ReadAllBytes(dialogoAbrirArchivoEntrevistaSalida.FileName);
                txtEntrevistaSalida.Text = nombreArchivoEntrevistaSalida;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("Seleccione Imagen", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (txtLiq.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoLiq, txtLiq.Text, 1);
            }

            if (txtCTS.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoCTS, txtCTS.Text, 2);
            }

            if (txtConstanciaTrabajo.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoConstanciaTrabajo, txtConstanciaTrabajo.Text, 3);
            }

            if (txtRetencionRenta.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoRetencionRenta, txtRetencionRenta.Text, 4);
            }

            if (txtEvaluacionPracticas.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoEvaluacionPracticas, txtEvaluacionPracticas.Text, 5);
            }

            if (txtEntrevistaSalida.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoEntrevistaSalida, txtEntrevistaSalida.Text, 6);
            }

            MessageBox.Show("Desvinculación Grabada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLiq.Text = "";
            txtCTS.Text = "";
            txtConstanciaTrabajo.Text = "";
            txtRetencionRenta.Text = "";
            txtEvaluacionPracticas.Text = "";
            txtEntrevistaSalida.Text = "";
            pbFoto.Image = null;
        }
    }
}
