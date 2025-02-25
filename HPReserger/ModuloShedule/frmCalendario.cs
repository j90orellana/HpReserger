using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using HpResergerNube;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloShedule
{
    public partial class frmCalendario : XtraForm
    {
        public frmCalendario()
        {
            InitializeComponent();
            this.schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }

        private string _conexion = "";
        private NpgsqlConnection DXSchedulerConn;
        private NpgsqlDataAdapter AppointmentDataAdapter;
        private NpgsqlDataAdapter ResourceDataAdapter;
        private DataSet DXSchedulerDataset;

        private void frmCalendario_Load(object sender, EventArgs e)
        {

            if (HPReserger.frmLogin._Perfil != "AD01")
                btnTodoslosEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;


            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerStorage1.Appointments.AutoReload = true;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE");

            DLConexion objConexion = new DLConexion();
            _conexion = objConexion.GetConnectionString();

            EstadoInicial();

            // Obtener las etiquetas del SchedulerStorage
            AppointmentLabelCollection labels = schedulerControl1.Storage.Appointments.Labels;

            FillCheckedComboBoxWithLabels();
        }
        private void FillCheckedComboBoxWithLabels()
        {
            // Limpiar items anteriores en el CheckedComboBoxEdit
            comboBoxEdit1.Properties.Items.Clear();

            // Obtener las etiquetas de citas del scheduler
            AppointmentLabelCollection labels = schedulerControl1.Storage.Appointments.Labels;

            // Recorrer las etiquetas y agregarlas al ComboBoxEdit
            foreach (AppointmentLabel label in labels)
            {
                comboBoxEdit1.Properties.Items.Add(label.DisplayName); // Agregar el nombre de la etiqueta
            }

            // Establecer el primer item como seleccionado (opcional)
            if (comboBoxEdit1.Properties.Items.Count > 0)
            {
                comboBoxEdit1.SelectedIndex = 0;
            }

        }
        public void RecargarCalendario()
        {
            EstadoInicial();
        }
        private void EstadoInicial(bool Admin = false)
        {


            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerStorage1.Appointments.AutoReload = true;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE");

            DXSchedulerDataset = new DataSet();
            string selectAppointments = "SELECT *    FROM public.\"Appointments\" WHERE \"CustomField1\" = '" + HPReserger.frmLogin.CodigoUsuario + "'";
            string selectResources = "SELECT *,CONCAT(\"Nombre\", ' ', \"Apellido1\", ' ', \"Apellido2\") AS resourcename FROM public.\"CRM_Usuario\" where \"Estado\" = 1 ORDER BY \"ID_Usuario\" ASC ";

            if (Admin) selectAppointments = "SELECT *    FROM public.\"Appointments\" ";


            DXSchedulerConn = new NpgsqlConnection(_conexion);
            DXSchedulerConn.Open();

            AppointmentDataAdapter = new NpgsqlDataAdapter(selectAppointments, DXSchedulerConn);
            // Subscribe to RowUpdated event to retrieve identity value for an inserted row.
            AppointmentDataAdapter.RowUpdated += AppointmentDataAdapter_RowUpdated;
            AppointmentDataAdapter.Fill(DXSchedulerDataset, "Appointments");


            ResourceDataAdapter = new NpgsqlDataAdapter(selectResources, DXSchedulerConn);
            ResourceDataAdapter.Fill(DXSchedulerDataset, "Resources");

            // Specify mappings.
            MapAppointmentData();
            MapResourceData();
            // Generate commands using NpgsqlCommandBuilder
            NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(AppointmentDataAdapter);
            AppointmentDataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            AppointmentDataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            AppointmentDataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();


            DXSchedulerConn.Close();

            schedulerStorage1.Appointments.DataSource = DXSchedulerDataset.Tables[0];
            schedulerStorage1.Resources.DataSource = DXSchedulerDataset.Tables[1];

        }
        private void MapAppointmentData()
        {
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            // Required mapping.
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            // Required mapping.
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "CustomField1";
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("IdUsuario", "CustomField1", FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("IdEmpresa", "CustomField2", FieldValueType.String));


        }

        private void MapResourceData()
        {
            this.schedulerStorage1.Resources.Mappings.Id = "ID_Usuario";
            this.schedulerStorage1.Resources.Mappings.Caption = "resourcename";
        }
        // Retrieve identity value for an inserted appointment.
        public int idcalendario = 0;
        private void AppointmentDataAdapter_RowUpdated(object sender, NpgsqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == System.Data.StatementType.Insert)
            {
                idcalendario = 0;

                // Asegúrate de usar el nombre correcto de la secuencia aquí
                using (var cmd = new NpgsqlCommand("SELECT currval('public.\"Appointments_UniqueID_seq\"')", DXSchedulerConn))
                {
                    ((NpgsqlParameter)e.Command.Parameters[13]).Value = HPReserger.frmLogin.CodigoUsuario.ToString();
                    ((NpgsqlParameter)e.Command.Parameters[14]).Value = HPReserger.frmLogin.CodigoUsuario.ToString();


                    //e.Command.Parameters[14] = HPReserger.frmLogin.CodigoUsuario.ToString();
                    idcalendario = Convert.ToInt32(cmd.ExecuteScalar());
                }
                HpResergerNube.Appointments oclase = new Appointments();
                string codigo = HPReserger.frmLogin.CodigoUsuario.ToString();
                oclase.UpdateAppointmentCustomFields(idcalendario, codigo, codigo);
            }
        }


        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EstadoInicial();
        }

        private void SchedulerStorage1_FilterAppointment(object sender, PersistentObjectCancelEventArgs e)
        {
            //// Asegúrate de que e.Object es del tipo Appointment
            //if (e.Object is Appointment appointment)
            //{
            //    // Verifica si CustomFields no es null y si el campo "IdUsuario" existe
            //    if (appointment.CustomFields != null && appointment.CustomFields.ToString().Contains("IdUsuario"))
            //    {
            //        // Asegúrate de convertir el campo "IdUsuario" a string y compara
            //        string idUsuario = appointment.CustomFields["IdUsuario"]?.ToString();
            //        string codigoUsuario = HPReserger.frmLogin.CodigoUsuario.ToString();

            //        // Verifica que el idUsuario y codigoUsuario no sean null antes de comparar
            //        e.Cancel = idUsuario != null && idUsuario != codigoUsuario;
            //    }
            //    else
            //    {
            //        // Manejo si el campo "IdUsuario" no existe o CustomFields es null
            //        e.Cancel = true; // O manejar de otra manera según tu lógica
            //    }
            //}
            //else
            //{
            //    // Manejo si e.Object no es un Appointment
            //    e.Cancel = true; // O manejar de otra manera según tu lógica
            //}
            Appointment apt = (Appointment)e.Object;

            // Obtener el nombre de la etiqueta seleccionada
            if (comboBoxEdit1.SelectedItem != null)
            {


                string selectedLabelName = comboBoxEdit1.SelectedItem.ToString();

                // Obtener las etiquetas disponibles
                AppointmentLabelCollection labels = schedulerControl1.Storage.Appointments.Labels;

                // Encontrar la etiqueta correspondiente
                var selectedLabel = labels.FirstOrDefault(label => label.DisplayName == selectedLabelName);
                var index = labels.IndexOf(selectedLabel);
                // Filtrar citas por la etiqueta seleccionada
                if (index != 0)
                    if (selectedLabel != null && apt.LabelId != index)
                    {
                        e.Cancel = true; // Oculta la cita si no coincide con la etiqueta
                    }
            }
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                // Actualiza la base de datos
                //AppointmentDataAdapter.UpdateCommand.Parameters[29].Value = HPReserger.frmLogin.CodigoUsuario.ToString();
                //AppointmentDataAdapter.UpdateCommand.Parameters[30].Value = HPReserger.frmLogin.CodigoUsuario.ToString();
                AppointmentDataAdapter.Update(DXSchedulerDataset.Tables["Appointments"]);
                DXSchedulerDataset.AcceptChanges();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                //MessageBox.Show($"Error al actualizar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    foreach (DataRow row in DXSchedulerDataset.Tables["Appointments"].Rows)
                    {
                        if (row.RowState == DataRowState.Modified || row.RowState == DataRowState.Added)
                        {
                            HpResergerNube.Appointments appointment = new HpResergerNube.Appointments
                            {
                                UniqueID = (row["UniqueID"].ToString() == "" ? idcalendario : Convert.ToInt32(row["UniqueID"].ToString())),
                                Type = Convert.ToInt32(row["Type"]),
                                StartDate = Convert.ToDateTime(row["StartDate"]),
                                EndDate = Convert.ToDateTime(row["EndDate"]),
                                AllDay = Convert.ToBoolean(row["AllDay"]),
                                Subject = row["Subject"].ToString(),
                                Location = row["Location"].ToString(),
                                Description = row["Description"].ToString(),
                                Status = Convert.ToInt32(row["Status"]),
                                Label = Convert.ToInt32(row["Label"]),
                                ResourceIDs = row["ResourceIDs"].ToString(),
                                ReminderInfo = row["ReminderInfo"].ToString(),
                                RecurrenceInfo = row["RecurrenceInfo"].ToString(),
                                CustomField1 = HPReserger.frmLogin.CodigoUsuario.ToString(),
                                CustomField2 = HPReserger.frmLogin.CodigoUsuario.ToString()
                            };

                            HpResergerNube.Appointments obclase = new HpResergerNube.Appointments();
                            bool result = obclase.UpdateAppointment(appointment);

                            if (!result)
                            {
                                //XtraMessageBox.Show($"Hubo un error al actualizar la cita con UniqueID {appointment.UniqueID} en la base de datos.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // Aceptar cambios en el dataset
                    DXSchedulerDataset.AcceptChanges();
                }
                catch (Exception exx)
                {
                    XtraMessageBox.Show($"Error al actualizar la base de datos: {exx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
        private void btnRefrescar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EstadoInicial();

        }

        private void btnTodoslosEmpleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EstadoInicial(true);
        }

        private void schedulerStorage1_FetchAppointments(object sender, FetchAppointmentsEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre de la etiqueta seleccionada
            string selectedLabelName = comboBoxEdit1.SelectedItem.ToString();

            // Filtrar las citas del SchedulerControl según la etiqueta seleccionada
            schedulerControl1.Storage.FilterAppointment += SchedulerStorage1_FilterAppointment;

            // Refrescar el control para aplicar el filtro
            schedulerControl1.Refresh();
        }
    }
}
