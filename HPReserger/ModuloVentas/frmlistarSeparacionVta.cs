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
    public partial class frmlistarSeparacionVta : FormGradient
    {
        public frmlistarSeparacionVta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmlistarSeparacionVta_Load(object sender, EventArgs e)
        {
            if (Estado == 2 || Estado == 200) dtgconten.Columns[dias.Name].Visible = false;
            else dtgconten.Columns[dias.Name].Visible = true;
            CargarDatos();
        }
        public int NumCot { get; set; }
        public int Estado { get; set; }
        public void CargarDatos()
        {
            if (Estado == 200)
                dtgconten.DataSource = CapaLogica.SeparacionVenta(200, int.Parse(txtnumcot.Text == "" ? "0" : txtnumcot.Text), 0, 0, 0, null, txtBuscar.TextoValido(), DateTime.Now, Estado);
            else
                dtgconten.DataSource = CapaLogica.SeparacionVenta(20, int.Parse(txtnumcot.Text == "" ? "0" : txtnumcot.Text), 0, 0, 0, null, txtBuscar.TextoValido(), DateTime.Now, Estado);
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                NumCot = (int)item.Cells[numcot.Name].Value;
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            NumCot = 0; this.Close();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
                this.Close();
        }

        private void txtBuscar_BuscarTextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
