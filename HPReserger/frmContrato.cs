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
    public partial class frmContrato : Form
    {
        HPResergerCapaLogica.HPResergerCL clContrato = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoDocumento { get; set; }

        public string NumeroDocumento { get; set; }
        public int estado { get; set; }

        MemoryStream _memoryStream = new MemoryStream();
        public byte[] FotoContrato { get; set; }
        public string nombreArchivoContrato { get; set; }
        public byte[] FotoAnexoFunciones { get; set; }
        public string nombreArchivoAnexoFunciones { get; set; }
        public byte[] FotoSolicitudPracticas { get; set; }
        public string nombreArchivoSolicitudPracticas { get; set; }
        public byte[] FotoOtros { get; set; }
        public string nombreArchivoOtros { get; set; }

        public frmContrato()
        {
            InitializeComponent();
        }
        private void frmContrato_Load(object sender, EventArgs e)
        {
            dtpFechaFin.Value.AddDays(1);
            estado = 0;
            grpcontrato.Enabled = false;
            grpcontra.Enabled = false;
            btnModificar.Enabled = false;
            btnaceptar.Enabled = false;
            dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
            cartelito(dtgconten);
            if (dtgconten.RowCount > 0)
            {
                dtgconten.Enabled = true;
                CargaCombos(cboTipoContrato, "Id_TipoContrato", "TipoContrato", "TBL_TipoContrato");
                CargaCombos(cboCargo, "Id_Cargo", "Cargo", "TBL_Cargo");
                CargaCombos(cboEmpresa, "Id_Empresa", "Empresa", "TBL_Empresa");
                CargaCombos(cboGerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
                CargaCombos(cbotipocontratacion, "Id_TipoContratacion", "TipoContratacion", "TBL_TipoContratacion");
                //CargaCombos(cboProyecto, "Id_Proyecto", "Proyecto", "TBL_Proyecto");
                CargaCombos(cboSede, "Id_Sede", "Sede", "TBL_Sede");
                cboJefeInmediato.ValueMember = "codigo";
                cboJefeInmediato.DisplayMember = "jefe";
                cboJefeInmediato.DataSource = clContrato.ListarJefeInmediato(CodigoDocumento, NumeroDocumento, 0);
                dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
            }
            else
            {
                dtgconten.Enabled = false;
                txtAnexoFunciones.Enabled = txtContrato.Enabled = txtOtros.Enabled = txtSolicitudPracticas.Enabled = false;
                lklanexo.Enabled = lklcontrato.Enabled = lklotros.Enabled = lklpracticas.Enabled = false;
            }
            txtPeriodoLaboral_TextChanged(sender, e);

        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (dtgconten.RowCount > 0)
            {
                btnExportapdf.Enabled = true;
                btnModificar.Enabled = true;
                cboTipoContrato.SelectedValue = Convert.ToInt32(dtgconten["TIPOC", fila].Value.ToString());
                cboCargo.SelectedValue = Convert.ToInt32(dtgconten["IDCARGO", fila].Value.ToString());
                cboGerencia.SelectedValue = Convert.ToInt32(dtgconten["IDG", fila].Value.ToString());
                cboArea.SelectedValue = Convert.ToInt32(dtgconten["IDA", fila].Value.ToString());
                cboJefeInmediato.SelectedValue = Convert.ToInt64(dtgconten["IDJ", fila].Value.ToString() + dtgconten["DOCJEFE", fila].Value.ToString());
                cboProyecto.SelectedValue = Convert.ToInt32(dtgconten["IDP", fila].Value.ToString());
                cboEmpresa.SelectedValue = Convert.ToInt32(dtgconten["IDE", fila].Value.ToString());
                cboSede.SelectedValue = Convert.ToInt32(dtgconten["SEDE", fila].Value.ToString());
                dtpFechaInicio.Value = Convert.ToDateTime(dtgconten["INICIO", fila].Value.ToString());
                txtPeriodoLaboral.Text = dtgconten["PERIODO", fila].Value.ToString();
                dtpFechaFin.Value = Convert.ToDateTime(dtgconten["FIN", fila].Value.ToString());
                txtSalario.Text = dtgconten["SUELDO", fila].Value.ToString();
                cboBono.Text = dtgconten["BONO", fila].Value.ToString();
                txtImporteBono.Text = dtgconten["IMPORTE", fila].Value.ToString();
                txtPeriodicidad.Text = dtgconten["PERIOCIDAD", fila].Value.ToString();
                cbotipocontratacion.SelectedValue = Int32.Parse(dtgconten["tc", fila].Value.ToString());

                if (Convert.ToInt32(dtgconten["JEFE", fila].Value.ToString()) == 1)
                {
                    chkjefe.Checked = true;
                }
                if (dtgconten["CONTRATOIMG", fila].Value.ToString() != null && dtgconten["CONTRATOIMG", fila].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoContrato = Fotito = (byte[])dtgconten["CONTRATOIMG", fila].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoContrato.Image = Bitmap.FromStream(ms);
                    txtContrato.Text = dtgconten["NOMBRECONTRATOIMG", fila].Value.ToString();
                    lklcontrato.Enabled = true;
                }
                else
                {
                    txtContrato.Text = ""; FotoContrato = null;
                    pbFotoContrato.Image = null; lklcontrato.Enabled = false;
                }
                if (dtgconten["ANEXOIMG", fila].Value.ToString() != null && dtgconten["ANEXOIMG", fila].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoAnexoFunciones = Fotito = (byte[])dtgconten["ANEXOIMG", fila].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoAnexoFunciones.Image = Bitmap.FromStream(ms);
                    txtAnexoFunciones.Text = dtgconten["NOMBREANEXOIMG", fila].Value.ToString();
                    lklanexo.Enabled = true;
                }
                else
                {
                    txtAnexoFunciones.Text = ""; FotoAnexoFunciones = null;
                    pbFotoAnexoFunciones.Image = null; lklanexo.Enabled = false;
                }
                if (dtgconten["PRACTICAIMG", fila].Value.ToString() != null && dtgconten["PRACTICAIMG", fila].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoSolicitudPracticas = Fotito = (byte[])dtgconten["PRACTICAIMG", fila].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoSolicitudPracticas.Image = Bitmap.FromStream(ms);
                    txtSolicitudPracticas.Text = dtgconten["NOMBREPRACTICAIMG", fila].Value.ToString();
                    lklpracticas.Enabled = true;
                }
                else
                {
                    txtSolicitudPracticas.Text = ""; FotoSolicitudPracticas = null;
                    pbFotoSolicitudPracticas.Image = null; lklpracticas.Enabled = false;
                }
                if (dtgconten["OTROSIMG", fila].Value.ToString() != null && dtgconten["OTROSIMG", fila].Value.ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoOtros = Fotito = (byte[])dtgconten["OTROSIMG", fila].Value;
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoOtros.Image = Bitmap.FromStream(ms);
                    txtOtros.Text = dtgconten["NOMBREOTROSIMG", fila].Value.ToString();
                    lklotros.Enabled = true;
                }
                else
                {
                    txtOtros.Text = ""; FotoOtros = null;
                    lklotros.Enabled = false;
                    pbFotoOtros.Image = null;
                }
                if (!string.IsNullOrWhiteSpace(dtgconten["CESE", fila].Value.ToString()))
                {
                    dtpfechacese.Visible = lblfechacese.Visible = true;
                    dtpfechacese.Value = Convert.ToDateTime(dtgconten["CESE", fila].Value.ToString());
                }
                else
                {
                    dtpfechacese.Visible = lblfechacese.Visible = false;
                }

            }
            else
            {
                btnModificar.Enabled = false;btnExportapdf.Enabled = false;
            }

        }
        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clContrato.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtPeriodoLaboral_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtSalario.Text);
        }

        private void txtPeriodicidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnBuscarImagenContrato_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoContrato = new OpenFileDialog();
            dialogoAbrirArchivoContrato.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoContrato.DefaultExt = ".jpg";
            dialogoAbrirArchivoContrato.ShowDialog(this);
            txtContrato.Enabled = lklcontrato.Enabled = false;
            nombreArchivoContrato = dialogoAbrirArchivoContrato.FileName.ToString();
            if (nombreArchivoContrato != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoContrato.Image = Image.FromFile(nombreArchivoContrato);
                pbFotoContrato.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoContrato = File.ReadAllBytes(dialogoAbrirArchivoContrato.FileName);
                txtContrato.Text = nombreArchivoContrato;
                txtContrato.Enabled = lklcontrato.Enabled = true;
            }
        }

        private void btnBuscarImagenAnexoFunciones_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoAnexoFunciones = new OpenFileDialog();
            dialogoAbrirArchivoAnexoFunciones.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAnexoFunciones.DefaultExt = ".jpg";
            dialogoAbrirArchivoAnexoFunciones.ShowDialog(this);
            txtAnexoFunciones.Enabled = lklanexo.Enabled = false;
            nombreArchivoAnexoFunciones = dialogoAbrirArchivoAnexoFunciones.FileName.ToString();
            if (nombreArchivoAnexoFunciones != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoAnexoFunciones.Image = Image.FromFile(nombreArchivoAnexoFunciones);
                pbFotoAnexoFunciones.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoAnexoFunciones = File.ReadAllBytes(dialogoAbrirArchivoAnexoFunciones.FileName);
                txtAnexoFunciones.Text = nombreArchivoAnexoFunciones;
                txtAnexoFunciones.Enabled = lklanexo.Enabled = true;
            }
        }

        private void btnBuscarImagenSolicitudPracticas_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoSolicitudPracticas = new OpenFileDialog();
            dialogoAbrirArchivoSolicitudPracticas.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoSolicitudPracticas.DefaultExt = ".jpg";
            dialogoAbrirArchivoSolicitudPracticas.ShowDialog(this);
            txtSolicitudPracticas.Enabled = lklpracticas.Enabled = false;
            nombreArchivoSolicitudPracticas = dialogoAbrirArchivoSolicitudPracticas.FileName.ToString();
            if (nombreArchivoSolicitudPracticas != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoSolicitudPracticas.Image = Image.FromFile(nombreArchivoSolicitudPracticas);
                pbFotoSolicitudPracticas.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoSolicitudPracticas = File.ReadAllBytes(dialogoAbrirArchivoSolicitudPracticas.FileName);
                txtSolicitudPracticas.Text = nombreArchivoSolicitudPracticas;
                txtSolicitudPracticas.Enabled = lklpracticas.Enabled = true;
            }
        }

        private void btnBuscarImagenOtros_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoOtros = new OpenFileDialog();
            dialogoAbrirArchivoOtros.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoOtros.DefaultExt = ".jpg";
            dialogoAbrirArchivoOtros.ShowDialog(this);
            txtOtros.Enabled = lklotros.Enabled = false;
            nombreArchivoOtros = dialogoAbrirArchivoOtros.FileName.ToString();
            if (nombreArchivoOtros != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoOtros.Image = Image.FromFile(nombreArchivoOtros);
                pbFotoOtros.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoOtros = File.ReadAllBytes(dialogoAbrirArchivoOtros.FileName);
                txtOtros.Text = nombreArchivoOtros;
                txtOtros.Enabled = lklotros.Enabled = true;
            }
        }

        private void txtImporteBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtSalario.Text);
        }
        int fila;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                fila = dtgconten.CurrentCell.RowIndex;
            }
            else
            {
                fila = 0;
            }
            Limpiar(); dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddMonths(3);
            txtPeriodoLaboral.Text = "3";
            cboJefeInmediato.DataSource = clContrato.ListarJefeInmediato(CodigoDocumento, NumeroDocumento, 1);
            if (dtgconten.RowCount == 0)
            {

                dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
                cboBono.SelectedIndex = 1;
                dtgconten.Enabled = true;
                CargaCombos(cboTipoContrato, "Id_TipoContrato", "TipoContrato", "TBL_TipoContrato");
                CargaCombos(cboCargo, "Id_Cargo", "Cargo", "TBL_Cargo");
                CargaCombos(cboEmpresa, "Id_Empresa", "Empresa", "TBL_Empresa");
                CargaCombos(cboGerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
                CargaCombos(cboSede, "Id_Sede", "Sede", "TBL_Sede");
                cboJefeInmediato.ValueMember = "codigo";
                cboJefeInmediato.DisplayMember = "jefe";
                //cboJefeInmediato.DataSource = clContrato.ListarJefeInmediato(CodigoDocumento,NumeroDocumento,1);
            }
            estado = 1;
            dtgconten.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnaceptar.Enabled = true;
            grpcontra.Enabled = grpcontrato.Enabled = true;
            pbFotoAnexoFunciones.Image = pbFotoContrato.Image = pbFotoOtros.Image = pbFotoSolicitudPracticas.Image = null;
            FotoContrato = FotoAnexoFunciones = FotoSolicitudPracticas = FotoOtros = null;
        }

        private bool Validar()
        {
            if (txtPeriodoLaboral.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Período Laboral", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPeriodoLaboral.Focus();
                return false;
            }
            if (txtSalario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Salario", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSalario.Focus();
                return false;
            }
            if (cboBono.SelectedIndex == 0 && txtImporteBono.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Importe Bono", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtImporteBono.Focus();
                return false;
            }
            if (txtPeriodicidad.Text.Length == 0 && cboBono.SelectedIndex == 0)
            {
                MessageBox.Show("Ingrese Periodicidad", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPeriodicidad.Focus();
                return false;
            }
            if (txtContrato.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Contrato", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenContrato.Focus();
                return false;
            }
            if (dtgconten.RowCount > 0 && estado == 1)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten["CESE", 0].Value.ToString()))
                {
                    if (dtpFechaInicio.Value <= Convert.ToDateTime(dtgconten["CESE", 0].Value.ToString()))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de CESE del contrato anterior");
                        dtpFechaInicio.Focus();
                        return false;
                    }
                }
                else if (!string.IsNullOrWhiteSpace(dtgconten["FIN", 0].Value.ToString()))
                {
                    if (!(dtpFechaInicio.Value > Convert.ToDateTime(dtgconten["FIN", 0].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de FIN del contrato anterior");
                        dtpFechaInicio.Focus();
                        return false;
                    }
                    if ((dtpFechaInicio.Value.Date == Convert.ToDateTime(dtgconten["FIN", 0].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser igual que la de FIN del contrato anterior");
                        dtpFechaInicio.Focus();
                        return false;
                    }
                }

            }
            if (dtgconten.RowCount > 1 && estado == 2)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten["CESE", 1].Value.ToString()))
                {
                    if (dtpFechaInicio.Value <= Convert.ToDateTime(dtgconten["CESE", 1].Value.ToString()))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de CESE del contrato anterior");
                        return false;
                    }
                }
                else if (!string.IsNullOrWhiteSpace(dtgconten["FIN", 1].Value.ToString()))
                {
                    //MensajeAlerta(dtgconten["FIN", 0].Value.ToString());
                    if (!(dtpFechaInicio.Value > Convert.ToDateTime(dtgconten["FIN", 1].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de FIN del contrato anterior");
                        return false;
                    }
                    if ((dtpFechaInicio.Value.Date == Convert.ToDateTime(dtgconten["FIN", 1].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser igual que la de FIN del contrato anterior");
                        return false;
                    }
                }
            }
            if (dtpFechaFin.Value.Date <= dtpFechaInicio.Value.Date)
            {
                MensajeAlerta("FECHA FIN Debe ser mayor a la FECHA DE INICIO");
                dtpFechaFin.Focus();
                return false;
            }
            txtPeriodoLaboral.Text = ((dtpFechaFin.Value.Month + (dtpFechaFin.Value.Year - dtpFechaInicio.Value.Year) * 12) - dtpFechaInicio.Value.Month).ToString();
            //txtPeriodoLaboral.Text = Convert.ToDateTime(dtpFechaFin.Value - dtpFechaInicio.Value).Month.ToString();
            /*
            if (txtAnexoFunciones.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Anexo de Funciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenAnexoFunciones.Focus();
                return false;
            }
            if (txtSolicitudPracticas.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Solicitud de Practicas", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenSolicitudPracticas.Focus();
                return false;
            }
            if (txtOtros.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Otros", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenOtros.Focus();
                return false;
            }*/
            if (locacion.acepta == false && int.Parse(cbotipocontratacion.SelectedValue.ToString()) == 4)
            {
                MensajeAlerta("No ha Ingresado los detalles del Contrato por Locacion");
                btnlocacion.Focus();
                return false;
            }
            return true;
        }

        private void Limpiar()
        {
            pbFotoContrato.Image = pbFotoAnexoFunciones.Image = pbFotoSolicitudPracticas.Image = pbFotoOtros.Image = null;
            txtPeriodoLaboral.Text = "";
            txtSalario.Text = "";
            txtImporteBono.Text = "";
            txtPeriodicidad.Text = "";
            txtContrato.Text = "";
            txtAnexoFunciones.Text = "";
            txtSolicitudPracticas.Text = "";
            txtOtros.Text = "";
        }

        private void GrabarEditar(int Opcion)
        {
            int jefe; int numero; int tipocontra;
            decimal ImporteBono = 0;
            int PeriodicidadBono = 0;
            if (chkjefe.Checked) { jefe = 1; } else { jefe = 0; }
            if (cboBono.SelectedIndex == 0)
            {
                ImporteBono = Convert.ToDecimal(txtImporteBono.Text);
                PeriodicidadBono = Convert.ToInt32(txtPeriodicidad.Text);
            }
            string docjefe;
            int tipojefe;
            tipojefe = Convert.ToInt32(cboJefeInmediato.SelectedValue.ToString().Substring(0, 1));
            docjefe = cboJefeInmediato.SelectedValue.ToString().Substring(1);
            tipocontra = Int32.Parse(cbotipocontratacion.SelectedValue.ToString());
            //MessageBox.Show(tipojefe + " " + docjefe);
            if (dtgconten.RowCount > 0)
            {
                numero = Convert.ToInt32(dtgconten["NRO", dtgconten.CurrentCell.RowIndex].Value.ToString());
            }
            else { numero = 0; }
            clContrato.EmpleadoContrato(numero, CodigoDocumento, NumeroDocumento, tipocontra, jefe, Convert.ToInt32(cboTipoContrato.SelectedValue.ToString()), Convert.ToInt32(cboCargo.SelectedValue.ToString()), Convert.ToInt32(cboGerencia.SelectedValue.ToString()), Convert.ToInt32(cboArea.SelectedValue.ToString()), tipojefe, docjefe, Convert.ToInt32(cboEmpresa.SelectedValue.ToString()), Convert.ToInt32(cboProyecto.SelectedValue.ToString()), Convert.ToInt32(cboSede.SelectedValue.ToString()), dtpFechaInicio.Value, Convert.ToInt32(txtPeriodoLaboral.Text), dtpFechaFin.Value, Convert.ToDecimal(txtSalario.Text), cboBono.SelectedItem.ToString(), ImporteBono, PeriodicidadBono, FotoContrato, txtContrato.Text, FotoAnexoFunciones, txtAnexoFunciones.Text, FotoSolicitudPracticas, txtSolicitudPracticas.Text, FotoOtros, txtOtros.Text, frmLogin.CodigoUsuario, Opcion);
            //MessageBox.Show(numero+" "+CodigoDocumento +" "+ NumeroDocumento);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgconten.CurrentCell.RowIndex == 0)
            {
                estado = 2;
                cboJefeInmediato.DataSource = clContrato.ListarJefeInmediato(CodigoDocumento, NumeroDocumento, 1);
                btnRegistrar.Enabled = false;
                grpcontrato.Enabled = true; grpcontra.Enabled = true;
                btnaceptar.Enabled = true;
                dtgconten.Enabled = false;
                btnModificar.Enabled = true; btnModificar.Visible = false; btnModificar.Enabled = false; btnModificar.Visible = true;
            }
            else
            {
                MensajeAlerta("SOLO se Puede Modificar el CONTRATO ACTUAL");
            }
        }

        private void cboBono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBono.SelectedIndex == 0)
            {
                txtImporteBono.Text = string.Empty;
                txtImporteBono.Visible = true;
                label17.Visible = true;
                txtPeriodicidad.Text = string.Empty;
                txtPeriodicidad.Visible = true;
                label19.Visible = true;
            }
            else
            {
                txtImporteBono.Text = string.Empty;
                txtImporteBono.Visible = false;
                label17.Visible = false;
                txtPeriodicidad.Text = string.Empty;
                txtPeriodicidad.Visible = false;
                label19.Visible = false;
            }
        }

        private void cboGerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGerencia.SelectedIndex > -1)
            {
                cboArea.ValueMember = "CODIGOAREA";
                cboArea.DisplayMember = "AREA";
                cboArea.DataSource = clContrato.AreaGerencia(Convert.ToInt32(cboGerencia.SelectedValue));
            }
        }

        private void txtPeriodoLaboral_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPeriodoLaboral.Text))
            {
                dtpFechaFin.Value = (dtpFechaInicio.Value.AddMonths(Convert.ToInt32(txtPeriodoLaboral.Text)));
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtPeriodoLaboral_TextChanged(sender, e);
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtSalario);
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProyecto.DataSource = clContrato.getCargoTipoContratacion3("Id_Proyecto", "Id_Empresa", "Proyecto", "TBL_Proyecto", cboEmpresa.SelectedValue.ToString());
            cboProyecto.DisplayMember = "DESCRIPCION";
            cboProyecto.ValueMember = "CODIGO";
        }

        private void txtContrato_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoContrato);
        }

        private void txtAnexoFunciones_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoAnexoFunciones);
        }

        private void txtSolicitudPracticas_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoSolicitudPracticas);
        }

        private void txtOtros_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoOtros);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto();
                foto.fotito = fotito.Image;
                foto.ShowDialog();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                grpcontrato.Enabled = false; grpcontra.Enabled = false;
                btnaceptar.Enabled = false;
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;
                dtgconten.Enabled = true;
                if (estado == 1)
                {
                    dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
                    if (dtgconten.RowCount > 0)
                    {
                        dtgconten.CurrentCell = dtgconten[0, fila];
                    }
                    else
                    {
                        txtContrato.Text = txtAnexoFunciones.Text = txtSolicitudPracticas.Text = txtOtros.Text = "";

                        txtAnexoFunciones.Enabled = txtContrato.Enabled = txtOtros.Enabled = txtSolicitudPracticas.Enabled = false;
                        lklanexo.Enabled = lklcontrato.Enabled = lklotros.Enabled = lklpracticas.Enabled = false;

                    }
                }
                if (estado == 2)
                {
                    dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
                }
                estado = 0;
                if (dtgconten.RowCount > 0)
                {
                    btnModificar.Enabled = true;
                }
            }
            else { this.Close(); }
        }

        private void cboTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                if (Validar())
                {
                    GrabarEditar(1);
                    MessageBox.Show("Contrato generado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegistrar.Enabled = false;
                    btnModificar.Enabled = true;
                    btncancelar_Click(sender, e);
                    dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
                    if (int.Parse(cbotipocontratacion.SelectedValue.ToString()) == 4)
                    {
                        clContrato.LocacionServicios(dtgconten["nro", 0].Value.ToString(), CodigoDocumento.ToString(), NumeroDocumento, 1, locacion.ocupacion, locacion.detalle);
                    }
                    cartelito(dtgconten);
                    //Limpiar();
                }
            }
            if (estado == 2)
            {
                if (Validar())
                {
                    GrabarEditar(0);
                    MessageBox.Show("Contrato modificado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                    btncancelar_Click(sender, e);
                    dtgconten.DataSource = clContrato.ListarEmpleadoContrato(CodigoDocumento, NumeroDocumento);
                    cartelito(dtgconten);
                    if (locacion.acepta == true)
                    {
                        frmReporteLocacionServicios locacionservis = new frmReporteLocacionServicios();
                        locacionservis.contrato = dtgconten["nro", 0].Value.ToString();
                        locacionservis.tipo = CodigoDocumento.ToString();
                        locacionservis.numero = NumeroDocumento;
                        locacionservis.ShowDialog();
                    }
                }
            }
        }
        public void cartelito(DataGridView medir)
        {
            lblmsg.Text = "Total de Registros: " + medir.RowCount;
        }
        public void MensajeAlerta(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtpFechaInicio_CloseUp(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0 && estado == 1)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten["CESE", 0].Value.ToString()))
                {
                    if (dtpFechaInicio.Value <= Convert.ToDateTime(dtgconten["CESE", 0].Value.ToString()))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de CESE del contrato anterior");
                    }
                }
                else if (!string.IsNullOrWhiteSpace(dtgconten["FIN", 0].Value.ToString()))
                {
                    //MensajeAlerta(dtgconten["FIN", 0].Value.ToString());
                    if (!(dtpFechaInicio.Value > Convert.ToDateTime(dtgconten["FIN", 0].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de FIN del contrato anterior");
                    }
                    if ((dtpFechaInicio.Value.Date == Convert.ToDateTime(dtgconten["FIN", 0].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser igual que la de FIN del contrato anterior");
                    }
                }
            }
            if (dtgconten.RowCount > 1 && estado == 2)
            {
                if (!string.IsNullOrWhiteSpace(dtgconten["CESE", 1].Value.ToString()))
                {
                    if (dtpFechaInicio.Value <= Convert.ToDateTime(dtgconten["CESE", 1].Value.ToString()))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de CESE del contrato anterior");
                    }
                }
                else if (!string.IsNullOrWhiteSpace(dtgconten["FIN", 1].Value.ToString()))
                {
                    //MensajeAlerta(dtgconten["FIN", 0].Value.ToString());
                    if (!(dtpFechaInicio.Value >= Convert.ToDateTime(dtgconten["FIN", 1].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser menor que la de FIN del contrato anterior");
                    }
                    if ((dtpFechaInicio.Value.Date == Convert.ToDateTime(dtgconten["FIN", 1].Value.ToString())))
                    {
                        MensajeAlerta("FECHA DE INICIO No puede ser igual que la de FIN del contrato anterior");
                    }
                }
            }
            txtPeriodoLaboral_TextChanged(sender, e);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            txtPeriodoLaboral.Text = ((dtpFechaFin.Value.Month + (dtpFechaFin.Value.Year - dtpFechaInicio.Value.Year) * 12) - dtpFechaInicio.Value.Month).ToString();
        }

        private void dtpFechaFin_CloseUp(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value <= dtpFechaInicio.Value)
            {
                MensajeAlerta("FECHA FIN Debe ser mayor a la FECHA DE INICIO");
            }
            else
            {
                txtPeriodoLaboral.Text = ((dtpFechaFin.Value.Month + (dtpFechaFin.Value.Year - dtpFechaInicio.Value.Year) * 12) - dtpFechaInicio.Value.Month).ToString();
            }
        }

        private void lklcontrato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoContrato);
        }

        private void lklanexo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoAnexoFunciones);
        }

        private void lklpracticas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoSolicitudPracticas);
        }

        private void lklotros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoOtros);
        }

        private void txtAnexoFunciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSolicitudPracticas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOtros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotipocontratacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnpracticas.Visible = false;
            btnobradeterminada.Visible = false;
            btnlocacion.Visible = false;
            btnmercado.Visible = false;
            if (cbotipocontratacion.SelectedValue.ToString() == "4")
            {
                btnlocacion.Visible = true;
            }
            if (cbotipocontratacion.SelectedValue.ToString() == "1")
            {
                btnpracticas.Visible = true;
            }
            if (cbotipocontratacion.SelectedValue.ToString() == "2" || cbotipocontratacion.SelectedValue.ToString() == "3")
            {
                btnobradeterminada.Visible = true; btnmercado.Visible = true;
            }
        }
        private void btnpracticas_Click(object sender, EventArgs e)
        {
            FrmPracticasPreProfesionales pracprepro = new FrmPracticasPreProfesionales();
            pracprepro.numero = NumeroDocumento;
            pracprepro.tipo = CodigoDocumento.ToString();
            if (dtgconten.RowCount > 0)
                pracprepro.contrato = dtgconten["nro", 0].Value.ToString();
            else pracprepro.contrato = "0";
            pracprepro.ShowDialog();
        }
        frmLocacionServicio locacion = new frmLocacionServicio();
        private void btnlocacion_Click(object sender, EventArgs e)
        {
            locacion.numerodoc = NumeroDocumento;
            locacion.tipo = CodigoDocumento.ToString();
            locacion.estado = estado;
            if (dtgconten.RowCount > 0)
                locacion.contrato = dtgconten["nro", 0].Value.ToString();
            else locacion.contrato = "0";
            locacion.ShowDialog();
        }
        frmReporteLocacionServicios reportelocacion = new frmReporteLocacionServicios();
        private void btnExportapdf_Click(object sender, EventArgs e)
        { string caden = dtgconten["tc", dtgconten.CurrentCell.RowIndex].Value.ToString();
            if (caden=="4")
            {
                reportelocacion.contrato = dtgconten["nro", dtgconten.CurrentCell.RowIndex].Value.ToString();
                reportelocacion.tipo = CodigoDocumento.ToString();
                reportelocacion.numero = NumeroDocumento;
                reportelocacion.ShowDialog();
            }
            if (caden == "1")
            {
                MensajeAlerta("Contrato de Practias Pre Profesionales Programando");
            }
            if (caden == "2"||caden=="3")
            {
                MensajeAlerta("Contrato de Planillas Programando");
            }

        }
    }
}