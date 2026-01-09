using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Mantenimiento
{
    public class Empresa
    {
        private readonly string _connectionString;

        public Empresa()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public class oEmpresa
        {
            public int Id_Empresa { get; set; }
            public string EmpresaNombre { get; set; }
            public string RUC { get; set; }
            public int? Sector_Empresarial { get; set; }
            public string Direccion { get; set; }
            public int? Cod_Dep { get; set; }
            public int? Cod_Prov { get; set; }
            public int? Cod_Dist { get; set; }
            public int? TipoID_Representado { get; set; }
            public string NroID_Representado { get; set; }
            public int? Cia_Seguro { get; set; }
            public int? Usuario { get; set; }
            public DateTime? Fecha { get; set; }
            public int Stock { get; set; }
            public int IngresosMayores { get; set; }
        }

        // Obtener todos los registros
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "select *, CONCAT(ruc,' - ' , empresa)nombrecompleto from TBL_Empresa order by empresa";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetEmpleado(int codigo)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                                select Tipo_ID_Emp tipoId, Nro_ID_Emp nroDoc
                                , CONCAT(Tipo_ID_Emp, '-', Nro_ID_Emp)tipoNroDoc
                                   from TBL_Empleado where Cod_Emp = @codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", codigo);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetComprobantesPago()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "select Id_Comprobante Id, Cod_Sunat CodSunat, Nombre Nombre,dbo.NameComprobante(Id_Comprobante) Sufijo from TBL_Comprobante_Pago";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetEmpleados()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"select dbo.NombreEmpleado(Tipo_ID_Emp,Nro_ID_Emp)Nombre, Tipo_ID_Emp TipoId,Nro_ID_Emp NroId,Cod_Emp Id from TBL_Empleado
                                order by id desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable GetUsuariosActivos()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"select Codigo_User Id, Login_User Usuario from TBL_Usuario
                                where estado!=0";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        // Insertar un nuevo registro
        public bool Insert(oEmpresa empresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO TBL_Empresa 
                                (Empresa, RUC, Sector_Empresarial, Direccion, Cod_Dep, Cod_Prov, Cod_Dist, TipoID_Representado, 
                                 NroID_Representado, Cia_Seguro, Usuario, Fecha, stock, IngresosMayores)
                                 VALUES 
                                (@Empresa, @RUC, @Sector_Empresarial, @Direccion, @Cod_Dep, @Cod_Prov, @Cod_Dist, @TipoID_Representado, 
                                 @NroID_Representado, @Cia_Seguro, @Usuario, @Fecha, @Stock, @IngresosMayores)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Empresa", empresa.EmpresaNombre);
                command.Parameters.AddWithValue("@RUC", (object)empresa.RUC ?? DBNull.Value);
                command.Parameters.AddWithValue("@Sector_Empresarial", (object)empresa.Sector_Empresarial ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", (object)empresa.Direccion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Dep", (object)empresa.Cod_Dep ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Prov", (object)empresa.Cod_Prov ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Dist", (object)empresa.Cod_Dist ?? DBNull.Value);
                command.Parameters.AddWithValue("@TipoID_Representado", (object)empresa.TipoID_Representado ?? DBNull.Value);
                command.Parameters.AddWithValue("@NroID_Representado", (object)empresa.NroID_Representado ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cia_Seguro", (object)empresa.Cia_Seguro ?? DBNull.Value);
                command.Parameters.AddWithValue("@Usuario", (object)empresa.Usuario ?? DBNull.Value);
                command.Parameters.AddWithValue("@Fecha", (object)empresa.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@Stock", empresa.Stock);
                command.Parameters.AddWithValue("@IngresosMayores", empresa.IngresosMayores);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Actualizar un registro existente
        public bool Update(oEmpresa empresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_Empresa SET
                                Empresa = @Empresa,
                                RUC = @RUC,
                                Sector_Empresarial = @Sector_Empresarial,
                                Direccion = @Direccion,
                                Cod_Dep = @Cod_Dep,
                                Cod_Prov = @Cod_Prov,
                                Cod_Dist = @Cod_Dist,
                                TipoID_Representado = @TipoID_Representado,
                                NroID_Representado = @NroID_Representado,
                                Cia_Seguro = @Cia_Seguro,
                                Usuario = @Usuario,
                                Fecha = @Fecha,
                                stock = @Stock,
                                IngresosMayores = @IngresosMayores
                                WHERE Id_Empresa = @Id_Empresa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Empresa", empresa.Id_Empresa);
                command.Parameters.AddWithValue("@Empresa", empresa.EmpresaNombre);
                command.Parameters.AddWithValue("@RUC", (object)empresa.RUC ?? DBNull.Value);
                command.Parameters.AddWithValue("@Sector_Empresarial", (object)empresa.Sector_Empresarial ?? DBNull.Value);
                command.Parameters.AddWithValue("@Direccion", (object)empresa.Direccion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Dep", (object)empresa.Cod_Dep ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Prov", (object)empresa.Cod_Prov ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cod_Dist", (object)empresa.Cod_Dist ?? DBNull.Value);
                command.Parameters.AddWithValue("@TipoID_Representado", (object)empresa.TipoID_Representado ?? DBNull.Value);
                command.Parameters.AddWithValue("@NroID_Representado", (object)empresa.NroID_Representado ?? DBNull.Value);
                command.Parameters.AddWithValue("@Cia_Seguro", (object)empresa.Cia_Seguro ?? DBNull.Value);
                command.Parameters.AddWithValue("@Usuario", (object)empresa.Usuario ?? DBNull.Value);
                command.Parameters.AddWithValue("@Fecha", (object)empresa.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@Stock", empresa.Stock);
                command.Parameters.AddWithValue("@IngresosMayores", empresa.IngresosMayores);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Eliminar un registro por ID
        public bool Delete(int idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_Empresa WHERE Id_Empresa = @Id_Empresa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Empresa", idEmpresa);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
