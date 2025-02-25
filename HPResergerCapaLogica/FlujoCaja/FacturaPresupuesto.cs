using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class FacturaPresupuesto
    {
        public int Id { get; set; } = 0;
        public int IdFactura { get; set; } = 0;
        public int TipoFactura { get; set; } = 0;
        public int IdPartida { get; set; } = 0;
        public int TipoPartida { get; set; } = 0;

        private readonly string _connectionString;

        public FacturaPresupuesto()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Verifica si la tabla existe, si no, la crea
        public void ValidarTablaExiste()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                              -- Verificar y crear la tabla TBL_FacturasPresupuestos si no existe
                                IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TBL_FacturasPresupuestos')
                                BEGIN
                                    CREATE TABLE dbo.TBL_FacturasPresupuestos (
                                        id INT IDENTITY(1,1) PRIMARY KEY,
                                        idFactura INT NOT NULL,
                                        TipoFactura INT NOT NULL,
                                        idPartida INT NOT NULL,
                                        TipoPartida INT NOT NULL
                                    );
                                END;

                                -- Verificar y crear la tabla TBL_Partidas_Control si no existe
                                IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name = 'TBL_Partidas_Control' AND xtype = 'U')
                                BEGIN
                                    CREATE TABLE dbo.TBL_Partidas_Control (
                                        id INT IDENTITY(1,1) PRIMARY KEY,
                                        Codigo NVARCHAR(50) NOT NULL DEFAULT (''),
                                        Descripcion NVARCHAR(150) NOT NULL DEFAULT (''),
                                        completo NVARCHAR(MAX) NULL,
                                        Tipo INT NOT NULL,
                                        cabecera INT NOT NULL DEFAULT (0),
                                        tag NVARCHAR(50) NOT NULL DEFAULT (''),
                                        estado INT NOT NULL DEFAULT (1),
                                        fecha DATETIME NOT NULL DEFAULT (GETDATE()),
                                        pkempresa INT NOT NULL DEFAULT (0)
                                    );
                                END;


";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Insertar
        public int Insertar(int idfac, int tipofac, int empresa, string codigo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                            declare @id as int=0
                            declare @tipo as int =0

                            select @id = p.id, @tipo = p.Tipo from TBL_Partidas_Control p where codigo =@codigo and pkempresa = @empresa
                            select @id,@tipo
                            INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                                             OUTPUT INSERTED.id
                                                             VALUES (@idFactura, @TipoFactura, @id, @tipo)

";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@TipoFactura", tipofac);
                cmd.Parameters.AddWithValue("@empresa", empresa);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdate(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida
                            SELECT @tipoPartida = p.Tipo 
                            FROM TBL_Partidas_Control p 
                            WHERE p.id = @idPartida;

                            -- Validar si el tipo de partida es NULL (para evitar errores en el insert)
                            IF @tipoPartida IS NULL 
                                SET @tipoPartida = 0;

                            -- Si no existe, insertar un nuevo registro
                            IF @id = 0 
                            BEGIN
                                INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                OUTPUT INSERTED.id
                                VALUES (@idFactura, @tipoFacturas, @idPartida, @tipoPartida);
                            END
                            ELSE 
                            BEGIN
                                -- Si ya existe, actualizar
                                UPDATE TBL_FacturasPresupuestos
                                SET idFactura = @idFactura, 
                                    TipoFactura = @tipoFacturas, 
                                    idPartida = @idPartida, 
                                    TipoPartida = @tipoPartida
                                WHERE id = @id;
                            END

select @id

";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdateBuscarCompras(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT Empresa FROM TBL_FacturaManual WHERE Id = @idfactura AND @tipofacturas = 1
                                UNION ALL 
                                SELECT Empresa FROM TBL_NC_ND_CompraManual WHERE Id = @idfactura AND @tipofacturas = 100
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdateBuscarVentas(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT Empresa FROM TBL_VentaManual WHERE Id = @idfactura AND @tipofacturas = 2
                                UNION ALL 
                                SELECT Empresa FROM TBL_NC_ND_VentaManual WHERE Id = @idfactura AND @tipofacturas = 200
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }   public int InsertarUpdateBuscarPagos(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
 
							DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT fkempresa FROM TBL_Factura_Det WHERE NroFacturaDet = @idfactura AND @tipofacturas = 5
                                
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        // Obtener todos los registros
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_FacturasPresupuestos ORDER BY id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        // Actualizar
        public bool Actualizar(FacturaPresupuesto factura)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_FacturasPresupuestos
                                 SET idFactura = @idFactura, TipoFactura = @TipoFactura, 
                                     idPartida = @idPartida, TipoPartida = @TipoPartida
                                 WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", factura.Id);
                cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@TipoFactura", factura.TipoFactura);
                cmd.Parameters.AddWithValue("@idPartida", factura.IdPartida);
                cmd.Parameters.AddWithValue("@TipoPartida", factura.TipoPartida);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ActualizarR(FacturaPresupuesto factura)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            declare @id as int=0
                            declare @tipo as int =0

                            select @id = p.id, @tipo = p.Tipo from TBL_Partidas_Control p where p.id= @idPartida


                                UPDATE TBL_FacturasPresupuestos
                                 SET idFactura = @idFactura, TipoFactura = @TipoFactura, 
                                     idPartida = @idPartida, TipoPartida = @tipo
                                 WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", factura.Id);
                cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@TipoFactura", factura.TipoFactura);
                cmd.Parameters.AddWithValue("@idPartida", factura.IdPartida);
                cmd.Parameters.AddWithValue("@TipoPartida", factura.TipoPartida);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Eliminar
        public bool Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_FacturasPresupuestos WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
