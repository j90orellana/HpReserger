using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace HPResergerCapaLogica
{
    public class HPResergerCL
    {
        HPResergerCapaDatos.HPResergerCD cdOrdenPedido = new HPResergerCapaDatos.HPResergerCD();
        /// <summary>
        /// 
        public DataTable ListarEmpleadoContrato(int tipo, string numero)
        {
            return cdOrdenPedido.ListarContratoEmpleado(tipo, numero);
        }
        public void AgregarPerfil(string descripcion)
        {
            cdOrdenPedido.AgregarPerfil(descripcion);
        }
        public void ActualizarPerfil(int codigo, string descripcion)
        {
            cdOrdenPedido.ActualizarPerfil(codigo, descripcion);
        }
        public void EliminarPerfil(int codigo)
        {
            cdOrdenPedido.EliminarPerfil(codigo);
        }
        public void InsertarActualizarUsuario(int tipoid, string nroid, string login, string contra, int perfil, int estado, int opcion, out int respuesta)
        {
            cdOrdenPedido.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estado, opcion, out respuesta);
        }

        public void CambioContraseña(out int resultado, string usuario, string contrasena, string nueva)
        {
            cdOrdenPedido.CambiarContraseña(out resultado, usuario, contrasena, nueva);
        }
        public DataTable ListarAreaGerencia()
        {
            return cdOrdenPedido.ListarAreaGerencia();
        }

        public DataTable usuarios(string numeroid, int tipoid, int opcion)
        {
            return cdOrdenPedido.Usuarios(numeroid, tipoid, opcion);
        }

        public DataTable ListarArea()
        {
            return cdOrdenPedido.ListarAreas();
        }
        public DataTable ListarAreas(string busca)
        {
            return cdOrdenPedido.ListarAreas(busca);
        }

        public void InsertarArea(string valor, int costo, int gerencia)
        {
            cdOrdenPedido.InsertarArea(valor, costo, gerencia);
        }
        public void ActualizarArea(string valor, int costo, int gerencia, int area)
        {
            cdOrdenPedido.ActualizarArea(valor, costo, gerencia, area);
        }
        public void EliminarArea(int costo, int gerencia, int area)
        {
            cdOrdenPedido.EliminarArea(costo, gerencia, area);
        }
        public void AgregarGerencia(string gerencia)
        {
            cdOrdenPedido.AgregarGerencia(gerencia);
        }
        public void ActualizarGerencia(int codigo, string gerencia)
        {
            cdOrdenPedido.ActualizarGerencia(codigo, gerencia);
        }
        public void EliminarGerencia(int codigo)
        {
            cdOrdenPedido.EliminarGerencia(codigo);
        }
        public void InsertarCentroCostros(string valor)
        {
            cdOrdenPedido.InsertarCentroCosto(valor);
        }
        public void ActualizarCentroCostos(string valor, int codigo)
        {
            cdOrdenPedido.ActualizarCentroCosto(valor, codigo);
        }
        public DataTable MarcaArticulo(int IdArticulo)
        {
            return cdOrdenPedido.MarcaArticulo(IdArticulo);
        }

        public DataTable ModeloArticulo(int IdMarca)
        {
            return cdOrdenPedido.ModeloArticulo(IdMarca);
        }
        public void InsertarMarca(string valor)
        {
            cdOrdenPedido.InsertarMarca(valor);
        }
        public void ActualizarMarca(int codigo, string valor)
        {
            cdOrdenPedido.ActualizarMarca(codigo, valor);
        }
        public void ActualizarModelo(int codigo, string valor)
        {
            cdOrdenPedido.ActualizarModelo(codigo, valor);
        }
        public void EliminarMarca(int codigo)
        {
            cdOrdenPedido.EliminarMarca(codigo);
        }
        public void EliminarModelo(int codigo)
        {
            cdOrdenPedido.EliminarModelo(codigo);
        }
        public void InsertarModelo(string valor)
        {
            cdOrdenPedido.InsertarModelo(valor);
        }
        public DataTable ListarModeloMarcas(string busca)
        {
            return cdOrdenPedido.ListarModeloMarca(busca);
        }
        public DataTable VerificarMarcaModelo(int marca, int modelo)
        {
            return cdOrdenPedido.VerificarMarcaModelo(marca, modelo);
        }
        public DataTable VerificarArticuloServicio(string articulo, int marca)
        {
            return cdOrdenPedido.VerificarArticuloServicio(articulo, marca);
        }
        public void InsertarArticulo(string descripcion, int stock, int tipo, string observa)
        {
            cdOrdenPedido.InsertarArticulo(descripcion, stock, tipo, observa);
        }
        public void InsertarArticuloMarca(int marca, int articulo)
        {
            cdOrdenPedido.InsertarArticuloMarca(marca, articulo);
        }
        public void EliminarARticuloMarca(int marca, int articulo)
        {
            cdOrdenPedido.ElimimarArticuloMarca(marca, articulo);
        }
        public DataTable ListarArticulos(string busca)
        {
            return cdOrdenPedido.ListarArticulos(busca);
        }
        public DataTable ListarModelos(int valor)
        {
            return cdOrdenPedido.ListarModelos(valor);
        }
        public void ActualizarMarcaModelo(int marca, int modelo, int modmar, int modmode)
        {
            cdOrdenPedido.ActualizarMarcaModelo(marca, modelo, modmar, modmode);
        }
        public void ActualizarArticuloMarca(int arti, string descr, int stock, int tipo, string obser, int marca, int modmarca)
        {
            cdOrdenPedido.ActualizarArticuloMarca(arti, descr, stock, tipo, obser, marca, modmarca);
        }
        public DataTable VerificarArticulo(string articulo)
        {
            return cdOrdenPedido.VerificarArticulo(articulo);
        }
        public DataTable getCargoTipoContratacion2(string Campo1, string Campo2, string Tabla)
        {
            return cdOrdenPedido.getCargoTipoContratacion2(Campo1, Campo2, Tabla);
        }
        public DataTable getCargoTipoContratacion3(string Campo1, string Campo2, string Campo3, string Tabla, string busca)
        {
            return cdOrdenPedido.getCargoTipoContratacion3(Campo1, Campo2, Campo3, Tabla, busca);
        }
        public DataTable getCargoTipoContratacion6(string Campo1, string Campo2, string Campo3, string Campo4, string Tabla, string busca, string busca2)
        {
            return cdOrdenPedido.getCargoTipoContratacion6(Campo1, Campo2, Campo3, Campo4, Tabla, busca, busca2);
        }
        public void InsertarMarcaModelo(int marca, int modelo)
        {
            cdOrdenPedido.InsertarMarcaModelo(marca, modelo);
        }
        public void EliminarMarcaModelo(int marca, int modelo)
        {
            cdOrdenPedido.EliminarMarcaModelo(marca, modelo);
        }
        public DataTable ListarDepartamentos(string busca)
        {
            return cdOrdenPedido.listar_Departamentos(busca);
        }
        public DataTable ListarProvincias(int codigo, string busca)
        {
            return cdOrdenPedido.listar_Provincias(codigo, busca);
        }
        public DataTable ListarDistrito(int coddep, int codpro, string busca)
        {
            return cdOrdenPedido.listar_Distrito(coddep, codpro, busca);
        }
        public void InsertarDepartamento(int valor)
        {
            cdOrdenPedido.InsertarDepartamento(valor);
        }
        public void ActualizarDepartamento(string valor, int dep)
        {
            cdOrdenPedido.ActualizarDepartamento(valor, dep);
        }
        public DataTable ListarProvincias(string buscar)
        {
            return cdOrdenPedido.ListarProvincia(buscar);
        }
        public void EliminarDepartamento(int dep)
        {
            cdOrdenPedido.EliminarDepartamento(dep);
        }
        public DataTable verificardistrito(int coddep, int codpro)
        {
            return cdOrdenPedido.VerificarDistritos(coddep, codpro);
        }
        public DataTable VerificarProvincia(int dep)
        {
            return cdOrdenPedido.VerificarProvincias(dep);
        }
        public DataRow validardistrito(string validar)
        {
            return cdOrdenPedido.ValidarDistrito(validar);
        }
        public void insertardistrito(int dep, int pro, int dis, string valor)
        {
            cdOrdenPedido.InsertarDistrito(dep, pro, dis, valor);
        }
        public void modificardistrito(int dep, int pro, int dis, string valor)
        {
            cdOrdenPedido.ModificarDistrito(dep, pro, dis, valor);
        }
        public void eliminardistrito(int dep, int pro, int dis)
        {
            cdOrdenPedido.EliminarDistrito(dep, pro, dis);
        }
        public void InsertarProvincia(int dep, int pro, string valor)
        {
            cdOrdenPedido.insertarprovincia(dep, pro, valor);
        }
        public void ActualizarProvincia(int dep, int pro, string valor)
        {
            cdOrdenPedido.actualizarprovincia(dep, pro, valor);
        }
        public DataTable ListarProvincia(int Departamento)
        {
            return cdOrdenPedido.ListarProvincia(Departamento);
        }

        public DataTable ListarDistrito(int Departamento, int Provincia)
        {
            return cdOrdenPedido.ListarDistrito(Departamento, Provincia);
        }
        public void EliminarProvincia(int dep, int pro)
        {
            cdOrdenPedido.eliminarprovincia(dep, pro);
        }
        public DataTable ListarDistritos(string cadena)
        {
            return cdOrdenPedido.ListarDistritos(cadena);
        }
        public void AgregarEntiFinanciera(string Descripcion)
        {
            cdOrdenPedido.AgregarEntiFinanciera(Descripcion);
        }
        public void ActualizarEntiFinanciera(int codigo, string descripcion)
        {
            cdOrdenPedido.ActualizarEntiFinanciera(codigo, descripcion);
        }
        public void EliminarEntiFinanciera(int codigo)
        {
            cdOrdenPedido.EliminarEntiFinanciera(codigo);
        }
        public void AgregarParPresupuesto(string presupuesto)
        {
            cdOrdenPedido.AgregarParPresupuesto(presupuesto);
        }
        public void ActualizarParPresupuesto(int codigo, string presupuesto)
        {
            cdOrdenPedido.ActualizarParPresupuesto(codigo, presupuesto);
        }
        public void EliminarParPrespuesto(int codigo)
        {
            cdOrdenPedido.EliminarParPResupuesto(codigo);
        }
        public void AgregarTipoId(string presupuesto)
        {
            cdOrdenPedido.AgregarTipoId(presupuesto);
        }
        public void ActualizarTipoId(int codigo, string presupuesto)
        {
            cdOrdenPedido.ActualizarTipoId(codigo, presupuesto);
        }
        public void EliminarTipoId(int codigo)
        {
            cdOrdenPedido.EliminarTipoId(codigo);
        }
        public DataTable ListarProveedores(string busca, int opcion)
        {
            return cdOrdenPedido.ListarProveedores(busca, opcion);
        }
        public DataTable ListarCuentasContables(string busca, int opcion)
        {
            return cdOrdenPedido.ListarCuentasContables(busca, opcion);
        }
        public DataTable BuscarCuentas(string buscar, int opcion)
        {
            return cdOrdenPedido.BuscarCuenta(buscar, opcion);
        }
        public DataTable ListarDinamicas(string busca, int opcion)
        {
            return cdOrdenPedido.ListarDinamicaContable(busca, opcion);
        }
        public DataTable UltimaDinamica()
        {
            return cdOrdenPedido.UltimaDinamica();
        }
        public DataTable SacarDinaminas(string busca)
        {
            return cdOrdenPedido.SacarDinamicas(busca);
        }
        public void InsertarDinamica(int codigo, int ejercicio, int codope, int codsub, int cuenta, string debe, int estado)
        {
            cdOrdenPedido.InsertarDinamica(codigo, ejercicio, codope, codsub, cuenta, debe, estado);
        }
        public void ModificarDinamica(int codigo, int ejercicio, int codope, int codsub, int cuenta, string debe, int estado)
        {
            cdOrdenPedido.ModificarDinamica(codigo, ejercicio, codope, codsub, cuenta, debe, estado);
        }
        public void Modificar2Dinamica(int codigo)
        {
            cdOrdenPedido.Modificar2Dinamica(codigo);
        }
        public void EliminarDinamica(int codigo)
        {
            cdOrdenPedido.EliminarDinamica(codigo);
        }
        public DataTable ListarAsientosContables(string busca, int opcion, DateTime fechaini, DateTime fechafin)
        {
            return cdOrdenPedido.ListarAsientosContables(busca, opcion, fechaini, fechafin);
        }
        public void Modificar2asiento(int codigo)
        {
            cdOrdenPedido.Modificar2asiento(codigo);
        }
        public DataTable BuscarAsientosContables(string busca, int opcion)
        {
            return cdOrdenPedido.BuscarAsientosContables(busca, opcion);
        }
        public DataTable UltimoAsiento()
        {
            return cdOrdenPedido.UltimoAsiento();
        }
        public void InsertarAsiento(int codigo, DateTime fecha, int cuenta, double debe, double haber, int dina, int estado)
        {
            cdOrdenPedido.InsertarAsiento(codigo, fecha, cuenta, debe, haber, dina, estado);
        }
        public void EliminarAsiento(int codigo)
        {
            cdOrdenPedido.EliminarASiento(codigo);
        }
        public DataTable VerificarProveedores(string codigo, string razon)
        {
            return cdOrdenPedido.VerificarProveedores(codigo, razon);
        }
        public DataTable VerificarCuentas(int codigo, string nombre)
        {
            return cdOrdenPedido.VerificarCuentas(codigo, nombre);
        }
        public void InsertarCuentasContables(string cuentan1, int codcuenta, string nombre, int tipo, string natu, int generica, int grupo,
           string refleja, string reflejacc, int reflejadebe, int reflejahaber, int cuentacierre, string analitica, int mensual, int cierre,
           int traslacion, string bc)
        {
            cdOrdenPedido.InsertarCuentasContables(cuentan1, codcuenta, nombre, tipo, natu, generica, grupo, refleja, reflejacc, reflejadebe, reflejahaber,
                cuentacierre, analitica, mensual, cierre, traslacion, bc);
        }
        public void ActualizarCuentasContables(int codcuenta, int generica, int grupo,
          string refleja, string reflejacc, int reflejadebe, int reflejahaber, int cuentacierre, string analitica, int mensual, int cierre,
          int traslacion, string bc)
        {
            cdOrdenPedido.ActualizarCuentasContables(codcuenta, generica, grupo, refleja, reflejacc, reflejadebe, reflejahaber,
                cuentacierre, analitica, mensual, cierre, traslacion, bc);
        }
        public void InsertarProveedor(string ruc, string razon, string nombre, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
            string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int regi)
        {
            cdOrdenPedido.InsertarProveedor(ruc, razon, nombre, sector, dirofi, telofi, diralm, telalm, dirsuc, telsuc, telcon,
             nomcon, emacon, nctasoles, ccisoles, bancosoles, nroctadolares, ccidolares, bancodolares, detrac, regi);
        }
        public void ActualizarProveedor(string ruc, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
           string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int regi)
        {
            cdOrdenPedido.ActualizarProveedor(ruc, sector, dirofi, telofi, diralm, telalm, dirsuc, telsuc, telcon, nomcon, emacon, nctasoles, ccisoles, bancosoles,
                nroctadolares, ccidolares, bancodolares, detrac, regi);
        }
        /// </summary>
        /// <returns></returns>

        public DataTable ListarTipoPedido()
        {
            return cdOrdenPedido.ListarTipoPedido();
        }

        public DataTable ItemCombo(int TipoCompra)
        {
            return cdOrdenPedido.ItemCombo(TipoCompra);
        }

        //public DataTable MarcaArticulo(int IdArticulo)
        //{
        //    return cdOrdenPedido.MarcaArticulo(IdArticulo);
        //}

        //public DataTable ModeloArticulo(int IdMarca)
        //{
        //    return cdOrdenPedido.ModeloArticulo(IdMarca);
        //}

        public DataRow PerfilOrdenPedido(int IdUsuario)
        {
            return cdOrdenPedido.PerfilOrdenPedido(IdUsuario);
        }
        public void OrdenPedidoCabeceraInsertar(out int Numero, int Usuario, int Tipo)
        {
            cdOrdenPedido.OrdenPedidoCabeceraInsertar(out Numero, Usuario, Tipo);
        }

        public void OrdenPedidoDetalleInsertar(int Numero, int Cantidad, int Articulo, int Marca, int Modelo, string Observaciones)
        {
            cdOrdenPedido.OrdenPedidoDetalleInsertar(Numero, Cantidad, Articulo, Marca, Modelo, Observaciones);
        }

        public DataTable ListarPedidos(int TipoArticulo, string Articulo, DateTime Desde, DateTime Hasta, int Usuario)
        {
            return cdOrdenPedido.ListarPedidos(TipoArticulo, Articulo, Desde, Hasta, Usuario);
        }

        public DataTable ListarOrdenPedido(int Numero, string Tipo)
        {
            return cdOrdenPedido.ListarOrdenPedido(Numero, Tipo);
        }

        public void OrdenPedidoDetalleModificar(int Tipo, int Numero, int Cantidad, int ArticuloOld, int ArticuloNew, int MarcaOld, int MarcaNew, int ModeloOld, int ModeloNew, string Observaciones)
        {
            cdOrdenPedido.OrdenPedidoDetalleActualizar(Tipo, Numero, Cantidad, ArticuloOld, ArticuloNew, MarcaOld, MarcaNew, ModeloOld, ModeloNew, Observaciones);
        }

        public void AnularOrdenPedido(int Numero)
        {
            cdOrdenPedido.AnularOrdenPedido(Numero);
        }

        public DataTable ListarPedidosCotizacion(int Area, int Usuario)
        {
            return cdOrdenPedido.ListarPedidosCotizacion(Area, Usuario);
        }

        //public DataTable ListarArea()
        //{
        //    return cdOrdenPedido.ListarAreas();
        //}

        public DataRow CotizacionPedidoCabecera(int Numero)
        {
            return cdOrdenPedido.CotizacionPedidoCabecera(Numero);
        }

        public DataTable CotizacionPedidoDetalle(int Numero)
        {
            return cdOrdenPedido.CotizacionPedidoDetalle(Numero);
        }

        public DataTable ListarGiros()
        {
            return cdOrdenPedido.ListarGiros();
        }

        public DataTable ListarProveedorGiro(int Giro)
        {
            return cdOrdenPedido.ListarProveedorGiro(Giro);
        }

        public void CotizacionCabeceraInsertar(out int Numero, DateTime FechaEntrega, int Tipo, int Usuario, decimal Importe, int Pedido, string Proveedor, byte[] Foto, string NombreArchivo)
        {
            cdOrdenPedido.CotizacionCabeceraInsertar(out Numero, FechaEntrega, Tipo, Usuario, Importe, Pedido, Proveedor, Foto, NombreArchivo);
        }

        public void CotizacionDetalleInsertar(int Cotizacion, int Pedido)
        {
            cdOrdenPedido.CotizacionDetalleInsertar(Cotizacion, Pedido);
        }

        public DataTable ListarCotizacionesAsociadas(int Pedido)
        {
            return cdOrdenPedido.ListarCotizacionesAsociadas(Pedido);
        }

        public DataTable ListarCotizacionesAsociadasParaAprobar(int Usuario)
        {
            return cdOrdenPedido.ListarCotizacionesAsociadasParaAprobar(Usuario);
        }

        public DataRow Logueo(string Login_User, string Password_User)
        {
            return cdOrdenPedido.Logueo(Login_User, Password_User);
        }

        public void AprobacionNOCotizacion(int Cotizacion, string sStoredProcedure)
        {
            cdOrdenPedido.AprobacionNOCotizacion(Cotizacion, sStoredProcedure);
        }

        public void OrdenCompraInsertar(out int Numero, int Cotizacion, int Pedido, int CentroCosto, int PPto, int Usuario, int Area, int Gerencia, string Proveedor, decimal Importe, int Tipo)
        {
            cdOrdenPedido.OrdenCompraInsertar(out Numero, Cotizacion, Pedido, CentroCosto, PPto, Usuario, Area, Gerencia, Proveedor, Importe, Tipo);
        }

        public DataTable ListarOrdenesCompra(int Usuario)
        {
            return cdOrdenPedido.ListarOrdenesCompra(Usuario);
        }

        public DataRow ListarDetalleOC(int Cotizacion)
        {
            return cdOrdenPedido.ListarDetalleOC(Cotizacion);
        }
        public DataTable ListarOCDetalle(int Pedido)
        {
            return cdOrdenPedido.ListarOCDetalle(Pedido);
        }

        public void UpdateEstado(int Numero, int Estado)
        {
            cdOrdenPedido.UpdateEstadoOC(Numero, Estado);
        }

        public DataTable ListarOCProveedor(string Proveedor, int Tipo, int Usuario)
        {
            return cdOrdenPedido.ListarOCProveedor(Proveedor, Tipo, Usuario);
        }

        public DataTable ListarArticulosFIC(int OC, int TIPO)
        {
            return cdOrdenPedido.ListarArticulosFIC(OC, TIPO);
        }

        public void FICCabeceraInsertar(out int Numero, int GuiaRemision, int OrdenCompra, int Tipo, int Usuario)
        {
            cdOrdenPedido.FICCabeceraInsertar(out Numero, GuiaRemision, OrdenCompra, Tipo, Usuario);
        }

        public void FICDetalleInsertar(int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo, int Cantidad, string Observaciones, int Tipo)
        {
            cdOrdenPedido.FICDetalleInsertar(NumeroFIC, CodigoArticulo, CodigoMarca, CodigoModelo, Cantidad, Observaciones, Tipo);
        }

        public DataTable ListarFIC(int OC, int Tipo)
        {
            return cdOrdenPedido.ListarFIC(OC, Tipo);
        }

        public DataTable ListarFIC2(int OC, int FIC, int Tipo)
        {
            return cdOrdenPedido.ListarFIC2(OC, FIC, Tipo);
        }

        public DataRow RUCProveedor(string RUC)
        {
            return cdOrdenPedido.RUCProveedor(RUC);
        }

        public DataRow CargarImagenCotizacion(int Numero)
        {
            return cdOrdenPedido.CargarImagenCotizacion(Numero);
        }

        public void CotizacionModificar(int Numero, DateTime FechaEntrega, decimal Importe, string Proveedor, byte[] Foto, string NombreArchivo)
        {
            cdOrdenPedido.CotizacionModificar(Numero, FechaEntrega, Importe, Proveedor, Foto, NombreArchivo);
        }

        public DataRow ExisteFoto(string NombreFoto)
        {
            return cdOrdenPedido.ExisteFoto(NombreFoto);
        }

        public DataTable ListarOS(int Usuario)
        {
            return cdOrdenPedido.ListarOS(Usuario);
        }

        public DataTable getCargoTipoContratacion(string Campo1, string Campo2, string Tabla)
        {
            return cdOrdenPedido.getCargoTipoContratacion(Campo1, Campo2, Tabla);
        }

        public void SolicitudEmpleadoInsertar(int Numero, int Cargo, int TipoContratacion, string Busqueda, string AplicaTerna, int Area, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto, int Usuario)
        {
            cdOrdenPedido.SolicitudEmpleadoInsertar(Numero, Cargo, TipoContratacion, Busqueda, AplicaTerna, Area, CantPuestos, NroOrdenCompra, Foto, NombreFoto, Usuario);
        }

        public DataTable ListarSE(int Usuario)
        {
            return cdOrdenPedido.ListarSE(Usuario);
        }
        public DataRow CargarImagenSolicitudEmpleado(int Numero)
        {
            return cdOrdenPedido.CargarImagenSolicitudEmpleado(Numero);
        }

        public DataTable ListarComboSE(int Usuario)
        {
            return cdOrdenPedido.ListarComboSE(Usuario);
        }
        public DataTable ListarSEPostulantes(int Usuario)
        {
            return cdOrdenPedido.ListarSEPostulantes(Usuario);
        }

        public void PostulanteInsertar(int Tipo_ID_Postulante, string Nro_ID_Postulante, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, int ID_Puesto_Postulante, byte[] Foto, string NombreFoto, int OC, int SE, int Usuario)
        {
            cdOrdenPedido.PostulanteInsertar(Tipo_ID_Postulante, Nro_ID_Postulante, Apepat_Postulante, Apemat_Postulante, Nombres_Postulante, ID_Puesto_Postulante, Foto, NombreFoto, OC, SE, Usuario);
        }

        public DataTable ListarPostulanteSE(int Solicitud)
        {
            return cdOrdenPedido.ListarPostulanteSE(Solicitud);
        }

        //public DataTable ListarProvincia(int Departamento)
        //{
        //    return cdOrdenPedido.ListarProvincia(Departamento);
        //}

        //public DataTable ListarDistrito(int Departamento, int Provincia)
        //{
        //    return cdOrdenPedido.ListarDistrito(Departamento, Provincia);
        //}

        public void EmpleadoInsertar(int Tipo_ID_Emp, string Nro_ID_Emp, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, int Usuario)
        {
            cdOrdenPedido.EmpleadoInsertar(Tipo_ID_Emp, Nro_ID_Emp, Apepat_Emp, Apemat_Emp, Nombres_Emp, Sexo, Fec_Nacimiento, Lugar_Nacimiento, Estado_Civil, Hijos, Direccion, Distrito, Provincia, Departamento, Telf_Fijo, Telf_Celular, Profesion, Grado_Instruccion, AntecedentesPoliciales, NombreFotoAntecedentesPoliciales, AntecedentesPenales, NombreFotoAntecedentesPenales, ReciboServicios, NombreFotoReciboServicios, Usuario);
        }

        public DataRow DatosPostulante(int Tipo, string Numero)
        {
            return cdOrdenPedido.DatosPostulante(Tipo, Numero);
        }

        public void EmpleadoRequerimiento(int Tipo_ID_Emp, string Nro_ID_Emp, string Correo, string Correo_Obs, string Celular, string Celular_Obs, string Pc, string Pc_Obs, string Otros, string Otros_Obs, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoRequerimiento(Tipo_ID_Emp, Nro_ID_Emp, Correo, Correo_Obs, Celular, Celular_Obs, Pc, Pc_Obs, Otros, Otros_Obs, Usuario, Opcion);
        }

        public void EmpleadoCTS(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoCTS(Tipo_ID_Emp, Nro_ID_Emp, Banco, Moneda, Nro_Cta, Nro_Cci, Usuario, Opcion);
        }

        public void EmpleadoPagoHaberes(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoPagoHaberes(Tipo_ID_Emp, Nro_ID_Emp, Banco, Moneda, Nro_Cta, Nro_Cci, Usuario, Opcion);
        }

        public void EmpleadoSeguroPension(int Tipo_ID_Emp, string Nro_ID_Emp, string Eps, int Eps_Adicional, string Sctr, string Onp, string Afp, int Afp_Empresa, string Nro_Cupss, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoSeguroPension(Tipo_ID_Emp, Nro_ID_Emp, Eps, Eps_Adicional, Sctr, Onp, Afp, Afp_Empresa, Nro_Cupss, Usuario, Opcion);
        }

        public DataTable ListarJefeInmediato(int tipo, string documento, int opcion)
        {
            return cdOrdenPedido.ListarJefeInmediato(tipo, documento, opcion);
        }

        public void EmpleadoContrato(int numero, int Tipo_ID_Emp, string Nro_ID_Emp, int jefe, int Tipo_Contrato, int Cargo, int Gerencia, int Area, int tipojefe, string Jefe_Inmediato, int Empresa, int Proyecto, int Sede, DateTime Fec_Inicio, int Periodo_Laboral, DateTime Fec_Fin, Decimal Sueldo, string Bono, Decimal Bono_Importe, int Bono_Periodicidad, byte[] Contrato_Img, string Contrato, byte[] AnxFunc_Img, string AnxFunc, byte[] SolPrac_Img, string SolPrac, byte[] Otros_Img, string Otros, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoContrato(numero, Tipo_ID_Emp, Nro_ID_Emp, jefe, Tipo_Contrato, Cargo, Gerencia, Area, tipojefe, Jefe_Inmediato, Empresa, Proyecto, Sede, Fec_Inicio, Periodo_Laboral, Fec_Fin, Sueldo, Bono, Bono_Importe, Bono_Periodicidad, Contrato_Img, Contrato, AnxFunc_Img, AnxFunc, SolPrac_Img, SolPrac, Otros_Img, Otros, Usuario, Opcion);
        }

        public void EmpleadoFamilia(int Tipo_ID_Emp, string Nro_ID_Emp, int Vinculo_Familiar, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old, int Tipo_ID_Fam_New, string Nro_ID_Fam_New, string Apepat_Fam, string Apemat_Fam, string Nombres_Fam, DateTime Fec_Nacimiento_Fam, string Ocupacion, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoFamilia(Tipo_ID_Emp, Nro_ID_Emp, Vinculo_Familiar, Tipo_ID_Fam_Old, Nro_ID_Fam_Old, Tipo_ID_Fam_New, Nro_ID_Fam_New, Apepat_Fam, Apemat_Fam, Nombres_Fam, Fec_Nacimiento_Fam, Ocupacion, Usuario, Opcion);
        }

        public DataTable ListarEmpleadoFamilia(int CodugoDocumento, string NumeroDocumento)
        {
            return cdOrdenPedido.ListarEmpleadoFamilia(CodugoDocumento, NumeroDocumento);
        }

        public DataRow ExisteImagen(string Campo1, string Campo2, string Tabla)
        {
            return cdOrdenPedido.ExisteImagen(Campo1, Campo2, Tabla);
        }

        public void AprobarPostulante(int Tipo_ID_Postulante, string Nro_ID_Postulante, int Id_SolicitaEmpleado)
        {
            cdOrdenPedido.AprobarPostulante(Tipo_ID_Postulante, Nro_ID_Postulante, Id_SolicitaEmpleado);
        }

        public DataRow ExistePostulante(int Tipo_ID_Postulante, string Nro_ID_Postulante)
        {
            return cdOrdenPedido.ExistePostulante(Tipo_ID_Postulante, Nro_ID_Postulante);
        }

        public DataRow DatosEmpleado(int Tipo_ID_Empleado, string Nro_ID_Empleado)
        {
            return cdOrdenPedido.DatosEmpleado(Tipo_ID_Empleado, Nro_ID_Empleado);
        }

        public DataRow ExisteBeneficioEmpleado(int Tipo_ID_Emp, string Nro_ID_Emp, string sStoredProcedureName)
        {
            return cdOrdenPedido.ExisteBeneficioEmpleado(Tipo_ID_Emp, Nro_ID_Emp, sStoredProcedureName);
        }

        public DataRow FechaActual()
        {
            return cdOrdenPedido.FechaActual();
        }

        public void SolicitudEmpleadoModificar(int ID_SolicitaEmpleado, int Cargo, int Tipo_Contratacion, string Busqueda, string AplicaTerna, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto)
        {
            cdOrdenPedido.SolicitudEmpleadoModificar(ID_SolicitaEmpleado, Cargo, Tipo_Contratacion, Busqueda, AplicaTerna, CantPuestos, NroOrdenCompra, Foto, NombreFoto);
        }

        public DataRow VerificaEstadoSolicitudEmpleado(int Solicitud)
        {
            return cdOrdenPedido.VerificaEstadoSolicitudEmpleado(Solicitud);
        }

        public DataRow CargarCualquierImagenPostulanteEmpleado(string CampoBuscado, string Tabla, string PrimerCampoComparativo, int PrimerValor, string SegundoCampoComparativo, string SegundoValorComparativo)
        {
            return cdOrdenPedido.CargarCualquierImagenPostulanteEmpleado(CampoBuscado, Tabla, PrimerCampoComparativo, PrimerValor, SegundoCampoComparativo, SegundoValorComparativo);
        }

        public void PostulanteModificar(int Tipo_ID_Postulante_Old, string Nro_ID_Postulante_Old, int Tipo_ID_Postulante_New, string Nro_ID_Postulante_New, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, byte[] Foto, string NombreFoto, int Id_SolicitaEmpleado)
        {
            cdOrdenPedido.PostulanteModificar(Tipo_ID_Postulante_Old, Nro_ID_Postulante_Old, Tipo_ID_Postulante_New, Nro_ID_Postulante_New, Apepat_Postulante, Apemat_Postulante, Nombres_Postulante, Foto, NombreFoto, Id_SolicitaEmpleado);
        }

        public DataTable ListarEmpleado(int Opcion, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp)
        {
            return cdOrdenPedido.ListarEmpleado(Opcion, Apepat_Emp, Apemat_Emp, Nombres_Emp);
        }

        public void EmpleadoModificar(int Tipo_ID_Emp_New, string Nro_ID_Emp_New, int Tipo_ID_Emp_Old, string Nro_ID_Emp_Old, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios)
        {
            cdOrdenPedido.EmpleadoModificar(Tipo_ID_Emp_New, Nro_ID_Emp_New, Tipo_ID_Emp_Old, Nro_ID_Emp_Old, Apepat_Emp, Apemat_Emp, Nombres_Emp, Sexo, Fec_Nacimiento, Lugar_Nacimiento, Estado_Civil, Hijos, Direccion, Distrito, Provincia, Departamento, Telf_Fijo, Telf_Celular, Profesion, Grado_Instruccion, AntecedentesPoliciales, NombreFotoAntecedentesPoliciales, AntecedentesPenales, NombreFotoAntecedentesPenales, ReciboServicios, NombreFotoReciboServicios);
        }

        public void ActualizarLogin(string sStoredProcedureName, string Login_User, int Opcion)
        {
            cdOrdenPedido.ActualizarLogin(sStoredProcedureName, Login_User, Opcion);
        }

        public DataRow Loguearse(string Login_User, int Opcion)
        {
            return cdOrdenPedido.Loguearse(Login_User, Opcion);
        }

        public DataTable ListarAreasUsuario(int Usuario)
        {
            return cdOrdenPedido.ListarAreasUsuario(Usuario);
        }

        public DataRow CotTieneOC(int Cotizacion)
        {
            return cdOrdenPedido.CotTieneOC(Cotizacion);
        }

        public void AnularCotizacion(int Cotizacion)
        {
            cdOrdenPedido.AnularCotizacion(Cotizacion);
        }
        public DataTable LimpiarCombosGrillas()
        {
            return cdOrdenPedido.LimpiarCombosGrillas();
        }

        public DataRow NextValorizacion()
        {
            return cdOrdenPedido.NextValorizacion();
        }

        public void EliminarSolicitudEmpleado(int Solicitud)
        {
            cdOrdenPedido.EliminarSolicitudEmpleado(Solicitud);
        }

        public DataRow Correlativo(string Tabla)
        {
            return cdOrdenPedido.Correlativo(Tabla);
        }

        public DataTable ListarSECombo(int Usuario, int Solicitud)
        {
            return cdOrdenPedido.ListarSECombo(Usuario, Solicitud);
        }

        public DataRow DiasVacaciones(DateTime FechaInicio, DateTime FechaFin)
        {
            return cdOrdenPedido.DiasVacaciones(FechaInicio, FechaFin);
        }

        public void EmpleadoVacacionesInsertar(out int Numero, int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias_Vacaciones, string Observaciones)
        {
            cdOrdenPedido.EmpleadoVacacionesInsertar(out Numero, Tipo_ID_Emp, Nro_ID_Emp, Fec_Inicio, Fec_Fin, Dias_Vacaciones, Observaciones);
        }

        public DataTable AreaGerencia(int Gerencia)
        {
            return cdOrdenPedido.AreaGerencia(Gerencia);
        }

        public DataTable ListarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.ListarVacaciones(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public void AprobarVacaciones(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, byte[] Foto, string NombreFoto)
        {
            cdOrdenPedido.AprobarVacaciones(Registro, Tipo_ID_Emp, Nro_ID_Emp, Foto, NombreFoto);
        }

        public DataRow ImagenBoleta(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.ImagenBoleta(Registro, Tipo_ID_Emp, Nro_ID_Emp);
        }

        public DataRow ImagenFalta(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.ImagenFalta(Registro, Tipo_ID_Emp, Nro_ID_Emp);
        }

        public DataRow DiasTomadosVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.DiasTomadosVacaciones(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public DataRow MaximaFechaATomar(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.MaximaFechaATomar(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public DataRow DiasGenerado(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime FechaInicio)
        {
            return cdOrdenPedido.DiasGenerado(Tipo_ID_Emp, Nro_ID_Emp, FechaInicio);
        }

        public DataRow Sueldo(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.Sueldo(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public void ComprarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Desde, DateTime Hasta, int Dias_Pendiente, decimal Monto_Propuesto, decimal Monto_Pactado)
        {
            cdOrdenPedido.ComprarVacaciones(Tipo_ID_Emp, Nro_ID_Emp, Desde, Hasta, Dias_Pendiente, Monto_Propuesto, Monto_Pactado);
        }

        public void EmpleadoFaltas(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias, string Observaciones, byte[] Foto, string NombreFoto)
        {
            cdOrdenPedido.EmpleadoFaltas(Tipo_ID_Emp, Nro_ID_Emp, Fec_Inicio, Fec_Fin, Dias, Observaciones, Foto, NombreFoto);
        }

        public DataTable ListarFaltas(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.ListarFaltas(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public DataRow MaximaFechaATomarFalta(int Tipo_ID_Emp, string Nro_ID_Emp)
        {
            return cdOrdenPedido.MaximaFechaATomarFalta(Tipo_ID_Emp, Nro_ID_Emp);
        }

        public void EmpleadoMemoPremio(out int Numero, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo, string Observaciones)
        {
            cdOrdenPedido.EmpleadoMemoPremio(out Numero, Tipo_ID_Emp, Nro_ID_Emp, Tipo, Observaciones);
        }

        public DataTable ListarMemoPremio(int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo)
        {
            return cdOrdenPedido.ListarMemoPremio(Tipo_ID_Emp, Nro_ID_Emp, Tipo);
        }

        public void EmpleadoMemoPremioSustento(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo, byte[] Foto, string NombreFoto)
        {
            cdOrdenPedido.EmpleadoMemoPremioSustento(Registro, Tipo_ID_Emp, Nro_ID_Emp, Tipo, Foto, NombreFoto);
        }

        public DataRow ImagenEmpleadoMemoPremio(int Registro, int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo)
        {
            return cdOrdenPedido.ImagenEmpleadoMemoPremio(Registro, Tipo_ID_Emp, Nro_ID_Emp, Tipo);
        }

    }
}