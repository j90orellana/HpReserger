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
    public partial class frmdetracciones : FormGradient
    {
        public frmdetracciones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmdetracciones_Load(object sender, EventArgs e)
        {
            LimpiarBusquedas();
            CArgarDatosDetraccion();
        }
        private Boolean _prueba;
        public Boolean BuscarValor
        {
            get { return _prueba; }
            set { _prueba = value; }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, txtbusid, txtbusanexo, txtbusdesc, btnlimpiar);
                Desactivar(btnaceptar, txtdescripcion, txtporcentaje, txtAnexo, txtsunat, dtpfecha);
            }
            else
                this.Close();
            CArgarDatosDetraccion();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CArgarDatosDetraccion();
        }
        public void CArgarDatosDetraccion()
        {
            dtgconten.DataSource = CapaLogica.Detraciones(0);
            lblmsg2.Text = $"Total de Registros : {dtgconten.RowCount}";
            btnmodificar.Enabled = false;
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
            }
        }
        frmProcesando frmproce;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
            CArgarDatosDetraccion();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Tabla de Detracciones";
                Celditas.Add(Celdita);
                //HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Empresas", Celditas, 1, new int[] {  }, new int[] { 1 }, new int[] { });
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Periodos", Celditas, 2, new int[] { }, new int[] { 1 }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Detracción", Celditas, 2, new int[] { 2, 3, 4, 5 }, new int[] { 1 }, new int[] { });
            }
            else
            {
                msg("No hay Datos");
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                    ((TextBoxPer)x).ReadOnly = false;
                else ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                    ((TextBoxPer)x).ReadOnly = true;
                else ((Control)x).Enabled = false;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            ValidarMOstrarOcultar();
            if (y >= 0)
            {
                txtdescripcion.Text = dtgconten[descripcionx.Name, y].Value.ToString();
                txtporcentaje.Text = dtgconten[porcentajex.Name, y].Value.ToString();
                txtAnexo.Text = dtgconten[xAnexo.Name, y].Value.ToString();
                txtsunat.Text = dtgconten[xCod_Detraccion.Name, y].Value.ToString();
                CodigoDet = (int)dtgconten[id_detraccionx.Name, y].Value;
                dtpfecha.Value = (DateTime)dtgconten[fechax.Name, y].Value;
            }
        }
        public void ValidarMOstrarOcultar()
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = btneliminar.Enabled = true;
            }
            else
            {
                txtdescripcion.Text = txtporcentaje.Text = "";
                btnmodificar.Enabled = btneliminar.Enabled = false;
            }
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CArgarDatosDetraccion();
            LimpiarProductoNuevo();
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, txtbusid, txtbusanexo, txtbusdesc, btnlimpiar);
            Activar(btnaceptar, txtdescripcion, txtporcentaje, txtAnexo, txtsunat, dtpfecha);
            estado = 1;
            txtdescripcion.Focus();
        }
        private void LimpiarProductoNuevo()
        {
            txtdescripcion.CargarTextoporDefecto();
            txtporcentaje.CargarTextoporDefecto();
            txtsunat.CargarTextoporDefecto();
            txtAnexo.CargarTextoporDefecto();
        }
        int CodigoDet;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CodigoDet = (int)dtgconten.CurrentRow.Cells[id_detraccionx.Name].Value;
            estado = 2;
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, txtbusid, txtbusanexo, txtbusdesc, btnlimpiar);
            Activar(btnaceptar, txtdescripcion, txtporcentaje, txtAnexo, txtsunat, dtpfecha);
            txtdescripcion.Focus();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //ESTADO 1= NUEVO 2=MODIFICAR
            if (!txtdescripcion.EstaLLeno())
            {
                txtdescripcion.Focus();
                msg("Ingrese la Descripción");
                return;
            }
            if (!txtporcentaje.EstaLLeno())
            {
                txtporcentaje.Focus();
                msg("Ingrese el Porcentaje");
                return;
            }
            //NUEVO           
            if (estado == 1)
            {
                CapaLogica.Detraciones(1, 0, txtsunat.Text, txtAnexo.TextValido(), txtdescripcion.Text, Convert.ToDecimal(txtporcentaje.Text), frmLogin.CodigoUsuario, dtpfecha.Value);
                msgOK("Guardado Exitosamente");
                estado = 0;
            }
            //MODIFICAR
            if (estado == 2)
            {
                CapaLogica.Detraciones(2, CodigoDet, txtsunat.Text, txtAnexo.TextValido(), txtdescripcion.Text, Convert.ToDecimal(txtporcentaje.Text), frmLogin.CodigoUsuario, dtpfecha.Value);
                msgOK("Guardado Exitosamente");
                estado = 0;
            }
            if (BuscarValor)
            {
                detraccion = txtdescripcion.Text;
                BuscarValor = false;
                this.Close();
            }
            CArgarDatosDetraccion();
            Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, txtbusid, txtbusanexo, txtbusdesc, btnlimpiar);
            Desactivar(btnaceptar, txtdescripcion, txtporcentaje, txtAnexo, txtsunat, dtpfecha);

        }
        public string detraccion = "No";
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
                if (msgp("Desea Eliminar Registro") == DialogResult.Yes)
                {
                    CapaLogica.Detraciones(5, CodigoDet, txtsunat.Text, txtAnexo.TextValido(), txtdescripcion.Text, 0, frmLogin.CodigoUsuario, DateTime.Now);
                    CArgarDatosDetraccion();
                }
        }
        private void txtBuscar1_ClickBotonBuscar(object sender, EventArgs e)
        {
            //if (txtBuscar1.EstaLLeno())
            //{
            //    CArgarDatosDetraccion();
            //    DataTable datos = (DataTable)dtgconten.DataSource;
            //    string columna = txtBuscar1.EstaLLeno() ? txtBuscar1.Text : "";
            //    string filtro = $"Desc_Detraccion like '%{columna}%'";
            //    DataRow[] dato = datos.Select(filtro);
            //    if (dato.Count() > 0)
            //        dtgconten.DataSource = dato.CopyToDataTable();
            //    else dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
            //}
            //else CArgarDatosDetraccion();
        }
        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ValidarMOstrarOcultar();
        }
        private void dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ValidarMOstrarOcultar();
        }

        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (BuscarValor)
                {
                    detraccion = txtdescripcion.Text;
                    BuscarValor = false;
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarBusquedas();
        }
        public void LimpiarBusquedas()
        {
            txtbusid.CargarTextoporDefecto();
            txtbusanexo.CargarTextoporDefecto();
            txtbusdesc.CargarTextoporDefecto();
        }
        private void txtbusdesc_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.DetraccionesFiltrar(txtbusid.TextValido(), txtbusanexo.TextValido(), txtbusdesc.TextValido());
            lblmsg2.Text = $"Total de Registros : {dtgconten.RowCount}";
            btnmodificar.Enabled = false;
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
            }

        }
    }
}
