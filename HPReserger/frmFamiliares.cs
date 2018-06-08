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
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = clFamilia.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cboTipoDocumentoIdentidad.DisplayMember = "Desc_Tipo_ID";
            cboTipoDocumentoIdentidad.ValueMember = "Codigo_Tipo_ID";
            cboTipoDocumentoIdentidad.DataSource = TablaTipoID;
        }
        public void ModificarTamañoTipo(TextBox txt, int index)
        {
            if (index >= 0 && TablaTipoID != null)
            {
                DataRow Filita = TablaTipoID.Rows[index];
                txt.MaxLength = (int)Filita["Length"];
            }
        }
        private void frmFamiliares_Load(object sender, EventArgs e)
        {
            CargarTiposID("TBL_Tipo_ID");
            // CargaCombos(cboTipoDocumentoIdentidad, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            CargaCombos(cboVinculoFamiliar, "Id_VinculoFamiliar", "VinculoFamiliar", "TBL_VinculoFamiliar");
            CargaCombos(cbosexo, "Id_Sexo", "Sexo", "TBL_Sexo");
            MostrarGrilla();
            ModControles(false, cbosexo, cboTipoDocumentoIdentidad, cboVinculoFamiliar, txtApellidoMaterno, txtApellidoPaterno, txtconviviente, txtNombres, txtNumeroDocumento, txtOcupacion, dtpFecha, check18, btnconviviente);
            ModControles(true, btnRegistrar, Grid);
        }
        public void ModControles(Boolean a, params object[] Controles)
        {
            foreach (object x in Controles)
                ((Control)x).Enabled = a;
        }
        public void ModControles(string a, params object[] Controles)
        {
            foreach (object x in Controles)
                ((Control)x).Text = a;
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
            if (btnRegistrar.Text == "Registrar")
            {
                ModControles(true, cbosexo, cboTipoDocumentoIdentidad, cboVinculoFamiliar, txtApellidoMaterno, txtApellidoPaterno, txtconviviente, txtNombres, txtNumeroDocumento, txtOcupacion, dtpFecha, check18, btnconviviente);
                ModControles(false, Grid, btnModificar);
                btnRegistrar.Text = "Guardar";
                ModControles("", txtNumeroDocumento, txtApellidoMaterno, txtApellidoPaterno, txtconviviente, txtNombres, txtNumeroDocumento, txtOcupacion);
                check18.Checked = false;
                conviviente = null;
                pbconviviente.Image = null;
                return;
            }
            else
            {
                if (txtNumeroDocumento.Text.Length != txtNumeroDocumento.MaxLength && cboTipoDocumentoIdentidad.Text != "CARNE EXTRANJERIA")
                {
                    MessageBox.Show("No Coincide el Tamaño con el tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNumeroDocumento.Focus();
                    return;
                }
                if (txtNumeroDocumento.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Nº Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNumeroDocumento.Focus();
                    return;
                }
                if (txtApellidoPaterno.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Apellido Paterno", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtApellidoPaterno.Focus();
                    return;
                }
                if (txtApellidoMaterno.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Apellido Materno", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtApellidoMaterno.Focus();
                    return;
                }
                if (txtNombres.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Nombres", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNombres.Focus();
                    return;
                }
                if (txtOcupacion.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Ocupación", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtOcupacion.Focus();
                    return;
                }
                if (cbosexo.SelectedIndex < 0)
                {
                    msg("Seleccion el Sexo");
                    cbosexo.Focus();
                    return;
                }
                if (cboTipoDocumentoIdentidad.SelectedIndex < 0)
                {
                    msg("Seleccion el Tipo de Documento");
                    cboTipoDocumentoIdentidad.Focus();
                    return;
                }
                if (cboVinculoFamiliar.SelectedIndex < 0)
                {
                    msg("Seleccion el Vinculo Familiar");
                    cboVinculoFamiliar.Focus();
                    return;
                }
                DataRow filita = clFamilia.EmpleadoFamiliaExiste(CodigoDocumento, NumeroDocumento, (int)cboTipoDocumentoIdentidad.SelectedValue, txtNumeroDocumento.Text);
                if (filita != null)
                {
                    msg("Documento Familiar Ya Existe");
                    return;
                }

                int x = 0;
                if (check18.Checked) x = 1;
                else x = 0;
                clFamilia.EmpleadoFamilia(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboVinculoFamiliar.SelectedValue.ToString()), Convert.ToInt32(cboTipoDocumentoIdentidad.SelectedValue.ToString()), txtNumeroDocumento.Text, 0, "", txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, dtpFecha.Value, txtOcupacion.Text, frmLogin.CodigoUsuario, 1, conviviente, nombreconviviente, (int)cbosexo.SelectedValue, x);
                MessageBox.Show("Vínculo Familiar registrado con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                MostrarGrilla();
                btnRegistrar.Text = "Registrar";
                ModControles(false, cbosexo, cboTipoDocumentoIdentidad, cboVinculoFamiliar, txtApellidoMaterno, txtApellidoPaterno, txtconviviente, txtNombres, txtNumeroDocumento, txtOcupacion, dtpFecha, check18, btnconviviente);
                ModControles(true, Grid);
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmEFM.Icon = this.Icon;
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
                frmEFM.sexo = (int)cbosexo.SelectedValue;
                frmEFM.estudia = check18.Checked;
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
            {
                int x = e.RowIndex;
                btnModificar.Enabled = true;
                cboTipoDocumentoIdentidad.SelectedValue = (int)Grid[CODIGOTIPOID.Name, x].Value;
                cbosexo.SelectedValue = (int)Grid[sexo.Name, x].Value;
                cboVinculoFamiliar.SelectedValue = (int)Grid[CODIGOVINCULOFAMILIAR.Name, x].Value;
                txtNumeroDocumento.Text = Grid[NROID.Name, x].Value.ToString();
                txtNombres.Text = Grid[NOMBRES.Name, x].Value.ToString();
                txtApellidoMaterno.Text = Grid[APEMAT.Name, x].Value.ToString();
                txtApellidoPaterno.Text = Grid[APEPAT.Name, x].Value.ToString();
                txtOcupacion.Text = Grid[OCUPACION.Name, x].Value.ToString();
                txtconviviente.Text = Grid[nombreimagen.Name, x].Value.ToString();
                dtpFecha.Value = (DateTime)Grid[FECHANACIMIENTO.Name, x].Value;
                if ((int)Grid[estudia.Name, x].Value == 0)
                    check18.Checked = false;
                else
                    check18.Checked = true;
                if (Grid[imagen.Name, x].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    conviviente = Fotito = (byte[])Grid[imagen.Name, x].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbconviviente.Image = Bitmap.FromStream(ms);
                    lklconviviente.Visible = true;
                    lklconviviente.Enabled = true;
                }
                else lklconviviente.Enabled = false;
            }
            else
                btnModificar.Enabled = false;
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, txtNumeroDocumento.MaxLength);
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
                FrmFoto foto = new FrmFoto($"Foto de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text} ");
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

        private void cboTipoDocumentoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarTamañoTipo(txtNumeroDocumento, cboTipoDocumentoIdentidad.SelectedIndex);
        }

        private void pbconviviente_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (btnRegistrar.Text == "Guardar")
            {
                btnRegistrar.Text = "Registrar";
                MostrarGrilla();
                ModControles(false, cbosexo, cboTipoDocumentoIdentidad, cboVinculoFamiliar, txtApellidoMaterno, txtApellidoPaterno, txtconviviente, txtNombres, txtNumeroDocumento, txtOcupacion, dtpFecha, check18, btnconviviente);
                ModControles(true, btnRegistrar, Grid);
            }
            else
            {
                this.Close();
            }

        }
    }
}