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
    public partial class frmGenerarBoletas : FormGradient
    {
        public frmGenerarBoletas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgYesCancel(string cadena, string detalle) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena, detalle); }
        private void frmGenerarBoletas_Load(object sender, EventArgs e)
        {
            txtGlosa1.CargarTextoporDefecto(); txtglosa2.CargarTextoporDefecto();
            ValidarCheck();
            cboetapa.Enabled = cboproyecto.Enabled = true;
            cargarempresas();
            cargartipoid();
            empresa = 1;
        }
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
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }
        string numero = "0";
        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }
        private void btnrectipo_Click(object sender, EventArgs e)
        {
            cargartipoid();
        }
        DataTable DBoleta;
        int IdEmpresa;
        DateTime FechaContable;
        private int DinamicaAsiento = -60;
        private int DinamicaProvision = -61;
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
                if (!txtGlosa1.EstaLLeno()) { msgError("Ingrese Glosa del Asiento de la Boleta"); txtGlosa1.Focus(); return; }
                if (!txtglosa2.EstaLLeno()) { msgError("Ingrese la Glosa del asiento de Provisión"); txtglosa2.Focus(); return; }
                //
                int IdEmpresa = (int)cboempresa.SelectedValue;
                FechaContable = comboMesAño1.GetFecha();
                //Validamos que el asiento Exista
                //Dinamica --60 Asiento -61 Provision
                if (ValidarAsientoExiste(DinamicaAsiento, FechaContable, IdEmpresa)) { msgError("Ya Existe Asiento de la Boleta"); return; }
                if (ValidarAsientoExiste(DinamicaProvision, FechaContable, IdEmpresa)) { msgError("Ya Existe Provisión de la Boleta"); return; }
                //Validamos que el periodo Exista
                if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaContable))
                {
                    if (msgYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaContable.ToString("MMMM")}-{FechaContable.Year}?") != DialogResult.Yes)
                        return;
                }
                //validamos que el periodo este abierto
                else if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaContable))
                {
                    msgError("El Periodo Esta Cerrado, Cambie Fecha Contable"); comboMesAño1.Focus(); return;
                }
            }
            empresa = 0; tipo = 0;
            if (rbEmpresa.Checked)
                if (cboempresa.Items.Count > 0)
                    empresa = int.Parse(cboempresa.SelectedValue.ToString());
                else
                {
                    msgError("No hay Empresas");
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
                    msgError("No Hay Tipos de ID"); return;
                }
            }
            if (rbTodasEmpresa.Checked)
            {
                //todas las empresas
                foreach (DataRowView item in cboempresa.Items)
                {
                    empresa = (int)item.Row.ItemArray[0];
                    DBoleta = new DataTable();
                    DateTime inicial, final;
                    ///Ver si hay datos
                    inicial = comboMesAño1.GetFechaPRimerDia();
                    final = comboMesAño2.GetFecha();
                    //
                    //if (inicial.Day == 1) final.AddDays(1);
                    //if (final.Day == 1) final.AddDays(10);
                    if (inicial > final)
                    {
                        inicial = comboMesAño2.GetFechaPRimerDia();
                        final = comboMesAño1.GetFecha();
                    }
                    DBoleta = CapaLogica.SeleccionarBoletas(0, tipo, numero, 1, inicial, final);
                    int aux = (12 * (final.Year - inicial.Year) + final.Month) - inicial.Month + 1;
                    // msg("meses " + aux + "inicial " + inicial + "final " + final);
                    List<string> listita = new List<string>();
                    foreach (DataRow x in DBoleta.Rows)
                        listita.Add(x["mes"].ToString());
                    listita = listita.Distinct().ToList<string>();
                    //if (listita.Count != aux)
                    if (DBoleta.Rows.Count == 0)
                    {
                        //cuando no hay boletas 
                        CapaLogica.GenerarBoletasMensuales(0, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                        //Generar Asiento de Boletas Generadas
                        //if (chkGAsientos.Checked)
                        //{
                        //    DataTable Tablita = new DataTable();
                        //    //filtrar por lo que ya esta generado
                        //    Tablita = CapaLogica.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                        //    if (Tablita.Rows.Count > 0)
                        //    {
                        //        DataRow Ultimo = CapaLogica.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                        //        int ultimo = 1 + (int)Ultimo["ultimo"];
                        //        DataRow Filita = Tablita.Rows[0];
                        //        DataTable Ultimox = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                        //        Ultimo = Ultimox.Rows[0];
                        //        ultimo = ((int)Ultimo["codigo"]);
                        //        foreach (DataColumn col in Tablita.Columns)
                        //        {
                        //            CapaLogica.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, decimal.Parse(Filita[col.ColumnName].ToString() == "" ? "0" : Filita[col.ColumnName].ToString()));
                        //        }
                        //        //cuentas de Reflejo
                        //        //DataTable Cuentas = new DataTable();
                        //        //Cuentas = CReporteboleta.CuentasReflejo(ultimo, (int)cboempresa.SelectedValue, DateTime.Now.Date);
                        //        //if (Cuentas.Rows.Count > 0)
                        //        //{
                        //        //    DataRow Fila0 = Cuentas.Rows[0];
                        //        //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Haber"].ToString(), (decimal)Fila0["Deberes"], "H");
                        //        //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Debe"].ToString(), (decimal)Fila0["Haberes"], "D");
                        //        //}
                        //    }
                        //}
                        //fin de Asientos DE boletas Generadas
                    }
                    DBoleta = CapaLogica.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
                    if (DBoleta.Rows.Count == 0)
                    {
                        // msg($"No hay Boletas que Mostrar del :{inicial.ToLongDateString()} \nHasta: {final.ToLongDateString()}");
                    }
                    else
                    {
                        frmreporteboletasfin boletas = new frmreporteboletasfin();
                        boletas.Text = "Reporte Boletas de Pagos [ " + item.Row.ItemArray[1].ToString() + " ]";
                        boletas.empresa = empresa;
                        boletas.tipo = tipo;
                        boletas.numero = numero;
                        boletas.fecha = 1;
                        boletas.Icon = Icon;
                        boletas.fechainicial = inicial;
                        boletas.Fechafin = final;
                        boletas.Show();
                    }
                }
                msgOK("Generadas con Exito");
            }
            else
            {
                DBoleta = new DataTable();
                DateTime inicial, final;
                ///Ver si hay datos
                inicial = comboMesAño1.GetFechaPRimerDia();
                final = comboMesAño2.GetFecha();
                if (inicial > final)
                {
                    inicial = comboMesAño2.GetFechaPRimerDia();
                    final = comboMesAño1.GetFecha();
                }
                if (chkGAsientos.Checked)
                {
                    inicial = final = comboMesAño1.GetFechaPRimerDia();
                }
                DBoleta = CapaLogica.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
                int aux = (12 * (final.Year - inicial.Year) + final.Month) - inicial.Month + 1;
                // msg("meses " + aux + "inicial " + inicial + "final " + final);
                List<string> listita = new List<string>();
                foreach (DataRow x in DBoleta.Rows)
                    listita.Add(x["mes"].ToString());
                listita = listita.Distinct().ToList<string>();
                //if (listita.Count != aux)
                if (DBoleta.Rows.Count == 0)
                {
                    //cuando no hay boletas 
                    CapaLogica.GenerarBoletasMensuales(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                    //Generar Asiento de Boletas Generadas
                    DataTable Tablita = new DataTable();
                    Tablita = CapaLogica.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                    //if (Tablita.Rows.Count > 0)
                    //if (chkGAsientos.Checked)
                    //{                           
                    //    if ((Tablita.Rows[0])[0].ToString().ToUpper() != "")
                    //    {
                    //        DataRow Ultimo = CapaLogica.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                    //        int ultimo = 1 + (int)Ultimo["ultimo"];
                    //        DataRow Filita = Tablita.Rows[0];
                    //        DataTable Ultimox = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                    //        Ultimo = Ultimox.Rows[0];
                    //        ultimo = ((int)Ultimo["codigo"]);
                    //        foreach (DataColumn col in Tablita.Columns)
                    //        {
                    //            CapaLogica.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, (decimal)Filita[col.ColumnName]);
                    //        }
                    //        //cuentas de Reflejo
                    //        //DataTable Cuentas = new DataTable();
                    //        //Cuentas = CReporteboleta.CuentasReflejo(ultimo, (int)cboempresa.SelectedValue, DateTime.Now.Date);
                    //        //if (Cuentas.Rows.Count > 0)
                    //        //{
                    //        //    DataRow Fila0 = Cuentas.Rows[0];
                    //        //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Haber"].ToString(), (decimal)Fila0["Deberes"], "H");
                    //        //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Debe"].ToString(), (decimal)Fila0["Haberes"], "D");
                    //        //}
                    //    }
                    //}
                    //fin de Asientos DE boletas Generadas
                }
                DBoleta = CapaLogica.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
                if (DBoleta.Rows.Count == 0)
                {
                    msgError($"No hay Boletas que Mostrar del :{inicial.ToLongDateString()} \nHasta: {final.ToLongDateString()}");
                    return;
                }
                frmreporteboletasfin boletas = new frmreporteboletasfin();
                boletas.empresa = empresa;
                boletas.tipo = tipo;
                boletas.numero = numero;
                boletas.fecha = 1;
                boletas.Icon = Icon;
                boletas.fechainicial = inicial;
                boletas.Fechafin = final;
                boletas.Show();
            }
            //Proceso de los Asientos
            if (chkGAsientos.Checked)
            {
                DataTable TConfi = CapaLogica.ConfigurarAsientoBoletas();
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                foreach (DataRow item in TConfi.Rows)
                    ListaAuxiliar.Add(item["cuenta"].ToString());
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS                
                //PARTE PARA SELECCIONAR LOS TIPOS
                if (TConfi.Rows.Count == 0) { msgError("No se Encontró la Configuracion para los asientos de las boletas"); return; }
                DataTable TDatos = CapaLogica.ReporteBoletasAsiento(cboempresa.Text, txtnumero.Text, comboMesAño1.GetFechaPRimerDia(), comboMesAño1.GetFechaPRimerDia());
                if (TDatos.Rows.Count == 0) { msgError("No hay Boletas Encontradas"); return; }
                //Proceso para el Insert de los Registros
                //Asientos de las Boletas 1=Asiento 2= provision
                //DateTime FechaContable = comboMesAño1.GetFecha();
                GenerarAsientoBoletas(TConfi, TDatos, 1, FechaContable, DinamicaAsiento, txtGlosa1);
                GenerarAsientoBoletas(TConfi, TDatos, 2, FechaContable, DinamicaProvision, txtglosa2);
                msgOK("Asiento Generado");
                txtGlosa1.CargarTextoporDefecto();
                txtglosa2.CargarTextoporDefecto();
            }
        }
        public void GenerarAsientoBoletas(DataTable confi, DataTable datos, int Tipo, DateTime FechaContable, int idDinamica, TextBox txt)
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
                        string GlosaDetalle = item["glosa"].ToString() + $" {FechaContable.ToString(Configuraciones.MMyyyy)}";
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
                                string SerieDocumento = Tipo == 1 ? "BOL" : "PROV";
                                string NumDocumento = FechaContable.ToString(Configuraciones.MMyyyy);
                                decimal ValorSoles = (decimal)filas[item["ColumnaTabla"].ToString()];
                                decimal ValorDolares = ValorSoles / TC;
                                string NroCuentaBancaria = "";
                                ///
                                CapaLogica.InsertarAsientoFacturaDetalle(99, PosFila, NumAsiento, FechaContable, CuentaContable, IdProyecto, TipoIdProveedor, RucProveedor, NameProveedor,
                                    idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSoles, ValorDolares, TC, IdSoles, NroCuentaBancaria, "",
                                    GlosaDetalle, FechaContable, IdUsuario, "");
                            }
                        }
                    }
                }
            }
            CapaLogica.CuadrarAsiento(Cuo, IdProyecto, FechaContable, 2);
        }
        decimal Sumatoria = 0;
        private decimal BuscarSihayValores(DataTable datos, string v)
        {
            Sumatoria = 0;
            foreach (DataRow item in datos.Rows) Sumatoria += decimal.Parse(item[v].ToString());
            //if (Sumatoria > 0) return Sumatoria; else
            return Sumatoria;
        }
        private bool ValidarAsientoExiste(int v, DateTime dateTime, int selectedValue)
        {
            DataTable TAuxiliar;
            TAuxiliar = CapaLogica.CierreMensualDinamicaYaExiste(v, dateTime, selectedValue);
            if (TAuxiliar.Rows.Count > 0)
            {
                DataRow Filita = TAuxiliar.Rows[0];
                return true;
            }
            else
            {
                return false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                empresa = int.Parse(cboempresa.SelectedValue.ToString());
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = true;
            }
            else empresa = 0;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersona.Checked)
            {
                tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                numero = txtnumero.Text;
                cboempresa.Enabled = false;
                cbotipoid.Enabled = true;
                txtnumero.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                tipo = 0; numero = "0";
            }
        }
        private void rbTodasEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodasEmpresa.Checked)
            {
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = false;
            }
        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }
        private void cbotipoid_Click(object sender, EventArgs e)
        {
            cargartipoid();
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = (cboempresa.SelectedValue ?? "").ToString();
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cadena);
        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
            cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
            cboetapa.ValueMember = "id_etapa";
            cboetapa.DisplayMember = "descripcion";
        }

        private void chkGAsientos_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCheck();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarCheck()
        {
            if (chkGAsientos.Checked)
            {
                rbTodasEmpresa.Visible = comboMesAño2.Visible = label2.Visible = false;
                rbPersona.Checked = rbPersona.Enabled = false;
                rbEmpresa.Checked = true;
                txtglosa2.Visible = txtGlosa1.Visible = cboproyecto.Visible = cboetapa.Visible = true;
                //Cambiamos el size del formulario
                this.MinimumSize = new Size(517, 322);
                this.MaximumSize = new Size(517, 322);
                if (rbTodasEmpresa.Checked)
                {
                    rbTodasEmpresa.Checked = false;
                    rbEmpresa.Checked = true;
                }
            }
            else
            {
                rbTodasEmpresa.Visible = comboMesAño2.Visible = label2.Visible = true;
                rbPersona.Enabled = true;
                txtglosa2.Visible = txtGlosa1.Visible = cboproyecto.Visible = cboetapa.Visible = false;
                this.MinimumSize = new Size(517, 272);
                this.MaximumSize = new Size(517, 272);
            }
        }
    }
}
