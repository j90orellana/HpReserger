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
    public partial class frmEntiFinanciera : FormGradient
    {
        public frmEntiFinanciera()
        {
            InitializeComponent();
        }
        public int estado { get; set; }
        HPResergerCapaLogica.HPResergerCL cEntiFinanciera = new HPResergerCapaLogica.HPResergerCL();
        private void frmEntiFinanciera_Load(object sender, EventArgs e)
        {
            estado = 0;
            dtgconten.DataSource = cEntiFinanciera.EntidadFinanciera(0, 0, "", "");
            dtgconten.Focus();
            Activar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Nueva Entidad Financiera", txtgerencia, 700);
            txtcodigo.Text = txtgerencia.Text = "";
            estado = 1;
            Desactivar();
            txtsufijo.Text = "";
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Entidad Financiera", txtgerencia, 700);
            Desactivar();
            estado = 2;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtcodigo.Text = dtgconten[0, e.RowIndex].Value.ToString();
                    txtgerencia.Text = dtgconten[1, e.RowIndex].Value.ToString();
                    txtsufijo.Text = dtgconten[sufijox.Name, e.RowIndex].Value.ToString();
                }
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
                frmEntiFinanciera_Load(sender, e);
            }
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
            txtgerencia.ReadOnly = txtsufijo.ReadOnly = false;
        }
        public void Activar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
            txtcodigo.ReadOnly = txtgerencia.ReadOnly = txtsufijo.ReadOnly = true;
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    msg("Este valor: " + txtgerencia.Text + " ya Existe");
                    return Aux;
                }
            }
            return Aux;
        }
        public Boolean ValidarDes(string valor, int id)
        {
            Boolean Aux = true;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (dtgconten[1, i].Value.ToString() == valor && id != (int)dtgconten[codigox.Name, i].Value)
                {
                    Aux = false;
                    msg("Este valor: " + txtgerencia.Text + " ya Existe");
                    return Aux;
                }
            }
            return Aux;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (!txtsufijo.EstaLLeno())
            {
                txtsufijo.Focus();
                msg("Esta Vacio el sufijo");
                return;
            }

            if (estado == 1 && ValidarDes(txtgerencia.Text))
            {
                cEntiFinanciera.EntidadFinanciera(1, 0, txtgerencia.Text, txtsufijo.TextValido());
                msgOK("Insertado Exitosamente");
            }
            else
            {
                if (estado == 2 && ValidarDes(txtgerencia.Text, (int)dtgconten[codigox.Name, dtgconten.CurrentRow.Index].Value))
                {
                    cEntiFinanciera.EntidadFinanciera(2, Convert.ToInt32(txtcodigo.Text), txtgerencia.Text, txtsufijo.TextValido());
                    msgOK("Actualizado Exitosamente");
                }
                else
                {
                    if (estado == 3)
                    {
                        if (msgp("Seguró Desea Eliminar: " + txtgerencia.Text) == DialogResult.Yes)
                        {
                            cEntiFinanciera.EliminarEntiFinanciera(Convert.ToInt32(txtcodigo.Text));
                        }
                    }
                }
            }
            estado = 0;
            frmEntiFinanciera_Load(sender, e);
            Activar();
        }
    }
}
