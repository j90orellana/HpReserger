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

namespace HPReserger.ModuloRRHH
{
    public partial class frmRegistroFacturasCreditoEPS : FormGradient
    {
        public frmRegistroFacturasCreditoEPS()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private decimal _Sumatoria;
        public decimal Sumatoria
        {
            get { return _Sumatoria; }
            set
            {
                _Sumatoria = value;
                txttotal.Text = _Sumatoria.ToString("n2");
            }
        }
        public int Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                //
                cboperiodo.Enabled = false;
                if (cboFacturas.Items.Count > 0)
                    cboFacturas.ReadOnly = false;
                else cboFacturas.ReadOnly = true;
                cboEmpresa.ReadOnly = true;
                //dtgconten.ReadOnly = true;
                btnNuevo.Enabled = true; btnProcesar.Enabled = btnModificar.Enabled = false;
                dtgconten.Enabled = true;
                btnBusFac.Enabled = false;

                txtCanEmpleados.Enabled = false;
                MostrarLabelyTextboxSueldos(true);

                if (estado == 1) //Nuevo
                {
                    btnModificar.Enabled = btnNuevo.Enabled = false;
                    btnBusFac.Enabled = btnProcesar.Enabled = true;
                    dtgconten.Enabled = false;
                    //
                    cboperiodo.Enabled = true;
                    cboFacturas.ReadOnly = cboEmpresa.ReadOnly = false;

                    txtCanEmpleados.Enabled = true;
                    MostrarLabelyTextboxSueldos(false);
                }
                else if (estado == 2) // Modificar
                {
                    btnModificar.Enabled = btnNuevo.Enabled = false;
                    btnBusFac.Enabled = btnProcesar.Enabled = true;
                    dtgconten.Enabled = false;
                    //
                    cboperiodo.Enabled = true;
                    cboFacturas.ReadOnly = false;// cboEmpresa.ReadOnly = false;

                    txtCanEmpleados.Enabled = true;
                }
                if (estado == 0 && FormularioCargado)
                {
                    CargarDatos();
                }
            }
        }

        public int pkid { get; private set; }

        private int estado;
        Boolean FormularioCargado = false;
        private void frmRegistroFacturasCreditoEPS_Load(object sender, EventArgs e)
        {
            Estado = 0;
            CargarEmpresa();
            FormularioCargado = true;
            CargarDatos();
        }
        DataTable Tdatos;
        private void CargarDatos()
        {
            Tdatos = CapaLogica.Facturas_EPS_Listar();
            btnModificar.Enabled = false;
            if (Tdatos.Rows.Count > 0)
            {
                dtgconten.DataSource = Tdatos;
                btnModificar.Enabled = true;
            }
            else if (dtgconten.DataSource != null)
                dtgconten.DataSource = Tdatos.Clone();
            lbltotalRegistros.Text = $"Total Registros: { dtgconten.RowCount}";
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public void CargarEmpresa()
        {
            cboEmpresa.ValueMember = "codigo";
            cboEmpresa.DisplayMember = "descripcion";
            cboEmpresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidamosEmpresa()) { msgError("No hay Empresas"); return; }
            Estado = 1;
            ListadoFacturas = "";
            BuscarDatosdelPeriodo();
            BuscarCantidadEmpleados();
        }
        private void MostrarLabelyTextboxSueldos(bool v)
        {
            lblMontoCredito.Visible = lblTsueldos.Visible = txtSueldos.Visible = txtMontoCredito.Visible = v;
        }
        private Boolean ValidamosEmpresa()
        {
            if (cboEmpresa.Items.Count > 0) return true;
            else return false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            BuscarCantidadEmpleados();
            cboEmpresa.Enabled = false;
            pkid = (int)dtgconten.CurrentRow.Cells[xpkid.Name].Value;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0) this.Close();
            Estado = 0;
        }
        string ListadoFacturas;
        private void btnBusFac_Click(object sender, EventArgs e)
        {
            ModuloFacturacion.frmListarFacturas frmListaFacturas = new ModuloFacturacion.frmListarFacturas(true, true, true, ListadoFacturas, Sumatoria);
            frmListaFacturas.ValEmpresa = cboEmpresa.Text;

            if (frmListaFacturas.ShowDialog() == DialogResult.OK)
            {
                ListadoFacturas = string.Join(",", frmListaFacturas.CadenaFacturasProtegidas);
                Sumatoria = frmListaFacturas.Sumatoria;
                BuscarFacturasdelaCadena();
            }
        }
        private DateTime Fecha;
        private int pkEmpresa;
        string cadena;
        private void cboperiodo_CambioFechas(object sender, EventArgs e)
        {
            BuscarDatosdelPeriodo();
        }
        Boolean ErrorPeriodo = false;
        private void BuscarDatosdelPeriodo()
        {
            if (estado == 1 || estado == 2)
            {
                Fecha = cboperiodo.FechaInicioMes;
                pkEmpresa = (int)cboEmpresa.SelectedValue;
                ErrorPeriodo = false;
                try
                {
                    cadena = "No hay datos de UIT en este Periodo, Revise -> Menu; Mantenimiento; Generales; ParametrosGenerales; UIT";
                    txtUIT.Text = CapaLogica.ConsultarParametros(Fecha, "uit")["valor"].ToString();
                    cadena = "No hay datos de APORTE ESSALUD_EPS en este Periodo, Revise -> Menu; Mantenimiento; Generales; ParametrosGenerales; APORTE ESSALUD_EPS";
                    txtAporte.Text = CapaLogica.ConsultarParametros(Fecha, "APORTE ESSALUD_EPS")["valor"].ToString();
                    cadena = "No hay datos de RMA en este Periodo, Revise -> Menu;Mantenimiento; Instituciones; AFP Comisiones y Primas";
                    txtTopeLegal.Text = CapaLogica.AfpDetalle_BusquedaFecha(Fecha)["rma"].ToString();
                }
                catch (Exception) { ErrorPeriodo = true; msgError(cadena); }
            }
        }
        DataTable TFacturas;
        private void BuscarFacturasdelaCadena()
        {
            TFacturas = CapaLogica.BusquedaFacturasdeCadena(ListadoFacturas);
            cboFacturas.DisplayMember = "NumFac";
            cboFacturas.ValueMember = "numfac";
            cboFacturas.DataSource = TFacturas;
        }
        private void BuscarCantidadEmpleados()
        {
            if (estado == 1 || estado == 2)
                if (cboEmpresa.Items.Count > 0)
                {
                    pkEmpresa = (int)cboEmpresa.SelectedValue;
                    Fecha = cboperiodo.FechaInicioMes;
                    int val = CapaLogica.ConsultarEmpleadosActivos(pkEmpresa, Fecha).Rows.Count;
                    txtCanEmpleados.Value = val == 0 ? 1 : val;
                }
        }
        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCantidadEmpleados();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Mostramos los datos de la grilla seleccionada
                DataGridViewRow item = dtgconten.Rows[e.RowIndex];
                cboEmpresa.SelectedValue = (int)item.Cells[fkEmpresa.Name].Value;
                cboperiodo.Fecha((DateTime)item.Cells[xPeriodo.Name].Value);

                txtAporte.Text = item.Cells[xAporteEssalud.Name].Value.ToString();
                txtCanEmpleados.Value = (int)item.Cells[xCantTrabajadores.Name].Value;
                txtMontoCredito.Text = item.Cells[xMontoCredito.Name].Value.ToString();
                txtSueldos.Text = item.Cells[xSueldos.Name].Value.ToString();
                txtTopeLegal.Text = item.Cells[xTopeLegal.Name].Value.ToString();
                txttotal.Text = item.Cells[xTotalFacturas.Name].Value.ToString();
                txtUIT.Text = item.Cells[xUIT.Name].Value.ToString();
                ListadoFacturas = item.Cells[xListaFacturas.Name].Value.ToString();
                BuscarFacturasdelaCadena();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Declaraciones
            decimal UIT = txtUIT.DecimalValido();
            decimal Tope = txtTopeLegal.DecimalValido();
            decimal Aporte = txtAporte.DecimalValido();
            int CantEmpleados = Convert.ToInt32(txtCanEmpleados.Value);
            decimal MontoCredito = txtMontoCredito.DecimalValido();
            decimal Sueldos = txtSueldos.DecimalValido();
            decimal Total = txttotal.DecimalValido();
            //
            DateTime HOY = DateTime.Now;
            int idUsuario = frmLogin.CodigoUsuario;
            //Validaciones
            if (ErrorPeriodo) { msgError("Hay un Error En el Periodo"); return; }
            if (Total == 0) { msgError("Total de Facturas en Cero"); return; }
            if (UIT == 0) { msgError("Valor de UIT no puede ser cero"); return; }
            if (Tope == 0) { msgError("El Tope legal no puede ser cero"); return; }
            if (Aporte == 0) { msgError("Aporte no puede ser cero"); return; }
            //
            //Sueldos; MontoCredito // Esos se actualizan al generar el asiento
            if (msgp("Seguro Desea Grabar") == DialogResult.Yes)
            {
                if (estado == 1)//insertamos
                {
                    try
                    {
                        CapaLogica.Facturas_EPS_Listar(1, 0, pkEmpresa, Fecha, CantEmpleados, Total, UIT, Tope, ListadoFacturas, Aporte, Sueldos, MontoCredito, 1, HOY, idUsuario);
                        msgOK("Grabado con Exito");
                    }
                    catch (Exception) { msgError("Hubo un Error al Grabar los datos en la Base de Datos"); return; }
                }
                else if (estado == 2) // Actualizamos
                {
                    try
                    {
                        CapaLogica.Facturas_EPS_Listar(2, pkid, pkEmpresa, Fecha, CantEmpleados, Total, UIT, Tope, ListadoFacturas, Aporte, Sueldos, MontoCredito, 1, HOY, idUsuario);
                        msgOK("Actualizado con Exito");
                    }
                    catch (Exception) { msgError("Hubo un Error al Actualizar los datos en la Base de Datos"); return; }
                }
                //Cuando Todo Ocurrio de forma correcta;
                Estado = 0;
            }
            else { msgError("Cancelado por le Usuario"); }
        }
    }
}
