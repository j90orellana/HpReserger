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
    public partial class frmMemoPremioObservaciones : FormGradient
    {
        public string Observaciones { get { return txtObservaciones.Text; } set { txtObservaciones.Text = value; } }

        public frmMemoPremioObservaciones()
        {
            InitializeComponent();
        }

        private void frmMemoPremioObservaciones_Load(object sender, EventArgs e)
        {
            txtObservaciones.Text = Observaciones;
        }
        public void MostrarDatos()
        {
            txtObservaciones.Enabled = true;
            MinimumSize = new Size(0, 0);
        }
    }
}
