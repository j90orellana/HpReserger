using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class Appointments
    {
        public int UniqueID { get; set; }
        public int Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Label { get; set; }
        public int ResourceID { get; set; }
        public string ResourceIDs { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }

        private string connectionString;

        public Appointments()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertAppointment(Appointments appointment)
        {
            int uniqueId = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"Appointments\"(\"Type\", \"StartDate\", \"EndDate\", \"AllDay\", \"Subject\", \"Location\", \"Description\", \"Status\", \"Label\",  \"ResourceIDs\", \"ReminderInfo\", \"RecurrenceInfo\", \"CustomField1\", \"CustomField2\") " +
                                      "VALUES (@Type, @StartDate, @EndDate, @AllDay, @Subject, @Location, @Description, @Status, @Label,  @ResourceIDs, @ReminderInfo, @RecurrenceInfo, @CustomField1, @CustomField2) " +
                                      "RETURNING \"UniqueID\"";

                    cmd.Parameters.AddWithValue("@Type", appointment.Type);
                    cmd.Parameters.AddWithValue("@StartDate", appointment.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", appointment.EndDate);
                    cmd.Parameters.AddWithValue("@AllDay", appointment.AllDay);
                    cmd.Parameters.AddWithValue("@Subject", appointment.Subject);
                    cmd.Parameters.AddWithValue("@Location", appointment.Location);
                    cmd.Parameters.AddWithValue("@Description", appointment.Description);
                    cmd.Parameters.AddWithValue("@Status", appointment.Status);
                    cmd.Parameters.AddWithValue("@Label", appointment.Label);
                    cmd.Parameters.AddWithValue("@ResourceIDs", appointment.ResourceIDs);
                    cmd.Parameters.AddWithValue("@ReminderInfo", appointment.ReminderInfo);
                    cmd.Parameters.AddWithValue("@RecurrenceInfo", appointment.RecurrenceInfo);
                    cmd.Parameters.AddWithValue("@CustomField1", appointment.CustomField1);
                    cmd.Parameters.AddWithValue("@CustomField2", appointment.CustomField2);

                    // Obtiene el UniqueID generado
                    uniqueId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return uniqueId;
        }

        public bool UpdateAppointment(Appointments appointment)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"Appointments\" " +
                                      "SET \"Type\" = @Type, " +
                                      "\"StartDate\" = @StartDate, " +
                                      "\"EndDate\" = @EndDate, " +
                                      "\"AllDay\" = @AllDay, " +
                                      "\"Subject\" = @Subject, " +
                                      "\"Location\" = @Location, " +
                                      "\"Description\" = @Description, " +
                                      "\"Status\" = @Status, " +
                                      "\"Label\" = @Label, " +
                                      "\"ResourceIDs\" = @ResourceIDs, " +
                                      "\"ReminderInfo\" = @ReminderInfo, " +
                                      "\"RecurrenceInfo\" = @RecurrenceInfo, " +
                                      "\"CustomField1\" = @CustomField1, " +
                                      "\"CustomField2\" = @CustomField2 " +
                                      "WHERE \"UniqueID\" = @UniqueID";

                    // Agrega los parámetros con los valores del objeto `appointment`
                    cmd.Parameters.AddWithValue("@Type", appointment.Type);
                    cmd.Parameters.AddWithValue("@StartDate", appointment.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", appointment.EndDate);
                    cmd.Parameters.AddWithValue("@AllDay", appointment.AllDay);
                    cmd.Parameters.AddWithValue("@Subject", appointment.Subject);
                    cmd.Parameters.AddWithValue("@Location", appointment.Location);
                    cmd.Parameters.AddWithValue("@Description", appointment.Description);
                    cmd.Parameters.AddWithValue("@Status", appointment.Status);
                    cmd.Parameters.AddWithValue("@Label", appointment.Label);
                    cmd.Parameters.AddWithValue("@ResourceID", 0);
                    cmd.Parameters.AddWithValue("@ResourceIDs", appointment.ResourceIDs);
                    cmd.Parameters.AddWithValue("@ReminderInfo", appointment.ReminderInfo);
                    cmd.Parameters.AddWithValue("@RecurrenceInfo", appointment.RecurrenceInfo);
                    cmd.Parameters.AddWithValue("@CustomField1", appointment.CustomField1);
                    cmd.Parameters.AddWithValue("@CustomField2", appointment.CustomField2);
                    cmd.Parameters.AddWithValue("@UniqueID", appointment.UniqueID);

                    // Ejecuta el comando y verifica si se actualizó alguna fila
                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
            }

            return success;
        }


        public Appointments ReadAppointment(int uniqueID)
        {
            Appointments appointment = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"Appointments\" WHERE \"UniqueID\" = @UniqueID", connection))
                {
                    cmd.Parameters.AddWithValue("@UniqueID", uniqueID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appointment = new Appointments
                            {
                                UniqueID = Convert.ToInt32(reader["UniqueID"]),
                                Type = Convert.ToInt32(reader["Type"]),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                EndDate = Convert.ToDateTime(reader["EndDate"]),
                                AllDay = Convert.ToBoolean(reader["AllDay"]),
                                Subject = reader["Subject"].ToString(),
                                Location = reader["Location"].ToString(),
                                Description = reader["Description"].ToString(),
                                Status = Convert.ToInt32(reader["Status"]),
                                Label = Convert.ToInt32(reader["Label"]),
                                ResourceID = Convert.ToInt32(reader["ResourceID"]),
                                ResourceIDs = reader["ResourceIDs"].ToString(),
                                ReminderInfo = reader["ReminderInfo"].ToString(),
                                RecurrenceInfo = reader["RecurrenceInfo"].ToString(),
                                CustomField1 = reader["CustomField1"].ToString(),
                                CustomField2 = reader["CustomField2"].ToString()
                            };
                        }
                    }
                }
            }

            return appointment;
        }

        public bool UpdateAppointmentCustomFields(int uniqueID, string customField1, string customField2)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"Appointments\" SET \"CustomField1\" = @CustomField1, \"CustomField2\" = @CustomField2 WHERE \"UniqueID\" = @UniqueID";
                    cmd.Parameters.AddWithValue("@UniqueID", uniqueID);
                    cmd.Parameters.AddWithValue("@CustomField1", customField1);
                    cmd.Parameters.AddWithValue("@CustomField2", customField2);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteAppointment(int uniqueID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"Appointments\" WHERE \"UniqueID\" = @UniqueID";
                    cmd.Parameters.AddWithValue("@UniqueID", uniqueID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllAppointments()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"Appointments\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
