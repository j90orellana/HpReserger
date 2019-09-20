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
        HPResergerCapaLogica.HPResergerCL CReporteboleta = new HPResergerCapaLogica.HPResergerCL();
        private void frmGenerarBoletas_Load(object sender, EventArgs e)
        {
            cargarempresas();
            cargartipoid();
            empresa = 1;
        }
        public void cargarempresas()
        {
            cboempresa.DataSource = CReporteboleta.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }
        public void cargartipoid()
        {
            cbotipoid.DataSource = CReporteboleta.getCargoTipoContratacion("Codigo_Tipo_ID", "desc_tipo_id", "tbl_tipo_id");
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
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        DataTable DBoleta;
        private void btngenerar_Click(object sender, EventArgs e)
        {

            empresa = 0; tipo = 0;
            if (radioButton1.Checked)
                if (cboempresa.Items.Count > 0)
                    empresa = int.Parse(cboempresa.SelectedValue.ToString());
                else
                {
                    msg("No hay Empresas");
                    return;
                }
            if (radioButton2.Checked)
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
                    if (inicial > final)
                    {
                        inicial = comboMesAño2.GetFechaPRimerDia();
                        final = comboMesAño1.GetFecha();
                    }
                    DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
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
                        CReporteboleta.GenerarBoletasMensuales(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                        //Generar Asiento de Boletas Generadas
                        if (chkGAsientos.Checked)
                        {
                            DataTable Tablita = new DataTable();
                            //filtrar por lo que ya esta generado
                            Tablita = CReporteboleta.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                            if (Tablita.Rows.Count > 0)
                            {
                                DataRow Ultimo = CReporteboleta.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                                int ultimo = 1 + (int)Ultimo["ultimo"];
                                DataRow Filita = Tablita.Rows[0];
                                DataTable Ultimox = CReporteboleta.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                                Ultimo = Ultimox.Rows[0];
                                ultimo = ((int)Ultimo["codigo"]);
                                foreach (DataColumn col in Tablita.Columns)
                                {
                                    CReporteboleta.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, decimal.Parse(Filita[col.ColumnName].ToString() == "" ? "0" : Filita[col.ColumnName].ToString()));
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
                    DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
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
                msg("Generadas con Exito");
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
                DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
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
                    CReporteboleta.GenerarBoletasMensuales(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                    //Generar Asiento de Boletas Generadas
                    DataTable Tablita = new DataTable();
                    Tablita = CReporteboleta.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
                    if (Tablita.Rows.Count > 0)
                        if ((Tablita.Rows[0])[0].ToString().ToUpper() != "")
                        {
                            DataRow Ultimo = CReporteboleta.VerUltimoIdentificador("TBL_Asiento_Contable", "Id_Asiento_Contable");
                            int ultimo = 1 + (int)Ultimo["ultimo"];
                            DataRow Filita = Tablita.Rows[0];
                            DataTable Ultimox = CReporteboleta.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now);
                            Ultimo = Ultimox.Rows[0];
                            ultimo = ((int)Ultimo["codigo"]);
                            foreach (DataColumn col in Tablita.Columns)
                            {
                                CReporteboleta.InsertarAsientosdeBoletas((int)cboempresa.SelectedValue, col.ColumnName, ultimo, (decimal)Filita[col.ColumnName]);
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
                    //fin de Asientos DE boletas Generadas
                }
                DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
                if (DBoleta.Rows.Count == 0)
                {
                    msg($"No hay Boletas que Mostrar del :{inicial.ToLongDateString()} \nHasta: {final.ToLongDateString()}");
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
            if (radioButton1.Checked)
            {
                empresa = int.Parse(cboempresa.SelectedValue.ToString());
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                btnrectipo.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = true;
                btnrecempresa.Enabled = true;
            }
            else empresa = 0;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                numero = txtnumero.Text;
                cboempresa.Enabled = false;
                btnrecempresa.Enabled = false;
                cbotipoid.Enabled = true;
                txtnumero.Enabled = true;
                btnrectipo.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                tipo = 0; numero = "0";
            }
        }

        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbTodasEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodasEmpresa.Checked)
            {
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                btnrectipo.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = false;
                btnrecempresa.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }


    }
}
