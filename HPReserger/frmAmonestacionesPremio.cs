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
    public partial class frmAmonestacionesPremio : Form
    {

        HPResergerCapaLogica.HPResergerCL clAmonestacionesPremio = new HPResergerCapaLogica.HPResergerCL();
        public int Item { get; set; }

        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string NombreFoto { get; set; }
        public frmAmonestacionesPremio()
        {
            InitializeComponent();
        }

        private void btnAdjuntarSustento_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Length > 0 && Grid.Rows.Count > 0)
            {
                var dialogoAbrirArchivo = new OpenFileDialog();
                dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
                dialogoAbrirArchivo.DefaultExt = ".jpg";
                dialogoAbrirArchivo.ShowDialog(this);

                NombreFoto = dialogoAbrirArchivo.FileName.ToString();
                DataRow ExisteBoleta = clAmonestacionesPremio.ExisteImagen("NombreFoto", NombreFoto, "TBL_Empleado_MemoPremio");
                if (ExisteBoleta == null)
                {
                    if (NombreFoto != string.Empty)
                    {
                        _memoryStream.Position = 0;
                        _memoryStream.SetLength(0);
                        _memoryStream.Capacity = 0;

                        pbFoto.Image = Image.FromFile(NombreFoto);
                        pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                        Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                        txtRuta.Text = NombreFoto;

                        clAmonestacionesPremio.EmpleadoMemoPremioSustento(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, tab.SelectedIndex, Foto, txtRuta.Text);
                        MessageBox.Show("Imagen asociada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Imagen Asociado a otro Sustento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, tab.SelectedIndex);
        }

        private void txtObservacionesMemo_TextChanged(object sender, EventArgs e)
        {
            lblMemo.Text = Convert.ToString(8000 - txtObservacionesMemo.Text.Length) + " Caracteres";
        }

        private void txtObservacionesPremio_TextChanged(object sender, EventArgs e)
        {
            lblPremio.Text = Convert.ToString(8000 - txtObservacionesPremio.Text.Length) + " Caracteres";
        }

        private void frmAmonestacionesPremio_Load(object sender, EventArgs e)
        {
            txtNumeroDocumento.Text = "";
            txtRuta.Text = "";
            txtObservacionesMemo.Text = "";
            txtObservacionesPremio.Text = "";
            pbFoto.Image = null;

            Grid.DataSource = null;
            Grid.Rows.Clear();
            Grid.Refresh();

            TitulosGrillas();

            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            tab.SelectedIndex = 0;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clAmonestacionesPremio.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            DataRow EmpleadoVacaciones = clAmonestacionesPremio.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
                MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 0);
            }
            else
            {
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtNombres.Text = "";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            if (tab.SelectedIndex == 0 && txtObservacionesMemo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Observaciones para el Memorandum", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtObservacionesMemo.Focus();
                return;
            }

            if (tab.SelectedIndex == 1 && txtObservacionesPremio.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Observaciones para la Carta de Premio", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtObservacionesPremio.Focus();
                return;
            }

            int Registro = 0;
            if (tab.SelectedIndex == 0)
            {
                clAmonestacionesPremio.EmpleadoMemoPremio(out Registro, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 0, txtObservacionesMemo.Text);
                txtObservacionesMemo.Text = "";
            }
            else
            {
                clAmonestacionesPremio.EmpleadoMemoPremio(out Registro, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 1, txtObservacionesPremio.Text);
                txtObservacionesPremio.Text = "";
            }

            MessageBox.Show("Se procesó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, tab.SelectedIndex);

            frmMemoPremio frmMP = new frmMemoPremio();

            frmMP.Registro = Registro;
            frmMP.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmMP.NumeroDocumento = txtNumeroDocumento.Text;
            frmMP.TabIndex = tab.SelectedIndex;

            frmMP.ShowDialog();
            return;

        }

        private void MostrarGrid(int TipoDocumento, string NumeroDocumento, int Index)
        {
            Grid.DataSource = clAmonestacionesPremio.ListarMemoPremio(TipoDocumento, NumeroDocumento, Index);
        }

        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.Rows[0].Cells[0].Value != null)
            {
                CargarFoto(Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value.ToString()), Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[1].Value.ToString()), Grid.Rows[e.RowIndex].Cells[3].Value.ToString(), tab.SelectedIndex);
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void CargarFoto(int Registro, int TipoDocumento, string NumeroDocumento, int Tipo)
        {
            DataRow drFoto = clAmonestacionesPremio.ImagenEmpleadoMemoPremio(Registro, TipoDocumento, NumeroDocumento,Tipo);
            if (drFoto["Foto"] != null && drFoto["Foto"].ToString().Length > 0)
            {
                byte[] Fotito = new byte[0];
                Fotito = (byte[])drFoto["Foto"];
                MemoryStream ms = new MemoryStream(Fotito);
                pbFoto.Image = Bitmap.FromStream(ms);
                txtRuta.Text = drFoto["NOMBREFOTO"].ToString();
            }
            else
            {
                pbFoto.Image = null;
                txtRuta.Text = "";
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 15);
        }

        private void TitulosGrillas()
        {
            if (Grid.Columns.Count == 0)
            {
                Grid.Columns.Add("REGISTRO", "");
                Grid.Columns.Add("CODIGOTIPO", "");
                Grid.Columns.Add("TIPOID", "");
                Grid.Columns.Add("NDI", "");
                Grid.Columns.Add("APELLIDOSNOMBRES", "");
                Grid.Columns.Add("OBSERVACIONES", "");
            }

            Grid.Columns[0].Width = 0;
            Grid.Columns[0].Visible = false;
            Grid.Columns[0].DataPropertyName = "REGISTRO";

            Grid.Columns[1].Width = 0;
            Grid.Columns[1].Visible = false;
            Grid.Columns[1].DataPropertyName = "CODIGOTIPO";

            Grid.Columns[2].Width = 0;
            Grid.Columns[2].Visible = false;
            Grid.Columns[2].DataPropertyName = "TIPOID";

            Grid.Columns[3].Width = 0;
            Grid.Columns[3].Visible = false;
            Grid.Columns[3].DataPropertyName = "NID";

            Grid.Columns[4].Width = 0;
            Grid.Columns[4].Visible = false;
            Grid.Columns[4].DataPropertyName = "EMPLEADO";


            Grid.Columns[5].Width = 350;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Grid.Columns[5].HeaderText = "OBSERVACIONES";
            Grid.Columns[5].DataPropertyName = "OBSERVACIONES";
            Grid.Columns[5].ReadOnly = true;

        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[5].Value != null)
            {
                frmMemoPremioObservaciones frmMPO = new frmMemoPremioObservaciones();
                frmMPO.Observaciones = Grid.CurrentRow.Cells[5].Value.ToString();
                frmMPO.ShowDialog();
            }
        }
    }
}