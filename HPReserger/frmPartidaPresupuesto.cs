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
    public partial class frmPartidaPresupuesto : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL cpresupuesto = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public frmPartidaPresupuesto()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        private void frmPartidaPresupuesto_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = cpresupuesto.getCargoTipoContratacion("Id_PPresupuesto", "PartidaPpto", "TBL_Partida_Ppto_Cab");
            dtgconten.Focus();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = dtgconten[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                estado = 0;
                Activar();
                frmPartidaPresupuesto_Load(sender, e);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            tipmsg.Show("Ingrese Partida Presupuesto", txtgerencia, 1000);
            txtcodigo.Text = txtgerencia.Text = "";
            estado = 1;
            Desactivar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Partida Presupuesto", txtgerencia, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    msg("Este valor:" + txtgerencia.Text + " ya Existe");
                    return Aux;
                }
            }
            return Aux;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1 && ValidarDes(txtgerencia.Text))
            {
                cpresupuesto.AgregarParPresupuesto(txtgerencia.Text.ToString());
            }
            else
            {
                if (estado == 2 && ValidarDes(txtgerencia.Text))
                {
                    cpresupuesto.ActualizarParPresupuesto(Convert.ToInt32(txtcodigo.Text), txtgerencia.Text.ToString());
                }
                else
                {
                    if (estado == 3)
                    {
                        if (msgp("Seguró Desea Eliminar " + txtgerencia.Text) == DialogResult.Yes)
                        {
                            cpresupuesto.EliminarParPrespuesto(Convert.ToInt32(txtcodigo.Text));
                        }
                    }
                }
            }
            estado = 0;
            frmPartidaPresupuesto_Load(sender, e);
            Activar();
        }
    }
}
