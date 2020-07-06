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
    public partial class frmTipoFaltas : FormGradient
    {
        public frmTipoFaltas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int Estado;
        private bool Cargado;
        private int pkid;

        private void frmTipoFaltas_Load(object sender, EventArgs e)
        {
            ValoresDefecto();
            LimpiarBusquedas();
            ModoEdicion(false);
            Estado = 0;
            //
            Cargado = true;
            CargarDatos();
        }
        public void ValoresDefecto()
        {
            txtTipoFalta.CargarTextoporDefecto();
            txtobservacion.CargarTextoporDefecto();
            txtdiamax.CargarTextoporDefecto();
            txtdiamin.CargarTextoporDefecto();
            //
            dtpFecha.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //
            chkDescuento.Checked = false;
        }
        public void LimpiarBusquedas()
        {
            Cargado = false;
            txtbusTipoFalta.CargarTextoporDefecto(); txtbusObservacion.CargarTextoporDefecto();
            Cargado = true;
            CargarDatos();
        }
        public void ModoEdicion(Boolean a)
        {
            //Desactivamos con false
            txtbusObservacion.ReadOnly = txtbusTipoFalta.ReadOnly = btnAceptar.Enabled = a;
            //Activamos con True
            btnactualizar.Enabled = btnlimpiar.Enabled = btnnuevo.Enabled = dtgconten.Enabled = !a;
            btnAceptar.Enabled = a;
            //
            txtTipoFalta.ReadOnly = txtobservacion.ReadOnly = txtdiamin.ReadOnly = txtdiamax.ReadOnly = !a;
            chkDescuento.Enabled = a; dtpFecha.Enabled = a;
        }
        public void CargarDatos()
        {
            if (Cargado)
            {
                if (Configuraciones.ValidarSQLInyect(txtbusTipoFalta, txtbusObservacion)) { msgError("Codigo Malicioso Detectado"); return; }
                btnmodificar.Enabled = false;
                dtgconten.DataSource = CapaLogica.TiposFaltas(0, DateTime.Now, txtbusTipoFalta.TextValido(), txtbusObservacion.TextValido(), 0, 0, true, 0);
                lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
                if (dtgconten.RowCount != 0)
                    btnmodificar.Enabled = true;
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else
            {
                Estado = 0;
                ModoEdicion(false);
                CargarDatos();
            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int x = e.RowIndex;
                DataGridViewRow Fila = dtgconten.Rows[x];
                txtobservacion.Text = Fila.Cells[xobservacion.Name].Value.ToString();
                txtTipoFalta.Text = Fila.Cells[xNombre.Name].Value.ToString();
                txtdiamin.Text = ((int)Fila.Cells[xdiasminimos.Name].Value).ToString();
                txtdiamax.Text = ((int)Fila.Cells[xdiasmaximos.Name].Value).ToString();
                dtpFecha.Value = (DateTime)Fila.Cells[xFecha.Name].Value;
                chkDescuento.Checked = (Boolean)Fila.Cells[xdescuento.Name].Value;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
            btnmodificar.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
            btnmodificar.Enabled = false;
            dtpFecha.Enabled = false;
            pkid = (int)dtgconten[xpkid.Name, dtgconten.CurrentCell.RowIndex].Value;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
        }
        public void msgOk(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        public void msgError(string cadena) { HPResergerFunciones.Utilitarios.msgCancel(cadena); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Configuraciones.ValidarSQLInyect(txtobservacion, txtTipoFalta)) { msgError("Codigo Malicioso Detectado"); return; }
            //declaracion variables
            string NFalta = txtTipoFalta.TextValido().Trim();
            string Observacion = txtobservacion.TextValido().Trim();
            int min = txtdiamin.EnteroValido();
            int max = txtdiamax.EnteroValido();
            //
            //int aux = 0;
            //if (min > max)
            //{
            //    aux = min; min = max; max = aux;
            //}
            //
            DateTime Fecha = dtpFecha.Value;
            Boolean Descuento = chkDescuento.Checked;
            //Validaciones
            if (!txtTipoFalta.EstaLLeno()) { msgError("Ingrese Tipo de Falta"); txtTipoFalta.Focus(); return; }
            //if (min + max == 0) { msgError("Debe Ingresar un valor de Dias Maximos"); return; }

            //insertar valor
            if (Estado == 1)
            {
                CapaLogica.TiposFaltas(1, Fecha, NFalta, Observacion, min, max, Descuento, 0);
                msgOk("Se Agregó Registro");
            }
            //actualizamos el valor
            else if (Estado == 2)
            {
                CapaLogica.TiposFaltas(2, Fecha, NFalta, Observacion, min, max, Descuento, pkid);
                msgOk("Se Actualizo Registro");
            }
            ModoEdicion(false);
            Estado = 0; Cargado = true;
            CargarDatos();
        }

        private void txtbusTipoFalta_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtbusObservacion_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
