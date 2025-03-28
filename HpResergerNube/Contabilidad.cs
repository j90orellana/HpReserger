using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class Contabilidad
    {
        public string EMPRESA { get; set; }
        public string CODIGO_UNIDAD { get; set; }
        public string UNIDAD_CONTABLE { get; set; }
        public string CUENTA { get; set; }
        public string DESCRIPCION_CUENTA { get; set; }
        public long CODIGO_VOCHER { get; set; }
        public long NUMERO_VOUCHER { get; set; }
        public string FECCHA { get; set; } // text en la base
        public string CODIGO_TIPO_ANEXO { get; set; }
        public string CODIGO_ANEXO { get; set; }
        public string NOMBRE_ANEXO { get; set; }
        public string TD_REFERENCIA { get; set; }
        public string SERIE_REFERENCIA { get; set; }
        public string NUMERO_REFERENCIA { get; set; }
        public double DEBE_CONTABLE { get; set; }
        public double HABER_CONTABLE { get; set; }
        public string CODIGO_MONEDA_ORIGEN { get; set; }
        public double TC { get; set; }
        public double DEBE_ORIGEN { get; set; }
        public double HABER_ORIGEN { get; set; }
        public double DEBE_DOLARES { get; set; }
        public double HABER_DOLARES { get; set; }
        public string CENTRO_COSTO { get; set; }
        public string GLOSA { get; set; }
        public string NUMERACION { get; set; }
        public long AÑO { get; set; }
        public double CONTABLE { get; set; }
        public double ORIGEN { get; set; }
        public double DOLARES { get; set; }
        public string RESUMEN { get; set; }
        public string LUGAR { get; set; }
        public string PAREADO { get; set; }
        public string TIPO { get; set; }
        public string RELACIONADA { get; set; }
        public string SUBTYPE { get; set; }

        private string connectionString;

        public Contabilidad()
        {
            DLConexion dx = new DLConexion();
            connectionString = dx.GetConnectionString();
        }

        public List<Contabilidad> GenerarEstadoResultadoIntegral(string empresa, int año1, int año2)
        {
            List<Contabilidad> lista = new List<Contabilidad>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM public.contabilidad WHERE \"EMPRESA\" = @empresa AND \"AÑO\" BETWEEN @año1 AND @año2 AND \"RESUMEN\" ~ '^\\d+$' AND \"RESUMEN\"::int >= 60 ORDER BY \"RESUMEN\" ASC ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@empresa", empresa);
                    cmd.Parameters.AddWithValue("@año1", año1);
                    cmd.Parameters.AddWithValue("@año2", año2);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contabilidad c = new Contabilidad
                            {
                                EMPRESA = reader["EMPRESA"].ToString(),
                                CODIGO_UNIDAD = reader["CODIGO_UNIDAD"].ToString(),
                                UNIDAD_CONTABLE = reader["UNIDAD_CONTABLE"].ToString(),
                                CUENTA = reader["CUENTA"].ToString(),
                                DESCRIPCION_CUENTA = reader["DESCRIPCION_CUENTA"].ToString(),
                                CODIGO_VOCHER = reader["CODIGO_VOCHER"] == DBNull.Value ? 0 : Convert.ToInt64(reader["CODIGO_VOCHER"]),
                                NUMERO_VOUCHER = reader["NUMERO_VOUCHER"] == DBNull.Value ? 0 : Convert.ToInt64(reader["NUMERO_VOUCHER"]),
                                FECCHA = reader["FECCHA"].ToString(),
                                CODIGO_TIPO_ANEXO = reader["CODIGO_TIPO_ANEXO"].ToString(),
                                CODIGO_ANEXO = reader["CODIGO_ANEXO"].ToString(),
                                NOMBRE_ANEXO = reader["NOMBRE_ANEXO"].ToString(),
                                TD_REFERENCIA = reader["TD_REFERENCIA"].ToString(),
                                SERIE_REFERENCIA = reader["SERIE_REFERENCIA"].ToString(),
                                NUMERO_REFERENCIA = reader["NUMERO_REFERENCIA"].ToString(),
                                DEBE_CONTABLE = reader["DEBE_CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_CONTABLE"]),
                                HABER_CONTABLE = reader["HABER_CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_CONTABLE"]),
                                CODIGO_MONEDA_ORIGEN = reader["CODIGO_MONEDA_ORIGEN"].ToString(),
                                TC = reader["TC"] == DBNull.Value ? 0 : Convert.ToDouble(reader["TC"]),
                                DEBE_ORIGEN = reader["DEBE_ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_ORIGEN"]),
                                HABER_ORIGEN = reader["HABER_ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_ORIGEN"]),
                                DEBE_DOLARES = reader["DEBE_DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_DOLARES"]),
                                HABER_DOLARES = reader["HABER_DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_DOLARES"]),
                                CENTRO_COSTO = reader["CENTRO_COSTO"].ToString(),
                                GLOSA = reader["GLOSA"].ToString(),
                                NUMERACION = reader["NUMERACION"].ToString(),
                                AÑO = reader["AÑO"] == DBNull.Value ? 0 : Convert.ToInt64(reader["AÑO"]),
                                CONTABLE = reader["CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["CONTABLE"]),
                                ORIGEN = reader["ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["ORIGEN"]),
                                DOLARES = reader["DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DOLARES"]),
                                RESUMEN = reader["RESUMEN"].ToString(),
                                LUGAR = reader["LUGAR"].ToString(),
                                PAREADO = reader["PAREADO"].ToString(),
                                TIPO = reader["TIPO"].ToString(),
                                RELACIONADA = reader["RELACIONADA"].ToString(),
                                SUBTYPE = reader["SUBTYPE"].ToString()
                            };
                            lista.Add(c);
                        }
                    }
                }
            }

            return lista;
        }

        public List<Contabilidad> GenerarEstadoSituacionFinancieraActivos(string empresa, int año1, int año2)
        {
            List<Contabilidad> lista = new List<Contabilidad>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                ""EMPRESA"",
                ""CUENTA"",
                ""FECCHA"",
                ""AÑO"",
                ""CONTABLE"",
                ""RESUMEN"",
                ""LUGAR"",
                ""PAREADO"",
                ""SUBTYPE""
            FROM public.contabilidad
            WHERE ""EMPRESA"" = @empresa 
              AND CAST(""RESUMEN"" AS INTEGER) < 40
              AND ""AÑO"" BETWEEN @año1 AND @año2
 
        ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@empresa", empresa);
                    cmd.Parameters.AddWithValue("@año1", año1);
                    cmd.Parameters.AddWithValue("@año2", año2);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contabilidad c = new Contabilidad
                            {
                                EMPRESA = reader["EMPRESA"].ToString(),
                                CUENTA = reader["CUENTA"].ToString(),
                                FECCHA = reader["FECCHA"].ToString(),
                                AÑO = reader["AÑO"] == DBNull.Value ? 0 : Convert.ToInt64(reader["AÑO"]),
                                CONTABLE = reader["CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["CONTABLE"]),
                                RESUMEN = reader["RESUMEN"].ToString(),
                                LUGAR = reader["LUGAR"].ToString(),
                                PAREADO = reader["PAREADO"].ToString(),
                                SUBTYPE = reader["SUBTYPE"].ToString()
                            };

                            lista.Add(c);
                        }
                    }
                }
            }

            return lista;
        }
        public List<Contabilidad> GenerarEstadoSituacionFinancieraPasivosPatrimonio(string empresa, int año1, int año2)
        {
            List<Contabilidad> lista = new List<Contabilidad>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                ""EMPRESA"",
                ""CUENTA"",
                ""FECCHA"",
                ""AÑO"",
            -1*    ""CONTABLE"" AS ""CONTABLE"",
                ""RESUMEN"",
                ""LUGAR"",
                ""PAREADO"",
                ""SUBTYPE""
            FROM public.contabilidad
            WHERE ""EMPRESA"" = @empresa 
              AND CAST(""RESUMEN"" AS INTEGER) between 40 and 59 
              AND ""AÑO"" BETWEEN @año1 AND @año2

            UNION ALL

            SELECT 
                ""EMPRESA"",
                MAX(""CUENTA"") AS CUENTA,
                MAX(""FECCHA"") AS FECCHA,
                ""AÑO"",
             -1*   SUM(""CONTABLE"") AS CONTABLE,
                '60' AS RESUMEN,
                'PATRIMONIO' AS LUGAR,
                'Resultados del Ejercicio' AS PAREADO, ''
            FROM public.contabilidad
            WHERE ""EMPRESA"" = @empresa
              AND CAST(""RESUMEN"" AS INTEGER) >= 60 
              AND ""AÑO"" BETWEEN @año1 AND @año2
            GROUP BY ""EMPRESA"", ""AÑO"", ""LUGAR""
        ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@empresa", empresa);
                    cmd.Parameters.AddWithValue("@año1", año1);
                    cmd.Parameters.AddWithValue("@año2", año2);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contabilidad c = new Contabilidad
                            {
                                EMPRESA = reader["EMPRESA"].ToString(),
                                CUENTA = reader["CUENTA"].ToString(),
                                FECCHA = reader["FECCHA"].ToString(),
                                AÑO = reader["AÑO"] == DBNull.Value ? 0 : Convert.ToInt64(reader["AÑO"]),
                                CONTABLE = reader["CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["CONTABLE"]),
                                RESUMEN = reader["RESUMEN"].ToString(),
                                LUGAR = reader["LUGAR"].ToString(),
                                PAREADO = reader["PAREADO"].ToString(),
                                SUBTYPE = reader["SUBTYPE"].ToString()
                            };

                            lista.Add(c);
                        }
                    }
                }
            }

            return lista;
        }

        public List<Contabilidad> ObtenerPorEmpresaYFecha(string empresa, int año)
        {
            List<Contabilidad> lista = new List<Contabilidad>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM public.contabilidad WHERE \"EMPRESA\" = @empresa AND \"AÑO\" = @año";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@empresa", empresa);
                    cmd.Parameters.AddWithValue("@año", año);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contabilidad c = new Contabilidad
                            {
                                EMPRESA = reader["EMPRESA"].ToString(),
                                CODIGO_UNIDAD = reader["CODIGO_UNIDAD"].ToString(),
                                UNIDAD_CONTABLE = reader["UNIDAD_CONTABLE"].ToString(),
                                CUENTA = reader["CUENTA"].ToString(),
                                DESCRIPCION_CUENTA = reader["DESCRIPCION_CUENTA"].ToString(),
                                CODIGO_VOCHER = reader["CODIGO_VOCHER"] == DBNull.Value ? 0 : Convert.ToInt64(reader["CODIGO_VOCHER"]),
                                NUMERO_VOUCHER = reader["NUMERO_VOUCHER"] == DBNull.Value ? 0 : Convert.ToInt64(reader["NUMERO_VOUCHER"]),
                                FECCHA = reader["FECCHA"].ToString(),
                                CODIGO_TIPO_ANEXO = reader["CODIGO_TIPO_ANEXO"].ToString(),
                                CODIGO_ANEXO = reader["CODIGO_ANEXO"].ToString(),
                                NOMBRE_ANEXO = reader["NOMBRE_ANEXO"].ToString(),
                                TD_REFERENCIA = reader["TD_REFERENCIA"].ToString(),
                                SERIE_REFERENCIA = reader["SERIE_REFERENCIA"].ToString(),
                                NUMERO_REFERENCIA = reader["NUMERO_REFERENCIA"].ToString(),
                                DEBE_CONTABLE = reader["DEBE_CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_CONTABLE"]),
                                HABER_CONTABLE = reader["HABER_CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_CONTABLE"]),
                                CODIGO_MONEDA_ORIGEN = reader["CODIGO_MONEDA_ORIGEN"].ToString(),
                                TC = reader["TC"] == DBNull.Value ? 0 : Convert.ToDouble(reader["TC"]),
                                DEBE_ORIGEN = reader["DEBE_ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_ORIGEN"]),
                                HABER_ORIGEN = reader["HABER_ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_ORIGEN"]),
                                DEBE_DOLARES = reader["DEBE_DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DEBE_DOLARES"]),
                                HABER_DOLARES = reader["HABER_DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["HABER_DOLARES"]),
                                CENTRO_COSTO = reader["CENTRO_COSTO"].ToString(),
                                GLOSA = reader["GLOSA"].ToString(),
                                NUMERACION = reader["NUMERACION"].ToString(),
                                AÑO = reader["AÑO"] == DBNull.Value ? 0 : Convert.ToInt64(reader["AÑO"]),
                                CONTABLE = reader["CONTABLE"] == DBNull.Value ? 0 : Convert.ToDouble(reader["CONTABLE"]),
                                ORIGEN = reader["ORIGEN"] == DBNull.Value ? 0 : Convert.ToDouble(reader["ORIGEN"]),
                                DOLARES = reader["DOLARES"] == DBNull.Value ? 0 : Convert.ToDouble(reader["DOLARES"]),
                                RESUMEN = reader["RESUMEN"].ToString(),
                                LUGAR = reader["LUGAR"].ToString(),
                                PAREADO = reader["PAREADO"].ToString(),
                                TIPO = reader["TIPO"].ToString(),
                                RELACIONADA = reader["RELACIONADA"].ToString(),
                                SUBTYPE = reader["SUBTYPE"].ToString()
                            };
                            lista.Add(c);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
