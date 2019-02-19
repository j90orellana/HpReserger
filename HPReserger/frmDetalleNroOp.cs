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
    public partial class frmDetalleNroOp : FormGradient
    {
        public frmDetalleNroOp()
        {
            InitializeComponent();
        }
        public string nrooperacion
        { get; set; }
        private int _codigo;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Codigo
        { get { return _codigo; } set { _codigo = value; } }
        private void frmDetalleNroOp_Load(object sender, EventArgs e)
        {
            txtnrobanco.Text = nrooperacion;
            txtnrobanco.Focus();
        }
        public frmDetalleNroOp(string ruc, string razon, string nrocomp, string banco)
        {
            InitializeComponent();
            Ruc = ruc;
            Razon = razon;
            NroComprobante = nrocomp;
            Banco = banco;
        }
        public string Banco
        {
            get { return txtbanco.TextValido(); }
            set { txtbanco.Text = value; }
        }
        public string NroComprobante
        {
            get { return txtnrocomp.TextValido(); }
            set { txtnrocomp.Text = value; }
        }
        public string Razon
        {
            get { return txtrazon.TextValido(); }
            set { txtrazon.Text = value; }
        }
        public string Ruc
        {
            get { return txtruc.TextValido(); }
            set { txtruc.Text = value; }
        }
        private int empresa;
        public int Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public int Tipodet { get; set; }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Tipodet == 1)
                CapaLogica.ActualizarNroOperacion(Codigo, txtnrobanco.TextValido(), Tipodet, empresa);
            if (Tipodet == 2)
                CapaLogica.ActualizarNroOperacion(Codigo, txtnrobanco.TextValido(), Tipodet, empresa);
            if (Tipodet == 3)
                CapaLogica.ActualizarNroOperacion(Codigo, txtnrobanco.TextValido(), Tipodet, empresa);
            if (Tipodet == 5)
                CapaLogica.ActualizarNroOperacion(Codigo, txtnrobanco.TextValido(), Tipodet, empresa);
            this.Close();
        }
        private void frmDetalleNroOp_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void FrmDetalleNroOp_MouseLeave1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void FrmDetalleNroOp_MouseHover(object sender, EventArgs e)
        {
        }
        private void FrmDetalleNroOp_MouseLeave(object sender, EventArgs e)
        {
        }
        private void frmDetalleNroOp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
        private void txtnrobanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
