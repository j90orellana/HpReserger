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
    public partial class frmetapas : FormGradient
    {
        public frmetapas()
        {
            InitializeComponent();
        }
        public int proyecto;
        HPResergerCapaLogica.HPResergerCL CLEtapas = new HPResergerCapaLogica.HPResergerCL();
        private void frmetapas_Load(object sender, EventArgs e)
        {
            CargarSiono(cboestado);
            cargarlista();
            cboestado.SelectedIndex = -1;
        }
        public void cargarlista()
        {
            Dtgconten.DataSource = CLEtapas.ListarEtapasdelProyecto(0, proyecto, 0, "", 0, DateTime.Now, DateTime.Now, 0, "", 0);
            if (Dtgconten.RowCount < 0)
            {
                btnmodificar.Enabled = true;
            }

        }
        public void CargarSiono(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("Codigo");
            tablita.Columns.Add("valor");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.ValueMember = "codigo";
            combito.DisplayMember = "valor";
        }
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (Dtgconten.RowCount > 0 && y >= 0)
            {
                txtdescripcion.Text = Dtgconten["descripcion", y].Value.ToString();
                cboestado.SelectedValue = Dtgconten["estado", y].Value.ToString();
                dtpfechainicio.Value = DateTime.Parse(Dtgconten["fechainicio", y].Value.ToString());
                dtpfechafin.Value = DateTime.Parse(Dtgconten["fechafin", y].Value.ToString());
                txtmeses.Text = Dtgconten["mesesconstruccion", y].Value.ToString();
                txtobserva.Text = Dtgconten["observacion", y].Value.ToString();
                //int dias = dtpfechafin.Value.Year - dtpfechainicio.Value.Year;
                // int meses = (dtpfechafin.Value.Month + (dias * 12)) - dtpfechainicio.Value.Month;
                //  msg((meses + 1).ToString());
            }
        }
        int estados = 0;
        private void Iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            pnl1.Enabled = a;
            Dtgconten.Enabled = !a;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estados = 1; txtdescripcion.Text = txtmeses.Text = txtobserva.Text = ""; Iniciar(true);

        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estados = 2;
            Iniciar(true);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estados != 0)
            {
                Iniciar(false);
                estados = 0;
            }
            else this.Close();
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                msg("Ingresé una Descripción");
                txtdescripcion.Focus();
                return;
            }
            if (cboestado.SelectedIndex < 0)
            {
                msg("Seleccione un Estado");
                cboestado.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmeses.Text))
            {
                msg("Ingresé los meses de Construcción");
                txtmeses.Focus();
                return;
            }
            if (dtpfechainicio.Value > dtpfechafin.Value)
            {
                msg("La fecha de inicio no puede se mayor a la de fin");
                dtpfechainicio.Focus();
                return;
            }
            if (estados == 1)
            {
                CLEtapas.ListarEtapasdelProyecto(1, proyecto, 1, txtdescripcion.Text, int.Parse(cboestado.SelectedValue.ToString()), dtpfechainicio.Value, dtpfechafin.Value, int.Parse(txtmeses.Text), txtobserva.Text, frmLogin.CodigoUsuario);
                msg("Etapa Ingresadá con exito");
                Iniciar(false);
                estados = 0;
                int dias = dtpfechafin.Value.Year - dtpfechainicio.Value.Year;
                int meses = ((dtpfechafin.Value.Month + (dias * 12)) - dtpfechainicio.Value.Month) + 1;
                cargarlista();
                CLEtapas.MesEtapa(10, 0, (int)Dtgconten["id_etapa", Dtgconten.RowCount - 1].Value, 0, 0, 0);
                for (int i = 0; i < meses + 2; i++)
                {
                    int mes = dtpfechainicio.Value.Month + i;
                    if (mes > 12) mes = mes - 12;
                    CLEtapas.MesEtapa(1, i + 1, (int)Dtgconten["id_etapa", Dtgconten.RowCount - 1].Value, (int)(dtpfechainicio.Value.Year + (dtpfechainicio.Value.Month + i - 1) / 12), mes, frmLogin.CodigoUsuario);
                }

            }
            if (estados == 2)
            {
                CLEtapas.ListarEtapasdelProyecto(2, proyecto, int.Parse(Dtgconten["id_etapa", Dtgconten.CurrentCell.RowIndex].Value.ToString()), txtdescripcion.Text, int.Parse(cboestado.SelectedValue.ToString()), dtpfechainicio.Value, dtpfechafin.Value, int.Parse(txtmeses.Text), txtobserva.Text, frmLogin.CodigoUsuario);
                msg("Etapa Modificada con exito");
                Iniciar(false);
                int dias = dtpfechafin.Value.Year - dtpfechainicio.Value.Year;
                int meses = ((dtpfechafin.Value.Month + (dias * 12)) - dtpfechainicio.Value.Month) + 1;
                CLEtapas.MesEtapa(10, 0, (int)Dtgconten["id_etapa", Dtgconten.CurrentCell.RowIndex].Value, 0, 0, 0);
                for (int i = 0; i < meses + 2; i++)
                {
                    int mes = dtpfechainicio.Value.Month + i;
                    if (mes > 12) mes = mes - 12;
                    CLEtapas.MesEtapa(1, i + 1, (int)Dtgconten["id_etapa", Dtgconten.CurrentCell.RowIndex].Value, (int)(dtpfechainicio.Value.Year + (dtpfechainicio.Value.Month + i - 1) / 12), mes, frmLogin.CodigoUsuario);
                }
                estados = 0; cargarlista();
            }


        }
        private void txtmeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtmeses_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtmeses, 4);
        }
    }
}
