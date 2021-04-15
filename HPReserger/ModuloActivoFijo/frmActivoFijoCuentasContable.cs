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

namespace HPReserger.ModuloActivoFijo
{
    public partial class frmActivoFijoCuentasContable : FormGradient
    {
        public frmActivoFijoCuentasContable()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Estado { get; private set; }
        private void frmActivoFijoCuentasContable_Load(object sender, EventArgs e)
        {
            Estado = 0;
            txtCuenta.CargarTextoporDefecto();
            CargarDAtos();
            ModoEdicion(true);
        }
        DataTable Tdatos;
        DataView dv;
        private void CargarDAtos()
        {
            dv = CapaLogica.ActivoFijo_CuentasContable(0).AsDataView();
            Dtgconten.DataSource = dv;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 1;
            ModoEdicion(true);
        }
        private void ModoEdicion(bool v)
        {
            btnActualizar.Enabled = btnmodificar.Enabled = !v;
            foreach (DataGridViewColumn item in Dtgconten.Columns)
                if (item.Index == 0)
                    item.ReadOnly = !v;
            //
            btnAceptar.Enabled = v;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 1)
            {
                ModoEdicion(false);
                Estado = 0;
            }
            else { this.Close(); }
        }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaLogica.ActivoFijo_CuentasContable(2);
            DataView dv = Tdatos.AsDataView();
            dv.RowFilter = "activofijo = 1";
            foreach (DataRow item in dv.ToTable().Rows)
            {
                //CapaLogica.ActivoFijo_CuentasContable(item["Id_Cuenta_Contable"].ToString());
            }
            msgOK("Grabado con Exito");
            Estado = 0;
            ModoEdicion(false);
            CargarDAtos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDAtos();
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Dtgconten.EndEdit();
        }

        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                CapaLogica.ActivoFijo_CuentasContable(((int)Dtgconten[0, e.RowIndex].Value) == 1 ? 3 : 2, Dtgconten[xId_Cuenta_Contable.Name, e.RowIndex].Value.ToString());
            }
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            if (txtCuenta.EstaLLeno())
            {
                dv.RowFilter = $"Cuenta_Contable like '%{txtCuenta.TextValido()}%'";
            }
            else dv.RowFilter = "";
        }
    }
}
