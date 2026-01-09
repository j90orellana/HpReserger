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
        public string Codigo { get; set; } = "";
        public int Nivel { get; set; } = 0;
        public string Matriz { get; set; } = "";
        public string Area { get; set; } = "";
        public string Partida { get; set; } = "";
        public string SubPartida { get; set; } = "";
        public string DetallePartida { get; set; } = "";
        public string DetalleSubPartida { get; set; } = "";
        public int AreaOwner { get; set; } = 0;
        public int AreaOwner2 { get; set; } = 0;
        public int? Tipo { get; set; } = null;
        public string Tag { get; set; } = "";
        public int Estado { get; set; } = 1;
        public DateTime Fecha { get; set; } = DateTime.Now;

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

        public DataTable GetAreas()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT 
                        0 AS Id_Area,
                        '[Ninguna]' AS Area,
                        NULL AS Gerencia,
                        NULL AS CCosto

                    UNION ALL
                    SELECT 
                    Id_Area,
                    Area,
                    Gerencia,
                    CCosto
                    FROM TBL_Area
                    ORDER BY Id_Area;

";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
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
        public int Insertar(Partidas_Control p)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
        INSERT INTO TBL_Partidas_Control
        (Codigo, Nivel, Matriz, Area, Partida, SubPartida, DetallePartida, DetalleSubPartida,
         AreaOwner, AreaOwner2, Tipo, Tag, Estado, Fecha)
        OUTPUT INSERTED.Id
        VALUES
        (@Codigo, @Nivel, @Matriz, @Area, @Partida, @SubPartida, @DetallePartida, @DetalleSubPartida,
         @AreaOwner, @AreaOwner2, @Tipo, @Tag, @Estado, @Fecha)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@Nivel", p.Nivel);
                cmd.Parameters.AddWithValue("@Matriz", (object)p.Matriz ?? "");
                cmd.Parameters.AddWithValue("@Area", (object)p.Area ?? "");
                cmd.Parameters.AddWithValue("@Partida", (object)p.Partida ?? "");
                cmd.Parameters.AddWithValue("@SubPartida", (object)p.SubPartida ?? "");
                cmd.Parameters.AddWithValue("@DetallePartida", (object)p.DetallePartida ?? "");
                cmd.Parameters.AddWithValue("@DetalleSubPartida", (object)p.DetalleSubPartida ?? "");
                cmd.Parameters.AddWithValue("@AreaOwner", p.AreaOwner);
                cmd.Parameters.AddWithValue("@AreaOwner2", p.AreaOwner2);
                cmd.Parameters.AddWithValue("@Tipo", (object)p.Tipo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Tag", (object)p.Tag ?? "");
                cmd.Parameters.AddWithValue("@Estado", p.Estado);
                cmd.Parameters.AddWithValue("@Fecha", p.Fecha);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }


        // Read
        public DataTable ObtenerTodos()
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

                        SELECT id id, CONCAT(codigo, ' - ', DetalleSubPartida) AS Nombre,  e.Empresa 
                        FROM TBL_Partidas_Control c
                        INNER JOIN TBL_Empresa e ON e.ppto =c.Tipo
                        WHERE estado = 1 AND nivel = 4 AND Codigo != ''
                        ORDER BY 1
";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable GetAllxEmpresa(int idempresa)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT Id id,
                CONCAT(c.codigo, ' - ', c.DetalleSubPartida) AS Nombre,
                
                e.Empresa 
            FROM TBL_Partidas_Control c
            INNER JOIN TBL_Empresa e ON e.ppto = c.Tipo
            WHERE e.id_empresa = @idempresa
              AND c.estado = 1 
              AND c.nivel = 4 
              AND c.Codigo != ''
            ORDER BY 1;
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Agrega el parámetro seguro
                adapter.SelectCommand.Parameters.AddWithValue("@idempresa", idempresa);

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
                                CONCAT(codigo, ' - ', DetalleSubPartida) AS Nombre, 
                                c.Codigo, 
                                MAX(id) AS id 
                            FROM TBL_Partidas_Control c
                            WHERE estado = 1 
                                AND nivel = 4 
                                AND Codigo <> ''
                            GROUP BY codigo, DetalleSubPartida
                            ORDER BY Nombre";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        // Update
        public bool Actualizar(Partidas_Control p)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
        UPDATE TBL_Partidas_Control SET
            Codigo=@Codigo,
            Nivel=@Nivel,
            Matriz=@Matriz,
            Area=@Area,
            Partida=@Partida,
            SubPartida=@SubPartida,
            DetallePartida=@DetallePartida,
            DetalleSubPartida=@DetalleSubPartida,
            AreaOwner=@AreaOwner,
            AreaOwner2=@AreaOwner2,
            Tipo=@Tipo,
            Tag=@Tag,
            Estado=@Estado,
            Fecha=@Fecha
        WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@Nivel", p.Nivel);
                cmd.Parameters.AddWithValue("@Matriz", (object)p.Matriz ?? "");
                cmd.Parameters.AddWithValue("@Area", (object)p.Area ?? "");
                cmd.Parameters.AddWithValue("@Partida", (object)p.Partida ?? "");
                cmd.Parameters.AddWithValue("@SubPartida", (object)p.SubPartida ?? "");
                cmd.Parameters.AddWithValue("@DetallePartida", (object)p.DetallePartida ?? "");
                cmd.Parameters.AddWithValue("@DetalleSubPartida", (object)p.DetalleSubPartida ?? "");
                cmd.Parameters.AddWithValue("@AreaOwner", p.AreaOwner);
                cmd.Parameters.AddWithValue("@AreaOwner2", p.AreaOwner2);
                cmd.Parameters.AddWithValue("@Tipo", (object)p.Tipo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Tag", (object)p.Tag ?? "");
                cmd.Parameters.AddWithValue("@Estado", p.Estado);
                cmd.Parameters.AddWithValue("@Fecha", p.Fecha);
                cmd.Parameters.AddWithValue("@Id", p.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarGrilla(Partidas_Control p)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
        UPDATE TBL_Partidas_Control SET
            Codigo=@Codigo,
            Nivel=@Nivel,
            Matriz=@Matriz,
            Area=@Area,
            Partida=@Partida,
            SubPartida=@SubPartida,
            DetallePartida=@DetallePartida,
            DetalleSubPartida=@DetalleSubPartida,
            AreaOwner=@AreaOwner,
            AreaOwner2=@AreaOwner2
          
        WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@Nivel", p.Nivel);
                cmd.Parameters.AddWithValue("@Matriz", (object)p.Matriz ?? "");
                cmd.Parameters.AddWithValue("@Area", (object)p.Area ?? "");
                cmd.Parameters.AddWithValue("@Partida", (object)p.Partida ?? "");
                cmd.Parameters.AddWithValue("@SubPartida", (object)p.SubPartida ?? "");
                cmd.Parameters.AddWithValue("@DetallePartida", (object)p.DetallePartida ?? "");
                cmd.Parameters.AddWithValue("@DetalleSubPartida", (object)p.DetalleSubPartida ?? "");
                cmd.Parameters.AddWithValue("@AreaOwner", p.AreaOwner);
                cmd.Parameters.AddWithValue("@AreaOwner2", p.AreaOwner2);             
                cmd.Parameters.AddWithValue("@Id", p.Id);

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
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT *
                FROM TBL_Partidas_Control
                WHERE Estado = 1 AND Tipo = @Tipo
                ORDER BY Codigo";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);

                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }
    }
}
