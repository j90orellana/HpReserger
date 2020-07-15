﻿using HpResergerUserControls;
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
            cbotipoid.DataSource = CapaLogica.getCargoTipoContratacion("Codigo_Tipo_ID", "desc_tipo_id", "tbl_tipo_id");
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
                //Validamos que el asiento Exista

                //Validamos que el periodo Exista

                //validamos que el periodo este abierto







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
                        if (chkGAsientos.Checked)
                        {
                            DataTable Tablita = new DataTable();
                            //filtrar por lo que ya esta generado
                            Tablita = CapaLogica.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                            if (Tablita.Rows.Count > 0)
                            {
                                DataRow Ultimo = CapaLogica.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                                int ultimo = 1 + (int)Ultimo["ultimo"];
                                DataRow Filita = Tablita.Rows[0];
                                DataTable Ultimox = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                                Ultimo = Ultimox.Rows[0];
                                ultimo = ((int)Ultimo["codigo"]);
                                foreach (DataColumn col in Tablita.Columns)
                                {
                                    CapaLogica.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, decimal.Parse(Filita[col.ColumnName].ToString() == "" ? "0" : Filita[col.ColumnName].ToString()));
                                }
                                //cuentas de Reflejo
                                //DataTable Cuentas = new DataTable();
                                //Cuentas = CReporteboleta.CuentasReflejo(ultimo, (int)cboempresa.SelectedValue, DateTime.Now.Date);
                                //if (Cuentas.Rows.Count > 0)
                                //{
                                //    DataRow Fila0 = Cuentas.Rows[0];
                                //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Haber"].ToString(), (decimal)Fila0["Deberes"], "H");
                                //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Debe"].ToString(), (decimal)Fila0["Haberes"], "D");
                                //}
                            }
                        }
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
                    if (Tablita.Rows.Count > 0)
                        if (chkGAsientos.Checked)
                        {
                            if ((Tablita.Rows[0])[0].ToString().ToUpper() != "")
                            {
                                DataRow Ultimo = CapaLogica.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                                int ultimo = 1 + (int)Ultimo["ultimo"];
                                DataRow Filita = Tablita.Rows[0];
                                DataTable Ultimox = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                                Ultimo = Ultimox.Rows[0];
                                ultimo = ((int)Ultimo["codigo"]);
                                foreach (DataColumn col in Tablita.Columns)
                                {
                                    CapaLogica.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, (decimal)Filita[col.ColumnName]);
                                }
                                //cuentas de Reflejo
                                //DataTable Cuentas = new DataTable();
                                //Cuentas = CReporteboleta.CuentasReflejo(ultimo, (int)cboempresa.SelectedValue, DateTime.Now.Date);
                                //if (Cuentas.Rows.Count > 0)
                                //{
                                //    DataRow Fila0 = Cuentas.Rows[0];
                                //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Haber"].ToString(), (decimal)Fila0["Deberes"], "H");
                                //    CReporteboleta.InsertarCuentasReflejo(ultimo + 1, empresa, Fila0["Debe"].ToString(), (decimal)Fila0["Haberes"], "D");
                                //}
                            }
                        }
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
        private void ValidarCheck()
        {
            if (chkGAsientos.Checked)
            {
                rbTodasEmpresa.Visible = comboMesAño2.Visible = label2.Visible = false;
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
                txtglosa2.Visible = txtGlosa1.Visible = cboproyecto.Visible = cboetapa.Visible = false;
                this.MinimumSize = new Size(517, 272);
                this.MaximumSize = new Size(517, 272);
            }
        }
    }
}
