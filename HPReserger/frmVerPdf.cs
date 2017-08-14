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
    public partial class frmVerPdf : Form
    {
        public frmVerPdf()
        {
            InitializeComponent();
        }
        public string nombreformulario;
        public string ruta;
        public FormWindowState EstadoVentana = FormWindowState.Normal;
        private void frmVerPdf_Load(object sender, EventArgs e)
        {
            this.Text = "Ver Pdf - " + nombreformulario;
            AdbVer.src = ruta;
            this.WindowState = EstadoVentana;
            dtgconten.Columns.Add("id", "hola");
            dtgconten.Columns.Add("id1", "hola1");
            dtgconten.Columns.Add("id2", "hola2");
            dtgconten.Columns.Add("id3", "hola3");
            dtgconten.Columns.Add("id4", "hola4");

        }
        private void frmVerPdf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        public void ManejarCajita(out int hola)
        {
            hola = 0;

        }
        int fila;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount <= 0)
                fila = 0;
            else
                fila = dtgconten.CurrentCell.RowIndex;
            btnadd.Text = "add " + fila;
            //int[] numero = { 1, 2, 3, 4, 5 };
            if (dtgconten.RowCount != 0)
            {
                dtgconten.Rows.Insert(fila + 1, 1);
            }
            else
                dtgconten.Rows.Add();
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dtgconten.ColumnCount; i++)
            {
                if (dtgconten[i, e.RowIndex].Value != null)
                {
                    return;
                }
            }
            dtgconten.Rows[e.RowIndex].Visible = false;
        }
    }
}
