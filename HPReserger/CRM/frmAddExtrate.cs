using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using HPReserger;
using HpResergerUserControls;
using SISGEM.ModuloShedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmAddExtrate : XtraForm
    {
        public frmAddExtrate()
        {
            InitializeComponent();
        }
        public string idcliente = "";
        public int idExtrate = 0;
        private void frmAddExtrate_Load(object sender, EventArgs e)
        {
      
            
            //xProyectos.GroupIndex = 0;
            //xProyectos.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;

            CargarClientes();
            CargarExtrate();
            CargarDatosDetalle();
        }
        

        private void CargarDatosDetalle()
        {
            HpResergerNube.CRM_Usuario objclase = new HpResergerNube.CRM_Usuario();

            DataTable tusuario = objclase.GetAllUsuarios();
            repositoryItemRespondables.DataSource = tusuario;
            repositoryItemRespondables.ValueMember = "ID_Usuario";
            repositoryItemRespondables.DisplayMember = "Nombre_Completo";
            //repositoryItemRespondables.EditValue = tusuario.Rows.Count > 0 ? tusuario.Rows[0]["ID_Usuario"] : null;

            HpResergerNube.SCH_Estrate_Objetivos objclasex = new HpResergerNube.SCH_Estrate_Objetivos();
            DataTable tobjetivos = objclasex.GetEstrateObjetivosByFkIdEstrate(idExtrate);

            repositoryItemObjetivoRelacionado.DataSource = tobjetivos;
            repositoryItemObjetivoRelacionado.ValueMember = "id";
            repositoryItemObjetivoRelacionado.DisplayMember = "nombre";
            //repositoryItemObjetivoRelacionado.EditValue = tobjetivos.Rows.Count > 0 ? tobjetivos.Rows[0]["id"] : null;


            HpResergerNube.SCH_Status objclasey = new HpResergerNube.SCH_Status();
            DataTable tstatus = objclasey.GetAllStatus();

            repositoryItemStatus.DataSource = tstatus;
            repositoryItemStatus.ValueMember = "ID_Status";
            repositoryItemStatus.DisplayMember = "Detalle_Status";
            //repositoryItemStatus.EditValue = tstatus.Rows.Count > 0 ? tstatus.Rows[0]["ID_Status"] : null;

            HpResergerNube.SCH_Estrate_Objetivos_Operativos objclasedetalle = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
            DataTable tdetalleclase = objclasedetalle.GetObjetivosOperativosByFkIdNombreEstado(idExtrate, 3);

            repositoryItemProyecto.DataSource = tdetalleclase;
            repositoryItemProyecto.ValueMember = "Nombre";
            repositoryItemProyecto.DisplayMember = "Nombre";
            xProyectos.MaxWidth = 100;
            //repositoryItemStatus.EditValue = tstatus.Rows.Count > 0 ? tstatus.Rows[0]["ID_Status"] : null;

        }
        DataTable TObjetivos;
        private void CargarObejtivos()
        {
            HpResergerNube.SCH_Estrate_Objetivos objObjetivos = new HpResergerNube.SCH_Estrate_Objetivos();
            TObjetivos = objObjetivos.GetEstrateObjetivosByFkIdEstrate(idExtrate);
            if (TObjetivos.Rows.Count > 0)
            {
                GridObjetivos.DataSource = TObjetivos;
            }
            else GridObjetivos.DataSource = null;
        }
        DataTable TEstrategia;
        private void CargarEstrategias()
        {
            HpResergerNube.SCH_Estrate_Estrategia objEstrategia = new HpResergerNube.SCH_Estrate_Estrategia();
            TEstrategia = objEstrategia.GetEstrateEstrategiasByFkIdEstrate(idExtrate);
            if (TEstrategia.Rows.Count > 0)
            {
                gridEstrategias.DataSource = TEstrategia;
            }
            else gridEstrategias.DataSource = null;
        }
        DataTable TProblemas;
        private void CargarProblemas()
        {
            HpResergerNube.SCH_Estrate_Problemas objPRoblemas = new HpResergerNube.SCH_Estrate_Problemas();
            TProblemas = objPRoblemas.GetProblemasByFkIdEstrate(idExtrate);
            if (TProblemas.Rows.Count > 0)
            {
                GridProblemas.DataSource = TProblemas;
            }
            else GridProblemas.DataSource = null;
        }
        DataTable TDetalles;
        private void CargarDetalles()
        {
            HpResergerNube.SCH_Estrate_Objetivos_Operativos objObjetivosOperativos = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
            TDetalles = objObjetivosOperativos.GetObjetivosOperativosByFkIdNombreEstado(idExtrate, 1);
            if (TDetalles.Rows.Count > 0)
            {
                GridDetalle.DataSource = TDetalles;
            }
            else GridDetalle.DataSource = null;

            gridView4.ExpandAllGroups();

            CargarDatosDetalle();
        }

        private void CargarClientes()
        {
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            //cliente
            DataTable tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            ItemForID_cliente.Properties.DataSource = tcliente;
            ItemForID_cliente.Properties.DisplayMember = "nombrecompleto";
            ItemForID_cliente.Properties.ValueMember = "ID_Cliente";
            ItemForID_cliente.EditValue = tcliente.Rows.Count > 0 ? tcliente.Rows[0]["ID_Cliente"] : null;

        }
        private void ActualizarEstadoBotones()
        {
            bool isEnabled = ItemForID_cliente.EditValue != null;

            btnAddEstrategias.Enabled = isEnabled;
            btnAddObjetivos.Enabled = isEnabled;
            btnAddProblemas.Enabled = isEnabled;
            btnAddDetalles.Enabled = isEnabled;
        }
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotones();

            if (ItemForID_cliente.EditValue != null)
            {
                idcliente = ItemForID_cliente.EditValue.ToString();

            }
            else
            {
                idcliente = "";
            }
            CargarExtrate();

        }

        private void CargarExtrate()
        {

            HpResergerNube.SCH_Estrate objExtrate = new HpResergerNube.SCH_Estrate();
            DataTable TExtrate = objExtrate.GetEstratesByCliente(idcliente);
            if (TExtrate.Rows.Count > 0)
            {
                idExtrate = (int)TExtrate.Rows[0]["id"];
            }
            else { idExtrate = 0; }

            if (idExtrate != 0)
            {
                CargarEstrategias();
                CargarObejtivos();
                CargarProblemas();
                CargarDetalles();
            }
            else
            {
                gridEstrategias.DataSource = null;
                GridDetalle.DataSource = null;
                GridProblemas.DataSource = null;
                GridObjetivos.DataSource = null;
            }
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnAddEstrategias_Click(object sender, EventArgs e)
        {
            using (DialogForm dialog = new DialogForm("Agregar Estrategia", "Nombre Estrategia", DialogForm.Tipo.estrategia, idcliente, idExtrate))
            {
                dialog.Icon = this.Icon;
                dialog.ShowDialog();
                idExtrate = dialog._fkid;
            }
            CargarEstrategias();
        }

        private void btnAddObjetivos_Click(object sender, EventArgs e)
        {
            using (DialogForm dialog = new DialogForm("Agregar Objetivo", "Nombre Objetivo", DialogForm.Tipo.objetivo, idcliente, idExtrate))
            {
                dialog.Icon = this.Icon;
                dialog.ShowDialog();
                idExtrate = dialog._fkid;
            }
            CargarObejtivos();
        }

        private void btnAddProblemas_Click(object sender, EventArgs e)
        {
            using (DialogForm dialog = new DialogForm("Agregar Problema", "Nombre Problema", DialogForm.Tipo.problema, idcliente, idExtrate))
            {
                dialog.Icon = this.Icon;
                dialog.ShowDialog();
                idExtrate = dialog._fkid;
            }
            CargarProblemas();
        }

        private void btnAddDetalles_Click(object sender, EventArgs e)
        {
            if (idExtrate != 0)
            {
                frmAddObjetivosProyectos frm = new frmAddObjetivosProyectos(idcliente, idExtrate);
                frm.ShowDialog();

                CargarDetalles();
            }
            else { XtraMessageBox.Show("Debe primero Ingresar Objetivos", "Error"); }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fila = e.RowHandle;
                object idValor = gridView1.GetRowCellValue(fila, "id");
                // Obtener el valor de la celda que se ha editado
                object nuevoValor = e.Value;

                // Obtener la fila y columna de la celda que se ha editado
                string columna = e.Column.FieldName;

                HpResergerNube.SCH_Estrate_Estrategia obclase = new HpResergerNube.SCH_Estrate_Estrategia();
                obclase.ID = (int)idValor;
                obclase.Nombre = nuevoValor.ToString();
                // Intentar actualizar la estrategia
                if (!obclase.UpdateEstrateEstrategiaNombre(obclase))
                {
                    // Mostrar mensaje de error
                    XtraMessageBox.Show(
                        $"Hubo un error al guardar los cambios.",
                        "Error al Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fila = e.RowHandle;
                object idValor = gridView2.GetRowCellValue(fila, "id");
                // Obtener el valor de la celda que se ha editado
                object nuevoValor = e.Value;

                // Obtener la fila y columna de la celda que se ha editado
                string columna = e.Column.FieldName;

                HpResergerNube.SCH_Estrate_Objetivos obclase = new HpResergerNube.SCH_Estrate_Objetivos();
                obclase.ID = (int)idValor;
                obclase.Nombre = nuevoValor.ToString();
                // Intentar actualizar la estrategia
                if (!obclase.UpdateEstrateObjetivoNombre(obclase))
                {
                    // Mostrar mensaje de error
                    XtraMessageBox.Show(
                        $"Hubo un error al guardar los cambios.",
                        "Error al Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fila = e.RowHandle;
                object idValor = gridView3.GetRowCellValue(fila, "id");
                // Obtener el valor de la celda que se ha editado
                object nuevoValor = e.Value;

                // Obtener la fila y columna de la celda que se ha editado
                string columna = e.Column.FieldName;

                HpResergerNube.SCH_Estrate_Problemas obclase = new HpResergerNube.SCH_Estrate_Problemas();
                obclase.ID = (int)idValor;
                obclase.Nombre = nuevoValor.ToString();
                // Intentar actualizar la estrategia
                if (!obclase.UpdateProblemaNombre(obclase))
                {
                    // Mostrar mensaje de error
                    XtraMessageBox.Show(
                        $"Hubo un error al guardar los cambios.",
                        "Error al Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fila = e.RowHandle;
                object idValor = gridView4.GetRowCellValue(fila, "id");
                object nombre = gridView4.GetRowCellValue(fila, "Nombre");
                object DetalleObjetivo = gridView4.GetRowCellValue(fila, "DetalleObjetivo");
                object status = gridView4.GetRowCellValue(fila, "status");
                object fechaRecordatorio = gridView4.GetRowCellValue(fila, "fechaRecordatorio");
                object comentario = gridView4.GetRowCellValue(fila, "comentario");
                object objetivorelacionado = gridView4.GetRowCellValue(fila, "objetivorelacionado");
                object responsable = gridView4.GetRowCellValue(fila, "responsable");

                HpResergerNube.SCH_Estrate_Objetivos_Operativos obclase = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
                obclase.ID = (int)idValor;
                obclase.Nombre = nombre.ToString();
                obclase.Comentario = comentario.ToString();
                obclase.DetalleObjetivo = DetalleObjetivo.ToString();
                obclase.FechaRecordatorio = (DateTime)fechaRecordatorio;
                obclase.ObjetivoRelacionado = (int)objetivorelacionado;
                obclase.Responsable = responsable.ToString();
                obclase.Status = status.ToString();
                // Intentar actualizar la estrategia
                if (!obclase.UpdateObjetivoOperativoGrilla(obclase))
                {
                    // Mostrar mensaje de error
                    XtraMessageBox.Show(
                        $"Hubo un error al guardar los cambios.",
                        "Error al Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        frmProcesando frmproce;
        DataTable TTDetalle;
        SaveFileDialog saveFileDialog;
        private void barButtonExportaToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ItemForID_cliente.EditValue != null)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Title = "Guardando Estrategia";
                    saveFileDialog.FileName = $"{DateTime.Now.ToString("yyyy.MM.dd")} Control de Objetivos.xlsx"; 
                                       

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    Cursor = Cursors.WaitCursor;

                    HpResergerNube.SCH_Estrate_Objetivos_Operativos obclase = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
                    TTDetalle = obclase.GetObjetivosOperativosByFkIdNombreEstadoAgrúpados(idExtrate, 1);

                    // Mostrar el formulario de procesamiento
                    frmproce = new frmProcesando();
                    frmproce.Show();

                    // Iniciar el trabajo en segundo plano
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                // Mostrar mensaje de error si no se ha creado un Estrate
                XtraMessageBox.Show(
                    "No se puede exportar a Excel porque no existe un Estrate creado. Por favor, asegúrese de crear un Estrate antes de intentar exportar.",
                    "Exportación a Excel - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (0 == 0)
            {

                FileInfo newFile = new FileInfo(saveFileDialog.FileName);
                if (HPResergerFunciones.Utilitarios.EstaArchivoAbierto(newFile.FullName))
                {
                    XtraMessageBox.Show($"El archivo '{newFile.FullName}' está actualmente abierto. Por favor, cierre el archivo e inténtelo de nuevo.", "Archivo Abierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                string FechaGenerado = DateTime.Now.ToShortDateString();
                _NombreHoja = $"Estrategias".ToUpper();
                _Cabecera = "Estrategias";
                _Columnas = new int[] { }; _NColumna = "F";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", "CONTROL ACCIONES ESTRATEGICAS".ToUpper(), 10, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", "v 1.00".ToUpper(), 10, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", $"{_NColumna}3", "Cliente".ToUpper(), 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", $"{_NColumna}4", ItemForID_cliente.Text, 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));

                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.FromArgb(220, 230, 241), Configuraciones.FuenteReportesTahoma8, Color.Black);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.FromArgb(78, 129, 189), Configuraciones.FuenteReportesTahoma8, Color.White);

                int posheader = 6;

                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"{_NColumna}{posheader}", "1.ESTRATEGIA EMPRESA", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                if (TEstrategia != null)
                {
                    foreach (DataRow item in TEstrategia.Rows)
                    {
                        posheader++;
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"{_NColumna}{posheader}", item["nombre"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                    }
                }
                posheader++;
                posheader++;
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"{_NColumna}{posheader}", "2. OBJETIVOS Y PROBLEMAS ESTRATEGICOS", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));

                posheader++;
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"c{posheader}", "Objetivos principales", 8, false, false, Color.Blue, Color.White, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{posheader}", $"f{posheader}", "Problemas principales", 8, false, false, Color.Red, Color.White, Configuraciones.FuenteReportesTahoma8));

                posheader++;
                int posObjetivos = posheader;
                int posProblemas = posheader;

                if (TObjetivos != null)
                {
                    foreach (DataRow item in TObjetivos.Rows)
                    {
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posObjetivos}", $"a{posObjetivos}", item["nombre"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        posObjetivos++;
                    }
                }

                if (TProblemas != null)
                {
                    foreach (DataRow item in TProblemas.Rows)
                    {
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{posProblemas}", $"f{posProblemas}", item["nombre"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        posProblemas++;
                    }
                }

                posheader = posObjetivos > posProblemas ? posObjetivos : posProblemas;
                posheader++;
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"{_NColumna}{posheader}", "3. OBJETIVOS OPERATIVOS", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                if (TTDetalle != null)
                {
                    string titulo = "";
                    foreach (DataRow item in TTDetalle.Rows)
                    {
                        if (titulo == "" || titulo != item["NombreProyecto"].ToString())
                        {
                            posheader++;
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"{_NColumna}{posheader}", item["NombreProyecto"].ToString(), 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            posheader++;
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"a{posheader}", "Detalle de Objetivos", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));

                            titulo = item["NombreProyecto"].ToString();

                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"a{posheader}", "Detalle de Objetivos", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{posheader}", $"b{posheader}", "Status", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{posheader}", $"c{posheader}", "Fecha de Recordatorio", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{posheader}", $"d{posheader}", "Comentario", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{posheader}", $"e{posheader}", "Objetivo Relacionado", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{posheader}", $"f{posheader}", "Responsable", 8, false, false, Color.Cyan, Color.Black, Configuraciones.FuenteReportesTahoma8));

                        }
                        posheader++;
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{posheader}", $"a{posheader}", item["DetalleObjetivo"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{posheader}", $"b{posheader}", item["Status"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{posheader}", $"c{posheader}", ((DateTime)item["fechaRecordatorio"]).ToShortDateString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{posheader}", $"d{posheader}", item["comentario"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{posheader}", $"e{posheader}", item["NombreObjetivo"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{posheader}", $"f{posheader}", item["nombres_responsables"].ToString(), 8, false, false, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma8));

                        //posheader++;

                    }
                }

                posheader++;

                //int PosInicialGrilla = 6;
                //DataTable TablaExportar = new DataTable();
                //TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                ////Remuevo Columnas inservibles               
                ////TablaExportar.Columns.RemoveAt(0);
                ////
                ////
                //foreach (DataColumn item in TablaExportar.Columns)
                //    item.ColumnName = dtgconten.Columns[item.Ordinal].HeaderText;

                //if (chkCarpeta.Checked)
                //{
                //    string Carpeta = folderBrowserDialog1.SelectedPath;
                //    string valor = Carpeta + @"\";
                //    //ELiminamos el Excel Antiguo
                //    string num = rb2digitos.Checked ? "2" : "7";
                //    string NameFile = valor + $"BC {num} {NameEmpresa } {FechaGenerado}.xlsx";
                //    File.Delete(NameFile);
                //    File.Exists(NameFile);
                //    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaExportar, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, 1, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "");
                //    msgOK($"Archivo Grabado en \n{folderBrowserDialog1.SelectedPath}");

                //}
                //else
                HPResergerFunciones.Utilitarios.ExportarAExcelsoloDatos(new DataTable(), CeldaCabecera, CeldaDefault, newFile.FullName, _Cabecera, Celdas, posheader, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6 }, "");

            }
        }
        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = $"{DateTime.Now.ToString("yyyy.MM.dd")} Control de Objetivos.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Crear un sistema de impresión
                        PrintingSystem printingSystem = new PrintingSystem();

                        // Crear un enlace compuesto
                        CompositeLink compositeLink = new CompositeLink(printingSystem);

                        // Ajustar la apariencia de los gridView1 para la exportación
                        gridView4.AppearancePrint.Row.Font = new Font("Tahoma", 5);
                     
                        gridView4.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 5);
                        gridView4.AppearancePrint.GroupRow.Font = new Font("Tahoma", 5);

                        // Habilitar WordWrap para las celdas
                        gridView4.OptionsPrint.PrintPreview = true;
                        gridView4.OptionsPrint.UsePrintStyles = true;

                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView4.Columns)
                        {
                            column.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                        }
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView4.Columns)
                        {
                            column.BestFit();
                        }

                        // Crear enlaces para cada GridControl y añadirlos al enlace compuesto
                        PrintableComponentLink link1 = new PrintableComponentLink(printingSystem)
                        {
                            Component = gridEstrategias,
                            Landscape = true, // Ajustar a horizontal
                            PaperKind = System.Drawing.Printing.PaperKind.A4 // Ajustar tamaño de papel
                        };

                        PrintableComponentLink link2 = new PrintableComponentLink(printingSystem)
                        {
                            Component = GridObjetivos,
                            Landscape = true, // Ajustar a horizontal
                            PaperKind = System.Drawing.Printing.PaperKind.A4 // Ajustar tamaño de papel
                        };

                        PrintableComponentLink link3 = new PrintableComponentLink(printingSystem)
                        {
                            Component = GridProblemas,
                            Landscape = true, // Ajustar a horizontal
                            PaperKind = System.Drawing.Printing.PaperKind.A4 // Ajustar tamaño de papel
                        };

                        PrintableComponentLink link4 = new PrintableComponentLink(printingSystem)
                        {
                            Component = GridDetalle,
                            Landscape = true, // Ajustar a horizontal
                            PaperKind = System.Drawing.Printing.PaperKind.A4 // Ajustar tamaño de papel
                        };


                        // Crear un enlace para añadir texto y saltos de línea
                        Link customTextLink1 = new Link();
                        customTextLink1.CreateDetailArea += (s, ea) =>
                        {
                            BrickGraphics graphics = ea.Graph;

                            // Añadir texto con fuente y color personalizado
                            graphics.Font = new Font("Tahoma", 8, FontStyle.Bold);
                            graphics.BackColor = Color.White;
                            graphics.ForeColor = Color.Black;
                            graphics.DrawString($"Cliente: {ItemForID_cliente.Text}", new RectangleF(0, 0, 500, 20));
                            graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio
                        };

                        Link customTextLink2 = new Link();
                        customTextLink2.CreateDetailArea += (s, ea) =>
                        {
                            BrickGraphics graphics = ea.Graph;

                            // Añadir texto con fuente y color personalizado
                            graphics.Font = new Font("Tahoma", 8, FontStyle.Bold);
                            graphics.BackColor = Color.White;
                            graphics.ForeColor = Color.Black;
                            graphics.DrawString("Listado de Objetivos", new RectangleF(0, 0, 500, 20));
                            graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio
                        };

                        Link customTextLink3 = new Link();
                        customTextLink3.CreateDetailArea += (s, ea) =>
                        {
                            BrickGraphics graphics = ea.Graph;

                            // Añadir texto con fuente y color personalizado
                            graphics.Font = new Font("Tahoma", 8, FontStyle.Bold);
                            graphics.BackColor = Color.White;
                            graphics.ForeColor = Color.Black;
                            graphics.DrawString("Listado de Problemas", new RectangleF(0, 0, 500, 20));
                            graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio
                        };

                        Link customTextLink4 = new Link();
                        customTextLink4.CreateDetailArea += (s, ea) =>
                        {
                            BrickGraphics graphics = ea.Graph;

                            // Añadir texto con fuente y color personalizado
                            graphics.Font = new Font("Tahoma", 8, FontStyle.Bold);
                            graphics.BackColor = Color.White;
                            graphics.ForeColor = Color.Black;
                            graphics.DrawString("Detalle", new RectangleF(0, 0, 500, 20));
                            graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio
                        };

                        // Añadir los enlaces al enlace compuesto
                        compositeLink.Links.Add(customTextLink1);
                        compositeLink.Links.Add(link1);
                        compositeLink.Links.Add(customTextLink2);
                        compositeLink.Links.Add(link2);
                        compositeLink.Links.Add(customTextLink3);
                        compositeLink.Links.Add(link3);
                        compositeLink.Links.Add(customTextLink4);
                        compositeLink.Links.Add(link4);

                        // Configurar la orientación horizontal y márgenes para el CompositeLink
                        compositeLink.Landscape = true;
                        compositeLink.Margins = new Margins(50, 50, 50, 50); // Ajustar márgenes

                        // Crear el documento
                        compositeLink.CreateDocument();

                        // Exportar el documento a PDF
                        compositeLink.PrintingSystem.ExportToPdf(filePath);

                        //MessageBox.Show($"El archivo PDF se ha guardado exitosamente en {filePath}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Abrir el archivo PDF generado
                        System.Diagnostics.Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        //        saveFileDialog.FilterIndex = 1;
        //        saveFileDialog.RestoreDirectory = true;
        //        saveFileDialog.Title = "Save PDF File";

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string filePath = saveFileDialog.FileName;

        //            try
        //            {
        //                // Crear un sistema de impresión
        //                PrintingSystem printingSystem = new PrintingSystem();

        //                // Crear un enlace compuesto
        //                CompositeLink compositeLink = new CompositeLink(printingSystem);

        //                // Crear enlaces para cada GridControl y añadirlos al enlace compuesto
        //                PrintableComponentLink link1 = new PrintableComponentLink(printingSystem);
        //                link1.Component = gridEstrategias;

        //                PrintableComponentLink link2 = new PrintableComponentLink(printingSystem);
        //                link2.Component = GridObjetivos;

        //                PrintableComponentLink link3 = new PrintableComponentLink(printingSystem);
        //                link3.Component = GridProblemas;

        //                PrintableComponentLink link4 = new PrintableComponentLink(printingSystem);
        //                link4.Component = GridDetalle;

        //                // Crear un enlace para añadir texto y saltos de línea
        //                Link customTextLink1 = new Link();
        //                customTextLink1.CreateDetailArea += (s, ea) =>
        //                {
        //                    BrickGraphics graphics = ea.Graph;

        //                        // Añadir texto y salto de línea
        //                        graphics.DrawString($"Cliente: {ItemForID_cliente.Text}", new RectangleF(0, 0, 500, 20));
        //                    graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio


        //                    };

        //                Link customTextLink2 = new Link();
        //                customTextLink2.CreateDetailArea += (s, ea) =>
        //                {
        //                    BrickGraphics graphics = ea.Graph;

        //                    // Añadir texto y salto de línea

        //                    graphics.DrawString("Listado de Objetivos", new RectangleF(0, 0, 500, 20));
        //                    graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio


        //                };

        //                Link customTextLink3 = new Link();
        //                customTextLink3.CreateDetailArea += (s, ea) =>
        //                {
        //                    BrickGraphics graphics = ea.Graph;

        //                    // Añadir texto y salto de línea                   

        //                    graphics.DrawString("Listado de Problemas", new RectangleF(0, 0, 500, 20));
        //                    graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio

        //                };

        //                Link customTextLink4 = new Link();
        //                customTextLink4.CreateDetailArea += (s, ea) =>
        //                {
        //                    BrickGraphics graphics = ea.Graph;

        //                    // Añadir texto y salto de línea                   

        //                    graphics.DrawString("Detalle", new RectangleF(0, 0, 500, 20));
        //                    graphics.DrawEmptyBrick(new RectangleF(0, 20, 500, 20)); // Añadir espacio

        //                };
        //                // Añadir los enlaces al enlace compuesto
        //                compositeLink.Links.Add(customTextLink1);
        //                compositeLink.Links.Add(link1);
        //                compositeLink.Links.Add(customTextLink2);
        //                compositeLink.Links.Add(link2);
        //                compositeLink.Links.Add(customTextLink3);
        //                compositeLink.Links.Add(link3);
        //                compositeLink.Links.Add(customTextLink4);
        //                compositeLink.Links.Add(link4);

        //                // Crear el documento
        //                compositeLink.CreateDocument();

        //                // Exportar el documento a PDF
        //                compositeLink.PrintingSystem.ExportToPdf(filePath);

        //                MessageBox.Show($"El archivo PDF se ha guardado exitosamente en {filePath}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Ocurrió un error al guardar el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }

        //}
    }
}
