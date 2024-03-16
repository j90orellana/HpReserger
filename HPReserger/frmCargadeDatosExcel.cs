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
    public partial class frmCargadeDatosExcel : FormGradient
    {
        public frmCargadeDatosExcel()
        {
            InitializeComponent();
        }
        public string Ruta { get { return txtRuta.Text; } set { txtRuta.Text = value; } }
        public string Hoja { get { return cbohojas.Text; } set { cbohojas.Text = value; } }
        public string ruta;
        private void frmCargadeDatosExcel_Load(object sender, EventArgs e)
        {
            Ruta = ruta;
            if (Ruta.Length > 0)
            {
                cbohojas.Items.Clear();
                foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(Ruta))
                {
                    cbohojas.Items.Add(item);
                }
                if (cbohojas.Items.Count > 0)
                {
                    cbohojas.SelectedIndex = 0;
                }
            }
        }
        private void btncargaexcel_Click(object sender, EventArgs e)
        {
            if (cbohojas.Items.Count > 0)
            {
                Grid.DataSource = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, Hoja);
            }
            else HPResergerFunciones.frmInformativo.MostrarDialogError("No Hay Hojas que Mostrar");
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btncargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Archivo de Excel|*.xls;*.xlsx";
            if (DialogResult.OK == OpenFileDialog.ShowDialog())
            {
                if (OpenFileDialog.FileName != null)
                {
                    Ruta = OpenFileDialog.FileName;
                    cbohojas.Items.Clear();
                    foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(Ruta))
                    {
                        cbohojas.Items.Add(item);
                    }
                    if (cbohojas.Items.Count > 0)
                    {
                        cbohojas.SelectedIndex = 0;
                    }
                }
                else
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("No ha Seleccionado un Archivo");
                }
            }
            //else MSG("No ha Seleccionado un Archivo");
        }

        private void Grid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblmensaje.Text = $"Nro Registros {Grid.RowCount}";
        }

        private void Grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblmensaje.Text = $"Nro Registros {Grid.RowCount}";
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyValue == 8)
            {
                if (msgp("Desea ELiminar Filas") == DialogResult.Yes)
                    foreach (DataGridViewRow item in Grid.SelectedRows)
                    {
                        Grid.Rows.Remove(item);
                    }
                else e.Handled = true;
            }

        }

        private void cbohojas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
