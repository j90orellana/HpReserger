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
    public partial class frmSolicitudEmpleado : Form
    {
        HPResergerCapaLogica.HPResergerCL clSolicitudEmpleado = new HPResergerCapaLogica.HPResergerCL();
        MemoryStream _memoryStream = new MemoryStream();
        public byte[] Foto { get; set; }
        public string nombreArchivo { get; set; }
        public int Item { get; set; }
        public int Item2 { get; set; }

        public frmSolicitudEmpleado()
        {
            InitializeComponent();
        }

        private void frmSolicitudEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
            cboCargoPuesto.SelectedIndex = -1;

            CargarCombos(cboTipoContratacion, "Id_TipoContratacion", "TipoContratacion", "TBL_TipoContratacion");
            cboTipoContratacion.SelectedIndex = -1;

            cboBusqueda.SelectedIndex = -1;
            cboTerna.SelectedIndex = -1;

            MostrarGrid(frmLogin.CodigoUsuario);
            Correlativo();
            Grid1.Visible = false;
        }

        private void Correlativo()
        {
            DataRow Correlativo = clSolicitudEmpleado.Correlativo("TBL_SolicitaEmpleado");
            txtSolicitud.Text = Correlativo["CORRELATIVO"].ToString();
        }

        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clSolicitudEmpleado.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void MostrarGrid(int Usuario)
        {
            Grid1.DataSource = clSolicitudEmpleado.ListarOS(Usuario);
            Grid2.DataSource = clSolicitudEmpleado.ListarSE(Usuario);
            Item = 0;
        }

        private void txtPuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
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
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivo);
                pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                txtAdjunto.Text = nombreArchivo;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Búsqueda", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboBusqueda.Focus();
                return;
            }

            if (cboTerna.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Terna", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTerna.Focus();
                return;
            }

            if (txtPuestos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Cantidad de Puestos", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPuestos.Focus();
                return;
            }

            if (txtAdjunto.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAdjunto.Focus();
                return;
            }

            DataRow ExisteImagen = clSolicitudEmpleado.ExisteImagen("NombreFoto", txtAdjunto.Text.Trim(), "TBL_SolicitaEmpleado");
            if (ExisteImagen != null)
            {
                MessageBox.Show("La imagen del requerimiento ya esta asociadao a otra Solicitud", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarJPG.Focus();
                return;
            }

            if (Convert.ToInt32(txtPuestos.Text) == 0)
            {
                MessageBox.Show("Cant. Puestos NO puede ser cero", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPuestos.Focus();
                return;
            }

            //int NumeroSolicitudEmpleado = 0;
            int OC = 0;
            if (cboBusqueda.SelectedIndex == 0)
            {
                OC = Convert.ToInt32(Grid1.Rows[Item].Cells[0].Value.ToString().Substring(2));
                clSolicitudEmpleado.SolicitudEmpleadoInsertar(Convert.ToInt32(txtSolicitud.Text.ToString()), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString(), cboTerna.SelectedItem.ToString(), Convert.ToInt32(Grid1.Rows[Item].Cells[1].Value.ToString()), Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text, frmLogin.CodigoUsuario);
            }
            else
            {
                clSolicitudEmpleado.SolicitudEmpleadoInsertar(Convert.ToInt32(txtSolicitud.Text.ToString()), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString(), cboTerna.SelectedItem.ToString(), frmLogin.CodigoArea, Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text, frmLogin.CodigoUsuario);
            }

            MessageBox.Show("La Solicitud de Empleado Nº " + (txtSolicitud.Text.ToString()) + " se generó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarGrid(frmLogin.CodigoUsuario);
            Correlativo();
            Limpiar();
        }

        private void Grid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item = e.RowIndex;
        }

        private void CargarFoto(int SE, int Item)
        {
            if (Grid2.Rows[Item].Cells[0].Value != null && Grid2.Rows.Count > 0)
            {
                DataRow drFoto = clSolicitudEmpleado.CargarImagenSolicitudEmpleado(SE);
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

        private void Grid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                CargarFoto(Convert.ToInt32(Grid2.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(2)), e.RowIndex);
            }
        }

        private bool SolicitudTienePostulantes(int Solicitud)
        {
            DataRow VerificaSE = clSolicitudEmpleado.VerificaEstadoSolicitudEmpleado(Solicitud);
            if (VerificaSE != null)
            {
                MessageBox.Show("Solicitud ya tiene Postulantes vinculados", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }
            return false;
        }

        private void Grid2_DoubleClick(object sender, EventArgs e)
        {
            if (Grid2.Rows.Count > 0 && Grid2.CurrentRow.Cells[0].Value != null)
            {
                if (SolicitudTienePostulantes(Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2))) == false)
                {
                    frmSolicitudEmpleadoModificar frmSE = new frmSolicitudEmpleadoModificar();
                    frmSE.Solicitud = Grid2.CurrentRow.Cells[0].Value.ToString();
                    frmSE.Busqueda = Grid2.CurrentRow.Cells[1].Value.ToString();

                    if (Grid2.CurrentRow.Cells[2].Value.ToString() == string.Empty)
                    {
                        frmSE.NOS = "";
                    }
                    else
                    {
                        frmSE.NOS = "OS" + Grid2.CurrentRow.Cells[2].Value.ToString();
                    }

                    frmSE.Cargo = Grid2.CurrentRow.Cells[4].Value.ToString();
                    frmSE.Tipo = Grid2.CurrentRow.Cells[6].Value.ToString();
                    frmSE.Terna = Grid2.CurrentRow.Cells[7].Value.ToString();
                    frmSE.Adjuntar = Grid2.CurrentRow.Cells[10].Value.ToString();
                    frmSE.Puestos = Convert.ToInt32(Grid2.CurrentRow.Cells[11].Value.ToString());

                    if (frmSE.ShowDialog() == DialogResult.OK)
                    {
                        MostrarGrid(frmLogin.CodigoUsuario);
                    }
                }
            }
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedIndex == 0)
            {
                Grid1.Visible = true;
            }
            else
            {
                Grid1.Visible = false;
            }
        }

        private void Grid2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Grid2.Rows.Count > 0 && Grid2.CurrentRow.Cells[0].Value != null)
            {
                if (e.KeyValue == (char)(Keys.Delete))
                {
                    if (SolicitudTienePostulantes(Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2))) == false)
                    {
                        if (MessageBox.Show("¿ Seguro de eliminar la Solicitud Nº " + Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2) + " ?", "HP Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clSolicitudEmpleado.EliminarSolicitudEmpleado(Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2)));
                            MostrarGrid(frmLogin.CodigoUsuario);
                        }
                    }
                }
            }
        }

        private void Limpiar()
        {
            cboBusqueda.SelectedIndex = -1;
            cboTerna.SelectedIndex = -1;
            txtPuestos.Text = "";
            cboCargoPuesto.SelectedIndex = -1;
            cboTipoContratacion.SelectedIndex = -1;
            txtAdjunto.Text = "";
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            FrmFoto foto = new FrmFoto();
            foto.fotito = pbFoto.Image;
            foto.ShowDialog();
        }

        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void frmSolicitudEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }
    }
}
