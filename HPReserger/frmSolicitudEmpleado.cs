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
            CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");

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
            DataRow Correlativo = clSolicitudEmpleado.CorrelativoCampo("TBL_SolicitaEmpleado", "ID_SolicitaEmpleado");
            txtSolicitud.Text = Correlativo["CORRELATIVO"].ToString();
        }

        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.DataSource = null;
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
                if (cbogerencia.SelectedIndex == -1) { msg("Selecciones Gerencias"); cbogerencia.Focus(); return; }
                if (cbogerencia.Items.Count <= 0) { msg("No Hay Gerencias Creadas"); cbogerencia.Focus(); return; }
                if (cboarea.SelectedIndex == -1) { msg("Selecciones Area"); cboarea.Focus(); return; }
                if (cboarea.Items.Count <= 0) { msg("No Hay Areas Creadas"); cboarea.Focus(); return; }
                //if (!txtservicio.EstaLLeno()) { msg("Ingrese Servicio"); txtservicio.Focus(); return; }
                DataRow Filita = clSolicitudEmpleado.Correlativo("[TBL_Solicitud_Empleado_Ext]");
                OC = (int)Filita[0];
                clSolicitudEmpleado.SolicitudEmpleadoExt(OC, (int)cboarea.SelectedValue, "", txtobservacion.Text, 1, frmLogin.CodigoUsuario);
                //sin modulo
                //OC = Convert.ToInt32(Grid1.Rows[Item].Cells[0].Value.ToString().Substring(2));
                //clSolicitudEmpleado.SolicitudEmpleadoInsertar(Convert.ToInt32(txtSolicitud.Text.ToString()), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString(), cboTerna.SelectedItem.ToString(), Convert.ToInt32(Grid1.Rows[Item].Cells[1].Value.ToString()), Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text, frmLogin.CodigoUsuario);
                clSolicitudEmpleado.SolicitudEmpleadoInsertar(Convert.ToInt32(txtSolicitud.Text.ToString()), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString() + "OUT", cboTerna.SelectedItem.ToString(), (int)cboarea.SelectedValue, (int)cbogerencia.SelectedValue, Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text, frmLogin.CodigoUsuario);
            }
            else
            {
                clSolicitudEmpleado.SolicitudEmpleadoInsertar(Convert.ToInt32(txtSolicitud.Text.ToString()), Convert.ToInt32(cboCargoPuesto.SelectedValue.ToString()), Convert.ToInt32(cboTipoContratacion.SelectedValue.ToString()), cboBusqueda.SelectedItem.ToString(), cboTerna.SelectedItem.ToString(), frmLogin.CodigoArea, frmLogin.CodigoGerencia, Convert.ToInt32(txtPuestos.Text), OC, Foto, txtAdjunto.Text, frmLogin.CodigoUsuario);
            }
            MessageBox.Show("La Solicitud de Empleado Nº " + (txtSolicitud.Text.ToString()) + " se generó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarGrid(frmLogin.CodigoUsuario);
            Correlativo();
            Limpiar();
        }
        public void msg(string cadenar)
        {
            MessageBox.Show(cadenar, "Hp Reseger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                panelOre1.Visible = true;
                cboarea_SelectedIndexChanged(sender, e);
            }
            else
            {
                Grid1.Visible = false;
                panelOre1.Visible = true;
                cboarea_SelectedIndexChanged(sender, e);
                //cboCargoPuesto.Enabled = true;
                // CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
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
                    else
                    {
                        if (MSG("Solicitud YA tiene Postulantes, Desea Eliminar?") == DialogResult.OK)
                        {
                            clSolicitudEmpleado.EliminarSolicitudEmpleado(Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2)));
                            MostrarGrid(frmLogin.CodigoUsuario);
                        }
                    }
                }
            }
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void Limpiar()
        {
            cboBusqueda.SelectedIndex = -1;
            cboTerna.SelectedIndex = -1;
            txtPuestos.Text = "";
            cboCargoPuesto.SelectedIndex = -1;
            cboTipoContratacion.SelectedIndex = -1;
            txtAdjunto.Text = "";
            cbogerencia.SelectedIndex = -1;
            txtobservacion.Text = "";
            pbFoto.Image = null;
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            if (pbFoto.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Solicitud de Empleados");
                foto.fotito = pbFoto.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
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
        public void Activar(Control x)
        {
            x.Enabled = true;
        }
        public void Desactivar(Control x)
        {
            x.Enabled = false;
        }
        private void cbogerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogerencia.SelectedIndex >= 0)
            {
                cboarea.DisplayMember = "area";
                cboarea.ValueMember = "codigoarea";
                cboarea.DataSource = clSolicitudEmpleado.AreaGerencia((int)cbogerencia.SelectedValue);
            }
            else
            {
                cboarea.SelectedIndex = -1;
            }
            if (cboarea.Items.Count > 0)
            {
                Activar(txtobservacion);
                Activar(cboarea);
            }
            else
            {
                Desactivar(txtobservacion);
                Desactivar(cboarea);
                Desactivar(cboCargoPuesto);
            }
        }
        private void cboarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboarea.SelectedIndex >= 0)
            {
                cboCargoPuesto.DataSource = null;
                cboCargoPuesto.ValueMember = "fk_idcargo";
                cboCargoPuesto.DisplayMember = "cargo";
                cboCargoPuesto.DataSource = clSolicitudEmpleado.CargosAreas(10, 0, (int)cboarea.SelectedValue,"");
                cboCargoPuesto.SelectedIndex = -1;
            }
            else
            {
                cboCargoPuesto.SelectedIndex = -1;
            }
            if (cboCargoPuesto.Items.Count > 0)
            {
                Activar(cboCargoPuesto);
            }
            else
            {
                Desactivar(cboCargoPuesto);
            }
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
        }
        private void cboCargoPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncargos_Click(object sender, EventArgs e)
        {
            cboBusqueda_SelectedIndexChanged(sender, e);
        }
    }
}
