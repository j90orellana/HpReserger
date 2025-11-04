using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class MovimientoPartida
    {
        public int Id { get; set; } = 0;
        public int Fkid { get; set; } = 0;
        public int Fkiddet { get; set; } = 0;
        public string Cuenta { get; set; } = string.Empty;
        public int Fkproyecto { get; set; } = 0;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Idpartida { get; set; } = 0;
    }
    public class Partidas_Control
    {
        public int Id { get; set; } = 0;
        public string NTipo { get; set; } = string.Empty;
        public string Ncodigo { get; set; } = string.Empty;
        public string CodigoPadre { get; set; } = string.Empty;
        public string PatidaPadre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Partida { get; set; } = string.Empty;
        public int Tipo { get; set; } = 0;
        public int Cabecera { get; set; } = 0;
        public string Tag { get; set; } = string.Empty;
        public int Estado { get; set; } = 1;
        public int PKempresa { get; set; } = 1;
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Campos heredados (para mantener compatibilidad)
        public string Descripcion { get => Partida; set => Partida = value; }
        public string Completo { get; set; } = string.Empty;

        private readonly string _connectionString;

        public Partidas_Control()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public void VerificarCrearTablaMovimientosPartida()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Verificar si la tabla existe
                string checkTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TBL_MovimientoPartidas' AND xtype='U')
                BEGIN
                    CREATE TABLE TBL_MovimientoPartidas (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        fkid INT NOT NULL,
                        fkiddet INT NOT NULL,
                        cuenta VARCHAR(10) NOT NULL,
                        fkproyecto INT NOT NULL,
                        fecha DATE NOT NULL,
                        idpartida INT NOT NULL
                    )
                END";

                SqlCommand cmd = new SqlCommand(checkTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public bool ActualizarMovimiento(MovimientoPartida movimiento)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_MovimientoPartidas SET 
                        fkid = @fkid, 
                        fkiddet = @fkiddet, 
                        cuenta = @cuenta, 
                        fkproyecto = @fkproyecto, 
                        fecha = @fecha, 
                        idpartida = @idpartida
                        WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", movimiento.Id);
                cmd.Parameters.AddWithValue("@fkid", movimiento.Fkid);
                cmd.Parameters.AddWithValue("@fkiddet", movimiento.Fkiddet);
                cmd.Parameters.AddWithValue("@cuenta", movimiento.Cuenta);
                cmd.Parameters.AddWithValue("@fkproyecto", movimiento.Fkproyecto);
                cmd.Parameters.AddWithValue("@fecha", movimiento.Fecha);
                cmd.Parameters.AddWithValue("@idpartida", movimiento.Idpartida);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Retorna true si se actualizó al menos una fila
                return rowsAffected > 0;
            }
        }
        public int InsertarMovimiento(MovimientoPartida movimiento)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO TBL_MovimientoPartidas 
                            (fkid, fkiddet, cuenta, fkproyecto, fecha, idpartida) 
                            OUTPUT INSERTED.id 
                            VALUES (@fkid, @fkiddet, @cuenta, @fkproyecto, @fecha, @idpartida)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fkid", movimiento.Fkid);
                cmd.Parameters.AddWithValue("@fkiddet", movimiento.Fkiddet);
                cmd.Parameters.AddWithValue("@cuenta", movimiento.Cuenta);
                cmd.Parameters.AddWithValue("@fkproyecto", movimiento.Fkproyecto);
                cmd.Parameters.AddWithValue("@fecha", movimiento.Fecha);
                cmd.Parameters.AddWithValue("@idpartida", movimiento.Idpartida);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        // Create
        public int Insertar(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO TBL_Partidas_Control 
                            (NTipo, Ncodigo, CodigoPadre, PatidaPadre, Codigo, Partida,Tipo, Cabecera, Tag, Estado, Fecha) 
                            OUTPUT INSERTED.id 
                            VALUES (@NTipo, @Ncodigo, @CodigoPadre, @PatidaPadre, @Codigo, @Partida,@Tipo, @Cabecera, @Tag, @Estado, @Fecha)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NTipo", partida.NTipo);
                cmd.Parameters.AddWithValue("@Ncodigo", partida.Ncodigo);
                cmd.Parameters.AddWithValue("@CodigoPadre", partida.CodigoPadre);
                cmd.Parameters.AddWithValue("@PatidaPadre", partida.PatidaPadre);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Partida", partida.Partida);
                cmd.Parameters.AddWithValue("@Tipo", partida.Tipo);
                cmd.Parameters.AddWithValue("@Cabecera", partida.Cabecera);
                cmd.Parameters.AddWithValue("@Tag", partida.Tag);
                cmd.Parameters.AddWithValue("@Estado", partida.Estado);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Read
        // Read
        public DataTable ObtenerTodos( )
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM TBL_Partidas_Control 
                           WHERE  estado = 1 
                           ORDER BY Partida";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        // Read
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                        SELECT CONCAT(codigo, ' - ', Partida) AS Nombre, c.*, e.Empresa 
                        FROM TBL_Partidas_Control c
                        INNER JOIN TBL_Empresa e ON e.ppto =c.Tipo
                        WHERE estado = 1 AND cabecera = 0 AND Codigo != ''
                        ORDER BY 1
";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable GetAllUnicos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT DISTINCT 
                                CONCAT(codigo, ' - ', Partida) AS Nombre, 
                                c.Codigo, 
                                MAX(id) AS id 
                            FROM TBL_Partidas_Control c
                            WHERE estado = 1 
                                AND cabecera = 0 
                                AND Codigo <> ''
                            GROUP BY codigo, Partida
                            ORDER BY Nombre";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        // Update
        // Update
        public bool Actualizar(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_Partidas_Control SET 
                           NTipo = @NTipo, 
                           Ncodigo = @Ncodigo, 
                           CodigoPadre = @CodigoPadre,
                           PatidaPadre = @PatidaPadre,
                           Codigo = @Codigo, 
                           Partida = @Partida, 
                           Tipo = @Tipo, 
                           Cabecera = @Cabecera, 
                           Tag = @Tag, 
                           Estado = @Estado, 
                           Fecha = @Fecha
                           WHERE id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NTipo", partida.NTipo);
                cmd.Parameters.AddWithValue("@Ncodigo", partida.Ncodigo);
                cmd.Parameters.AddWithValue("@CodigoPadre", partida.CodigoPadre);
                cmd.Parameters.AddWithValue("@PatidaPadre", partida.PatidaPadre);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Partida", partida.Partida);
                cmd.Parameters.AddWithValue("@Tipo", partida.Tipo);
                cmd.Parameters.AddWithValue("@Cabecera", partida.Cabecera);
                cmd.Parameters.AddWithValue("@Tag", partida.Tag);
                cmd.Parameters.AddWithValue("@Estado", partida.Estado);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);
                cmd.Parameters.AddWithValue("@Id", partida.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarGrilla(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_Partidas_Control SET 
                        Codigo = @Codigo, 
                        Partida = @Partida,                        
                        Fecha = @Fecha,
                        NTipo = @NTipo,
                        Ncodigo = @Ncodigo,
                        CodigoPadre = @CodigoPadre,
                        PatidaPadre = @PatidaPadre
                        WHERE id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Partida", partida.Partida);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);
                cmd.Parameters.AddWithValue("@NTipo", partida.NTipo);
                cmd.Parameters.AddWithValue("@Ncodigo", partida.Ncodigo);
                cmd.Parameters.AddWithValue("@CodigoPadre", partida.CodigoPadre);
                cmd.Parameters.AddWithValue("@PatidaPadre", partida.PatidaPadre);
                cmd.Parameters.AddWithValue("@Id", partida.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Delete
        public bool Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_Partidas_Control WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarFisicoxTag(string _tag)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_Partidas_Control WHERE tag = @tag";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tag", _tag);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarLogicoxTag(string _tag)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "update p set estado =0 FROM TBL_Partidas_Control p WHERE tag = @tag";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tag", _tag);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarLogico(int _id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "update p set estado=0 FROM TBL_Partidas_Control p WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Filter by Tipo
        public DataTable FiltrarPorTipo(int tipo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                        SELECT 
                            id,
                            NTipo,
                            Ncodigo,
                            CodigoPadre,
                            PatidaPadre,
                            Codigo,
                            Partida AS Descripcion, -- Mantener compatibilidad
                            Tipo,
                            Cabecera,
                            Tag tag,
                            Estado,
                            Fecha
                            
                        FROM TBL_Partidas_Control
                        WHERE estado = 1 
                            AND tipo = @Tipo 
                           
                          ORDER BY 
                           
                        TRY_CAST(   REPLACE(codigo,'.','0') as int )  asc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
