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
    public partial class frmpresupuesto : FormGradient
    {
        public frmpresupuesto()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLpresupuesto = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void RellenarCombosSiNo(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Administracion" });
            tablita.Rows.Add(new object[] { "2", "Obra" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 1;
        }

        private void frmpresupuesto_Load(object sender, EventArgs e)
        {
            RellenarCombosSiNo(cbotipo);
            cbomoneda.DataSource = CLpresupuesto.getCargoTipoContratacion("Id_Moneda", "Moneda", "TBL_Moneda");
            cbomoneda.ValueMember = "codigo";
            cbomoneda.DisplayMember = "descripcion";
            cboempresa.DataSource = CLpresupuesto.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            dtgconten.DataSource = CLpresupuesto.ListarPresupuestosCabecera();

        }
        public void Iniciar(Boolean a)
        {
            btnaceptar.Enabled = a;
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            dtgconten.Enabled = !a;
            gp1.Enabled = a;
            btndetalle.Enabled = !a;
        }
        public Boolean validar(int fila)
        {
            if (cbotipo.SelectedIndex == 0 && dtgconten.RowCount > 0)
            {
                string PERIODO = txtejercicio.Text;
                string TIPO = cbotipo.SelectedValue.ToString();
                string EMPRESA = cboempresa.SelectedValue.ToString();
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    if (dtgconten["ejercicio", i].Value.ToString() == PERIODO && dtgconten["id_empresa", i].Value.ToString() == EMPRESA && dtgconten["tipo_ppto", i].Value.ToString() == TIPO && i != fila)
                    {
                        msg("Ya Existe un Presupuesto de Administración en la Fila: " + i + 1);
                        return false;
                    }
                }
            }
            return true;
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            Iniciar(true);
            txtejercicio.Text = DateTime.Now.Year.ToString();
            cboempresa.SelectedIndex = -1;
            cbomoneda.SelectedIndex = -1;
            cbotipo.SelectedIndex = -1;
            txtimporte.Text = "";
            txtdescripcion.Text = "";
            txtnumero.Text = (dtgconten.RowCount + 1).ToString();
            txtdescripcion.Focus();

        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Iniciar(true);
            txtdescripcion.Focus();

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
                Iniciar(false);
            else
                this.Close();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedIndex < 0)
            {
                msg("Seleccioné una Empresa");
                cboempresa.Focus();
                return;
            }
            if (cbomoneda.SelectedIndex < 0)
            {
                msg("Seleccioné una Moneda");
                cbomoneda.Focus();
                return;
            }
            if (cbotipo.SelectedIndex < 0)
            {
                msg("Seleccioné un Tipo");
                cbotipo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                msg("Ingrese la Descripción del Presupuesto");
                txtdescripcion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtejercicio.Text))
            {
                msg("Ingrese la Ejercicio del Presupuesto");
                txtejercicio.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtimporte.Text))
            {
                msg("Ingrese el Importe del Presupuesto");
                txtimporte.Focus();
                return;
            }
            if (estado == 1)
            {
                if (validar(-1))
                {
                    CLpresupuesto.PresupuestoCabecera(1, 0, txtdescripcion.Text, int.Parse(txtejercicio.Text), int.Parse(cboempresa.SelectedValue.ToString()), int.Parse(cbotipo.SelectedValue.ToString()), int.Parse(cbomoneda.SelectedValue.ToString()), decimal.Parse(txtimporte.Text), frmLogin.CodigoUsuario);
                    msgOK("Presupuesto Guardado con exito"); estado = 0;
                    dtgconten.DataSource = CLpresupuesto.ListarPresupuestosCabecera();
                    Iniciar(false);
                }
            }
            if (estado == 2)
            {
                if (validar(dtgconten.CurrentCell.RowIndex))
                {
                    CLpresupuesto.PresupuestoCabecera(2, int.Parse(dtgconten["idppto", dtgconten.CurrentCell.RowIndex].Value.ToString()), txtdescripcion.Text, int.Parse(txtejercicio.Text), int.Parse(cboempresa.SelectedValue.ToString()), int.Parse(cbotipo.SelectedValue.ToString()), int.Parse(cbomoneda.SelectedValue.ToString()), decimal.Parse(txtimporte.Text), frmLogin.CodigoUsuario);
                    msgOK("Presupuesto Actualizado con exito"); estado = 0;
                    dtgconten.DataSource = CLpresupuesto.ListarPresupuestosCabecera();
                    Iniciar(false);
                }
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                int y = e.RowIndex;
                txtnumero.Text = dtgconten["idppto", y].Value.ToString();
                txtdescripcion.Text = dtgconten["partidappto", y].Value.ToString();
                txtejercicio.Text = dtgconten["ejercicio", y].Value.ToString();
                txtimporte.Text = dtgconten["importe", y].Value.ToString();
                cboempresa.SelectedValue = dtgconten["id_empresa", y].Value.ToString();
                cbomoneda.SelectedValue = dtgconten["moneda", y].Value.ToString();
                cbotipo.SelectedValue = dtgconten["tipo_ppto", y].Value.ToString();
                btndetalle.Enabled = true;
            }
            else
                btndetalle.Enabled = false;
        }

        private void txtejercicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtejercicio_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtejercicio, 4);
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtimporte.Text);
        }

        private void txtimporte_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtimporte);
        }
        frmPresupuestodetalle presudetale;
        private void btndetalle_Click(object sender, EventArgs e)
        {
            if (presudetale == null)
            {
                presudetale = new frmPresupuestodetalle();
                presudetale.MdiParent = this.MdiParent;
                //presudetale.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
                presudetale.cabecera = int.Parse(dtgconten["idppto", dtgconten.CurrentCell.RowIndex].Value.ToString());
                presudetale.empresa = int.Parse(dtgconten["id_empresa", dtgconten.CurrentCell.RowIndex].Value.ToString());
                presudetale.Text = $"Detalle del Presupuesto - {dtgconten[EMPRESA.Name, dtgconten.CurrentCell.RowIndex].Value.ToString()}";
                //presudetale.ShowDialog();
                presudetale.Icon = Icon;
                presudetale.FormClosed += new FormClosedEventHandler(cerrarpresusdetalle);
                presudetale.Show();

            }
            else
            {
                presudetale.Activate();
                ValidarVentanas(presudetale);
            }

        }
        void cerrarpresusdetalle(object sender, FormClosedEventArgs e)
        {
            presudetale = null;
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
            if (e.RowIndex > 0)
            {
                btndetalle_Click(sender, e);
            }
        }
    }
}
