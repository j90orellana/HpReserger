using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloShedule
{
    public partial class frmAgendarCita : XtraForm
    {
        private int fkid;
        private int idExtrate;
        private string idcliente;
        public int idAgenda { get; internal set; }

        public frmAgendarCita()
        {
            InitializeComponent();
        }

        private void frmAgendarCita_Load(object sender, EventArgs e)
        {

            dtpFechaReunion.EditValue = DateTime.Now;
            //dtpFechaSeguimiento.EditValue = DateTime.Now.AddHours(1);
            if (idAgenda != 0)
            {
                ItemForID_cliente.Enabled = false;
            }

            CargarCombos();
        }

        private void CargarCombos()
        {
            HpResergerNube.SCH_Nivel objnivel = new HpResergerNube.SCH_Nivel();
            DataTable Tnivel = objnivel.GetAllNiveles();

            //NIVEL
            repositoryItemSearchLookUpEdit1.DataSource = Tnivel;
            repositoryItemSearchLookUpEdit1.DisplayMember = "Detalle_nivel";
            repositoryItemSearchLookUpEdit1.ValueMember = "ID_NIVEL";
            repositoryItemSearchLookUpEdit1.NullText = Tnivel.Rows.Count > 0 ? Tnivel.Rows[0]["Detalle_nivel"].ToString() : null;

            //CLIENTE
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            ItemForID_cliente.Properties.DataSource = tcliente;
            ItemForID_cliente.Properties.DisplayMember = "nombrecompleto";
            ItemForID_cliente.Properties.ValueMember = "ID_Cliente";
            ItemForID_cliente.EditValue = tcliente.Rows.Count > 0 ? tcliente.Rows[0]["ID_Cliente"] : null;

            ItemForID_cliente.Properties.View.Columns.Clear();
            ItemForID_cliente.Properties.View.Columns.AddVisible("ID_Cliente", "ID");
            ItemForID_cliente.Properties.View.Columns.AddVisible("ID_Numero_Doc", "Numero Doc");
            ItemForID_cliente.Properties.View.Columns.AddVisible("nombrecompleto", "Nombre Completo");
            ItemForID_cliente.Properties.View.BestFitColumns();

            HpResergerNube.CRM_Usuario ousuarios = new HpResergerNube.CRM_Usuario();
            DataTable Tusuario = ousuarios.GetAllUsuarios();
            repositoryItemCheckedComboBoxEdit1.DataSource = Tusuario;
            repositoryItemCheckedComboBoxEdit1.ValueMember = "ID_Usuario";
            repositoryItemCheckedComboBoxEdit1.DisplayMember = "Nombre_Completo";
            repositoryItemCheckedComboBoxEdit1.NullText = Tusuario.Rows.Count > 0 ? Tusuario.Rows[0]["Nombre_Completo"].ToString() : null;


            HpResergerNube.SCH_Status ostatus = new HpResergerNube.SCH_Status();
            DataTable tstatus = ostatus.GetAllStatus();
            repositoryItemSearchLookUpEdit3.DataSource = tstatus;
            repositoryItemSearchLookUpEdit3.ValueMember = "ID_Status";
            repositoryItemSearchLookUpEdit3.DisplayMember = "Detalle_Status";
            repositoryItemSearchLookUpEdit3.NullText = tstatus.Rows.Count > 0 ? tstatus.Rows[0]["Detalle_Status"].ToString() : null;
        }

        private void RecargarContacto()
        {
            // Crear instancia del repositorio de contactos
            HpResergerNube.CRM_ContactoRepository ocontacto = new HpResergerNube.CRM_ContactoRepository();
            if (ItemForID_cliente.EditValue != null)
            {
                // Obtener los contactos del cliente
                DataTable contactos = ocontacto.GetContactosPorCliente(ItemForID_cliente.EditValue.ToString());

                //// Verificar si se encontraron contactos
                if (contactos.Rows.Count > 0)
                {
                    //    // Configurar el control de edición de ID_Contacto
                    ID_ContactoTextEdit.Properties.DataSource = contactos;
                    ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
                    ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
                    //ID_ContactoTextEdit.EditValue = contactos.Rows[0]["ID_Contacto"];
                    //    // Seleccionar valores por checked
                    //    ID_ContactoTextEdit.SuspendLayout();
                    //    foreach (DataRow row in cokntactos.Rows)
                    //    {
                    //        //if ((int)row["ID"] == 1 || (int)row["ID"] == 3) // Selecciona las opciones con ID 1 y 3
                    //        if (row["ID_Contacto"].ToString() == "C1217" || row["ID_Contacto"].ToString() == "C1218")
                    //        {
                    //            ID_ContactoTextEdit.Properties.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(row["ID_Contacto"], CheckState.Checked));
                    //        }
                    //        else
                    //        {
                    //            ID_ContactoTextEdit.Properties.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(row["ID_Contacto"], CheckState.Unchecked));
                    //        }
                    //    }


                    repositoryItemCheckedComboBoxEdit2.DataSource = contactos;
                    repositoryItemCheckedComboBoxEdit2.ValueMember = "ID_Contacto";
                    repositoryItemCheckedComboBoxEdit2.DisplayMember = "NombreCompleto";
                    repositoryItemCheckedComboBoxEdit2.NullText = contactos.Rows[0]["NombreCompleto"].ToString();

                    //Configurar las columnas visibles en la vista del control de edición de ID_Contacto
                    //repositoryItemCheckedComboBoxEdit2.View.Columns.Clear();
                    //repositoryItemCheckedComboBoxEdit2.View.Columns.AddVisible("ID_Contacto", "Código");
                    //repositoryItemCheckedComboBoxEdit2.View.Columns.AddVisible("Telefono1", "Telefono");
                    //repositoryItemCheckedComboBoxEdit2.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");

                    //cboResponsableCliente.Properties.View.Columns.AddVisible("Cargo", "Cargo");
                    //cboResponsableCliente.Properties.View.Columns.AddVisible("email1", "Email");
                    //cboResponsableCliente.Properties.View.BestFitColumns();



                    //Configurar las columnas visibles en la vista del control de edición de ID_Contacto
                    //cboResponsableOficina.Properties.View.Columns.Clear();
                    //cboResponsableOficina.Properties.View.Columns.AddVisible("ID_Contacto", "Código");
                    //cboResponsableOficina.Properties.View.Columns.AddVisible("Telefono1", "Telefono");
                    //cboResponsableOficina.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");

                    //cboResponsableOficina.Properties.View.Columns.AddVisible("Cargo", "Cargo");
                    //cboResponsableOficina.Properties.View.Columns.AddVisible("email1", "Email");
                    //cboResponsableOficina.Properties.View.BestFitColumns();
                }
                else
                {
                    // Limpiar el control de edición de ID_Contacto si no se encontraron contactos
                    ID_ContactoTextEdit.Properties.DataSource = null;
                    ID_ContactoTextEdit.EditValue = null;

                    repositoryItemCheckedComboBoxEdit2.DataSource = null;
                    repositoryItemCheckedComboBoxEdit2.NullText = null;

                    //repositoryItemCheckedComboBoxEdit1.DataSource = null;
                    //repositoryItemCheckedComboBoxEdit1.NullText = null;
                }
            }
            else
            {
                // Limpiar el control de edición de ID_Contacto si no se encontraron contactos
                ID_ContactoTextEdit.Properties.DataSource = null;
                ID_ContactoTextEdit.EditValue = null;

                repositoryItemCheckedComboBoxEdit2.DataSource = null;
                repositoryItemCheckedComboBoxEdit2.NullText = null;

                //repositoryItemCheckedComboBoxEdit1.DataSource = null;
                //repositoryItemCheckedComboBoxEdit1.NullText = null;
            }
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cboNivel_EditValueChanged(object sender, EventArgs e)
        {
            //if (repositoryItemSearchLookUpEdit1.EditValue != null)
            //{
            //    int value = (int)cboNivel.EditValue;

            //    cboNivel.ForeColor = Color.White;

            //    switch (value)
            //    {
            //        case 4:
            //            cboNivel.BackColor = Color.FromArgb(255, 80, 80);
            //            break;
            //        case 3:
            //            cboNivel.BackColor = Color.FromArgb(0, 112, 192);
            //            break;
            //        case 2:
            //            cboNivel.BackColor = Color.FromArgb(102, 153, 255);
            //            break;
            //        case 1:
            //            cboNivel.BackColor = Color.FromArgb(130, 82, 196);
            //            break;
            //        default:
            //            cboNivel.BackColor = SystemColors.Control; // O cualquier otro color por defecto
            //            break;
            //    }
            //}
        }

        DataTable TObjetivos;


        private void CargarObejtivos()
        {
            HpResergerNube.SCH_Estrate_Objetivos objObjetivos = new HpResergerNube.SCH_Estrate_Objetivos();
            TObjetivos = objObjetivos.GetEstrateObjetivosByFkIdEstrate(idExtrate);
            if (TObjetivos.Rows.Count > 0)
            {
                repositoryItemSearchLookUpEdit2.DataSource = TObjetivos;
                repositoryItemSearchLookUpEdit2.ValueMember = "id";
                repositoryItemSearchLookUpEdit2.DisplayMember = "nombre";
            }
            else
            {
                repositoryItemSearchLookUpEdit2.DataSource = null;
            }
        }
        private void CargarExtrate()
        {
            idcliente = ItemForID_cliente.EditValue?.ToString() ?? string.Empty;

            HpResergerNube.SCH_Estrate objExtrate = new HpResergerNube.SCH_Estrate();
            DataTable TExtrate = objExtrate.GetEstratesByCliente(idcliente);
            if (TExtrate.Rows.Count > 0)
            {
                idExtrate = (int)TExtrate.Rows[0]["id"];
            }
            else { idExtrate = 0; }

            if (idExtrate != 0)
            {
                CargarObejtivos();
            }
            else TObjetivos = null;

        }
        private void ItemForID_cliente_EditValueChanged(object sender, EventArgs e)
        {
            RecargarContacto();
            CargarExtrate();
            ConsultarReunionExistente();
            RecargarDetalle();
        }

        private void ConsultarReunionExistente()
        {
            fkid = idAgenda;
            HpResergerNube.SCH_Reuniones obclase = new HpResergerNube.SCH_Reuniones();
            obclase = obclase.ReadReunion(fkid);

            if (obclase != null)
            {
                fkid = obclase.ID;
                dtpFechaReunion.EditValue = obclase.Fecha;
                ID_ContactoTextEdit.EditValue = obclase.Participantes;

                lblestado.Caption = "Reunión Guardada";
            }


            if (fkid == 0)
            {
                dtpFechaReunion.EditValue = DateTime.Now;
                ID_ContactoTextEdit.EditValue = null;
                gridControl1.DataSource = "";
                lblestado.Caption = "Nueva Reunión";
            }

        }

        private void RecargarDetalle()
        {
            if (fkid != 0)
            {
                HpResergerNube.SCH_ReunionesDet obclase = new HpResergerNube.SCH_ReunionesDet();
                gridControl1.DataSource = obclase.GetReunionesDetByFKID(fkid);
                gridView1.BestFitColumns();
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtpFechaReunion.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar una fecha para la reunión. Por favor, elija una fecha en el campo 'Fecha de Reunión'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ItemForID_cliente.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un cliente para la reunión. Por favor, elija un cliente en el campo 'Cliente'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ID_ContactoTextEdit.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar los participantes para la reunión. Por favor, agregue al menos un participante en el campo 'Participantes'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fkid == 0)
            {
                // Crear una instancia de la clase SCH_Reuniones
                HpResergerNube.SCH_Reuniones obclase = new HpResergerNube.SCH_Reuniones();
                obclase.Cliente = ItemForID_cliente.EditValue.ToString();
                obclase.Estado = 1; // Asumimos que "1" representa el valor true para el estado
                obclase.Fecha = (DateTime)dtpFechaReunion.EditValue;
                obclase.FechaCreacion = DateTime.Now;
                obclase.Participantes = ID_ContactoTextEdit.EditValue.ToString();

                // Insertar la reunión en la base de datos
                fkid = obclase.InsertReunion(obclase);

                if (fkid == 0)
                {
                    // Mostrar mensaje si la inserción falla
                    XtraMessageBox.Show("No se pudo guardar la reunión. Por favor, intente nuevamente o contacte al administrador si el problema persiste.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Mostrar mensaje si la inserción es exitosa
                    XtraMessageBox.Show("La reunión se ha guardado correctamente con el ID: " + fkid.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblestado.Caption = "Reunión Guardada";
                }
            }
            else
            {
                HpResergerNube.SCH_Reuniones obclase = new HpResergerNube.SCH_Reuniones();
                obclase.Cliente = ItemForID_cliente.EditValue.ToString();
                obclase.Estado = 1;
                obclase.Fecha = (DateTime)dtpFechaReunion.EditValue;
                obclase.FechaCreacion = DateTime.Now;
                obclase.Participantes = ID_ContactoTextEdit.EditValue.ToString();
                obclase.ID = fkid;

                if (obclase.UpdateReunion(obclase))
                {

                    XtraMessageBox.Show("La reunión se ha actualizo correctamente con el ID: " + fkid.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblestado.Caption = "Reunión Guardada";
                }
                else
                {
                    XtraMessageBox.Show("No se pudo actualizar la reunión. Por favor, intente nuevamente o contacte al administrador si el problema persiste.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void btnAlñadirDetalleReunion(object sender, EventArgs e)
        {
            {
                if (fkid != 0)
                {
                    HpResergerNube.SCH_ReunionesDet obclase = new HpResergerNube.SCH_ReunionesDet();

                    // Supongo que debes establecer las propiedades del objeto antes de insertar
                    obclase.FKID = fkid;
                    obclase.Accion = "Ingrese Accion"; // Asumiendo que txtAccion es el control de entrada para "Accion"
                    obclase.Nivel = 1;// Asumiendo que txtNivel es el control de entrada para "Nivel"
                    obclase.Seguimiento = DateTime.Now;// Asumiendo que dtpSeguimiento es el control de entrada para "Seguimiento"
                    obclase.ResponsableOficina = "";// Asumiendo que txtResponsableOficina es el control de entrada para "Responsable_Oficina"
                    obclase.ResponsableCliente = "";// Asumiendo que txtResponsableCliente es el control de entrada para "Responsable_Cliente"
                    obclase.ObjetivoRelacionado = 0; // Asumiendo que txtObjetivoRelacionado es el control de entrada para "Objetivo_Relacionado"

                    int result = obclase.InsertReunionDet(obclase);

                    if (result == 0)
                    {
                        XtraMessageBox.Show("Hubo un error al guardar el detalle de la reunión. Por favor, intente nuevamente o contacte al administrador si el problema persiste.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        XtraMessageBox.Show("El detalle de la reunión se ha guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Primero debe guardar la cabecera de la reunión antes de añadir detalles.", "Cabecera Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            RecargarDetalle();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fkid != 0)
            {
                // Crear una instancia de la clase SCH_Reuniones
                HpResergerNube.SCH_Reuniones obclase = new HpResergerNube.SCH_Reuniones();

                // Intentar actualizar el estado de la reunión a "eliminado"
                bool resultado = obclase.UpdateReunionEliminar(fkid); // Supongo que el método correcto es UpdateReunionEstado y queremos establecer el estado a false (0)

                if (resultado)
                {
                    XtraMessageBox.Show("La reunión ha sido eliminada con éxito. El estado se ha actualizado a 'Eliminado'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("No se pudo eliminar la reunión. Por favor, verifique que el ID de la reunión sea correcto y que no haya problemas de conexión con la base de datos.", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar una reunión válida para eliminar. Por favor, asegúrese de que el ID de la reunión sea correcto y vuelva a intentarlo.", "Selección Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Llamar a métodos para consultar y recargar los detalles
            ConsultarReunionExistente();
            RecargarDetalle();

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.RowHandle >= 0)
            {
                int fila = e.RowHandle;
                object idValor = gridView1.GetRowCellValue(fila, "id");
                object fkid = gridView1.GetRowCellValue(fila, "fkid");
                object accion = gridView1.GetRowCellValue(fila, "Accion");
                object Nivel = gridView1.GetRowCellValue(fila, "Nivel");
                object Seguimiento = gridView1.GetRowCellValue(fila, "Seguimiento");
                object Responsable_Oficina = gridView1.GetRowCellValue(fila, "Responsable_Oficina");
                object Responsable_Cliente = gridView1.GetRowCellValue(fila, "Responsable_Cliente");
                object Objetivo_Relacionado = gridView1.GetRowCellValue(fila, "Objetivo_Relacionado");
                object idstatus = gridView1.GetRowCellValue(fila, "idstatus");

                HpResergerNube.SCH_ReunionesDet obclase = new HpResergerNube.SCH_ReunionesDet();
                obclase.ID = (int)idValor;
                obclase.FKID = (int)fkid;
                obclase.Accion = accion.ToString();
                obclase.Nivel = (int)Nivel;
                obclase.Seguimiento = (DateTime)Seguimiento;
                obclase.ResponsableOficina = Responsable_Oficina.ToString();
                obclase.ResponsableCliente = Responsable_Cliente.ToString();
                obclase.ObjetivoRelacionado = (int)Objetivo_Relacionado;
                obclase.idstatus = (int)idstatus;
                // Intentar actualizar la estrategia
                if (!obclase.UpdateReunionDet(obclase))
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

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            idAgenda = fkid = 0;
            ItemForID_cliente.Enabled = true;
            lblestado.Caption = "Nueva Reunión";
            ItemForID_cliente.EditValue = null;
            gridControl1.DataSource = null;
        }
    }
}
