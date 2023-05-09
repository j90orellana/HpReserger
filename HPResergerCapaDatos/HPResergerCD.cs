using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;

namespace HPResergerCapaDatos
{
    public class HPResergerCD
    {
        abcBaseDatos.Database bd;
        //public string DATASOURCE = "HPLAPTOP";   
        public static string BASEDEDATOS = "";// "Actual";
        public string DATASOURCE = DataBase;
        //public string DATASOURCE = "192.168.0.102";
        //public static string BASEDEDATOS = "sige";
        public string USERID = "jorellana";
        public string USERPASS = "Ore456";
        public static DateTime FechaCaduca;
        public static List<string> ListaBases;
        public static string DataBase;
        public HPResergerCD()
        {
            try
            {
                XmlDocument dato = new XmlDocument();
                dato.Load(Application.StartupPath + "\\Datos.xml");
                var datito = dato.ChildNodes[1];
                if (BASEDEDATOS == "")
                    BASEDEDATOS = datito["BaseDeDatos"].InnerText;
                DataBase = @datito["DataSource"].InnerText;
                var Bases = datito.ChildNodes[2];
                ListaBases = new List<string>();
                foreach (XmlNode item in Bases.ChildNodes)
                {
                    ListaBases.Add(item.InnerText.Trim());
                }
                var licencia = datito.ChildNodes[3];
                var Code = licencia["Code"].InnerText;
                var Key = licencia["Key"].InnerText;
                FechaCaduca = CalculoDeFechaLicencia(Code, Key);
            }
            catch (Exception)
            {
                DATASOURCE = "192.168.0.102";
                BASEDEDATOS = "sige";
            }
            bd = new abcBaseDatos.Database("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; Persist Security Info=True ; user id = " + USERID + "; password = " + USERPASS + "");
        }
        private DateTime CalculoDeFechaLicencia(string code, string key)
        {
            DateTime FechaResul = DateTime.Now;
            if (code.Substring(0, 1) != ((int.Parse(key.Substring(0, 2)) - 9) / 2).ToString())
            {
                return FechaResul;
            }
            if (code.Substring(2, 1) != ((int.Parse(key.Substring(4, 2)) - 7) / 4).ToString())
            {
                return FechaResul;
            }
            int añopart1 = 2000 + ((int.Parse(key.Substring(2, 2)) - 20) / 3);
            int mespar1 = int.Parse(key.Substring(10, 2)) - 12;
            int diapar1 = int.Parse(key.Substring(6, 2)) / 3;
            if ((int.Parse(code.Substring(3, 1)) + int.Parse(code.Substring(1, 1))) != (int.Parse(key.Substring(8, 2))) - diapar1 - (mespar1 * 2))
            {
                return FechaResul;
            }
            return new DateTime(añopart1, mespar1, diapar1);
        }
        public void HPResergerCDs(string BaseDatos)
        {
            BASEDEDATOS = BaseDatos;
            DATASOURCE = @DataBase;
            bd = new abcBaseDatos.Database("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + "");
        }
        public DataTable ListarContratoEmpleado(int tipo, string numero)
        {
            string[] parametros = { "@tipo", "@numero" };
            object[] valores = { tipo, numero };
            return bd.DataTableFromProcedure("usp_get_Empleado_Contrato", parametros, valores, null);
        }
        public void AgregarPerfil(string descripcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_perfil_insertar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 40).Value = descripcion;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarPerfil(int codigo, string descripcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_perfil_actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Value = descripcion;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarPerfil(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_perfil_eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarActualizarUsuario(int codigoid, int tipoid, string nroid, string login, string contra, int perfil, int estado, int opcion, int usuario, out int respuesta)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_inserta_actualizar_usuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@codigoid", SqlDbType.Int).Value = codigoid;
                    cmd.Parameters.Add("@tipoid", SqlDbType.Int).Value = tipoid;
                    cmd.Parameters.Add("@nroid", SqlDbType.VarChar, 14).Value = nroid;
                    cmd.Parameters.Add("@login", SqlDbType.VarChar, 10).Value = login;
                    cmd.Parameters.Add("@contra", SqlDbType.VarChar, 10).Value = contra;
                    cmd.Parameters.Add("@perfil", SqlDbType.Int).Value = perfil;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;

                    cmd.ExecuteNonQuery();
                    respuesta = int.Parse(cmd.Parameters["@respuesta"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable Usuarios(string numeroid, int tipoid, int opcion)
        {
            string[] parametros = { "@numeroid", "@tipoid", "@opcion" };
            object[] valores = { numeroid, tipoid, opcion };
            return bd.DataTableFromProcedure("dbo_usp_usuarios", parametros, valores, null);
        }
        public DataTable BusquedaUsuarios(string nrodoc, string tipo, string nombre, string area, string login)
        {
            string[] parametros = { "@nrodoc", "@tipodoc", "@nombres", "@area", "@login" };
            object[] valores = { nrodoc, tipo, nombre, area, login };
            return bd.DataTableFromProcedure("usp_BusquedaUsuarios", parametros, valores, null);
        }
        public void CambiarContraseña(out int resultado, string usuario, string contrasena, string nueva)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_cambio_contrasena";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@opcion", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 40).Value = usuario;
                    cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 40).Value = contrasena;
                    cmd.Parameters.Add("@nueva", SqlDbType.VarChar, 40).Value = nueva;
                    cmd.ExecuteNonQuery();
                    resultado = int.Parse(cmd.Parameters["@opcion"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ListarAreaGerencia()
        {
            return bd.DataTableFromProcedure("usp_listar_gerencia_area", null, null, null);
        }
        public DataTable ListarAreas(string busca)
        {
            string[] parametro = { "@valor" };
            object[] valor = { busca };
            return bd.DataTableFromProcedure("usp_listar_areas", parametro, valor, null);
        }
        public DataTable ListarAreas()
        {
            return bd.DataTableFromProcedure("usp_get_Areas", null, null, null);
        }
        public void InsertarArea(string valor, int costo, int gerencia)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_area";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Valor", SqlDbType.VarChar, 100).Value = valor;
                    cmd.Parameters.Add("@codcosto", SqlDbType.Int).Value = costo;
                    cmd.Parameters.Add("@codgerencia", SqlDbType.Int).Value = gerencia;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarArea(string valor, int costo, int gerencia, int area)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_area";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Valor", SqlDbType.VarChar, 100).Value = valor;
                    cmd.Parameters.Add("@codcosto", SqlDbType.Int).Value = costo;
                    cmd.Parameters.Add("@codgerencia", SqlDbType.Int).Value = gerencia;
                    cmd.Parameters.Add("@codarea", SqlDbType.Int).Value = area;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarArea(int costo, int gerencia, int area)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_area";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codcosto", SqlDbType.Int).Value = costo;
                    cmd.Parameters.Add("@codgerencia", SqlDbType.Int).Value = gerencia;
                    cmd.Parameters.Add("@codarea", SqlDbType.Int).Value = area;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void AgregarGerencia(string gerencia)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Gerencia_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@gerencia", SqlDbType.VarChar, 100).Value = gerencia;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarGerencia(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_gerencia_eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarGerencia(int codigo, string gerencia)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_gerencia_actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id_Gerencia", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@gerencia", SqlDbType.VarChar, 100).Value = gerencia;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }

        }
        public void InsertarCentroCosto(string codigo, string valor, string tiene, string cuenta)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_centro_ccosto";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = codigo;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;
                    cmd.Parameters.Add("@tiene", SqlDbType.VarChar, 100).Value = tiene;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = cuenta;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarCentroCosto(string valor, string codigos, int codigo, string tiene, string cuenta)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_actualizar_ccosto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;
                    cmd.Parameters.Add("@codigos", SqlDbType.VarChar, 100).Value = codigos;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@tiene", SqlDbType.VarChar, 100).Value = tiene;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = cuenta;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable VerificarArticulo(string articulo)
        {
            string[] parametro = { "@articulo" };
            object[] valor = { articulo };
            return bd.DataTableFromProcedure("usp_verificar_articulo", parametro, valor, null);
        }
        public DataTable VerificarArticuloServicio(string articulo, int marca)
        {
            string[] parametro = { "@articulo", "@marca" };
            object[] valor = { articulo, marca };
            return bd.DataTableFromProcedure("usp_verificar_articulo_servicio", parametro, valor, null);
        }
        public void InsertarArticulo(string descripcion, int stock, int tipo, string observa, int igv, int centro, string cuenta, string cc, string cta, string ctaact)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_articulo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = descripcion;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@observa", SqlDbType.VarChar, 1000).Value = observa;
                    cmd.Parameters.Add("@igv", SqlDbType.Int).Value = igv;
                    cmd.Parameters.Add("@centro", SqlDbType.Int).Value = centro;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = cuenta;
                    cmd.Parameters.Add("@cc", SqlDbType.VarChar, 100).Value = cc;
                    cmd.Parameters.Add("@cta", SqlDbType.VarChar, 20).Value = cta;
                    cmd.Parameters.Add("@ctaact", SqlDbType.VarChar, 20).Value = ctaact;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarArticuloMarca(int marca, int articulo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_articulo_marca";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.Parameters.Add("@arti", SqlDbType.Int).Value = articulo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarArticuloMarca(int art, string desc, int stock, int tipo, string observa, int marca, int marcamod, int igv, int centro, string cuenta, string cc, string cta, string ctaact)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_articulo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@art", SqlDbType.Int).Value = art;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = desc;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@observa", SqlDbType.VarChar, 1000).Value = observa;
                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.Parameters.Add("@modmar", SqlDbType.Int).Value = marcamod;
                    cmd.Parameters.Add("@igv", SqlDbType.Int).Value = igv;
                    cmd.Parameters.Add("@centro", SqlDbType.Int).Value = centro;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = cuenta;
                    cmd.Parameters.Add("@cc", SqlDbType.VarChar, 100).Value = cc;
                    cmd.Parameters.Add("@cta", SqlDbType.VarChar, 20).Value = cta;
                    cmd.Parameters.Add("@ctaact", SqlDbType.VarChar, 20).Value = ctaact;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ElimimarArticuloMarca(int marca, int articulo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_articulo_marca";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@art", SqlDbType.Int).Value = articulo;
                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarMarca(int codigo, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_actualizar_marca";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarMarca(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_marca";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarModelo(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_modelo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarMarca(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_marca";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarMarcaModelo(int marca, int modelo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_marca_codigo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.Parameters.Add("@modelo", SqlDbType.Int).Value = modelo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarMarcaModelo(int marca, int modelo, int modmar, int modmode)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_marca_codigo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.Parameters.Add("@modelo", SqlDbType.Int).Value = modelo;

                    cmd.Parameters.Add("@modmar", SqlDbType.Int).Value = modmar;
                    cmd.Parameters.Add("@modmode", SqlDbType.Int).Value = modmode;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarMarcaModelo(int marca, int modelo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_marca_codigo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = marca;
                    cmd.Parameters.Add("@modelo", SqlDbType.Int).Value = modelo;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarModelo(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_modelo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarModelo(int codigo, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_actualizar_modelo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ListarArticulos(string busca)
        {
            string[] parametro = { "@valor" };
            object[] valor = { busca };
            return bd.DataTableFromProcedure("usp_listar_articulos", parametro, valor, null);
        }
        public DataTable ListarModelos(int codigo)
        {
            string[] parametro = { "@valor" };
            object[] valor = { codigo };
            return bd.DataTableFromProcedure("usp_listar_modelos", parametro, valor, null);
        }
        public DataTable ListarModeloMarca(string busca)
        {
            string[] parametro = { "@valor" };
            object[] valor = { busca };
            return bd.DataTableFromProcedure("usp_listar_modelo_marca", parametro, valor, null);

        }
        public DataTable VerificarMarcaModelo(int marca, int modelo)
        {
            string[] parametro = { "@marca", "@modelo" };
            object[] valor = { marca, modelo };
            return bd.DataTableFromProcedure("usp_verificar_marca_modelo", parametro, valor, null);

        }
        public DataTable getCargoTipoContratacion2(string Campo1, string Campo2, string Tabla)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Tabla" };
            object[] valores = { Campo1, Campo2, Tabla };
            return bd.DataTableFromProcedure("usp_get_CargoTipoContratacion2", parametros, valores, null);
        }
        public DataTable getCargoTipoContratacion3(string Campo1, string Campo2, string Campo3, string Tabla, string busca)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Campo3", "@Tabla", "@Busca" };
            object[] valores = { Campo1, Campo2, Campo3, Tabla, busca };
            return bd.DataTableFromProcedure("usp_get_CargoTipoContratacion3", parametros, valores, null);
        }
        public DataTable getCargoTipoContratacion6(string Campo1, string Campo2, string Campo3, string Campo4, string Tabla, string busca, string busca2)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Campo3", "@Campo4", "@Tabla", "@Busca", "@Busca2" };
            object[] valores = { Campo1, Campo2, Campo3, Campo4, Tabla, busca, busca2 };
            return bd.DataTableFromProcedure("usp_get_CargoTipoContratacion6", parametros, valores, null);
        }

        public DataTable ListarProvincia(int Departamento)
        {
            string[] parametros = { "@Cod_Dept" };
            object[] valores = { Departamento };
            return bd.DataTableFromProcedure("usp_Get_Provincia", parametros, valores, null);
        }

        public DataTable ListarDistrito(int Departamento, int Provincia)
        {
            string[] parametros = { "@Cod_Dept", "@Cod_Prov" };
            object[] valores = { Departamento, Provincia };
            return bd.DataTableFromProcedure("usp_Get_Distrito", parametros, valores, null);
        }
        public DataTable VerificarProvincias(int coddep)
        {
            string[] parametro = { "@coddep" };
            object[] valor = { coddep };
            return bd.DataTableFromProcedure("usp_verificar_provincia", parametro, valor, null);
        }
        public DataTable ListarProvincia(string buscar)
        {
            string[] parametros = { "@Buscar" };
            object[] valor = { buscar };
            return bd.DataTableFromProcedure("usp_listar_provincias", parametros, valor, null);
        }
        public void InsertarDepartamento(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_departamento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 50).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarDepartamento(string valor, int dep)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_actualizar_departamento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 200).Value = valor;
                    cmd.Parameters.Add("@dep", SqlDbType.Int).Value = dep;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarDepartamento(int dep)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_eliminar_departamento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dep", SqlDbType.Int).Value = dep;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ModificarDistrito(int dep, int pro, int dis, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_modificar_distrito";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@coddep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@codpro", SqlDbType.Int).Value = pro;
                    cmd.Parameters.Add("@coddis", SqlDbType.Int).Value = dis;
                    cmd.Parameters.Add("@valor", SqlDbType.Char).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarDistrito(int dep, int pro, int dis)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_eliminar_distrito";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@coddep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@codpro", SqlDbType.Int).Value = pro;
                    cmd.Parameters.Add("@coddis", SqlDbType.Int).Value = dis;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable listar_Departamentos(string buscar)
        {
            string[] parametros = { "@Buscar" };
            object[] valor = { buscar };
            return bd.DataTableFromProcedure("usp_Listar_Departamento", parametros, valor, null);
        }

        public DataTable ELiminarReflejosdeCierreApertura(DateTime fechaContable, int fkEmpresa)
        {
            string[] parametros = { "@FechaContable", "@pkEmpresa" };
            object[] valor = { fechaContable, fkEmpresa };
            return bd.DataTableFromProcedure("usp_ELiminarReflejosdeCierreApertura", parametros, valor, null);
        }

        public DataTable listar_Provincias(int codigo, string buscar)
        {
            string[] parametros = { "@coddep", "@Buscar" };
            object[] valor = { codigo, buscar };
            return bd.DataTableFromProcedure("usp_Listar_Provincia", parametros, valor, null);
        }
        public DataTable listar_Distrito(int coddep, int codpro, string buscar)
        {
            string[] parametros = { "@codpro", "@coddep", "@Buscar" };
            object[] valor = { codpro, coddep, buscar };
            return bd.DataTableFromProcedure("usp_Listar_Distrito", parametros, valor, null);
        }
        public void insertarprovincia(int dep, int pro, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_provincia";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@pro", SqlDbType.Int).Value = pro;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void actualizarprovincia(int dep, int pro, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_actualizar_provincia";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@pro", SqlDbType.Int).Value = pro;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void eliminarprovincia(int dep, int pro)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_eliminar_provincia";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@pro", SqlDbType.Int).Value = pro;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable VerificarDistritos(int coddep, int codpro)
        {
            string[] parametro = { "@coddep", "@codpro" };
            object[] valor = { coddep, codpro };
            return bd.DataTableFromProcedure("usp_verificar_distrito", parametro, valor, null);
        }
        public DataRow ValidarDistrito(string validar)
        {
            string[] parametro = { "@Buscar" };
            object[] valor = { validar };
            return bd.DatarowFromProcedure("usp_validar_distrito", parametro, valor, null);
        }
        public void InsertarDistrito(int dep, int pro, int dis, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_distrito";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@coddep", SqlDbType.Int).Value = dep;
                    cmd.Parameters.Add("@codpro", SqlDbType.Int).Value = pro;
                    cmd.Parameters.Add("@coddis", SqlDbType.Int).Value = dis;
                    cmd.Parameters.Add("@valor", SqlDbType.Char).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ListarDistritos(string cadena)
        {
            string[] parametros = { "@Buscar" };
            object[] valores = { cadena };
            return bd.DataTableFromProcedure("usp_Listar_Distritos", parametros, valores, null);
        }
        public void AgregarEntiFinanciera(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Entidad_Financiera_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Value = valor;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarEntiFinanciera(int codigo, string descripcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Entidad_Financiera_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Value = descripcion;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }

        }
        public void EliminarEntiFinanciera(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Entidad_Financiera_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void AgregarParPresupuesto(string presupuesto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_ParPresupuesto_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@presupuesto", SqlDbType.VarChar, 100).Value = presupuesto;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void AgregarTipoId(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_TipoId_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tipoid", SqlDbType.VarChar, 20).Value = valor;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarTipoId(int codigo, string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_TipoId_actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 20).Value = valor;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarParPresupuesto(int codigo, string presupuesto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_ParPresupuesto_actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@presupuesto", SqlDbType.VarChar, 100).Value = presupuesto;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }

        }
        public void EliminarTipoId(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_TipoId_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarParPResupuesto(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_ParPresupuesto_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ListarProveedores(string busca, int opcion)
        {
            string[] parametros = { "@busca", "@opcion" };
            object[] valor = { busca, opcion };
            return bd.DataTableFromProcedure("usp_listar_proveedores", parametros, valor, null);
        }

        public DataTable ListarCuentasContables(string busca, int opcion)
        {
            string[] parametros = { "@busca", "@opcion" };
            object[] valor = { busca, opcion };
            return bd.DataTableFromProcedure("usp_listar_cuentas_contables", parametros, valor, null);

        }
        public DataTable ListarDinamicaContable(string busca, int opcion)
        {
            string[] parametros = { "@buscar", "@opcion" };
            object[] valor = { busca, opcion };
            return bd.DataTableFromProcedure("usp_buscar_dinamicas", parametros, valor, null);

        }
        public DataTable SacarDinamicas(string busca)
        {
            string[] parametros = { "@buscar" };
            object[] valor = { busca };
            return bd.DataTableFromProcedure("usp_sacar_dinamicas", parametros, valor, null);

        }
        public DataTable UltimaDinamica()
        {
            return bd.DataTableFromProcedure("usp_ultima_dinamica", null, null, null);
        }

        public void InsertarDinamica(int codigo, int ejercicio, int codope, int codsub, string cuenta, string debe, int estado, int solicita, string glosa)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_dinamica";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@ejercicio", SqlDbType.Int).Value = ejercicio;
                    cmd.Parameters.Add("@codope", SqlDbType.Int).Value = codope;
                    cmd.Parameters.Add("@codsub", SqlDbType.Int).Value = codsub;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 12).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.VarChar, 150).Value = debe;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@solicita", SqlDbType.Int).Value = solicita;
                    cmd.Parameters.Add("@glosa", SqlDbType.VarChar, 300).Value = glosa;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ModificarDinamica(int codigo, int ejercicio, int codope, int codsub, string cuenta, string debe, int estado, int solicita, string glosa)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_modificar_dinamica";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@ejercicio", SqlDbType.Int).Value = ejercicio;
                    cmd.Parameters.Add("@codope", SqlDbType.Int).Value = codope;
                    cmd.Parameters.Add("@codsub", SqlDbType.Int).Value = codsub;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 12).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.VarChar, 150).Value = debe;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@solicita", SqlDbType.Int).Value = solicita;
                    cmd.Parameters.Add("@glosa", SqlDbType.VarChar, 300).Value = glosa;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void Modificar2Dinamica(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_modificar2_dinamica";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarDinamica(int codigo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_dinamica";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ListarAsientosContables(string busca, int opcion, DateTime fechaini, DateTime fechafin, int fecha, int empresa)
        {
            string[] parametros = { "@buscar", "@opcion", "@fechaini", "@fechafin", "@fecha", "@empresa" };
            object[] valor = { busca, opcion, fechaini, fechafin, fecha, empresa };
            return bd.DataTableFromProcedure("usp_listar_asientos", parametros, valor, null);
        }
        public DataRow ConsultarParametros(DateTime Fecha, string campo)
        {
            string[] parametros = { "@fecha", "@campo" };
            object[] valores = { Fecha, campo };
            return bd.DatarowFromProcedure("usp_ConsultarParametros", parametros, valores, null);
        }
        public DataRow AfpDetalle_BusquedaFecha(DateTime Fecha)
        {
            string[] parametros = { "@fecha" };
            object[] valores = { Fecha };
            return bd.DatarowFromProcedure("usp_AfpDetalle_BusquedaFecha", parametros, valores, null);
        }
        public DataTable ConsultarEmpleadosActivos(int empresa, DateTime fecha)
        {
            string[] parametros = { "@empresa", "@fecha" };
            object[] valores = { empresa, fecha };
            return bd.DataTableFromProcedure("usp_ConsultarEmpleadosActivos", parametros, valores, null);
        }
        public DataTable ContarCantidadAsientos(int empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valor = { empresa };
            return bd.DataTableFromProcedure("usp_ContarCantidadAsientos", parametros, valor, null);
        }
        public DataTable BusquedaFacturasdeCadena(string cadena)
        {
            string[] parametros = { "@cadena" };
            object[] valor = { cadena };
            return bd.DataTableFromProcedure("usp_BusquedaFacturasdeCadena", parametros, valor, null);
        }
        public DataTable Facturas_EPS_Listar(int @opcion, int @pkid, int @fkempresa, DateTime @Periodo, int @CantTrabajadores, decimal @TotalFacturas, decimal @UIT, decimal @TopeLegal,
            string @ListaFacturas, decimal @AporteESSALUD, decimal @SueldosEPS_F, decimal @MontoCredito_F, int @Estado, DateTime @Fecha, int @Usuario)
        {
            string[] parametros = { "@opcion", "@pkid", "@fkempresa", "@Periodo", "@CantTrabajadores", "@TotalFacturas", "@UIT", "@TopeLegal", "@ListaFacturas", "@AporteESSALUD", "@SueldosEPS_F", "@MontoCredito_F", "@Estado", "@Fecha", "@Usuario" };
            object[] valor = { @opcion, @pkid, @fkempresa, @Periodo, @CantTrabajadores, @TotalFacturas, @UIT, @TopeLegal, @ListaFacturas, @AporteESSALUD, @SueldosEPS_F, @MontoCredito_F, @Estado, @Fecha, @Usuario };
            return bd.DataTableFromProcedure("usp_Facturas_EPS_Listar", parametros, valor, null);
        }
        public DataTable Facturas_EPS_Listar()
        {
            return bd.DataTableFromProcedure("usp_Facturas_EPS_Listar", null, null, null);
        }
        public DataTable ListarAsientosFiltrados(int empresa, DateTime Fechaini, DateTime Fechafin, string cuo, string cuenta, string glosa, string suboperacion)
        {
            string[] parametros = { "@empresa", "@fechaini", "@fechafin", "@cuo", "@cuenta", "@glosa", "@SubOperacion" };
            object[] valor = { empresa, Fechaini, Fechafin, cuo, cuenta, glosa, suboperacion };
            return bd.DataTableFromProcedure("usp_ListarAsientosFiltrados", parametros, valor, null);
        }
        public DataTable ListarAsientosFiltradosAvanzado(int empresa, DateTime Fechaini, DateTime Fechafin, string cuo, string cuenta, string glosa, string suboperacion, int Estado)
        {
            string[] parametros = { "@empresa", "@fechaini", "@fechafin", "@cuo", "@cuenta", "@glosa", "@SubOperacion", "@estado" };
            object[] valor = { empresa, Fechaini, Fechafin, cuo, cuenta, glosa, suboperacion, Estado };
            return bd.DataTableFromProcedure("usp_ListarAsientosFiltradosAvanzado", parametros, valor, null);
        }
        public DataTable UltimoAsiento(int empresan, DateTime _Fecha)
        {
            string[] parametros = { "@empresa", "@Fecha" };
            object[] valores = { empresan, _Fecha };
            return bd.DataTableFromProcedure("usp_ultimo_asiento", parametros, valores, null);
        }
        public DataTable UltimoAsientoFactura(string numfac, string proveedor, DateTime _Fechas)
        {
            string[] parametros = { "@numfac", "@prove", "@Fechas" };
            object[] valores = { numfac, proveedor, _Fechas };
            return bd.DataTableFromProcedure("usp_ultimo_asiento_Factura", parametros, valores, null);
        }
        public DataTable BuscarAsientosContables(string busca, int opcion, int empresa)
        {
            string[] parametros = { "@buscar", "@opcion", "@empresa" };
            object[] valor = { busca, opcion, empresa };
            return bd.DataTableFromProcedure("usp_buscar_asientos", parametros, valor, null);
        }
        public DataTable BuscarAsientosContablesconTodo(string busca, int opcion, int empresa, DateTime fechon)
        {
            string[] parametros = { "@buscar", "@opcion", "@empresa", "@fechon" };
            object[] valor = { busca, opcion, empresa, fechon };
            return bd.DataTableFromProcedure("usp_buscar_asientos_ConTodo", parametros, valor, null);
        }
        public DataTable ListarCuentas()
        {
            return bd.DataTableFromProcedure("usp_ListarCuentas", null, null, null);
        }
        public DataTable BuscarCuentasQuery(string cuenta)
        {
            string[] parametros = { "@id" };
            object[] valor = { cuenta };
            ParameterDirection[] direccion = { ParameterDirection.InputOutput };
            string sql = "SELECT Id_Cuenta_Contable,Cuenta_Contable FROM TBL_Cuenta_Contable WHERE Id_Cuenta_Contable = @id";
            return bd.DataTableFromQuery(sql, parametros, valor, direccion);
        }
        public DataTable BuscarProveedorQuery(string Name)
        {
            string[] parametros = { "@id" };
            object[] valor = { Name };
            ParameterDirection[] direccion = { ParameterDirection.InputOutput };
            string sql = "SELECT Tipo_Id,RUC,razon_social,nombre_comercial FROM TBL_Proveedor WHERE ruc = @id";
            return bd.DataTableFromQuery(sql, parametros, valor, direccion);
        }
        public DataTable BuscarSolicitanteQuery(string Name)
        {
            string[] parametros = { "@id" };
            object[] valor = { Name };
            ParameterDirection[] direccion = { ParameterDirection.InputOutput };
            string sql = "SELECT * FROM TBL_Empleado e INNER JOIN TBL_Tipo_ID i ON e.Tipo_ID_Emp = i.Codigo_Tipo_ID WHERE @id = CONCAT(i.Desc_Tipo_ID, '-', Nro_ID_Emp)";
            return bd.DataTableFromQuery(sql, parametros, valor, direccion);
        }
        public DataTable BuscarClienteQuery(string Name)
        {
            string[] parametros = { "@id" };
            object[] valor = { Name };
            ParameterDirection[] direccion = { ParameterDirection.InputOutput };
            string sql = "SELECT Tipo_Id_Cli,Nro_Id_Cli,Apepat_RazSoc_Cli,Apemat_Cli,Nombres_Cli FROM TBL_Cliente WHERE Nro_Id_Cli = @id";
            return bd.DataTableFromQuery(sql, parametros, valor, direccion);
        }
        public DataTable DetalleAsientos(int opcion, int idaux, int idasiento, string cuenta, int tipodoc, string numdoc, string razon, int idcomprobante, string codcomprobante, string numcomprobante, int centrocosto, string glosa
           , DateTime fechaemision, DateTime fechavence, decimal importemn, decimal importeme, decimal tipocambio, int usuario, int proyecto, DateTime fecharecepcion, int moneda, DateTime FechaAsiento, int ctabancaria,
            string fkasi, string nroop, int tipopago)
        {
            string[] parametros = { "@opcion", "@idaux", "@idasiento", "@cuenta", "@tipodoc", "@numdoc", "@razon", "@idComprobante", "@codcomprobante", "@numcomprobante", "@centrocosto", "@glosa"
                    , "@fechaemision","@fechavence", "@importemn", "@importeme", "@tipocambio", "@usuario","@fkproyecto","@fecharecepcion","@fkmoneda","@Fechaasiento","@Ctabancaria","@Fkasi","@nroop","@tipopago" };
            object[] valor = { opcion, idaux, idasiento, cuenta, tipodoc, numdoc, razon, idcomprobante, codcomprobante, numcomprobante, centrocosto, glosa, fechaemision, fechavence, importemn, importeme, tipocambio,
                usuario, proyecto, fecharecepcion, moneda, FechaAsiento, ctabancaria, fkasi, nroop,tipopago };
            return bd.DataTableFromProcedure("usp_DetalleAsientos", parametros, valor, null);
        }
        public DataTable DuplicarDetalle(int idaux, int idasiento, int idproyecto, int duplicar, string cuenta, DateTime _FEchas)
        {
            string[] parametros = { "@idaux", "@idasiento", "@proyecto", "@duplicar", "@cuenta", "@fechas" };
            object[] valores = { idaux, idasiento, idproyecto, duplicar, cuenta, _FEchas };
            return bd.DataTableFromProcedure("usp_DuplicarDetalle", parametros, valores, null);
        }
        public DataTable BuscarSiDuplica(int idaux, int idasiento, int idproyecto, string cuenta, DateTime fecha)
        {
            string[] parametros = { "@idaux", "@idasiento", "@proyecto", "@cuenta", "@fecha" };
            object[] valores = { idaux, idasiento, idproyecto, cuenta, fecha };
            return bd.DataTableFromProcedure("usp_BuscarSiDuplica", parametros, valores, null);
        }
        public void ActualizarDetalleAsiento(int oldasiento, int oldproyecto, DateTime oldfecha, int newasiento, int newproyecto, DateTime newfecha)
        {
            string[] parametros = { "@Oldidasiento", "@Oldproyecto", "@Oldfecha", "@Newidasiento", "@Newproyecto", "@Newfecha" };
            object[] valores = { oldasiento, oldproyecto, oldfecha, newasiento, newproyecto, newfecha };
            bd.DataTableFromProcedure("usp_ActualizarDetalleAsiento", parametros, valores, null);
        }
        public void ActualizarDetalleAsientoCambioPeriodo(int oldasiento, int oldproyecto, DateTime oldfecha, int newasiento, int newproyecto, DateTime newfecha)
        {
            string[] parametros = { "@Oldidasiento", "@Oldproyecto", "@Oldfecha", "@Newidasiento", "@Newproyecto", "@Newfecha" };
            object[] valores = { oldasiento, oldproyecto, oldfecha, newasiento, newproyecto, newfecha };
            bd.DataTableFromProcedure("usp_ActualizarDetalleAsientoCambioPeriodo", parametros, valores, null);
        }
        public void InsertarAsiento(int id, int codigo, DateTime fecha, string cuenta, decimal debe, decimal haber, int dina, int estado, DateTime? fechavalor, int proyecto, int etapa, string glosa, int moneda, decimal tc)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_asiento_contable";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 12).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.Decimal).Value = debe;
                    cmd.Parameters.Add("@haber", SqlDbType.Decimal).Value = haber;
                    cmd.Parameters.Add("@dina", SqlDbType.Int).Value = dina;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@fechavalor", SqlDbType.DateTime).Value = fechavalor;
                    cmd.Parameters.Add("@proyec", SqlDbType.Int).Value = proyecto;
                    cmd.Parameters.Add("@etapa", SqlDbType.Int).Value = etapa;
                    cmd.Parameters.Add("@glosa", SqlDbType.NVarChar, 300).Value = glosa;
                    cmd.Parameters.Add("@tc", SqlDbType.Decimal).Value = tc;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { }
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarAsiento(int id, int codigo, DateTime fecha, string cuenta, double debe, double haber, int dina, int estado, DateTime? fechavalor, int proyecto, int etapa, string glosa, int moneda, decimal tc)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_asiento_contable";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                    cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 12).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.Decimal).Value = debe;
                    cmd.Parameters.Add("@haber", SqlDbType.Decimal).Value = haber;
                    cmd.Parameters.Add("@dina", SqlDbType.Int).Value = dina;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@fechavalor", SqlDbType.DateTime).Value = fechavalor;
                    cmd.Parameters.Add("@proyec", SqlDbType.Int).Value = proyecto;
                    cmd.Parameters.Add("@etapa", SqlDbType.Int).Value = etapa;
                    cmd.Parameters.Add("@glosa", SqlDbType.NVarChar, 300).Value = glosa;
                    cmd.Parameters.Add("@tc", SqlDbType.Decimal).Value = tc;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) { }
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void Modificar2asiento(int codigo, int proyecto, DateTime Fechas)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_modificar2_asiento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@proyecto", SqlDbType.Int).Value = proyecto;
                    cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = Fechas;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable FacturaManualDatosAdicionales(int opcion, int idfactura, int igv, int TIPO)
        {
            // 0 : Actualiza e Inserta
            //10: Muestra el dato de la factura
            string[] parametros = { "@idfactura", "@igv", "@opcion", "@tipo" };
            object[] valores = { idfactura, igv, opcion, TIPO };
            return bd.DataTableFromProcedure("usp_FacturaManual_Adicionales", parametros, valores, null);
        }

        public void EliminarASiento(int codigo, int proyecto, DateTime fecha)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_eliminar_asiento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@proyecto", SqlDbType.Int).Value = proyecto;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarASiento(string Cuo, int empresa, DateTime fechacontable, int Reversa)
        {
            string[] parametros = { "@cuo", "@empresa", "@fechacontable", "@Reversa" };
            object[] valores = { Cuo, empresa, fechacontable, Reversa };
            bd.DataTableFromProcedure("usp_EliminarAsientoxCuo", parametros, valores, null);
        }
        public DataTable BuscarCuenta(string buscar, int opcion, string Naturaleza)
        {
            string[] parametros = { "@buscar", "@opcion", "@natu" };
            object[] valores = { buscar, opcion, Naturaleza };
            return bd.DataTableFromProcedure("usp_buscar_cuenta", parametros, valores, null);
        }
        public DataTable BuscarcuentasInterEmpresas(int Fkmoneda)
        {
            string[] parametros = { "@fkmoneda" };
            object[] valores = { Fkmoneda };
            return bd.DataTableFromProcedure("usp_ListarCuentasInterEmpresas", parametros, valores, null);
        }
        public DataTable VerificarProveedores(string codigo, string razon)
        {
            string[] parametros = { "@codigo", "@razon" };
            object[] valor = { codigo, razon };
            return bd.DataTableFromProcedure("usp_verificar_proveedor", parametros, valor, null);
        }
        public DataTable SiguienteIdPrestamoInterEmpresa(int fkEmpresa)
        {
            string[] parametros = { "@empresa" };
            object[] valor = { fkEmpresa };
            return bd.DataTableFromProcedure("usp_SiguienteIdPrestamoInterEmpresa", parametros, valor, null);
        }
        public DataTable VerificarCuentas(string codigo, string nombre)
        {
            string[] parametros = { "@codigo", "@nombre" };
            object[] valor = { codigo, nombre };
            return bd.DataTableFromProcedure("usp_verificar_cuentas_contables", parametros, valor, null);
        }
        public void InsertarCuentasContables(string cuentan1, string codcuenta, string nombre, string tipo, string natu, string generica, string grupo,
       string refleja, string reflejacc, string reflejadebe, string reflejahaber, string cuentacierre, string analitica, string mensual, string cierre,
       string traslacion, string bc, int soli, int cabecera, int estado, int @interempresa)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_cuentas_contables";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@cuentan1", SqlDbType.VarChar, 150).Value = cuentan1;
                    cmd.Parameters.Add("@codcuenta", SqlDbType.VarChar, 12).Value = codcuenta;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = nombre;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 150).Value = tipo;
                    cmd.Parameters.Add("@natu", SqlDbType.VarChar, 150).Value = natu;

                    cmd.Parameters.Add("@generica", SqlDbType.VarChar, 150).Value = generica;
                    cmd.Parameters.Add("@grupo", SqlDbType.VarChar, 150).Value = grupo;
                    cmd.Parameters.Add("@refleja", SqlDbType.VarChar, 150).Value = refleja;
                    cmd.Parameters.Add("@reflejacc", SqlDbType.VarChar, 150).Value = reflejacc;
                    cmd.Parameters.Add("@reflejadebe", SqlDbType.VarChar, 150).Value = reflejadebe;

                    cmd.Parameters.Add("@reflejahaber", SqlDbType.VarChar, 150).Value = reflejahaber;
                    cmd.Parameters.Add("@cuentacierre", SqlDbType.VarChar, 150).Value = cuentacierre;
                    cmd.Parameters.Add("@analitica", SqlDbType.VarChar, 150).Value = analitica;
                    cmd.Parameters.Add("@mensual", SqlDbType.VarChar, 150).Value = mensual;
                    cmd.Parameters.Add("@cierre", SqlDbType.VarChar, 150).Value = cierre;

                    cmd.Parameters.Add("@traslacion", SqlDbType.VarChar, 150).Value = traslacion;
                    cmd.Parameters.Add("@bc", SqlDbType.VarChar, 150).Value = bc;
                    cmd.Parameters.Add("@soli", SqlDbType.Int).Value = soli;
                    cmd.Parameters.Add("@Cabecera", SqlDbType.Int).Value = cabecera;
                    cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@interempresa", SqlDbType.Int).Value = @interempresa;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarCuentasContables(string oldcodcuenta, string codcuenta, string cuentan1, string DesCuentea, string TipoCuenta, string generica, string grupo,
            string refleja, string reflejacc, string reflejadebe, string reflejahaber, string cuentacierre, string analitica, string mensual, string cierre,
            string traslacion, string bc, string naturaleza, int soli, int cabecera, int estado, int @interempresa)
        {
            string[] parametros = { "@oldcodcuenta", "@codcuenta", "@cuentan1", "@DesCuentea", "@TipoCuenta", "@generica", "@grupo", "@refleja", "@reflejacc", "@reflejadebe", "@reflejahaber", "@cuentacierre", "@analitica", "@mensual", "@cierre", "@traslacion", "@bc", "@naturaleza", "@soli", "@cabecera", "@Estado", "@interempresa" };
            object[] valores = { oldcodcuenta, codcuenta, cuentan1, DesCuentea, TipoCuenta, generica, grupo, refleja, reflejacc, reflejadebe, reflejahaber, cuentacierre, analitica, mensual, cierre, traslacion, bc, naturaleza, soli, cabecera, estado, @interempresa };
            bd.DataTableFromProcedure("usp_actualizar_cuentas_contables", parametros, valores, null);
        }
        public DataRow CuentaContable_EnUso(int opcion, string cuenta)
        {
            string[] parametros = { "@opcion", "@cuenta" };
            object[] valores = { opcion, cuenta };
            return bd.DatarowFromProcedure("usp_CuentaContable_EnUso", parametros, valores, null);
        }
        public void InsertarProveedor(int tipoid, string anterior, string ruc, string razon, string nombre, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
            string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int tipoper, int ctaasoles, int ctadolares, int plazo,
            int condicion, int estado, Boolean nuevorus, Boolean retencion, Boolean buencontribuyente, Boolean percepcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_proveedor";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipoid", SqlDbType.Int).Value = tipoid;
                    cmd.Parameters.Add("@ruc", SqlDbType.NVarChar, 150).Value = ruc;
                    cmd.Parameters.Add("@anterior", SqlDbType.VarChar, 150).Value = anterior;
                    cmd.Parameters.Add("@sector", SqlDbType.Int).Value = sector;
                    cmd.Parameters.Add("@razon", SqlDbType.VarChar, 150).Value = razon;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = nombre;
                    cmd.Parameters.Add("@dirofi", SqlDbType.VarChar, 150).Value = dirofi;

                    cmd.Parameters.Add("@telofi", SqlDbType.VarChar, 150).Value = telofi;
                    cmd.Parameters.Add("@diralm", SqlDbType.VarChar, 150).Value = diralm;
                    cmd.Parameters.Add("@telalm", SqlDbType.VarChar, 150).Value = telalm;
                    cmd.Parameters.Add("@dirsuc", SqlDbType.VarChar, 150).Value = dirsuc;
                    cmd.Parameters.Add("@telsuc", SqlDbType.VarChar, 150).Value = telsuc;

                    cmd.Parameters.Add("@telcon", SqlDbType.VarChar, 150).Value = telcon;
                    cmd.Parameters.Add("@nomcon", SqlDbType.VarChar, 150).Value = nomcon;
                    cmd.Parameters.Add("@emacon", SqlDbType.VarChar, 150).Value = emacon;
                    cmd.Parameters.Add("@nctasoles", SqlDbType.VarChar, 150).Value = nctasoles;
                    cmd.Parameters.Add("@ccisoles", SqlDbType.VarChar, 150).Value = ccisoles;

                    cmd.Parameters.Add("@bancosoles", SqlDbType.Int).Value = bancosoles;
                    cmd.Parameters.Add("@nroctadolares", SqlDbType.VarChar, 150).Value = nroctadolares;
                    cmd.Parameters.Add("@ccidolares", SqlDbType.VarChar, 150).Value = ccidolares;
                    cmd.Parameters.Add("@bancodolares", SqlDbType.Int).Value = bancodolares;
                    cmd.Parameters.Add("@detrac", SqlDbType.VarChar, 150).Value = detrac;
                    cmd.Parameters.Add("@tipoper", SqlDbType.Int).Value = tipoper;
                    cmd.Parameters.Add("@ctasoles", SqlDbType.Int).Value = ctaasoles;
                    cmd.Parameters.Add("@ctadolares", SqlDbType.Int).Value = ctadolares;

                    cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = condicion;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@nuevorus", SqlDbType.Bit).Value = nuevorus;
                    cmd.Parameters.Add("@retencion", SqlDbType.Bit).Value = retencion;
                    cmd.Parameters.Add("@buencontribuyente", SqlDbType.Bit).Value = buencontribuyente;
                    cmd.Parameters.Add("@percepcion", SqlDbType.Bit).Value = percepcion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataRow ActualizarProveedor(int tipoid, int anteriortipoid, string anteriorRuc, string ruc, string razon, string nombrecomercial, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
           string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int tipoper, int ctaasoles, int ctadolares, int plazofijo
            , int condicion, int estado, Boolean nuevorus, Boolean retencion, Boolean buencontribuyente, Boolean percepcion)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_proveedor";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@tipoid", SqlDbType.Int).Value = tipoid;
                    cmd.Parameters.Add("@ruc", SqlDbType.NVarChar, 150).Value = ruc;
                    cmd.Parameters.Add("@anteriortipoid", SqlDbType.Int).Value = anteriortipoid;
                    cmd.Parameters.Add("@anterior", SqlDbType.VarChar, 150).Value = anteriorRuc;
                    cmd.Parameters.Add("@razon", SqlDbType.VarChar, 150).Value = razon;
                    cmd.Parameters.Add("@nombrecomercial", SqlDbType.VarChar, 150).Value = nombrecomercial;

                    cmd.Parameters.Add("@sector", SqlDbType.Int).Value = sector;
                    cmd.Parameters.Add("@dirofi", SqlDbType.VarChar, 150).Value = dirofi;
                    cmd.Parameters.Add("@telofi", SqlDbType.VarChar, 150).Value = telofi;
                    cmd.Parameters.Add("@diralm", SqlDbType.VarChar, 150).Value = diralm;

                    cmd.Parameters.Add("@telalm", SqlDbType.VarChar, 150).Value = telalm;
                    cmd.Parameters.Add("@dirsuc", SqlDbType.VarChar, 150).Value = dirsuc;
                    cmd.Parameters.Add("@telsuc", SqlDbType.VarChar, 150).Value = telsuc;
                    cmd.Parameters.Add("@telcon", SqlDbType.VarChar, 150).Value = telcon;
                    cmd.Parameters.Add("@nomcon", SqlDbType.VarChar, 150).Value = nomcon;

                    cmd.Parameters.Add("@emacon", SqlDbType.VarChar, 150).Value = emacon;
                    cmd.Parameters.Add("@nctasoles", SqlDbType.VarChar, 150).Value = nctasoles;
                    cmd.Parameters.Add("@ccisoles", SqlDbType.VarChar, 150).Value = ccisoles;
                    cmd.Parameters.Add("@bancosoles", SqlDbType.Int).Value = bancosoles;
                    cmd.Parameters.Add("@nroctadolares", SqlDbType.VarChar, 150).Value = nroctadolares;

                    cmd.Parameters.Add("@ccidolares", SqlDbType.VarChar, 150).Value = ccidolares;
                    cmd.Parameters.Add("@bancodolares", SqlDbType.Int).Value = bancodolares;
                    cmd.Parameters.Add("@detrac", SqlDbType.VarChar, 150).Value = detrac;
                    cmd.Parameters.Add("@tipoper", SqlDbType.Int).Value = tipoper;
                    cmd.Parameters.Add("@ctasoles", SqlDbType.Int).Value = ctaasoles;
                    cmd.Parameters.Add("@ctadolares", SqlDbType.Int).Value = ctadolares;
                    cmd.Parameters.Add("@plazopago", SqlDbType.Int).Value = plazofijo;

                    cmd.Parameters.Add("@condicion", SqlDbType.Int).Value = condicion;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@nuevorus", SqlDbType.Bit).Value = nuevorus;
                    cmd.Parameters.Add("@retencion", SqlDbType.Bit).Value = retencion;
                    cmd.Parameters.Add("@buencontribuyente", SqlDbType.Bit).Value = buencontribuyente;
                    cmd.Parameters.Add("@percepcion", SqlDbType.Bit).Value = percepcion;

                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    da.Fill(tabla);
                }
                cn.Close();
                cn.Dispose();
                return tabla.Rows[0];
            }
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <returns></returns>
        public DataRow EliminarProveedor(int tipoid, string nrodoc)
        {
            string[] parametros = { "@tipoid", "@nrodoc" };
            object[] valores = { tipoid, nrodoc };
            return bd.DatarowFromProcedure("usp_EliminarProveedor", parametros, valores, null);
        }
        public DataRow EliminarCliente(int tipoid, string nrodoc)
        {
            string[] parametros = { "@tipoid", "@nrodoc" };
            object[] valores = { tipoid, nrodoc };
            return bd.DatarowFromProcedure("usp_EliminarCliente", parametros, valores, null);
        }
        public DataTable ListarTipoPedido()
        {
            return bd.DataTableFromProcedure("usp_get_TBL_Tipo_Compra", null, null, null);
        }

        public DataTable ItemCombo(int TipoCompra)
        {
            string[] parametros = { "@TipoCompra" };
            object[] valores = { TipoCompra };
            return bd.DataTableFromProcedure("usp_get_ItemCombo", parametros, valores, null);
        }

        public DataTable MarcaArticulo(int IdArticulo)
        {
            string[] parametros = { "@IdArticulo" };
            object[] valores = { IdArticulo };
            return bd.DataTableFromProcedure("usp_get_MarcaArticulo", parametros, valores, null);
        }

        public DataTable ModeloArticulo(int IdMarca, int articulo)
        {
            string[] parametros = { "@IdMarca", "@idart" };
            object[] valores = { IdMarca, articulo };
            return bd.DataTableFromProcedure("usp_get_MarcaModelo", parametros, valores, null);
        }

        public DataRow PerfilOrdenPedido(int IdUsuario)
        {
            string[] parametros = { "@Codigo_User" };
            object[] valores = { IdUsuario };
            return bd.DatarowFromProcedure("usp_get_Perfil_Orden_Pedido", parametros, valores, null);
        }

        public void OrdenPedidoCabeceraInsertar(out int Numero, int Usuario, int Tipo, string proyecto, string etapa)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_set_Orden_Pedido_Cabecera_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@proyecto", SqlDbType.VarChar, 10).Value = proyecto;
                    cmd.Parameters.Add("@etapa", SqlDbType.VarChar, 10).Value = etapa;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void OrdenPedidoDetalleInsertar(int Numero, int Cantidad, int Articulo, int Marca, int Modelo, string Observaciones, int ActivoFijo, int centrocosto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_ser_Orden_Pedido_Detalle_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                    cmd.Parameters.Add("@Articulo", SqlDbType.Int).Value = Articulo;
                    cmd.Parameters.Add("@Marca", SqlDbType.Int).Value = Marca;
                    cmd.Parameters.Add("@Modelo", SqlDbType.Int).Value = Modelo;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;
                    cmd.Parameters.Add("@activofijo", SqlDbType.Int).Value = ActivoFijo;
                    cmd.Parameters.Add("@cc", SqlDbType.Int).Value = centrocosto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        DataTable TAblitaSionNo;
        public void CargarSioNo()
        {
            TAblitaSionNo = new DataTable();
            TAblitaSionNo.Columns.Add("codigo", typeof(int));
            TAblitaSionNo.Columns.Add("Valor", typeof(string));
            TAblitaSionNo.Rows.Add(new object[] { 0, "NO" });
            TAblitaSionNo.Rows.Add(new object[] { 1, "SI" });
        }
        public DataTable ListarPedidos(int TipoArticulo, string Articulo, DateTime Desde, DateTime Hasta, int Usuario, int empresa)
        {
            string[] parametros = { "@TipoArticulo", "@Articulo", "@Desde", "@Hasta", "Usuario", "empresa" };
            object[] valores = { TipoArticulo, Articulo, Desde, Hasta, Usuario, empresa };
            return bd.DataTableFromProcedure("usp_get_buscar_Articulo_Pedido", parametros, valores, null);
        }

        public DataTable ListarOrdenPedido(int Numero, string Tipo)
        {
            string[] parametros = { "@Numero", "@Tipo" };
            object[] valores = { Numero, Tipo };
            return bd.DataTableFromProcedure("usp_get_Orden_Pedido", parametros, valores, null);
        }

        public void OrdenPedidoDetalleActualizar(int Tipo, int Numero, int Cantidad, int ArticuloOld, int ArticuloNew, int MarcaOld, int MarcaNew, int ModeloOld, int ModeloNew, string Observaciones)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Orden_Pedido_Modificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                    cmd.Parameters.Add("@CodigoArticuloOld", SqlDbType.Int).Value = ArticuloOld;
                    cmd.Parameters.Add("@CodigoArticuloNew", SqlDbType.Int).Value = ArticuloNew;
                    cmd.Parameters.Add("@CodigoMarcaOld", SqlDbType.Int).Value = MarcaOld;
                    cmd.Parameters.Add("@CodigoMarcaNew", SqlDbType.Int).Value = MarcaNew;
                    cmd.Parameters.Add("@CodigoModeloOld", SqlDbType.Int).Value = ModeloOld;
                    cmd.Parameters.Add("@CodigoModeloNew", SqlDbType.Int).Value = ModeloNew;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ELiminarCotizacionTotal(int cotizacion)
        {
            string[] parametros = { "@Cotizacion" };
            object[] valores = { cotizacion };
            return bd.DataTableFromProcedure("usp_EliminarCotizacionTotal", parametros, valores, null);
        }
        public void AnularOrdenPedido(int Numero)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_get_anular_pedido";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarPedidosCotizacion(int Area, int Usuario)
        {
            string[] parametros = { "@Area", "@Usuario" };
            object[] valores = { Area, Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_Ordenes_Pedidos_Cotizacion", parametros, valores, null);
        }

        //public DataTable ListarAreas()
        //{
        //    return bd.DataTableFromProcedure("usp_get_Areas", null, null, null);
        //}

        public DataRow CotizacionPedidoCabecera(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DatarowFromProcedure("usp_get_Listar_Ordenes_Pedidos_Cotizacion_Ver_Cabecera", parametros, valores, null);
        }

        public DataTable CotizacionPedidoDetalle(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DataTableFromProcedure("usp_get_Listar_Ordenes_Pedidos_Cotizacion_Ver_Detalle", parametros, valores, null);
        }

        public DataTable ListarGiros()
        {
            return bd.DataTableFromProcedure("usp_get_Giro", null, null, null);
        }

        public DataTable ListarProveedorGiro(int Giro)
        {
            string[] parametros = { "@Giro" };
            object[] valores = { Giro };
            return bd.DataTableFromProcedure("usp_get_proveedor_giro", parametros, valores, null);
        }

        public void CotizacionCabeceraInsertar(out int Numero, DateTime FechaEntrega, int Tipo, int Usuario, decimal Importe, int Pedido, string Proveedor, byte[] Foto, string NombreArchivo, int moneda)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_set_Cotizacion_Cabecera_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@FechaEntrega", SqlDbType.DateTime).Value = FechaEntrega;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Importe", SqlDbType.Decimal).Value = Importe;
                    cmd.Parameters.Add("@Pedido", SqlDbType.Int).Value = Pedido;
                    cmd.Parameters.Add("@Proveedor", SqlDbType.Char, 11).Value = Proveedor;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreArchivo", SqlDbType.VarChar, 256).Value = NombreArchivo;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void CotizacionDetalleInsertar(int Cotizacion, int Pedido, int tipo, int cantidad, decimal preciounit, decimal total, string articulo, string marca, string modelo, string obsevarciones)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_set_Cotizacion_Detalle_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@NumeroCotizacion", SqlDbType.Int).Value = Cotizacion;
                    cmd.Parameters.Add("@Pedido", SqlDbType.Int).Value = Pedido;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                    cmd.Parameters.Add("@preciounit", SqlDbType.Decimal).Value = preciounit;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
                    cmd.Parameters.Add("@articulo", SqlDbType.VarChar, 100).Value = articulo;
                    cmd.Parameters.Add("@marca", SqlDbType.VarChar, 100).Value = marca;
                    cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 100).Value = modelo;
                    cmd.Parameters.Add("@observacion", SqlDbType.VarChar, 100).Value = obsevarciones;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarCotizacionesAsociadas(int Pedido)
        {
            string[] parametros = { "@Pedido" };
            object[] valores = { Pedido };
            return bd.DataTableFromProcedure("usp_get_Cotizaciones_Asociadas", parametros, valores, null);
        }

        public DataTable ListarCotizacionesAsociadasParaAprobar(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_Ordenes_Pedidos_Aprobar_Cotizacion", parametros, valores, null);
        }
        public DataTable BuscarCuentasReflejo(string cuenta, decimal saldodebe, decimal saldohaber)
        {
            string[] parametros = { "@cuentaC", "@SaldoD", "@SaldoH" };
            object[] valores = { cuenta, saldodebe, saldohaber };
            return bd.DataTableFromProcedure("usp_BuscarCuentasReflejo", parametros, valores, null);
        }
        public DataRow Logueo(string Login_User, string Password_User)
        {
            string[] parametros = { "@Login_User", "@Password_User" };
            object[] valores = { Login_User, Password_User };
            return bd.DatarowFromProcedure("usp_Logueo", parametros, valores, null);
        }

        public void AprobacionNOCotizacion(int Cotizacion, string sStoredProcedure)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = sStoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Cotizacion", SqlDbType.Int).Value = Cotizacion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void OrdenCompraInsertar(out int Numero, int Cotizacion, int Pedido, int CentroCosto, int PPto, int Usuario, int Area, int Gerencia, string Proveedor, decimal Importe, int Tipo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Orden_Compra_insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Cotizacion", SqlDbType.Int).Value = Cotizacion;
                    cmd.Parameters.Add("@Pedido", SqlDbType.Int).Value = Pedido;
                    cmd.Parameters.Add("@CentroCosto", SqlDbType.Int).Value = CentroCosto;
                    cmd.Parameters.Add("@PPto", SqlDbType.Int).Value = PPto;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Area", SqlDbType.Int).Value = Area;
                    cmd.Parameters.Add("@Gerencia", SqlDbType.Int).Value = Gerencia;
                    cmd.Parameters.Add("@Proveedor", SqlDbType.Char, 11).Value = Proveedor;
                    cmd.Parameters.Add("@Importe", SqlDbType.Decimal).Value = Importe;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarOrdenesCompra(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_Ordenes_Pedidos_Aprobar_Cotizacion_OC", parametros, valores, null);
        }
        public DataRow ListarDetalleOC(int Cotizacion)
        {
            string[] parametros = { "@Cotizacion" };
            object[] valores = { Cotizacion };
            return bd.DatarowFromProcedure("usp_get_Cotizacion_OC", parametros, valores, null);
        }

        public DataTable ListarOCDetalle(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DataTableFromProcedure("usp_get_Listar_Ordenes_Pedidos_Cotizacion_Ver_Detalle_Cotizado", parametros, valores, null);
        }

        public void UpdateEstadoOC(int Numero, int Estado)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Update_Estado";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = Estado;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void FICCabeceraInsertar(out int Numero, int GuiaRemision, int OrdenCompra, int Tipo, int Usuario)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_FIC_Cabecera_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@GuiaRemision", SqlDbType.Int).Value = GuiaRemision;
                    cmd.Parameters.Add("@OrdenCompra", SqlDbType.Int).Value = OrdenCompra;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void FICDetalleInsertar(int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo, int Cantidad, string Observaciones, int Tipo, int centrocosto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_FIC_Detalle_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@NumeroFIC", SqlDbType.Int).Value = NumeroFIC;
                    cmd.Parameters.Add("@CodigoArticulo", SqlDbType.Int).Value = CodigoArticulo;
                    cmd.Parameters.Add("@CodigoMarca", SqlDbType.Int).Value = CodigoMarca;
                    cmd.Parameters.Add("@CodigoModelo", SqlDbType.Int).Value = CodigoModelo;
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@cc", SqlDbType.Int).Value = centrocosto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarOCProveedor(string Proveedor, int Tipo, int Usuario)
        {
            string[] parametros = { "@Proveedor", "@Tipo", "@Usuario" };
            object[] valores = { Proveedor, Tipo, Usuario };
            return bd.DataTableFromProcedure("usp_Proveedor_OC", parametros, valores, null);
        }
        public DataTable ListarOCProveedorAprobadas(string Proveedor, int Tipo, int Usuario)
        {
            string[] parametros = { "@Proveedor", "@Tipo", "@Usuario" };
            object[] valores = { Proveedor, Tipo, Usuario };
            return bd.DataTableFromProcedure("usp_listar_Proveedor_OC", parametros, valores, null);
        }

        public DataTable ListarSinOCProveedor(string Proveedor, int Tipo, int Usuario, int OC)
        {
            string[] parametros = { "@Proveedor", "@Tipo", "@Usuario", "@OC" };
            object[] valores = { Proveedor, Tipo, Usuario, OC };
            return bd.DataTableFromProcedure("usp_Proveedor_sin_OC", parametros, valores, null);
        }

        public DataTable ListarArticulosFIC(int OC, int TIPO)
        {
            string[] parametros = { "@OC", "@TIPO" };
            object[] valores = { OC, TIPO };
            return bd.DataTableFromProcedure("usp_get_Articulos_FIC", parametros, valores, null);
        }

        public DataTable ListarFIC(int OC, int Tipo)
        {
            string[] parametros = { "@OC", "@Tipo" };
            object[] valores = { OC, Tipo };
            return bd.DataTableFromProcedure("usp_get_FIC", parametros, valores, null);
        }
        public DataTable ListarOCFaltantes(string cadena, DateTime fechaini, DateTime fechafin, int articulo, int servicio, int opcion, int fecha)
        {
            string[] parametros = { "@cadena", "@fechaini", "@fechafin", "@articulo", "@servicio", "@opcion", "@fecha" };
            object[] valores = { cadena, fechaini, fechafin, articulo, servicio, opcion, fecha };
            return bd.DataTableFromProcedure("dbo.usp_listar_oc_Faltante", parametros, valores, null);
        }
        public DataTable ListarFIClistar(int OC, int Tipo)
        {
            string[] parametros = { "@OC", "@Tipo" };
            object[] valores = { OC, Tipo };
            return bd.DataTableFromProcedure("usp_get_FIC_listar", parametros, valores, null);
        }
        public DataTable ListarFics(int opcion, string proveedor, int guia, int tipo)
        {
            string[] parametros = { "@opcion", "@proveedor", "@guia", "@tipo" };
            object[] valores = { opcion, proveedor, guia, tipo };
            return bd.DataTableFromProcedure("usp_ListarFic", parametros, valores, null);
        }
        public DataRow MaximoValordeUnCampo(string tabla, string campo)
        {
            string[] parametros = { "@tabla", "@campo" };
            object[] valores = { tabla, campo };
            return bd.DatarowFromProcedure("ups_MaximoValordeUnCampo", parametros, valores, null);
        }
        public DataTable ListarFicsFila(int opcion, string proveedor, string guia, int tipo)
        {
            string[] parametros = { "@opcion", "@proveedor", "@guia", "@tipo" };
            object[] valores = { opcion, proveedor, guia, tipo };
            return bd.DataTableFromProcedure("usp_ListarFic", parametros, valores, null);
        }
        public DataRow BuscarMontodelasGuias(int opcion, string proveedor, string guia, int tipo)
        {
            string[] parametros = { "@opcion", "@proveedor", "@guia", "@tipo" };
            object[] valores = { opcion, proveedor, guia, tipo };
            return bd.DatarowFromProcedure("usp_ListarFic", parametros, valores, null);
        }
        public DataRow BuscarFacturas(string ruc, string nrofac)
        {
            string[] parametros = { "@ruc", "@nrofac" };
            object[] valores = { ruc, nrofac };
            return bd.DatarowFromProcedure("dbo.usp_Facturas", parametros, valores, null);
        }
        public DataRow BuscarFacturasVentas(string ruc, string nrofac)
        {
            string[] parametros = { "@ruc", "@nrofac" };
            object[] valores = { ruc, nrofac };
            return bd.DatarowFromProcedure("usp_FacturasVentas", parametros, valores, null);
        }
        public DataTable ListarFicsDetalle(string fic)
        {
            string[] parametros = { "@fic" };
            object[] valores = { fic };
            return bd.DataTableFromProcedure("usp_ListarFic_detalle", parametros, valores, null);
        }
        public DataTable ListarFicsDetalleservicio(string fic)
        {
            string[] parametros = { "@fic" };
            object[] valores = { fic };
            return bd.DataTableFromProcedure("usp_ListarFic_detalle_servicio", parametros, valores, null);
        }
        public DataTable ListarFIC2(int OC, int FIC, int Tipo)
        {
            string[] parametros = { "@OC", "@FIC", "@Tipo" };
            object[] valores = { OC, FIC, Tipo };
            return bd.DataTableFromProcedure("usp_get_Articulos_FIC2", parametros, valores, null);
        }
        public DataTable ListarGuias(string ruc, int tipo, int opcion, int guia)
        {
            string[] parametros = { "@ruc", "@tipo", "@opcion", "@guia" };
            object[] valores = { ruc, tipo, opcion, guia };
            return bd.DataTableFromProcedure("dbo.usp_listar_guias ", parametros, valores, null);
        }
        public DataTable ListarFIC2listar(int OC, int FIC, int Tipo)
        {
            string[] parametros = { "@OC", "@FIC", "@Tipo" };
            object[] valores = { OC, FIC, Tipo };
            return bd.DataTableFromProcedure("usp_get_Articulos_FIC2_listar", parametros, valores, null);
        }
        public DataRow RUCProveedor(string RUC)
        {
            string[] parametros = { "@RUC" };
            object[] valores = { RUC };
            return bd.DatarowFromProcedure("usp_Get_Proveedor", parametros, valores, null);
        }
        public DataRow BuscarRucEmpresa(string @empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valores = { empresa };
            return bd.DatarowFromProcedure("usp_BuscarRucEmpresa", parametros, valores, null);
        }
        public DataTable BusquedaProveedorClienteEmpleado(int tipoid, string numdoc)
        {
            string[] parametros = { "@tipoid", "@numdoc" };
            object[] valores = { tipoid, numdoc };
            return bd.DataTableFromProcedure("usp_busquedaProveedorClienteEmpleado", parametros, valores, null);
        }
        public DataTable ListarFacturasProveedor(string ruc, string estado, int tipo)
        {
            string[] parametros = { "@proveedor", "@estado", "@tipo" };
            object[] valores = { ruc, estado, tipo };
            return bd.DataTableFromProcedure("usp_ListarFacturasProveedor", parametros, valores, null);
        }
        public DataTable ListarNotaCredito(string CodNumNota, string Proveedor, int tipo)
        {
            string[] parametros = { "@codnumnota", "@proveedor", "@tipo" };
            object[] valores = { CodNumNota, Proveedor, tipo };
            return bd.DataTableFromProcedure("usp_ListarNotaCredito", parametros, valores, null);
        }
        public DataTable NotaCredito(int opcion, string codnc, string nronc, string nrofac, int tipo, string Proveedor, decimal subtotaln, decimal igv, decimal total, string glosa, int usuario)
        {
            string[] parametros = { "@opcion", "@codnc", "@nronc", "@nrofac", "@tiponota", "@proveedor", "@subtotal", "@igv", "@total", "@glosa", "@usuario" };
            object[] valores = { opcion, codnc, nronc, nrofac, tipo, Proveedor, subtotaln, igv, total, glosa, usuario };
            return bd.DataTableFromProcedure("usp_NotaCredito", parametros, valores, null);
        }
        public DataTable NotaCreditoDetalle(int opcion, string codnc, string nronc, string Proveedor, int tipo, int tipocompra, int cantidad, int articulo, int marca, int modelo, decimal precioreg, decimal preciomod, decimal total, int eliminado, int usuario)
        {
            string[] parametros = { "@opcion", "@codnc", "@nronc", "@proveedor", "@tiponota", "@tipocompra", "@cantidad", "@idarticulo", "@idmarca", "@idmodelo", "@precioreg", "@preciomod", "@total", "@eliminado", "@usuario" };
            object[] valores = { opcion, codnc, nronc, Proveedor, tipo, tipocompra, cantidad, articulo, marca, modelo, precioreg, preciomod, total, eliminado, usuario };
            return bd.DataTableFromProcedure("usp_NotaCreditoDetalle", parametros, valores, null);
        }
        public DataTable ListarFacturaProveedorNota(string codnumfac, string ruc, string estado)
        {
            string[] parametros = { "@codNumfac", "@proveedor", "@estado" };
            object[] valores = { codnumfac, ruc, estado };
            return bd.DataTableFromProcedure("usp_ListarFacturaProveedorNota", parametros, valores, null);
        }
        public DataTable ListarFacturasNotas(string codnumfac, string ruc, string estado)
        {
            string[] parametros = { "@codNumfac", "@proveedor", "@estado" };
            object[] valores = { codnumfac, ruc, estado };
            return bd.DataTableFromProcedure("usp_ListarFacturasNotas", parametros, valores, null);
        }
        public DataRow CargarImagenCotizacion(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DatarowFromProcedure("usp_Get_Imagen_Cotizacion", parametros, valores, null);
        }
        public void InsertarFactura(string nrofactura, string proveedor, int fic, int oc, int tipo, decimal subtotal, decimal igv, decimal total, int gravaivg, DateTime fechaemision, DateTime fechaentregado, DateTime fecharecepcion, int estado, int moneda, byte[] imgfactura, int usuario, int nroconstancia, decimal detracion, int cc)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_factura";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nrofactura", SqlDbType.VarChar, 40).Value = nrofactura;
                    cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 40).Value = proveedor;
                    cmd.Parameters.Add("@fic", SqlDbType.Int).Value = fic;
                    cmd.Parameters.Add("@oc", SqlDbType.Int).Value = oc;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = subtotal;
                    cmd.Parameters.Add("@igv", SqlDbType.Decimal).Value = igv;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
                    cmd.Parameters.Add("@gravaigv", SqlDbType.Int).Value = gravaivg;
                    cmd.Parameters.Add("@fechaemision", SqlDbType.DateTime).Value = fechaemision;
                    cmd.Parameters.Add("@fechaentrega", SqlDbType.DateTime).Value = fechaentregado;
                    cmd.Parameters.Add("@fecharecepcion", SqlDbType.DateTime).Value = fecharecepcion;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;
                    cmd.Parameters.Add("@imgfactura", SqlDbType.Image).Value = imgfactura;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;
                    cmd.Parameters.Add("@detraccion", SqlDbType.Int).Value = detracion;
                    cmd.Parameters.Add("@nroconstancia", SqlDbType.Decimal).Value = nroconstancia;
                    cmd.Parameters.Add("@cc", SqlDbType.Int).Value = cc;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void CotizacionModificar(int Numero, DateTime FechaEntrega, decimal Importe, string Proveedor, byte[] Foto, string NombreArchivo, int moneda)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Modificar_Cotizacion";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Proveedor", SqlDbType.Char, 11).Value = Proveedor;
                    cmd.Parameters.Add("@Importe", SqlDbType.Decimal).Value = Importe;
                    cmd.Parameters.Add("@FechaEntrega", SqlDbType.DateTime).Value = FechaEntrega;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreArchivo;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataRow ExisteFoto(string NombreFoto)
        {
            string[] parametros = { "@NombreFoto" };
            object[] valores = { NombreFoto };
            return bd.DatarowFromProcedure("usp_get_NombreFoto", parametros, valores, null);
        }
        public DataTable getCargoTipoContratacion(string Campo1, string Campo2, string Tabla)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Tabla" };
            object[] valores = { Campo1, Campo2, Tabla };
            return bd.DataTableFromProcedure("usp_get_CargoTipoContratacion", parametros, valores, null);
        }
        public DataTable ListarTablaConPrimerCampoOrdenado(string Campo1, string Campo2, string Tabla)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Tabla" };
            object[] valores = { Campo1, Campo2, Tabla };
            return bd.DataTableFromProcedure("usp_get_CargoTipoContratacion10", parametros, valores, null);
        }
        public DataTable GetTabla(string Tabla, string CampoOrdenar)
        {
            string[] parametros = { "@Tabla", "@CampoOrdenar" };
            object[] valores = { Tabla, CampoOrdenar };
            return bd.DataTableFromProcedure("usp_GetTabla", parametros, valores, null);
        }
        public DataTable ConsultaRCumples()
        {
            return bd.DataTableFromProcedure("uspConsultarCumpleanos", null, null, null);
        }
        public DataTable ListadodeEmpresas()
        {
            return bd.DataTableFromProcedure("usp_ListadodeEmpresas", null, null, null);
        }
        public DataTable ListarOS(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_NOS", parametros, valores, null);
        }

        public void SolicitudEmpleadoInsertar(int Numero, int Cargo, int TipoContratacion, string Busqueda, string AplicaTerna, int Area, int gerencia, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto, int Usuario)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_set_SolicitaEmpleado_insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Cargo", SqlDbType.Int).Value = Cargo;
                    cmd.Parameters.Add("@Tipo_Contratacion", SqlDbType.Int).Value = TipoContratacion;
                    cmd.Parameters.Add("@Busqueda", SqlDbType.Char, 10).Value = Busqueda;
                    cmd.Parameters.Add("@AplicaTerna", SqlDbType.Char, 2).Value = AplicaTerna;
                    cmd.Parameters.Add("@Area", SqlDbType.Int).Value = Area;
                    cmd.Parameters.Add("@gerencia", SqlDbType.Int).Value = gerencia;
                    cmd.Parameters.Add("@CantPuestos", SqlDbType.Int).Value = CantPuestos;
                    cmd.Parameters.Add("@NroOrdenCompra", SqlDbType.Int).Value = NroOrdenCompra;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarSE(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_listar_SolicitudesEmpleados", parametros, valores, null);
        }

        public DataRow CargarImagenSolicitudEmpleado(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DatarowFromProcedure("usp_Get_Imagen_SolicitudEmpleado", parametros, valores, null);
        }

        public DataTable ListarComboSE(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_NOS_Combo", parametros, valores, null);
        }

        public DataTable ListarSEPostulantes(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_listar_SolicitudesEmpleadosPostulante", parametros, valores, null);
        }

        public void PostulanteInsertar(int Tipo_ID_Postulante, string Nro_ID_Postulante, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, int ID_Puesto_Postulante, byte[] Foto, string NombreFoto, int OC, int SE, int Usuario, DateTime Fecha)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Postulante_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Postulante", SqlDbType.Int).Value = Tipo_ID_Postulante;
                    cmd.Parameters.Add("@Nro_ID_Postulante", SqlDbType.VarChar, 14).Value = Nro_ID_Postulante;
                    cmd.Parameters.Add("@Apepat_Postulante", SqlDbType.VarChar, 30).Value = Apepat_Postulante;
                    cmd.Parameters.Add("@Apemat_Postulante", SqlDbType.VarChar, 30).Value = Apemat_Postulante;
                    cmd.Parameters.Add("@Nombres_Postulante", SqlDbType.VarChar, 30).Value = Nombres_Postulante;
                    cmd.Parameters.Add("@ID_Puesto_Postulante", SqlDbType.Int).Value = ID_Puesto_Postulante;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;
                    cmd.Parameters.Add("@OC", SqlDbType.Int).Value = OC;
                    cmd.Parameters.Add("@SE", SqlDbType.Int).Value = SE;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime).Value = Fecha;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoRequerimiento(int Tipo_ID_Emp, string Nro_ID_Emp, string Correo, string Correo_Obs, string Celular, string Celular_Obs, string Pc, string Pc_Obs, string Otros, string Otros_Obs, int Usuario, int Opcion, string nombre, byte[] foto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoRequerimiento";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 2).Value = Correo;
                    cmd.Parameters.Add("@Correo_Obs", SqlDbType.VarChar, 70).Value = Correo_Obs;
                    cmd.Parameters.Add("@Celular", SqlDbType.VarChar, 2).Value = Celular;
                    cmd.Parameters.Add("@Celular_Obs", SqlDbType.VarChar, 70).Value = Celular_Obs;
                    cmd.Parameters.Add("@Pc", SqlDbType.VarChar, 2).Value = Pc;
                    cmd.Parameters.Add("@Pc_Obs", SqlDbType.VarChar, 70).Value = Pc_Obs;
                    cmd.Parameters.Add("@Otros", SqlDbType.VarChar, 2).Value = Otros;
                    cmd.Parameters.Add("@Otros_Obs", SqlDbType.VarChar, 70).Value = Otros_Obs;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 500).Value = nombre;
                    cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoSeguroPension(int Tipo_ID_Emp, string Nro_ID_Emp, string Eps, int Eps_Adicional, string Sctr, string Onp, string Afp, int Afp_Empresa, string Nro_Cupss, int Usuario, int Opcion, int descuento, decimal descvalor, int aplica, int plann)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoSeguroPension";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Eps", SqlDbType.VarChar, 2).Value = Eps;
                    cmd.Parameters.Add("@Eps_Adicional", SqlDbType.Int).Value = Eps_Adicional;
                    cmd.Parameters.Add("@Sctr", SqlDbType.VarChar, 2).Value = Sctr;
                    cmd.Parameters.Add("@Onp", SqlDbType.VarChar, 2).Value = Onp;
                    cmd.Parameters.Add("@Afp", SqlDbType.VarChar, 2).Value = Afp;
                    cmd.Parameters.Add("@Afp_Empresa", SqlDbType.Int).Value = Afp_Empresa;
                    cmd.Parameters.Add("@Nro_Cupss", SqlDbType.VarChar, 20).Value = Nro_Cupss;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                    cmd.Parameters.Add("@descuento", SqlDbType.Int).Value = descuento;
                    cmd.Parameters.Add("@descvalor", SqlDbType.Decimal).Value = descvalor;
                    cmd.Parameters.Add("@aplica", SqlDbType.Int).Value = aplica;
                    cmd.Parameters.Add("@plann", SqlDbType.Int).Value = plann;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoCTS(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoCTS";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Banco", SqlDbType.Int).Value = Banco;
                    cmd.Parameters.Add("@Moneda", SqlDbType.Int).Value = Moneda;
                    cmd.Parameters.Add("@Nro_Cta", SqlDbType.VarChar, 20).Value = Nro_Cta;
                    cmd.Parameters.Add("@Nro_Cci", SqlDbType.VarChar, 30).Value = Nro_Cci;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoPagoHaberes(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoPagoHaberes";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Banco", SqlDbType.Int).Value = Banco;
                    cmd.Parameters.Add("@Moneda", SqlDbType.Int).Value = Moneda;
                    cmd.Parameters.Add("@Nro_Cta", SqlDbType.VarChar, 20).Value = Nro_Cta;
                    cmd.Parameters.Add("@Nro_Cci", SqlDbType.VarChar, 30).Value = Nro_Cci;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarPostulanteSE(int Solicitud)
        {
            string[] parametros = { "@Solicitud" };
            object[] valores = { Solicitud };
            return bd.DataTableFromProcedure("usp_listar_Postulante", parametros, valores, null);
        }

        //public DataTable ListarProvincia(int Departamento)
        //{
        //    string[] parametros = { "@Cod_Dept" };
        //    object[] valores = { Departamento };
        //    return bd.DataTableFromProcedure("usp_Get_Provincia", parametros, valores, null);
        //}

        //public DataTable ListarDistrito(int Departamento, int Provincia)
        //{
        //    string[] parametros = { "@Cod_Dept", "@Cod_Prov" };
        //    object[] valores = { Departamento, Provincia };
        //    return bd.DataTableFromProcedure("usp_Get_Distrito", parametros, valores, null);
        //}

        public void EmpleadoInsertar(int pais, string lugar, int Tipo_ID_Emp, string Nro_ID_Emp, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, int Usuario, byte[] foto, string nombrefoto, byte[] firma, string nombrefirma)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pais", SqlDbType.Int).Value = pais;
                    cmd.Parameters.Add("@lugar", SqlDbType.VarChar, 40).Value = lugar;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Apepat_Emp", SqlDbType.VarChar, 30).Value = Apepat_Emp;
                    cmd.Parameters.Add("@Apemat_Emp", SqlDbType.VarChar, 30).Value = Apemat_Emp;
                    cmd.Parameters.Add("@Nombres_Emp", SqlDbType.VarChar, 30).Value = Nombres_Emp;
                    cmd.Parameters.Add("@Sexo", SqlDbType.Int).Value = Sexo;
                    cmd.Parameters.Add("@Fec_Nacimiento", SqlDbType.DateTime).Value = Fec_Nacimiento;
                    cmd.Parameters.Add("@Lugar_Nacimiento", SqlDbType.Int).Value = Lugar_Nacimiento;
                    cmd.Parameters.Add("@Estado_Civil", SqlDbType.Int).Value = Estado_Civil;
                    cmd.Parameters.Add("@Hijos", SqlDbType.Int).Value = Hijos;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 80).Value = Direccion;
                    cmd.Parameters.Add("@Distrito", SqlDbType.Int).Value = Distrito;
                    cmd.Parameters.Add("@Provincia", SqlDbType.Int).Value = Provincia;
                    cmd.Parameters.Add("@Departamento", SqlDbType.Int).Value = Departamento;
                    cmd.Parameters.Add("@Telf_Fijo", SqlDbType.VarChar, 10).Value = Telf_Fijo;
                    cmd.Parameters.Add("@Telf_Celular", SqlDbType.VarChar, 15).Value = Telf_Celular;
                    cmd.Parameters.Add("@Profesion", SqlDbType.Int).Value = Profesion;
                    cmd.Parameters.Add("@Grado_Instruccion", SqlDbType.Int).Value = Grado_Instruccion;
                    cmd.Parameters.Add("@AntecedentesPoliciales", SqlDbType.Image).Value = AntecedentesPoliciales;
                    cmd.Parameters.Add("@NombreFotoAntecedentesPoliciales", SqlDbType.VarChar, 256).Value = NombreFotoAntecedentesPoliciales;
                    cmd.Parameters.Add("@AntecedentesPenales", SqlDbType.Image).Value = AntecedentesPenales;
                    cmd.Parameters.Add("@NombreFotoAntecedentesPenales", SqlDbType.VarChar, 256).Value = NombreFotoAntecedentesPenales;
                    cmd.Parameters.Add("@ReciboServicios", SqlDbType.Image).Value = ReciboServicios;
                    cmd.Parameters.Add("@NombreFotoReciboServicios", SqlDbType.VarChar, 256).Value = NombreFotoReciboServicios;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto;
                    cmd.Parameters.Add("@nombrefoto", SqlDbType.VarChar, 256).Value = nombrefoto;
                    cmd.Parameters.Add("@firma", SqlDbType.Image).Value = firma;
                    cmd.Parameters.Add("@nombrefirma", SqlDbType.VarChar, 256).Value = nombrefirma;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataRow DatosPostulante(int Tipo, string Numero)
        {
            string[] parametros = { "@tipo", "@Nro" };
            object[] valores = { Tipo, Numero };
            return bd.DatarowFromProcedure("usp_get_datos_postulante", parametros, valores, null);
        }
        public DataTable ListarPerfiles(int perfiles, int opcion, int codigo, int usuario, DateTime fecha)
        {
            string[] parametros = { "@perfile", "@opcion", "@codigo", "@usuario", "@fecha" };
            object[] valores = { perfiles, opcion, codigo, usuario, fecha };
            return bd.DataTableFromProcedure("usp_ListarPerfiles", parametros, valores, null);
        }
        public DataTable ListarJefeInmediato(int tipo, string documento, int opcion)
        {
            string[] parametros = { "@tipo", "@documento", "@opcion" };
            object[] valores = { tipo, documento, opcion };
            return bd.DataTableFromProcedure("usp_get_JefeInmediato", parametros, valores, null);
        }

        public void EmpleadoContrato(int numero, int Tipo_ID_Emp, string Nro_ID_Emp, int tipocontra, int adendas, int mercadobra, int jefe, int Tipo_Contrato, int Cargo, int Gerencia, int Area, int tipojefe, string Jefe_Inmediato, int Empresa, int Proyecto, int Sede, DateTime Fec_Inicio, int Periodo_Laboral, DateTime Fec_Fin, Decimal Sueldo, string Bono, Decimal Bono_Importe, int Bono_Periodicidad, byte[] Contrato_Img, string Contrato, byte[] AnxFunc_Img, string AnxFunc, byte[] SolPrac_Img, string SolPrac, byte[] Otros_Img, string Otros, int Usuario, int Opcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoContrato";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@tipocontra", SqlDbType.Int).Value = tipocontra;
                    cmd.Parameters.Add("@adendas", SqlDbType.Int).Value = adendas;
                    cmd.Parameters.Add("@mercadoobra", SqlDbType.Int).Value = mercadobra;
                    cmd.Parameters.Add("@jefe", SqlDbType.Int).Value = jefe;
                    cmd.Parameters.Add("@Tipo_Contrato", SqlDbType.Int).Value = Tipo_Contrato;
                    cmd.Parameters.Add("@Cargo", SqlDbType.Int).Value = Cargo;
                    cmd.Parameters.Add("@Gerencia", SqlDbType.Int).Value = Gerencia;
                    cmd.Parameters.Add("@Area", SqlDbType.Int).Value = Area;
                    cmd.Parameters.Add("@tipojefe", SqlDbType.Int).Value = tipojefe;
                    cmd.Parameters.Add("@Jefe_Inmediato", SqlDbType.VarChar, 14).Value = Jefe_Inmediato;
                    cmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = Empresa;
                    cmd.Parameters.Add("@Proyecto", SqlDbType.Int).Value = Proyecto;
                    cmd.Parameters.Add("@Sede", SqlDbType.Int).Value = Sede;
                    cmd.Parameters.Add("@Fec_Inicio", SqlDbType.DateTime).Value = Fec_Inicio;
                    cmd.Parameters.Add("@Periodo_Laboral", SqlDbType.Int).Value = Periodo_Laboral;
                    cmd.Parameters.Add("@Fec_Fin", SqlDbType.DateTime).Value = Fec_Fin;
                    cmd.Parameters.Add("@Sueldo", SqlDbType.Decimal).Value = Sueldo;
                    cmd.Parameters.Add("@Bono", SqlDbType.VarChar, 2).Value = Bono;
                    cmd.Parameters.Add("@Bono_Importe", SqlDbType.Decimal).Value = Bono_Importe;
                    cmd.Parameters.Add("@Bono_Periodicidad", SqlDbType.Int).Value = Bono_Periodicidad;
                    cmd.Parameters.Add("@Contrato_Img", SqlDbType.Image).Value = Contrato_Img;
                    cmd.Parameters.Add("@Contrato", SqlDbType.VarChar, 256).Value = Contrato;
                    cmd.Parameters.Add("@AnxFunc_Img", SqlDbType.Image).Value = AnxFunc_Img;
                    cmd.Parameters.Add("@AnxFunc", SqlDbType.VarChar, 256).Value = AnxFunc;
                    cmd.Parameters.Add("@SolPrac_Img", SqlDbType.Image).Value = SolPrac_Img;
                    cmd.Parameters.Add("@SolPrac", SqlDbType.VarChar, 256).Value = SolPrac;
                    cmd.Parameters.Add("@Otros_Img", SqlDbType.Image).Value = Otros_Img;
                    cmd.Parameters.Add("@Otros", SqlDbType.VarChar, 256).Value = Otros;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoFamilia(int Tipo_ID_Emp, string Nro_ID_Emp, int Vinculo_Familiar, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old, int Tipo_ID_Fam_New, string Nro_ID_Fam_New, string Apepat_Fam, string Apemat_Fam, string Nombres_Fam, DateTime Fec_Nacimiento_Fam, string Ocupacion, int Usuario, int Opcion, byte[] foto, string nombrefoto, int sexo, int estudia)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoFamilia";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Vinculo_Familiar", SqlDbType.Int).Value = Vinculo_Familiar;
                    cmd.Parameters.Add("@Tipo_ID_Fam_Old", SqlDbType.Int).Value = Tipo_ID_Fam_Old;
                    cmd.Parameters.Add("@Nro_ID_Fam_Old", SqlDbType.VarChar, 14).Value = Nro_ID_Fam_Old;
                    cmd.Parameters.Add("@Tipo_ID_Fam_New", SqlDbType.Int).Value = Tipo_ID_Fam_New;
                    cmd.Parameters.Add("@Nro_ID_Fam_New", SqlDbType.VarChar, 14).Value = Nro_ID_Fam_New;
                    cmd.Parameters.Add("@Apepat_Fam", SqlDbType.VarChar, 30).Value = Apepat_Fam;
                    cmd.Parameters.Add("@Apemat_Fam", SqlDbType.VarChar, 30).Value = Apemat_Fam;
                    cmd.Parameters.Add("@Nombres_Fam", SqlDbType.VarChar, 30).Value = Nombres_Fam;
                    cmd.Parameters.Add("@Fec_Nacimiento_Fam", SqlDbType.DateTime).Value = Fec_Nacimiento_Fam;
                    cmd.Parameters.Add("@Ocupacion", SqlDbType.VarChar, 30).Value = Ocupacion;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                    cmd.Parameters.Add("@nombrefoto", SqlDbType.VarChar, 100).Value = nombrefoto;
                    cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto;
                    cmd.Parameters.Add("@sexo", SqlDbType.Int).Value = sexo;
                    cmd.Parameters.Add("@estudia", SqlDbType.Int).Value = estudia;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarEmpleadoFamilia(int CodugoDocumento, string NumeroDocumento)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { CodugoDocumento, NumeroDocumento };
            return bd.DataTableFromProcedure("usp_mostrar_empleadosfamilia", parametros, valores, null);
        }

        public DataRow ExisteImagen(string Campo1, string Campo2, string Tabla)
        {
            string[] parametros = { "@Campo1", "@Campo2", "@Tabla" };
            object[] valores = { Campo1, Campo2, Tabla };
            return bd.DatarowFromProcedure("usp_get_ExisteImagen", parametros, valores, null);
        }

        public void AprobarPostulante(int Tipo_ID_Postulante, string Nro_ID_Postulante, int Id_SolicitaEmpleado)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_AprobarPostulante";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Tipo_ID_Postulante", SqlDbType.Int).Value = Tipo_ID_Postulante;
                    cmd.Parameters.Add("@Nro_ID_Postulante", SqlDbType.VarChar, 14).Value = Nro_ID_Postulante;
                    cmd.Parameters.Add("@Id_SolicitaEmpleado", SqlDbType.Int).Value = Id_SolicitaEmpleado;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataRow ExistePostulante(int Tipo_ID_Postulante, string Nro_ID_Postulante)
        {
            string[] parametros = { "@Tipo_ID_Postulante", "@Nro_ID_Postulante" };
            object[] valores = { Tipo_ID_Postulante, Nro_ID_Postulante };
            return bd.DatarowFromProcedure("usp_ExistePostulante", parametros, valores, null);
        }

        public DataRow DatosEmpleado(int Tipo_ID_Empleado, string Nro_ID_Empleado)
        {
            string[] parametros = { "@Tipo_ID_Empleado", "@Nro_ID_Empleado" };
            object[] valores = { Tipo_ID_Empleado, Nro_ID_Empleado };
            return bd.DatarowFromProcedure("usp_ExisteEmpleado", parametros, valores, null);
        }

        public DataRow ExisteBeneficioEmpleado(int Tipo_ID_Emp, string Nro_ID_Emp, string sStoredProcedureName)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure(sStoredProcedureName, parametros, valores, null);
        }

        public DataRow FechaActual()
        {
            return bd.DatarowFromProcedure("usp_FechaActual", null, null, null);
        }

        public void SolicitudEmpleadoModificar(int ID_SolicitaEmpleado, int Cargo, int Tipo_Contratacion, string Busqueda, string AplicaTerna, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_SolicitaEmpleadoModificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID_SolicitaEmpleado", SqlDbType.Int).Value = ID_SolicitaEmpleado;
                    cmd.Parameters.Add("@Cargo", SqlDbType.Int).Value = Cargo;
                    cmd.Parameters.Add("@Tipo_Contratacion", SqlDbType.Int).Value = Tipo_Contratacion;
                    cmd.Parameters.Add("@Busqueda", SqlDbType.Char, 7).Value = Busqueda;
                    cmd.Parameters.Add("@AplicaTerna", SqlDbType.Char, 2).Value = AplicaTerna;
                    cmd.Parameters.Add("@CantPuestos", SqlDbType.Int).Value = CantPuestos;
                    cmd.Parameters.Add("@NroOrdenCompra", SqlDbType.Int).Value = NroOrdenCompra;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable ProductosProyecto(int codigo, int opcion, string cadena, int usuarioo)
        {
            string[] parametros = { "@cod", "@opcion", "@descripcion", "@usuario" };
            object[] valores = { codigo, opcion, cadena, usuarioo };
            return bd.DataTableFromProcedure("usp_ProductosProyecto", parametros, valores, null);
        }
        public DataTable RegistroVentas(int opcion, string tipo, int nrocompra, string tipoid, string nro, string cliente, string producto, string proyecto, int etapa, int cantida, decimal precio, int vendedor, int usuario)
        {
            object[] valores = { opcion, tipo, nrocompra, tipoid, nro, cliente, producto, proyecto, etapa, cantida, precio, vendedor, usuario };
            string[] parametros = { "@opcion", "@tipo", "@nrocompro", "@tipoid", "@nro", "@cliente", "@producto", "@proyecto", "@etapa", "@cantidad", "@precio", "@vendedor", "@usuario" };
            return bd.DataTableFromProcedure("usp_RegistroVentas", parametros, valores, null);
        }
        public DataTable Proyecto_Productos(int codigo, int opcion, int proy, int prod, int moneda, int unidad, decimal cantidad, decimal preciopre, decimal precio, string etapa, int estado, string observacion, int usuarioo, int tipoinicial, decimal vinicial)
        {
            string[] parametros = { "@cod", "@opcion", "@proy", "@prod", "@moneda", "@unidad", "@cantidad", "@preciopre", "@precio", "@etapa", "@estado", "@observacion", "@usuario", "@Tipoinicial", "@Valorinicial" };
            object[] valores = { codigo, opcion, proy, prod, moneda, unidad, cantidad, preciopre, precio, etapa, estado, observacion, usuarioo, tipoinicial, vinicial };
            return bd.DataTableFromProcedure("usp_Proyecto_Productos", parametros, valores, null);
        }
        public DataRow ValorIGVactual(DateTime Fecha)
        {
            string[] parametros = { "@fechas" };
            object[] valores = { Fecha };
            return bd.DatarowFromProcedure("Usp_SacarIgv", parametros, valores, null);
        }
        public DataRow VerificaEstadoSolicitudEmpleado(int Solicitud)
        {
            string[] parametros = { "@ID_SolicitaEmpleado" };
            object[] valores = { Solicitud };
            return bd.DatarowFromProcedure("usp_VerificaEstadoSolicitudEmpleado", parametros, valores, null);
        }

        public DataRow CargarCualquierImagenPostulanteEmpleado(string CampoBuscado, string Tabla, string PrimerCampoComparativo, int PrimerValor, string SegundoCampoComparativo, string SegundoValorComparativo)
        {
            string[] parametros = { "@CampoBuscado", "@Tabla", "@PrimerCampoComparativo", "@PrimerValor", "@SegundoCampoComparativo", "@SegundoValorComparativo" };
            object[] valores = { CampoBuscado, Tabla, PrimerCampoComparativo, PrimerValor, SegundoCampoComparativo, SegundoValorComparativo };
            return bd.DatarowFromProcedure("usp_Get_CualquierCampo_PostulanteEmpleado", parametros, valores, null);
        }

        public void PostulanteModificar(int Tipo_ID_Postulante_Old, string Nro_ID_Postulante_Old, int Tipo_ID_Postulante_New, string Nro_ID_Postulante_New, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, byte[] Foto, string NombreFoto, int Id_SolicitaEmpleado, DateTime fechanacimiento)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Postulante_Modificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Postulante_Old", SqlDbType.Int).Value = Tipo_ID_Postulante_Old;
                    cmd.Parameters.Add("@Nro_ID_Postulante_Old", SqlDbType.VarChar, 14).Value = Nro_ID_Postulante_Old;
                    cmd.Parameters.Add("@Tipo_ID_Postulante_New", SqlDbType.Int).Value = Tipo_ID_Postulante_New;
                    cmd.Parameters.Add("@Nro_ID_Postulante_New", SqlDbType.VarChar, 14).Value = Nro_ID_Postulante_New;
                    cmd.Parameters.Add("@Apepat_Postulante", SqlDbType.VarChar, 30).Value = Apepat_Postulante;
                    cmd.Parameters.Add("@Apemat_Postulante", SqlDbType.VarChar, 30).Value = Apemat_Postulante;
                    cmd.Parameters.Add("@Nombres_Postulante", SqlDbType.VarChar, 30).Value = Nombres_Postulante;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;
                    cmd.Parameters.Add("@Id_SolicitaEmpleado", SqlDbType.Int).Value = Id_SolicitaEmpleado;
                    cmd.Parameters.Add("@fechanacimiento", SqlDbType.DateTime).Value = fechanacimiento;


                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarEmpleado(int Opcion, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int tipo, string doc, int pos)
        {
            string[] parametros = { "@Opcion", "@Apepat_Emp", "@Apemat_Emp", "@Nombres_Emp", "@tipo", "@doc", "@pos" };
            object[] valores = { Opcion, Apepat_Emp, Apemat_Emp, Nombres_Emp, tipo, doc, pos };
            return bd.DataTableFromProcedure("usp_ListarEmpleado", parametros, valores, null);
        }

        public void EmpleadoModificar(int pais, string lugar, int Tipo_ID_Emp_New, string Nro_ID_Emp_New, int Tipo_ID_Emp_Old, string Nro_ID_Emp_Old, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, byte[] foto, string nombrefoto, byte[] firma, string nombrefirma)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoModificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pais", SqlDbType.Int).Value = pais;
                    cmd.Parameters.Add("@lugar", SqlDbType.VarChar, 14).Value = lugar;
                    cmd.Parameters.Add("@Tipo_ID_Emp_New", SqlDbType.Int).Value = Tipo_ID_Emp_New;
                    cmd.Parameters.Add("@Nro_ID_Emp_New", SqlDbType.VarChar, 14).Value = Nro_ID_Emp_New;
                    cmd.Parameters.Add("@Tipo_ID_Emp_Old", SqlDbType.Int).Value = Tipo_ID_Emp_Old;
                    cmd.Parameters.Add("@Nro_ID_Emp_Old", SqlDbType.VarChar, 14).Value = Nro_ID_Emp_Old;
                    cmd.Parameters.Add("@Apepat_Emp", SqlDbType.VarChar, 30).Value = Apepat_Emp;
                    cmd.Parameters.Add("@Apemat_Emp", SqlDbType.VarChar, 30).Value = Apemat_Emp;
                    cmd.Parameters.Add("@Nombres_Emp", SqlDbType.VarChar, 30).Value = Nombres_Emp;
                    cmd.Parameters.Add("@Sexo", SqlDbType.Int).Value = Sexo;
                    cmd.Parameters.Add("@Fec_Nacimiento", SqlDbType.DateTime).Value = Fec_Nacimiento;
                    cmd.Parameters.Add("@Lugar_Nacimiento", SqlDbType.Int).Value = Lugar_Nacimiento;
                    cmd.Parameters.Add("@Estado_Civil", SqlDbType.Int).Value = Estado_Civil;
                    cmd.Parameters.Add("@Hijos", SqlDbType.Int).Value = Hijos;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 80).Value = Direccion;
                    cmd.Parameters.Add("@Distrito", SqlDbType.Int).Value = Distrito;
                    cmd.Parameters.Add("@Provincia", SqlDbType.Int).Value = Provincia;
                    cmd.Parameters.Add("@Departamento", SqlDbType.Int).Value = Departamento;
                    cmd.Parameters.Add("@Telf_Fijo", SqlDbType.VarChar, 10).Value = Telf_Fijo;
                    cmd.Parameters.Add("@Telf_Celular", SqlDbType.VarChar, 15).Value = Telf_Celular;
                    cmd.Parameters.Add("@Profesion", SqlDbType.Int).Value = Profesion;
                    cmd.Parameters.Add("@Grado_Instruccion", SqlDbType.Int).Value = Grado_Instruccion;
                    cmd.Parameters.Add("@AntecedentesPoliciales", SqlDbType.Image).Value = AntecedentesPoliciales;
                    cmd.Parameters.Add("@NombreFotoAntecedentesPoliciales", SqlDbType.VarChar, 256).Value = NombreFotoAntecedentesPoliciales;
                    cmd.Parameters.Add("@AntecedentesPenales", SqlDbType.Image).Value = AntecedentesPenales;
                    cmd.Parameters.Add("@NombreFotoAntecedentesPenales", SqlDbType.VarChar, 256).Value = NombreFotoAntecedentesPenales;
                    cmd.Parameters.Add("@ReciboServicios", SqlDbType.Image).Value = ReciboServicios;
                    cmd.Parameters.Add("@NombreFotoReciboServicios", SqlDbType.VarChar, 256).Value = NombreFotoReciboServicios;
                    cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto;
                    cmd.Parameters.Add("@nombrefoto", SqlDbType.VarChar, 256).Value = nombrefoto;
                    cmd.Parameters.Add("@firma", SqlDbType.Image).Value = firma;
                    cmd.Parameters.Add("@nombrefirma", SqlDbType.VarChar, 256).Value = nombrefirma;


                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void ActualizarLogin(string sStoredProcedureName, string Login_User, int Opcion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = sStoredProcedureName;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Login_User", SqlDbType.VarChar, 10).Value = Login_User;
                        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    cn.Dispose();
                }
                catch (Exception) { }
            }
        }

        public DataRow Loguearse(string Login_User, int Opcion)
        {
            ////Conexcion del usuario a la base de datos!;
            try
            {
                string[] parametros = { "@Login_User", "@Opcion" };
                object[] valores = { Login_User, Opcion };
                DataRow datoslogueo = bd.DatarowFromProcedure("usp_GetIntentosLogin", parametros, valores, null);
                if (datoslogueo == null)
                {
                    MessageBox.Show("Usuario NO existe", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return datoslogueo;
            }
            catch (SqlException)
            {
                MessageBox.Show("No Hay Conexión a la Base de datos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable UsuarioConectado(int codigo, string user, int opcion)
        {
            try
            {
                string[] parametros = { "@codigo", "@user", "@opcion" };
                object[] valores = { codigo, user, opcion };
                return bd.DataTableFromProcedure("usp_UsuariosConectados", parametros, valores, null);
            }
            catch (Exception)
            {
                MessageBox.Show("No Hay Conexión a la Base de datos", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ListarAreasUsuario(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_Get_Area_User", parametros, valores, null);
        }

        public DataRow CotTieneOC(int Cotizacion)
        {
            string[] parametros = { "@Cotizacion" };
            object[] valores = { Cotizacion };
            return bd.DatarowFromProcedure("usp_Cot_Tiene_OC", parametros, valores, null);
        }

        public void AnularCotizacion(int Cotizacion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EliminarCotizacion";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Cotizacion", SqlDbType.Int).Value = Cotizacion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable LimpiarCombosGrillas()
        {
            return bd.DataTableFromProcedure("usp_LimpiarCombosGrillas", null, null, null);
        }

        public DataRow NextValorizacion(int numero)
        {
            string[] parametros = { "@numero" };
            object[] valores = { numero };
            return bd.DatarowFromProcedure("usp_NextValorizacion", parametros, valores, null);
        }

        public void EliminarSolicitudEmpleado(int Solicitud)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EliminarSolicitud";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID_SolicitaEmpleado", SqlDbType.Int).Value = Solicitud;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataRow Correlativo(string Tabla)
        {
            string[] parametros = { "@tabla" };
            object[] valores = { Tabla };
            return bd.DatarowFromProcedure("usp_Correlativo", parametros, valores, null);
        }
        public DataRow CorrelativoCampo(string Tabla, string campo)
        {
            string[] parametros = { "@tabla", "@campo" };
            object[] valores = { Tabla, campo };
            return bd.DatarowFromProcedure("usp_CorrelativoCampo", parametros, valores, null);
        }
        public DataTable CualquierTabla(string Tabla)
        {
            string[] parametros = { "@tabla" };
            object[] valores = { Tabla };
            return bd.DataTableFromProcedure("usp_CualquierTabla", parametros, valores, null);

        }
        public DataTable CualquierTabla(string Tabla, string campo, string fila)
        {
            string[] parametros = { "@tabla", "@campo", "@fila" };
            object[] valores = { Tabla, campo, fila };
            return bd.DataTableFromProcedure("usp_CualquierTablaMenos", parametros, valores, null);
        }
        public DataTable CualquierTablaFiltrada(string Tabla, string campo, int VEntero)
        {
            string[] parametros = { "@tabla", "@campo", "@vEntero", "@Vstring" };
            object[] valores = { Tabla, campo, VEntero, null };
            return bd.DataTableFromProcedure("usp_CualquierTablaFiltrada", parametros, valores, null);
        }
        public DataTable CualquierTablaFiltrada(string Tabla, string campo, string VString)
        {
            string[] parametros = { "@tabla", "@campo", "@vEntero", "@Vstring" };
            object[] valores = { Tabla, campo, null, VString };
            return bd.DataTableFromProcedure("usp_CualquierTablaFiltrada", parametros, valores, null);
        }
        public DataTable ListarSECombo(int Usuario, int Solicitud)
        {
            string[] parametros = { "@Usuario", "@Solicitud" };
            object[] valores = { Usuario, Solicitud };
            return bd.DataTableFromProcedure("usp_SolicitudesEmpleado", parametros, valores, null);
        }

        public DataRow DiasVacaciones(DateTime FechaInicio, DateTime FechaFin)
        {
            string[] parametros = { "@FechaInicio", "@FechaFin" };
            object[] valores = { FechaInicio, FechaFin };
            return bd.DatarowFromProcedure("usp_Dias_Vacaciones", parametros, valores, null);
        }
        public DataRow UltimoRegistoVacaciones(int tipo, string doc)
        {
            string[] parametros = { "@tipo", "@doc" };
            object[] valores = { tipo, doc };
            return bd.DatarowFromProcedure("usp_UltimoRegistoVacaciones", parametros, valores, null);
        }
        public void EmpleadoVacacionesInsertar(out int Numero, int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias_Vacaciones, string Observaciones)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoVacaciones_Registrar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Fec_Inicio", SqlDbType.DateTime).Value = Fec_Inicio;
                    cmd.Parameters.Add("@Fec_Fin", SqlDbType.DateTime).Value = Fec_Fin;
                    cmd.Parameters.Add("@Dias_Vacaciones", SqlDbType.Int).Value = Dias_Vacaciones;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable AreaGerencia(int Gerencia)
        {
            string[] parametros = { "@Gerencia" };
            object[] valores = { Gerencia };
            return bd.DataTableFromProcedure("usp_GetAreaGerencia", parametros, valores, null);
        }

        public DataTable ListarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DataTableFromProcedure("usp_BoletasVacaciones", parametros, valores, null);
        }

        public DataTable ListarFaltas(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DataTableFromProcedure("usp_Faltas", parametros, valores, null);
        }

        public void AprobarVacaciones(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, byte[] Foto, string NombreFoto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Aprobar_Vacaciones_Empleado";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Registro", SqlDbType.Int).Value = Registro;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataRow ImagenBoleta(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Registro", "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Registro, Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_Get_Imagen_Boleta", parametros, valores, null);
        }

        public DataRow ImagenFalta(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Registro", "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Registro, Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_Get_Imagen_Falta", parametros, valores, null);
        }

        public DataRow DiasTomadosVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_DiasTomadosVacaciones", parametros, valores, null);
        }

        public DataRow MaximaFechaATomar(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_MaximaFechaTomada", parametros, valores, null);
        }
        public DataTable ConfigurarAsientoBoletas(int opcion, int pkid, string cuenta, string debe, Boolean incluir, string glosa, int tipo, string columna)
        {
            string[] parametros = { "@opcion", "@pkid", "@cuenta", "@debe", "@incluir", "@glosa", "@tipo", "@columna" };
            object[] valores = { opcion, pkid, cuenta, debe, incluir, glosa, tipo, columna };
            return bd.DataTableFromProcedure("usp_ConfigurarAsientoBoletas", parametros, valores, null);
        }
        public DataRow MaximaFechaATomarFalta(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fecha, string TipoFalta)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp", "@Fecha", "@tipofalta" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, Fecha, TipoFalta };
            return bd.DatarowFromProcedure("usp_MaximaFechaTomadaFalta", parametros, valores, null);
        }
        public DataRow TipoFalta_Busqueda(string falta, DateTime fecha)
        {
            string[] parametros = { "@falta", "@fecha" };
            object[] valores = { falta, fecha };
            return bd.DatarowFromProcedure("usp_TipoFalta_Busqueda", parametros, valores, null);
        }
        public DataRow DiasGenerado(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime FechaInicio)
        {
            string[] parametros = { "@tipodoc", "@nrodoc", "@fecha" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, FechaInicio };
            return bd.DatarowFromProcedure("usp_DiasGenerado", parametros, valores, null);
        }
        public DataTable DiasGeneradoResumen(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime FechaInicio, string Empresa)
        {
            string[] parametros = { "@tipodoc", "@nrodoc", "@fecha", "@empresa" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, FechaInicio, Empresa };
            return bd.DataTableFromProcedure("usp_DiasGenerado", parametros, valores, null);
        }
        public DataTable GratificacionesReporte(string empresa, string empleado, DateTime FechaIni, DateTime FechaFin)
        {
            string[] parametros = { "@empresa", "@empleado", "@FechaIni", "@FechaFin" };
            object[] valores = { empresa, empleado, FechaIni, FechaFin };
            return bd.DataTableFromProcedure("CalculoGratificacionesReporte", parametros, valores, null);
        }
        public DataTable CTSReporte(string empresa, string empleado, DateTime FechaIni, DateTime FechaFin)
        {
            string[] parametros = { "@empresa", "@empleado", "@FechaIni", "@FechaFin" };
            object[] valores = { empresa, empleado, FechaIni, FechaFin };
            return bd.DataTableFromProcedure("CalculoCTSReporte", parametros, valores, null);
        }
        public DataTable AfpReporte(int opcion, string empresa, string empleado, string entidad, DateTime FechaIni, DateTime FechaFin)
        {
            string[] parametros = { "@opcion", "@empresa", "@empleado", "@entidad", "@FechaIni", "@FechaFin" };
            object[] valores = { opcion, empresa, empleado, entidad, FechaIni, FechaFin };
            return bd.DataTableFromProcedure("usp_AfpReporte", parametros, valores, null);
        }
        public DataRow Sueldo(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_GetEmpleadoSueldo", parametros, valores, null);
        }

        public void ComprarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Desde, DateTime Hasta, int Dias_Pendiente, decimal Monto_Propuesto, decimal Monto_Pactado, int usuario, int pago, string observacion)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_CompraVacaciones_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Desde", SqlDbType.DateTime).Value = Desde;
                    cmd.Parameters.Add("@Hasta", SqlDbType.DateTime).Value = Hasta;
                    cmd.Parameters.Add("@Dias_Pendientes", SqlDbType.Int).Value = Dias_Pendiente;
                    cmd.Parameters.Add("@Monto_Propuesto", SqlDbType.Decimal).Value = Monto_Propuesto;
                    cmd.Parameters.Add("@Monto_Pactado", SqlDbType.Decimal).Value = Monto_Pactado;
                    cmd.Parameters.Add("@usuario", SqlDbType.Decimal).Value = usuario;
                    cmd.Parameters.Add("@pago", SqlDbType.Int).Value = pago;
                    cmd.Parameters.Add("@observacion", SqlDbType.VarChar, 500).Value = observacion;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoFaltas(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias, int TipoFalta, string Observaciones, byte[] Foto, string NombreFoto, int estado)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoFaltas_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Fec_Inicio", SqlDbType.DateTime).Value = Fec_Inicio;
                    cmd.Parameters.Add("@Fec_Fin", SqlDbType.DateTime).Value = Fec_Fin;
                    cmd.Parameters.Add("@Dias", SqlDbType.Int).Value = Dias;
                    cmd.Parameters.Add("@tipofalta", SqlDbType.Int).Value = TipoFalta;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoMemoPremio(out int Numero, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo, string Observaciones)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_MemoPremio_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 8000).Value = Observaciones;

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());

                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarMemoPremio(int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp", "@Tipo" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, Tipo };
            return bd.DataTableFromProcedure("usp_Get_MemoPremio", parametros, valores, null);
        }

        public void EmpleadoMemoPremioSustento(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo, byte[] Foto, string NombreFoto)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_MemoPremio_Sustento";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Registro", SqlDbType.Int).Value = Registro;
                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = Tipo;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataRow ImagenEmpleadoMemoPremio(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo)
        {
            string[] parametros = { "@Registro", "@Tipo_ID_Emp", "@Nro_ID_Emp", "@Tipo" };
            object[] valores = { Registro, Tipo_ID_Emp, Nro_ID_Emp, Tipo };
            return bd.DatarowFromProcedure("usp_Get_Imagen_MemoPremio", parametros, valores, null);
        }

        public DataTable OrdenCompraProveedor(string Proveedor, int GuiaRemision, int OrdenCompra, int tipo)
        {
            string[] parametros = { "@Proveedor", "@GuiaRemision", "@OrdenCompra", "@tipo" };
            object[] valores = { Proveedor, GuiaRemision, OrdenCompra, tipo };
            return bd.DataTableFromProcedure("usp_Get_OrdenCompra_Proveedor", parametros, valores, null);
        }

        public DataTable ListarFicModificar(int NumeroFIC)
        {
            string[] parametros = { "@NumeroFIC" };
            object[] valores = { NumeroFIC };
            return bd.DataTableFromProcedure("usp_Get_FIC_Modificar", parametros, valores, null);
        }

        public void FICModificarCabecera(int Numero, DateTime Fecha, int GuiaRemision)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_FIC_Cabecera_Modificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Numero;
                    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Fecha;
                    cmd.Parameters.Add("@GuiaRemision", SqlDbType.Int).Value = GuiaRemision;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void FICEliminarItemDetalle(int Id_FIC_Detalle, int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Eliminar_FIC_Detalle_Item";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id_FIC_Detalle", SqlDbType.Int).Value = Id_FIC_Detalle;
                    cmd.Parameters.Add("@NumeroFIC", SqlDbType.Int).Value = NumeroFIC;
                    cmd.Parameters.Add("@CodigoArticulo", SqlDbType.Int).Value = CodigoArticulo;
                    cmd.Parameters.Add("@CodigoMarca", SqlDbType.Int).Value = CodigoMarca;
                    cmd.Parameters.Add("@CodigoModelo", SqlDbType.Int).Value = CodigoModelo;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoDesvinculacionInsertar(int Tipo_ID_Emp, string Nro_ID_Emp, byte[] Foto, string Ruta, int Opcion, DateTime fechacese, int usuario, out int respuesta)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_Desvinculacion_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Tipo_ID_Emp", SqlDbType.Int).Value = Tipo_ID_Emp;
                    cmd.Parameters.Add("@Nro_ID_Emp", SqlDbType.VarChar, 14).Value = Nro_ID_Emp;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@Ruta", SqlDbType.VarChar, 256).Value = Ruta;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                    cmd.Parameters.Add("@fechacese", SqlDbType.DateTime).Value = fechacese;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    respuesta = int.Parse(cmd.Parameters["@respuesta"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataRow ListarContrato(int tipo, string documento, DateTime fecha)
        {
            string[] parametros = { "@tipo", "@documento", "@fecha" };
            object[] valores = { tipo, documento, fecha };
            return bd.DatarowFromProcedure("usp_Listar_Contrato", parametros, valores, null);
        }
        public DataRow ListarDesvinculaciones(int tipo, string documento, int contrato)
        {
            string[] parametros = { "@tipo", "@documento", "@contrato" };
            object[] valores = { tipo, documento, contrato };
            return bd.DatarowFromProcedure("usp_Listar_Desvinculaciones", parametros, valores, null);
        }
        public DataTable ListarDesvinculacionContrato(int tipo, string documento)
        {
            string[] parametros = { "@tipo", "@documento" };
            object[] valores = { tipo, documento };
            return bd.DataTableFromProcedure("dbo.usp_listar_desvinculacion_contrato", parametros, valores, null);
        }
        public DataRow ContratoActivo(int tipo, string documento, DateTime fecha)
        {
            string[] parametros = { "@tipo", "@documento", "@fecha" };
            object[] valores = { tipo, documento, fecha };
            return bd.DatarowFromProcedure("usp_contrato_activo", parametros, valores, null);
        }
        public DataRow ContratoActivo_oTiene(int tipo, string documento, DateTime fecha)
        {
            string[] parametros = { "@tipo", "@documento", "@fecha" };
            object[] valores = { tipo, documento, fecha };
            return bd.DatarowFromProcedure("usp_contrato_activo_oTiene", parametros, valores, null);
        }
        public DataTable ReportedeOp(int opcion, int articulo, int servicio, int fecha, DateTime fechaini, DateTime fechafin, int anulado, int registrado, int cotizado, int cotizadocompleto, int cotizacooc, string busca)
        {
            string[] parametros = { "@opcion", "@articulo", "@servicio", "@fecha", "@fechaini", "@fechafin", "@anulado", "@registrado", "@cotizado", "@cotizacocompleto", "@cotizacooc", "@busca" };
            object[] valores = { opcion, articulo, servicio, fecha, fechaini, fechafin, anulado, registrado, cotizado, cotizadocompleto, cotizacooc, busca };
            return bd.DataTableFromProcedure("usp_Listar_Ordenesdepedido", parametros, valores, null);
        }
        public DataTable reportepedidodetalle(int opcion, int orden)
        {
            string[] parametros = { "@opcion", "op" };
            object[] valores = { opcion, orden };
            return bd.DataTableFromProcedure("usp_listar_ordenespedidodetalle", parametros, valores, null);
        }
        public DataTable ReportedeOC(int opcion, int articulo, int servicio, int fecha, DateTime fechaini, DateTime fechafin, int anulado, int registrado, int entregadoimcompleto, int cotizado, int cotizadocompleto, int cotizacooc, string busca, int importe, decimal minimo, decimal maximo)
        {
            string[] parametros = { "@opcion", "@articulo", "@servicio", "@fecha", "@fechaini", "@fechafin", "@anulado", "@registrado", "@entregadoimcompleto", "@cotizado", "@cotizacocompleto", "@cotizacooc", "@busca", "@importe", "@minimo", "@maximo" };
            object[] valores = { opcion, articulo, servicio, fecha, fechaini, fechafin, anulado, registrado, entregadoimcompleto, cotizado, cotizadocompleto, cotizacooc, busca, importe, minimo, maximo };
            return bd.DataTableFromProcedure("usp_Listar_OrdenesdeCompra", parametros, valores, null);
        }
        public DataTable Reporteempleados(int opcion, int opciones, string buscar, int dni, int carnet, int pasa, int cedula, int ruc, int practicas, int planillaempleado,
            int planillaobrero, int recibo, int sueldo, decimal minimo, decimal maximo, int fecha, DateTime fechaini, DateTime fechafinal, int banco, string codbanco)
        {
            string[] parametros = { "@opcion","@opciones","@buscar","@dni","@carnet","@pasa","@cedula","@ruc","@practicas","@planillaempleado","@planillaobrero",
                "@recibo","@sueldo","@minimo","@maximo","@fecha","@fechaini","@fechafinal","@banco","@codbanco"};
            object[] valores = { opcion, opciones, buscar, dni, carnet, pasa, cedula, ruc, practicas, planillaempleado, planillaobrero, recibo, sueldo, minimo, maximo, fecha, fechaini, fechafinal, banco, codbanco };
            return bd.DataTableFromProcedure("usp_ListarReporteEmpleados", parametros, valores, null);
        }
        public DataTable ReporteempleadosFiltrados(int Opcion, string empleado, string empresa, string cargo, string areagerencia, int tipodoc, int tipocontrato)
        {
            string[] parametros = { "@opcion", "@empleado", "@empresa", "@cargo", "@areagerencia", "@tipoid", "@tipocontrato" };
            object[] valores = { Opcion, empleado, empresa, cargo, areagerencia, tipodoc, tipocontrato };
            return bd.DataTableFromProcedure("[usp_ListarReporteEmpleadosFiltrados]", parametros, valores, null);
        }
        public DataTable ListarBancosCts()
        {
            return bd.DataTableFromProcedure("usp_ListarBancosCts", null, null, null);
        }
        public DataTable ExportarRequerimientos(string documento, string tipo)
        {
            string[] parametros = { "@documento", "@tipo" };
            object[] valores = { documento, tipo };
            return bd.DataTableFromProcedure("usp_ExportarRequerimientos", parametros, valores, null);
        }
        public DataTable ListarPedidoProveedor(int pedido, string proveedor)
        {
            string[] parametros = { "@pedido", "@proveedor" };
            object[] valores = { pedido, proveedor };
            return bd.DataTableFromProcedure("usp_listar_pedido_proveedor", parametros, valores, null);
        }
        public DataRow LocacionServicios(string contrato, string tipoid, string numero, int opcion, string ocupacion, string detalle)
        {
            string[] parametros = { "@contrato", "@tipoid", "@numero", "@opcion", "@ocupacion", "@detalle" };
            object[] valor = { contrato, tipoid, numero, opcion, ocupacion, detalle };
            return bd.DatarowFromProcedure("usp_Contrato_Locacion_Servicios", parametros, valor, null);
        }
        public DataTable InstitucionEducativa(string ruc, string razon, string direccion, int opcion, int busca)
        {
            string[] parametros = { "@ruc", "@razon", "@direccion", "@opcion", "@busca" };
            object[] valores = { ruc, razon, direccion, opcion, busca };
            return bd.DataTableFromProcedure("usp_institucion_educatica", parametros, valores, null);
        }
        public DataTable PracticasPreProfesionales(string contrato, string tipoid, string numero, int opcion, string ruc, string representante, string tipoidrepre, string docrepre, string situacion,
            string especialidad, string ocupacion, string dias, string horario)
        {
            string[] parametros = { "@contrato", "@tipoid", "@numero", "@opcion", "@ruc", "@representante", "@tipoidrepre", "@docrepre", "@situacion", "@especialidad", "@ocupacion", "@dias", "@horario" };
            object[] valores = { contrato, tipoid, numero, opcion, ruc, representante, tipoidrepre, docrepre, situacion, especialidad, ocupacion, dias, horario };
            return bd.DataTableFromProcedure("usp_Contrato_Practicas_Profesionales", parametros, valores, null);
        }
        public DataTable ListarPaises()
        {
            return bd.DataTableFromProcedure("usp_ListarPaises", null, null, null);
        }
        public DataTable ListarCentrosdeCosto(int codigo, int centro, string busca)
        {
            string[] parametros = { "@codigo", "@centro", "@busca" };
            object[] valores = { codigo, centro, busca };
            return bd.DataTableFromProcedure("usp_listarCentrodeCosto", parametros, valores, null);
        }
        public DataTable ListarCuentasArticulos()
        {
            return bd.DataTableFromProcedure("usp_cuentas_articulos", null, null, null);
        }
        public DataTable ListarCentroCostos()
        {
            return bd.DataTableFromProcedure("usp_ListarCentroCosto", null, null, null);
        }
        public DataTable ListarCentroCostoTieneCuenta()
        {
            return bd.DataTableFromProcedure("usp_ListarCentroCostoTieneCuenta", null, null, null);
        }
        public DataTable ListarProyectosUsuario(int usuario)
        {
            string[] parametros = { "@usuario" };
            object[] valores = { usuario };
            return bd.DataTableFromProcedure("usp_ListarProyectodelUsuario", parametros, valores, null);
        }

        public DataTable ListarEtapasProyecto(string proyecto)
        {
            string[] parametros = { "@proyecto" };
            object[] valores = { proyecto };
            return bd.DataTableFromProcedure("usp_ListarEtapasdeProyecto", parametros, valores, null);
        }
        public DataRow ListarEmpresasdelUsuario(int usuario)
        {
            string[] parametros = { "@usuario" };
            object[] valores = { usuario };
            return bd.DatarowFromProcedure("usp_EmpresaDelUsuario", parametros, valores, null);
        }
        public DataTable ListarProyectosEmpresa(string empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valores = { empresa };
            return bd.DataTableFromProcedure("usp_ProyectosdeEmpresa", parametros, valores, null);
        }
        public DataTable ListarProyectosEmpresa(string empresa, int cabecera)
        {
            string[] parametros = { "@empresa", "@cabecera" };
            object[] valores = { empresa, cabecera };
            return bd.DataTableFromProcedure("[usp_ProyectosdeEmpresaPpto]", parametros, valores, null);
        }
        public DataTable Proyectos(string proyectos, int empresa, int idproyecto, int opcion)
        {
            string[] parametros = { "@proyecto", "@empresa", "@idproyecto", "@opcion" };
            object[] valores = { proyectos, empresa, idproyecto, opcion };
            return bd.DataTableFromProcedure("usp_Proyectos", parametros, valores, null);

        }
        public DataRow EmpleadoConviviente(string numero, int tipo, byte[] imagen, string nombre, int opcion)
        {
            string[] parametros = { "@numero", "@tipo", "@imagen", "@nombre", "@opcion" };
            object[] valores = { numero, tipo, imagen, nombre, opcion };
            return bd.DatarowFromProcedure("usp_empleado_Conviviente", parametros, valores, null);
        }
        public DataTable Proyectodatos(int proyecto, string @ubicacion, int @moneda, string @areabruta, string @precioxmetro, string @preciototal, string @autoavaluo, string @revaluacuion, string @vigilancia, string @marketing, string @ventas, string @administracion, string @gerenciamiento, string @cdap, string @finder, string @costosuper, string @comision, string @comisionext, string @ceremonia, string @regaloxdpto, string @manteminion, string @atencion, string @costoprevio, string @gestioncomuni, string @porcentajecredito, string @costofianza, string @imprevisto)
        {
            string[] parametros = { "@proyecto", "@ubicacion", "@moneda", "@areabruta", "@precioxmetro", "@preciototal", "@autoavaluo", "@revaluacuion", "@vigilancia", "@marketing", "@ventas", "@administracion", "@gerenciamiento", "@cdap", "@finder", "@costosuper", "@comision", "@comisionext", "@ceremonia", "@regaloxdpto", "@manteminion", "@atencion", "@costoprevio", "@gestioncomuni", "@porcentajecredito", "@costofianza", "@imprevisto" };
            object[] valores = { proyecto, @ubicacion, @moneda, @areabruta, @precioxmetro, @preciototal, @autoavaluo, @revaluacuion, @vigilancia, @marketing, @ventas, @administracion, @gerenciamiento, @cdap, @finder, @costosuper, @comision, @comisionext, @ceremonia, @regaloxdpto, @manteminion, @atencion, @costoprevio, @gestioncomuni, @porcentajecredito, @costofianza, @imprevisto };
            return bd.DataTableFromProcedure("usp_Proyectodatos", parametros, valores, null);
        }
        public DataRow ProyectodatosListar(int proyecto)
        {
            string[] parametros = { "@proyecto" };
            object[] valores = { proyecto };
            return bd.DatarowFromProcedure("usp_Proyectodatos_listar", parametros, valores, null);
        }
        public DataTable ListarPresupuestosCabecera()
        {
            return bd.DataTableFromProcedure("usp_ListarPresupuestosCabecera", null, null, null);
        }
        public DataTable PresupuestoCabecera(int @opcion, int @numero, string @presupuesto, int @ejercicio, int @empresa, int @tipo, int @moneda, decimal @importe, int @usuario)
        {
            string[] parametros = { "@opcion", "@numero", "@presupuesto", "@ejercicio", "@empresa", "@tipo", "@moneda", "@importe", "@usuario" };
            object[] valores = { @opcion, @numero, @presupuesto, @ejercicio, @empresa, @tipo, @moneda, @importe, @usuario };
            return bd.DataTableFromProcedure("usp_PresupuestosCabecera", parametros, valores, null);
        }
        public DataTable ListarPresupuestoCentrodeCosto(int cabecera, int proyecto)
        {
            string[] parametros = { "@cabecera", "@proyecto" };
            object[] valores = { cabecera, proyecto };
            return bd.DataTableFromProcedure("usp_ListarPresupuestoCentrodeCosto", parametros, valores, null);
        }
        public DataTable ProyectoCentrodecostodetalle(int @opcion, int @iddep, int @presupuesto, int @proyecto, int etapa, decimal @importe, string @ceco, decimal @importececo, decimal @importeflujo, int @usuario)
        {
            string[] parametros = { "@opcion", "@iddep", "@presupuesto", "@proyecto", "@etapa", "@importe", "@ceco", "@importececo", "@importeflujo", "@usuario" };
            object[] valores = { @opcion, @iddep, @presupuesto, @proyecto, etapa, @importe, @ceco, @importececo, @importeflujo, @usuario };
            return bd.DataTableFromProcedure("usp_ProyectoCentrodecostodetalle", parametros, valores, null);
        }
        public DataTable InsertarAsientoFactura(int num, int nextasiento, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string ruc, string razon, string codfac, string numfac, int ccs, DateTime fecha, DateTime fechaRecepcion, DateTime FechaVence, int usuario, int moneda)
        {
            string[] parametros = { "@num", "@next", "@opcion", "@oc", "@monto", "@igv", "@total", "@cc", "@ruc", "@razon", "@codfac", "@numfac", "@ccs", "@fecha", "@fechaVence", "@fechaRecep", "@usuario", "@moneda" };
            object[] valores = { num, nextasiento, opcion, oc, monto, igv, total, cc, ruc, razon, codfac, numfac, ccs, fecha, FechaVence, fechaRecepcion, usuario, moneda };
            return bd.DataTableFromProcedure("usp_InsertarAsientoFactura", parametros, valores, null);
        }
        public DataTable InsertarAsientoFacturaLlegada(int num, int empresa, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string numfac, int moneda)
        {
            string[] parametros = { "@num", "@empresa", "@opcion", "@oc", "@monto", "@igv", "@total", "@cc", "@numfac", "@moneda" };
            object[] valores = { num, empresa, opcion, oc, monto, igv, total, cc, numfac, moneda };
            return bd.DataTableFromProcedure("usp_InsertarAsientoFacturaLlegada", parametros, valores, null);
        }
        public DataTable InsertarAsientoFacturaProvisionada(int num, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string numfac)
        {
            string[] parametros = { "@num", "@opcion", "@oc", "@monto", "@igv", "@total", "@cc", "@numfac" };
            object[] valores = { num, opcion, oc, monto, igv, total, cc, numfac };
            return bd.DataTableFromProcedure("usp_InsertarAsientoFacturaProvisionada", parametros, valores, null);
        }
        public DataTable RegistrarDetraccion(int asiento, int empresa, decimal monto)
        {
            string[] parametros = { "@Asiento", "@Empresa", "@Montodetracion" };
            object[] valores = { asiento, empresa, monto };
            return bd.DataTableFromProcedure("usp_RegistrarDetraccion", parametros, valores, null);
        }
        public DataRow SiguienteAsientoxOrdenCompra(int num)
        {
            string[] parametros = { "@numoc" };
            object[] valores = { num };
            return bd.DatarowFromProcedure("usp_SiguienteAsientoxOC", parametros, valores, null);
        }
        public DataTable InsertarAsientoRecibo(int num, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string ruc, string razon, string cod, string numfac, int ccs, DateTime fecha, DateTime fecharecep, DateTime fechavence, int usuario)
        {
            string[] parametros = { "@num", "@opcion", "@oc", "@monto", "@igv", "@total", "@cc", "@ruc", "@razon", "@codfac", "@numfac", "@ccs", "@fecha", "@fechaVence", "@fechaRecep", "@usuario" };
            object[] valores = { num, opcion, oc, monto, igv, total, cc, ruc, razon, cod, numfac, ccs, fecha, fechavence, fecharecep, usuario };
            return bd.DataTableFromProcedure("usp_InsertarAsientoRecibo", parametros, valores, null);
        }
        public DataRow Siguiente(string tabla, string campo)
        {
            string[] parametros = { "@tabla", "@campo" };
            object[] valores = { tabla, campo };
            return bd.DatarowFromProcedure("usp_Siguiente", parametros, valores, null);
        }
        public DataTable ListarPresupuestoCentrodeCostoReporte(int proyecto, int @cabecera)
        {
            string[] parametros = { "@proyecto", "@cabecera" };
            object[] valores = { proyecto, @cabecera };
            return bd.DataTableFromProcedure("usp_ListarPresupuestoCentrodeCostoReporte", parametros, valores, null);
        }
        public DataTable ListarFLujosCentrodeCostoReporte(int proyecto, int @cabecera)
        {
            string[] parametros = { "@proyecto", "@cabecera" };
            object[] valores = { proyecto, @cabecera };
            return bd.DataTableFromProcedure("usp_ListarFLujosCentrodeCostoReporte", parametros, valores, null);
        }
        public DataTable ListarPresupuestoCentrodeCostoReporteVerCuentas(int proyecto)
        {
            string[] parametros = { "@proyecto" };
            object[] valores = { proyecto };
            return bd.DataTableFromProcedure("usp_ListarPresupuestoCentrodeCostoReporteVerCuentas", parametros, valores, null);

        }
        public DataTable ListarPresupuestoCentrodeCostoReporteCuentas(int proyecto, string cuentas)
        {
            string[] parametros = { "@proyecto", "@cuentas" };
            object[] valores = { proyecto, cuentas };
            return bd.DataTableFromProcedure("usp_ListarPresupuestoCentrodeCostoReporteCuentas", parametros, valores, null);
        }
        public DataTable ListarEtapasdelProyecto(int opcion, int proyecto, int etapa, string descripcion, int estado, DateTime fechainicio, DateTime fechafin, int meses, string observa, int usuario)
        {
            string[] parametros = { "@opcion", "@proyecto", "@etapa", "@descripcion", "@estado", "@fechainicio", "@fechafin", "@meses", "@observa", "@usuario" };
            object[] valores = { opcion, proyecto, etapa, descripcion, estado, fechainicio, fechafin, meses, observa, usuario };
            return bd.DataTableFromProcedure("usp_ListarEtapasdelProyecto", parametros, valores, null);
        }
        public DataRow BuscarParametros(string valor, DateTime fecha)
        {
            string[] parametros = { "@valor", "@fecha" };
            object[] valores = { valor, fecha };
            return bd.DatarowFromProcedure("usp_buscarparametro", parametros, valores, null);
        }
        public DataTable MesEtapa(int @opcion, int @idmes, int @fketapa, int @anio, int @mes, int @usuario)
        {
            string[] parametros = { "@opcion", "@idmes", "@fketapa", "@anio", "@mes", "@usuario" };
            object[] valores = { @opcion, @idmes, @fketapa, @anio, @mes, @usuario };
            return bd.DataTableFromProcedure("usp_MesEtapa", parametros, valores, null);
        }
        public DataTable MesEtapaProyecto(int etapa)
        {
            string[] parametros = { "@Etapa" };
            object[] valores = { etapa };
            return bd.DataTableFromProcedure("usp_MesesEtapasProyectos", parametros, valores, null);
        }
        public DataTable ListarPptoEmpresas(int empresas)
        {
            string[] parametros = { "@empresas" };
            object[] valores = { empresas };
            return bd.DataTableFromProcedure("usp_ListarPptoEmpresas", parametros, valores, null);
        }
        public DataTable MesEtapaCentroCosto(int @opcion, int @etapa, int @idmesetapa, string @ceco, decimal @monto, decimal flujo, int @cabecera, int @usuario)
        {
            string[] parametros = { "@opcion", "@etapa", "@idmesetapa", "@ceco", "@monto", "flujo", "@cabecera", "@usuario" };
            object[] valores = { @opcion, @etapa, @idmesetapa, @ceco, @monto, flujo, @cabecera, @usuario };
            return bd.DataTableFromProcedure("usp_listarEtapaMesCentroCosto", parametros, valores, null);
        }
        public DataTable ListarReporteCuentaCosto(int etapa, string cc)
        {
            string[] parametros = { "@etapa", "@cc" };
            object[] valores = { etapa, cc };
            return bd.DataTableFromProcedure("usp_ListarReporteCuentaCosto", parametros, valores, null);
        }
        public DataTable ListarReporteCuentaCostoFlujo(int etapa, string cc)
        {
            string[] parametros = { "@etapa", "@cc" };
            object[] valores = { etapa, cc };
            return bd.DataTableFromProcedure("usp_ListarReporteCuentaCostoFlujo", parametros, valores, null);
        }
        public DataTable ListarBancosTiposdePago(string banco)
        {
            string[] parametros = { "@banco" };
            object[] valores = { banco };
            return bd.DataTableFromProcedure("usp_ListarBancosTiposdePago", parametros, valores, null);
        }
        public DataTable ListarBancosTiposdePagoxEmpresa(string banco, int empresa, int moneda)
        {
            string[] parametros = { "@banco", "@Empresa", "@moneda" };
            object[] valores = { banco, empresa, moneda };
            return bd.DataTableFromProcedure("usp_ListarBancosTiposdePagoxEmpresa", parametros, valores, null);
        }
        public DataTable DepositoaPlazo()
        {
            return bd.DataTableFromProcedure("usp_DepositoaPlazo", null, null, null);
        }
        public DataTable CertificadosBancarios()
        {
            return bd.DataTableFromProcedure("usp_CertificadosBancarios", null, null, null);
        }
        public DataTable ListarFacturasPorPagar(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado)
        {
            string[] parametros = { "@proveedor", "@busca", "@fecha", "@fechaini", "@fechafin", "@recepcion", "@fechaini1", "@fechafin1", "@estado" };
            object[] valores = { proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado };
            return bd.DataTableFromProcedure("usp_ListarFacturasPorPagar", parametros, valores, null);
        }
        public DataTable ListarFacturasPorPagarxEmpresa(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado, int empresa)
        {
            string[] parametros = { "@proveedor", "@busca", "@fecha", "@fechaini", "@fechafin", "@recepcion", "@fechaini1", "@fechafin1", "@estado", "@empresa" };
            object[] valores = { proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado, empresa };
            return bd.DataTableFromProcedure("usp_ListarFacturasPorPagarxEmpresa", parametros, valores, null);
        }
        public DataTable ListarFacturasPagadosxEmpresa(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado, int empresa)
        {
            string[] parametros = { "@proveedor", "@busca", "@fecha", "@fechaini", "@fechafin", "@recepcion", "@fechaini1", "@fechafin1", "@estado", "@empresa" };
            object[] valores = { proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado, empresa };
            return bd.DataTableFromProcedure("usp_ListarFacturasPagadosxEmpresa", parametros, valores, null);
        }
        public DataTable ActualizarReporteAfpRentaSeguros(int opcion, int tipoid, string doc, DateTime Fecha, int Empresa, int cta, decimal monto)
        {
            string[] parametros = { "@opcion", "@tipoid", "@doc", "@Fecha", "@empresa", "@cta", "@monto" };
            object[] valores = { opcion, tipoid, doc, Fecha, Empresa, cta, monto };
            return bd.DataTableFromProcedure("usp_ActualizarReporteAfpRentaSeguros", parametros, valores, null);
        }
        public DataTable insertarPagarfactura(string nrofactura, string proveedor, int tipo, string nropago, decimal apagar, decimal subtotal, decimal igv, decimal total, int usuario, int opcion, int banco, string nrocuenta, DateTime fechapago, int @idcomprobante, int empresa, string cuo)
        {
            string[] parametros = { "@nrofactura", "@proveedor", "@tipo", "@nropago", "@apagar", "@subtotal", "@igv", "@total", "@usuario", "@opcion", "@Banco", "@Nrocuenta", "@Fechapago", "@idcomprobante", "@cuo", "@empresa" };
            object[] valores = { nrofactura, proveedor, tipo, nropago, apagar, subtotal, igv, total, usuario, opcion, banco, nrocuenta, fechapago, @idcomprobante, cuo, empresa };
            return bd.DataTableFromProcedure("usp_insertarPagarfactura", parametros, valores, null);
        }
        public DataTable guardarfactura(int si, int asiento, string @fac, string @cc, decimal @debe, decimal @haber, int dina, DateTime fecha, DateTime? fechavence, DateTime? fecharecepcion, int usuario, int centro, string tipo, string proveedor, int moneda, string idcuenta, string nropago, decimal tcReg, decimal TcPago, DateTime fechasiento
            , decimal montodiferencial, int PosicionDiferencial, decimal TotalDiferencial, int IdComprobante, DateTime @FechaContable, string glosa)
        {
            string[] parametros = { "@sifac", "@asiento", "@fac", "@cc", "@debe", "@haber", "@dina", "@fecha", "@fechavc", "@fecharecep", "@usuario", "@ccs", "@tipo", "@proveedor", "@fkmoneda", "@Idcuenta", "@nropago",
               "@TCReg","@TCPago", "@Fechaasiento", "@MontoDiferencial", "@PosicionDiferencial","@TotalDiferencial","@IdComprobante","@FechaContable","@glosa" };
            object[] valores = { si, asiento, @fac, @cc, @debe, @haber, dina, fecha, fechavence, fecharecepcion, usuario, centro, tipo, proveedor, moneda, idcuenta, nropago, tcReg,TcPago, fechasiento, montodiferencial,
                @PosicionDiferencial ,TotalDiferencial,IdComprobante,FechaContable,glosa};
            return bd.DataTableFromProcedure("usp_guardarfactura", parametros, valores, null);
        }
        public DataTable ActualizarNotaCreditoDebito(int IdComprobante, string proveedor, string numdoc, int @opcion, int empresa)
        {
            string[] parametros = { "@idcomprobante", "@proveedor", "@numdoc", "@opcion", "@empresa" };
            object[] valores = { IdComprobante, proveedor, numdoc, @opcion, empresa };
            return bd.DataTableFromProcedure("usp_ActualizarNotaCreditoDebito", parametros, valores, null);
        }
        public DataTable ValidarChequeExiste(string banco, string cuenta, string cheque)
        {
            string[] parametros = { "@banco", "@cuenta", "@cheque" };
            object[] valores = { banco, cuenta, cheque };
            return bd.DataTableFromProcedure("usp_ValidarChequeExiste", parametros, valores, null);
        }
        public DataTable EstadodeGanaciasPerdidas(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGananciasPerdidas1", parametros, valores, null);
        }
        public DataTable SacarResultadoEjercicio(DateTime anio, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { anio, empresa };
            return bd.DataTableFromProcedure("usp_ResultadodelEjercicio", parametros, valores, null);
        }
        public DataTable FLujodeCaja(DateTime fechaini, DateTime fechafin, string nombre, int empresa, int tamañoletras)
        {
            string[] parametros = { "@fechamin", "@fechamax", "@empresa", "@lenmes" };
            object[] valores = { fechaini, fechafin, empresa, tamañoletras };
            return bd.DataTableFromProcedure("usp_FlujodeCajas", parametros, valores, null);
        }
        public DataTable BalanceGenerarlActivoCorriente(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneralActivoCorriente", parametros, valores, null);
        }
        public DataTable BalanceGeneral(DateTime año, int empresa)
        {
            //var tb = new DataTable();
            //using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            //{

            //    cn.Open();
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = cn;
            //        cmd.CommandText = "dbo.usp_BalanceGeneral";
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.Add("@año", SqlDbType.DateTime).Value = año;
            //        cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
            //        // cmd.ExecuteNonQuery();
            //        using (SqlDataReader dr = cmd.ExecuteReader())
            //        {
            //            tb.Load(dr);
            //        }
            //    }
            //    cn.Close();
            //    cn.Dispose();
            //}
            //return tb;

            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneral", parametros, valores, null);
        }
        public DataTable BalanceGenerarlActivonoCorriente(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneralActivonoCorriente", parametros, valores, null);
        }
        public DataTable BalanceGeneralActivoPasivoCorriente(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneralActivoPasivoCorriente", parametros, valores, null);
        }
        public DataTable BalanceGeneralActivoPasivonoCorriente(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneralActivoPasivonoCorriente", parametros, valores, null);
        }
        public DataTable BalanceGeneralPatrimonio(DateTime año, int empresa)
        {
            string[] parametros = { "@año", "@empresa" };
            object[] valores = { año, empresa };
            return bd.DataTableFromProcedure("usp_BalanceGeneralPatrimonio", parametros, valores, null);
        }
        public DataTable ListarFacturasSinPagar(string buscar, int factura, int provee, int check, string tipo, int fecha, DateTime fechainicio, DateTime fechafin)
        {
            string[] parametros = { "@buscar", "@factura", "@provee", "@checktipo", "@tipo", "@fecha", "@fechainicio", "@fechafin" };
            object[] valores = { buscar, factura, provee, check, tipo, fecha, fechainicio, fechafin };
            return bd.DataTableFromProcedure("usp_ListarFacturasSinPagar", parametros, valores, null);
        }
        public DataTable ListarFicSinFactura(string buscar, int fic, int provee, int check, string tipo)
        {
            string[] parametros = { "@buscar", "@factura", "@provee", "@checktipo", "@tipo" };
            object[] valores = { buscar, fic, provee, check, tipo };
            return bd.DataTableFromProcedure("usp_ListarFicSinFactura", parametros, valores, null);
        }
        public DataTable EliminarItemOrdenPedido(int pedido, int item)
        {
            string[] parametros = { "@pedido", "@articulo" };
            object[] valores = { pedido, item };
            return bd.DataTableFromProcedure("usp_EliminarItemOrdenPedido", parametros, valores, null);
        }
        public DataTable ListarFaltantesCotizacion(int cotizacion)
        {
            string[] parametros = { "@cot" };
            object[] valores = { cotizacion };
            return bd.DataTableFromProcedure("usp_ListarFaltantesCotizacion", parametros, valores, null);
        }
        public DataRow ListarGravaIgvOrdenCompra(int orden)
        {
            string[] parametros = { "@orden" };
            object[] valores = { orden };
            return bd.DatarowFromProcedure("usp_ListarGravaIgvOrdenCompra", parametros, valores, null);
        }
        public DataRow VerMaximoPresupuesto(int cabecera)
        {
            string[] parametros = { "@cabecera" };
            object[] valores = { cabecera };
            return bd.DatarowFromProcedure("usp_VerMaximoPresupuesto", parametros, valores, null);
        }
        public DataTable listar_Detalle_Cotizacion(int pedido, string proveedor)
        {
            string[] parametros = { "@pedido", "@proveedor" };
            object[] valores = { pedido, proveedor };
            return bd.DataTableFromProcedure("usp_listar_Detalle_Cotizacion", parametros, valores, null);
        }
        public DataRow ActualizarCotizacionDetalle(int cod, decimal valor, decimal total)
        {
            string[] parametros = { "@cod", "@valor", "@total" };
            object[] valores = { cod, valor, total };
            return bd.DatarowFromProcedure("usp_ActualizarCotizacionDetalle", parametros, valores, null);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCosto(int etapa, string ceco, string cuenta, int cabecera)
        {
            string[] parametros = { "@etapa", "@ceco", "@cuenta", "@cabecera" };
            object[] valores = { etapa, ceco, cuenta, cabecera };
            return bd.DataTableFromProcedure("usp_ListarDetalleDelReporteDeCentrodeCosto", parametros, valores, null);
        }
        public DataTable TiposID(int opcion, int codigo, string valor, int leng, string codsunat)
        {
            string[] parametros = { "@opcion", "@cod", "@valor", "@len", "@Codsunat" };
            object[] valores = { opcion, codigo, valor, leng, codsunat };
            return bd.DataTableFromProcedure("usp_TiposiD", parametros, valores, null);
        }
        public DataTable EntidadFinanciera(int opcion, int codigo, string valor, string leng, int codsunat)
        {
            string[] parametros = { "@opcion", "@cod", "@valor", "@sufijo", "@codsunat" };
            object[] valores = { opcion, codigo, valor, leng, codsunat };
            return bd.DataTableFromProcedure("usp_EntidadFinanciera", parametros, valores, null);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFLujos(int etapa, string ceco, string cuenta, int cabecera)
        {
            string[] parametros = { "@etapa", "@ceco", "@cuenta", "@cabecera" };
            object[] valores = { etapa, ceco, cuenta, cabecera };
            return bd.DataTableFromProcedure("usp_ListarDetalleDelReporteDeCentrodeCostoFLujos", parametros, valores, null);
        }
        public DataRow VerUltimoIdentificador(string tabla, string campo)
        {
            string[] parametros = { "@tabla", "@campo" };
            object[] valores = { tabla, campo };
            return bd.DatarowFromProcedure("usp_VerUltimoIdentificador", parametros, valores, null);
        }
        public DataTable InsertarActualizarCargo(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarCargo", parametros, valores, null);
        }
        public DataTable InsertarActualizarEmpresaEps(int @cod, int @opcion, string @cargo, int @usuario, decimal beneficiario, decimal adicional1, decimal adicional2, decimal adicional3, Boolean activo)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario", "@beneficiario", "@adicional1", "@adicional2", "@adicional3", "@activo" };
            object[] valores = { cod, opcion, cargo, usuario, beneficiario, adicional1, adicional2, adicional3, activo };
            return bd.DataTableFromProcedure("usp_InsertarActualizarEmpresaEps", parametros, valores, null);
        }
        public DataTable InsertarActualizarEmpresaEpsPLanes(int @cod, int codplan, int codeps, int @opcion, string @cargo, int @usuario, decimal monto)
        {
            string[] parametros = { "@codEmp", "@codPlan", "@codEps", "@opcion", "@cargo", "@usuario", "@monto" };
            object[] valores = { cod, codplan, codeps, opcion, cargo, usuario, monto };
            return bd.DataTableFromProcedure("usp_InsertarActualizarEmpresaEpsPLanes", parametros, valores, null);
        }
        public DataTable PLanes(int opcion, int cod, int empresa, string plan)
        {
            string[] parametros = { "@opcion", "@cod", "@empresa", "@plan" };
            object[] valores = { opcion, cod, empresa, plan };
            return bd.DataTableFromProcedure("usp_PLanes", parametros, valores, null);
        }
        public DataTable InsertarActualizarEpsAdicional(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarEpsAdicional", parametros, valores, null);
        }
        public DataTable InsertarActualizarEstadoCivil(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarEstadoCivil", parametros, valores, null);
        }
        public DataTable ReversaDeFacturas(string nrofac, string proveedor)
        {
            string[] parametros = { "@nrofac", "@proveedor" };
            object[] valores = { nrofac, proveedor };
            return bd.DataTableFromProcedure("usp_ReversaDeFacturas", parametros, valores, null);
        }
        public DataTable InsertarActualizarGradoInstruccion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarGradoInstruccion", parametros, valores, null);
        }
        public DataTable InsertarActualizarMoneda(int @cod, int @opcion, string @cargo, int @usuario, string names)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario", "@name" };
            object[] valores = { cod, opcion, cargo, usuario, names };
            return bd.DataTableFromProcedure("usp_InsertarActualizarMoneda", parametros, valores, null);
        }
        public DataTable InsertarActualizarPeriodicidad(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarPeriodicidad", parametros, valores, null);
        }
        public DataTable InsertarActualizarProfesion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarProfesion", parametros, valores, null);
        }
        public DataTable InsertarActualizarSector_Empresarial(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarSector_Empresarial", parametros, valores, null);
        }
        public DataTable InsertarActualizarSede(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarSede", parametros, valores, null);
        }
        public DataTable InsertarActualizarAFP(int @cod, int @opcion, string @cargo)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo" };
            object[] valores = { cod, opcion, cargo };
            return bd.DataTableFromProcedure("usp_InsertarActualizarAFP", parametros, valores, null);
        }
        public DataTable InsertarActualizarSexo(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarSexo", parametros, valores, null);
        }
        public DataTable InsertarActualizarTipoContratacion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarTipoContratacion", parametros, valores, null);
        }
        public DataTable InsertarActualizarTipoContrato(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarTipoContrato", parametros, valores, null);
        }
        public DataTable InsertarActualizarVinculoFamiliar(int @cod, int @opcion, string @cargo, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@cargo", "@usuario" };
            object[] valores = { cod, opcion, cargo, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarVinculoFamiliar", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarAfp(int @cod, int @opcion, string descripcion, decimal aporte, decimal seguro, decimal comision, DateTime periodo, decimal rma, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@descripcion", "@aporte", "@seguro", "@comision", "@periodo", "@rma", "@usuario" };
            object[] valores = { cod, opcion, descripcion, aporte, seguro, comision, periodo, rma, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarAfp", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarInstitucionEducativa(string @cod, int @opcion, string descripcion, string direccion, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@descripcion", "@direccion", "@usuario" };
            object[] valores = { cod, opcion, descripcion, direccion, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarInstitucionEducativa", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarPais(string @cod, int @opcion, string campo1, string campo2, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@campo1", "@campo2", "@usuario" };
            object[] valores = { cod, opcion, campo1, campo2, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarPais", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarOperacion(string @cod, int @opcion, string campo1, string campo2, int @usuario)
        {
            string[] parametros = { "@cod", "@opcion", "@campo1", "@campo2", "@usuario" };
            object[] valores = { cod, opcion, campo1, campo2, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarOperacion", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarSubOperacion(string @cod, int @opcion, string campo1, string campo2, string campo3, int @usuario, int cod2)
        {
            string[] parametros = { "@cod", "@opcion", "@campo1", "@campo2", "@campo3", "@usuario", "@cod2" };
            object[] valores = { cod, opcion, campo1, campo2, campo3, usuario, cod2 };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarSubOperacion", parametros, valores, null);
        }
        public DataTable InsertarActualizarListarEmpresas(string @id, int @opcion, string @campo1, string @campo2, int @sector, string @direccion, int @dep, int @prov, int @dis, int @tipo,
            string @repre, int @cia, int usuario, int stock)
        {
            string[] parametros = { "@id", "@opcion", "@campo1", "@campo2", "@sector", "@direcc", "@dep", "@prov", "@dis", "@tipo", "@repre", "@cia", "@usuario", "@stock" };
            object[] valores = { @id, @opcion, @campo1, @campo2, @sector, @direccion, @dep, @prov, @dis, @tipo, @repre, @cia, usuario, stock };
            return bd.DataTableFromProcedure("usp_InsertarActualizarListarEmpresas", parametros, valores, null);
        }
        public DataTable ComisionesBonos(int @opcion, int @pkid, int @tipoid, string @numdoc, int @pkempresa, int @fkempresa, DateTime @periodo, decimal sueldo, decimal @comision, decimal @bono,
            int @idusuario, DateTime @fecha, int Estado)
        {
            string[] parametros = { "@opcion", "@pkid", "@tipoid", "@numdoc", "@pkempresa", "@fkempresa", "@periodo", "@sueldo", "@comision", "@bono", "@idusuario", "@fecha", "@estado" };
            object[] valores = { @opcion, @pkid, @tipoid, @numdoc, @pkempresa, @fkempresa, @periodo, sueldo, @comision, @bono, @idusuario, @fecha, Estado };
            return bd.DataTableFromProcedure("usp_ComisionesBonos", parametros, valores, null);
        }
        public DataTable ComisionesBonos_Reporte(DateTime fechade, DateTime fechaa)
        {
            string[] parametros = { "@fechade", "@fechaa" };
            object[] valores = { fechade, fechaa };
            return bd.DataTableFromProcedure("usp_ComisionesBonos_Reporte", parametros, valores, null);
        }
        public DataTable BuscarEmpleadoActivo()
        {
            return bd.DataTableFromProcedure("usp_BuscarEmpleadoActivo", null, null, null);
        }
        public DataTable ActualizarParametros(int @opcion, string @campo, decimal valor, string observa, int usuario, DateTime fecha)
        {
            string[] parametros = { "@opcion", "@campo", "@valor", "@obser", "@usuario", "@date" };
            object[] valores = { opcion, campo, valor, observa, usuario, fecha };
            return bd.DataTableFromProcedure("usp_ActualizarParametros", parametros, valores, null);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFecha(int etapa, int cuenta, DateTime fecha)
        {
            string[] parametros = { "@etapa", "@cuenta", "@fecha" };
            object[] valores = { etapa, cuenta, fecha };
            return bd.DataTableFromProcedure("usp_ListarDetalleDelReporteDeCentrodeCostoFecha", parametros, valores, null);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFechaFacturas(int etapa, string cuenta, DateTime fecha)
        {
            string[] parametros = { "@etapa", "@cuenta", "@fecha" };
            object[] valores = { etapa, cuenta, fecha };
            return bd.DataTableFromProcedure("usp_ListarDetalleDelReporteDeCentrodeCostoFechaFacturas", parametros, valores, null);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFechaFlujoFacturas(int etapa, string cuenta, DateTime fecha)
        {
            string[] parametros = { "@etapa", "@cuenta", "@fecha" };
            object[] valores = { etapa, cuenta, fecha };
            return bd.DataTableFromProcedure("usp_ListarDetalleDelReporteDeCentrodeCostoFechaFlujoFacturas", parametros, valores, null);
        }
        public DataTable ListarCotizacionesPorNumero(int numero)
        {
            string[] parametros = { "@numero" };
            object[] valores = { numero };
            return bd.DataTableFromProcedure("usp_ListarCotizacionesPorNumero", parametros, valores, null);
        }
        public DataTable InsertarActualizarImpuestoRenta(int opcion, int codigo, string descripcion, decimal minimo, decimal maximo, decimal valor, string observacion, int usuario)
        {
            string[] parametros = { "@opcion", "@codigo", "@descripcion", "@minimo", "@maximo", "@valor", "@observacion", "@usuario" };
            object[] valores = { opcion, codigo, descripcion, minimo, maximo, valor, observacion, usuario };
            return bd.DataTableFromProcedure("usp_InsertarActualizarImpuestoRenta", parametros, valores, null);
        }
        public DataTable BuscarPaisActual(string pais)
        {
            string[] parametros = { "@pais" };
            object[] valores = { pais };
            return bd.DataTableFromProcedure("usp_BuscarPaisActual", parametros, valores, null);
        }
        public DataTable EliminarFactura(int fic, int estado)
        {
            string[] parametros = { "@fic", "@estado" };
            object[] valores = { fic, estado };
            return bd.DataTableFromProcedure("usp_EliminarFactura", parametros, valores, null);
        }
        public DataTable ListarEmpleadosDesvinculados()
        {
            return bd.DataTableFromProcedure("usp_ListarEmpleadosDesvinculados", null, null, null);
        }
        public DataTable BuscarCuentasBancoPagar(string banco, string cuenta, string CuentaBancaria)
        {
            string[] parametros = { "@banco", "@cadena", "@CuentaBancaria" };
            object[] valores = { banco, cuenta, CuentaBancaria };
            return bd.DataTableFromProcedure("usp_BuscarCuentasBancoPagar", parametros, valores, null);
        }
        public DataTable BuscarCuentasBancoPagarBoletas(string banco, string cuenta)
        {
            string[] parametros = { "@banco", "@cadena" };
            object[] valores = { banco, cuenta };
            return bd.DataTableFromProcedure("[usp_BuscarCuentasBancoPagarBoletas]", parametros, valores, null);
        }
        public DataTable ActualizarBoletas(int tipo, string doc, DateTime fecha, int estado)
        {
            string[] parametros = { "@tipo", "@doc", "@InicioMes", "@estado" };
            object[] valores = { tipo, doc, fecha, estado };
            return bd.DataTableFromProcedure("usp_ActualizarBoletas", parametros, valores, null);
        }
        public DataTable ListarComisionesEmpleado(int codigo, int contrato)
        {
            string[] parametros = { "@codigo", "@contra" };
            object[] valores = { codigo, contrato };
            return bd.DataTableFromProcedure("usp_ListarComisionesEmpleado", parametros, valores, null);
        }
        public DataTable EmpleadoComision(int opcion, int codigo, int contrato, int comisiones, decimal comiporcentaje, string comiperiodo, int destaque, decimal valordestaque, string periododestaque, int produccion, decimal importepro, decimal porcentajepro, string periodopro,
            byte[] imagenpro, string nombreimagenpro, int regular, decimal impregular, int movilidad, decimal impmovilidad, string permovilidad, int usuario, decimal pordestaque)
        {
            string[] parametros = {"@opcion","@codigo","@contrato","@comisiones","@comiporcentaje","@comiperiodo","@destaque","@valordestaque","@periododestaque","@produccion","@importepro",
            "@porcentajepro","@periodopro","@imagenpro","@nombreimagen","@regular","@impregular","@movilidad","@impmovilidad","@permovilidad","@usuario","@pordestaque" };
            object[] valores = { opcion, codigo, contrato, comisiones, comiporcentaje, comiperiodo, destaque, valordestaque, periododestaque, produccion, importepro, porcentajepro, periodopro,
            imagenpro, nombreimagenpro, regular, impregular, movilidad, impmovilidad, permovilidad, usuario,pordestaque };
            return bd.DataTableFromProcedure("usp_ComisionEmpleado", parametros, valores, null);
        }
        public DataRow ListarAreaGerenciaDeUsuario(string @Login_User)
        {
            string[] parametros = { "@Login_User" };
            object[] valores = { @Login_User };
            return bd.DatarowFromProcedure("usp_ListarAreaGerenciaDeUsuario", parametros, valores, null);
        }
        public DataTable SeleccionarBoletas(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_SeleccionarBoletas", parametros, valores, null); ;
        }
        public DataTable SeleccionarGratificacion(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_SeleccionarGratificacion", parametros, valores, null); ;
        }
        public DataTable SeleccionarPagoCts(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_SeleccionarPagoCts", parametros, valores, null); ;
        }
        public DataTable GenerarBoletasMensuales(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin", "@usuario" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin, usuario };
            return bd.DataTableFromProcedure("usp_GenerarBoletasMensuales", parametros, valores, null); ;
        }
        public DataTable BalanceParametros(int opcion, int pos, string codigoreal, string codigo, string nombre, string cuenta, int usuario)
        {
            string[] parametros = { "@opcion", "@pos", "@codigoreal", "@codigo", "@nombre", "@cuenta", "@usuario" };
            object[] valores = { opcion, pos, codigoreal, codigo, nombre, cuenta, usuario };
            return bd.DataTableFromProcedure("usp_BalanceParametros", parametros, valores, null); ;
        }
        public DataTable BalanceGananciasParametros(int opcion, int pos, string codigoreal, string codigo, string nombre, string cuenta, int usuario, string signo)
        {
            string[] parametros = { "@opcion", "@pos", "@codigoreal", "@codigo", "@nombre", "@cuenta", "@usuario", "@signo" };
            object[] valores = { opcion, pos, codigoreal, codigo, nombre, cuenta, usuario, signo };
            return bd.DataTableFromProcedure("usp_BalanceGanaciaParametros", parametros, valores, null); ;
        }
        public DataTable GenerarAsientodeBoletasGeneradas(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin", "@usuario" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin, usuario };
            return bd.DataTableFromProcedure("usp_GenerarAsientodeBoletasGeneradas", parametros, valores, null); ;
        }
        public DataTable TipodeCambio(int opcion, int año, int mes, int dia, decimal compra, decimal venta, byte[] img)
        {
            string[] parametros = { "@opcion", "@año", "@mes", "@dia", "@compra", "@venta", "@img" };
            object[] valores = { opcion, año, mes, dia, compra, venta, img };
            return bd.DataTableFromProcedure("usp_TipodeCambio", parametros, valores, null); ;
        }
        public DataTable InsertarCuentasReflejo(int asiento, int empresa, string cuenta, decimal monto, string lado)
        {
            string[] parametros = { "@asiento", "@empresa", "@cuenta", "@monto", "@lado" };
            object[] valores = { asiento, empresa, cuenta, monto, lado };
            return bd.DataTableFromProcedure("usp_InsertarCuentasReflejo", parametros, valores, null); ;
        }
        public DataTable InsertarAsientosdeBoletas(int empresasx, string cuentas, int codigo, decimal monto)
        {
            string[] parametros = { "@empresas", "@cuenta", "@codigo", "@monto" };
            object[] valores = { empresasx, cuentas, codigo, monto };
            return bd.DataTableFromProcedure("usp_InsertarAsientosdeBoletas", parametros, valores, null); ;
        }
        public DataTable CuentasReflejo(string @cuenta)
        {
            string[] parametros = { "@cuenta" };
            object[] valores = { @cuenta };
            return bd.DataTableFromProcedure("usp_CuentasReflejo", parametros, valores, null); ;
        }
        public DataTable StoreProcedures(int opcion, int codigo, string store, int cadena)
        {
            string[] parametros = { "@opcion", "@codigo", "@store", "@cadena" };
            object[] valores = { opcion, codigo, store, cadena };
            return bd.DataTableFromProcedure("usp_StoreProcedures", parametros, valores, null); ;
        }
        public DataTable GenerarGratificaciones(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin", "@usuario" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin, usuario };
            return bd.DataTableFromProcedure("usp_GenerarGratificaciones", parametros, valores, null); ;
        }
        public DataTable Generarcts(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fechaini", "@fechafin", "@usuario" };
            object[] valores = { empresa, tipo, numero, fecha, fechaini, fechafin, usuario };
            return bd.DataTableFromProcedure("usp_Generarcts", parametros, valores, null); ;
        }
        public DataRow getMinMaxContrato()
        {
            return bd.DatarowFromProcedure("usp_getMinMaxContrato", null, null, null); ;
        }
        public DataTable PLanesdelaEmpresa()
        {
            return bd.DataTableFromProcedure("usp_PLanesdelaEmpresa", null, null, null); ;
        }
        public DataTable TablaSolicitudes(int opcion, int empleado, string accion, string valor, int estado, int solicita, string observacion)
        {
            string[] parametros = { "@opcion", "@empleado", "@accion", "@valores", "@estado", "@solicita", "@observacion" };
            object[] valores = { opcion, empleado, accion, valor, estado, solicita, observacion };
            return bd.DataTableFromProcedure("usp_TablaSolicitudes", parametros, valores, null); ;
        }
        public DataTable EmpresasExternas(int opcion, int registro, int codigo, string ruc, string empresa, int certificado, decimal importe, decimal renta, byte[] foto, string nombrefoto, int usuario, DateTime fecha)
        {
            string[] parametros = { "@opcion", "@registro", "@codigo", "@ruc", "@empresa", "@certificado", "@importe", "@renta", "@imagen", "@nombreimagen", "@usuario", "@fechaCertificado" };
            object[] valores = { opcion, registro, codigo, ruc, empresa, certificado, importe, renta, foto, nombrefoto, usuario, fecha };
            return bd.DataTableFromProcedure("usp_EmpresasExternas", parametros, valores, null);
        }
        public DataTable DesvinculacionOtrosDscto(int opcion, int registro, int tipo, string numero, string motivo, decimal importe, byte[] descuento, string nombredesc, int usuario)
        {
            string[] parametros = { "@opcion", "@registro", "@tipo", "@numero", "@motivo", "@importe", "@descuento", "@nombredesc", "@usuario" };
            object[] valores = { opcion, registro, tipo, numero, motivo, importe, descuento, nombredesc, usuario };
            return bd.DataTableFromProcedure("usp_DesvinculacionOtrosDscto", parametros, valores, null);
        }
        public DataTable AbonosExternos(int opcion, DateTime fecha, int empresa, int codigo, string ruc, decimal importe, int usuario)
        {
            string[] parametros = { "@opcion", "@fecha", "@empresa", "@codigo", "@ruc", "@importe", "@usuario" };
            object[] valores = { opcion, fecha, empresa, codigo, ruc, importe, usuario };
            return bd.DataTableFromProcedure("usp_AbonosExternos", parametros, valores, null); ;
        }
        public DataTable SolicitudEmpleadoExt(int numero, int area, string servicio, string observacion, int estado, int usuario)
        {
            string[] parametros = { "@num", "@area", "@servicio", "@observacion", "@estado", "@usuario" };
            object[] valores = { numero, area, servicio, observacion, estado, usuario };
            return bd.DataTableFromProcedure("usp_SolicitudEmpleadoExt", parametros, valores, null); ;
        }
        public DataRow EmpresaEPsMOntosMaximos(int numero, int codigo)
        {
            string[] parametros = { "@valor", "@codigo" };
            object[] valores = { numero, codigo };
            return bd.DatarowFromProcedure("usp_EmpresaEPsMOntosMaximos", parametros, valores, null); ;
        }
        public DataTable ActualizarMemoPremio(int codigo, int tipoid, string numero, int tipo, string observacion)
        {
            string[] parametros = { "@codigo", "@tipoid", "@numero", "@tipo", "@observacion" };
            object[] valores = { codigo, tipoid, numero, tipo, observacion };
            return bd.DataTableFromProcedure("usp_ActualizarMemoPremio", parametros, valores, null); ;
        }
        public DataTable ReporteBoletas(string empresa, string numero, DateTime fecinicio, DateTime fecfin)
        {
            string[] parametros = { "@empresa", "@numero", "@fecInicio", "@fecFin" };
            object[] valores = { empresa, numero, fecinicio, fecfin };
            return bd.DataTableFromProcedure("usp_ReporteBoletas", parametros, valores, null); ;
        }
        public DataTable ReporteBoletasAsientos(string empresa, string numero, DateTime fecinicio, DateTime fecfin)
        {
            string[] parametros = { "@empresa", "@numero", "@fecInicio", "@fecFin" };
            object[] valores = { empresa, numero, fecinicio, fecfin };
            return bd.DataTableFromProcedure("usp_ReporteBoletas_Asiento", parametros, valores, null); ;
        }
        public DataTable BuscarBoletasPOrPAgar(int empresa, int tipo, string numero, int fecha, DateTime fecinicio, DateTime fecfin)
        {
            string[] parametros = { "@empresa", "@tipo", "@numero", "@fecha", "@fecInicio", "@fecFin" };
            object[] valores = { empresa, tipo, numero, fecha, fecinicio, fecfin };
            return bd.DataTableFromProcedure("usp_BuscarBoletasPOrPAgar", parametros, valores, null); ;
        }
        public DataTable FacturasManualesBusqueda(string empresa, string nrofac, string proveedor, string glosa, int fecha, DateTime fechaini, DateTime fechafin, string listadoFacturas)
        {
            string[] parametros = { "@empresa", "@nrofac", "@proveedor", "@glosa", "@fecha", "@fechaini", "@fechaFin", "@listadoFacturas" };
            object[] valores = { empresa, nrofac, proveedor, glosa, fecha, fechaini, fechafin, listadoFacturas };
            return bd.DataTableFromProcedure("usp_FacturasManualesBusqueda", parametros, valores, null); ;
        }
        public DataTable CargosAreas(int opcion, int cargo, int area, string cadena)
        {
            string[] parametros = { "@opcion", "@cargo", "@area", "@cadena" };
            object[] valores = { opcion, cargo, area, cadena };
            return bd.DataTableFromProcedure("usp_CargosAreas", parametros, valores, null); ;
        }
        public DataRow EmpleadoFamiliaExiste(int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp", "@Tipo_ID_Fam_Old", "@Nro_ID_Fam_Old" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, Tipo_ID_Fam_Old, Nro_ID_Fam_Old };
            return bd.DatarowFromProcedure("usp_EmpleadoFamiliaExiste", parametros, valores, null); ;
        }
        public DataRow CalcularEdad(DateTime fecha, DateTime hoy, int opcion)
        {
            string[] parametros = { "@fecha", "@hoy", "@opcion" };
            object[] valores = { fecha, hoy, opcion };
            return bd.DatarowFromProcedure("usp_CalcularEdad", parametros, valores, null); ;
        }
        public DataRow AprobarPostulantePrevia(int Tipo_ID_Postulante, string Nro_ID_Postulante, int Id_SolicitaEmpleado, int opcion)
        {
            string[] parametros = { "@Tipo_ID_Postulante", "@Nro_ID_Postulante", "@Id_SolicitaEmpleado", "@estado" };
            object[] valores = { Tipo_ID_Postulante, Nro_ID_Postulante, Id_SolicitaEmpleado, opcion };
            return bd.DatarowFromProcedure("usp_AprobarPostulantePrevia", parametros, valores, null); ;
        }
        public DataTable Periodos(int opcion, int empresa, DateTime fechas)
        {
            try
            {
                string[] parametros = { "@Opcion", "@empresa", "@fechas" };
                object[] valores = { opcion, empresa, fechas };
                return bd.DataTableFromProcedure("usp_Periodos", parametros, valores, null);
            }
            catch (Exception)
            {
                return Periodos(opcion, 0, DateTime.Now);
            }
        }
        public DataTable Periodos(string @empresa, string mes, string año, string estado)
        {
            string[] parametros = { "@empresa", "@mes", "@año", "@estado" };
            object[] valores = { empresa, mes, año, estado };
            return bd.DataTableFromProcedure("usp_PeriodosBusqueda", parametros, valores, null);
        }
        public DataTable ValidarCrearPeriodo(int @empresa, DateTime fechacontable)
        {
            string[] parametros = { "@empresa", "@FechaContable" };
            object[] valores = { empresa, fechacontable };
            return bd.DataTableFromProcedure("usp_ValidarCrearPeriodo", parametros, valores, null);
        }
        public DataTable TipoPlanCuentas(int opcion, int id, string plan, int codsunat)
        {
            string[] parametros = { "@Opcion", "@id", "@plan", "@codSunat" };
            object[] valores = { opcion, id, plan, codsunat };
            return bd.DataTableFromProcedure("usp_TipoPLanCuenta", parametros, valores, null);
        }
        public DataTable FormatoDiario5_3(DateTime Periodo, int plan)
        {
            string[] parametros = { "@Periodo", "@plan" };
            object[] valores = { Periodo, plan };
            return bd.DataTableFromProcedure("usp_FormatoDiario5_3", parametros, valores, null);
        }
        public DataTable ListarAsientosAbiertos(int opcion, int empresa, DateTime fecha)
        {
            string[] parametros = { "@Opcion", "@empresa", "@fecha" };
            object[] valores = { opcion, empresa, fecha };
            return bd.DataTableFromProcedure("usp_ListarAsientosAbiertos", parametros, valores, null);
        }
        public DataTable Detraciones(int opcion, int id, string cod, string anexo, string descripcion, decimal porcentaje, int usuario, DateTime fechas)
        {
            string[] parametros = { "@Opcion", "@Id", "@cod", "@anexo", "@Desc", "@Porcentaje", "@Usuario", "@Fechas" };
            object[] valores = { opcion, id, cod, anexo, descripcion, porcentaje, usuario, fechas };
            return bd.DataTableFromProcedure("usp_detracciones", parametros, valores, null);
        }
        public DataTable DetraccionesFiltrar(string cod, string anexo, string desc)
        {
            string[] parametros = { "@cod", "@anexo", "@desc" };
            object[] valores = { cod, anexo, desc };
            return bd.DataTableFromProcedure("usp_DetraccionesFiltrar", parametros, valores, null);
        }
        public DataTable ListarAbonosFacturas(int opcion, string numfac, int tipoid, string proveedor, int idcomprobante, int empresa)
        {
            string[] parametros = { "@opcion", "@numfac", "@tipoid", "@proveedor", "@IdComprobante", "@empresa" };
            object[] valores = { opcion, numfac, tipoid, proveedor, idcomprobante, empresa };
            return bd.DataTableFromProcedure("usp_ListarAbonosFacturas", parametros, valores, null);
        }
        public DataTable ComprobanteDePago(int opcion, int id, string descripcion, int usuario, int codigosunat, DateTime fechas)
        {
            string[] parametros = { "@Opcion", "@Id", "@Desc", "@Usuario", "@Codsunat", "@Fechas" };
            object[] valores = { opcion, id, descripcion, usuario, codigosunat, fechas };
            return bd.DataTableFromProcedure("usp_ComprobanteDePago", parametros, valores, null);
        }
        public DataTable DetraccionesPorPAgar(int empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valores = { empresa };
            return bd.DataTableFromProcedure("usp_ListarDetraccionesPorPagar", parametros, valores, null);
        }
        public DataTable DetraccionesPorPAgarVentas(int empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valores = { empresa };
            return bd.DataTableFromProcedure("usp_ListarDetraccionesPorPagarVentas", parametros, valores, null);
        }
        public DataTable Detracciones(int @Opcion, string @Nrofac, string @Proveedor, decimal @ImporteMo, decimal @ImportePEN, decimal @tc, decimal importepagar, decimal diferencia, string @nroopbanco
            , string @banco, string @ctabanco, DateTime @fechapago, int @Usuario, int @idComprobante, int idempresa, string cuopago, int @tipopago)
        {
            string[] parametros = { "@Opcion", "@Nrofac", "@Proveedor", "@ImporteMo", "@ImportePEN", "@tc", "@ImportePagado", "@diferencia", "@nroopbanco", "@banco", "@ctabanco", "@fechapago", "@Usuario",
                "@idComprobante", "@idempresa", "@cuopago","@tipopago" };
            object[] valores = { @Opcion, @Nrofac, @Proveedor, @ImporteMo, @ImportePEN, @tc, importepagar, diferencia, @nroopbanco, @banco, @ctabanco, @fechapago, @Usuario, @idComprobante, idempresa,
                cuopago, @tipopago };
            return bd.DataTableFromProcedure("usp_DetraccionPago", parametros, valores, null);
        }
        public DataTable DetraccionesVenta(int opcion, string nroboleta, int tipo, string idcliente, decimal importemo, decimal importepen, decimal tc, decimal importepagado, decimal diferencia, string nropago
            , string banco, string nrocuenta, DateTime fechapago, int usuario, int fkempresa, int idcomprobante, string cuo, int TipoPago)
        {
            string[] parametros = { "@Opcion", "@nroboleta", "@tipo", "@idcliente", "@ImporteMo", "@ImportePEN", "@TC", "@ImportePagado", "@diferencia", "@nropago", "@banco", "@ctabanco", "@fechapago", "@Usuario",
                "@empresa", "@idcomprobante", "cuopago" ,"@tipopago"};
            object[] valores = { opcion, nroboleta, tipo, idcliente, importemo, importepen, tc, importepagado, diferencia, nropago, banco, nrocuenta, fechapago, usuario, fkempresa, idcomprobante, cuo, TipoPago };
            return bd.DataTableFromProcedure("usp_DetraccionPagoVenta", parametros, valores, null);
        }
        public DataTable PagarDetracionesCabecera(int pos, int asiento, string cuo, int empresa, int proyecto, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string ruc, string nrofac,
            string cuenta, string CuentaRedondeo, DateTime @fechapago, DateTime Fechacontable, string glosa, int idcomprobante, decimal TC, int @ultimo)
        {
            string[] parametros = {"@pos", "@Asiento", "@Cuo", "@Empresa", "proyecto", "@MontoTotal", "@MontoRedondeo", "@MontoDiferencia", "@Ruc", "@Nrofac", "@cuenta", "@CuentaRedondeo", "@fechapago",
                "@FechaContable", "@glosa", "@idcomprobante", "@tc","@ultimo" };
            object[] valores = { pos,asiento, cuo, empresa, proyecto, montoTotal, montoredondeo, montodiferencia, ruc, nrofac, cuenta, CuentaRedondeo, @fechapago, Fechacontable, glosa, idcomprobante, TC
            ,@ultimo};
            return bd.DataTableFromProcedure("usp_PagarDetracionesCabecera", parametros, valores, null);
        }
        public DataTable PagarDetracionesVentaCabecera(int asiento, string cuo, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string nroboleta, string cuentaContableNacion, string cuentacontablebanco, string CuentaRedondeo, DateTime fechacontable, string glosa, int fkempresa, DateTime FechaPago, int idcomprobante, decimal TC, int pkproyecto)
        {
            string[] parametros = { "@Asiento", "@Cuo", "@MontoTotal", "@MontoRedondeo", "@MontoDiferencia", "@nroBoleta", "@CuentaContableNacion", "@CuentaContableBanco", "@CuentaRedondeo", "@fechaContable", "@glosa", "@empresa", "@FechaPago", "@IdComprobante", "@tc", "@Pkproyecto" };
            object[] valores = { asiento, cuo, montoTotal, montoredondeo, montodiferencia, nroboleta, cuentaContableNacion, cuentacontablebanco, CuentaRedondeo, fechacontable, glosa, fkempresa, FechaPago, idcomprobante, TC, pkproyecto };
            return bd.DataTableFromProcedure("usp_PagarDetracionesVentaCabecera", parametros, valores, null);
        }
        public DataTable PagarDetracionesDetalle(int pos, int @Asiento, string @Cuo, int @Empresa, int proyecto, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string @Ruc, string @Codfac,
            string @Numfac, decimal @Total, decimal @tc, int @Idcuenta, string @Cuentacontablebanco, string CuentaRedondeo, DateTime @fechaContable, string @glosa, int @Usuario, int @idcomprobante,
            string nrooperacion, int tipopago, int ultimo)
        {
            string[] parametros = { "@pos", "@Asiento", "@Cuo", "@Empresa", "@Proyecto", "@MontoTotal", "@MontoRedondeo", "@MontoDiferencia", "@Ruc", "@Codfac", "@Numfac", "@Total", "@tc", "@Idcuenta",
                "@Cuentacontablebanco", "@CuentaRedondeo", "@fechaContable", "@glosa", "@Usuario", "@idcomprobante", "@nrooperacion", "@tipopago","@ultimo" };
            object[] valores = { pos, @Asiento, @Cuo, @Empresa, proyecto, montoTotal, montoredondeo, montodiferencia, @Ruc, @Codfac, @Numfac, @Total, @tc, @Idcuenta, @Cuentacontablebanco,
                CuentaRedondeo, @fechaContable, @glosa, @Usuario, @idcomprobante, nrooperacion, tipopago,ultimo };
            return bd.DataTableFromProcedure("usp_PagarDetracionesDetalle", parametros, valores, null);
        }
        public DataTable PagarDetracionesVentaDetalle(int @Asiento, int @tipodoc, string @numdoc, string @nombreCliente, int @idcomprobante, string @Codfac, string @Numfac, string @nroBoleta,
            decimal @MontoTotal, decimal @MontoRedondeo, decimal @MontoDiferencia, decimal @tc, string @CuentaContableNacion, string @CuentaContableBanco, int @cuentaBanco, string @CuentaRedondeo,
            DateTime @fechaContable, string @glosa, int @Usuario, int fkempresa, decimal tcpago, int pkproyecto, int Detalle, string nrooperacion, int tipopago, int idctabancoDetracion)
        {
            string[] parametros = { "@Asiento", "@tipodoc", "@numdoc", "@nombreCliente", "@idcomprobante", "@Codfac", "@Numfac", "@nroBoleta", "@MontoTotal", "@MontoRedondeo", "@MontoDiferencia", "@tc",
                "@CuentaContableNacion", "@CuentaContableBanco", "@cuentaBanco", "@CuentaRedondeo", "@fechaContable", "@glosa", "@Usuario", "@empresa", "tcPago", "@pkProyecto", "@detalle","@nrooperacion",
                "@tipopago","@idctabancoDetracion" };
            object[] valores = { @Asiento, @tipodoc, @numdoc, @nombreCliente, @idcomprobante, @Codfac, @Numfac, @nroBoleta, MontoTotal, MontoRedondeo, MontoDiferencia, @tc, @CuentaContableNacion, @CuentaContableBanco,
                @cuentaBanco, CuentaRedondeo, @fechaContable, @glosa, @Usuario, fkempresa, tcpago, pkproyecto, Detalle,nrooperacion,tipopago,idctabancoDetracion };
            return bd.DataTableFromProcedure("usp_PagarDetracionesVentaDetalle", parametros, valores, null);
        }
        public DataTable ReversarAsientos(int idasiento, int proyecto, int usuario, DateTime Fecha)
        {
            string[] parametros = { "@Idasiento", "@Proyecto", "@Idusuario", "@fecha" };
            object[] valores = { idasiento, proyecto, usuario, Fecha };
            return bd.DataTableFromProcedure("usp_ReversarAsientos", parametros, valores, null);
        }
        public DataTable ListarAsientosRelacionasPagos(int proyecto, DateTime fechaasiento, int idasiento, int iddinamica)
        {
            string[] parametros = { "@Proyecto", "@FechaASiento", "@idAsiento", "@dinamica" };
            object[] valores = { proyecto, fechaasiento, idasiento, iddinamica };
            return bd.DataTableFromProcedure("usp_ListarAsientosRelacionasPagos", parametros, valores, null);
        }
        public DataTable AnularAsientos(int idasiento, int proyecto, int usuario, DateTime Fecha, DateTime FechaEmision, DateTime FechaContable, string glosa)
        {
            string[] parametros = { "@Idasiento", "@Proyecto", "@Idusuario", "@fecha", "FechaEmision", "@FechaContable", "@Glosa" };
            object[] valores = { idasiento, proyecto, usuario, Fecha, FechaEmision, FechaContable, glosa };
            return bd.DataTableFromProcedure("usp_AnularAsientos", parametros, valores, null);
        }
        public DataTable ReversarAsientosSoloEstado(int idasiento, int proyecto, DateTime Fecha)
        {
            string[] parametros = { "@Idasiento", "@Proyecto", "@fecha" };
            object[] valores = { idasiento, proyecto, Fecha };
            return bd.DataTableFromProcedure("usp_ReversarAsientosSoloEstado", parametros, valores, null);
        }
        public DataTable Clientes(int Opcion, int Codigo, int Tipoid, string Nroid, string Apepat, string Apemat, string Nombres, int Tipo, int Sexo, int Civil, string Direcion, int Distrito, int Provincia, int Departamento, string Telfijo, string Telcelular, string Email, string Ocupacion, int Usuario, DateTime Fecha)
        {
            string[] parametros = { "@Opcion", "@Codigo", "@Tipoid", "@Nroid", "@Apepat", "@Apemat", "@Nombres", "@Tipo", "@Sexo", "@Civil", "@Direcion", "@Distrito", "@Provincia", "@Departamento", "@Telfijo", "@Telcelular", "@Email", "@Ocupacion", "@Usuario", "@Fecha" };
            object[] valores = { Opcion, Codigo, Tipoid, Nroid, Apepat, Apemat, Nombres, Tipo, Sexo, Civil, Direcion, Distrito, Provincia, Departamento, Telfijo, Telcelular, Email, Ocupacion, Usuario, Fecha };
            return bd.DataTableFromProcedure("usp_Cliente", parametros, valores, null);
        }
        public DataTable ClientesBusqueda(string codigo, string nrodoc, string nombres, string estadocivil)
        {
            string[] parametros = { "@codigo", "@NroDoc", "@Nombres", "@EstadoCivil" };
            object[] valores = { codigo, nrodoc, nombres, estadocivil };
            return bd.DataTableFromProcedure("usp_ClienteBusqueda", parametros, valores, null);
        }
        public DataTable UnidadMedida(int opcion, int codigo, string descripcion, int usuario)
        {
            string[] parametros = { "@Opcion", "@Cod", "@Descripcion", "@Usuario" };
            object[] valores = { opcion, codigo, descripcion, usuario };
            return bd.DataTableFromProcedure("usp_UnidadMedida", parametros, valores, null);
        }
        public DataTable ListarProductosVender(string valor, int empresa, int proyecto)
        {
            string[] parametros = { "@valor", "@empresa", "@proyecto" };
            object[] valores = { valor, empresa, proyecto };
            return bd.DataTableFromProcedure("[usp_ListarProductosVender]", parametros, valores, null);
        }
        public DataTable ListarNroOpBancaria(int banco, string nrocuenta, string ruc, string razon, string nroop, DateTime fecha1, DateTime fecha2, int checkestados, string empresa, string tipocomprobante, string cuo)
        {
            string[] parametros = { "@Banco", "@Nrocuenta", "@Ruc", "@Razon", "@Nroop", "@Fecha1", "@Fecha2", "@checkEstados", "@Empresa", "@tipoComprobante", "@cuo" };
            object[] valores = { banco, nrocuenta, ruc, razon, nroop, fecha1, fecha2, checkestados, empresa, tipocomprobante, cuo };
            return bd.DataTableFromProcedure("usp_ListarNroOpBancaria", parametros, valores, null);
        }
        public DataTable ActualizarNroOperacion(int codigo, string valor, int tipodet, int fkempresa, string cuo)
        {
            string[] parametros = { "@Codigo", "@Nroop", "@TipoDet", "@fkempresa", "@cuo" };
            object[] valores = { codigo, valor, tipodet, fkempresa, cuo };
            return bd.DataTableFromProcedure("[usp_ActualizarNroOperacion]", parametros, valores, null);
        }
        public DataTable ActualizarNroOperacionconFechaPago(int codigo, string valor, int tipodet, int fkempresa, string cuo,DateTime fechapago)
        {
            string[] parametros = { "@Codigo", "@Nroop", "@TipoDet", "@fkempresa", "@cuo","@fechapago" };
            object[] valores = { codigo, valor, tipodet, fkempresa, cuo,fechapago };
            return bd.DataTableFromProcedure("[usp_ActualizarNroOperacion_conFecha]", parametros, valores, null);
        }
        public DataTable Vendedor(int cod, int opcion, int codigo, string nrocod, int estado, int usuario)
        {
            string[] parametros = { "@codigo", "@Opcion", "@Cod", "@Nro", "@estado", "@usuario" };
            object[] valores = { cod, opcion, codigo, nrocod, estado, usuario };
            return bd.DataTableFromProcedure("usp_Vendedor", parametros, valores, null);
        }
        public DataTable CotizacionDetalle(out int num, int opcion)
        {
            num = 10;
            string[] parametros = { "@num", "@Opcion" };
            object[] valores = { num, opcion };
            ParameterDirection[] direciones = { ParameterDirection.Output, ParameterDirection.Input };
            return bd.DataTableFromProcedure("usp_CotizacionesCLiente", parametros, valores, direciones);
        }
        public void CotizacionesCLienteCabecera(out int nume, int Opcion, int Codvend, DateTime Fechavence, decimal Subtotal, decimal Igv, decimal Importe, int Tipoidcliente, string Nroidcliente, int Estado, string Observacion, int Usuario, decimal inicial)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog =" + BASEDEDATOS + " ; user id =" + USERID + "; password =" + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_CotizacionesCLienteCabecera";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                    cmd.Parameters.Add("@Codven", SqlDbType.Int).Value = Codvend;
                    cmd.Parameters.Add("@Fechavence", SqlDbType.DateTime).Value = Fechavence;
                    cmd.Parameters.Add("@Importe", SqlDbType.Decimal).Value = Importe;
                    cmd.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = Subtotal;
                    cmd.Parameters.Add("@Igv", SqlDbType.Decimal).Value = Igv;
                    cmd.Parameters.Add("@Tipoidcliente", SqlDbType.Int).Value = Tipoidcliente;
                    cmd.Parameters.Add("@Nroidcliente", SqlDbType.NVarChar, 15).Value = Nroidcliente;
                    cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = Estado;
                    cmd.Parameters.Add("@Observacion", SqlDbType.VarChar, 250).Value = Observacion;
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = Usuario;
                    cmd.Parameters.Add("@Valorinicial", SqlDbType.Decimal).Value = inicial;
                    cmd.ExecuteNonQuery();
                    nume = int.Parse(cmd.Parameters["@num"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable CotizacionesCLienteCabecera(int Opcion, int Codvend, DateTime Fechavence, decimal subtotal, decimal igv, decimal total, int Tipoidcliente, string Nroidcliente, int Estado, string Observacion, int Usuario)
        {
            string[] parametros = { "@Opcion", "@Codven", "@Fechavence", "@subtotal", "@igv", "@importe", "@Tipoidcliente", "@Nroidcliente", "@Estado", "@Observacion", "@Usuario" };
            object[] valores = { @Opcion, @Codvend, @Fechavence, subtotal, igv, total, @Tipoidcliente, @Nroidcliente, @Estado, @Observacion, @Usuario };
            return bd.DataTableFromProcedure("usp_CotizacionesCLienteCabeceraVer", parametros, valores, null);
        }
        public DataTable CotizacionesCLienteCabeceraDetalle(int Opcion, int cod, int empresa, int proyecto, string etapa, int idarticulo, decimal cantidad, decimal preciobase, decimal tc, int tipodesc, decimal valordesc, decimal precionfina, decimal subtotal, decimal igv, int moneda, decimal inicial, int tipoinicial, decimal valorinicial)
        {
            string[] parametros = { "@Opcion", "@Codcabeza", "@Empresa", "@Proyecto", "@Etapas", "@Idarticulo", "@Cant", "@Preciobase", "@Tc", "@Tipodesc", "@Valordescuento", "@Preciofinal", "@Subtotal", "@Igv", "@moneda", "@Inicial", "@Tipoinicial", "@Valorinicial" };
            object[] valores = { Opcion, cod, empresa, proyecto, etapa, idarticulo, cantidad, preciobase, tc, tipodesc, valordesc, precionfina, subtotal, igv, moneda, inicial, tipoinicial, valorinicial };
            return bd.DataTableFromProcedure("usp_CotizacionesCLienteCabeceraDetalle", parametros, valores, null);
        }
        public DataTable CotizacionCLiente(string nrocot, string tipoid, string nroid, string nombre)
        {
            string[] parametros = { "@Nrocot", "@Tipoid", "@Nroid", "@Nombres" };
            object[] valores = { nrocot, tipoid, nroid, nombre };
            return bd.DataTableFromProcedure("usp_CotizacionCliente", parametros, valores, null);
        }
        public DataTable SeparacionVenta(int opcion, int numcot, decimal importe, decimal tipocambio, int moneda, byte[] img, string nombre, DateTime fecha, int usuario)
        {
            string[] parametros = { "@Opcion", "@Numcot", "@Importe", "@Tipocambio", "@Moneda", "@Imgpago", "@Nombrepago", "@Fecha", "@Usuario" };
            object[] valores = { opcion, numcot, importe, tipocambio, moneda, img, nombre, fecha, usuario };
            return bd.DataTableFromProcedure("usp_SeparacionVta", parametros, valores, null);
        }
        public DataTable VerificarStockProductosDeCotizacion(int numcot)
        {
            string[] parametros = { "@Numcot" };
            object[] valores = { numcot };
            return bd.DataTableFromProcedure("usp_VerificarStockProductos", parametros, valores, null);
        }
        public DataTable CronogramaVtaCabecera(int @Opcion, int @Fkcoti, decimal @Saldo, int @Moneda, decimal @Tc, int @Nrocuota, int @Usuario)
        {
            string[] parametros = { "@Opcion", "@Fkcoti", "@Saldo", "@Moneda", "@Tc", "@Nrocuota", "@Usuario" };
            object[] valores = { @Opcion, @Fkcoti, @Saldo, @Moneda, @Tc, @Nrocuota, @Usuario };
            return bd.DataTableFromProcedure("usp_CronogramaVtaCabecera", parametros, valores, null);
        }
        public DataTable CronogramaVtaDetalle(int @Opcion, int @Fkcronocab, int @Fkcoti, int @Nrocuota, DateTime @Fechavencecuota, decimal @Valorcuotas, int @Monedas, DateTime? @Fechapago, byte[] @Imgpago, string @Nombrepago, DateTime @Fecha, int @Usuario)
        {
            string[] parametros = { "@Opcion", "@Fkcronocab", "@Fkcoti", "@Nrocuota", "@Fechavencecuota", "@Valorcuotas", "@Monedas", "@Fechapago", "@Imgpago", "@Nombrepago", "@Fecha", "@Usuario" };
            object[] valores = { @Opcion, @Fkcronocab, @Fkcoti, @Nrocuota, @Fechavencecuota, @Valorcuotas, @Monedas, @Fechapago, @Imgpago, @Nombrepago, @Fecha, @Usuario };
            return bd.DataTableFromProcedure("usp_CronogramaVtaDetalle", parametros, valores, null);
        }
        public DataTable CuentaBancaria(int @Opcion, int @Id, int @Empresa, int @Banco, int @Moneda, int @Tipo, string @Nrocuenta, string @Nrocuentacci, int @Usuario)
        {
            string[] parametros = { "@Opcion", "@Id", "@Empresa", "@Banco", "@Moneda", "@Tipo", "@Nrocuenta", "@Nrocuentacci", "@Usuario" };
            object[] valores = { @Opcion, @Id, @Empresa, @Banco, @Moneda, @Tipo, @Nrocuenta, @Nrocuentacci, @Usuario };
            return bd.DataTableFromProcedure("usp_CuentaBancaria", parametros, valores, null);
        }
        public DataTable TipoCuentaBancaria(int @Opcion, int @Id, string @Descripcion, int @usuario)
        {
            string[] parametros = { "@Opcion", "@Id", "@Descripcion", "@usuario" };
            object[] valores = { @Opcion, @Id, Descripcion, usuario };
            return bd.DataTableFromProcedure("ups_TipoCuentaBancaria", parametros, valores, null);
        }
        public DataTable CuentasBancariasBusqueda(string empresa, string banco, string moneda, string cuenta, string cci)
        {
            string[] parametros = { "@Empresa", "@Banco", "@Moneda", "@Cuenta", "@Cci" };
            object[] valores = { empresa, banco, moneda, cuenta, cci };
            return bd.DataTableFromProcedure("usp_CuentasBancariasBusqueda", parametros, valores, null);
        }
        public DataTable delproducto(int abc, out int con, out int stocc)
        {
            con = 0; stocc = 0;
            ParameterDirection[] index = new ParameterDirection[3];
            index[0] = ParameterDirection.Input;
            index[1] = ParameterDirection.Output;
            index[2] = ParameterDirection.Output;
            string[] parametros = { "@abc", "@con", "@stocc" };
            object[] valores = { abc, con, stocc };
            return bd.DataTableFromProcedure("usp_delproducto", parametros, valores, index);
        }
        public DataTable TipodeCambioxDia(DateTime Fecha)
        {
            string[] parametros = { "@fecha" };
            object[] valores = { Fecha };
            return bd.DataTableFromProcedure("usp_TipodeCambioxDia", parametros, valores, null);
        }
        public DataTable ActivoFijos_Saldos(DateTime Fecha)
        {
            string[] parametros = { "@fecha" };
            object[] valores = { Fecha };
            return bd.DataTableFromProcedure("usp_ActivoFijos_Saldos", parametros, valores, null);
        }
        public DataTable ActivoFijos_SaldosResumen(DateTime Fecha)
        {
            string[] parametros = { "@fecha" };
            object[] valores = { Fecha };
            return bd.DataTableFromProcedure("usp_ActivoFijos_Saldos_Resumen", parametros, valores, null);
        }
        public DataTable ActivoFijoCrear(int empresa, int activofijo)
        {
            string[] parametros = { "@empresa", "@activofijo" };
            object[] valores = { empresa, activofijo };
            return bd.DataTableFromProcedure("usp_ActivoFijo_Create", parametros, valores, null);
        }
        public DataTable ActivoFijosParaDepreciar(int empresa, DateTime fecha)
        {
            string[] parametros = { "@empresa", "@fecha" };
            object[] valores = { empresa, fecha };
            return bd.DataTableFromProcedure("usp_ActivoFijosParaDepreciar", parametros, valores, null);
        }
        public DataTable ActivoFijo_Depreciacion(int @opcion, int @pkid, int @fkid, int @fkempresa, DateTime @FechaContable, int @Mes, decimal @vTributario, decimal @vContable, string @Cuo,
            string @Glosa, int @Estado)
        {
            string[] parametros = { "@opcion", "@pkid", "@fkid", "@fkempresa", "@FechaContable", "@Mes", "@vTributario", "@vContable", "@Cuo", "@Glosa", "@Estado" };
            object[] valores = { @opcion, @pkid, @fkid, @fkempresa, @FechaContable, @Mes, @vTributario, @vContable, @Cuo, @Glosa, @Estado };
            return bd.DataTableFromProcedure("usp_ActivoFijo_Depreciacion", parametros, valores, null);
        }
        public DataTable ActivoFijo(int @opcion, int @pkid, int @fkEmpresa, int @pkProyecto, int @pkEtapa, DateTime @FechaActivacion, DateTime @FechaContable, decimal @VidaUtil, decimal @PorcentajeTributario,
            decimal @PorcentajeContable, decimal @ValorResidual, decimal @ValorActivo, string @Glosa, string @Facturas, string @CuentaActivo, string @CuentaGasto, string @CuentaDepreciacion, string @CUOActivo, int @Estado
            , DateTime fechadoc, string cuofac, int @activo, int @tipoactivo, string @codigoti, int gerencia, int metodo, string partida, string marca, string modelo, string numeroserie, string responsable)
        {
            string[] parametros = { "@opcion", "@pkid", "@fkEmpresa", "@pkProyecto", "@pkEtapa", "@FechaActivacion", "@FechaContable", "@VidaUtil", "@PorcentajeTributario", "@PorcentajeContable", "@ValorResidual", "@ValorActivo",
                "@Glosa", "@Facturas", "@CuentaActivo", "@CuentaGasto", "@CuentaDepreciacion", "@CUOActivo", "@Estado", "@fechadoc", "@cuofac", "@Activo", "@TipoActivo", "@CodigoTI", "@Gerencia", "@Metodo", "@Partida", "@Marca",
                "@Modelo", "@NumeroSerie", "@Responsable" };
            object[] valores = { @opcion, @pkid, @fkEmpresa, @pkProyecto, @pkEtapa, @FechaActivacion, @FechaContable, @VidaUtil, @PorcentajeTributario, @PorcentajeContable, @ValorResidual, @ValorActivo, @Glosa, @Facturas, @CuentaActivo,
                @CuentaGasto, @CuentaDepreciacion, @CUOActivo, @Estado, fechadoc, cuofac, @activo, @tipoactivo, @codigoti, gerencia, metodo, partida, marca, modelo, numeroserie, responsable };
            return bd.DataTableFromProcedure("usp_ActivoFijo", parametros, valores, null);
        }
        public DataTable ReporteDepreciacionActivoFijo(int empresa, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@fechaini", "@fechafin" };
            object[] valores = { empresa, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_ReporteDepreciacionActivoFijo", parametros, valores, null);
        }
        public DataTable ActivoFijo_CuentasContable(int opcion, string cuenta)
        {
            string[] parametros = { "@opcion    ", "@cuenta" };
            object[] valores = { opcion, cuenta };
            return bd.DataTableFromProcedure("usp_ActivoFijo_CuentasContable", parametros, valores, null);
        }
        public DataTable FacturaManualCabecera(int @opcion, int @idfac, int @id, string @nro, string @nroRef, string @ruc, int @empresa, int @proyecto, int @etapa, int @compensa, int @moneda,
            decimal @tc, decimal @total, decimal @igv, int @gravaigv, DateTime @fechaemision, DateTime @fecharecepcion, DateTime @fechavence, DateTime @fechacontable, int @estado, int @tipopago,
            string @nrodocpago, string coddet, decimal porcentaje, decimal @detracion, byte[] @imgfac, string @glosa, int @usuario, string @usuarioCompensacion, int ActivoFijo)
        {
            string[] parametros = { "@opcion", "@idfac", "@id", "@nro", "@nroRef", "@ruc", "@empresa", "@proyecto", "@etapa", "@compensa", "@moneda", "@tc", "@total", "@igv", "@gravaigv",
                "@fechaemision", "@fecharecepcion", "@fechavence", "@fechacontable", "@estado", "@tipopago", "@nrodocpago", "@coddet", "@porcentaje", "@detracion", "@imgfac", "@glosa", "@usuario",
                "@usuarioCompensacion","@ActivoFijo" };
            object[] valores = { @opcion, @idfac, @id, @nro, nroRef, @ruc, @empresa, @proyecto, @etapa, @compensa, @moneda, @tc, @total, @igv, @gravaigv, @fechaemision, @fecharecepcion,
                @fechavence, fechacontable, @estado, @tipopago, @nrodocpago, coddet, porcentaje, @detracion, @imgfac, @glosa, @usuario, @usuarioCompensacion, ActivoFijo };
            return bd.DataTableFromProcedure("usp_FacturaManualCabecera", parametros, valores, null);
        }
        public DataTable FacturaManualVentaCabecera(int @opcion, int @idfac, int @id, string @nro, string @nroRef, int @tipoid, string @nroid, int @empresa, int @proyecto, int @etapa, int @moneda, decimal @tc, decimal @total, decimal @igv, DateTime @fechaemision, DateTime @fechavence, DateTime @fechacontable, int @estado, int @tipopago, string @nrodocpago, string coddet, decimal porcentaje, decimal @detracion, byte[] @imgfac, string @glosa, int @usuario)
        {
            string[] parametros = { "@opcion", "@idfac", "@id", "@nro", "@nroRef", "@tipoid", "@nroid", "@empresa", "@proyecto", "@etapa", "@moneda", "@tc", "@total", "@igv", "@fechaemision", "@fechavence", "@fechacontable", "@estado", "@tipopago", "@nrodocpago", "@coddet", "@porcentaje", "@detracion", "@imgfac", "@glosa", "@usuario" };
            object[] valores = { @opcion, @idfac, @id, @nro, @nroRef, @tipoid, @nroid, @empresa, @proyecto, @etapa, @moneda, @tc, @total, @igv, @fechaemision, @fechavence, fechacontable, @estado, @tipopago, @nrodocpago, coddet, porcentaje, @detracion, @imgfac, @glosa, @usuario };
            return bd.DataTableFromProcedure("usp_FacturaManualVentaCabecera", parametros, valores, null);
        }
        public DataTable FacturaManualDetalle(int @opcion, int @idfac, int @id, string @nro, string @ruc, string @debehaber, string @cuenta, string @ceco, int @tipoigv, decimal @importemn, decimal @importeme, string @glosa, string @cuo, int @usuario)
        {
            string[] parametros = { "@opcion", "@idfac", "@id", "@nro", "@ruc", "@debehaber", "@cuenta", "@ceco", "@tipoigv", "@importemn", "@importeme", "@glosa", "@cuo", "@usuario" };
            object[] valores = { @opcion, @idfac, @id, @nro, @ruc, @debehaber, @cuenta, @ceco, @tipoigv, @importemn, @importeme, @glosa, @cuo, @usuario };
            return bd.DataTableFromProcedure("usp_FacturaManualDetalle", parametros, valores, null);
        }
        public DataTable FacturaManualVentaDetalle(int @opcion, int @idfac, int @id, string @nro, int @tipoid, string @nroid, string @debehaber, string @cuenta, int @tipoigv, decimal @importemn, decimal @importeme, string @glosa, string @cuo, int @usuario, int fkempresa)
        {
            string[] parametros = { "@opcion", "@idfac", "@id", "@nro", "@tipoid", "@nroid", "@debehaber", "@cuenta", "@tipoigv", "@importemn", "@importeme", "@glosa", "@cuo", "@usuario", "@empresa" };
            object[] valores = { @opcion, @idfac, @id, @nro, @tipoid, @nroid, @debehaber, @cuenta, @tipoigv, @importemn, @importeme, @glosa, @cuo, @usuario, fkempresa };
            return bd.DataTableFromProcedure("usp_FacturaManualVentaDetalle", parametros, valores, null);
        }
        public DataTable FacturaManualBusqueda(string proveedor, string nrodoc, string empresa, string idcomprobante)
        {
            string[] parametros = { "@proveedor", "@nrodoc", "@empresa", "@idcomprobante" };
            object[] valores = { proveedor, nrodoc, empresa, idcomprobante };
            return bd.DataTableFromProcedure("usp_FacturaManualBusqueda", parametros, valores, null);
        }
        public DataTable BuscarImagenFacturasCompras(string proveedor, string nrodoc, int tipo, int @opcion, int fkempresa, int @idcomprobante)
        {
            string[] parametros = { "@proveedor", "@fac", "@tipo", "@opcion", "@empresa", "@idcomprobante" };
            object[] valores = { proveedor, nrodoc, tipo, @opcion, fkempresa, @idcomprobante };
            return bd.DataTableFromProcedure("usp_BuscarImagenFacturasCompras", parametros, valores, null);
        }
        public DataTable FacturaManualVentaBusqueda(string proveedor, string nrodoc, string empresa)
        {
            string[] parametros = { "@proveedor", "@nrodoc", "@empresa" };
            object[] valores = { proveedor, nrodoc, empresa };
            return bd.DataTableFromProcedure("usp_FacturaManualVentaBusqueda", parametros, valores, null);
        }
        public DataTable FacturaManualDetalleBusqueda(string proveedor, string nrodoc, int idcomprobante)
        {
            string[] parametros = { "@proveedor", "@nrodoc", "@idcomprobante" };
            object[] valores = { proveedor, nrodoc, idcomprobante };
            return bd.DataTableFromProcedure("usp_FacturaManualDetalleBusqueda", parametros, valores, null);
        }
        public DataRow FacturaManualBusquedaContadas()
        {
            return bd.DatarowFromProcedure("usp_FacturaManualBusquedaContadas", null, null, null);
        }
        public DataRow FacturaManualVentaBusquedaContadas()
        {
            return bd.DatarowFromProcedure("usp_FacturaManualVentaBusquedaContadas", null, null, null);
        }
        public DataTable FacturaManualVentaDetalleBusqueda(string proveedor, string nrodoc, int fkempresa, int idcomprobante)
        {
            string[] parametros = { "@proveedor", "@nrodoc", "@empresa", "@idcomprobante" };
            object[] valores = { proveedor, nrodoc, fkempresa, idcomprobante };
            return bd.DataTableFromProcedure("usp_FacturaManualVentaDetalleBusqueda", parametros, valores, null);
        }
        public DataTable VerFacturasPagadasCompras(string proveedor, string nrofac, int @idcomprobante)
        {
            string[] parametros = { "@proveedor", "@nrofac", "@idcomprobante" };
            object[] valores = { proveedor, nrofac, @idcomprobante };
            return bd.DataTableFromProcedure("usp_VerFacturasPagadasCompras", parametros, valores, null);
        }
        public DataTable VerFacturasPagadasVentas(string TipoYIdCliente, string nrofac, int @idcomprobante, int idempresa)
        {
            string[] parametros = { "@Cliente", "@nrofac", "@idcomprobante", "@idempresa" };
            object[] valores = { TipoYIdCliente, nrofac, @idcomprobante, idempresa };
            return bd.DataTableFromProcedure("usp_VerFacturasPagadasVentas", parametros, valores, null);
        }
        public DataTable VerPeriodoAbierto(int empresa, DateTime Fecha)
        {
            string[] parametros = { "@empresa", "@fecha" };
            object[] valores = { empresa, Fecha };
            return bd.DataTableFromProcedure("usp_VerPeriodoAbierto", parametros, valores, null);
        }
        public DataTable CreaciondeCuentasReflejo(string @cuenta)
        {
            string[] parametros = { "@cuenta" };
            object[] valores = { cuenta };
            return bd.DataTableFromProcedure("usp_CreaciondeCuentasReflejo", parametros, valores, null);
        }
        public DataTable BusquedaVentasManuales(int empresa, DateTime fecha1, DateTime fecha2, string cliente, string nroboleta)
        {
            string[] parametros = { "@empresa", "@fecha1", "@fecha2", "@Cliente", "@nroBoleta" };
            object[] valores = { empresa, fecha1, fecha2, cliente, nroboleta };
            return bd.DataTableFromProcedure("usp_BusquedaVentasManuales", parametros, valores, null);
        }
        public DataTable ListarCobrarInterEmpresas(int empresa, int @empresaDes, int moneda, DateTime fecha1, DateTime fecha2, string cliente, string nroboleta)
        {
            string[] parametros = { "@empresa", "@empresaDes", "@moneda", "@fecha1", "@fecha2", "@Cliente", "@nroBoleta" };
            object[] valores = { empresa, @empresaDes, moneda, fecha1, fecha2, cliente, nroboleta };
            return bd.DataTableFromProcedure("usp_ListarCobrarInterEmpresas", parametros, valores, null);
        }
        public DataTable BusquedaVentasManualesAbonados(int empresa, DateTime fecha1, DateTime fecha2, string cliente, string nroboleta)
        {
            string[] parametros = { "@empresa", "@fecha1", "@fecha2", "@Cliente", "@nroBoleta" };
            object[] valores = { empresa, fecha1, fecha2, cliente, nroboleta };
            return bd.DataTableFromProcedure("usp_BusquedaVentasManualesAbonados", parametros, valores, null);
        }
        public DataTable FacturaVentaManualPago(int @opcion, int @id, string @comprobante, string @nroopbanco, int @tipoid, string @cliente, int @empresa, decimal @importe, decimal @tc, string @banco,
            string @cuentabanco, DateTime @fechapago, string @cuo, int @usuario, int tipopago)
        {
            string[] parametros = { "@opcion", "@id", "@comprobante", "@nroopbanco", "@tipoid", "@cliente", "@empresa", "@importe", "@tc", "@banco", "@cuentabanco", "@fechapago", "@cuo", "@usuario", "@tipopago" };
            object[] valores = { @opcion, @id, @comprobante, @nroopbanco, @tipoid, @cliente, @empresa, @importe, @tc, @banco, @cuentabanco, @fechapago, @cuo, @usuario, tipopago };
            return bd.DataTableFromProcedure("usp_FacturaVentaManualPago", parametros, valores, null);
        }
        public DataTable InsertarAsientoFacturaCabecera(int @opcion, int @Id, int @Asiento, DateTime @fechaContable, string @Cuenta, decimal @Debe, decimal @Haber, decimal @tc, int @proyecto, int @etapa, string @cuo, int @Fkmoneda, string @glosa, DateTime FechaAbono, int dina)
        {
            string[] parametros = { "@opcion", "@Id", "@Asiento", "@fechaContable", "@Cuenta", "@Debe", "@Haber", "@tc", "@proyecto", "@etapa", "@cuo", "@fkmoneda", "@glosa", "@FechaAbono", "@dina" };
            object[] valores = { @opcion, @Id, @Asiento, @fechaContable, @Cuenta, @Debe, @Haber, @tc, @proyecto, @etapa, @cuo, Fkmoneda, glosa, FechaAbono, dina };
            return bd.DataTableFromProcedure("usp_InsertarAsientoFacturaCabecera", parametros, valores, null);
        }
        public DataTable InsertarAsientoFacturaDetalle(int @opcion, int @Id, int @Asiento, DateTime @fechaContable, string @Cuenta, int @proyecto, int @tipodoc, string @numdoc, string @razon, int @idcomprobante,
            string @codcomprobante, string @numcomprobante, int @cc, DateTime @fechaemision, DateTime @fechavencimiento, DateTime @fecharecepcion, decimal @impormn, decimal @importeme, decimal @tc, int @Fkmoneda,
            string @cuentabanco, string @nroopbanco, string @glosa, DateTime @fechaasiento, int @usuario, string @fkasi, int Tipopago, int @idctabbanco)
        {
            string[] parametros = { "@opcion", "@Id", "@Asiento", "@fechaContable", "@Cuenta", "@proyecto", "@tipodoc", "@numdoc", "@razon", "@idcomprobante", "@codcomprobante", "@numcomprobante", "@cc", "@fechaemision",
                "@fechavencimiento", "@fecharecepcion", "@impormn", "@importeme", "@tc", "@Fkmoneda", "@cuentabanco", "@nroopbanco", "@glosa", "@fechaasiento", "@usuario", "@fkasi","@Tipopago","@idctabbanco" };
            object[] valores = { @opcion, @Id, @Asiento, @fechaContable, @Cuenta, @proyecto, @tipodoc, @numdoc, @razon, @idcomprobante, @codcomprobante, @numcomprobante, @cc, @fechaemision, @fechavencimiento,
                @fecharecepcion, @impormn, @importeme, @tc, @Fkmoneda, @cuentabanco, @nroopbanco, @glosa, @fechaasiento, @usuario, @fkasi,Tipopago,@idctabbanco };
            return bd.DataTableFromProcedure("usp_InsertarAsientoFacturaDetalle", parametros, valores, null);
        }
        public DataTable InsertarAsientoDetalle(int @opcion, int @Id, int @Asiento, DateTime @fechaContable, string @Cuenta, int @proyecto, int @tipodoc, string @numdoc, string @razon, int @idcomprobante,
            string @codcomprobante, string @numcomprobante, int @cc, DateTime @fechaemision, DateTime @fechavencimiento, DateTime @fecharecepcion, decimal @impormn, decimal @importeme, decimal @tc, int @Fkmoneda,
            int @CtaBancaria, string @nroopbanco, string @glosa, DateTime @fechaasiento, int @usuario, string @fkasi, int Tipopago)
        {
            string[] parametros = { "@opcion", "@Id", "@Asiento", "@fechaContable", "@Cuenta", "@proyecto", "@tipodoc", "@numdoc", "@razon", "@idcomprobante", "@codcomprobante", "@numcomprobante", "@cc", "@fechaemision",
                "@fechavencimiento", "@fecharecepcion", "@impormn", "@importeme", "@tc", "@Fkmoneda", "@CtaBancaria", "@nroopbanco", "@glosa", "@fechaasiento", "@usuario", "@fkasi","@Tipopago" };
            object[] valores = { @opcion, @Id, @Asiento, @fechaContable, @Cuenta, @proyecto, @tipodoc, @numdoc, @razon, @idcomprobante, @codcomprobante, @numcomprobante, @cc, @fechaemision, @fechavencimiento,
                @fecharecepcion, @impormn, @importeme, @tc, @Fkmoneda, @CtaBancaria, @nroopbanco, @glosa, @fechaasiento, @usuario, @fkasi,Tipopago };
            return bd.DataTableFromProcedure("[usp_InsertarAsientoDetalle]", parametros, valores, null);
        }
        public DataTable ActivarDesactivarReflejos(int Activar) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@Desactivar" };
            object[] valores = { Activar };
            return bd.DataTableFromProcedure("usp_ActivarDesactivarReflejos", parametros, valores, null);
        }
        public DataTable BuscarCuentasBancariasxEmpresas(int empresa) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa" };
            object[] valores = { empresa };
            return bd.DataTableFromProcedure("usp_BuscarCuentasBancariasxEmpresas", parametros, valores, null);
        }
        public DataTable MovimientoBancariosxEmpresa(int empresa, DateTime FechaIni, DateTime FechaFin, string NroCuenta, int Moneda, int @idCtaBancaria) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@Fechaini", "@FechaFin", "@NroCuenta", "@moneda", "@idCtaBancaria" };
            object[] valores = { empresa, FechaIni, FechaFin, NroCuenta, Moneda, @idCtaBancaria };
            return bd.DataTableFromProcedure("usp_MovimientoBancariosxEmpresa", parametros, valores, null);
        }
        public DataTable SaldoContableCuentaBancariaxEmpresa(int empresa, DateTime FechaIni, DateTime FechaFin, string NroCuenta, int Moneda) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@Fechaini", "@FechaFin", "@NroCuenta", "@moneda" };
            object[] valores = { empresa, FechaIni, FechaFin, NroCuenta, Moneda };
            return bd.DataTableFromProcedure("usp_SaldoContableCuentaBancariaxEmpresa", parametros, valores, null);
        }
        public DataTable MovimientoBancariosxEmpresaExcel(int empresa, DateTime FechaIni, DateTime FechaFin, string NroCuenta, int Moneda, int @idCtaBancaria) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@Fechaini", "@FechaFin", "@NroCuenta", "@moneda", "@idCtaBancaria" };
            object[] valores = { empresa, FechaIni, FechaFin, NroCuenta, Moneda, @idCtaBancaria };
            return bd.DataTableFromProcedure("usp_MovimientoBancariosxEmpresaExcel", parametros, valores, null);
        }
        public DataTable ConciliacionCabecera(int opcion, int pkid, int pkempresa, int pkidCtaBancaria, string cuentacontable, DateTime Fecha,
            decimal SAldoContable, decimal EstadoCuenta, int idusuario, decimal SaldoContableInicia, decimal EstadoCuentaInicial)
        {
            string[] parametros = { "@opcion", "@pkid", "@pkempresa", "@pkidCtaBancaria", "@cuentacontable", "@Fecha", "@SaldoContable", "@EstadoCuentas", "@idUsuario","@SaldoContableInicial"
                    , "@EstadoCuentasInicial" };
            object[] valores = { opcion, pkid, pkempresa, pkidCtaBancaria, cuentacontable, Fecha, SAldoContable, EstadoCuenta, idusuario, SaldoContableInicia, EstadoCuentaInicial };
            return bd.DataTableFromProcedure("usp_ConciliacionCabecera", parametros, valores, null);
        }
        public DataTable ActualizarNumeroOperacion(int empresa, string cuo, string nroop, int idctabancaria) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@EMPRESA", "@CUO", "@NROOP", "@IDCTBANCO" };
            object[] valores = { empresa, cuo, nroop, idctabancaria };
            return bd.DataTableFromProcedure("usp_ActualizarNumeroOperacion", parametros, valores, null);
        }
        public DataTable ConciliacionDetalle(int @opcion, int @fkid, int @pkid, int @tipo, int? grupo, string @cuo, DateTime @Fecha, DateTime @FechaEjecuta,
            decimal @monto, string @operacion, string @glosa, string @glosa2, int @idasiento, int @estado, string @seguimiento, string proveedor)
        {
            string[] parametros = { "@opcion", "@fkid", "@pkid", "@tipo", "@grupo", "@cuo", "@Fecha", "@FechaEjecuta", "@monto", "@operacion", "@glosa", "@glosa2",
                "@idasiento", "@estado" ,"@seguimiento","@proveedor"};
            object[] valores = { @opcion, @fkid, @pkid, @tipo, grupo, @cuo, @Fecha, FechaEjecuta, @monto, @operacion, @glosa, @glosa2, @idasiento, @estado, @seguimiento, proveedor };
            return bd.DataTableFromProcedure("usp_ConciliacionDetalle", parametros, valores, null);
        }
        public DataTable Conciliacion_Busqueda(string empresa, string banco, string nrocuenta, DateTime FechaIni, DateTime FechaFin, int fecha) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@banco", "@NroCuenta", "@Fechaini", "@FechaFin", "@fecha" };
            object[] valores = { empresa, banco, nrocuenta, FechaIni, FechaFin, fecha };
            return bd.DataTableFromProcedure("usp_Conciliacion_Busqueda", parametros, valores, null);
        }
        public DataTable Conciliacion_BusquedaFinanzas(string empresa, string banco, string nrocuenta, DateTime FechaIni, DateTime FechaFin, int fecha) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@banco", "@NroCuenta", "@Fechaini", "@FechaFin", "@fecha" };
            object[] valores = { empresa, banco, nrocuenta, FechaIni, FechaFin, fecha };
            return bd.DataTableFromProcedure("usp_Conciliacion_BusquedaFinanzas", parametros, valores, null);
        }
        public DataTable Conciliacion_Busqueda_ConDetalle(string empresa, string banco, string nrocuenta, DateTime FechaIni, DateTime FechaFin, int fecha) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empresa", "@banco", "@NroCuenta", "@Fechaini", "@FechaFin", "@fecha" };
            object[] valores = { empresa, banco, nrocuenta, FechaIni, FechaFin, fecha };
            return bd.DataTableFromProcedure("[usp_Conciliacion_Busqueda_ConDetalle]", parametros, valores, null);
        }
        public DataTable ReporteConciliacionFinanzas(int empresa, string banco, string nrocuenta, DateTime FechaIni, DateTime FechaFin, int fecha)
        {
            string[] parametros = { "@empresa", "@banco", "@NroCuenta", "@Fechaini", "@FechaFin", "@fecha" };
            object[] valores = { empresa, banco, nrocuenta, FechaIni, FechaFin, fecha };
            return bd.DataTableFromProcedure("usp_ReporteConcilicacionFinanzas", parametros, valores, null);
        }
        public DataTable CompensacionDeCuentas(int empresa, string cuos, string cuentas, string rucs, int fecha, DateTime fechade, DateTime fechahasta)
        {
            string[] parametros = { "@empresa", "@cuos", "@cuentas", "@rucs", "@fecha", "@Fechade", "@fechahasta" };
            object[] valores = { empresa, cuos, cuentas, rucs, fecha, fechade, fechahasta };
            return bd.DataTableFromProcedure("usp_CompensaciondeCuentas", parametros, valores, null);
        }

        public DataTable ComisionesEmpleados(int opcion, int pkid, int tipodoc, string nrodoc, DateTime periodo, decimal importe, byte[] sustento, int @idusuario) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@opcion", "@pkid", "@tipodoc", "@nrodoc", "@periodo", "@importe", "@sustento", "@idusuario" };
            object[] valores = { opcion, pkid, tipodoc, nrodoc, periodo, importe, sustento, @idusuario };
            return bd.DataTableFromProcedure("usp_ComisionesEmpleados", parametros, valores, null);
        }
        public DataTable ComisionesEmpleadosBusqueda(string empleado, DateTime fechaini, DateTime fechafin, decimal importemin, decimal importemax) //1 activa ,cualquiera desactiva
        {
            string[] parametros = { "@empleado", "@fechaini", "@fechafin", "@importemin", "@importemax" };
            object[] valores = { empleado, fechaini, fechafin, importemin, importemax };
            return bd.DataTableFromProcedure("usp_ComisionesEmpleadosBusqueda", parametros, valores, null);
        }
        public DataTable BuscarFacturasManualesToNcNd(string ruc, string NumComprobante)
        {
            string[] parametros = { "@ruc", "@NumComp" };
            object[] valores = { ruc, NumComprobante };
            return bd.DataTableFromProcedure("usp_BuscarFacturasManualesToNcNd", parametros, valores, null);
        }
        public DataTable BuscarVentasManualesToNcNd(string numdoc, int tipoid, string NumComprobante)
        {
            string[] parametros = { "@cliente", "@id", "@NumComp" };
            object[] valores = { numdoc, tipoid, NumComprobante };
            return bd.DataTableFromProcedure("usp_BuscarVentasManualesToNcNd", parametros, valores, null);
        }
        public DataTable MedioPagos(int @opcion, int pkid, string mediopago, int codsunat)
        {
            string[] parametros = { "@opcion", "@pkid", "@mediopago", "@codsunat" };
            object[] valores = { opcion, pkid, mediopago, codsunat };
            return bd.DataTableFromProcedure("usp_MedioPagos", parametros, valores, null);
        }
        public DataTable TiposFaltas(int @opcion, DateTime FechaActual, string nombre, string observacion, int min, int max, Boolean descuento, int id)
        {
            string[] parametros = { "@opcion", "@FechaActual", "@Nombre", "@Observacion", "@min", "@max", "@descuento", "@id" };
            object[] valores = { opcion, FechaActual, nombre, observacion, min, max, descuento, id };
            return bd.DataTableFromProcedure("usp_TiposFaltas", parametros, valores, null);
        }
        public DataTable BuscarFacturasManualesToNcNdDEtalle(int opcion, string ruc, string NumComprobante)
        {
            string[] parametros = { "@opcion", "@ruc", "@NumComp" };
            object[] valores = { opcion, ruc, NumComprobante };
            return bd.DataTableFromProcedure("usp_BuscarFacturasManualesToNcNdDEtalle", parametros, valores, null);
        }
        public DataTable BuscarVentasManualesToNcNdDEtalle(int opcion, string ruc, int tipoid, string NumComprobante)
        {
            string[] parametros = { "@opcion", "@ruc", "@tipoid", "@NumComp" };
            object[] valores = { opcion, ruc, tipoid, NumComprobante };
            return bd.DataTableFromProcedure("usp_BuscarVentasManualesToNcNdDEtalle", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_1(int empresa, int periodo, int anio)
        {
            string[] parametros = { "@Empresa", "@PeriodoMes", "@periodoAño" };
            object[] valores = { empresa, periodo, anio };
            return bd.DataTableFromProcedure("usp_FormatodeCompras8_1", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_1_Masivo(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@PeriodoInicio", "@PeriodoFin" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("[usp_FormatodeCompras8_1_Masivo]", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_2_Masivo(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@PeriodoInicio", "@PeriodoFin" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("usp_FormatodeCompras8_2_Masivo", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_2(int @opcion, int @pkEmpresa, DateTime @Periodo, string @NumeroCorrelativo, string @Secuencia, DateTime @FechaEmision, int @TipoComprobante,
            string @SerieComprobante, string @NumeroComprobante, decimal @ValorAdquisiciones, decimal @OtrosComprobantes, decimal @ImporteTotal, int @TipoComprobantePago,
            string @SerieComprobantePago, int @AñoDua, string @NumeroComprobantePago, decimal @MontoRetencion, string @CodigoMoneda, decimal @TipoCambio, string @PaisSujeto,
            string @RazonSocialSujeto, string @DomicilioSujeto, string @DocumentoSujeto, string @DocumentoBeneficiario, string @RazonSocialBeneficiario,
            string @PaisBeneficiario, string @Vinculo, decimal @RentaBruta, decimal @Deducciones, decimal @RentaNeta, decimal @TasaRetencion, decimal @ImpuestoRetenido,
            string @Convenios, string @Exoneracion, string @TipoRenta, string @Modalidad, string @Aplicación, int @Estado)
        {
            string[] parametros = { "@opcion", "@pkEmpresa", "@Periodo", "@NumeroCorrelativo", "@Secuencia", "@FechaEmision", "@TipoComprobante", "@SerieComprobante",
                "@NumeroComprobante", "@ValorAdquisiciones", "@OtrosComprobantes", "@ImporteTotal", "@TipoComprobantePago", "@SerieComprobantePago", "@AñoDua", "@NumeroComprobantePago",
                "@MontoRetencion", "@CodigoMoneda", "@TipoCambio", "@PaisSujeto", "@RazonSocialSujeto", "@DomicilioSujeto", "@DocumentoSujeto", "@DocumentoBeneficiario",
                "@RazonSocialBeneficiario", "@PaisBeneficiario", "@Vinculo", "@RentaBruta", "@Deducciones", "@RentaNeta", "@TasaRetencion", "@ImpuestoRetenido", "@Convenios",
                "@Exoneracion", "@TipoRenta", "@Modalidad", "@Aplicación", "@Estado" };
            object[] valores = { @opcion, @pkEmpresa, @Periodo, @NumeroCorrelativo, @Secuencia, @FechaEmision, @TipoComprobante, @SerieComprobante, @NumeroComprobante, @ValorAdquisiciones,
                @OtrosComprobantes, @ImporteTotal, @TipoComprobantePago, @SerieComprobantePago, @AñoDua, @NumeroComprobantePago, @MontoRetencion, @CodigoMoneda, @TipoCambio, @PaisSujeto,
                @RazonSocialSujeto, @DomicilioSujeto, @DocumentoSujeto, @DocumentoBeneficiario, @RazonSocialBeneficiario, @PaisBeneficiario, @Vinculo, @RentaBruta, @Deducciones,
                @RentaNeta, @TasaRetencion, @ImpuestoRetenido, @Convenios, @Exoneracion, @TipoRenta, @Modalidad, @Aplicación, @Estado };
            return bd.DataTableFromProcedure("[usp_Formato82]", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_2(int @pkEmpresa, DateTime Periodo, int TipoComprobantePago, string SerieComprobantePago, int AñoDua, string NumeroComprobantePago, string DocumentoBeneficiario, string RazonSocialBeneficiario)
        {
            string[] parametros = { "@opcion", "@pkEmpresa", "@Periodo", "@TipoComprobantePago", "@SerieComprobantePago", "@AñoDua", "@NumeroComprobantePago", "@DocumentoBeneficiario",
                "@RazonSocialBeneficiario" };
            object[] valores = { 0, @pkEmpresa, @Periodo, @TipoComprobantePago, @SerieComprobantePago, @AñoDua, @NumeroComprobantePago, @DocumentoBeneficiario, @RazonSocialBeneficiario };
            return bd.DataTableFromProcedure("[usp_Formato82]", parametros, valores, null);
        }
        public DataTable ConsultaCuoFormato82(int @pkEmpresa, string cuo)
        {
            string[] parametros = { "@pkEmpresa", "@cuo" };
            object[] valores = { @pkEmpresa, cuo };
            return bd.DataTableFromProcedure("[usp_ConsutarCuoFormato82]", parametros, valores, null);
        }
        public DataTable FormatodeCompras8_3_Masivo(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@PeriodoInicio", "@PeriodoFin" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("usp_FormatodeCompras8_3_Masivo", parametros, valores, null);
        }
        public DataTable FormatodeVentas14_1(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@PeriodoInicio", "@PeriodoFin" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("[usp_FormatodeVentas14_1_Masivo]", parametros, valores, null);
        }
        public DataTable FormatodeVentas14_2(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@PeriodoInicio", "@PeriodoFin" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("[usp_FormatodeVentas14_2_Masivo]", parametros, valores, null);
        }
        public DataTable GenerarFlujodeCajaGastos(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("usp_GenerarFlujodeCajaGastos", parametros, valores, null);
        }
        public DataTable GenerarFlujodeCajaRegistro(string empresa, DateTime PeriodoInicio, DateTime PeriodoFin)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, PeriodoInicio, PeriodoFin };
            return bd.DataTableFromProcedure("usp_GenerarFlujodeCajaRegistro", parametros, valores, null);
        }
        public DataTable FormatoCajaBanco1_1(string empresa, DateTime FechaInicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, FechaInicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoCajaBanco1_1", parametros, valores, null);
        }
        public DataTable FormatoCajaBancos1_1Auditoria(string empresa, DateTime FechaInicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, FechaInicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoCajaBancos1_1Auditoria", parametros, valores, null);
        }
        public DataTable FormatoCajaBanco1_2Auditoria(string empresa, DateTime FechaInicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, FechaInicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoCajaBanco1_2Auditoria", parametros, valores, null);
        }
        public DataTable FormatoCajaBanco1_1Masivo(string empresa, DateTime FechaInicial, DateTime FechaFinal, string cuentas)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal", "@cuentas" };
            object[] valores = { empresa, FechaInicial, FechaFinal, cuentas };
            return bd.DataTableFromProcedure("usp_FormatoCajaBanco1_1_Masivo", parametros, valores, null);
        }
        public DataTable FormatoCajaBanco1_2(string empresa, DateTime FechaInicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { empresa, FechaInicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoCajaBanco1_2", parametros, valores, null);
        }
        public DataTable FormatoCajaBanco1_2Masivo(string empresa, DateTime FechaInicial, DateTime FechaFinal, string cuentas)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal", "@Cuentas" };
            object[] valores = { empresa, FechaInicial, FechaFinal, cuentas };
            return bd.DataTableFromProcedure("usp_FormatoCajaBanco1_2_Masivo", parametros, valores, null);
        }
        public DataTable FormatodeVentas14_1(int empresa, int periodo, int anio)
        {
            string[] parametros = { "@Empresa", "@PeriodoMes", "@periodoAño" };
            object[] valores = { empresa, periodo, anio };
            return bd.DataTableFromProcedure("usp_FormatodeVentas14_1", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_2(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_2", parametros, valores, null);
        }
        public DataTable ReporteDocumentosRegistradoSinPago(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_ReporteDocumentosRegistradoSinPago", parametros, valores, null);
        }
        public DataTable ReporteDocumentosPagadosEXcluidosRegistrados(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_ReporteDocumentosPagadosEXcluidosRegistrados", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_3(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_3", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_4(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_4", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_5(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_5", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_6(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_6", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_11(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_11", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_12(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_12", parametros, valores, null);
        }
        public DataTable FormatoLibroInventario3_13(string Empresa, DateTime Fechainicial, DateTime FechaFinal)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal" };
            object[] valores = { Empresa, Fechainicial, FechaFinal };
            return bd.DataTableFromProcedure("usp_FormatoLibroInventario3_13", parametros, valores, null);
        }
        public DataTable MayorCuentasxEmpresas(int empresa, int periodo, int anio)
        {
            string[] parametros = { "@Empresa", "@PeriodoMes", "@periodoAño" };
            object[] valores = { empresa, periodo, anio };
            return bd.DataTableFromProcedure("usp_MayorCuentasxEmpresas", parametros, valores, null);
        }
        public DataTable MayorPorCuentas(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial", "@CierreApertura" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon, 1 };
            return bd.DataTableFromProcedure("usp_MayorPorCuentasNormal", parametros, valores, null);
        }
        public DataTable CuentaContableValidarActivas(String CUENTA)
        {
            string[] parametros = { "@CUENTA" };
            object[] valores = { CUENTA };
            return bd.DataTableFromProcedure("usp_CuentaContableValidarActivas", parametros, valores, null);
        }
        public DataTable MayorPorCuentasConAperturaCierre(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial", "@CierreApertura" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon, 1 };
            return bd.DataTableFromProcedure("[usp_MayorPorCuentasConAperturaCierre]", parametros, valores, null);
        }
        public DataTable MayorPorCuentasPerfil(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon };
            return bd.DataTableFromProcedure("usp_MayorPorCuentasPerfil", parametros, valores, null);
        }
        public DataTable LibroDiario5_1(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon };
            return bd.DataTableFromProcedure("usp_LibroDiario5_1", parametros, valores, null);
        }
        public DataTable ReporteAnalitico(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon };
            return bd.DataTableFromProcedure("usp_ReporteAnalitico", parametros, valores, null);
        }
        public DataTable BalanceComprobacion(int @Empresa, int @len, DateTime @periodo)
        {
            string[] parametros = { "@empresa", "@len", "@periodo" };
            object[] valores = { Empresa, len, periodo };
            return bd.DataTableFromProcedure("usp_BalanceComprobacion", parametros, valores, null);
        }
        public DataTable ReporteAnalitico2(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@cuentas", "@Glosas", "@NroDoc", "@Ruc", "@Empresa", "@RazonSocial" };
            object[] valores = { fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon };
            return bd.DataTableFromProcedure("usp_ReporteAnalitico2", parametros, valores, null);
        }
        public DataTable CierreMensualSaldos(int empresa, DateTime fechaini, DateTime fechafin, decimal tccomprasbs, decimal tcventasbs)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal", "@TCCompraSBS", "@TCVentaSBS" };
            object[] valores = { empresa, fechaini, fechafin, tccomprasbs, tcventasbs };
            return bd.DataTableFromProcedure("usp_CierreMensualSaldos", parametros, valores, null);
        }
        public DataTable CantidadLlamadas(DateTime Fecha)
        {
            string[] parametros = { "@Fecha" };
            object[] valores = { Fecha };
            return bd.DataTableFromProcedure("usp_CantidadLlamadas", parametros, valores, null);
        }
        public DataTable CierreMensualDocumentos(int empresa, DateTime fechaini, DateTime fechafin, decimal tccomprasbs, decimal tcventasbs, Boolean Generar)
        {
            string[] parametros = { "@Empresa", "@FechaInicial", "@FechaFinal", "@TCCompraSBS", "@TCVentaSBS", "@Generar" };
            object[] valores = { empresa, fechaini, fechafin, tccomprasbs, tcventasbs, Generar };
            return bd.DataTableFromProcedure("usp_CierreMensualDocumentos", parametros, valores, null);
        }
        public DataTable CierreMensualDinamicaYaExiste(int dinamica, DateTime FechaPeriodo, int empresa)
        {
            string[] parametros = { "@dinamica", "@Periodo", "@empresa" };
            object[] valores = { dinamica, FechaPeriodo, empresa };
            return bd.DataTableFromProcedure("usp_CierreMensualDinamicaYaExiste", parametros, valores, null);
        }
        public DataTable CierreAnualDinamicaYaExiste(int dinamica, DateTime FechaPeriodo, int empresa)
        {
            string[] parametros = { "@dinamica", "@Periodo", "@empresa" };
            object[] valores = { dinamica, FechaPeriodo, empresa };
            return bd.DataTableFromProcedure("usp_CierreAnualDinamicaYaExiste", parametros, valores, null);
        }
        public DataTable AsientoApertura_CierrePeriodo(int empresa, int len, DateTime Fecha)
        {
            string[] parametros = { "@empresa", "@len", "@periodo" };
            object[] valores = { empresa, 7, Fecha };
            return bd.DataTableFromProcedure("usp_AsientoApertura_CierrePeriodo", parametros, valores, null);
        }
        public DataTable ResultadoCierre(int empresa, DateTime Fecha)
        {
            string[] parametros = { "@empresa", "@fecha" };
            object[] valores = { empresa, Fecha };
            return bd.DataTableFromProcedure("usp_ResultadoCierre", parametros, valores, null);
        }
        public DataTable ResultadoCierreBalance(int empresa, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@empresa" };
            object[] valores = { fechaini, fechafin, empresa };
            return bd.DataTableFromProcedure("usp_ResultadoCierreCuentaBalance", parametros, valores, null);
        }
        public DataTable DiferenciadeCambioMensual(int @opcion, int @empresa, DateTime @periodo, int @tipo, string @CuentaContable, int @idcomprobante, string @numdoc, int @tipoidpro, string @proveedor, string @nombreproveedor, decimal @montodolares, decimal @montosoles, decimal @finmesoles, decimal @difcambio, decimal @tccompra, decimal @tcventa, string @naturaleza
            , int @CtaBancaria)
        {
            string[] parametros = { "@opcion", "@empresa", "@periodo", "@tipo", "@CuentaContable", "@idcomprobante", "@numdoc", "@tipoidpro", "@proveedor",
                "@nombreproveedor", "@montodolares", "@montosoles", "@finmesoles", "@difcambio", "@tccompra", "@tcventa", "@naturaleza","@CtaBancaria" };
            object[] valores = { @opcion, @empresa, @periodo, @tipo, @CuentaContable, @idcomprobante, @numdoc, @tipoidpro, @proveedor, @nombreproveedor,
                @montodolares, @montosoles, @finmesoles, @difcambio, @tccompra, @tcventa, @naturaleza ,CtaBancaria};
            return bd.DataTableFromProcedure("usp_DiferenciadeCambioMensual", parametros, valores, null);
        }
        public DataTable AperturaEjercicio(int @opcion, string ruc, int @empresa, DateTime @periodo, string @CuentaContable, string descripcion, decimal pen, decimal usd)
        {
            string[] parametros = { "@opcion", "@ruc", "@empresa", "@periodo", "@CuentaContable", "@descripcion", "@pen", "@usd" };
            object[] valores = { @opcion, ruc, @empresa, @periodo, @CuentaContable, descripcion, pen, usd };
            return bd.DataTableFromProcedure("[usp_AperturaEjercicio]", parametros, valores, null);
        }
        public DataTable AperturaEjercicioBalance(int @opcion, int @pkEmpresa, string @Cod_Asiento_Contable, DateTime @FechaContable, DateTime @FechaRegistro,
            DateTime? @FechaEmision, int @Id_Comprobante, string @Cod_Comprobante, string @Num_Comprobante, string @Num_Doc, string @Razon_Social,
            string @Glosa, string @Cuenta_Contable, string @descripcion, int @CtaBancaria, string @CuentaBanco, string @moneda, decimal @pen, decimal @usd, decimal @tipocambio)
        {
            string[] parametros = { "@opcion", "@pkEmpresa", "@Cod_Asiento_Contable", "@FechaContable", "@FechaRegistro", "@FechaEmision",
                "@Id_Comprobante", "@Cod_Comprobante", "@Num_Comprobante", "@Num_Doc", "@Razon_Social", "@Glosa", "@Cuenta_Contable",
                "@descripcion","@CtaBancaria", "@CuentaBanco", "@moneda", "@pen", "@usd", "@tipocambio" };
            object[] valores = { @opcion, @pkEmpresa, @Cod_Asiento_Contable, @FechaContable, @FechaRegistro, @FechaEmision, @Id_Comprobante,
                @Cod_Comprobante, @Num_Comprobante, @Num_Doc, @Razon_Social, @Glosa, @Cuenta_Contable, @descripcion,@CtaBancaria, @CuentaBanco, @moneda,
                @pen, @usd, @tipocambio };
            return bd.DataTableFromProcedure("[usp_AperturaEjercicioBalance]", parametros, valores, null);
        }
        public DataTable ReporteSaldosContables(int empresa, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@FechaInicial", "@Fecha" };
            object[] valores = { empresa, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_ReporteSaldosContables", parametros, valores, null);
        }
        public DataTable ReporteSaldosContables2(int empresa, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@empresa", "@FechaInicial", "@Fecha" };
            object[] valores = { empresa, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_ReporteSaldosContables2", parametros, valores, null);
        }
        public DataTable ReporteFacturasComprasIncompletas(DateTime fechaini, DateTime fechafin, int Fecha)
        {
            string[] parametros = { "@Fechaini", "@FechaFin", "@Fecha" };
            object[] valores = { fechaini, fechafin, Fecha };
            return bd.DataTableFromProcedure("usp_ReporteFacturasComprasIncompletas", parametros, valores, null);
        }
        public DataTable VerificarCuadredeAsiento(string cuo, int proyecto)
        {
            string[] parametros = { "@cuo", "@proyecto" };
            object[] valores = { cuo, proyecto };
            return bd.DataTableFromProcedure("usp_VerificarCuardredeAsiento", parametros, valores, null);
        }
        public DataTable CuadrarAsiento(string cuo, int proyecto, DateTime FechaAsiento, int tipo)
        {
            string[] parametros = { "@cuo", "@proyecto", "@fechaAsiento", "@tipo" };
            object[] valores = { cuo, proyecto, FechaAsiento, tipo };
            return bd.DataTableFromProcedure("usp_CuadraAsiento", parametros, valores, null);
        }
        public DataTable LimpiezaDetalleAsientos(string cuo, int proyecto)
        {
            string[] parametros = { "@cuo", "@proyecto" };
            object[] valores = { cuo, proyecto };
            return bd.DataTableFromProcedure("usp_LimpiezaDetalleAsientos", parametros, valores, null);
        }
        public DataTable ListarFacturasCompensaciones(string idempleado, int empresa)
        {
            string[] parametros = { "@idEmpleado", "@empresa" };
            object[] valores = { idempleado, empresa };
            return bd.DataTableFromProcedure("usp_ListarFacturasCompensaciones", parametros, valores, null);
        }
        public DataTable ListarFacturasCompensaciones(string idempleado, int empresa, int tipo, int idmoneda)
        {
            string[] parametros = { "@idEmpleado", "@empresa", "@tipo", "@idmoneda" };
            object[] valores = { idempleado, empresa, tipo, idmoneda };
            return bd.DataTableFromProcedure("usp_ListarFacturasCompensacionesxTipo", parametros, valores, null);
        }
        public DataTable ListarFacturasAnticipos(string ruc, int empresa)
        {
            string[] parametros = { "@ruc", "@empresa" };
            object[] valores = { ruc, empresa };
            return bd.DataTableFromProcedure("usp_ListarFacturasAnticipos", parametros, valores, null);
        }
        public DataTable ListarEmpleadosCompensaciones(int empresa, int tipo)
        {
            string[] parametros = { "@empresa", "@tipo" };
            object[] valores = { empresa, tipo };
            return bd.DataTableFromProcedure("usp_ListarEmpleadosCompensaciones", parametros, valores, null);
        }
        public DataTable ListarEmpleadosCompensacionesTodos()
        {
            return bd.DataTableFromProcedure("usp_ListarEmpleadosCompensacionesTodos", null, null, null);
        }
        public DataTable ActualizaEstadoFacturas(int id, int idcomprobante, int estado, DateTime Fechacompensa, int @tipopago, string @nropago)
        {
            string[] parametros = { "@id", "@idcomprobante", "@estado", "@fechaCompensa", "@tipopago", "@nropago" };
            object[] valores = { id, @idcomprobante, estado, Fechacompensa, tipopago, nropago };
            return bd.DataTableFromProcedure("usp_ActualizaEstadoFacturas", parametros, valores, null);
        }
        public DataTable ReembolsoGastos_Detalle(int @opcion, int @pkid, int @empresa, int @idcomprobante, int @tipoid, string @proveedor, string @razon, string @nrocomprobante, DateTime @fechaemision, string @usuariocompensa, int @idmoneda, decimal @tcreg, decimal @montomn, decimal @montome, string @cuo, string @cuopago, int @tipopago, string @cuentabanco, string @nrooperacion, string @numpago, DateTime @fechapago, string @cuentacontable, string @glosapagos, string @glosafacturas, int @estado, int @idusuario)
        {
            string[] parametros = { "@opcion", "@pkid", "@empresa", "@idcomprobante", "@tipoid", "@proveedor", "@razon", "@nrocomprobante", "@fechaemision", "@usuariocompensa", "@idmoneda", "@tcreg", "@montomn", "@montome", "@cuo", "@cuopago", "@tipopago", "@cuentabanco", "@nrooperacion", "@numpago", "@fechapago", "@cuentacontable", "@glosapagos", "@glosafacturas", "@estado", "@idusuario" };
            object[] valores = { @opcion, @pkid, @empresa, @idcomprobante, @tipoid, @proveedor, @razon, @nrocomprobante, @fechaemision, @usuariocompensa, @idmoneda, @tcreg, @montomn, @montome, @cuo, @cuopago, @tipopago, @cuentabanco, @nrooperacion, @numpago, @fechapago, @cuentacontable, @glosapagos, @glosafacturas, @estado, @idusuario };
            return bd.DataTableFromProcedure("usp_ReembolsoGastos_Detalle", parametros, valores, null);
        }
        public DataTable FondoFijo_Detalle(int @opcion, int @pkid, int @empresa, int @idcomprobante, int @tipoid, string @proveedor, string @razon, string @nrocomprobante, DateTime @fechaemision,
            string @usuariocompensa, int @idmoneda, decimal @tcreg, decimal @montomn, decimal @montome, string @cuo, string @cuopago, int @tipopago, string @cuentabanco, string @nrooperacion, string @numpago,
            DateTime @fechapago, DateTime @fechacreacionfondo, string @cuentacontable, string @glosapagos, string @glosafacturas, int @estado, int @idusuario)
        {
            string[] parametros = { "@opcion", "@pkid", "@empresa", "@idcomprobante", "@tipoid", "@proveedor", "@razon", "@nrocomprobante", "@fechaemision", "@usuariocompensa", "@idmoneda", "@tcreg", "@montomn",
                "@montome", "@cuo", "@cuopago", "@tipopago", "@cuentabanco", "@nrooperacion", "@numpago", "@fechapago", "@fechacreacionfondo","@cuentacontable", "@glosapagos", "@glosafacturas", "@estado",
                "@idusuario" };
            object[] valores = { @opcion, @pkid, @empresa, @idcomprobante, @tipoid, @proveedor, @razon, @nrocomprobante, @fechaemision, @usuariocompensa, @idmoneda, @tcreg, @montomn, @montome, @cuo, @cuopago,
                @tipopago, @cuentabanco, @nrooperacion, @numpago, @fechapago,@fechacreacionfondo, @cuentacontable, @glosapagos, @glosafacturas, @estado, @idusuario };
            return bd.DataTableFromProcedure("[usp_FondoFijo_Detalle]", parametros, valores, null);
        }
        public DataTable EntregasRendir_Detalle(int @opcion, int @pkid, int @empresa, int @idcomprobante, int @tipoid, string @proveedor, string @razon, string @nrocomprobante, DateTime @fechaemision, string @usuariocompensa, int @idmoneda, decimal @tcreg, decimal @montomn, decimal @montome, string @cuo, string @cuopago, int @tipopago, string @cuentabanco, string @nrooperacion, string @numpago, DateTime @fechapago, string @cuentacontable, string @glosapagos, string @glosafacturas, int @estado, int @idusuario)
        {
            string[] parametros = { "@opcion", "@pkid", "@empresa", "@idcomprobante", "@tipoid", "@proveedor", "@razon", "@nrocomprobante", "@fechaemision", "@usuariocompensa", "@idmoneda", "@tcreg", "@montomn", "@montome", "@cuo", "@cuopago", "@tipopago", "@cuentabanco", "@nrooperacion", "@numpago", "@fechapago", "@cuentacontable", "@glosapagos", "@glosafacturas", "@estado", "@idusuario" };
            object[] valores = { @opcion, @pkid, @empresa, @idcomprobante, @tipoid, @proveedor, @razon, @nrocomprobante, @fechaemision, @usuariocompensa, @idmoneda, @tcreg, @montomn, @montome, @cuo, @cuopago, @tipopago, @cuentabanco, @nrooperacion, @numpago, @fechapago, @cuentacontable, @glosapagos, @glosafacturas, @estado, @idusuario };
            return bd.DataTableFromProcedure("usp_EntregasRendir_Detalle", parametros, valores, null);
        }
        public DataTable ListarCompensaciones(int empresa, int tipo, int Tipoid, string numdoc, int Estado)
        {
            string[] parametros = { "@empresa", "@tipo", "@tipoid", "@numdoc", "@Estado" };
            object[] valores = { empresa, tipo, Tipoid, numdoc, Estado };
            return bd.DataTableFromProcedure("usp_ListarCompensaciones", parametros, valores, null);
        }
        public DataTable ListarCompensacionesxPagar(int empresa, int tipo, int Tipoid, string numdoc, int Estado)
        {
            string[] parametros = { "@empresa", "@tipo", "@tipoid", "@numdoc", "@Estado" };
            object[] valores = { empresa, tipo, Tipoid, numdoc, Estado };
            return bd.DataTableFromProcedure("usp_ListarCompensacionesxPagar", parametros, valores, null);
        }
        public DataTable InsertarCompensaciones(int @empresa, int @tipo, int @tipoid, string @numdoc, decimal @montomn, decimal @montome, string @cuo, int tipopago, string cuentabanco, string nrooperacion, string @numpago, DateTime @fechacompensa, int @estado, string cuentacontable, string cuopago)
        {
            string[] parametros = { "@empresa", "@tipo", "@tipoid", "@numdoc", "@montomn", "@montome", "@cuo", "@tipopago", "@CuentaBanco", "@NroOperacion", "@numpago", "@fechacompensa", "@estado", "@cuentacontabla", "@cuoPago" };
            object[] valores = { @empresa, @tipo, @tipoid, @numdoc, @montomn, @montome, @cuo, tipopago, cuentabanco, nrooperacion, @numpago, @fechacompensa, @estado, cuentacontable, cuopago };
            return bd.DataTableFromProcedure("usp_InsertarCompensaciones", parametros, valores, null);
        }
        public DataTable CompensacionesActualizar(int pkid, int @empresa, int @tipo, int @tipoid, string @numdoc, decimal @montomn, decimal @montome, string @cuo, int tipopago, string cuentabanco, string nrooperacion, string @numpago, DateTime @fechacompensa, int @estado, string cuentacontable, string cuopago)
        {
            string[] parametros = { "@pkid", "@empresa", "@tipo", "@tipoid", "@numdoc", "@montomn", "@montome", "@cuo", "@tipopago", "@CuentaBanco", "@NroOperacion", "@numpago", "@fechacompensa", "@estado", "@cuentacontabla", "@cuoPago" };
            object[] valores = { pkid, @empresa, @tipo, @tipoid, @numdoc, @montomn, @montome, @cuo, tipopago, cuentabanco, nrooperacion, @numpago, @fechacompensa, @estado, cuentacontable, cuopago };
            return bd.DataTableFromProcedure("usp_Compensaciones_Actualizar", parametros, valores, null);
        }
        public DataTable InsertarCompensacionesDetalle(int pkid, int @empresa, int @tipo, decimal @montomn, decimal @montome, int tipopago, string cuentabanco, string nrooperacion, string @numpago, DateTime @fechacompensa, int @estado, string cuopago)
        {
            string[] parametros = { "@PkId", "@empresa", "@tipo", "@montomn", "@montome", "@tipopago", "@CuentaBanco", "@NroOperacion", "@numpago", "@fechacompensa", "@estado", "@cuoPago" };
            object[] valores = { pkid, @empresa, @tipo, @montomn, @montome, tipopago, cuentabanco, nrooperacion, @numpago, @fechacompensa, @estado, cuopago };
            return bd.DataTableFromProcedure("usp_InsertarCompensaciones_Det", parametros, valores, null);
        }
        public DataTable ActualizarCompensaciones(int @empresa, int @tipo, int id, int @estado, int tipopago, string cuentabanco, string nrooperacion, string cuopago)
        {
            string[] parametros = { "@empresa", "@tipo", "@id", "@estado", "@tipopago", "@CuentaBanco", "@NroOperacion", "@cuoPago" };
            object[] valores = { @empresa, @tipo, id, @estado, tipopago, cuentabanco, nrooperacion, cuopago };
            return bd.DataTableFromProcedure("usp_ActualizarCompensaciones", parametros, valores, null);
        }
        public DataTable ListarProveedoresCompensaciones(int empresa)
        {
            string[] parametros = { "@empresa" };
            object[] valores = { @empresa };
            return bd.DataTableFromProcedure("usp_ListarProveedoresCompensaciones", parametros, valores, null);
        }
        public DataTable PlanContable()
        {
            return bd.DataTableFromProcedure("usp_PlanContable", null, null, null);
        }
        public DataTable PlanContable2Col()
        {
            return bd.DataTableFromProcedure("usp_PlanContable2Columnas", null, null, null);
        }
        public DataTable FondoFijoVeriricarExistencia(int empresa, int tipo, string numdoc, string cuenta, int pkid)
        {
            string[] parametros = { "@empresa", "@tipo", "@nundoc", "@cuenta", "@pkid" };
            object[] valores = { @empresa, tipo, numdoc, cuenta, pkid };
            return bd.DataTableFromProcedure("usp_FondoFijoVeriricarExistencia", parametros, valores, null);
        }
        public DataTable SiguienteIDCompensaciones(int empresa, int tipo)
        {
            string[] parametros = { "@empresa", "@tipo" };
            object[] valores = { @empresa, tipo };
            return bd.DataTableFromProcedure("usp_SiguienteIDCompensaciones", parametros, valores, null);
        }
        public DataTable FondoFijoCuentasEmpleado(int empresa, int tipo, int tipoid, string numdoc, string moneda)
        {
            string[] parametros = { "@empresa", "@tipo", "@tipoid", "@nundoc", "@moneda" };
            object[] valores = { @empresa, tipo, tipoid, numdoc, moneda };
            return bd.DataTableFromProcedure("usp_FondoFijoCuentasEmpleado", parametros, valores, null);
        }
        public DataTable PrestamosInterEmpresa(int @opcion, int @empresaori, int @proyectoori, int @etapaori, int @bancoori, int @ctaori, string @cuoori, string @ctaContableori, int @empresades, int @proyectodes
            , int @etapades, int @bancodes, int @ctades, string @cuodes, string @ctacontabledes, int @idmoneda, decimal @montoprestado, DateTime @fechacontable, DateTime @fechaprestado, decimal @tc, string @glosa,
            int @estado, int @tipopago, string nrooperacion)
        {
            string[] parametros = { "@opcion", "@empresaori", "@proyectoori", "@etapaori", "@bancoori", "@ctaori", "@cuoori", "@ctaContableori", "@empresades", "@proyectodes", "@etapades", "@bancodes", "@ctades",
                    "@cuodes", "@ctacontabledes", "@idmoneda", "@montoprestado", "@fechacontable", "@fechaprestado", "@tc", "@glosa", "@estado","@tipopago","@nrooperacion" };
            object[] valores = { @opcion, @empresaori, @proyectoori, @etapaori, @bancoori, @ctaori, @cuoori, @ctaContableori, @empresades, @proyectodes, @etapades, @bancodes, @ctades,@cuodes, @ctacontabledes,
                @idmoneda, @montoprestado, @fechacontable, @fechaprestado, @tc, @glosa, @estado,tipopago,nrooperacion };
            return bd.DataTableFromProcedure("usp_PrestamosInterbancarios", parametros, valores, null);
        }
        public DataTable PrestamosInterEmpresaDetalle(int @opcion, int @fkid, int @fkEmpresaOri, int @fkProyectoOri, int @fkEtapaOri, int @fkBancoOri, int @fkCtaBancoOri, int @fkEmpresaDes, int @fkProyectoDes,
            int @fkEtapaDes, int @fkBancoDes, int @fkCtaBancoDes, string @CuoAbonoOri, string @CuoAbonoDes, DateTime @FechaContable, DateTime @FechaAbono, int @FkMoneda, decimal @Monto, decimal @TC,
            int @TipoPago, string @NroOperacion, DateTime @FechaModifica, int @Usuario, int @Estado, string glosa)
        {
            string[] parametros = { "@opcion", "@fkid", "@fkEmpresaOri", "@fkProyectoOri", "@fkEtapaOri", "@BancoOri", "@fkCtaBancoOri", "@fkEmpresaDes", "@fkProyectoDes", "@fkEtapaDes", "@BancoDes",
                "@fkCtaBancoDes", "@CuoAbonoOri", "@CuoAbonoDes", "@FechaContable", "@FechaAbono", "@FkMoneda", "@Monto", "@TC", "@TipoPago", "@NroOperacion", "@FechaModifica","@glosa", "@Usuario", "@Estado" };
            object[] valores = { @opcion, @fkid, @fkEmpresaOri, @fkProyectoOri, @fkEtapaOri, @fkBancoOri, @fkCtaBancoOri, @fkEmpresaDes, @fkProyectoDes, @fkEtapaDes, @fkBancoDes, @fkCtaBancoDes,
                @CuoAbonoOri, @CuoAbonoDes, @FechaContable, @FechaAbono, @FkMoneda, @Monto, @TC, @TipoPago, @NroOperacion, @FechaModifica,glosa, @Usuario, @Estado };
            return bd.DataTableFromProcedure("usp_PrestamosInterbancarios_Detalle", parametros, valores, null);
        }
        public DataTable PrestamoInterEmpresa_Filtrar(int empresa, int fkid)
        {
            string[] parametros = { "@empresa", "@fkid" };
            object[] valores = { @empresa, fkid };
            return bd.DataTableFromProcedure("usp_PrestamoInterEmpresa_Filtrar", parametros, valores, null);
        }
        public DataTable PrestamoInterEmpresa_Listado(string empresaorigen, string empresadestino, string moneda, DateTime fecha1, DateTime fecha2)
        {
            string[] parametros = { "@empresaorigen", "@empresadestino", "@moneda", "fecha1", "@fecha2" };
            object[] valores = { empresaorigen, empresadestino, moneda, fecha1, fecha2 };
            return bd.DataTableFromProcedure("usp_PrestamoInterEmpresa_Listado", parametros, valores, null);
        }
    }
}