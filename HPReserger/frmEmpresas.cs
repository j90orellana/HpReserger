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
    public partial class frmEmpresas : FormGradient
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        string tabla = "TBL_Cargo";
        string campo = "Cargo";
        string id = "Id_Cargo";
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            txtruc.Enabled = a;
            btnborrar.Enabled = !a;
            txtbuscar.Enabled = !a;
            cbotipo.Enabled = a;
            txtnombre.Enabled = a;
            txtdireccion.Enabled = a;
            txtnroid.Enabled = a;
            cbodep.Enabled = a;
            cbodis.Enabled = a;
            cbopro.Enabled = a;
            cbosector.Enabled = a;
            cbotipo.Enabled = a;
            cboseguro.Enabled = a;
            cbonombre.Enabled = a;
            btnsector.Enabled = a;
            btnciaseguro.Enabled = a;
            chkStock.Enabled = a;
        }
        public void CargarCombos(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
        }
        private void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        DataTable Tdatos;
        public void CargarDatos()
        {
            Tdatos = CapaLogica.InsertarActualizarListarEmpresas("1", 0, "", "", 0, "", 0, 0, 0, 0, "", 0, 0, 0);
            dtgconten.DataSource = Tdatos;
            dtgconten.Focus();
            lbltotalregistros.Text = $"Total Registros: {dtgconten.RowCount}";
        }
        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarSectores(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CapaLogica.getCargoTipoContratacion("Codigo_Sector_Empresarial", "Desc_Sector_Empresarial", "TBL_Sector_Empresarial");
        }
        public void CargarSeguros(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CapaLogica.getCargoTipoContratacion("ID_Eps", "Empresa_Eps", "TBL_Empresa_Eps");
        }
        public void CargarTipoid(ComboBox combito)
        {
            CapaLogica.TablaTipoID(cbotipo);
        }
        public void CargarDepartamento(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CapaLogica.getCargoTipoContratacion("Cod_Dept", "Departamento", "TBL_Departamento");
        }
        public void CargarProvincia(ComboBox combito, int valor)
        {
            combito.DisplayMember = "PROVINCIA";
            combito.ValueMember = "CODIGOPROVINCIA";
            combito.DataSource = CapaLogica.ListarProvincia(valor);
        }
        public void CargarDistrito(ComboBox combito, int valor, int valor2)
        {
            combito.DisplayMember = "DISTRITO";
            combito.ValueMember = "CODIGODISTRITO";
            combito.DataSource = CapaLogica.ListarDistrito(valor, valor2);
        }
        public void CargarEmpleado(ComboBox combito)
        {
            combito.DisplayMember = "empleado";
            combito.ValueMember = "tipo";
            combito.DataSource = CapaLogica.BuscarEmpleadoActivo();
        }

        private void cbodep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodep.SelectedIndex >= 0)
                CargarProvincia(cbopro, (int)cbodep.SelectedValue);
        }

        private void cbopro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopro.SelectedIndex >= 0)
                CargarDistrito(cbodis, (int)cbodep.SelectedValue, (int)cbopro.SelectedValue);
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                CargarSectores(cbosector);
                CargarSeguros(cboseguro);
                CargarTipoid(cbotipo);
                CargarDepartamento(cbodep);
                CargarEmpleado(cbonombre);

                btnmodificar.Enabled = true;
                txtruc.Text = dtgconten["ruc", e.RowIndex].Value.ToString();
                txtnombre.Text = dtgconten["empresa", e.RowIndex].Value.ToString();
                txtdireccion.Text = dtgconten["direccion", e.RowIndex].Value.ToString();
                cbotipo.Text = dtgconten[tipodni.Name, e.RowIndex].Value.ToString();
                txtnroid.Text = dtgconten["nroid", e.RowIndex].Value.ToString();
                cbonombre.Text = dtgconten["representante", e.RowIndex].Value.ToString();
                cbodep.Text = dtgconten["dep", e.RowIndex].Value.ToString();
                cbopro.Text = dtgconten["pro", e.RowIndex].Value.ToString();
                cbodis.Text = dtgconten["dis", e.RowIndex].Value.ToString();
                cbosector.Text = dtgconten["sector", e.RowIndex].Value.ToString();
                cboseguro.SelectedValue = dtgconten["cia", e.RowIndex].Value.ToString();
                btneliminar.Enabled = true;
                btnexportarExcel.Enabled = true;
                chkStock.Checked = dtgconten[xStock.Name, e.RowIndex].Value.ToString() == "SI" ? true : false;
            }
            else
            {
                btnexportarExcel.Enabled = false;
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarSectores(cbosector);
            CargarSeguros(cboseguro);
            CargarTipoid(cbotipo);
            CargarDepartamento(cbodep);
            CargarEmpleado(cbonombre);
            estado = 1;
            iniciar(true);
            txtnombre.Text = txtruc.Text = txtdireccion.Text = txtnroid.Text = "";
            //DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
            //txtaporte.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtnombre.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                iniciar(false);
                estado = 0;
            }
            CargarDatos();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        frmProcesando frmproce;
        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (Tdatos.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    frmproce = new HPReserger.frmProcesando();
                    frmproce.Show();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }

                    else
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                Cursor = Cursors.Default;
            }
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtnombre.Focus();
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex >= 0)
            {
                cbonombre.SelectedValue = cbotipo.SelectedValue.ToString() + "/" + txtnroid.Text;
                txtnroid.MaxLength = (int)((DataTable)cbotipo.DataSource).Rows[cbotipo.SelectedIndex]["leng"];
            }
        }

        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            cbotipo_SelectedIndexChanged(sender, e);
        }

        private void cbonombre_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbonombre.SelectedIndex >= 0)
            {
                string valor = cbonombre.SelectedValue.ToString();
                cbotipo.SelectedValue = valor.Substring(0, 1);
                txtnroid.Text = valor.Substring(2, valor.Length - 2);
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtruc.Text))
            {
                msg("Ingresé Ruc");
                txtruc.Focus();
                return;
            }
            if (txtruc.Text.Length != 11)
            {
                msg("El Ruc Debe Tener 11 Digitos");
                txtruc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                msg("Ingresé Nombre");
                txtnombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdireccion.Text))
            {
                msg("Ingresé Dirección");
                txtdireccion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnroid.Text))
            {
                msg("Ingresé Id Del Representante");
                txtnroid.Focus();
                return;
            }
            //if (cbonombre.SelectedIndex < 0)
            //{
            //    Msg("Ingresé Id Del Representante");
            //    txtnroid.Focus();
            //    return;
            //}
            if (cboseguro.SelectedIndex < 0)
            {
                msg("Seleccione Compañia de Seguro");
                cboseguro.Focus();
                return;
            }
            int Stock = chkStock.Checked ? 1 : 0;
            /* decimal aportex = decimal.Parse(txtaporte.Text) / 100;
             decimal segurox = decimal.Parse(txtseguro.Text) / 100;
             decimal comisionx = decimal.Parse(txtcomision.Text) / 100;*/
            if (estado == 1)
            {
                //nuevo
                /* if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                 {
                     Msg("Ingresé Nombre del Afp");
                     txtgerencia.Focus();
                     return;
                 }*/
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["ruc"].Value.ToString())
                    {
                        msg("La Empresa ya Existe");
                        txtruc.Focus();
                        return;
                    }
                }
                //Insertando;
                CapaLogica.InsertarActualizarListarEmpresas(txtruc.Text, 1, txtnombre.Text, txtruc.Text, (int)cbosector.SelectedValue, txtdireccion.Text, (int)cbodep.SelectedValue,
                    (int)cbopro.SelectedValue, (int)cbodis.SelectedValue, (int)cbotipo.SelectedValue, txtnroid.Text, (int)cboseguro.SelectedValue, frmLogin.CodigoUsuario, Stock);
                HPResergerFunciones.frmInformativo.MostrarDialog("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            int x = dtgconten.CurrentCell.RowIndex;
            if (estado == 2)
            {
                //Modificar
                /*  if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                  {
                      Msg("Ingresé Nombre del Afp");
                      txtgerencia.Focus();
                      return;
                  }*/
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["ruc"].Value.ToString() && fila != x)
                    {
                        msg("La Empresa ya Existe");
                        txtruc.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CapaLogica.InsertarActualizarListarEmpresas(dtgconten["ruc", x].Value.ToString(), 2, txtnombre.Text, txtruc.Text, (int)cbosector.SelectedValue, txtdireccion.Text,
                    (int)cbodep.SelectedValue, (int)cbopro.SelectedValue, (int)cbodis.SelectedValue, (int)cbotipo.SelectedValue, txtnroid.Text, (int)cboseguro.SelectedValue, frmLogin.CodigoUsuario, Stock);
                HPResergerFunciones.frmInformativo.MostrarDialog("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.InsertarActualizarListarEmpresas("1", 10, txtbuscar.Text, "", 0, "", 0, 0, 0, 0, "", 0, 0, 0);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txtnombre, 100);
        }

        private void txtnroid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtnroid_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtnroid, 11);
        }

        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }

        private void btnsector_Click(object sender, EventArgs e)
        {
            frmSectorEmpresarial frmsector = new frmSectorEmpresarial();
            frmsector.Consulta = true;
            frmsector.Icon = Icon;
            frmsector.btnaceptar.Enabled = true;
            if (frmsector.ShowDialog() == DialogResult.OK)
            {
                CargarSectores(cbosector);
                cbosector.SelectedValue = frmsector.estado;
            }
        }

        private void btnciaseguro_Click(object sender, EventArgs e)
        {
            frmEmpresaEps frmempresaeps = new frmEmpresaEps();
            frmempresaeps.Consulta = true;
            frmempresaeps.Icon = Icon;
            frmempresaeps.btnaceptar.Enabled = true;
            if (frmempresaeps.ShowDialog() == DialogResult.OK)
            {
                CargarSeguros(cboseguro);
                cboseguro.SelectedValue = frmempresaeps.estado;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Tdatos.Rows.Count > 0)
            {
                //DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL                
                List<string> ListCuentas = new List<string>();
                //AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                DataView dv = Tdatos.AsDataView();
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //
                string EmpresaValor = Configuraciones.ValidarRutaValida("");
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                string directorio = (Carpeta + @"\" + EmpresaValor).Replace(" ", "_");
                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);
                //}
                string NameFile = "";
                NameFile = valor + $"Listado Empresas {EmpresaValor}.xlsx";
                //ELiminamos el Excel Antiguo
                try
                {
                    if (File.Exists(NameFile)) File.Delete(NameFile);
                }
                catch { msgError("El Archivo Esta Abierto"); }
                //DEFINICIONES
                int i = 0; //posicion de la hoja no  es index
                int Hoja = 0;
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackAlterno, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackColumna, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeColumna);
                //RECORREMOS EL RANGO DE PERIODOS QUE SE INGRESO               
                i = 0;
                Hoja++;
                String _NombreHoja = $"Listado de Empresas";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"R{1 + i}", "Listado de Empresas", 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{2 + i}", $"R{2 + i}", "Detalle de las Empresas", 9, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{4 + i}", $"R{4 + i}", ($"COSTO Y DEPRECIACIÓN ACUMULADA AL {FechaTempFinMes.ToString("dd 'DE' MMMM yyyy")}").ToUpper(), 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                DataTable TResult = dv.ToTable();
                Configuraciones.QuitarColumnas(TResult, new int[] { 3, 5, 6, 7, 8, 10, 11, 12, 19 });
                Configuraciones.CambiarNombreColumnsTablaGrilla(TResult, dtgconten.Columns);
                int FilCabecera = 5;
                foreach (DataColumn item in TResult.Columns)
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"{char.ConvertFromUtf32(65 + i)}{FilCabecera}", $"{char.ConvertFromUtf32(65 + i++)}{FilCabecera}", item.ColumnName, 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, FilCabecera, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 5, 7, 8, 9, 10, 11, 12, 13 }, "", true);
                //Agregamos un MES  

                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
    }
}
