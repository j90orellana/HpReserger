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
    public partial class frmLocacionServicio : FormGradient
    {
        public frmLocacionServicio()
        {
            InitializeComponent();
        }
        public string ocupacion;
        public string detalle;
        public string tipo;
        public string contrato;
        public string numerodoc;
        public int estado;
        public Boolean busca;
        public Boolean acepta;
        HPResergerCapaLogica.HPResergerCL locacion = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmLocacionServicio_Load(object sender, EventArgs e)
        {
            DataRow CLocacionServicio = locacion.LocacionServicios(contrato, tipo, numerodoc, 0, ocupacion, detalle);
            if (CLocacionServicio != null)
            {
                txtocupacion.Text = CLocacionServicio["Ocupacion_Principal"].ToString();
                txtdetalle.Text = CLocacionServicio["Detalle_Servicio"].ToString();
                busca = true;
            }
            else
            {
                txtdetalle.Text = "";
                txtocupacion.Text = "";
                busca = false;
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtdetalle.Text))
            {
                if (msgp("Hay Datos en detalle, Desea Salir") != DialogResult.Yes)
                    return;
            }
            if (!string.IsNullOrWhiteSpace(txtocupacion.Text))
            {
                if (msgp("Hay Datos en la Ocupacion, Desea Salir") != DialogResult.Yes)
                    return;
            }
            acepta = false;
            this.Close();
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdetalle.Text))
            {
                msg("Ingresé el Detalle del Servicio");
                txtdetalle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtocupacion.Text))
            {
                msg("Ingresé la Ocupación Principal");
                txtocupacion.Focus();
                return;
            }
            ocupacion = txtocupacion.Text;
            detalle = txtdetalle.Text;
            acepta = true;
            if (busca == true && estado == 2)
                locacion.LocacionServicios(contrato, tipo, numerodoc, 2, ocupacion, detalle);
            if (busca == false && estado == 2)
                locacion.LocacionServicios(contrato, tipo, numerodoc, 1, ocupacion, detalle);
            msgOK("Guardado");
            this.Close();
        }
    }
}
