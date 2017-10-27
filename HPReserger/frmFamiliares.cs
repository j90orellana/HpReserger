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
    public partial class frmFamiliares : Form
    {

        HPResergerCapaLogica.HPResergerCL clFamilia = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public int Item { get; set; }

        public frmFamiliares()
        {
            InitializeComponent();
        }

        private void frmFamiliares_Load(object sender, EventArgs e)
        {
            CargaCombos(cboTipoDocumentoIdentidad, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            CargaCombos(cboVinculoFamiliar, "Id_VinculoFamiliar", "VinculoFamiliar", "TBL_VinculoFamiliar");
            MostrarGrilla();
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clFamilia.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
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
            if (txtOcupacion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Ocupación", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtOcupacion.Focus();
                return;
            }

            clFamilia.EmpleadoFamilia(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboVinculoFamiliar.SelectedValue.ToString()), Convert.ToInt32(cboTipoDocumentoIdentidad.SelectedValue.ToString()), txtNumeroDocumento.Text, 0, "", txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, dtpFecha.Value, txtOcupacion.Text, frmLogin.CodigoUsuario, 1, conviviente, nombreconviviente);
            MessageBox.Show("Vínculo Familiar registrado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            MostrarGrilla();           
        }

        private void Limpiar()
        {
            txtNumeroDocumento.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtNombres.Text = "";
            txtOcupacion.Text = "";
        }

        private void MostrarGrilla()
        {
            Grid.DataSource = clFamilia.ListarEmpleadoFamilia(CodigoDocumento, NumeroDocumento);
            IFormEmpleado FormEmpleado = this.MdiParent as IFormEmpleado;
            if (FormEmpleado != null)
                FormEmpleado.CargarNroHijos(CodigoDocumento, NumeroDocumento);
        }
        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[0].Value != null)
            {
                frmEmpleadosFamiliaresModificar frmEFM = new frmEmpleadosFamiliaresModificar();
                frmEFM.CodigoDocumentoEmpleado = CodigoDocumento;
                frmEFM.NumeroDocumentoEmpleado = NumeroDocumento;
                frmEFM.CodigoDocumentoFamiliar = Convert.ToInt32(Grid.Rows[Item].Cells[0].Value.ToString());
                frmEFM.NumeroDocumentoFamiliar = Grid.Rows[Item].Cells[2].Value.ToString();
                frmEFM.VinculoFamiliar = Convert.ToInt32(Grid.Rows[Item].Cells[3].Value.ToString());
                frmEFM.ApellidoPaterno = Grid.Rows[Item].Cells[5].Value.ToString();
                frmEFM.ApellidoMaterno = Grid.Rows[Item].Cells[6].Value.ToString();
                frmEFM.Nombres = Grid.Rows[Item].Cells[7].Value.ToString();
                frmEFM.FechaNacimiento = Convert.ToDateTime(Grid.Rows[Item].Cells[8].Value.ToString());
                frmEFM.Ocupacion = Grid.Rows[Item].Cells["OCUPACION"].Value.ToString();
                if (Grid["nombreimagen", Item].Value.ToString().Length > 0)
                {
                    frmEFM.txtconviviente.Text = nombreconviviente = Grid["nombreimagen", Item].Value.ToString();
                    byte[] Fotito = new byte[0];
                    Fotito = (byte[])Grid["imagen", Item].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    frmEFM.pbconviviente.Image = Bitmap.FromStream(ms);
                    frmEFM.lklconviviente.Enabled = true;
                }
                else
                { frmEFM.lklconviviente.Enabled = false; frmEFM.txtconviviente.Text = ""; frmEFM.pbconviviente.Image = null; }
                if (frmEFM.ShowDialog() == DialogResult.OK)
                {
                    MostrarGrilla();
                }
            }
        }

        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item = e.RowIndex;
            if (Grid.RowCount > 0)
                btnModificar.Enabled = true;
            else
                btnModificar.Enabled = false;
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 10);
        }
        byte[] conviviente;
        string nombreconviviente;
        private void btnconviviente_Click(object sender, EventArgs e)
        {
            var dialogoAbriArchivoConviviente = new OpenFileDialog();
            dialogoAbriArchivoConviviente.Filter = "Jpg Files|*.jpg";
            dialogoAbriArchivoConviviente.DefaultExt = ".jpg";
            if (dialogoAbriArchivoConviviente.ShowDialog(this) != DialogResult.Cancel)
            {
                txtconviviente.Text = nombreconviviente = dialogoAbriArchivoConviviente.FileName;
                conviviente = File.ReadAllBytes(dialogoAbriArchivoConviviente.FileName);
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                pbconviviente.Image = Image.FromFile(dialogoAbriArchivoConviviente.FileName);
                pbconviviente.Image.Save(_memoryStream, ImageFormat.Jpeg);
                lklconviviente.Enabled = true;
            }
            else
                lklconviviente.Enabled = false;
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto();
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        private void lklconviviente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbconviviente);
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void frmFamiliares_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}