﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;

namespace HPResergerCapaDatos
{
    public class HPResergerCD
    {
        abcBaseDatos.Database bd;
        public string DATASOURCE = "192.168.0.102";
        public string BASEDEDATOS = " HpReserger";
        public string USERID = "mmendoza";
        public string USERPASS = "123";
        public HPResergerCD()
        {
            bd = new abcBaseDatos.Database("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + "");
        }

        public DataTable ListarContratoEmpleado(int tipo, string numero)
        {
            string[] parametros = { "@tipo", "@numero" };
            object[] valores = { tipo, numero };
            return bd.DataTableFromProcedure("usp_get_Empleado_Contrato", parametros, valores, null);
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
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


        public void InsertarActualizarUsuario(int tipoid, string nroid, string login, string contra, int perfil, int estado, int opcion, out int respuesta)
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
                    cmd.Parameters.Add("@tipoid", SqlDbType.Int).Value = tipoid;
                    cmd.Parameters.Add("@nroid", SqlDbType.VarChar, 14).Value = nroid;
                    cmd.Parameters.Add("@login", SqlDbType.VarChar, 10).Value = login;
                    cmd.Parameters.Add("@contra", SqlDbType.VarChar, 10).Value = contra;
                    cmd.Parameters.Add("@perfil", SqlDbType.Int).Value = perfil;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;

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
                    cmd.Parameters.Add("@gerencia", SqlDbType.VarChar, 20).Value = gerencia;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }

        }
        public void InsertarCentroCosto(string valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_centro_ccosto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = valor;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarCentroCosto(string valor, int codigo)
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
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

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
        public void InsertarArticulo(string descripcion, int stock, int tipo, string observa)
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
        public void ActualizarArticuloMarca(int art, string desc, int stock, int tipo, string observa, int marca, int marcamod)
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
        public void InsertarDepartamento(int valor)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_departamento";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@coddep", SqlDbType.Int).Value = valor;

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

        public void InsertarDinamica(int codigo, int ejercicio, int codope, int codsub, int cuenta, string debe, int estado)
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
                    cmd.Parameters.Add("@cuenta", SqlDbType.Int).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.VarChar, 150).Value = debe;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ModificarDinamica(int codigo, int ejercicio, int codope, int codsub, int cuenta, string debe, int estado)
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
                    cmd.Parameters.Add("@cuenta", SqlDbType.Int).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.VarChar, 150).Value = debe;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

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

        public DataTable ListarAsientosContables(string busca, int opcion, DateTime fechaini, DateTime fechafin)
        {
            string[] parametros = { "@buscar", "@opcion", "@fechaini", "@fechafin" };
            object[] valor = { busca, opcion, fechaini, fechafin };
            return bd.DataTableFromProcedure("usp_listar_asientos", parametros, valor, null);
        }
        public DataTable UltimoAsiento()
        {
            return bd.DataTableFromProcedure("usp_ultimo_asiento", null, null, null);
        }
        public DataTable BuscarAsientosContables(string busca, int opcion)
        {
            string[] parametros = { "@buscar", "@opcion" };
            object[] valor = { busca, opcion };
            return bd.DataTableFromProcedure("usp_buscar_asientos", parametros, valor, null);
        }

        public void InsertarAsiento(int codigo, DateTime fecha, int cuenta, double debe, double haber, int dina, int estado)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_asiento_contable";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                    cmd.Parameters.Add("@cuenta", SqlDbType.Int).Value = cuenta;
                    cmd.Parameters.Add("@debe", SqlDbType.Decimal).Value = debe;
                    cmd.Parameters.Add("@haber", SqlDbType.Decimal).Value = haber;
                    cmd.Parameters.Add("@dina", SqlDbType.Int).Value = dina;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void Modificar2asiento(int codigo)
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
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void EliminarASiento(int codigo)
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
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public DataTable BuscarCuenta(string buscar, int opcion)
        {
            string[] parametros = { "@buscar", "@opcion" };
            object[] valores = { buscar, opcion };
            return bd.DataTableFromProcedure("usp_buscar_cuenta", parametros, valores, null);
        }
        public DataTable VerificarProveedores(string codigo, string razon)
        {
            string[] parametros = { "@codigo", "@razon" };
            object[] valor = { codigo, razon };
            return bd.DataTableFromProcedure("usp_verificar_proveedor", parametros, valor, null);
        }
        public DataTable VerificarCuentas(int codigo, string nombre)
        {
            string[] parametros = { "@codigo", "@nombre" };
            object[] valor = { codigo, nombre };
            return bd.DataTableFromProcedure("usp_verificar_cuentas_contables", parametros, valor, null);
        }
        public void InsertarCuentasContables(string cuentan1, int codcuenta, string nombre, int tipo, string natu, int generica, int grupo,
        string refleja, string reflejacc, int reflejadebe, int reflejahaber, int cuentacierre, string analitica, int mensual, int cierre,
        int traslacion, string bc)
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
                    cmd.Parameters.Add("@codcuenta", SqlDbType.Int).Value = codcuenta;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = nombre;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@natu", SqlDbType.VarChar, 150).Value = natu;

                    cmd.Parameters.Add("@generica", SqlDbType.Int).Value = generica;
                    cmd.Parameters.Add("@grupo", SqlDbType.Int).Value = grupo;
                    cmd.Parameters.Add("@refleja", SqlDbType.VarChar, 150).Value = refleja;
                    cmd.Parameters.Add("@reflejacc", SqlDbType.VarChar, 150).Value = reflejacc;
                    cmd.Parameters.Add("@reflejadebe", SqlDbType.Int).Value = reflejadebe;

                    cmd.Parameters.Add("@reflejahaber", SqlDbType.Int).Value = reflejahaber;
                    cmd.Parameters.Add("@cuentacierre", SqlDbType.Int).Value = cuentacierre;
                    cmd.Parameters.Add("@analitica", SqlDbType.VarChar, 150).Value = analitica;
                    cmd.Parameters.Add("@mensual", SqlDbType.Int).Value = mensual;
                    cmd.Parameters.Add("@cierre", SqlDbType.Int).Value = cierre;

                    cmd.Parameters.Add("@traslacion", SqlDbType.Int).Value = traslacion;
                    cmd.Parameters.Add("@bc", SqlDbType.VarChar, 150).Value = bc;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarCuentasContables(int codcuenta, int generica, int grupo,
       string refleja, string reflejacc, int reflejadebe, int reflejahaber, int cuentacierre, string analitica, int mensual, int cierre,
       int traslacion, string bc)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_cuentas_contables";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@codcuenta", SqlDbType.Int).Value = codcuenta;
                    cmd.Parameters.Add("@generica", SqlDbType.Int).Value = generica;
                    cmd.Parameters.Add("@grupo", SqlDbType.Int).Value = grupo;
                    cmd.Parameters.Add("@refleja", SqlDbType.VarChar, 150).Value = refleja;
                    cmd.Parameters.Add("@reflejacc", SqlDbType.VarChar, 150).Value = reflejacc;

                    cmd.Parameters.Add("@reflejadebe", SqlDbType.Int).Value = reflejadebe;
                    cmd.Parameters.Add("@reflejahaber", SqlDbType.Int).Value = reflejahaber;
                    cmd.Parameters.Add("@cuentacierre", SqlDbType.Int).Value = cuentacierre;
                    cmd.Parameters.Add("@analitica", SqlDbType.VarChar, 150).Value = analitica;

                    cmd.Parameters.Add("@mensual", SqlDbType.Int).Value = mensual;
                    cmd.Parameters.Add("@cierre", SqlDbType.Int).Value = cierre;
                    cmd.Parameters.Add("@traslacion", SqlDbType.Int).Value = traslacion;
                    cmd.Parameters.Add("@bc", SqlDbType.VarChar, 150).Value = bc;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void InsertarProveedor(string ruc, string razon, string nombre, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
            string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int regi)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_insertar_proveedor";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 150).Value = ruc;
                    cmd.Parameters.Add("@razon", SqlDbType.VarChar, 150).Value = razon;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = nombre;
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
                    cmd.Parameters.Add("@regi", SqlDbType.Int).Value = regi;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void ActualizarProveedor(string ruc, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
           string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int regi)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "dbo.usp_actualizar_proveedor";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 150).Value = ruc;
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
                    cmd.Parameters.Add("@regi", SqlDbType.Int).Value = regi;
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        /// <returns></returns>


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

        public DataTable ModeloArticulo(int IdMarca)
        {
            string[] parametros = { "@IdMarca" };
            object[] valores = { IdMarca };
            return bd.DataTableFromProcedure("usp_get_MarcaModelo", parametros, valores, null);
        }

        public DataRow PerfilOrdenPedido(int IdUsuario)
        {
            string[] parametros = { "@Codigo_User" };
            object[] valores = { IdUsuario };
            return bd.DatarowFromProcedure("usp_get_Perfil_Orden_Pedido", parametros, valores, null);
        }

        public void OrdenPedidoCabeceraInsertar(out int Numero, int Usuario, int Tipo)
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

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void OrdenPedidoDetalleInsertar(int Numero, int Cantidad, int Articulo, int Marca, int Modelo, string Observaciones)
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

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarPedidos(int TipoArticulo, string Articulo, DateTime Desde, DateTime Hasta, int Usuario)
        {
            string[] parametros = { "@TipoArticulo", "@Articulo", "@Desde", "@Hasta", "Usuario" };
            object[] valores = { TipoArticulo, Articulo, Desde, Hasta, Usuario };
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

        public void CotizacionCabeceraInsertar(out int Numero, DateTime FechaEntrega, int Tipo, int Usuario, decimal Importe, int Pedido, string Proveedor, byte[] Foto, string NombreArchivo)
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

                    cmd.ExecuteNonQuery();
                    Numero = int.Parse(cmd.Parameters["@Numero"].Value.ToString().Trim());
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void CotizacionDetalleInsertar(int Cotizacion, int Pedido)
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
                    cmd.Parameters.Add("@NumeroPedido", SqlDbType.Int).Value = Pedido;

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

        public void FICDetalleInsertar(int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo, int Cantidad, string Observaciones, int Tipo)
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
            return bd.DataTableFromProcedure("dbo.usp_listar_oc_Faltantes", parametros, valores, null);
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
        public DataTable ListarFicsDetalle(string fic)
        {
            string[] parametros = { "@fic" };
            object[] valores = { fic };
            return bd.DataTableFromProcedure("usp_ListarFic_detalle", parametros, valores, null);
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

        public DataRow CargarImagenCotizacion(int Numero)
        {
            string[] parametros = { "@Numero" };
            object[] valores = { Numero };
            return bd.DatarowFromProcedure("usp_Get_Imagen_Cotizacion", parametros, valores, null);
        }
        public void InsertarFactura(string nrofactura,string proveedor,int fic,int oc,int tipo,decimal subtotal,decimal igv,decimal total, int gravaivg, DateTime fechaemision, DateTime fechaentregado,int estado, int moneda, byte[] imgfactura, int usuario)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_insertar_factura";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nrofactura", SqlDbType.VarChar,40).Value = nrofactura;
                    cmd.Parameters.Add("@proveedor", SqlDbType.Char, 40).Value = proveedor;
                    cmd.Parameters.Add("@fic", SqlDbType.Int).Value = fic;
                    cmd.Parameters.Add("@oc", SqlDbType.Int).Value = oc;
                    cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                    cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = subtotal;
                    cmd.Parameters.Add("@igv", SqlDbType.Decimal).Value = igv;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
                    cmd.Parameters.Add("@gravaigv", SqlDbType.Int).Value = gravaivg;
                    cmd.Parameters.Add("@fechaemision", SqlDbType.DateTime).Value = fechaemision;
                    cmd.Parameters.Add("@fechaentrega", SqlDbType.DateTime).Value = fechaentregado;
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                    cmd.Parameters.Add("@moneda", SqlDbType.Int).Value = moneda;                    
                    cmd.Parameters.Add("@imgfactura", SqlDbType.Image).Value = imgfactura;
                    cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;
                    
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }
        public void CotizacionModificar(int Numero, DateTime FechaEntrega, decimal Importe, string Proveedor, byte[] Foto, string NombreArchivo)
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

        public DataTable ListarOS(int Usuario)
        {
            string[] parametros = { "@Usuario" };
            object[] valores = { Usuario };
            return bd.DataTableFromProcedure("usp_get_Listar_NOS", parametros, valores, null);
        }

        public void SolicitudEmpleadoInsertar(int Numero, int Cargo, int TipoContratacion, string Busqueda, string AplicaTerna, int Area, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto, int Usuario)
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
                    cmd.Parameters.Add("@Busqueda", SqlDbType.Char, 7).Value = Busqueda;
                    cmd.Parameters.Add("@AplicaTerna", SqlDbType.Char, 2).Value = AplicaTerna;
                    cmd.Parameters.Add("@Area", SqlDbType.Int).Value = Area;
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

        public void PostulanteInsertar(int Tipo_ID_Postulante, string Nro_ID_Postulante, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, int ID_Puesto_Postulante, byte[] Foto, string NombreFoto, int OC, int SE, int Usuario)
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

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoRequerimiento(int Tipo_ID_Emp, string Nro_ID_Emp, string Correo, string Correo_Obs, string Celular, string Celular_Obs, string Pc, string Pc_Obs, string Otros, string Otros_Obs, int Usuario, int Opcion)
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

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoSeguroPension(int Tipo_ID_Emp, string Nro_ID_Emp, string Eps, int Eps_Adicional, string Sctr, string Onp, string Afp, int Afp_Empresa, string Nro_Cupss, int Usuario, int Opcion)
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

        public void EmpleadoInsertar(int Tipo_ID_Emp, string Nro_ID_Emp, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, int Usuario)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_Empleado_insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

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

        public DataTable ListarJefeInmediato(int tipo, string documento, int opcion)
        {
            string[] parametros = { "@tipo", "@documento", "@opcion" };
            object[] valores = { tipo, documento, opcion };
            return bd.DataTableFromProcedure("usp_get_JefeInmediato", parametros, valores, null);
        }

        public void EmpleadoContrato(int numero, int Tipo_ID_Emp, string Nro_ID_Emp, int jefe, int Tipo_Contrato, int Cargo, int Gerencia, int Area, int tipojefe, string Jefe_Inmediato, int Empresa, int Proyecto, int Sede, DateTime Fec_Inicio, int Periodo_Laboral, DateTime Fec_Fin, Decimal Sueldo, string Bono, Decimal Bono_Importe, int Bono_Periodicidad, byte[] Contrato_Img, string Contrato, byte[] AnxFunc_Img, string AnxFunc, byte[] SolPrac_Img, string SolPrac, byte[] Otros_Img, string Otros, int Usuario, int Opcion)
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

        public void EmpleadoFamilia(int Tipo_ID_Emp, string Nro_ID_Emp, int Vinculo_Familiar, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old, int Tipo_ID_Fam_New, string Nro_ID_Fam_New, string Apepat_Fam, string Apemat_Fam, string Nombres_Fam, DateTime Fec_Nacimiento_Fam, string Ocupacion, int Usuario, int Opcion)
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

        public void PostulanteModificar(int Tipo_ID_Postulante_Old, string Nro_ID_Postulante_Old, int Tipo_ID_Postulante_New, string Nro_ID_Postulante_New, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, byte[] Foto, string NombreFoto, int Id_SolicitaEmpleado)
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


                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable ListarEmpleado(int Opcion, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp)
        {
            string[] parametros = { "@Opcion", "@Apepat_Emp", "@Apemat_Emp", "@Nombres_Emp" };
            object[] valores = { Opcion, Apepat_Emp, Apemat_Emp, Nombres_Emp };
            return bd.DataTableFromProcedure("usp_ListarEmpleado", parametros, valores, null);
        }

        public void EmpleadoModificar(int Tipo_ID_Emp_New, string Nro_ID_Emp_New, int Tipo_ID_Emp_Old, string Nro_ID_Emp_Old, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios)
        {
            using (SqlConnection cn = new SqlConnection("data source =" + DATASOURCE + "; initial catalog = " + BASEDEDATOS + "; user id = " + USERID + "; password = " + USERPASS + ""))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = "usp_EmpleadoModificar";
                    cmd.CommandType = CommandType.StoredProcedure;

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
        }

        public DataRow Loguearse(string Login_User, int Opcion)
        {
            string[] parametros = { "@Login_User", "@Opcion" };
            object[] valores = { Login_User, Opcion };
            return bd.DatarowFromProcedure("usp_GetIntentosLogin", parametros, valores, null);
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

        public DataRow MaximaFechaATomarFalta(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_MaximaFechaTomadaFalta", parametros, valores, null);
        }

        public DataRow DiasGenerado(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime FechaInicio)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp", "@Fec_Inicio" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp, FechaInicio };
            return bd.DatarowFromProcedure("usp_DiasGenerado", parametros, valores, null);
        }

        public DataRow Sueldo(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            string[] parametros = { "@Tipo_ID_Emp", "@Nro_ID_Emp" };
            object[] valores = { Tipo_ID_Emp, Nro_ID_Emp };
            return bd.DatarowFromProcedure("usp_GetEmpleadoSueldo", parametros, valores, null);
        }

        public void ComprarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Desde, DateTime Hasta, int Dias_Pendiente, decimal Monto_Propuesto, decimal Monto_Pactado)
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

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                cn.Dispose();
            }
        }

        public void EmpleadoFaltas(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias, string Observaciones, byte[] Foto, string NombreFoto)
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
                    cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 256).Value = Observaciones;
                    cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto;
                    cmd.Parameters.Add("@NombreFoto", SqlDbType.VarChar, 256).Value = NombreFoto;

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

    }
}