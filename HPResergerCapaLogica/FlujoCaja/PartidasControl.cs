﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class Partidas_Control
    {
        public int Id { get; set; } = 0;
        public string Codigo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Completo { get; set; } = string.Empty;
        public int Tipo { get; set; } = 0;
        public int Cabecera { get; set; } = 0;
        public string Tag { get; set; } = string.Empty;
        public int Estado { get; set; } = 1;
        public int PKempresa { get; set; } = 1;
        public DateTime Fecha { get; set; } = DateTime.Now;

        private readonly string _connectionString;
        public Partidas_Control()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        // Create
        public int Insertar(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO TBL_Partidas_Control (Codigo, Descripcion, Completo, Tipo, Cabecera, Tag, Estado, Fecha,pkempresa) OUTPUT INSERTED.id " +
                    "VALUES (@Codigo, @Descripcion, @Completo, @Tipo, @Cabecera, @Tag, @Estado, @Fecha, @pkempresa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", partida.Descripcion);
                cmd.Parameters.AddWithValue("@Completo", (object)partida.Completo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo", partida.Tipo);
                cmd.Parameters.AddWithValue("@Cabecera", partida.Cabecera);
                cmd.Parameters.AddWithValue("@Tag", partida.Tag);
                cmd.Parameters.AddWithValue("@Estado", partida.Estado);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);
                cmd.Parameters.AddWithValue("@pkempresa", partida.PKempresa);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Read
        public DataTable ObtenerTodos(int empresa)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = $"select * from TBL_Partidas_Control where pkempresa = {empresa} and estado =1 order by descripcion";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

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
                string query = @"select concat(codigo,' - ',Descripcion)Nombre, c.*,e.Empresa from TBL_Partidas_Control c
                                inner join TBL_Empresa e on c.pkempresa = e.Id_Empresa
                                where estado = 1 and cabecera =0 and Codigo !=''
                                order by 1";
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
                string query = @"
                                SELECT DISTINCT 
                                    CONCAT(codigo, ' - ', Descripcion) AS Nombre, 
                                    c.Codigo, 
                                    MAX(id) AS id 
                                FROM TBL_Partidas_Control c
                                WHERE estado = 1 
                                    AND cabecera = 0 
                                    AND Codigo <> ''
                                GROUP BY codigo, Descripcion
                                ORDER BY Nombre;
    
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        // Update
        public bool Actualizar(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE TBL_Partidas_Control SET Codigo = @Codigo, Descripcion = @Descripcion, Completo = @Completo, Tipo = @Tipo, Cabecera = @Cabecera, Tag = @Tag, Estado = @Estado, Fecha = @Fecha " +
                    ",pkempresa= @pkempresa WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", partida.Descripcion);
                cmd.Parameters.AddWithValue("@Completo", (object)partida.Completo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo", partida.Tipo);
                cmd.Parameters.AddWithValue("@Cabecera", partida.Cabecera);
                cmd.Parameters.AddWithValue("@Tag", partida.Tag);
                cmd.Parameters.AddWithValue("@Estado", partida.Estado);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);
                cmd.Parameters.AddWithValue("@Id", partida.Id);
                cmd.Parameters.AddWithValue("@pkempresa", partida.PKempresa);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ActualizarGrilla(Partidas_Control partida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE TBL_Partidas_Control SET Codigo = @Codigo, Descripcion = @Descripcion, Completo = @Completo, Fecha = @Fecha WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", partida.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", partida.Descripcion);
                cmd.Parameters.AddWithValue("@Completo", (object)partida.Completo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha", partida.Fecha);
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
        public DataTable FiltrarPorTipo(int tipo, int empresa)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            SELECT * 
                            FROM TBL_Partidas_Control
                            WHERE estado = 1  AND tipo = @Tipo and pkempresa= @pkempresa
                            ORDER BY TRY_CAST(Codigo AS INT) ASC;
                            ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@pkempresa", empresa);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
