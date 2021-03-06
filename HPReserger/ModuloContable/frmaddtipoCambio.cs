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
    public partial class frmaddtipoCambio : FormGradient
    {
        public frmaddtipoCambio()
        {
            InitializeComponent();
        }
        public DateTime fechatipo { get; set; }
        public bool TipoCambioSBS { get; internal set; }

        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmaddtipoCambio_Load(object sender, EventArgs e)
        {
            comboMesAño1.ActualizarMesAÑo(fechatipo.Month.ToString(), fechatipo.Year.ToString());
            if (TipoCambioSBS)
            {
                txtdia.Enabled = false;
                txtdia.Text = Configuraciones.FinDelMes(fechatipo).Day.ToString();
            }
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string cadena = ""; lblmsg.ForeColor = Color.Red;
            DateTime fechas = new DateTime();
            try
            {
                DateTime fechita = new DateTime(comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, int.Parse(txtdia.Text));
                fechas = fechita;
            }
            catch (ArgumentOutOfRangeException)
            {
                cadena += "Día Incorreto  ";
                txtdia.Text = "0";
            }
            if (decimal.Parse(txtcompra.Text) <= 0) cadena += "Valor de Compra Incorrecto  ";
            if (decimal.Parse(txtventa.Text) <= 0) cadena += "Valor de Venta Incorrecto  ";

            lblmsg.Text = cadena;

            if (cadena == "")
            {
                //15=si existe lo reemplaza
                if (TipoCambioSBS)
                {
                    CapaLogica.TipodeCambio(150, fechas.Year, fechas.Month, fechas.Day, decimal.Parse(txtcompra.Text), decimal.Parse(txtventa.Text), null);
                    lblmsg.ForeColor = Color.Black;
                    lblmsg.Text = "Agregado con Éxito";
                    txtdia.Focus();
                }
                else
                {
                    CapaLogica.TipodeCambio(15, fechas.Year, fechas.Month, fechas.Day, decimal.Parse(txtcompra.Text), decimal.Parse(txtventa.Text), null);
                    lblmsg.ForeColor = Color.Black;
                    lblmsg.Text = "Agregado con Éxito";
                    //txtcompra.Text = "0.00";
                    //txtventa.Text = "0.00";
                    txtdia.Text = "0";
                    txtdia.Focus();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboMesAño1_CambioFechas(object sender, EventArgs e)
        {
            if (TipoCambioSBS)
            {
                txtdia.Enabled = false;
                txtdia.Text = Configuraciones.FinDelMes(comboMesAño1.FechaInicioMes).Day.ToString();
            }
        }
    }
}
