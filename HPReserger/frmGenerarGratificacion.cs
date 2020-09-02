using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmGenerarGratificacion : FormGradient
    {
        public frmGenerarGratificacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgYesCancel(string cadena, string detalle) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena, detalle); }
        public void cargarempresas()
        {
            string cadena = cboempresa.Text;
            DataTable Tdatos = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            if (Tdatos.Rows.Count != cboempresa.Items.Count)
            {
                cboempresa.ValueMember = "codigo";
                cboempresa.DisplayMember = "descripcion";
                cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
                if (cboempresa.DataSource != null) cboempresa.Text = cadena;
            }
        }
        public void cargartipoid()
        {
            cbotipoid.DataSource = CapaLogica.ListadodeTablaORdenadoxCodigo("Codigo_Tipo_ID", "desc_tipo_id", "tbl_tipo_id");
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "descripcion";
        }
        int empresa = 0, tipo = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                empresa = int.Parse(cboempresa.SelectedValue.ToString());
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                //btnrectipo.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = true;
                //btnrecempresa.Enabled = true;
            }
            else empresa = 0;
        }
        string numero = "0";
        private DateTime FechaContable;
        private int DinamicaAsiento = -66;
        private int IdEmpresa;
        private decimal Sumatoria = 0;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersona.Checked)
            {
                tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                numero = txtnumero.Text;
                cboempresa.Enabled = false;
                //btnrecempresa.Enabled = false;
                cbotipoid.Enabled = true;
                txtnumero.Enabled = true;
                //btnrectipo.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                tipo = 0; numero = "0";
            }
        }
        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }
        private void btnrectipo_Click(object sender, EventArgs e)
        {
            cargartipoid();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            //Validaciones para el proceso de generar el asiento
            if (chkGAsientos.Checked)
            {
                if (cboempresa.Items.Count == 0) { msgError("No hay Empresas"); cboempresa.Focus(); return; }
                if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
                if (cboproyecto.Items.Count == 0) { msgError("No hay Proyectos"); cboproyecto.Focus(); return; }
                if (cboproyecto.SelectedValue == null) { msgError("Seleccione una Proyecto"); cboproyecto.Focus(); return; }
                if (cboetapa.Items.Count == 0) { msgError("No hay Etapas"); cboetapa.Focus(); return; }
                if (cboetapa.SelectedValue == null) { msgError("Seleccione una Etapa"); cboetapa.Focus(); return; }
                //if (!txtGlosa1.EstaLLeno()) { msgError("Ingrese Glosa del Asiento de la Boleta"); txtGlosa1.Focus(); return; }
                //
                int IdEmpresa = (int)cboempresa.SelectedValue;
                FechaContable = comboMesAño1.GetFecha();
                //Validamos que el asiento Exista
                //Dinamica --66 Asiento 
                if (CapaLogica.ValidarAsientoExiste(DinamicaAsiento, FechaContable, IdEmpresa)) { msgError("Ya Existe Asiento de la CTS"); return; }
                //Validamos que el periodo Exista
                if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaContable))
                {
                    if (msgYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaContable.ToString("MMMM")}-{FechaContable.Year}?") != DialogResult.Yes)
                        return;
                }
                //validamos que el periodo este abierto
                if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaContable))
                {
                    msgError("El Periodo Esta Cerrado, Cambie Fecha Contable"); comboMesAño1.Focus(); return;
                }
            }
            empresa = 0; tipo = 0;
            DataTable DBoleta = new DataTable();
            if (rbEmpresa.Checked)
                if (cboempresa.Items.Count > 0)
                    empresa = int.Parse(cboempresa.SelectedValue.ToString());
                else
                {
                    msg("No hay Empresas");
                    return;
                }
            if (rbPersona.Checked)
            {
                if (cbotipoid.Items.Count > 0)
                {
                    tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                    numero = txtnumero.Text;
                }
                else
                {
                    msg("No Hay Tipos de ID"); return;
                }
            }
            DateTime inicial;
            ///Ver si hay datos
            inicial = comboMesAño1.GetFechaPRimerDia();
            CapaLogica.GenerarGratificaciones(empresa, tipo, numero, 1, comboMesAño1.GetFechaPRimerDia(), comboMesAño1.GetFechaPRimerDia(), frmLogin.CodigoUsuario);
            DBoleta = CapaLogica.SeleccionarGratificacion(empresa, tipo, numero, 1, inicial, inicial);
            if (DBoleta.Rows.Count == 0)
            {
                msg($"No hay Gratificaciones que Mostrar del :{inicial.ToLongDateString()}");
                return;
            }
            frmReporteGratificacion frmgratis = new frmReporteGratificacion();
            frmgratis.empresa = empresa;
            frmgratis.tipo = tipo;
            frmgratis.numero = numero;
            frmgratis.fecha = 1;
            frmgratis.fechainicial = inicial;
            msgOK("Gratificaciones Generadas con Éxito");
            frmgratis.Fechafin = inicial;
            frmgratis.Show();
            //Proceso de los Asientos            
            if (chkGAsientos.Checked)
            {
                DataTable TConfi = CapaLogica.ConfigurarAsientoBoletas();//PARTE PARA SELECCIONAR LOS TIPOS
                if (TConfi.Rows.Count == 0) { msgError("No se Encontró la Configuracion para el Asiento de la Gratificación"); return; }
                DataTable TDatos = CapaLogica.ReporteBoletasAsiento(cboempresa.Text, txtnumero.Text, comboMesAño1.GetFechaPRimerDia(), comboMesAño1.GetFechaPRimerDia());
                if (TDatos.Rows.Count == 0) { msgError("No hay Gratificacion Generadas"); return; }
                //Proceso para el Insert de los Registros
                //Asientos de las Boletas 1=Asiento 2= provision 3 = gratificacion
                //DateTime FechaContable = comboMesAño1.GetFecha();
                GenerarAsientoBoletas(TConfi, TDatos, 3, FechaContable, DinamicaAsiento, txtGlosa1);
                msgOK("Asiento Generado");
                txtGlosa1.CargarTextoporDefecto();
            }
        }
        private decimal BuscarSihayValores(DataTable datos, string v)
        {
            Sumatoria = 0;
            foreach (DataRow item in datos.Rows) Sumatoria += decimal.Parse(item[v].ToString());
            //if (Sumatoria > 0) return Sumatoria; else
            return Sumatoria;
        }
        private void GenerarAsientoBoletas(DataTable confi, DataTable datos, int Tipo, DateTime FechaContable, int idDinamica, TextBox txt)
        {
            decimal TC = CapaLogica.TipoCambioDia("Venta", FechaContable);
            int NumAsiento = 0;
            IdEmpresa = (int)cboempresa.SelectedValue;
            int IdProyecto = (int)cboproyecto.SelectedValue;
            int IdEtapa = (int)cboetapa.SelectedValue;
            int IdSoles = 1;
            string glosa = txt.Text;
            int IdUsuario = frmLogin.CodigoUsuario;
            if (NumAsiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento(IdEmpresa, FechaContable);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) NumAsiento = 1;
                else NumAsiento = ((int)asiento["codigo"]);
            }
            string Cuo = HPResergerFunciones.Utilitarios.Cuo(NumAsiento, FechaContable);
            // return;
            int PosFila = 0;
            foreach (DataRow item in confi.Rows)
            {
                if ((int)item["tipo"] == Tipo)
                {
                    decimal Suma = 0;
                    Suma = BuscarSihayValores(datos, item["columnatabla"].ToString());
                    if (Suma > 0)
                    {
                        Boolean Debe = item["debehaber"].ToString() == "D" ? true : false;
                        Boolean IncluirFecha = (Boolean)item["incluirfechaglosa"];
                        string CuentaContable = item["cuenta"].ToString();
                        string ColumnaTabla = item["columnatabla"].ToString();
                        decimal ValorDebeMN = Debe ? Suma : 0;
                        decimal ValorHaberMN = Debe ? 0 : Suma;
                        string GlosaDetalle = item["glosa"].ToString() + $" {FechaContable.ToString("MMMM/yyyy")}";
                        GlosaDetalle = IncluirFecha ? GlosaDetalle : item["glosa"].ToString();
                        GlosaDetalle = GlosaDetalle.ToUpper();
                        //Cabecera
                        PosFila++;
                        CapaLogica.InsertarAsientoFacturaCabecera(1, PosFila, NumAsiento, FechaContable, CuentaContable, ValorDebeMN, ValorHaberMN, TC, IdProyecto, IdEtapa, Cuo,
                            IdSoles, glosa, FechaContable, idDinamica);
                        //Detalle
                        foreach (DataRow filas in datos.Rows)
                        {
                            if ((decimal)filas[item["columnatabla"].ToString()] > 0)
                            {
                                int TipoIdProveedor = (int)filas["tipoid"];
                                string RucProveedor = filas["nrodoc"].ToString();
                                string NameProveedor = filas["nombreempleado"].ToString();
                                int idcomprobante = 0;
                                string SerieDocumento = Tipo == 1 ? "BOL" : tipo == 2 ? "PROV" : tipo == 3 ? "GRA" : "CTS";
                                string NumDocumento = FechaContable.ToString("MMyyyy");
                                decimal ValorSoles = (decimal)filas[item["ColumnaTabla"].ToString()];
                                decimal ValorDolares = ValorSoles / TC;
                                string NroCuentaBancaria = "";
                                ///
                                CapaLogica.InsertarAsientoFacturaDetalle(99, PosFila, NumAsiento, FechaContable, CuentaContable, IdProyecto, TipoIdProveedor, RucProveedor, NameProveedor,
                                    idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSoles, ValorDolares, TC, IdSoles, NroCuentaBancaria, "",
                                    GlosaDetalle, FechaContable, IdUsuario, "", 3);
                            }
                        }
                    }
                }
            }
            CapaLogica.CuadrarAsiento(Cuo, IdProyecto, FechaContable, 2);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkGAsientos_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheck();
        }
        private void ValidarCheck()
        {
            if (chkGAsientos.Checked)
            {
                //comboMesAño2.Visible = label2.Visible = false;
                btnlimpiar.Enabled = rbPersona.Checked = rbPersona.Enabled = false;
                rbEmpresa.Checked = true;
                //txtglosa2.Visible = 
                txtGlosa1.Visible = cboproyecto.Visible = cboetapa.Visible = true;
                //Cambiamos el size del formulario
                this.MinimumSize = new Size(517, 284);
                this.MaximumSize = new Size(517, 284);
                //if (rbTodasEmpresa.Checked)
                //{
                //    rbTodasEmpresa.Checked = false;
                //    rbEmpresa.Checked = true;
                //}
            }
            else
            {
                //comboMesAño2.Visible = label2.Visible = true;
                btnlimpiar.Enabled = rbPersona.Enabled = true;
                //txtglosa2.Visible =
                txtGlosa1.Visible = cboproyecto.Visible = cboetapa.Visible = false;
                this.MinimumSize = new Size(517, 233);
                this.MaximumSize = new Size(517, 233);
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = (cboempresa.SelectedValue ?? "").ToString();
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cadena);
        }

        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
            cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
            cboetapa.ValueMember = "id_etapa";
            cboetapa.DisplayMember = "descripcion";
        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
            cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
            cboetapa.ValueMember = "id_etapa";
            cboetapa.DisplayMember = "descripcion";
        }
        public void CambiarTextoxDefectoGlosas()
        {
            bool prueba = false;
            if (!txtGlosa1.EstaLLeno()) prueba = true;
            txtGlosa1.TextoDefecto = $"PAGO GRATIFICACIONES {comboMesAño1.FechaInicioMes.ToString("MMMM yyyy").ToUpper() }";
            if (prueba) txtGlosa1.CargarTextoporDefecto();
        }
        private void comboMesAño1_CambioFechas(object sender, EventArgs e)
        {
            CambiarTextoxDefectoGlosas();
        }
        private void frmGenerarGratificacion_Load(object sender, EventArgs e)
        {
            CambiarTextoxDefectoGlosas();
            // Gratificaciones 7=julio 12=diciembre
            //if (DateTime.Now.Month == 7 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12)
            //{
            //    cargarempresas();
            //    cargartipoid();
            //    empresa = 1;
            //    if (DateTime.Now.Month == 7)
            //        comboMesAño1.MostrarMeses(7);
            //    if (DateTime.Now.Month == 11)
            //        comboMesAño1.MostrarMeses(12);
            //}
            //else
            //{
            //    msg($"Las Gratificaciones se Pagan solo en Julio y Diciembre ");
            //    this.Close();
            //}
            txtGlosa1.CargarTextoporDefecto();
            comboMesAño1.MostrarMeses(7, 12);
            cargarempresas();
            cargartipoid();
            empresa = 1;
            ValidarCheck();
        }
    }
}
