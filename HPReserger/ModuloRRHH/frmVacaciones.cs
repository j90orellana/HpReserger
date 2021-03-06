﻿using System;
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
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmVacaciones : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoVacaciones = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        DataRow DiasVaca;
        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string NombreFoto { get; set; }

        public frmVacaciones()
        {
            InitializeComponent();
        }
        int habiles = 0, nohabiles = 0, Acumulados = 0;
        private void DiasInicio(int TipoDocumento, string NumeroDocumento, string sStoredProcedureName)
        {
            DataRow EmpleadoVacaciones = clEmpleadoVacaciones.ExisteBeneficioEmpleado(TipoDocumento, NumeroDocumento, sStoredProcedureName);
            Cargado = false;
            if (EmpleadoVacaciones != null)
            {
                Cargado = true;
                txtFecha.Text = EmpleadoVacaciones["FECHAINICIO"].ToString();
                MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                //txtDiasUtilizados.Text = EmpleadoVacaciones["DIASUTILIZADOS"].ToString();
                //txtDiasPendientes.Text = EmpleadoVacaciones["DIASPENDIENTES"].ToString();
                txttipo.Text = EmpleadoVacaciones["TIPOCONTRATACION"].ToString();

                //if (Convert.ToInt32(EmpleadoVacaciones["DIASPENDIENTES"].ToString()) <= 0)
                //{
                //    btnBoletaVacaciones.Enabled = false;
                //    btnCompraVacaciones.Enabled = false;
                //    groupBox1.Enabled = false;
                //    btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
                //}
                //else
                //{
                //    btnBoletaVacaciones.Enabled = true;
                //    btnCompraVacaciones.Enabled = true;
                //    groupBox1.Enabled = true;
                //    btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = true;
                //}

                //if (EmpleadoVacaciones["IDTIPO"].ToString() == "2" || EmpleadoVacaciones["IDTIPO"].ToString() == "3")
                //{
                //    btnBoletaVacaciones.Enabled = true;
                //    btnCompraVacaciones.Enabled = true;
                //    groupBox1.Visible = true;
                //    btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = true;
                //}
                //else
                //{
                //    btnBoletaVacaciones.Enabled = false;
                //    btnCompraVacaciones.Enabled = false;
                //    groupBox1.Visible = false;
                //    btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
                //}
                ///calculos de dias utilizados 
                habiles = 0;
                for (int i = 0; i < Grid.RowCount; i++)
                {
                    if (Grid["estado", i].Value.ToString() == "APROBADO")
                    {
                        TimeSpan ts = DateTime.Parse(Grid["fechafin", i].Value.ToString()) - DateTime.Parse(Grid["fechainicio", i].Value.ToString());
                        int dias = ts.Days + 1;

                        DateTime AuxDays = DateTime.Parse(Grid["fechainicio", i].Value.ToString());
                        for (int j = 0; j < dias; j++)
                        {
                            if (AuxDays.DayOfWeek == DayOfWeek.Saturday || AuxDays.DayOfWeek == DayOfWeek.Sunday)
                                nohabiles++;
                            else
                                habiles++;
                            AuxDays = AuxDays.AddDays(1);
                        }
                    }
                }
                Acumulados = (habiles + (habiles / 5) * 2);
                txtDiasUtilizados.Text = Acumulados.ToString("n0");
                //txtDiasPendientes.Text = (30 - Acumulados).ToString("n0");
                txtDiasPendientes.Text = Convert.ToDecimal(txtVacaciones.Text).ToString("0");
                //msg($"habiles {habiles } y no habiles { nohabiles} Acumulado { habiles % 5} Division { (habiles/ 5).ToString("n0")} ");
            }
            else
            {
                btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
                groupBox1.Visible = false;
                txtFecha.Text = "";
                txtVacaciones.Text = "";
                txtDias.Text = "";
                txtVacaciones.Text = "";
                txtDiasPendientes.Text = "";
                txtDiasUtilizados.Text = "";
                txtObservaciones.Text = "";
                txttipo.Text = ""; //lblmensajito.Text = "";
                LimpiarGrillas();
                // TitulosGrillas();
                pbFoto.Image = null;
            }

            DataRow EmpleadoVacacionesx = clEmpleadoVacaciones.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacacionesx != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacacionesx["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacacionesx["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacacionesx["NOMBRES"].ToString();
                DataRow Contratoactivo = clEmpleadoVacaciones.ContratoActivo(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
                if (Contratoactivo != null)
                {
                    lblmensajito.Text = "EMPLEADO ACTIVO CONTRATO Nº" + Contratoactivo["Nro_Contrato"].ToString();
                    if (Contratoactivo["tipocontratacion"].ToString() == "2" || Contratoactivo["tipocontratacion"].ToString() == "3")
                    {
                        btnBoletaVacaciones.Enabled = true;
                        btnCompraVacaciones.Enabled = true;
                        groupBox1.Visible = true; 
                        btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = true;
                        pbVacaciones.Visible = false;
                    }
                    else
                    {
                        btnBoletaVacaciones.Enabled = false;
                        btnCompraVacaciones.Enabled = false;
                        // groupBox1.Visible = false;
                        btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
                        pbVacaciones.Visible = true;
                    }
                    //btnBoletaVacaciones.Enabled = true;
                    // btnCompraVacaciones.Enabled = true;
                    // groupBox1.Visible = true;
                    // btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = true;
                }
                else
                {
                    lblmensajito.Text = "EMPLEADO INACTIVO";
                    btnBoletaVacaciones.Enabled = false;
                    btnCompraVacaciones.Enabled = false;
                    groupBox1.Visible = true;
                    btnCompraVacaciones.Enabled = btnBoletaVacaciones.Enabled = btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
                    pbVacaciones.Visible = true;
                }
            }
            else
            {
                if (Grid.RowCount > 0)
                {
                    DataTable Filas = ((DataTable)Grid.DataSource).Clone();
                    Grid.DataSource = Filas;
                }
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtNombres.Text = "";
                pbFoto.Image = null; lblmensajito.Text = "";
                txtRuta.Text = "";
            }
            btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;

        }
        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Now;
            DiasInicio(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_GetDiasVacaciones");
            if (Cargado)
                Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
        }
        private void frmVacaciones_Load(object sender, EventArgs e)
        {

            // TitulosGrillas();
            LimpiarGrillas();
            txtNumeroDocumento.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtNombres.Text = "";
            txtFecha.Text = "";
            txtVacaciones.Text = "";
            txtDias.Text = "";
            txtDiasUtilizados.Text = "";
            txtDiasPendientes.Text = "";
            txtObservaciones.Text = "";
            pbFoto.Image = null;

            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            dtpInicio.Value = DateTime.Today.Date;
            dtpFin.Value = DateTime.Today.Date;

            groupBox1.Visible = false;
            if (cboTipoDocumento.DataSource != null) cboTipoDocumento.SelectedValue = 1;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleadoVacaciones.ListadodeTablaORdenadoxCodigo(codigo, descripcion, tabla);
        }
        int Habiles = 0;
        private bool Cargado;

        private void Dias(DateTime Inicio, DateTime Fin, int TipoDocumento, string NumeroDocumento)
        {
            DiasVaca = clEmpleadoVacaciones.DiasVacaciones(Inicio, Fin);
            if (DiasVaca != null)
            {
                txtDias.Text = DiasVaca["DIAS"].ToString();
            }
            ////contador de dias habiles y no habiles
            TimeSpan ts = Fin - Inicio;
            int dif = ts.Days + 1;
            DateTime DayAux;
            if (Inicio > Fin)
                DayAux = Fin;
            else
                DayAux = Inicio;
            int Nohabiles = 0;
            Habiles = 0;
            for (int i = 0; i < dif; i++)
            {
                if (DayAux.DayOfWeek == DayOfWeek.Sunday || DayAux.DayOfWeek == DayOfWeek.Saturday)
                    Nohabiles++;
                else
                    Habiles++;
                DayAux = DayAux.AddDays(1);
            }
            //txtObservaciones.Text = dif.ToString() + $" = Habiles {Habiles } + No habiles { Nohabiles} = DiasExtras{ Habiles % 5}";
            // if ((habiles + Habiles) > 22)
            //     msg("No se Puede Tomar muchos días el Máximo son 30 días", CompanyName MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataRow DiasGenerado = clEmpleadoVacaciones.DiasGenerado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, dtpInicio.Value);
            if (DiasGenerado != null)
            {
                if (DiasGenerado["DiasPendientes"].ToString().Length > 0)
                {
                    txtVacaciones.Text = ((decimal)DiasGenerado["DiasPendientes"]).ToString("n2");
                }
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
        }

        private void btnBoletaVacaciones_Click(object sender, EventArgs e)
        {
            if ((habiles + Habiles) > 22)
            {
                msg("No se Puede Tomar muchos días el Máximo son 30 días");
                dtpFin.Focus();
                return;
            }
            if (txtDias.Text.Length == 0 || Convert.ToInt32(txtDias.Text) <= 0)
            {
                msg("Días Inválido");
                txtDias.Focus();
                return;
            }

            if (Convert.ToInt32(txtDias.Text) > Convert.ToInt32(txtDiasPendientes.Text))
            {
                msg("Solo puedes tomar " + Convert.ToString(txtDiasPendientes.Text) + " días de vacaciones como máximo");
                return;
            }

            DateTime FechaMaxima;
            DataRow MaximaFecha = clEmpleadoVacaciones.MaximaFechaATomar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
            if (!MaximaFecha.IsNull("FECHA"))
            {
                FechaMaxima = Convert.ToDateTime(MaximaFecha["FECHA"].ToString());

                int Resultado = DateTime.Compare(dtpInicio.Value.Date, FechaMaxima.Date);
                if (Resultado <= 0)
                {
                    msg("Fecha de Inicio debe ser posterior a la última Fecha Fin aprobada");
                    return;
                }
            }

            int Numero = 0;
            clEmpleadoVacaciones.EmpleadoVacacionesInsertar(out Numero, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, dtpInicio.Value, dtpFin.Value, Convert.ToInt32(txtDias.Text), txtObservaciones.Text);
            MostrarGrid(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
            msgOK("Vacaciones registradas");

            frmBoletaVacaciones frmBV = new frmBoletaVacaciones();
            frmBV.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmBV.NumeroDocumento = txtNumeroDocumento.Text;
            frmBV.Registro = Numero;
            frmBV.tipo = 1;

            frmBV.ShowDialog();
            return;
        }

        private void MostrarGrid(int CodigoTipo, string NumeroDocumento)
        {
            Grid.DataSource = clEmpleadoVacaciones.ListarVacaciones(CodigoTipo, NumeroDocumento);
        }

        private void LimpiarGrillas()
        {
            if (Grid.RowCount > 0)
            {
                DataTable tablita = ((DataTable)Grid.DataSource).Clone();
                Grid.DataSource = tablita;
            }
            // Grid.Rows.Clear();
            //   Grid.Columns.Clear();
            // Grid.Refresh();
        }

        private void TitulosGrillas()
        {
            if (Grid.Columns.Count == 0)
            {
                Grid.Columns.Add("REGISTRO", "");
                Grid.Columns.Add("CODIGOTIPO", "");
                Grid.Columns.Add("TIPOID", "");
                Grid.Columns.Add("NIDI", "");
                Grid.Columns.Add("DIASTRABAJADOS", "");
                Grid.Columns.Add("FECHAINICIO", "");
                Grid.Columns.Add("FECHAFIN", "");
                Grid.Columns.Add("DIASVACACIONES", "");
                Grid.Columns.Add("ESTADO", "");
                Grid.Columns.Add("OBSERVACION", "");
            }

            Grid.Columns[0].Width = 0;
            Grid.Columns[0].Visible = false;
            Grid.Columns[0].DataPropertyName = "REGISTRO";

            Grid.Columns[1].Width = 0;
            Grid.Columns[1].Visible = false;
            Grid.Columns[1].DataPropertyName = "CODIGOTIPO";

            Grid.Columns[2].Width = 80;
            Grid.Columns[2].Visible = true;
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Grid.Columns[2].HeaderText = "TIPO ID";
            Grid.Columns[2].DataPropertyName = "TIPOID";

            Grid.Columns[3].Width = 80;
            Grid.Columns[3].Visible = true;
            Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns[3].HeaderText = "Nº ID";
            Grid.Columns[3].DataPropertyName = "NID";

            Grid.Columns[4].Width = 60;
            Grid.Columns[4].Visible = true;
            Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns[4].HeaderText = "DIAS TRAB.";
            Grid.Columns[4].DataPropertyName = "DIASTRABAJADOS";

            Grid.Columns[5].Width = 80;
            Grid.Columns[5].Visible = true;
            Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[5].HeaderText = "FECHA INI.";
            Grid.Columns[5].DataPropertyName = "FECHAINICIO";

            Grid.Columns[6].Width = 80;
            Grid.Columns[6].Visible = true;
            Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[6].HeaderText = "FECHA FIN";
            Grid.Columns[6].DataPropertyName = "FECHAFIN";

            Grid.Columns[7].Width = 60;
            Grid.Columns[7].Visible = true;
            Grid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid.Columns[7].HeaderText = "DIAS VAC.";
            Grid.Columns[7].DataPropertyName = "DIASVACACIONES";

            Grid.Columns[8].Width = 80;
            Grid.Columns[8].Visible = true;
            Grid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[8].HeaderText = "ESTADO";
            Grid.Columns[8].DataPropertyName = "ESTADO";

            Grid.Columns[9].Width = 100;
            Grid.Columns[9].Visible = true;
            Grid.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns[9].HeaderText = "OBSERVACION";
            Grid.Columns[9].DataPropertyName = "OBSERVACION";
        }

        private void btnAprobarVacaciones_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[0].Value != null && Grid.CurrentRow.Cells[8].Value.ToString() != "APROBADO")
            {
                if (pbFoto.Image == null)
                {
                    msg("Seleccione Imagen");
                    btnSeleccionarImagen.Focus();
                    return;
                }

                clEmpleadoVacaciones.AprobarVacaciones(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(Grid.CurrentRow.Cells[1].Value.ToString()), Grid.CurrentRow.Cells[3].Value.ToString(), Foto, txtRuta.Text);
                MostrarGrid(Convert.ToInt32(Grid.CurrentRow.Cells[1].Value.ToString()), Grid.CurrentRow.Cells[3].Value.ToString());
                msgOK("Aprobación con éxito");
                dtpInicio.Value = DateTime.Today.Date;
                dtpFin.Value = DateTime.Today.Date;
                DiasInicio(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_GetDiasVacaciones");
                Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                return;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[0].Value != null && Grid.CurrentRow.Cells[8].Value.ToString() == "PENDIENTE")
            {
                var dialogoAbrirArchivo = new OpenFileDialog();
                dialogoAbrirArchivo.Filter = Configuraciones.FilterImagenes();
                //dialogoAbrirArchivo.DefaultExt = ".jpg";
                dialogoAbrirArchivo.ShowDialog(this);

                NombreFoto = dialogoAbrirArchivo.FileName.ToString();
                DataRow ExisteBoleta = clEmpleadoVacaciones.ExisteImagen("NombreFoto", NombreFoto, "TBL_Empleado_Vacaciones");
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
                    msg("Imagen Asociada a otra Boleta de Vacaciones");
                    return;
                }
            }
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Imagen de Vacaciones");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.Rows[e.RowIndex].Cells[8].Value.ToString() == "APROBADO")
                CargarFoto(Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value.ToString()), Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[1].Value.ToString()), Grid.Rows[e.RowIndex].Cells[3].Value.ToString());
            else
                pbFoto.Image = null;
            if (Grid["estado", e.RowIndex].Value.ToString() == "ANULADA")
                btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
            if (Grid["estado", e.RowIndex].Value.ToString() == "PENDIENTE")
                btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = true;
            else
                btnAprobarVacaciones.Enabled = btnSeleccionarImagen.Enabled = false;
        }

        private void CargarFoto(int Registro, int TipoDocumento, string NumeroDocumento)
        {
            DataRow drFoto = clEmpleadoVacaciones.ImagenBoleta(Registro, TipoDocumento, NumeroDocumento);
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
        private void btnCompraVacaciones_Click(object sender, EventArgs e)
        {
            if (txtDiasPendientes.Text.Length > 0)
            {
                frmCompraVacaciones frmCV = new frmCompraVacaciones();
                frmCV.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                frmCV.NumeroDocumento = txtNumeroDocumento.Text;
                frmCV.Icon = Icon;
                frmCV.FechaInicioLabores = txtFecha.Text;
                if (Grid.RowCount > 0)
                {
                    frmCV.FechaUltimoPeriodoDesde = Grid.Rows[Grid.Rows.Count - 1].Cells[5].Value.ToString();
                    frmCV.FechaUltimoPeriodoHasta = Grid.Rows[Grid.Rows.Count - 1].Cells[6].Value.ToString();
                }
                frmCV.DiasUtilizados = txtDiasUtilizados.Text;
                frmCV.MaximoDiasComprar = txtDiasPendientes.Text;

                if (frmCV.ShowDialog() == DialogResult.OK)
                {
                    frmBoletaVacaciones frmBV = new frmBoletaVacaciones();
                    frmBV.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmBV.NumeroDocumento = txtNumeroDocumento.Text;
                    DataRow Filita = clEmpleadoVacaciones.UltimoRegistoVacaciones((int)cboTipoDocumento.SelectedValue, txtNumeroDocumento.Text);
                    if (Filita != null)
                    {
                        int Numero = (int)Filita["ultimo"];
                        frmBV.Registro = Numero;
                        frmBV.tipo = 2;
                        frmBV.ShowDialog();
                    }
                    DiasInicio(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_GetDiasVacaciones");
                    Dias(dtpInicio.Value, dtpFin.Value, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                }
            }
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtDiasPendientes_TextChanged(object sender, EventArgs e)

        {
            try
            {
                int dias;
                dias = Convert.ToInt32(txtDiasPendientes.Text);
                if (dias == 0 || string.IsNullOrWhiteSpace(txtDiasPendientes.Text.ToString()))
                {
                    groupBox1.Visible = false;
                }
                else { groupBox1.Visible = true; }
            }
            catch { }

        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento_TextChanged(sender, e);
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

        private void frmVacaciones_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }

        private void txtNumeroDocumento_DoubleClick(object sender, EventArgs e)
        {
            frmListarEmpleados frmlisempleados = new frmListarEmpleados();
            frmlisempleados.NumeroDocumento = txtNumeroDocumento.Text;
            if (frmlisempleados.ShowDialog() == DialogResult.OK)
            {
                txtNumeroDocumento.Text = frmlisempleados.NumeroDocumento;
                if (cboTipoDocumento.DataSource != null)
                    cboTipoDocumento.SelectedValue = frmlisempleados.TipoDocumento;
            }
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 10);
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            MostrarFoto(pbFoto);
        }
    }
}
