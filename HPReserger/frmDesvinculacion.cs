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
            //Verifico si el empleado existe
            DataRow EmpleadoVacaciones = clDesvinculacion.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString() + " " + EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                //txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
                //Verifico si tiene un contrato activo en la fecha ingresada
                DataRow Listarcontrato = clDesvinculacion.ListarContrato(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, dtpfechacese.Value);
                if (Listarcontrato != null)
                {
                    panelliquidacion.Enabled = true; panelverimagen.Enabled = true;
                    dtgconten.DataSource = clDesvinculacion.ListarDesvinculacionContrato(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);

                    lblcontrato.Text = "Contrato Nº: " + Listarcontrato["Nro_Contrato"].ToString() + " Inicio: " + Convert.ToDateTime(Listarcontrato["Fec_Inicio"]).ToShortDateString() +
                        " Fin:" + Convert.ToDateTime(Listarcontrato["Fec_Fin"]).ToShortDateString();
                    if (!string.IsNullOrWhiteSpace(Listarcontrato["Fec_cesado"].ToString()))
                    {
                        lblcontrato.Text += " Cese: " + Convert.ToDateTime(Listarcontrato["Fec_cesado"]).ToShortDateString();
                        dtpfechacese.Value = Convert.ToDateTime(Listarcontrato["Fec_cesado"]);
                    }
                    panelliquidacion.Enabled = true;
                    DataRow ListarDesvinculaciones = clDesvinculacion.ListarDesvinculaciones(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, Convert.ToInt32(Listarcontrato["Nro_Contrato"].ToString()));
                    if (ListarDesvinculaciones != null)
                    {
                        panelverimagen.Enabled = true;
                        if (ListarDesvinculaciones["Liquidacion"].ToString() != null && ListarDesvinculaciones["Liquidacion"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoLiq = Fotito = (byte[])ListarDesvinculaciones["Liquidacion"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbLiquidacion.Image = Bitmap.FromStream(ms);
                            txtLiq.Text = ListarDesvinculaciones["Nombre_Liquidacion"].ToString();
                            lklliquidacion.Enabled = true;
                        }
                        else
                        {
                            txtLiq.Text = ""; FotoLiq = null;
                            pbLiquidacion.Image = null; lklliquidacion.Enabled = false;
                        }
                        if (ListarDesvinculaciones["Cts"].ToString() != null && ListarDesvinculaciones["Cts"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoCTS = Fotito = (byte[])ListarDesvinculaciones["Cts"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbCts.Image = Bitmap.FromStream(ms);
                            txtCTS.Text = ListarDesvinculaciones["Nombre_Cts"].ToString();
                            lklcts.Enabled = true;
                        }
                        else
                        {
                            txtCTS.Text = ""; FotoCTS = null; lklcts.Enabled = false;
                            pbCts.Image = null;
                        }
                        if (ListarDesvinculaciones["Retencion_Renta"].ToString() != null && ListarDesvinculaciones["Retencion_Renta"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoRetencionRenta = Fotito = (byte[])ListarDesvinculaciones["Retencion_Renta"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbRenta.Image = Bitmap.FromStream(ms);
                            txtRetencionRenta.Text = ListarDesvinculaciones["Nombre_Retencion_Renta"].ToString();
                            lklrenta.Enabled = true;
                        }
                        else
                        {
                            txtRetencionRenta.Text = ""; FotoRetencionRenta = null; lklrenta.Enabled = false;
                            pbRenta.Image = null;
                        }
                        if (ListarDesvinculaciones["Constancia_Trabajo"].ToString() != null && ListarDesvinculaciones["Constancia_Trabajo"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoConstanciaTrabajo = Fotito = (byte[])ListarDesvinculaciones["Constancia_Trabajo"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbConstancia.Image = Bitmap.FromStream(ms);
                            txtConstanciaTrabajo.Text = ListarDesvinculaciones["Nombre_Constancia_Trabajo"].ToString();
                            lkltrabajo.Enabled = true;
                        }
                        else
                        {
                            txtConstanciaTrabajo.Text = ""; FotoConstanciaTrabajo = null;
                            pbConstancia.Image = null; lkltrabajo.Enabled = false;
                        }
                        if (ListarDesvinculaciones["Evaluacion_Practicas"].ToString() != null && ListarDesvinculaciones["Evaluacion_Practicas"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoEvaluacionPracticas = Fotito = (byte[])ListarDesvinculaciones["Evaluacion_Practicas"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbPracticas.Image = Bitmap.FromStream(ms);
                            txtEvaluacionPracticas.Text = ListarDesvinculaciones["Nombre_Evaluacion_Practicas"].ToString();
                            lklpracticas.Enabled = true;
                        }
                        else
                        {
                            txtEvaluacionPracticas.Text = ""; FotoEvaluacionPracticas = null; lklpracticas.Enabled = false;
                            pbPracticas.Image = null;
                        }
                        if (ListarDesvinculaciones["Entrevista_Salida"].ToString() != null && ListarDesvinculaciones["Entrevista_Salida"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            FotoEntrevistaSalida = Fotito = (byte[])ListarDesvinculaciones["Entrevista_Salida"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            pbSalida.Image = Bitmap.FromStream(ms);
                            txtEntrevistaSalida.Text = ListarDesvinculaciones["Nombre_Entrevista_Salida"].ToString();
                            lklsalida.Enabled = true;
                        }
                        else
                        {
                            txtEntrevistaSalida.Text = ""; FotoEntrevistaSalida = null; lklsalida.Enabled = false;
                            pbSalida.Image = null;
                        }
                    }
                    else
                    {
                        panelverimagen.Enabled = false;
                        txtLiq.Text = txtConstanciaTrabajo.Text = txtCTS.Text = txtEntrevistaSalida.Text = txtEvaluacionPracticas.Text = txtRetencionRenta.Text = "";
                    }

                }
                else
                {
                    lblcontrato.Text = "No Tiene Contrato Activo ";
                    panelliquidacion.Enabled = false;
                    txtLiq.Text = ""; FotoLiq = null;
                    pbLiquidacion.Image = null;
                    txtCTS.Text = ""; FotoCTS = null;
                    pbCts.Image = null;
                    txtRetencionRenta.Text = ""; FotoRetencionRenta = null;
                    pbRenta.Image = null;
                    txtConstanciaTrabajo.Text = ""; FotoConstanciaTrabajo = null;
                    pbConstancia.Image = null;
                    txtEvaluacionPracticas.Text = ""; FotoEvaluacionPracticas = null;
                    pbPracticas.Image = null;
                    txtEntrevistaSalida.Text = ""; FotoEntrevistaSalida = null;
                    pbSalida.Image = null;
                    lklliquidacion.Enabled = lklcts.Enabled = lklrenta.Enabled = lkltrabajo.Enabled = lklpracticas.Enabled = lklsalida.Enabled = false;
                    panelliquidacion.Enabled = false; panelverimagen.Enabled = false;
                }
            }
            else
            {
                txtApellidoPaterno.Text = txtNombres.Text = "";
                dtgconten.DataSource = clDesvinculacion.ListarDesvinculacionContrato(1, "");
                lklliquidacion.Enabled = lklcts.Enabled = lklrenta.Enabled = lkltrabajo.Enabled = lklpracticas.Enabled = lklsalida.Enabled = false;
            }
        }

        private void frmDesvinculacion_Load(object sender, EventArgs e)
        {
            dtgconten.Enabled = false;
            dtpfechacese.Value = DateTime.Now;
            txtNumeroDocumento.Text = "";
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            dtpfechacese.MaxDate = DateTime.Now.AddDays(1);
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
            if (!txtMotivoCese.EstaLLeno())
            {
                MessageBox.Show("Ingrese Motivo del Cese", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMotivoCese.Focus();
                return;
            }

            frmLiquidacion frmLIQ = new frmLiquidacion();
            frmLIQ.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmLIQ.NumeroDocumento = txtNumeroDocumento.Text;
            frmLIQ._FechaInicio = dtpfechacese.Value;
            frmLIQ._Monto =decimal.Parse( txtmonto.Num.Text);
            frmLIQ._MotivoCese = txtMotivoCese.Text;
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
            frmCTS.fechacese = dtpfechacese.Value;
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
            frmCT.fechacese = dtpfechacese.Value;
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
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 10);
        }

        private void btnAdjuntarLiq_Click(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }
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
                pbLiquidacion = pbFoto;
                FotoLiq = File.ReadAllBytes(dialogoAbrirArchivoLiq.FileName);
                txtLiq.Text = nombreArchivoLiq; lklliquidacion.Enabled = true;
                panelverimagen.Enabled = true;
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
                txtCTS.Text = nombreArchivoCTS; panelverimagen.Enabled = true; lklcts.Enabled = true;
                pbCts = pbFoto;
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
                txtConstanciaTrabajo.Text = nombreArchivoConstanciaTrabajo; panelverimagen.Enabled = true; lkltrabajo.Enabled = true;
                pbConstancia = pbFoto;
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
                txtRetencionRenta.Text = nombreArchivoRetencionRenta; panelverimagen.Enabled = true;
                lklrenta.Enabled = true;
                pbRenta = pbFoto;
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
                txtEvaluacionPracticas.Text = nombreArchivoEvaluacionPracticas; panelverimagen.Enabled = true;
                lklpracticas.Enabled = true;
                pbPracticas = pbFoto;
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
                txtEntrevistaSalida.Text = nombreArchivoEntrevistaSalida; panelverimagen.Enabled = true;
                lklsalida.Enabled = true;
                pbSalida = pbFoto;
            }
        }
        int respuesta;
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (lklliquidacion.Enabled == false)
            {
                MSG("Falta Imagen de la Liquidación"); btnAdjuntarLiq.Focus();
                return;
            }
            if (lklcts.Enabled == false)
            {
                MSG("Falta Imagen de la Constancia de Cts"); btnCTS.Focus();
                return;
            }
            if (lkltrabajo.Enabled == false)
            {
                MSG("Falta Imagen de la Constancia de Trabajo"); btnAdjuntarConstanciaTrabajo.Focus();
                return;
            }

            if (lklrenta.Enabled == false)
            {
                MSG("Falta Imagen de la Retención de Renta"); btnRetencionRenta.Focus();
                return;
            }
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
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoLiq, txtLiq.Text, 1, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }

            if (txtCTS.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoCTS, txtCTS.Text, 2, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }

            if (txtConstanciaTrabajo.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoConstanciaTrabajo, txtConstanciaTrabajo.Text, 3, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }

            if (txtRetencionRenta.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoRetencionRenta, txtRetencionRenta.Text, 4, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }

            if (txtEvaluacionPracticas.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoEvaluacionPracticas, txtEvaluacionPracticas.Text, 5, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }

            if (txtEntrevistaSalida.Text.Length > 0)
            {
                clDesvinculacion.EmpleadoDesvinculacionInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, FotoEntrevistaSalida, txtEntrevistaSalida.Text, 6, dtpfechacese.Value, frmLogin.CodigoUsuario, out respuesta);
            }
            if (respuesta == 1)
            {
                MessageBox.Show("Desvinculación Insertada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbFoto.Image = null;
            }
            if (respuesta == 2)
            {
                MessageBox.Show("Desvinculación Actualizada con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pbFoto.Image = null;
            }
            if (respuesta == 0)
            {
                MessageBox.Show("Contrato No Encontrado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (respuesta == 3)
            {
                MessageBox.Show("Contrato Encontrado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void dtpfechacese_ValueChanged(object sender, EventArgs e)
        {

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

        private void lklliquidacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbLiquidacion);
        }

        private void lklcts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbCts);
        }

        private void lkltrabajo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbConstancia);
        }

        private void lklrenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbRenta);
        }

        private void lklpracticas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbPracticas);
        }

        private void lklsalida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbSalida);
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DateTime fechita;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!dtgconten.Enabled)
            {
                dtgconten.Enabled = !dtgconten.Enabled;
                fechita = dtpfechacese.Value;
                button1.Text = "Ocultar Desvinculaciones";

            }
            else
            {
                button1.Text = "Ver Desvinculaciones";
                dtgconten.Enabled = !dtgconten.Enabled;
                dtpfechacese.Value = fechita;
                if (dtgconten.RowCount > 0)
                    dtgconten.CurrentCell = dtgconten[0, 0];
                txtNumeroDocumento_TextChanged(sender, e);
            }
        }
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                if (dtgconten["FECHACESE", e.RowIndex].Value.ToString() != string.Empty)
                {
                    dtpfechacese.Value = Convert.ToDateTime(dtgconten["FECHACESE", e.RowIndex].Value.ToString());
                    dtpfechacese_CloseUp(sender, e);
                    dtgconten.CurrentCell = dtgconten[e.ColumnIndex, e.RowIndex];
                }
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*    if (dtgconten.RowCount > 0&&dtpfechacese!=null)
                {
                    dtpfechacese.Value = DateTime.Parse(dtgconten["fechacese", e.RowIndex].Value.ToString());
                    dtpfechacese_CloseUp(sender, e);
                }*/
        }

        private void dtpfechacese_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtNumeroDocumento_TextChanged(sender, e);
                txtNumeroDocumento_TextChanged(sender, e);
            }
            catch { }
        }
        frmListarEmpleadosDesvinculados frmlisdesempl;
        private void btnverTodas_Click(object sender, EventArgs e)
        {
            if (frmlisdesempl == null)
            {
                frmlisdesempl = new frmListarEmpleadosDesvinculados();
                frmlisdesempl.MdiParent = this.ParentForm;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
                frmlisdesempl.FormClosed += new FormClosedEventHandler(cerrartodasdesvinculaciones);
                frmlisdesempl.Show();
            }
            else
            {
                frmlisdesempl.Activate();
                ValidarVentanas(frmlisdesempl);
            }
        }
        void cerrartodasdesvinculaciones(object sender, FormClosedEventArgs e)
        {
            frmlisdesempl = null;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2) - 54;
        }
        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void frmDesvinculacion_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }
    }
}
