using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public partial class frmConfigurarDinamicas : Form
    {
        public frmConfigurarDinamicas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmConfigurarDinamicas_Load(object sender, EventArgs e)
        {
            CargarDinamicas();
        }
        public void CargarDinamicas()
        {
            dtgconten.DataSource = CapaLogica.StoreProcedures(0, 0, "0", 0);
        }
        int estado = 0;
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            estado = 1;
            dtgconten.Columns[Cadenax.Name].ReadOnly = true;
            Desactivar(btnmodificar);
            Activar(btnguardar);
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
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
                Close();
            else
            {
                Activar(btnmodificar);
                Desactivar(btnguardar);
                estado = 0;
                CargarDinamicas();
            }
        }
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentCell.RowIndex;
            int y = dtgconten.CurrentCell.ColumnIndex;
            if (x >= 0 && y == dtgconten.Columns[Cadenax.Name].Index)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress -= new KeyPressEventHandler(ValidarNumeros);
                txt.KeyPress += new KeyPressEventHandler(ValidarNumeros);
            }

        }
        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            dtgconten.EndEdit();
            foreach (DataGridViewRow fila in dtgconten.Rows)
            {
                CapaLogica.StoreProcedures(2, (int)fila.Cells[cod_storex.Name].Value, fila.Cells[storex.Name].Value.ToString(), (int)fila.Cells[Cadenax.Name].Value);
            }
            if (dtgconten.RowCount > 0)
            {
                msg("Guardado con Exito");
                CargarDinamicas();
                Activar(btnmodificar);
                Desactivar(btnguardar);
                estado = 0;
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dtgconten_DoubleClick(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                frmdinamicaContable dinas = new frmdinamicaContable();
                dinas.Busqueda = true;
                dinas.salida = false;
                dinas.ShowDialog();
                int y = dtgconten.CurrentCell.RowIndex;
                int x = dtgconten.CurrentCell.ColumnIndex;
                if (dinas.aceptar)
                {
                    //dtgconten[x, y].ReadOnly = false;
                    dtgconten[x, y].Value = int.Parse(dinas.txtcodigo.Text.Substring(3));
                    //dtgconten[x, y].ReadOnly = true;

                }
            }
        }
    }
}
