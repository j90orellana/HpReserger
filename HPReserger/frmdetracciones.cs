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
        private void frmdetracciones_Load(object sender, EventArgs e)
        {
            CArgarDatosDetraccion();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar);
                Desactivar(btnaceptar, txtdescripcion);
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
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
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
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Detracción", Celditas, 2, new int[] { 2, 3, 5 }, new int[] { 1 }, new int[] { });
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
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
            if (y >= 0)
            {
                txtdescripcion.Text = dtgconten[descripcionx.Name, y].Value.ToString();
                txtporcentaje.Text = dtgconten[porcentajex.Name, y].Value.ToString();
                CodigoDet = (int)dtgconten[id_detraccionx.Name, y].Value;
                dtpfecha.Value = (DateTime)dtgconten[fechax.Name, y].Value;
            }
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CArgarDatosDetraccion();
            LimpiarProductoNuevo();
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar);
            Activar(btnaceptar, txtdescripcion);
            estado = 1;
            txtdescripcion.Focus();
        }
        private void LimpiarProductoNuevo()
        {
            txtdescripcion.Text = "";
            txtporcentaje.Text = "";

        }
        int CodigoDet;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CodigoDet = (int)dtgconten.CurrentRow.Cells[id_detraccionx.Name].Value;
            estado = 2;
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar);
            Activar(btnaceptar, txtdescripcion);
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
                CapaLogica.Detraciones(1, 0, txtdescripcion.Text, Convert.ToDecimal(txtporcentaje.Text), frmLogin.CodigoUsuario, dtpfecha.Value);
                CArgarDatosDetraccion();
                msg("Guardado Exitosamente");
                estado = 0;
            }
            //MODIFICAR
            if (estado == 2)
            {
                CapaLogica.Detraciones(2, CodigoDet, txtdescripcion.Text, Convert.ToDecimal(txtporcentaje.Text), frmLogin.CodigoUsuario, dtpfecha.Value);
                CArgarDatosDetraccion();
                msg("Guardado Exitosamente");
                estado = 0;
            }
            Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar);
            Desactivar(btnaceptar, txtdescripcion);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
                if (HPResergerFunciones.Utilitarios.msgp("Desea Eliminar Registro") == DialogResult.Yes)
                {
                    CapaLogica.Detraciones(5, CodigoDet, txtdescripcion.Text, 0, frmLogin.CodigoUsuario, DateTime.Now);
                    CArgarDatosDetraccion();
                }
        }
    }
}
