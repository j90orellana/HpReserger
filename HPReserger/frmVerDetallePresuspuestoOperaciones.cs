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
    public partial class frmVerDetallePresuspuestoOperaciones : FormGradient
    {
        public frmVerDetallePresuspuestoOperaciones()
        {
            InitializeComponent();
        }
        public int etapa;
        public string cuenta;
        public DateTime fecha;
        public int Tipo;
        HPResergerCapaLogica.HPResergerCL Ccampos = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmVerDetallePresuspuestoOperaciones_Load(object sender, EventArgs e)
        {
            //Msg($"etapa { etapa} cuenta { cuenta} fecha { fecha}");
            if(Tipo==1)
            dtgconten.DataSource = Ccampos.ListarDetalleDelReporteDeCentrodeCostoFechaFacturas(etapa, cuenta, fecha);
            else
                dtgconten.DataSource = Ccampos.ListarDetalleDelReporteDeCentrodeCostoFechaFlujoFacturas(etapa, cuenta, fecha);
            if (dtgconten.RowCount > 0)
                btnexportarExcel.Enabled = true;
            else
                btnexportarExcel.Enabled = false;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Asientos";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Asientos", Celditas, 1, new int[] { }, new int[] { 1 }, new int[] { });
                msgOK("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }
    }
}
