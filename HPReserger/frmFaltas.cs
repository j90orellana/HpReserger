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
    public partial class frmFaltas : Form
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoFaltas = new HPResergerCapaLogica.HPResergerCL();
        DataRow DiasFalta;
        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string NombreFoto { get; set; }

        public frmFaltas()
        {
            InitializeComponent();
        }

        private void frmFaltas_Load(object sender, EventArgs e)
        {
            estado = 1; txtRuta.Text = "";
            groupBox1.Visible = false;
            LimpiarGrillas();
            txtNumeroDocumento.Text = "";
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            dtpInicio.Value = DateTime.Today.Date;
            dtpFin.Value = DateTime.Today.Date;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleadoFaltas.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            DiasInicio(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);

        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void MostrarGrid(int CodigoTipo, string NumeroDocumento)
        {
            Grid.DataSource = clEmpleadoFaltas.ListarFaltas(CodigoTipo, NumeroDocumento);
        }

        private void DiasInicio(int TipoDocumento, string NumeroDocumento, string sStoredProcedureName)
        {
            DataRow EmpleadoVacaciones = clEmpleadoFaltas.ExisteBeneficioEmpleado(TipoDocumento, NumeroDocumento, sStoredProcedureName);
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
                MostrarGrid(TipoDocumento, NumeroDocumento);
                DataRow Contratoactivo = clEmpleadoFaltas.ContratoActivo(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
                if (Contratoactivo != null)
                {
                    groupBox1.Visible = true;
                    groupBox1.Enabled = btnRegistrarFalta.Enabled = btnAdjuntarSustento.Enabled = true;
                    lblmensajito.Text = "EMPLEADO ACTIVO CONTRATO Nº" + Contratoactivo["Nro_Contrato"].ToString();
                    pbFaltas.Visible = false;
                }
                else
                {
                    groupBox1.Enabled = true;
                    groupBox1.Visible = true;
                    btnRegistrarFalta.Enabled = btnAdjuntarSustento.Enabled = false;
                    lblmensajito.Text = "EMPLEADO INACTIVO";
                    btnRegistrarFalta.Enabled = btnAdjuntarSustento.Enabled = false;
                    pbFaltas.Visible = true;
                }
            }
            else
            {
                txtApellidoPaterno.Text = ""; groupBox1.Visible = false; btnRegistrarFalta.Enabled = btnAdjuntarSustento.Enabled = false;
                txtApellidoMaterno.Text = "";
                txtNombres.Text = "";
                txtDias.Text = "";
                txtObservaciones.Text = "";
                LimpiarGrillas();
                TitulosGrillas(); lblmensajito.Text = "";
                pbFoto.Image = null;
            }
        }

        private void Dias(DateTime Inicio, DateTime Fin, int TipoDocumento, string NumeroDocumento)
        {
            DiasFalta = clEmpleadoFaltas.DiasVacaciones(Inicio, Fin);
            if (!DiasFalta.IsNull("DIAS"))
            {
                txtDias.Text = DiasFalta["DIAS"].ToString();
            }
        }

        private void LimpiarGrillas()
        {
            Grid.DataSource = null;
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            Grid.Refresh();
        }

        private void TitulosGrillas()
        {
            if (Grid.Columns.Count == 0)
            {
                Grid.Columns.Add("REGISTRO", "");
                Grid.Columns.Add("CODIGOTIPO", "");
                Grid.Columns.Add("TIPOID", "");
                Grid.Columns.Add("NIDI", "");
                Grid.Columns.Add("FECHAINICIO", "");
                Grid.Columns.Add("FECHAFIN", "");
                Grid.Columns.Add("DIASFLTAS", "");
                Grid.Columns.Add("OBSERVACIONES", "");
            }

            Grid.Columns[0].Width = 0;
            Grid.Columns[0].Visible = false;
            Grid.Columns[0].DataPropertyName = "REGISTRO";

            Grid.Columns[1].Width = 0;
            Grid.Columns[1].Visible = false;
            Grid.Columns[1].DataPropertyName = "CODIGOTIPO";

            Grid.Columns[2].Width = 150;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Grid.Columns[2].HeaderText = "TIPO ID";
            Grid.Columns[2].DataPropertyName = "TIPOID";
            Grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Grid.Columns[3].Width = 80;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns[3].HeaderText = "Nº ID";
            Grid.Columns[3].DataPropertyName = "NID";
            Grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Grid.Columns[4].Width = 80;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[4].HeaderText = "FECHA INI.";
            Grid.Columns[4].DataPropertyName = "FECHAINICIO";
            Grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Grid.Columns[5].Width = 80;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].HeaderText = "FECHA FIN";
            Grid.Columns[5].DataPropertyName = "FECHAFIN";
            Grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Grid.Columns[6].Width = 80;
            Grid.Columns[6].Visible = true;
            Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns[6].HeaderText = "DIAS FALT.";
            Grid.Columns[6].DataPropertyName = "DIASFALTAS";
            Grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Grid.Columns[7].Width = 200;
            Grid.Columns[7].Visible = true;
            Grid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Grid.Columns[7].HeaderText = "OBSERVACIONES";
            Grid.Columns[7].DataPropertyName = "OBSERVACIONES";
            Grid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
        }
        int estado = 0; string ruta;
        private void btnRegistrarFalta_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            if (txtDias.Text.Length == 0 || Convert.ToInt32(txtDias.Text) <= 0)
            {
                MessageBox.Show("Días Inválido", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDias.Focus();
                return;
            }

            if (txtObservaciones.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Observaciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtObservaciones.Focus();
                return;
            }

            if (Foto == null )//&& chkfaltas.Checked == false)
            {
                MessageBox.Show("Seleccione Imagen de Sustento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAdjuntarSustento.Focus();
                return;
            }
            if (Foto == null)
                ruta = "";
            else
                ruta = txtRuta.Text;
            DateTime FechaMaximaFalta;
            DataRow MaximaFecha = clEmpleadoFaltas.MaximaFechaATomarFalta(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
            if (!MaximaFecha.IsNull("FECHA"))
            {
                FechaMaximaFalta = Convert.ToDateTime(MaximaFecha["FECHA"].ToString());

                int Resultado = DateTime.Compare(dtpInicio.Value.Date, FechaMaximaFalta.Date);
                if (Resultado <= 0)
                {
                    MessageBox.Show("Fecha de Inicio debe ser posterior a la última Fecha Fin de Falta", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            clEmpleadoFaltas.EmpleadoFaltas(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, dtpInicio.Value, dtpFin.Value, Convert.ToInt32(txtDias.Text), txtObservaciones.Text, Foto, ruta, estado);
            MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
            MessageBox.Show("Falta registrada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpInicio.Value = DateTime.Today.Date;
            dtpFin.Value = DateTime.Today.Date;
            txtObservaciones.Text = "";
            chkfaltas.Checked = false;
            Foto = null;
        }

        private void btnAdjuntarSustento_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivo.DefaultExt = ".jpg";
            dialogoAbrirArchivo.ShowDialog(this);

            NombreFoto = dialogoAbrirArchivo.FileName.ToString();
            DataRow ExisteBoleta = clEmpleadoFaltas.ExisteImagen("NombreFoto", NombreFoto, "TBL_Empleado_Faltas");
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
                }
            }
            else
            {
                MessageBox.Show("Imagen Asociado a otro Sustento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                CargarFoto(Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value.ToString()), Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[1].Value.ToString()), Grid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else
            {
                pbFoto.Image = null;
            }

        }

        private void CargarFoto(int Registro, int TipoDocumento, string NumeroDocumento)
        {
            DataRow drFoto = clEmpleadoFaltas.ImagenFalta(Registro, TipoDocumento, NumeroDocumento);
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
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 10);
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
        private void pbFoto_Click(object sender, EventArgs e)
        {
            MostrarFoto(pbFoto);
        }

        private void chkfaltas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfaltas.Checked)
            {
                estado = 0; btnAdjuntarSustento.Enabled = false;
            }
            else
            {
                estado = 1; btnAdjuntarSustento.Enabled = true;
            }
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void frmFaltas_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }
    }
}
