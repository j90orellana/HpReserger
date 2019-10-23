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
    public partial class frmNroOpBancacia : FormGradient
    {
        public frmNroOpBancacia()
        {
            InitializeComponent();
        }
        public class Listado
        {
            public int index;
            public int tipo;
            public int fkempresa;
            public string cuo;
            public Listado(int _index, int _tipo, int _fkempresa, string _cuo)
            {
                index = _index; tipo = _tipo; fkempresa = _fkempresa;
                cuo = _cuo;
            }
        }
        List<Listado> lista;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmNroOpBancacia_Load(object sender, EventArgs e)
        {
            Busqueda = false;
            cboEmpresa_Click(sender, e);
            CodigoBanco = 0;
            CargarBancos();
            LimpiarDatos();
            Busqueda = true;
            CargarGrilla();
            lista = new List<Listado>();
        }
        DataTable TDatos;
        public void CargarGrilla()
        {
            if (Busqueda)
            {
                int c = 0;
                ///usp_ListarNroOpBancaria
                string cuenta = cbocuenta.Text.Split(' ')[0];
                if (cuenta == "NINGUNA") cuenta = "";
                int CheckEstado = 0;
                if (chkNroop.CheckState == CheckState.Checked) CheckEstado = 1;
                else if (chkNroop.CheckState == CheckState.Unchecked) CheckEstado = -1;
                //
                TDatos = CapaLogica.ListarNroOpBancaria(CodigoBanco, cuenta, txtruc.TextValido(), txtrazon.TextValido(), txtnrobanco.TextValido(), dtpfecha1.Value, dtpfecha2.Value, CheckEstado, cboEmpresa.Text, txttipodoc.Text);
                foreach (DataRow item in TDatos.Rows)//id   ok
                {
                    int valor = (int)item[idx.DataPropertyName];
                    int tipor = (int)item[xdet.DataPropertyName];
                    int empresa = (int)item[xfkempresa.DataPropertyName];
                    string cuo = item["cuo"].ToString();
                    //Listado lis = new Listado(valor, tipor, empresa, cuo);
                    if (lista != null)
                        if (lista.Find(cust => cust.cuo == cuo && cust.fkempresa == empresa && cust.tipo == tipor && cust.index == valor) != null)
                        {
                            c++;
                            item["ok"] = 1;
                        }
                }
                OrdernarDatos();
            }
        }
        public void OrdernarDatos()
        {
            if (TDatos != null)
            {
                DataView dt = TDatos.DefaultView;
                dt.Sort = "ok desc";
                TDatos = dt.ToTable();
                dtgconten.DataSource = TDatos;
                int c = lista == null ? 0 : lista.Count;
                lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}  Seleccionados : {c}";
            }
        }
        public void CargarBancos()
        {
            DataTable TBanco = new DataTable();
            string cadena = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            TBanco = CapaLogica.getCargoTipoContratacion("sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            DataRow Rowcito = TBanco.NewRow();
            Rowcito[0] = "NADA";
            Rowcito[1] = "NINGUNO";
            TBanco.Rows.InsertAt(Rowcito, 0);
            cbobanco.DataSource = TBanco;
            cbobanco.Text = cadena;
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            dtgconten.EndEdit();
            if (dtgconten.RowCount > 0)
            {
                //Boolean estado = false;
                //if (dtgconten[okx.Name, 0].Value == null)
                //    estado = false;
                //else
                //    estado = dtgconten[okx.Name, 0].Value.ToString() == "1" ? true : false;
                int y = 0;
                int val = 0;
                if (btnseleccion.Text == "Seleccionar Todos") val = 1;
                foreach (DataGridViewRow xx in dtgconten.Rows)
                {
                    if (xx.Cells[NroOPBancox.Name].Value.ToString() == "")
                    {
                        if ((int)xx.Cells[okx.Name].Value == val && val == 0)
                        {
                            int tipo = (int)xx.Cells[xdet.Name].Value;
                            int id = (int)xx.Cells[idx.Name].Value;
                            string cuo = xx.Cells[xcuo.Name].Value.ToString();
                            Listado List = lista.Find(cust => cust.tipo == tipo && cust.index == id && cust.cuo == cuo);
                            lista.Remove(List);
                        }
                        else
                        {
                            int tipo = (int)xx.Cells[xdet.Name].Value;
                            int id = (int)xx.Cells[idx.Name].Value;
                            int empresa = (int)xx.Cells[xfkempresa.Name].Value;
                            string cuo = xx.Cells[xcuo.Name].Value.ToString();
                            if (lista.Find(cust => cust.index == id && cust.tipo == tipo && cust.fkempresa == empresa && cust.cuo == cuo) == null)
                                lista.Add(new Listado(id, tipo, empresa, cuo));
                            xx.Cells[okx.Name].Value = val;
                            dtgconten_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                            y++;
                        }
                    }
                }
                if (val == 1)
                {
                    btnseleccion.Text = "Deseleccionar  Todos";
                    OrdernarDatos();
                }
                else
                {
                    btnseleccion.Text = "Seleccionar Todos";
                }
            }
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgconten.EndEdit();
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (dtgconten.Columns[botonx.Name].Index == y)
                {
                    if (dtgconten[y, x].Value.ToString() == "Editar")
                    {
                        frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[Proveedorx.Name, x].Value.ToString(), dtgconten[Razonx.Name, x].Value.ToString(), dtgconten[NroFacturax.Name, x].Value.ToString(), dtgconten[Bancox.Name, x].Value.ToString()
                            , dtgconten[xcuo.Name, x].Value.ToString());
                        frmnroop.Codigo = (int)dtgconten[idx.Name, x].Value;
                        frmnroop.nrooperacion = dtgconten[NroOPBancox.Name, x].Value.ToString();
                        frmnroop.Empresa = (int)dtgconten[xfkempresa.Name, x].Value;
                        frmnroop.Tipodet = (int)dtgconten[xdet.Name, x].Value;
                        frmnroop.ShowDialog();
                        CargarGrilla();
                    }
                }
            }
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            //CargarBancos();
        }
        public int CodigoBanco { get; set; }
        public bool Busqueda { get; private set; }

        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuenta.Text = "";
                cbocuenta.ValueMember = "Id_Cuenta_Contable";
                cbocuenta.DisplayMember = "banco";
                DataTable TCuentas = new DataTable();
                TCuentas = CapaLogica.ListarBancosTiposdePago(cbobanco.SelectedValue.ToString());
                DataRow filita = TCuentas.NewRow();
                filita[0] = "";
                filita[1] = "NINGUNA";
                TCuentas.Rows.InsertAt(filita, 0);
                cbocuenta.DataSource = TCuentas;
                //Extrae el codigo del banco
                if (CapaLogica.EntidadFinanciera(10, 0, "", cbobanco.SelectedValue.ToString()).Rows.Count == 0)
                    CodigoBanco = 0;
                else
                    CodigoBanco = int.Parse((CapaLogica.EntidadFinanciera(10, 0, "", cbobanco.SelectedValue.ToString()).Rows[0])["id_entidad"].ToString());
            }
            CargarGrilla();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        public void LimpiarDatos()
        {
            dtpfecha1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfecha2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            txtruc.CargarTextoporDefecto();
            txtnrobanco.CargarTextoporDefecto();
            txtrazon.CargarTextoporDefecto();
            cbobanco.SelectedIndex = 0;
            chkNroop.CheckState = CheckState.Indeterminate;
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (msgp("Desea Cerrar Ventana") == DialogResult.Yes) { this.Close(); }
        }
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void txtrazon_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void txtnrobanco_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void dtpfecha1_ValueChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void dtpfecha2_ValueChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void cbocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0) return;
            if (!txtnroid.EstaLLeno())
            {
                txtnroid.Focus();
                msg("Ingrese Número de Operación");
                return;
            }
            foreach (Listado item in lista)
            {
                CapaLogica.ActualizarNroOperacion(item.index, txtnroid.TextValido(), item.tipo, item.fkempresa, item.cuo);
            }
            msgOK("Actualizado Número de Operación");
            txtnroid.CargarTextoporDefecto();
            lista.Clear();
            LimpiarDatos();
            CargarGrilla();
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (dtgconten[NroOPBancox.Name, x].Value.ToString() != "")
                {
                    if (dtgconten[okx.Name, x].Value.ToString() != "0")
                    {
                        dtgconten[okx.Name, x].Value = 0;
                    }
                }
                //Proceso de Cambio
                int tipo = (int)dtgconten[xdet.Name, x].Value;
                int id = (int)dtgconten[idx.Name, x].Value;
                int empresa = (int)dtgconten[xfkempresa.Name, x].Value;
                string cuo = dtgconten[xcuo.Name, x].Value.ToString();
                if (dtgconten[okx.Name, x].Value.ToString() == "")
                {
                    Listado List = lista.Find(cust => cust.tipo == tipo && cust.index == id && cust.fkempresa == empresa && cust.cuo == cuo);
                    lista.Remove(List);
                    dtgconten[okx.Name, x].Value = 0;
                }
                else if (dtgconten[okx.Name, x].Value.ToString() == "0")
                {
                    Listado List = lista.Find(cust => cust.tipo == tipo && cust.index == id && cust.fkempresa == empresa && cust.cuo == cuo);
                    lista.Remove(List);
                }
                else if ((int)dtgconten[okx.Name, x].Value == 1)
                {
                    if (lista.Find(cust => cust.tipo == tipo && cust.index == id && cust.fkempresa == empresa && cust.cuo == cuo) == null)
                        lista.Add(new Listado(id, tipo, empresa, cuo));
                }
            }

            int c = lista == null ? 0 : lista.Count;
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}  Seleccionados : {c}";
            //OrdernarDatos();
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x == -1)
            {
                if (dtgconten.Columns[okx.Name].Index == y)
                {
                    //ordernar Por click
                    DataView dt = TDatos.DefaultView;
                    dt.Sort = "ok desc";
                    TDatos = dt.ToTable();
                    dtgconten.EndEdit();
                }
            }
            if (x >= 0)
            {
            }
        }
        DataGridViewButtonCell Combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            //if (x >= 0)
            //{
            //    Combo = dtgconten.Rows[x].Cells[botonx.Name] as DataGridViewButtonCell;
            //    //Combo.DataSource = tipoDoc;
            //    if (Combo.Value.ToString() == "")                
            //}
        }
        frmProcesando frmproce;
        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                dtgconten.SuspendLayout();
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = "Nro de Operaciones"; string _Cabecera = "Listado de Documentos Pagados"; int[] _Columnas = new int[] { }; string _NColumna = "f";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", NameEmpresa, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;

                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)dtgconten.DataSource).Copy();
                ///Remuevo Columnas inservibles
                TableResuk.Columns.RemoveAt(13);
                TableResuk.Columns.RemoveAt(3);
                TableResuk.Columns.RemoveAt(0);
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
        private void cboEmpresa_Click(object sender, EventArgs e)
        {
            string cadena = cboEmpresa.Text;
            DataTable Table = CapaLogica.TablaEmpresa();
            if (Table.Rows.Count != cboEmpresa.Items.Count)
            {
                CapaLogica.TablaEmpresa(cboEmpresa);
                cboEmpresa.Text = cadena;
            }
        }
    }
}
