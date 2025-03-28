using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{
    // Clase que representa la entidad de la tabla TBL_Proveedor
    public class Proveedor
    {
        public int? TipoId { get; set; } = 6;
        public string RUC { get; set; } = "";
        public string RazonSocial { get; set; } = "";
        public string NombreComercial { get; set; } = "";
        public int? TipoPersona { get; set; } = 0;
        public int SectorComercial { get; set; } = 0;
        public string DireccionOficina { get; set; } = "";
        public string TelefonoOficina { get; set; } = "";
        public string DireccionAlmacen { get; set; } = "";
        public string TelefonoAlmacen { get; set; } = "";
        public string DireccionSucursal { get; set; } = "";
        public string TelefonoSucursal { get; set; } = "";
        public string NombreContacto { get; set; } = "";
        public string TelefonoContacto { get; set; } = "";
        public string EmailContacto { get; set; } = "";
        public int? BancoCtaSoles { get; set; } = null;
        public string NroCtaSoles { get; set; } = "";
        public string NroCtaCciSoles { get; set; } = "";
        public int? TipoCtaSoles { get; set; } = null;
        public int? BancoCtaDolares { get; set; } = null;
        public string NroCtaDolares { get; set; } = "";
        public string NroCtaCciDolares { get; set; } = "";
        public int? TipoCtaDolares { get; set; } = null;
        public string NroCtaDetracciones { get; set; } = "";
        public int? CondicionContrib { get; set; } = null;
        public int PlazoDias { get; set; } = 30;
        public int EstadoContrib { get; set; } = 0;
        public bool? AfectoNvoRUS { get; set; } = null;
        public bool? BuenContrib { get; set; } = null;
        public bool? AgenteRetencion { get; set; } = null;
        public bool? AgentePercepVtaInt { get; set; } = null;
    }

    public class ProveedorData
    {
        private readonly string _connectionString;

        public ProveedorData()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public DataTable ListarTodos()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TBL_Proveedor";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public bool Insert(Proveedor proveedor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO TBL_Proveedor VALUES (@TipoId, @RUC, @RazonSocial, @NombreComercial, @TipoPersona, @SectorComercial, 
                            @DireccionOficina, @TelefonoOficina, @DireccionAlmacen, @TelefonoAlmacen, @DireccionSucursal, @TelefonoSucursal, 
                            @NombreContacto, @TelefonoContacto, @EmailContacto, @BancoCtaSoles, @NroCtaSoles, @NroCtaCciSoles, @TipoCtaSoles, 
                            @BancoCtaDolares, @NroCtaDolares, @NroCtaCciDolares, @TipoCtaDolares, @NroCtaDetracciones, @CondicionContrib, @PlazoDias, 
                            @EstadoContrib, @AfectoNvoRUS, @BuenContrib, @AgenteRetencion, @AgentePercepVtaInt)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TipoId", proveedor.TipoId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@RUC", proveedor.RUC);
                command.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                command.Parameters.AddWithValue("@NombreComercial", proveedor.NombreComercial);
                command.Parameters.AddWithValue("@TipoPersona", proveedor.TipoPersona ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SectorComercial", proveedor.SectorComercial);
                command.Parameters.AddWithValue("@DireccionOficina", proveedor.DireccionOficina);
                command.Parameters.AddWithValue("@TelefonoOficina", proveedor.TelefonoOficina);
                command.Parameters.AddWithValue("@DireccionAlmacen", proveedor.DireccionAlmacen);
                command.Parameters.AddWithValue("@TelefonoAlmacen", proveedor.TelefonoAlmacen);
                command.Parameters.AddWithValue("@DireccionSucursal", proveedor.DireccionSucursal);
                command.Parameters.AddWithValue("@TelefonoSucursal", proveedor.TelefonoSucursal);
                command.Parameters.AddWithValue("@NombreContacto", proveedor.NombreContacto);
                command.Parameters.AddWithValue("@TelefonoContacto", proveedor.TelefonoContacto);
                command.Parameters.AddWithValue("@EmailContacto", proveedor.EmailContacto);
                command.Parameters.AddWithValue("@BancoCtaSoles", proveedor.BancoCtaSoles ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaSoles", proveedor.NroCtaSoles);
                command.Parameters.AddWithValue("@NroCtaCciSoles", proveedor.NroCtaCciSoles);
                command.Parameters.AddWithValue("@TipoCtaSoles", proveedor.TipoCtaSoles ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@BancoCtaDolares", proveedor.BancoCtaDolares ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaDolares", proveedor.NroCtaDolares);
                command.Parameters.AddWithValue("@NroCtaCciDolares", proveedor.NroCtaCciDolares);
                command.Parameters.AddWithValue("@TipoCtaDolares", proveedor.TipoCtaDolares ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaDetracciones", proveedor.NroCtaDetracciones);
                command.Parameters.AddWithValue("@CondicionContrib", proveedor.CondicionContrib ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PlazoDias", proveedor.PlazoDias);
                command.Parameters.AddWithValue("@EstadoContrib", proveedor.EstadoContrib);
                command.Parameters.AddWithValue("@AfectoNvoRUS", proveedor.AfectoNvoRUS ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@BuenContrib", proveedor.BuenContrib ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AgenteRetencion", proveedor.AgenteRetencion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AgentePercepVtaInt", proveedor.AgentePercepVtaInt ?? (object)DBNull.Value);
                return command.ExecuteNonQuery() > 0;
            }
        }


        public bool Update(Proveedor proveedor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"UPDATE TBL_Proveedor SET TipoId=@TipoId, RazonSocial=@RazonSocial, NombreComercial=@NombreComercial, TipoPersona=@TipoPersona, 
                                SectorComercial=@SectorComercial, DireccionOficina=@DireccionOficina, TelefonoOficina=@TelefonoOficina, 
                                DireccionAlmacen=@DireccionAlmacen, TelefonoAlmacen=@TelefonoAlmacen, DireccionSucursal=@DireccionSucursal, 
                                TelefonoSucursal=@TelefonoSucursal, NombreContacto=@NombreContacto, TelefonoContacto=@TelefonoContacto, 
                                EmailContacto=@EmailContacto, BancoCtaSoles=@BancoCtaSoles, NroCtaSoles=@NroCtaSoles, NroCtaCciSoles=@NroCtaCciSoles, 
                                TipoCtaSoles=@TipoCtaSoles, BancoCtaDolares=@BancoCtaDolares, NroCtaDolares=@NroCtaDolares, 
                                NroCtaCciDolares=@NroCtaCciDolares, TipoCtaDolares=@TipoCtaDolares, NroCtaDetracciones=@NroCtaDetracciones, 
                                CondicionContrib=@CondicionContrib, PlazoDias=@PlazoDias, EstadoContrib=@EstadoContrib, AfectoNvoRUS=@AfectoNvoRUS, 
                                BuenContrib=@BuenContrib, AgenteRetencion=@AgenteRetencion, AgentePercepVtaInt=@AgentePercepVtaInt 
                                WHERE RUC=@RUC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TipoId", proveedor.TipoId ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@RUC", proveedor.RUC);
                command.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                command.Parameters.AddWithValue("@NombreComercial", proveedor.NombreComercial);
                command.Parameters.AddWithValue("@TipoPersona", proveedor.TipoPersona ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SectorComercial", proveedor.SectorComercial);
                command.Parameters.AddWithValue("@DireccionOficina", proveedor.DireccionOficina);
                command.Parameters.AddWithValue("@TelefonoOficina", proveedor.TelefonoOficina);
                command.Parameters.AddWithValue("@DireccionAlmacen", proveedor.DireccionAlmacen);
                command.Parameters.AddWithValue("@TelefonoAlmacen", proveedor.TelefonoAlmacen);
                command.Parameters.AddWithValue("@DireccionSucursal", proveedor.DireccionSucursal);
                command.Parameters.AddWithValue("@TelefonoSucursal", proveedor.TelefonoSucursal);
                command.Parameters.AddWithValue("@NombreContacto", proveedor.NombreContacto);
                command.Parameters.AddWithValue("@TelefonoContacto", proveedor.TelefonoContacto);
                command.Parameters.AddWithValue("@EmailContacto", proveedor.EmailContacto);
                command.Parameters.AddWithValue("@BancoCtaSoles", proveedor.BancoCtaSoles ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaSoles", proveedor.NroCtaSoles);
                command.Parameters.AddWithValue("@NroCtaCciSoles", proveedor.NroCtaCciSoles);
                command.Parameters.AddWithValue("@TipoCtaSoles", proveedor.TipoCtaSoles ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@BancoCtaDolares", proveedor.BancoCtaDolares ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaDolares", proveedor.NroCtaDolares);
                command.Parameters.AddWithValue("@NroCtaCciDolares", proveedor.NroCtaCciDolares);
                command.Parameters.AddWithValue("@TipoCtaDolares", proveedor.TipoCtaDolares ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NroCtaDetracciones", proveedor.NroCtaDetracciones);
                command.Parameters.AddWithValue("@CondicionContrib", proveedor.CondicionContrib ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PlazoDias", proveedor.PlazoDias);
                command.Parameters.AddWithValue("@EstadoContrib", proveedor.EstadoContrib);
                command.Parameters.AddWithValue("@AfectoNvoRUS", proveedor.AfectoNvoRUS ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@BuenContrib", proveedor.BuenContrib ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AgenteRetencion", proveedor.AgenteRetencion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AgentePercepVtaInt", proveedor.AgentePercepVtaInt ?? (object)DBNull.Value);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(string ruc)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM TBL_Proveedor WHERE RUC = @RUC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RUC", ruc);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public DataTable FiltrarPorRUC(string ruc)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TBL_Proveedor WHERE RUC = @RUC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RUC", ruc);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
