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
    public partial class frmAreaCargo : Form
    {
        public frmAreaCargo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                Activar(cboarea, btnmodificar, cbogerencia, btnr);
                Desactivar(cboCargoPuesto, btnagregar);
                estado = 0;
                dtgconten.DataSource = CapaLogica.CargosAreas(0, 0, 0);
            }
            else { this.Close(); }
        }
        private void frmAreaCargo_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.CargosAreas(0, 0, 0);
            CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
            //CargarCombos(cboarea, "Id_Area", "Area", "TBL_Area");
            CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
            Activar(cboarea, btnmodificar, btnr);
            Desactivar(cboCargoPuesto, btnagregar);
        }
        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = CapaLogica.getCargoTipoContratacion(codigo, descripcion, tabla);
        }
        int estado = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (cboarea.SelectedIndex >= 0)
            {
                estado = 1;
                Desactivar(btnmodificar, cboarea, cbogerencia, btnr);
                Activar(cboCargoPuesto, btnagregar);
                dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue);
            }
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cboarea.SelectedIndex >= 0 && cboCargoPuesto.SelectedIndex >= 0)
            {
                CapaLogica.CargosAreas(1, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue);
                dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue);
            }
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MSG("Desea ELiminar ??") == DialogResult.OK)
                {
                    int x = dtgconten.CurrentCell.RowIndex;
                    CapaLogica.CargosAreas(99, (int)dtgconten["fk_id_cargo", x].Value, (int)dtgconten["fk_id_area", x].Value);
                    if (estado == 1)
                        dtgconten.DataSource = CapaLogica.CargosAreas(10, (int)cboCargoPuesto.SelectedValue, (int)cboarea.SelectedValue);
                    else
                        dtgconten.DataSource = CapaLogica.CargosAreas(0, 0, 0);
                }
            }
        }
        private void cboarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboarea.SelectedIndex >= 0)
            {
                Activar(btnmodificar, cboarea);
            }
            else
            {
                Desactivar(btnmodificar, cboarea);
            }
        }
        private void cbogerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogerencia.SelectedIndex >= 0)
            {
                cboarea.Enabled = true;
                cboarea.DisplayMember = "area";
                cboarea.ValueMember = "codigoarea";
                cboarea.DataSource = CapaLogica.AreaGerencia((int)cbogerencia.SelectedValue);
            }
            else { cboarea.Enabled = false; }
            cboarea_SelectedIndexChanged(sender, e);
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Tag.ToString() == "1")
            {
                CargarCombos(cbogerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
            }
            if (((Control)sender).Tag.ToString() == "2")
            {
                CargarCombos(cboCargoPuesto, "Id_Cargo", "Cargo", "TBL_Cargo");
            }
        }
    }
}
