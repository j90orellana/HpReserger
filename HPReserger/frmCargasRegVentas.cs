using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmCargasRegVentas : FormGradient
    {
        public frmCargasRegVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmCargasRegVentas_Load(object sender, EventArgs e)
        {
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Excel|*.xls;*xlsx;*xlsm";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = txtruta.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                txtruta.Text = file;
                SacarHojasdeExcel();
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SacarHojasdeExcel()
        {
            cbohojas.Items.Clear();
            foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(txtruta.Text))
            {
                cbohojas.Items.Add(item);
            }
            if (cbohojas.Items.Count > 0)
            {
                cbohojas.SelectedIndex = 0;
            }
        }
        private void txtruta_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(txtruta.Text))
            {
                cbohojas.Items.Clear();
            }
            else { SacarHojasdeExcel(); }
        }
        public Boolean ValidarRutaExiste(TextBox cajita)
        {
            if (cajita.Text.Length > 0)
            {
                if (!File.Exists(cajita.Text))
                {
                    msg("Archivo no Existe");
                    return false;
                }
                return true;
            }
            else return false;
        }
        private void txtruta_Leave(object sender, EventArgs e)
        {
            ValidarRutaExiste(txtruta);
        }
        public DialogResult msgP(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        DataTable Tipocomprobantes = new DataTable();
        DataTable TipoId = new DataTable();
        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (msgP("Desea Continuar con la Carga ") == DialogResult.Yes)
            {
                //Si Cargar Todo a la Base;
                //Verifico si Existe la ruta del Archivo
                if (!ValidarRutaExiste(txtruta))
                {
                    return;
                }
                if (dtgconten.Columns.Count == 12)
                {
                    //proceso de validacion de datos  
                    //COLUMNAS --CODIGO -DESCRIPCION
                    Tipocomprobantes = CapaLogica.getCargoTipoContratacion("id_comprobante", "nombre", "TBL_Comprobante_Pago");
                    List<string> Comprobantes = new List<string>();
                    foreach (DataRow item in Tipocomprobantes.Rows)
                    {
                        Comprobantes.Add(item[1].ToString().ToUpper());
                    }
                    //TIPOS DE ID 
                    TipoId = CapaLogica.TiposID(0, 0, "", 0);
                    List<tipoid> TiposId = new List<tipoid>();
                    foreach (DataRow item in TipoId.Rows)
                    {
                        tipoid tp = new tipoid(item[1].ToString().ToUpper(), (int)item[2]);
                        TiposId.Add(tp);
                    }
                    Boolean Verificacion = true;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if (Comprobantes.Exists(c => c == item.Cells[0].Value.ToString().ToUpper()))
                        {
                            ColorCeldaNormal(item.Cells[0]);
                        }
                        else { Verificacion = false; ColorCeldaError(item.Cells[0]); }
                        if (TiposId.Exists(c => c.tipo == item.Cells[2].Value.ToString().ToUpper() && c.len == item.Cells[3].Value.ToString().Length))
                        {
                            ColorCeldaNormal(item.Cells[2]);
                            ColorCeldaNormal(item.Cells[3]);
                        }
                        else { Verificacion = false; ColorCeldaError(item.Cells[2]); ColorCeldaError(item.Cells[3]); }
                        int x = 0, y = 7;
                        if (Int32.TryParse(item.Cells[y].Value.ToString(), out x))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                        y = 8;
                        if (Int32.TryParse(item.Cells[y].Value.ToString(), out x))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                        y = 10;
                        if (Int32.TryParse(item.Cells[y].Value.ToString(), out x))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                        y = 9;
                        decimal p;
                        if (decimal.TryParse(item.Cells[y].Value.ToString(), out p))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                        y = 11;
                        if (Int32.TryParse(item.Cells[y].Value.ToString(), out x))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                        y = 1;
                        if (Int32.TryParse(item.Cells[y].Value.ToString(), out x))
                        {
                            ColorCeldaNormal(item.Cells[y]);
                        }
                        else { ColorCeldaError(item.Cells[y]); Verificacion = false; }
                    }
                    //VERIFICACION
                    if (Verificacion)
                    {
                        ///INSERTANDO A LA BASE DE DATOS
                        foreach (DataGridViewRow item in dtgconten.Rows)
                        {
                            CapaLogica.RegistroVentas(1, item.Cells[0].Value.ToString(), int.Parse(item.Cells[1].Value.ToString()), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString(), int.Parse(item.Cells[7].Value.ToString()), int.Parse(item.Cells[8].Value.ToString()), decimal.Parse(item.Cells[9].Value.ToString()), int.Parse(item.Cells[10].Value.ToString()), frmLogin.CodigoUsuario);
                        }
                        msg("Insertado con Exito");
                    }
                    else
                    {
                        msg("Revise Los datos No se puede Procesar la Carga de Datos");
                    }
                }
                else { msg("Deben Haber 11 Columnas en el Excel"); }
            }
            else
            {
                //no Cargar nada a la Base;
            }
        }
        public void ColorCeldaError(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Red;
            item.Style.BackColor = Color.Yellow;
        }
        public void ColorCeldaNormal(DataGridViewCell item)
        {
            item.Style.ForeColor = Color.Green;
            item.Style.BackColor = Color.Empty;
        }
        public class tipoid
        {
            public string tipo;
            public int len;
            public tipoid(string _tipo, int _len)
            {
                tipo = _tipo;
                len = _len;
            }
        }
        DataTable Datos = new DataTable();
        private void btncargaexcel_Click(object sender, EventArgs e)
        {
            if (cbohojas.Items.Count > 0)
            {
                Datos = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(txtruta.Text, cbohojas.Text);
                Datos.Columns.Add("Número", typeof(int));
                // Datos = Datos.Select("", "NOMBRE_CLIENTE asc").CopyToDataTable();

                dtgconten.DataSource = Datos;
                if (dtgconten.ColumnCount > 4)
                    dtgconten.Sort(dtgconten.Columns[4], ListSortDirection.Ascending);
            }
            else msg("No Hay Hojas que Mostrar");
        }

        private void dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {

            }
        }

        private void dtgconten_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void dtgconten_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dtgconten[e.ColumnIndex, e.RowIndex].Selected = true;
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void eliminarFilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in dtgconten.SelectedCells)
            {
                dtgconten.Rows.Remove(item.OwningRow);
            }
        }
        private void eliminarColumnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in dtgconten.SelectedCells)
            {
                try
                {
                    dtgconten.Columns.Remove(item.OwningColumn);
                }
                catch { }
            }
        }
    }
}
