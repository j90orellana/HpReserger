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
    public partial class frmLocacionServicio : Form
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
                if (Preguntar("Hay Datos en detalle, Desea Salir") == DialogResult.No)
                    return;
            }
            if (!string.IsNullOrWhiteSpace(txtocupacion.Text))
            {
                if (Preguntar("Hay Datos en la Ocupacion, Desea Salir") == DialogResult.No)
                    return;
            }
            acepta = false;
            this.Close();
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Preguntar(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdetalle.Text))
            {
                MSG("Ingresé el Detalle del Servicio");
                txtdetalle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtocupacion.Text))
            {
                MSG("Ingresé la Ocupación Principal");
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
            MSG("Guardado");
            this.Close();
        }
    }
}
