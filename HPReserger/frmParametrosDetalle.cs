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
    public partial class frmParametrosDetalle : Form
    {
        public frmParametrosDetalle()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Tabla de Parametros";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Parametros", Celditas, 2, new int[] { 1, 5 }, new int[] { 1 }, new int[] { });
                msg("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (dtgconten.RowCount > 0)
                btnexportarExcel.Enabled = true;
            else
                btnexportarExcel.Enabled = false;           
        }
    }
}
