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
        DataRow DatosMaximo;
        private void frmPresupuestodetalle_Load(object sender, EventArgs e)
        {
            txtimporte.Text = "";
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.DataSource = CLDetalle.ListarProyectosEmpresa(empresa.ToString());
            DatosMaximo = CLDetalle.VerMaximoPresupuesto(cabecera);
            if (DatosMaximo != null)
                txtmontomax.Text = DatosMaximo["diferencia"].ToString();
            txtmontomax.Enabled = false;
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
                if (dtgconten.RowCount > 0)
                {
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
                else MSG("Proyecto - No Tiene Etapas");
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
            if (MessageBox.Show("Seguro, Desea Salir", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
            iniciar(false);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txttotal.Text) > (decimal.Parse(DatosMaximo["sumaimporte"].ToString()) + decimal.Parse(txtmontomax.Text)))
            {
                MSG($"El Total Del Proyecto:{txttotal.Text },  No Puede ser mayor al Presupuesto { decimal.Parse(DatosMaximo["sumaimporte"].ToString()) + decimal.Parse(txtmontomax.Text)}");
                txtimporte.Focus();
                return;
            }

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
            CLDetalle.ProyectoCentrodecostodetalle(10, 0, cabecera, int.Parse(cboproyecto.SelectedValue.ToString()), 0, 0, "0", 0, 0, 0);
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                if (decimal.Parse(dtgconten["importe", i].Value.ToString()) > 0)
                {
                    CLDetalle.ProyectoCentrodecostodetalle(0, 0, cabecera, int.Parse(cboproyecto.SelectedValue.ToString()), int.Parse(dtgconten["id_etapas", i].Value.ToString()), decimal.Parse(txtimporte.Text), dtgconten["CodCentroC", i].Value.ToString(), decimal.Parse(dtgconten["importe", i].Value.ToString()), decimal.Parse(dtgconten["flujos", i].Value.ToString()), frmLogin.CodigoUsuario);
                }
            }
            MSG("Modificación Exitosa");
            contando(dtgconten);
            iniciar(false);
            DatosMaximo = CLDetalle.VerMaximoPresupuesto(cabecera);
            if (DatosMaximo != null)
                txtmontomax.Text = DatosMaximo["diferencia"].ToString();
            txtmontomax.Enabled = false;
        }


        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);

        }
        TextBox txt;
        decimal total, flujos;
        public void calcularsumatoria()
        {
            total = 0; flujos = 0;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                total += decimal.Parse(dtgconten["importe", i].Value.ToString());
                flujos += decimal.Parse(dtgconten["flujos", i].Value.ToString());
            }
            txttotal.Text = total.ToString("n2");
            txtflujos.Text = flujos.ToString("n2");
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
        frmpresupuestoetapa etapitas;
        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                if (dtgconten["btnmas", y].ColumnIndex == x)
                {
                    if (etapitas == null)
                    {
                        etapitas = new frmpresupuestoetapa();
                        etapitas.MdiParent = this.MdiParent;
                        //presudetale.MdiParent = this;
                        //presus.StartPosition = FormStartPosition.CenterParent;
                        // pbfotoempleado.Visible = false;
                        //                presudetale.ShowDialog();
                        etapitas.Text = "PRESUPUESTO POR ETAPAS DE " + cboproyecto.Text;
                        etapitas.etapa = (int)dtgconten["id_Etapas", y].Value;
                        etapitas.txtetapa.Text = dtgconten["etapa_des", y].Value.ToString();
                        etapitas.txtcc.Text = dtgconten["codcentroc", y].Value.ToString();
                        etapitas.txtcentro.Text = dtgconten["descripción", y].Value.ToString();
                        etapitas.cabecera = cabecera;
                        etapitas.Icon = Icon;
                        etapitas.FormClosed += new FormClosedEventHandler(cerrarpresupuestoetapas);
                        etapitas.Show();
                        if (etapitas.ok)
                        {
                            dtgconten["importe", y].Value = etapitas.valor;
                            dtgconten["FLujos", y].Value = etapitas.valorflujo;
                            calcularsumatoria();
                        }
                    }
                    else
                    {
                        etapitas.Activate();
                        ValidarVentanas(etapitas);
                    }
                }
            }
        }
        void cerrarpresupuestoetapas(object sender, FormClosedEventArgs e)
        {
            if (etapitas != null)
                if (etapitas.ok)
                {
                    dtgconten["importe", dtgconten.CurrentCell.RowIndex].Value = etapitas.valor;
                    dtgconten["FLujos", dtgconten.CurrentCell.RowIndex].Value = etapitas.valorflujo;
                    calcularsumatoria();
                }
            etapitas = null;
            // pbfotoempleado.Visible = true;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            // if (formulario.StartPosition != FormStartPosition.CenterParent)
            //   formulario.StartPosition = FormStartPosition.CenterParent;
            //this.LayoutMdi(MdiLayout.);
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2);
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                if (dtgconten.RowCount > 0)
                {
                    if (etapitas == null)
                    {
                        etapitas = new frmpresupuestoetapa();
                        etapitas.MdiParent = this.MdiParent;
                        etapitas.Icon = Icon;
                        //presudetale.MdiParent = this;
                        //presus.StartPosition = FormStartPosition.CenterParent;
                        // pbfotoempleado.Visible = false;
                        //                presudetale.ShowDialog();
                        etapitas.Text = "PRESUPUESTO POR ETAPAS DE " + cboproyecto.Text;
                        etapitas.etapa = (int)dtgconten["id_Etapas", y].Value;
                        etapitas.txtetapa.Text = dtgconten["etapa_des", y].Value.ToString();
                        etapitas.txtcc.Text = dtgconten["codcentroc", y].Value.ToString();
                        etapitas.txtcentro.Text = dtgconten["descripción", y].Value.ToString();
                        etapitas.cabecera = cabecera;
                        etapitas.FormClosed += new FormClosedEventHandler(cerrarpresupuestoetapas);
                        etapitas.Show();
                        if (etapitas.ok)
                        {
                            dtgconten["importe", y].Value = etapitas.valor;
                            dtgconten["FLujos", y].Value = etapitas.valorflujo;
                            calcularsumatoria();
                        }
                    }
                    else
                    {
                        etapitas.Activate();
                        ValidarVentanas(etapitas);
                    }
                }
            }
        }

        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            txt = e.Control as TextBox;
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
            }
        }
        private void dtgconten_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
