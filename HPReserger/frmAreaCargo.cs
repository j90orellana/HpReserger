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
    public partial class frmAreaCargo : FormGradient
    {
        public frmAreaCargo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msgErrror(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado != 0)
            {
                Estado = 0;
                ModoEdicion(false);
                btnNuevo.Enabled = true;
                Cargado = true;
                FiltrarDatos();
            }
            else { this.Close(); }
        }
        public void ModoEdicion(Boolean v)
        {
            cboarea.Enabled = cbogerencia.Enabled = cboCargoPuesto.Enabled = v;
            btnlimpiar.Enabled = cbotipos.Enabled = !v;
            txtbusCargo.ReadOnly = v;
            //
            dtgconten.Enabled = !v;
            btnAceptar.Enabled = v;
        }
        private void frmAreaCargo_Load(object sender, EventArgs e)
        {
            Estado = 0;
            btnNuevo.Enabled = true;
            btnmodificar.Enabled = false;
            CargarValoresxDefecto();
            CargarGerencia(cbogerencia);
            CargarArea();
            CargarCargos(cboCargoPuesto);
            //dtgconten.DataSource = CapaLogica.CargosAreas(0, 0, 0, " ");
            //CargarCombosOrdenados(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
            //CargarCombos(cboarea, "Id_Area", "Area", "TBL_Area");
            //CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
            //Activar(cboarea, btnmodificar, btnr);            
            ///
            Cargado = true;
            FiltrarDatos();
            ModoEdicion(false);
        }

        private void CargarCargos(ComboBox cbo)
        {
            DataTable TablaAux = CapaLogica.getCargoTipoContratacion2("Id_Cargo", "Cargo", "TBL_Cargo");
            string cadena = cbo.Text;
            if (TablaAux.Rows.Count != cbo.Items.Count)
            {
                cbo.ValueMember = "codigo";
                cbo.DisplayMember = "descripcion";
                cbo.DataSource = TablaAux;
                if (cbo.DataSource != null) cbo.Text = cadena;
            }
        }
        private void CargarArea()
        {
            DataTable TablaAuxiliar = CapaLogica.AreaGerencia((int)cbogerencia.SelectedValue);
            string cadena = cboarea.Text;
            if (cboarea.Items.Count != TablaAuxiliar.Rows.Count)
            {
                cboarea.DisplayMember = "area";
                cboarea.ValueMember = "codigoarea";
                cboarea.DataSource = TablaAuxiliar;
                if (cboarea.DataSource != null) cboarea.Text = cadena;
            }
        }
        private void CargarGerencia(ComboBox cbo)
        {
            DataTable TablaAux = CapaLogica.getCargoTipoContratacion2("Id_Gerencia", "Gerencia", "TBL_Gerencia");
            string cadena = cbo.Text;
            if (TablaAux.Rows.Count != cbo.Items.Count)
            {
                cbo.ValueMember = "codigo";
                cbo.DisplayMember = "descripcion";
                cbo.DataSource = TablaAux;
                if (cbo.DataSource != null) cbo.Text = cadena;
            }
        }
        //private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        //{
        //    cbo.ValueMember = "codigo";
        //    cbo.DisplayMember = "descripcion";
        //    cbo.DataSource = CapaLogica.getCargoTipoContratacion(codigo, descripcion, tabla);
        //}
        //private void CargarCombosOrdenados(ComboBox cbo, string codigo, string descripcion, string tabla)
        //{
        //    cbo.ValueMember = "codigo";
        //    cbo.DisplayMember = "descripcion";
        //    cbo.DataSource = CapaLogica.getCargoTipoContratacion2(codigo, descripcion, tabla);
        //}
        int Estado = 0;
        private bool Cargado;
        private int IdAreaOld;
        private int IdCargoOld;

        public void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
            btnNuevo.Enabled = btnmodificar.Enabled = false;



            //if (cboarea.SelectedIndex >= 0 && cboCargoPuesto.SelectedIndex >= 0)
            //{
            //    CapaLogica.CargosAreas(1, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, "");
            //    dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, "");
            //}
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
            btnNuevo.Enabled = btnmodificar.Enabled = false;
            IdAreaOld = (int)cboarea.SelectedValue;
            IdCargoOld = (int)cboCargoPuesto.SelectedValue;
            //if (cboarea.SelectedIndex >= 0)
            //{
            //    Estado = 1;
            //    //Desactivar(btnmodificar, cboarea, cbogerencia, btnr, txtbuscar, cbotipos);
            //    Activar(cboCargoPuesto, btnNuevo);
            //    dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, "");
            //}
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (msgp("Desea ELiminar ??") == DialogResult.Yes)
                {
                    int x = dtgconten.CurrentCell.RowIndex;
                    CapaLogica.CargosAreas(99, (int)dtgconten["fk_id_cargo", x].Value, (int)dtgconten["fk_id_area", x].Value, "");
                    if (Estado == 1)
                        dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, "");
                    else
                        dtgconten.DataSource = CapaLogica.CargosAreas(0, 0, 0, "");
                }
            }
        }
        private void cboarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboarea.SelectedIndex >= 0)
            //{
            //    Activar(btnmodificar, cboarea);
            //}
            //else
            //{
            //    Desactivar(btnmodificar, cboarea);
            //}
        }
        private void cbogerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogerencia.SelectedIndex >= 0)
            {
                DataTable TablaAuxiliar = CapaLogica.AreaGerencia((int)cbogerencia.SelectedValue);
                cboarea.DisplayMember = "area";
                cboarea.ValueMember = "codigoarea";
                cboarea.DataSource = TablaAuxiliar;
            }
            else { cboarea.Enabled = false; }
        }
        //private void btnr_Click(object sender, EventArgs e)
        //{
        //    if (((Control)sender).Tag.ToString() == "1")
        //    {
        //        CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
        //    }
        //    if (((Control)sender).Tag.ToString() == "2")
        //    {
        //        CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
        //    }
        //}
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            btnmodificar.Enabled = false;
            if (fila >= 0)
            {
                cbogerencia.SelectedValue = dtgconten[pk_id_gerencia.Name, fila].Value;
                cboarea.SelectedValue = dtgconten[fk_id_Area.Name, fila].Value;
                cboCargoPuesto.SelectedValue = dtgconten[fk_id_cargo.Name, fila].Value;
                btnmodificar.Enabled = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //txtbuscar.Text = "";
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //50 filtrar
            //dtgconten.DataSource = CapaLogica.CargosAreas(50, cbotipos.SelectedIndex, 0, txtbuscar.EstaLLeno() ? txtbuscar.Text : "");
        }

        private void btnbusCargo_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void FiltrarDatos()
        {
            if (Cargado)
            {
                //50 filtrar
                dtgconten.DataSource = CapaLogica.CargosAreas(50, cbotipos.SelectedIndex, 0, txtbusCargo.TextValido());
                lblRegistros.Text = $"Total de Registros: {dtgconten.RowCount}";
            }
        }
        private void cbotipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            Cargado = false;
            CargarValoresxDefecto();
            Cargado = true;
            FiltrarDatos();
        }
        private void CargarValoresxDefecto()
        {
            txtbusCargo.CargarTextoporDefecto();
            cbotipos.SelectedIndex = 0;
        }
        private void cbogerencia_Click(object sender, EventArgs e)
        {
            CargarGerencia(cbogerencia);
        }
        private void cboarea_Click(object sender, EventArgs e)
        {
            CargarArea();
        }
        private void cboCargoPuesto_Click(object sender, EventArgs e)
        {
            CargarCargos(cboCargoPuesto);
        }

        private void cboCargoPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cbogerencia.SelectedValue == null) { msgErrror("Seleccione Gerencia"); return; }
            if (cbogerencia.SelectedValue == null) { msgErrror("Seleccione Gerencia"); return; }
            if (cboCargoPuesto.SelectedValue == null) { msgErrror("Seleccione Cargo"); return; }
            //
            if (Estado == 1)//insertamos
            {
                CapaLogica.CargosAreas(1, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, "");
                msgOK("Agregado con Exito");
            }
            else if (Estado == 2)//Modificar
            {
                CapaLogica.CargosAreas(2, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue, $"{IdAreaOld}-{IdCargoOld}");
                msgOK("Actualizado con Exito");
            }
            Estado = 0;
            ModoEdicion(false);
            btnNuevo.Enabled = true;
            Cargado = true;
            FiltrarDatos();
        }
    }
}
