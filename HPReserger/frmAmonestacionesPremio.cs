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
            btneliminar.Enabled = false;
            btnmodificiar.Enabled = false;
            if (ESTADO == 1)
            {
                if (tab.SelectedIndex != TABINDEX)
                {
                    tab.SelectedIndex = TABINDEX;
                    btneliminar.Enabled = false;
                    btnmodificiar.Enabled = false;
                    return;
                }
            }
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
        // DataTable Inicial;
        private void frmAmonestacionesPremio_Load(object sender, EventArgs e)
        {
            // Inicial = new DataTable();
            txtNumeroDocumento.Text = "";
            txtRuta.Text = "";
            txtObservacionesMemo.Text = "";
            txtObservacionesPremio.Text = "";
            pbFoto.Image = null;

            //  Inicial = ((DataTable)Grid.DataSource).Clone();

            //TitulosGrillas();

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
            btnmodificiar.Enabled = false;
            btneliminar.Enabled = false;
            DataRow EmpleadoVacaciones = clAmonestacionesPremio.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
                MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 0);

                DataRow Contratoactivo = clAmonestacionesPremio.ContratoActivo(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
                if (Contratoactivo != null)
                {
                    tab.Enabled = btnGenerar.Enabled = true;
                    lblmensajito.Text = "EMPLEADO ACTIVO CONTRATO Nº" + Contratoactivo["Nro_Contrato"].ToString();
                    btnAdjuntarSustento.Enabled = true;
                    tab.Enabled = true;
                    btnGenerar.Enabled = true;
                    btnAdjuntarSustento.Enabled = true;
                }
                else
                {
                    btnGenerar.Enabled = false;
                    btnAdjuntarSustento.Enabled = false;
                    tab.Enabled = false;
                    btnAdjuntarSustento.Enabled = false;
                    tab.Enabled = btnGenerar.Enabled = false;
                    lblmensajito.Text = "EMPLEADO INACTIVO";
                    btnmodificiar.Enabled = false;
                    btneliminar.Enabled = false;
                }
            }
            else
            {
                if (Grid.RowCount > 0)
                {
                    DataTable Filas = ((DataTable)Grid.DataSource).Clone();
                    Grid.DataSource = Filas;
                }
                tab.Enabled = false;
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtNombres.Text = txtObservacionesMemo.Text = "";
                pbFoto.Image = null; lblmensajito.Text = "";
                txtRuta.Text = "";
                btnGenerar.Enabled = false;
                btnAdjuntarSustento.Enabled = false;
                btnmodificiar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int Registrox = 0;
            if (ESTADO == 0)
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


                if (tab.SelectedIndex == 0)
                {
                    clAmonestacionesPremio.EmpleadoMemoPremio(out Registrox, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 0, txtObservacionesMemo.Text);
                    txtObservacionesMemo.Text = "";
                }
                else
                {
                    clAmonestacionesPremio.EmpleadoMemoPremio(out Registrox, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, 1, txtObservacionesPremio.Text);
                    txtObservacionesPremio.Text = "";
                }

                MessageBox.Show("Se procesó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int x = Grid.CurrentCell.RowIndex;
                string caden = "";
                if (tab.SelectedIndex == 0)
                    caden = txtObservacionesMemo.Text;
                else
                    caden = txtObservacionesPremio.Text;
                Registrox = (int)Grid[Registro.Name, x].Value;
                clAmonestacionesPremio.ActualizarMemoPremio(Registrox, (int)Grid[CODIGOTIPO.Name, x].Value, Grid[NDI.Name, x].Value.ToString(), tab.SelectedIndex, caden);
                msg("Actualizado con Exito");
                btncancelar_Click(sender, e);
            }
            MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, tab.SelectedIndex);

            frmMemoPremio frmMP = new frmMemoPremio();

            frmMP.Registro = Registrox;
            frmMP.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmMP.NumeroDocumento = txtNumeroDocumento.Text;
            frmMP.TabIndexa = tab.SelectedIndex;

            frmMP.ShowDialog();
            return;

        }

        private void MostrarGrid(int TipoDocumento, string NumeroDocumento, int Index)
        {
            Grid.DataSource = clAmonestacionesPremio.ListarMemoPremio(TipoDocumento, NumeroDocumento, Index);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (Grid.Rows.Count > 0)
            {
                btneliminar.Enabled = true;
                btnmodificiar.Enabled = true;
                CargarFoto(Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value.ToString()), Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[1].Value.ToString()), Grid.Rows[e.RowIndex].Cells[3].Value.ToString(), tab.SelectedIndex);
            }
            else
            {
                pbFoto.Image = null;
                btneliminar.Enabled = false;
                btnmodificiar.Enabled = false;
            }
        }

        private void CargarFoto(int Registro, int TipoDocumento, string NumeroDocumento, int Tipo)
        {
            DataRow drFoto = clAmonestacionesPremio.ImagenEmpleadoMemoPremio(Registro, TipoDocumento, NumeroDocumento, Tipo);
            if (drFoto["Foto"] != null)
                if (drFoto["Foto"].ToString().Length > 0)
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

        private void frmAmonestacionesPremio_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFoto, $"Foto de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }
        public void MostrarFoto(PictureBox fotito, string Nombre)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto(Nombre);
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        DataTable tablita;
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount > 0)
            {
                tablita = new DataTable();
                tablita = clAmonestacionesPremio.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
                if (MSG("Desea Eliminar Registro?") == DialogResult.OK)
                    if (tablita.Rows.Count != 0)
                    {
                        int x = Grid.CurrentCell.RowIndex;
                        DataRow filita = tablita.Rows[0];
                        string cade = Grid[Registro.Name, x].Value.ToString() + "," + Grid[CODIGOTIPO.Name, x].Value.ToString() + ",'" + Grid[NDI.Name, x].Value.ToString() + "'," + tab.SelectedIndex;
                        clAmonestacionesPremio.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_EliminarMemoPremio", cade, 0, frmLogin.CodigoUsuario, "Solicita Eliminar Amonestación a " + Grid["APELLIDOSNOMBRES", Grid.CurrentCell.RowIndex].Value.ToString());

                        msg("Solicitud Enviada a su Jefe");
                    }
                    else msg("No se Encuentra el Código del Jefe");
            }
            else
            {
                msg("No hay Que Eliminar");
            }
        }
        int ESTADO = 0; int TABINDEX = 0;
        private void btnmodificiar_Click(object sender, EventArgs e)
        {
            ESTADO = 1;
            TABINDEX = tab.SelectedIndex;
            int x = Grid.CurrentCell.RowIndex;
            if (x < 0)
            {
                msg("No hay que Modificar");
                return;
            }
            else
            {
                txtNumeroDocumento.Enabled = false;
                cboTipoDocumento.Enabled = false;
                btnmodificiar.Enabled = false;
                btneliminar.Enabled = false;
                Grid.Enabled = false;
                if (tab.SelectedIndex == 0)
                {
                    txtObservacionesMemo.Text = Grid[OBSERVACIONES.Name, x].Value.ToString();
                }
                else
                {
                    txtObservacionesPremio.Text = Grid[OBSERVACIONES.Name, x].Value.ToString();
                }
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (ESTADO != 0)
            {
                btnmodificiar.Enabled = true;
                btneliminar.Enabled = true;
                Grid.Enabled = true;
                txtNumeroDocumento.Enabled = true;
                cboTipoDocumento.Enabled = true;
                txtObservacionesPremio.Text = "";
                txtObservacionesMemo.Text = "";
                ESTADO = 0;
            }
            else
            {
                this.Close();
            }
        }
        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento_TextChanged(sender, e);
        }
    }
}