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
    public partial class frmPresupuestodetalle : Form
    {
        public frmPresupuestodetalle()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLDetalle = new HPResergerCapaLogica.HPResergerCL();
        public int cabecera; public int empresa;
        private void frmPresupuestodetalle_Load(object sender, EventArgs e)
        {
            txtimporte.Text = "";
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.DataSource = CLDetalle.ListarProyectosEmpresa(empresa.ToString());
            if (cboproyecto.Items.Count < 1)
                MSG("No hay Proyectos");
        }
        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtimporte.Text);
        }
        public void contando(DataGridView grilla)
        {
            lblmsg.Text = "Total de Registros " + grilla.RowCount;
        }
        private void txtimporte_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtimporte);
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        decimal importes;
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex > -1)
            {
                iniciar(false);
                dtgconten.DataSource = CLDetalle.ListarPresupuestoCentrodeCosto(cabecera, int.Parse(cboproyecto.SelectedValue.ToString()));
                txtimporte.Text = dtgconten["importe_proy", 0].Value.ToString();
                calcularsumatoria();
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    importes = decimal.Parse(dtgconten["importe_proy", i].Value.ToString());
                    if (importes > 0)
                    {
                        txtimporte.Text = importes.ToString("n2");
                        break;
                    }
                }
                contando(dtgconten);
            }
        }
        public void iniciar(Boolean a)
        {
            btneditar.Enabled = !a;
            btnaceptar.Enabled = a;
            gp1.Enabled = !a;           
            txtimporte.Enabled = a;
            dtgconten.Enabled = a;
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.Items.Count < 1)
            {
                MSG("No hay Proyectos");
                return;

            }
            iniciar(true);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro, Desea Salir", "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
            iniciar(false);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtimporte.Text != txttotal.Text)
            {
                MSG("Hay diferencia en el Importe");
                txtimporte.Focus();
                return;
            }
            if (cboproyecto.SelectedIndex < 0)
            {
                MSG("Seleccioné un Proyecto");
                cboproyecto.Focus();
                return;
            }
            CLDetalle.ProyectoCentrodecostodetalle(10, 0, cabecera,int.Parse(cboproyecto.SelectedValue.ToString()),0, 0, "0", 0, 0);
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (decimal.Parse(dtgconten["importe", i].Value.ToString()) > 0)
                {
                    CLDetalle.ProyectoCentrodecostodetalle(0, 0, cabecera, int.Parse(cboproyecto.SelectedValue.ToString()), int.Parse(dtgconten["id_etapas",i].Value.ToString()), decimal.Parse(txtimporte.Text), dtgconten["CodCentroC", i].Value.ToString(), decimal.Parse(dtgconten["importe", i].Value.ToString()), frmLogin.CodigoUsuario);
                }
            }
            MSG("Modificación Exitosa");
            contando(dtgconten);
            iniciar(false);

        }


        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);

        }
        int deci, punto;
        TextBox txt;
        decimal total;
        public void calcularsumatoria()
        {
            total = 0;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                total += decimal.Parse(dtgconten["importe", i].Value.ToString());
            }
            txttotal.Text = total.ToString("n2");
        }
        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
            {
                dtgconten[e.ColumnIndex, e.RowIndex].Value = 0.00;
            }
            calcularsumatoria();
        }

        private void txtimporte_Validated(object sender, EventArgs e)
        {
            txtimporte.Text = decimal.Parse(txtimporte.Text.ToString()).ToString("n2");
        }

        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            punto = deci = 0;
            txt = e.Control as TextBox;
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
            }

        }
    }
}
