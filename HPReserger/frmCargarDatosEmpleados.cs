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
    public partial class frmCargarDatosEmpleados : FormGradient
    {
        public frmCargarDatosEmpleados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmCargarDatosEmpleados_Load(object sender, EventArgs e)
        {           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime fecha = new DateTime(2017, 12, 31);
            //dtgconten.DataSource = CapaLogica.BalanceGeneral(fecha, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //dtgconten.DataSource = null;
        }
    }
}
