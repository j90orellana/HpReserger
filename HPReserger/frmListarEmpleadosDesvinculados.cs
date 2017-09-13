﻿using System;
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
    public partial class frmListarEmpleadosDesvinculados : Form
    {
        public frmListarEmpleadosDesvinculados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmListarEmpleadosDesvinculados_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.ListarEmpleadosDesvinculados();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (dtgconten.RowCount > 0 && fila >= 0)
            {
                txttipoid.Text = dtgconten["tipo", fila].Value.ToString();
                txtnombre.Text = dtgconten["nombres", fila].Value.ToString();
                txtapellido.Text = dtgconten["apellidos", fila].Value.ToString();
                txtnroid.Text = dtgconten["nroid", fila].Value.ToString();

                DataRow Contratoactivo = CapaLogica.ContratoActivo(Convert.ToInt32(dtgconten["tipoid", fila].Value.ToString()), dtgconten["nroid", fila].Value.ToString(), DateTime.Now);
                if (Contratoactivo != null)
                {
                    txtestado.Text = "EMPLEADO ACTIVO CONTRATO Nº" + Contratoactivo["Nro_Contrato"].ToString();
                }
                else
                {
                    txtestado.Text = "EMPLEADO INACTIVO";
                }
            }
        }
    }
}
