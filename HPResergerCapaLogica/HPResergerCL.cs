using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HPResergerCapaLogica
{
    public class HPResergerCL
    {
        HPResergerCapaDatos.HPResergerCD cdOrdenPedido = new HPResergerCapaDatos.HPResergerCD();
        /// <summary>
        /// Listar Empleado Contrato
        /// </summary>
        ///<example> y que dice</example>
        ///<param name="numero" >Numero De contrato</param>
        ///<param name="tipo">Tipo de Contrato</param>
        public DataTable ListarEmpleadoContrato(int tipo, string numero)
        {
            return cdOrdenPedido.ListarContratoEmpleado(tipo, numero);
        }
        public void CambiarBase(string cadena)
        {
            HPResergerCapaDatos.HPResergerCD.BASEDEDATOS = cadena;
            cdOrdenPedido.HPResergerCDs(cadena);
        }
        /// <summary>
        /// Aguega un Perfil
        /// </summary>
        /// <param name="descripcion">Descripción del perfil</param>
        public void AgregarPerfil(string descripcion)
        {
            cdOrdenPedido.AgregarPerfil(descripcion);
        }
        public DataTable ProductosProyecto(int codigo, int opcion, string cadena, int usuarioo)
        {
            return cdOrdenPedido.ProductosProyecto(codigo, opcion, cadena, usuarioo);
        }
        public DataTable RegistroVentas(int opcion, string tipo, int nrocompra, string tipoid, string nro, string cliente, string producto, string proyecto, int etapa, int cantida, decimal precio, int vendedor, int usuario)
        {
            return cdOrdenPedido.RegistroVentas(opcion, tipo, nrocompra, tipoid, nro, cliente, producto, proyecto, etapa, cantida, precio, vendedor, usuario);
        }
        public DataTable Proyecto_Productos(int codigo, int opcion, int proy, int prod, decimal cantidad, int unidad, int moneda, decimal precipre, decimal precio, string etapa, int estado, string observacion, int usuarioo, int tipoinicial, decimal vinicial)
        {
            return cdOrdenPedido.Proyecto_Productos(codigo, opcion, proy, prod, moneda, unidad, cantidad, precipre, precio, etapa, estado, observacion, usuarioo, tipoinicial, vinicial);
        }
        public DataTable Proyecto_Productos(int proyecto)
        {
            return cdOrdenPedido.Proyecto_Productos(0, 0, proyecto, 0, 0, 0, 0, 0, 0, "", 0, "", 0, 0, 0);
        }
        public DataTable Proyecto_ProductosxCod(int CodigoProducto)
        {
            return cdOrdenPedido.Proyecto_Productos(CodigoProducto, 20, 0, 0, 0, 0, 0, 0, 0, "", 0, "", 0, 0, 0);
        }
        public decimal Igv(DateTime Fecha)
        {
            return (decimal)ValorIGVactual(Fecha)["valor"];
        }
        public DataRow ValorIGVactual(DateTime Fecha)
        {
            return cdOrdenPedido.ValorIGVactual(Fecha);
        }
        public DataTable Proyecto_ProductosxCod(int CodigoProducto, string etapa)
        {
            return cdOrdenPedido.Proyecto_Productos(CodigoProducto, 40, 0, 0, 0, 0, 0, 0, 0, etapa, 0, "", 0, 0, 0);
        }
        public DataTable Proyecto_ProductosxProyecto(int CodigoProyecto)
        {
            return cdOrdenPedido.Proyecto_Productos(0, 30, CodigoProyecto, 0, 0, 0, 0, 0, 0, "", 0, "", 0, 0, 0);
        }
        public DataTable DetalleProducto(int idproducto)
        {
            return cdOrdenPedido.Proyecto_Productos(idproducto, 50, 0, 0, 0, 0, 0, 0, 0, "", 0, "", 0, 0, 0);
        }
        public void ActualizarPerfil(int codigo, string descripcion)
        {
            cdOrdenPedido.ActualizarPerfil(codigo, descripcion);
        }
        public void EliminarPerfil(int codigo)
        {
            cdOrdenPedido.EliminarPerfil(codigo);
        }
        public void InsertarActualizarUsuario(int tipoid, string nroid, string login, string contra, int perfil, int estado, int opcion, int usuario, out int respuesta)
        {
            cdOrdenPedido.InsertarActualizarUsuario(tipoid, nroid, login, contra, perfil, estado, opcion, usuario, out respuesta);
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
        public DataTable BusquedaUsuarios(string nrodoc, string tipo, string nombre, string area, string login)
        {
            return cdOrdenPedido.BusquedaUsuarios(nrodoc, tipo, nombre, area, login);
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
        public void InsertarCentroCostros(string codigo, string valor, string tiene, string cuenta)
        {
            cdOrdenPedido.InsertarCentroCosto(codigo, valor, tiene, cuenta);
        }
        public void ActualizarCentroCostos(string valor, string codigos, int codigo, string tiene, string cuenta)
        {
            cdOrdenPedido.ActualizarCentroCosto(valor, codigos, codigo, tiene, cuenta);
        }
        public DataTable MarcaArticulo(int IdArticulo)
        {
            return cdOrdenPedido.MarcaArticulo(IdArticulo);
        }

        public DataTable ModeloArticulo(int IdMarca, int articulo)
        {
            return cdOrdenPedido.ModeloArticulo(IdMarca, articulo);
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
        public void InsertarArticulo(string descripcion, int stock, int tipo, string observa, int igv, int centro, string cuenta, string cc, string cta, string ctaact)
        {
            cdOrdenPedido.InsertarArticulo(descripcion, stock, tipo, observa, igv, centro, cuenta, cc, cta, ctaact);
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
        public void ActualizarArticuloMarca(int arti, string descr, int stock, int tipo, string obser, int marca, int modmarca, int igv, int centro, string cuenta, string cc, string cta, string ctaact)
        {
            cdOrdenPedido.ActualizarArticuloMarca(arti, descr, stock, tipo, obser, marca, modmarca, igv, centro, cuenta, cc, cta, ctaact);
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
        public void InsertarDepartamento(string valor)
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
            //// Cuenta_Contable Cuenta_Contable_Naturaleza SolicitaDetalle
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
        public void InsertarDinamica(int codigo, int ejercicio, int codope, int codsub, string cuenta, string debe, int estado, int solicita)
        {
            cdOrdenPedido.InsertarDinamica(codigo, ejercicio, codope, codsub, cuenta, debe, estado, solicita);
        }
        public void ModificarDinamica(int codigo, int ejercicio, int codope, int codsub, string cuenta, string debe, int estado, int solicita)
        {
            cdOrdenPedido.ModificarDinamica(codigo, ejercicio, codope, codsub, cuenta, debe, estado, solicita);
        }
        public void Modificar2Dinamica(int codigo)
        {
            cdOrdenPedido.Modificar2Dinamica(codigo);
        }
        public void EliminarDinamica(int codigo)
        {
            cdOrdenPedido.EliminarDinamica(codigo);
        }
        public DataTable ListarAsientosContables(string busca, int opcion, DateTime fechaini, DateTime fechafin, int fecha, int empresa)
        {
            return cdOrdenPedido.ListarAsientosContables(busca, opcion, fechaini, fechafin, fecha, empresa);
        }
        public void Modificar2asiento(int codigo, int proyecto, DateTime Fechas)
        {
            cdOrdenPedido.Modificar2asiento(codigo, proyecto, Fechas);
        }
        public DataTable BuscarAsientosContables(string busca, int opcion, int empresa)
        {
            return cdOrdenPedido.BuscarAsientosContables(busca, opcion, empresa);
        }
        public DataTable BuscarAsientosContablesconTodo(string busca, int opcion, int empresa, DateTime fechon)
        {
            return cdOrdenPedido.BuscarAsientosContablesconTodo(busca, opcion, empresa, fechon);
        }
        public DataTable ListarCuentas()
        {
            return cdOrdenPedido.ListarCuentas();
        }
        public DataTable DetalleAsientos(int opcion, int idaux, int idasiento, string cuenta, int tipodoc, string numdoc, string razon, int idcomprobante, string codcomprobante, string numcomprobante, int centrocosto, string glosa
         , DateTime fechaemision, DateTime fechavence, decimal importemn, decimal importeme, decimal tipocambio, int usuario, int proyecto, DateTime fecharecepcion, int moneda, DateTime fechaasiento, int ctabancaria, string fkasi, string nroop)
        {
            return cdOrdenPedido.DetalleAsientos(opcion, idaux, idasiento, cuenta, tipodoc, numdoc, razon, idcomprobante, codcomprobante, numcomprobante, centrocosto, glosa, fechaemision, fechavence, importemn, importeme, tipocambio, usuario, proyecto, fecharecepcion, moneda, fechaasiento, ctabancaria, fkasi, nroop);
        }
        public DataTable DetalleAsientos(int opcion, int idaux, int idasiento, int proyecto, DateTime FechaAsiento, string cuenta)
        {
            return cdOrdenPedido.DetalleAsientos(opcion, idaux, idasiento, cuenta, 0, null, null, 0, null, null, 0, null, DateTime.Now, DateTime.Now, 0, 0, 0, 0, proyecto, DateTime.Now, 0, FechaAsiento, 0, "", "");
        }
        public DataTable DetalleAsientosMontos(int idaux, int idasiento, int proyecto, DateTime FechaAsiento, string cuenta)
        {
            return cdOrdenPedido.DetalleAsientos(9, idaux, idasiento, cuenta, 0, null, null, 0, null, null, 0, null, DateTime.Now, DateTime.Now, 0, 0, 0, 0, proyecto, DateTime.Now, 0, FechaAsiento, 0, "", "");
        }
        public DataTable DuplicarDetalle(int idaux, int idasiento, int idproyecto, int duplicar, string cuenta, DateTime _Fechas)
        {
            return cdOrdenPedido.DuplicarDetalle(idaux, idasiento, idproyecto, duplicar, cuenta, _Fechas);
        }
        public DataTable BuscarSiDuplica(int idaux, int idasiento, int idproyecto, string cuenta, DateTime Fecha)
        {
            return cdOrdenPedido.BuscarSiDuplica(idaux, idasiento, idproyecto, cuenta, Fecha);
        }
        public DataTable UltimoAsiento(int empresa, DateTime FEcha)
        {
            return cdOrdenPedido.UltimoAsiento(empresa, FEcha);
        }
        public void UltimoAsiento(int empresa, DateTime FEcha, out int codigo, out string cuo)
        {
            DataRow FilaDato = (cdOrdenPedido.UltimoAsiento(empresa, FEcha)).Rows[0];
            codigo = (int)FilaDato["codigo"];
            cuo = FilaDato["cuo"].ToString();
        }
        public DataTable UltimoAsientoFactura(string numfac, string proveedor, DateTime fechh)
        {
            return cdOrdenPedido.UltimoAsientoFactura(numfac, proveedor, fechh);
        }
        public void InsertarAsiento(int id, int codigo, DateTime fecha, string cuenta, double debe, double haber, int dina, int estado, DateTime? fechavalor, int proyecto, int etapa, string glosa, int moneda, decimal tc)
        {
            cdOrdenPedido.InsertarAsiento(id, codigo, fecha, cuenta, debe, haber, dina, estado, fechavalor, proyecto, etapa, glosa, moneda, tc);
        }
        public void ActualizarDetalleAsiento(int oldasiento, int oldproyecto, DateTime oldfecha, int newasiento, int newproyecto, DateTime newfecha)
        {
            cdOrdenPedido.ActualizarDetalleAsiento(oldasiento, oldproyecto, oldfecha, newasiento, newproyecto, newfecha);
        }
        public void ActualizarDetalleAsientoCambioPeriodo(int oldasiento, int oldproyecto, DateTime oldfecha, int newasiento, int newproyecto, DateTime newfecha)
        {
            cdOrdenPedido.ActualizarDetalleAsientoCambioPeriodo(oldasiento, oldproyecto, oldfecha, newasiento, newproyecto, newfecha);
        }
        public void EliminarAsiento(int codigo, int proyecto, DateTime fecha)
        {
            cdOrdenPedido.EliminarASiento(codigo, proyecto, fecha);
        }
        public void EliminarAsiento(string Cuo, int Empresa, DateTime fechaContable, int reversa)
        {
            cdOrdenPedido.EliminarASiento(Cuo, Empresa, fechaContable, reversa);
        }
        public DataTable VerificarProveedores(string codigo, string razon)
        {
            return cdOrdenPedido.VerificarProveedores(codigo, razon);
        }
        public DataTable VerificarCuentas(string codigo, string nombre)
        {
            return cdOrdenPedido.VerificarCuentas(codigo, nombre);
        }
        public void InsertarCuentasContables(string cuentan1, string codcuenta, string nombre, string tipo, string natu, string generica, string grupo,
           string refleja, string reflejacc, string reflejadebe, string reflejahaber, string cuentacierre, string analitica, string mensual, string cierre,
           string traslacion, string bc, int soli, int cabecera, int estado)
        {
            cdOrdenPedido.InsertarCuentasContables(cuentan1, codcuenta, nombre, tipo, natu, generica, grupo, refleja, reflejacc, reflejadebe, reflejahaber,
                cuentacierre, analitica, mensual, cierre, traslacion, bc, soli, cabecera, estado);
        }
        public void ActualizarCuentasContables(string oldCodCuenta, string codcuenta, string cuentan1, string DesCuentea, string TipoCuenta, string generica, string grupo,
          string refleja, string reflejacc, string reflejadebe, string reflejahaber, string cuentacierre, string analitica, string mensual, string cierre,
          string traslacion, string bc, string naturaleza, int soli, int cabecera, int estado)
        {
            cdOrdenPedido.ActualizarCuentasContables(oldCodCuenta, codcuenta, cuentan1, DesCuentea, TipoCuenta, generica, grupo, refleja, reflejacc, reflejadebe, reflejahaber,
                cuentacierre, analitica, mensual, cierre, traslacion, bc, naturaleza, soli, cabecera, estado);
        }
        public DataRow CuentaContable_EnUso(int opcion, string cuenta)
        {
            return cdOrdenPedido.CuentaContable_EnUso(opcion, cuenta);
        }
        public void InsertarProveedor(int tipoid, string anterior, string ruc, string razon, string nombre, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
           string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int tipoper, int ctaasoles, int ctadolares, int plazo,
           int condicion, int estado, Boolean nuevorus, Boolean retencion, Boolean buencontribuyente, Boolean percepcion)
        {
            cdOrdenPedido.InsertarProveedor(tipoid, anterior, ruc, razon, nombre, sector, dirofi, telofi, diralm, telalm, dirsuc, telsuc, telcon,
             nomcon, emacon, nctasoles, ccisoles, bancosoles, nroctadolares, ccidolares, bancodolares, detrac, tipoper, ctaasoles, ctadolares, plazo,
             condicion, estado, nuevorus, retencion, buencontribuyente, percepcion);
        }
        public DataRow ActualizarProveedor(int tipoid, int anteriortipoid, string anterior, string ruc, string razon, string nombrecomercial, int sector, string dirofi, string telofi, string diralm, string telalm, string dirsuc, string telsuc, string telcon,
           string nomcon, string emacon, string nctasoles, string ccisoles, int bancosoles, string nroctadolares, string ccidolares, int bancodolares, string detrac, int tipoper, int ctaasoles, int ctadolares, int plazofijo
                , int condicion, int estado, Boolean nuevorus, Boolean retencion, Boolean buencontribuyente, Boolean percepcion)
        {
            return cdOrdenPedido.ActualizarProveedor(tipoid, anteriortipoid, anterior, ruc, razon, nombrecomercial, sector, dirofi, telofi, diralm, telalm, dirsuc, telsuc, telcon, nomcon, emacon, nctasoles, ccisoles, bancosoles,
                   nroctadolares, ccidolares, bancodolares, detrac, tipoper, ctaasoles, ctadolares, plazofijo,
                   condicion, estado, nuevorus, retencion, buencontribuyente, percepcion);
        }
        public DataRow EliminarProveedor(int tipoid, string nrodoc)
        {
            return cdOrdenPedido.EliminarProveedor(tipoid, nrodoc);
        }
        public DataRow EliminarCliente(int tipoid, string nrodoc)
        {
            return cdOrdenPedido.EliminarCliente(tipoid, nrodoc);
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
        public void OrdenPedidoCabeceraInsertar(out int Numero, int Usuario, int Tipo, string proyecto, string etapa)
        {
            cdOrdenPedido.OrdenPedidoCabeceraInsertar(out Numero, Usuario, Tipo, proyecto, etapa);
        }

        public void OrdenPedidoDetalleInsertar(int Numero, int Cantidad, int Articulo, int Marca, int Modelo, string Observaciones, int ActivoFijo, int centrocosto)
        {
            cdOrdenPedido.OrdenPedidoDetalleInsertar(Numero, Cantidad, Articulo, Marca, Modelo, Observaciones, ActivoFijo, centrocosto);
        }

        public DataTable ListarPedidos(int TipoArticulo, string Articulo, DateTime Desde, DateTime Hasta, int Usuario, int empresa)
        {
            return cdOrdenPedido.ListarPedidos(TipoArticulo, Articulo, Desde, Hasta, Usuario, empresa);
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
        public DataTable ELiminarCotizacionTotal(int cotizacion)
        {
            return cdOrdenPedido.ELiminarCotizacionTotal(cotizacion);
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

        public void CotizacionCabeceraInsertar(out int Numero, DateTime FechaEntrega, int Tipo, int Usuario, decimal Importe, int Pedido, string Proveedor, byte[] Foto, string NombreArchivo, int moneda)
        {
            cdOrdenPedido.CotizacionCabeceraInsertar(out Numero, FechaEntrega, Tipo, Usuario, Importe, Pedido, Proveedor, Foto, NombreArchivo, moneda);
        }

        public void CotizacionDetalleInsertar(int Cotizacion, int Pedido, int tipo, int cantidad, decimal preciounit, decimal total, string articulo, string marca, string modelo, string observaciones)
        {

            cdOrdenPedido.CotizacionDetalleInsertar(Cotizacion, Pedido, tipo, cantidad, preciounit, total, articulo, marca, modelo, observaciones);
        }

        public DataTable ListarCotizacionesAsociadas(int Pedido)
        {
            return cdOrdenPedido.ListarCotizacionesAsociadas(Pedido);
        }

        public DataTable ListarCotizacionesAsociadasParaAprobar(int Usuario)
        {
            return cdOrdenPedido.ListarCotizacionesAsociadasParaAprobar(Usuario);
        }
        public DataTable BuscarCuentasReflejo(string cuenta, decimal saldodebe, decimal saldohaber)
        {
            return cdOrdenPedido.BuscarCuentasReflejo(cuenta, saldodebe, saldohaber);
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
        public DataTable ListarOCProveedorAprobadas(string Proveedor, int Tipo, int Usuario)
        {
            return cdOrdenPedido.ListarOCProveedorAprobadas(Proveedor, Tipo, Usuario);
        }

        public DataTable ListarArticulosFIC(int OC, int TIPO)
        {
            return cdOrdenPedido.ListarArticulosFIC(OC, TIPO);
        }

        public void FICCabeceraInsertar(out int Numero, int GuiaRemision, int OrdenCompra, int Tipo, int Usuario)
        {
            cdOrdenPedido.FICCabeceraInsertar(out Numero, GuiaRemision, OrdenCompra, Tipo, Usuario);
        }

        public void FICDetalleInsertar(int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo, int Cantidad, string Observaciones, int Tipo, int centrocosto)
        {
            cdOrdenPedido.FICDetalleInsertar(NumeroFIC, CodigoArticulo, CodigoMarca, CodigoModelo, Cantidad, Observaciones, Tipo, centrocosto);
        }

        public DataTable ListarFIC(int OC, int Tipo)
        {
            return cdOrdenPedido.ListarFIC(OC, Tipo);
        }
        public DataTable ListarFIClistar(int OC, int Tipo)
        {
            return cdOrdenPedido.ListarFIClistar(OC, Tipo);
        }
        public DataTable ListarOCFaltantes(string cadena, DateTime fechaini, DateTime fechafin, int articulo, int servicio, int opcion, int fecha)
        {
            return cdOrdenPedido.ListarOCFaltantes(cadena, fechaini, fechafin, articulo, servicio, opcion, fecha);
        }
        public DataTable ListarFIC2(int OC, int FIC, int Tipo)
        {
            return cdOrdenPedido.ListarFIC2(OC, FIC, Tipo);
        }
        public DataTable ListarFIC2listar(int OC, int FIC, int Tipo)
        {
            return cdOrdenPedido.ListarFIC2listar(OC, FIC, Tipo);
        }

        public DataTable ListarFics(int opcion, string proveedor, int guia, int tipo)
        {
            return cdOrdenPedido.ListarFics(opcion, proveedor, guia, tipo);
        }
        public DataRow MaximoValordeUnCampo(string tabla, string campo)
        {
            return cdOrdenPedido.MaximoValordeUnCampo(tabla, campo);
        }
        public DataTable ListarFicsFila(int opcion, string proveedor, string guia, int tipo)
        {
            return cdOrdenPedido.ListarFicsFila(opcion, proveedor, guia, tipo);
        }
        public DataRow BuscarMontoDelasGuias(int opcion, string proveedor, string guia, int tipo)
        {
            return cdOrdenPedido.BuscarMontodelasGuias(opcion, proveedor, guia, tipo);
        }
        public DataRow BuscarFacturas(string ruc, string nrofac)
        {
            return cdOrdenPedido.BuscarFacturas(ruc, nrofac);
        }
        public DataRow BuscarFacturasVentas(string nrofac)
        {
            return cdOrdenPedido.BuscarFacturasVentas("", nrofac);
        }
        public DataTable InsertarAsientoRecibo(int num, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string ruc, string razon, string cod, string numfac, int ccs, DateTime fecha, DateTime fecharecep, DateTime fechavence, int usuario)
        {
            return cdOrdenPedido.InsertarAsientoRecibo(num, opcion, oc, monto, igv, total, cc, ruc, razon, cod, numfac, ccs, fecha, fechavence, fecharecep, usuario);
        }
        public void InsertarFactura(string nrofactura, string proveedor, int fic, int oc, int tipo, decimal subtotal, decimal igv, decimal total, int gravaivg, DateTime fechaemision, DateTime fechaentregado, DateTime fecharecepcion, int estado, int moneda, byte[] imgfactura, int usuario, int nroconstancia, decimal detraccion, int cc)
        {
            cdOrdenPedido.InsertarFactura(nrofactura, proveedor, fic, oc, tipo, subtotal, igv, total, gravaivg, fechaemision, fechaentregado, fecharecepcion, estado, moneda, imgfactura, usuario, nroconstancia, detraccion, cc);
        }
        public DataTable ListarFicsDetalle(string fic)
        {
            return cdOrdenPedido.ListarFicsDetalle(fic);
        }
        public DataTable ListarFicsDetalleservicio(string fic)
        {
            return cdOrdenPedido.ListarFicsDetalleservicio(fic);
        }
        public DataTable ListarGuias(string ruc, int tipo, int opcion, int guia)
        {
            return cdOrdenPedido.ListarGuias(ruc, tipo, opcion, guia);
        }
        public DataRow RUCProveedor(string RUC)
        {
            return cdOrdenPedido.RUCProveedor(RUC);
        }
        public DataTable BusquedaProveedorClienteEmpleado(int tipoid, string numdoc)
        {
            return cdOrdenPedido.BusquedaProveedorClienteEmpleado(tipoid, numdoc);
        }
        public DataRow CargarImagenCotizacion(int Numero)
        {
            return cdOrdenPedido.CargarImagenCotizacion(Numero);
        }
        public DataTable ListarFacturasProveedor(string ruc, string estado, int tipo)
        {
            return cdOrdenPedido.ListarFacturasProveedor(ruc, estado, tipo);
        }
        public DataTable NotaCredito(int opcion, string codnc, string nronc, string nrofac, int tipo, string Proveedor, decimal subtotaln, decimal igv, decimal total, string glosa, int usuario)
        {
            return cdOrdenPedido.NotaCredito(opcion, codnc, nronc, nrofac, tipo, Proveedor, subtotaln, igv, total, glosa, usuario);
        }
        public DataTable NotaCreditoDetalle(int opcion, string codnc, string nronc, string Proveedor, int tipo, int tipocompra, int cantidad, int articulo, int marca, int modelo, decimal precioreg, decimal preciomod, decimal total, int eliminado, int usuario)
        {
            return cdOrdenPedido.NotaCreditoDetalle(opcion, codnc, nronc, Proveedor, tipo, tipocompra, cantidad, articulo, marca, modelo, precioreg, preciomod, total, eliminado, usuario);
        }
        public DataTable NotaCreditoDetalleEliminar(string codnc, string nronc, string Proveedor, int tipo)
        {
            return cdOrdenPedido.NotaCreditoDetalle(10, codnc, nronc, Proveedor, tipo, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
        public DataTable ListarNotaCredito(string CodNumNota, string Proveedor, int tipo)
        {
            return cdOrdenPedido.ListarFacturasProveedor(CodNumNota, Proveedor, tipo);
        }
        public DataTable ListarFacturaProveedorNota(string codnumfac, string ruc, string estado)
        {
            return cdOrdenPedido.ListarFacturaProveedorNota(codnumfac, ruc, estado);
        }
        public DataTable ListarFacturasNotas(string codnumfac, string ruc, string estado)
        {
            return cdOrdenPedido.ListarFacturasNotas(codnumfac, ruc, estado);
        }
        public void CotizacionModificar(int Numero, DateTime FechaEntrega, decimal Importe, string Proveedor, byte[] Foto, string NombreArchivo, int moneda)
        {
            cdOrdenPedido.CotizacionModificar(Numero, FechaEntrega, Importe, Proveedor, Foto, NombreArchivo, moneda);
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

        public void SolicitudEmpleadoInsertar(int Numero, int Cargo, int TipoContratacion, string Busqueda, string AplicaTerna, int Area, int gerencia, int CantPuestos, int NroOrdenCompra, byte[] Foto, string NombreFoto, int Usuario)
        {
            cdOrdenPedido.SolicitudEmpleadoInsertar(Numero, Cargo, TipoContratacion, Busqueda, AplicaTerna, Area, gerencia, CantPuestos, NroOrdenCompra, Foto, NombreFoto, Usuario);
        }
        public DataTable ConsultarCumpleano()
        {
            return cdOrdenPedido.ConsultaRCumples();
        }
        public DataTable ListarSE(int Usuario)
        {
            return cdOrdenPedido.ListarSE(Usuario);
        }
        public DataTable TiposID(int opcion, int codigo, string valor, int leng, string codsunat)
        {
            return cdOrdenPedido.TiposID(opcion, codigo, valor, leng, codsunat);
        }
        public DataTable TiposID(int opcion, int codigo, string valor, int leng)
        {
            return cdOrdenPedido.TiposID(opcion, codigo, valor, leng, "");
        }
        public DataTable TiposID(int codigo)
        {
            return cdOrdenPedido.TiposID(10, codigo, "", 0, "");
        }
        public DataTable TiposID()
        {
            return cdOrdenPedido.TiposID(0, 0, "", 0, "");
        }
        public DataTable EntidadFinanciera(int opcion, int codigo, string valor, string leng)
        {
            return cdOrdenPedido.EntidadFinanciera(opcion, codigo, valor, leng);
        }
        public DataTable EntidadFinanciera()
        {
            return cdOrdenPedido.EntidadFinanciera(0, 0, "", "");
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

        public void PostulanteInsertar(int Tipo_ID_Postulante, string Nro_ID_Postulante, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, int ID_Puesto_Postulante, byte[] Foto, string NombreFoto, int OC, int SE, int Usuario, DateTime fecha)
        {
            cdOrdenPedido.PostulanteInsertar(Tipo_ID_Postulante, Nro_ID_Postulante, Apepat_Postulante, Apemat_Postulante, Nombres_Postulante, ID_Puesto_Postulante, Foto, NombreFoto, OC, SE, Usuario, fecha);
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

        public void EmpleadoInsertar(int pais, string lugar, int Tipo_ID_Emp, string Nro_ID_Emp, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, int Usuario, Byte[] foto, string nombrefoto, byte[] firma, string nombrefirma)
        {
            cdOrdenPedido.EmpleadoInsertar(pais, lugar, Tipo_ID_Emp, Nro_ID_Emp, Apepat_Emp, Apemat_Emp, Nombres_Emp, Sexo, Fec_Nacimiento, Lugar_Nacimiento, Estado_Civil, Hijos, Direccion, Distrito, Provincia, Departamento, Telf_Fijo, Telf_Celular, Profesion, Grado_Instruccion, AntecedentesPoliciales, NombreFotoAntecedentesPoliciales, AntecedentesPenales, NombreFotoAntecedentesPenales, ReciboServicios, NombreFotoReciboServicios, Usuario, foto, nombrefoto, firma, nombrefirma);
        }

        public DataRow DatosPostulante(int Tipo, string Numero)
        {
            return cdOrdenPedido.DatosPostulante(Tipo, Numero);
        }

        public void EmpleadoRequerimiento(int Tipo_ID_Emp, string Nro_ID_Emp, string Correo, string Correo_Obs, string Celular, string Celular_Obs, string Pc, string Pc_Obs, string Otros, string Otros_Obs, int Usuario, int Opcion, string nombre, byte[] foto)
        {
            cdOrdenPedido.EmpleadoRequerimiento(Tipo_ID_Emp, Nro_ID_Emp, Correo, Correo_Obs, Celular, Celular_Obs, Pc, Pc_Obs, Otros, Otros_Obs, Usuario, Opcion, nombre, foto);
        }

        public void EmpleadoCTS(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoCTS(Tipo_ID_Emp, Nro_ID_Emp, Banco, Moneda, Nro_Cta, Nro_Cci, Usuario, Opcion);
        }

        public void EmpleadoPagoHaberes(int Tipo_ID_Emp, string Nro_ID_Emp, int Banco, int Moneda, string Nro_Cta, string Nro_Cci, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoPagoHaberes(Tipo_ID_Emp, Nro_ID_Emp, Banco, Moneda, Nro_Cta, Nro_Cci, Usuario, Opcion);
        }

        public void EmpleadoSeguroPension(int Tipo_ID_Emp, string Nro_ID_Emp, string Eps, int Eps_Adicional, string Sctr, string Onp, string Afp, int Afp_Empresa, string Nro_Cupss, int Usuario, int Opcion, int descuento, decimal descvalor, int aplica, int plann)
        {
            cdOrdenPedido.EmpleadoSeguroPension(Tipo_ID_Emp, Nro_ID_Emp, Eps, Eps_Adicional, Sctr, Onp, Afp, Afp_Empresa, Nro_Cupss, Usuario, Opcion, descuento, descvalor, aplica, plann);
        }

        public DataTable ListarJefeInmediato(int tipo, string documento, int opcion)
        {
            return cdOrdenPedido.ListarJefeInmediato(tipo, documento, opcion);
        }
        public DataTable ListarPerfilActualDelUsuario(int CodigoUser)
        {
            return cdOrdenPedido.ListarJefeInmediato(CodigoUser, "", 100);
        }
        public DataTable ListarPerfiles(int perfiles, int opcion, int codigo, int usuario, DateTime fecha)
        {
            return cdOrdenPedido.ListarPerfiles(perfiles, opcion, codigo, usuario, fecha);
        }
        public void EmpleadoContrato(int numero, int Tipo_ID_Emp, string Nro_ID_Emp, int tipocontra, int adendas, int mercadoobra, int jefe, int Tipo_Contrato, int Cargo, int Gerencia, int Area, int tipojefe, string Jefe_Inmediato, int Empresa, int Proyecto, int Sede, DateTime Fec_Inicio, int Periodo_Laboral, DateTime Fec_Fin, Decimal Sueldo, string Bono, Decimal Bono_Importe, int Bono_Periodicidad, byte[] Contrato_Img, string Contrato, byte[] AnxFunc_Img, string AnxFunc, byte[] SolPrac_Img, string SolPrac, byte[] Otros_Img, string Otros, int Usuario, int Opcion)
        {
            cdOrdenPedido.EmpleadoContrato(numero, Tipo_ID_Emp, Nro_ID_Emp, tipocontra, adendas, mercadoobra, jefe, Tipo_Contrato, Cargo, Gerencia, Area, tipojefe, Jefe_Inmediato, Empresa, Proyecto, Sede, Fec_Inicio, Periodo_Laboral, Fec_Fin, Sueldo, Bono, Bono_Importe, Bono_Periodicidad, Contrato_Img, Contrato, AnxFunc_Img, AnxFunc, SolPrac_Img, SolPrac, Otros_Img, Otros, Usuario, Opcion);
        }

        public void EmpleadoFamilia(int Tipo_ID_Emp, string Nro_ID_Emp, int Vinculo_Familiar, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old, int Tipo_ID_Fam_New, string Nro_ID_Fam_New, string Apepat_Fam, string Apemat_Fam, string Nombres_Fam, DateTime Fec_Nacimiento_Fam, string Ocupacion, int Usuario, int Opcion, byte[] foto, string nombrefoto, int sexo, int estudia)
        {
            cdOrdenPedido.EmpleadoFamilia(Tipo_ID_Emp, Nro_ID_Emp, Vinculo_Familiar, Tipo_ID_Fam_Old, Nro_ID_Fam_Old, Tipo_ID_Fam_New, Nro_ID_Fam_New, Apepat_Fam, Apemat_Fam, Nombres_Fam, Fec_Nacimiento_Fam, Ocupacion, Usuario, Opcion, foto, nombrefoto, sexo, estudia);
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

        public void PostulanteModificar(int Tipo_ID_Postulante_Old, string Nro_ID_Postulante_Old, int Tipo_ID_Postulante_New, string Nro_ID_Postulante_New, string Apepat_Postulante, string Apemat_Postulante, string Nombres_Postulante, byte[] Foto, string NombreFoto, int Id_SolicitaEmpleado, DateTime fecnacimiento)
        {
            cdOrdenPedido.PostulanteModificar(Tipo_ID_Postulante_Old, Nro_ID_Postulante_Old, Tipo_ID_Postulante_New, Nro_ID_Postulante_New, Apepat_Postulante, Apemat_Postulante, Nombres_Postulante, Foto, NombreFoto, Id_SolicitaEmpleado, fecnacimiento);
        }

        public DataTable ListarEmpleado(int Opcion, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int tipo, string doc, int pos)
        {
            return cdOrdenPedido.ListarEmpleado(Opcion, Apepat_Emp, Apemat_Emp, Nombres_Emp, tipo, doc, pos);
        }

        public void EmpleadoModificar(int pais, string lugar, int Tipo_ID_Emp_New, string Nro_ID_Emp_New, int Tipo_ID_Emp_Old, string Nro_ID_Emp_Old, string Apepat_Emp, string Apemat_Emp, string Nombres_Emp, int Sexo, DateTime Fec_Nacimiento, int Lugar_Nacimiento, int Estado_Civil, int Hijos, string Direccion, int Distrito, int Provincia, int Departamento, string Telf_Fijo, string Telf_Celular, int Profesion, int Grado_Instruccion, byte[] AntecedentesPoliciales, string NombreFotoAntecedentesPoliciales, byte[] AntecedentesPenales, string NombreFotoAntecedentesPenales, byte[] ReciboServicios, string NombreFotoReciboServicios, byte[] foto, string nombrefoto, byte[] firma, string nombrefirma)
        {
            cdOrdenPedido.EmpleadoModificar(pais, lugar, Tipo_ID_Emp_New, Nro_ID_Emp_New, Tipo_ID_Emp_Old, Nro_ID_Emp_Old, Apepat_Emp, Apemat_Emp, Nombres_Emp, Sexo, Fec_Nacimiento, Lugar_Nacimiento, Estado_Civil, Hijos, Direccion, Distrito, Provincia, Departamento, Telf_Fijo, Telf_Celular, Profesion, Grado_Instruccion, AntecedentesPoliciales, NombreFotoAntecedentesPoliciales, AntecedentesPenales, NombreFotoAntecedentesPenales, ReciboServicios, NombreFotoReciboServicios, foto, nombrefoto, firma, nombrefirma);
        }

        public void ActualizarLogin(string sStoredProcedureName, string Login_User, int Opcion)
        {
            cdOrdenPedido.ActualizarLogin(sStoredProcedureName, Login_User, Opcion);
        }

        public DataRow Loguearse(string Login_User, int Opcion)
        {
            return cdOrdenPedido.Loguearse(Login_User, Opcion);
        }
        public DataTable UsuarioConectado(int codigo, string user, int opcion)
        {
            return cdOrdenPedido.UsuarioConectado(codigo, user, opcion);
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

        public DataRow NextValorizacion(int numero)
        {
            return cdOrdenPedido.NextValorizacion(numero);
        }

        public void EliminarSolicitudEmpleado(int Solicitud)
        {
            cdOrdenPedido.EliminarSolicitudEmpleado(Solicitud);
        }

        public DataTable CualquierTabla(string Tabla)
        {
            return cdOrdenPedido.CualquierTabla(Tabla);
        }
        public DataTable CualquierTabla(string Tabla, string campo, string fila)
        {
            return cdOrdenPedido.CualquierTabla(Tabla, campo, fila);
        }
        public DataRow Correlativo(string Tabla)
        {
            return cdOrdenPedido.Correlativo(Tabla);
        }
        public DataRow CorrelativoCampo(string Tabla, string campo)
        {
            return cdOrdenPedido.CorrelativoCampo(Tabla, campo);
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
        public DataRow UltimoRegistoVacaciones(int tipo, string doc)
        {
            return cdOrdenPedido.UltimoRegistoVacaciones(tipo, doc);
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

        public void ComprarVacaciones(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Desde, DateTime Hasta, int Dias_Pendiente, decimal Monto_Propuesto, decimal Monto_Pactado, int usuario, int pago, string observacion)
        {
            cdOrdenPedido.ComprarVacaciones(Tipo_ID_Emp, Nro_ID_Emp, Desde, Hasta, Dias_Pendiente, Monto_Propuesto, Monto_Pactado, usuario, pago, observacion);
        }

        public void EmpleadoFaltas(int Tipo_ID_Emp, string Nro_ID_Emp, DateTime Fec_Inicio, DateTime Fec_Fin, int Dias, string Observaciones, byte[] Foto, string NombreFoto, int estado)
        {
            cdOrdenPedido.EmpleadoFaltas(Tipo_ID_Emp, Nro_ID_Emp, Fec_Inicio, Fec_Fin, Dias, Observaciones, Foto, NombreFoto, estado);
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

        public DataTable OrdenCompraProveedor(string Proveedor, int GuiaRemision, int ordencompra, int tipo)
        {
            return cdOrdenPedido.OrdenCompraProveedor(Proveedor, GuiaRemision, ordencompra, tipo);
        }

        public DataTable ListarFicModificar(int NumeroFIC)
        {
            return cdOrdenPedido.ListarFicModificar(NumeroFIC);
        }

        public DataTable ListarSinOCProveedor(string Proveedor, int Tipo, int Usuario, int OC)
        {
            return cdOrdenPedido.ListarSinOCProveedor(Proveedor, Tipo, Usuario, OC);
        }

        public void FICModificarCabecera(int Numero, DateTime Fecha, int GuiaRemision)
        {
            cdOrdenPedido.FICModificarCabecera(Numero, Fecha, GuiaRemision);
        }

        public void FICEliminarItemDetalle(int Id_FIC_Detalle, int NumeroFIC, int CodigoArticulo, int CodigoMarca, int CodigoModelo)
        {
            cdOrdenPedido.FICEliminarItemDetalle(Id_FIC_Detalle, NumeroFIC, CodigoArticulo, CodigoMarca, CodigoModelo);
        }

        public void EmpleadoDesvinculacionInsertar(int Tipo_ID_Emp, string Nro_ID_Emp, byte[] Foto, string Ruta, int Opcion, DateTime fechacese, int usuario, out int respuesta)
        {
            cdOrdenPedido.EmpleadoDesvinculacionInsertar(Tipo_ID_Emp, Nro_ID_Emp, Foto, Ruta, Opcion, fechacese, usuario, out respuesta);
        }
        public DataRow ListarContrato(int tipo, string documento, DateTime fecha)
        {
            return cdOrdenPedido.ListarContrato(tipo, documento, fecha);

        }
        public DataRow ListarDesvinculaciones(int tipo, string documento, int contrato)
        {
            return cdOrdenPedido.ListarDesvinculaciones(tipo, documento, contrato);
        }
        public DataTable ListarDesvinculacionContrato(int tipo, string documento)
        {
            return cdOrdenPedido.ListarDesvinculacionContrato(tipo, documento);
        }
        public DataRow ContratoActivo(int tipo, string documento, DateTime fecha)
        {
            return cdOrdenPedido.ContratoActivo(tipo, documento, fecha);
        }
        public DataRow ContratoActivo_oTiene(int tipo, string documento, DateTime fecha)
        {
            return cdOrdenPedido.ContratoActivo_oTiene(tipo, documento, fecha);
        }
        public DataTable ReportedeOp(int opcion, int articulo, int servicio, int fecha, DateTime fechaini, DateTime fechafin, int anulado, int registrado, int cotizado, int cotizadocompleto, int cotizacooc, string busca)
        {
            return cdOrdenPedido.ReportedeOp(opcion, articulo, servicio, fecha, fechaini, fechafin, anulado, registrado, cotizado, cotizadocompleto, cotizacooc, busca);
        }
        public DataTable reportepedidodetalle(int opcion, int orden)
        {
            return cdOrdenPedido.reportepedidodetalle(opcion, orden);
        }
        public DataTable ReportedeOC(int opcion, int articulo, int servicio, int fecha, DateTime fechaini, DateTime fechafin, int anulado, int registrado, int entregadoincompleto, int cotizado, int cotizadocompleto, int cotizacooc, string busca, int importe, decimal minimo, decimal maximo)
        {
            return cdOrdenPedido.ReportedeOC(opcion, articulo, servicio, fecha, fechaini, fechafin, anulado, registrado, entregadoincompleto, cotizado, cotizadocompleto, cotizacooc, busca, importe, minimo, maximo);

        }
        public DataTable Reporteempleados(int opcion, int opciones, string buscar, int dni, int carnet, int pasa, int cedula, int ruc, int practicas, int planillaempleado,
           int planillaobrero, int recibo, int sueldo, decimal minimo, decimal maximo, int fecha, DateTime fechaini, DateTime fechafinal, int banco, string codbanco)
        {
            return cdOrdenPedido.Reporteempleados(opcion, opciones, buscar, dni, carnet, pasa, cedula, ruc, practicas, planillaempleado, planillaobrero, recibo, sueldo, minimo, maximo, fecha, fechaini, fechafinal, banco, codbanco);
        }
        public DataTable ListarBancosCts()
        {
            return cdOrdenPedido.ListarBancosCts();
        }
        public DataTable ExportarRequerimientos(string documento, string tipo)
        {
            return cdOrdenPedido.ExportarRequerimientos(documento, tipo);
        }
        public DataTable ListarPedidoProveedor(int pedido, string proveedor)
        {
            return cdOrdenPedido.ListarPedidoProveedor(pedido, proveedor);
        }
        public DataRow LocacionServicios(string contrato, string tipoid, string numero, int opcion, string ocupacion, string detalle)
        {
            return cdOrdenPedido.LocacionServicios(contrato, tipoid, numero, opcion, ocupacion, detalle);
        }
        public DataTable InstitucionEducativa(string ruc, string razon, string direccion, int opcion, int busca)
        {
            return cdOrdenPedido.InstitucionEducativa(ruc, razon, direccion, opcion, busca);
        }
        public DataTable PracticasPreProfesionales(string contrato, string tipoid, string numero, int opcion, string ruc, string representante, string tipoidrepre, string docrepre, string situacion,
            string especialidad, string ocupacion, string dias, string horario)
        {
            return cdOrdenPedido.PracticasPreProfesionales(contrato, tipoid, numero, opcion, ruc, representante, tipoidrepre, docrepre, situacion, especialidad, ocupacion, dias, horario);
        }
        public DataTable ListarPaises()
        {
            return cdOrdenPedido.ListarPaises();
        }
        public DataTable ListarCentrosdeCosto(int codigo, int centro, string busca)
        {
            return cdOrdenPedido.ListarCentrosdeCosto(codigo, centro, busca);
        }
        public DataTable ListarCuentasArticulos()
        {
            return cdOrdenPedido.ListarCuentasArticulos();
        }
        public DataTable ListarCentroCostoTieneCuenta()
        {
            return cdOrdenPedido.ListarCentroCostoTieneCuenta();
        }
        public DataTable ListarCentroCostos()
        {
            return cdOrdenPedido.ListarCentroCostos();
        }
        public DataTable ListarProyectosUsuario(int usuario)
        {
            return cdOrdenPedido.ListarProyectosUsuario(usuario);
        }
        public DataTable ListarEtapasProyecto(string proyecto)
        {
            return cdOrdenPedido.ListarEtapasProyecto(proyecto);
        }
        public DataRow ListarEmpresasdelUsuario(int usuario)
        {
            return cdOrdenPedido.ListarEmpresasdelUsuario(usuario);
        }
        public DataTable ListarProyectosEmpresa(string empresa)
        {
            //Id_Proyecto Proyecto    Id_Empresa
            return cdOrdenPedido.ListarProyectosEmpresa(empresa);
        }
        public DataTable ListarProyectosEmpresa(string empresa, int cabecera)
        {
            return cdOrdenPedido.ListarProyectosEmpresa(empresa, cabecera);
        }
        public DataTable Proyectos(string proyectos, int empresa, int idproyecto, int opcion)
        {
            return cdOrdenPedido.Proyectos(proyectos, empresa, idproyecto, opcion);
        }
        public DataRow EmpleadoConviviente(string numero, int tipo, byte[] imagen, string nombre, int opcion)
        {
            return cdOrdenPedido.EmpleadoConviviente(numero, tipo, imagen, nombre, opcion);
        }
        public DataTable Proyectodatos(int proyecto, string @ubicacion, int @moneda, string @areabruta, string @precioxmetro, string @preciototal, string @autoavaluo, string @revaluacuion, string @vigilancia, string @marketing, string @ventas, string @administracion, string @gerenciamiento, string @cdap, string @finder, string @costosuper, string @comision, string @comisionext, string @ceremonia, string @regaloxdpto, string @manteminion, string @atencion, string @costoprevio, string @gestioncomuni, string @porcentajecredito, string @costofianza, string @imprevisto)
        {
            return cdOrdenPedido.Proyectodatos(proyecto, @ubicacion, @moneda, @areabruta, @precioxmetro, @preciototal, @autoavaluo, @revaluacuion, @vigilancia, @marketing, @ventas, @administracion, @gerenciamiento, @cdap, @finder, @costosuper, @comision, @comisionext, @ceremonia, @regaloxdpto, @manteminion, @atencion, @costoprevio, @gestioncomuni, @porcentajecredito, @costofianza, @imprevisto);
        }
        public DataRow ProyectodatosListar(int proyecto)
        {
            return cdOrdenPedido.ProyectodatosListar(proyecto);
        }
        public DataTable ListarPresupuestosCabecera()
        {
            return cdOrdenPedido.ListarPresupuestosCabecera();
        }
        public DataTable PresupuestoCabecera(int opcion, int @numero, string @presupuesto, int @ejercicio, int @empresa, int @tipo, int @moneda, decimal @importe, int @usuario)
        {
            return cdOrdenPedido.PresupuestoCabecera(opcion, @numero, @presupuesto, @ejercicio, @empresa, @tipo, @moneda, @importe, @usuario);
        }
        public DataTable ListarPresupuestoCentrodeCosto(int cabecera, int proyecto)
        {
            return cdOrdenPedido.ListarPresupuestoCentrodeCosto(cabecera, proyecto);
        }
        public DataTable ProyectoCentrodecostodetalle(int @opcion, int @iddep, int @presupuesto, int @proyecto, int etapa, decimal @importe, string @ceco, decimal @importececo, decimal @importeflujo, int @usuario)
        {
            return cdOrdenPedido.ProyectoCentrodecostodetalle(@opcion, @iddep, @presupuesto, @proyecto, etapa, @importe, @ceco, @importececo, @importeflujo, @usuario);
        }
        public DataTable InsertarAsientoFactura(int num, int nextasiento, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string ruc, string razon, string codfac, string numfac, int ccs, DateTime fecha, DateTime fechaRecepcion, DateTime FechaVence, int usuario, int moneda)
        {
            return cdOrdenPedido.InsertarAsientoFactura(num, nextasiento, opcion, oc, monto, igv, total, cc, ruc, razon, codfac, numfac, ccs, fecha, FechaVence, fechaRecepcion, usuario, moneda);
        }
        public DataTable InsertarAsientoFacturaLlegada(int num, int empresa, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string numfac, int moneda)
        {
            return cdOrdenPedido.InsertarAsientoFacturaLlegada(num, empresa, opcion, oc, monto, igv, total, cc, numfac, moneda);
        }
        public DataTable InsertarAsientoFacturaProvisionada(int num, int opcion, int oc, decimal monto, decimal igv, decimal total, string cc, string numfac)
        {
            return cdOrdenPedido.InsertarAsientoFacturaProvisionada(num, opcion, oc, monto, igv, total, cc, numfac);
        }
        public DataTable RegistrarDetraccion(int asiento, int empresa, decimal monto)
        {
            return cdOrdenPedido.RegistrarDetraccion(asiento, empresa, monto);
        }
        public DataRow Siguiente(string tabla, string campo)
        {
            return cdOrdenPedido.Siguiente(tabla, campo);
        }
        public DataRow SiguienteAsientoxOrdenCompra(int num)
        {
            return cdOrdenPedido.SiguienteAsientoxOrdenCompra(num);
        }
        public DataTable ListarPresupuestoCentrodeCostoReporte(int proyecto, int @cabecera)
        {
            return cdOrdenPedido.ListarPresupuestoCentrodeCostoReporte(proyecto, @cabecera);
        }
        public DataTable ListarFLujosCentrodeCostoReporte(int proyecto, int @cabecera)
        {
            return cdOrdenPedido.ListarFLujosCentrodeCostoReporte(proyecto, @cabecera);
        }
        public DataTable ListarPresupuestoCentrodeCostoReporteVerCuentas(int proyecto)
        {
            return cdOrdenPedido.ListarPresupuestoCentrodeCostoReporteVerCuentas(proyecto);
        }
        public DataTable ListarPresupuestoCentrodeCostoReporteCuentas(int proyecto, string cuentas)
        {
            return cdOrdenPedido.ListarPresupuestoCentrodeCostoReporteCuentas(proyecto, cuentas);
        }
        public DataTable ListarEtapasdelProyecto(int opcion, int proyecto, int etapa, string descripcion, int estado, DateTime fechainicio, DateTime fechafin, int meses, string observa, int usuario)
        {
            return cdOrdenPedido.ListarEtapasdelProyecto(opcion, proyecto, etapa, descripcion, estado, fechainicio, fechafin, meses, observa, usuario);
        }
        public DataRow BuscarParametros(string valor, DateTime fecha)
        {
            return cdOrdenPedido.BuscarParametros(valor, fecha);
        }
        public DataTable MesEtapa(int @opcion, int @idmes, int @fketapa, int @anio, int @mes, int @usuario)
        {
            return cdOrdenPedido.MesEtapa(@opcion, @idmes, @fketapa, @anio, @mes, @usuario);
        }
        public DataTable ListarPptoEmpresas(int empresas)
        {
            return cdOrdenPedido.ListarPptoEmpresas(empresas);
        }
        public DataTable MesEtapaProyecto(int etapa)
        {
            return cdOrdenPedido.MesEtapaProyecto(etapa);
        }
        public DataTable MesEtapaCentroCosto(int @opcion, int @etapa, int @idmesetapa, string @ceco, decimal @monto, decimal flujo, int @cabecera, int @usuario)
        {
            return cdOrdenPedido.MesEtapaCentroCosto(@opcion, @etapa, @idmesetapa, @ceco, @monto, flujo, @cabecera, @usuario);
        }
        public DataTable ListarReporteCuentaCosto(int etapa, string cc)
        {
            return cdOrdenPedido.ListarReporteCuentaCosto(etapa, cc);
        }
        public DataTable ListarReporteCuentaCostoFlujo(int etapa, string cc)
        {
            return cdOrdenPedido.ListarReporteCuentaCostoFlujo(etapa, cc);
        }
        public DataTable ListarBancosTiposdePago(string banco)
        {
            return cdOrdenPedido.ListarBancosTiposdePago(banco);
        }
        public DataTable ListarBancosTiposdePagoxEmpresa(string banco, int empresa)
        {
            return cdOrdenPedido.ListarBancosTiposdePagoxEmpresa(banco, empresa);
        }
        public DataTable DepositoaPlazo()
        {
            return cdOrdenPedido.DepositoaPlazo();
        }
        public DataTable CertificadosBancarios()
        {
            return cdOrdenPedido.CertificadosBancarios();
        }
        public DataTable ListarFacturasPorPagar(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado)
        {
            return cdOrdenPedido.ListarFacturasPorPagar(proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado);
        }
        public DataTable ListarFacturasPorPagarxEmpresa(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado, int empresa)
        {
            return cdOrdenPedido.ListarFacturasPorPagarxEmpresa(proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado, empresa);
        }
        public DataTable ListarFacturasPagadosxEmpresa(int proveedor, string busca, int fecha, DateTime fechaini, DateTime fechafin, int recepcion, DateTime fechaini1, DateTime fechafin1, int estado, int empresa)
        {
            return cdOrdenPedido.ListarFacturasPagadosxEmpresa(proveedor, busca, fecha, fechaini, fechafin, recepcion, fechaini1, fechafin1, estado, empresa);
        }
        public DataTable insertarPagarfactura(string nrofactura, string proveedor, int tipo, string nropago, decimal apagar, decimal subtotal, decimal igv, decimal total, int usuario, int opcion, int banco, string nrocuenta, DateTime fechapago, int @idcomprobante)
        {
            return cdOrdenPedido.insertarPagarfactura(nrofactura, proveedor, tipo, nropago, apagar, subtotal, igv, total, usuario, opcion, banco, nrocuenta, fechapago, @idcomprobante);
        }
        public DataTable guardarfactura(int si, int asiento, string @fac, string @cc, decimal @debe, decimal @haber, int dina, DateTime fecha, DateTime? fechavence, DateTime? fecharecepcion, int usuario, int centro, string tipo, string proveedor, int moneda, string idcuenta, string nropago
            , decimal tcReg, decimal tcPago, DateTime fechasiento, decimal montodiferencial, int PosicionDiferencial, decimal TotalDiferencial, int IdComprobante, DateTime @FechaContable)
        {
            return cdOrdenPedido.guardarfactura(si, asiento, fac, @cc, @debe, @haber, dina, fecha, fechavence, fecharecepcion, usuario, centro, tipo, proveedor, moneda, idcuenta, nropago, tcReg, tcPago,
                fechasiento, montodiferencial, PosicionDiferencial, TotalDiferencial, IdComprobante, @FechaContable);
        }
        public DataTable ActualizarNotaCreditoDebito(string proveedor, string numdoc, int @opcion, int empresa)
        {
            return cdOrdenPedido.ActualizarNotaCreditoDebito(proveedor, numdoc, @opcion, empresa);
        }
        public DataTable ValidarChequeExiste(string banco, string cuenta, string cheque)
        {
            return cdOrdenPedido.ValidarChequeExiste(banco, cuenta, cheque);
        }
        public DataTable EstadodeGanaciasPerdidas(DateTime año, int empresa)
        {
            return cdOrdenPedido.EstadodeGanaciasPerdidas(año, empresa);
        }
        public DataTable SacarResultadoEjercicio(DateTime año, int empresa)
        {
            return cdOrdenPedido.SacarResultadoEjercicio(año, empresa);
        }
        public DataTable FLujodeCaja(DateTime fechaini, DateTime fechafin, string nombre, int empresa, int tamañoletras)
        {
            return cdOrdenPedido.FLujodeCaja(fechaini, fechafin, nombre, empresa, tamañoletras);
        }
        public DataTable BalanceGenerarlActivoCorriente(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGenerarlActivoCorriente(año, empresa);
        }
        public DataTable BalanceGeneral(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGeneral(año, empresa);
        }
        public DataTable BalanceGenerarlActivonoCorriente(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGenerarlActivonoCorriente(año, empresa);
        }
        public DataTable BalanceGeneralPatrimonio(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGeneralPatrimonio(año, empresa);
        }
        public DataTable BalanceGeneralActivoPasivoCorriente(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGeneralActivoPasivoCorriente(año, empresa);
        }
        public DataTable BalanceGeneralActivoPasivonoCorriente(DateTime año, int empresa)
        {
            return cdOrdenPedido.BalanceGeneralActivoPasivonoCorriente(año, empresa);
        }
        public DataTable ListarFacturasSinPagar(string buscar, int factura, int provee, int check, string tipo, int fecha, DateTime fechainicio, DateTime fechafin)
        {
            return cdOrdenPedido.ListarFacturasSinPagar(buscar, factura, provee, check, tipo, fecha, fechainicio, fechafin);
        }
        public DataTable ListarFicSinFactura(string buscar, int factura, int provee, int check, string tipo)
        {
            return cdOrdenPedido.ListarFicSinFactura(buscar, factura, provee, check, tipo);
        }
        public DataTable EliminarItemOrdenPedido(int pedido, int item)
        {
            return cdOrdenPedido.EliminarItemOrdenPedido(pedido, item);

        }
        public DataTable ListarFaltantesCotizacion(int cotizacion)
        {
            return cdOrdenPedido.ListarFaltantesCotizacion(cotizacion);
        }
        public DataRow ListarGravaIgvOrdenCompra(int orden)
        {
            return cdOrdenPedido.ListarGravaIgvOrdenCompra(orden);
        }
        public DataRow VerMaximoPresupuesto(int cabecera)
        {
            return cdOrdenPedido.VerMaximoPresupuesto(cabecera);
        }
        public DataTable listar_Detalle_Cotizacion(int pedido, string proveedor)
        {
            return cdOrdenPedido.listar_Detalle_Cotizacion(pedido, proveedor);
        }
        public DataRow ActualizarCotizacionDetalle(int cod, decimal valor, decimal total)
        {
            return cdOrdenPedido.ActualizarCotizacionDetalle(cod, valor, total);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCosto(int etapa, string ceco, string cuenta, int cabecera)
        {
            return cdOrdenPedido.ListarDetalleDelReporteDeCentrodeCosto(etapa, ceco, cuenta, cabecera);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFLujos(int etapa, string ceco, string cuenta, int cabecera)
        {
            return cdOrdenPedido.ListarDetalleDelReporteDeCentrodeCostoFLujos(etapa, ceco, cuenta, cabecera);
        }
        public DataRow VerUltimoIdentificador(string tabla, string campo)
        {
            return cdOrdenPedido.VerUltimoIdentificador(tabla, campo);
        }

        public DataTable InsertarActualizarCargo(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarCargo(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarEmpresaEps(int @cod, int @opcion, string @cargo, int @usuario, decimal beneficiario, decimal adicional1, decimal adicional2, decimal adicional3, Boolean activo)
        {
            return cdOrdenPedido.InsertarActualizarEmpresaEps(cod, opcion, cargo, usuario, beneficiario, adicional1, adicional2, adicional3, activo);
        }
        public DataTable InsertarActualizarEmpresaEpsPLanes(int @cod, int codplan, int @opcion, int CodEps, string @cargo, int @usuario, decimal monto)
        {
            return cdOrdenPedido.InsertarActualizarEmpresaEpsPLanes(cod, codplan, CodEps, opcion, cargo, usuario, monto);
        }
        public DataTable ReversaDeFacturas(string nrofac, string proveedor)
        {
            return cdOrdenPedido.ReversaDeFacturas(nrofac, proveedor);
        }
        public DataTable PLanesdelaEmpresa()
        {
            return cdOrdenPedido.PLanesdelaEmpresa();
        }
        public DataTable PLanes(int opcion, int cod, int empresa, string plan)
        {
            return cdOrdenPedido.PLanes(opcion, cod, empresa, plan);
        }
        public DataTable InsertarActualizarEpsAdicional(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarEpsAdicional(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarEstadoCivil(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarEstadoCivil(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarGradoInstruccion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarGradoInstruccion(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarMoneda(int @cod, int @opcion, string @cargo, int @usuario, string names)
        {
            return cdOrdenPedido.InsertarActualizarMoneda(cod, opcion, cargo, usuario, names);
        }
        public DataTable InsertarActualizarMoneda()
        {
            return cdOrdenPedido.InsertarActualizarMoneda(0, 0, "", 0, "");
        }
        public DataTable InsertarActualizarPeriodicidad(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarPeriodicidad(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarProfesion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarProfesion(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarSector_Empresarial(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarSector_Empresarial(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarSede(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarSede(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarSexo(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarSexo(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarTipoContratacion(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarTipoContratacion(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarTipoContrato(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarTipoContrato(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarVinculoFamiliar(int @cod, int @opcion, string @cargo, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarVinculoFamiliar(cod, opcion, cargo, usuario);
        }
        public DataTable InsertarActualizarListarAfp(int @cod, int @opcion, string descripcion, decimal aporte, decimal seguro, decimal comision, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarListarAfp(cod, opcion, descripcion, aporte, seguro, comision, usuario);
        }
        public DataTable InsertarActualizarListarInstitucionEducativa(string @cod, int @opcion, string descripcion, string direccion, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarListarInstitucionEducativa(cod, opcion, descripcion, direccion, usuario);
        }
        public DataTable InsertarActualizarListarPais(string @cod, int @opcion, string campo1, string campo2, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarListarPais(cod, opcion, campo1, campo2, usuario);
        }
        public DataTable InsertarActualizarListarOperacion(string @cod, int @opcion, string campo1, string campo2, int @usuario)
        {
            return cdOrdenPedido.InsertarActualizarListarOperacion(cod, opcion, campo1, campo2, usuario);
        }
        public DataTable InsertarActualizarListarSubOperacion(string @cod, int @opcion, string campo1, string campo2, string campo3, int @usuario, int cod2)
        {
            return cdOrdenPedido.InsertarActualizarListarSubOperacion(cod, opcion, campo1, campo2, campo3, usuario, cod2);
        }
        public DataTable InsertarActualizarListarEmpresas(string @id, int @opcion, string @campo1, string @campo2, int @sector, string @direccion, int @dep, int @prov, int @dis, int @tipo, string @repre, int @cia, int usuario)
        {
            return cdOrdenPedido.InsertarActualizarListarEmpresas(@id, @opcion, @campo1, @campo2, @sector, @direccion, @dep, @prov, @dis, @tipo, @repre, @cia, usuario);
        }
        public DataTable ListarEmpresas()
        {
            //id_empresa    empresa
            return cdOrdenPedido.InsertarActualizarListarEmpresas("", 0, "", "", 0, "", 0, 0, 0, 0, "", 0, 0);
        }
        public void TablaComprobantes(ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "id_comprobante";
            combo.DataSource = ComprobanteDePago();
        }
        public void TablaComprobantesConCodigo(ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "id_comprobante";
            combo.DataSource = ComprobanteDePagoConCodigo();
        }
        public void TablaEmpresas(ComboBox combo)
        {
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = Empresa();
            combo.Click += ComboEmpresa_Click;
        }
        public void TablaEmpresa(ComboBox combo)
        {
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = Empresa();
        }
        private void ComboEmpresa_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaEmpresas(combo);
            combo.Text = cadena;
        }

        public void TablaMonedas(ComboBox combo)
        {
            ////codigo  descripcion
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = Moneda();
            combo.Click += ComboMoneda_Click;
        }
        public void TablaMoneda(ComboBox combo)
        {
            ////codigo  descripcion
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = Moneda();
        }
        private void ComboMoneda_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaMonedas(combo);
            combo.Text = cadena;
        }
        public void TablaTipoCuentas(ComboBox combo)
        {
            ////codigo  descripcion
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = cdOrdenPedido.getCargoTipoContratacion2("id_tipo_cta", "descripcion", "TBL_Tipo_CtaBancaria");
            combo.Click += ComboTipoCuentas_Click;
        }
        private void ComboTipoCuentas_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaTipoCuentas(combo);
            combo.Text = cadena;
        }
        public void TablaBancos(ComboBox combo)
        {
            ////codigo  descripcion
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "codigo";
            combo.DataSource = EntidadFinanciera();
            combo.Click += ComboBancos_Click;
        }
        private void ComboBancos_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaBancos(combo);
            combo.Text = cadena;
        }
        public void TablaTipoId(ComboBox combito)
        {
            ///codigo    valor  leng    cod_sunat
            combito.DisplayMember = "valor";
            combito.ValueMember = "codigo";
            combito.DataSource = TiposID();
            combito.Click += CombitoTipoId_Click;
        }
        public void TablaTipoID(ComboBox combito)
        {
            ///codigo    valor  leng    cod_sunat
            combito.DisplayMember = "valor";
            combito.ValueMember = "codigo";
            combito.DataSource = TiposID();
        }
        private void CombitoTipoId_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaTipoId(combo);
            combo.Text = cadena;
        }
        public void TablaDetracciones(ComboBox combo)
        {
            combo.DisplayMember = "Desc_Detraccion";
            combo.ValueMember = "Id_Detraccion";
            combo.DataSource = Detracciones();
            combo.Click += ComboDetracciones_Click;
        }
        private void ComboDetracciones_Click(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string cadena = combo.Text;
            TablaDetracciones(combo);
            combo.Text = cadena;
        }
        public DataTable Detracciones()
        {
            return DetraccionesFiltrar("", "", "");
        }
        public DataTable Moneda()
        {
            return cdOrdenPedido.getCargoTipoContratacion("Id_Moneda", "Moneda", "TBL_Moneda");
        }
        public DataTable Empresa()
        {
            return cdOrdenPedido.getCargoTipoContratacion("id_empresa", "empresa", "TBL_Empresa");
        }
        public DataTable BuscarEmpleadoActivo()
        {
            return cdOrdenPedido.BuscarEmpleadoActivo();
        }
        public DataTable ActualizarParametros(int @opcion, string @campo, decimal valor, string observa, int usuario, DateTime fecha)
        {
            return cdOrdenPedido.ActualizarParametros(opcion, campo, valor, observa, usuario, fecha);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFecha(int etapa, int cuenta, DateTime fecha)
        {
            return cdOrdenPedido.ListarDetalleDelReporteDeCentrodeCostoFecha(etapa, cuenta, fecha);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFechaFacturas(int etapa, int cuenta, DateTime fecha)
        {
            return cdOrdenPedido.ListarDetalleDelReporteDeCentrodeCostoFechaFacturas(etapa, cuenta, fecha);
        }
        public DataTable ListarDetalleDelReporteDeCentrodeCostoFechaFlujoFacturas(int etapa, int cuenta, DateTime fecha)
        {
            return cdOrdenPedido.ListarDetalleDelReporteDeCentrodeCostoFechaFlujoFacturas(etapa, cuenta, fecha);
        }
        public DataTable ListarCotizacionesPorNumero(int numero)
        {
            return cdOrdenPedido.ListarCotizacionesPorNumero(numero);
        }
        public DataTable InsertarActualizarImpuestoRenta(int opcion, int codigo, string descripcion, decimal minimo, decimal maximo, decimal valor, string observacion, int usuario)
        {
            return cdOrdenPedido.InsertarActualizarImpuestoRenta(opcion, codigo, descripcion, minimo, maximo, valor, observacion, usuario);
        }
        public DataTable BuscarPaisActual(string pais)
        {
            return cdOrdenPedido.BuscarPaisActual(pais);
        }
        public DataTable EliminarFactura(int fic, int estado)
        {
            return cdOrdenPedido.EliminarFactura(fic, estado);
        }
        /// <summary>
        /// Listar Empleados Desvinculados
        /// </summary>
        /// <returns>Regresa una tabla</returns>
        public DataTable ListarEmpleadosDesvinculados()
        {
            return cdOrdenPedido.ListarEmpleadosDesvinculados();
        }
        public DataTable ActualizarBoletas(int tipo, string doc, DateTime fecha, int estado)
        {
            return cdOrdenPedido.ActualizarBoletas(tipo, doc, fecha, estado);
        }
        public DataTable BuscarCuentasBancoPagar(string banco, string cuenta)
        {
            return cdOrdenPedido.BuscarCuentasBancoPagar(banco, cuenta);
        }
        public DataTable BuscarCuentasBancoPagarBoletas(string banco, string cuenta)
        {
            return cdOrdenPedido.BuscarCuentasBancoPagarBoletas(banco, cuenta);
        }
        public DataTable ListarComisionesEmpleado(int codigo, int contrato)
        {
            return cdOrdenPedido.ListarComisionesEmpleado(codigo, contrato);
        }
        public DataTable EmpleadoComision(int opcion, int codigo, int contrato, int comisiones, decimal comiporcentaje, string comiperiodo, int destaque, decimal valordestaque, string periododestaque, int produccion, decimal importepro, decimal porcentajepro, string periodopro,
           byte[] imagenpro, string nombreimagenpro, int regular, decimal impregular, int movilidad, decimal impmovilidad, string permovilidad, int usuario, decimal pordestaque)
        {
            return cdOrdenPedido.EmpleadoComision(opcion, codigo, contrato, comisiones, comiporcentaje, comiperiodo, destaque, valordestaque, periododestaque, produccion, importepro, porcentajepro, periodopro,
            imagenpro, nombreimagenpro, regular, impregular, movilidad, impmovilidad, permovilidad, usuario, pordestaque);
        }
        public DataRow ListarAreaGerenciaDeUsuario(string @Login_User)
        {
            return cdOrdenPedido.ListarAreaGerenciaDeUsuario(Login_User);
        }
        public DataTable SeleccionarBoletas(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            return cdOrdenPedido.SeleccionarBoletas(empresa, tipo, numero, fecha, fechaini, fechafin);
        }
        public DataTable InsertarAsientosdeBoletas(int empresasx, string cuentas, int codigo, decimal monto)
        {
            return cdOrdenPedido.InsertarAsientosdeBoletas(empresasx, cuentas, codigo, monto);
        }
        public DataTable CuentasReflejo(string @cuenta)
        {
            return cdOrdenPedido.CuentasReflejo(@cuenta);
        }
        public DataTable StoreProcedures(int opcion, int codigo, string store, int cadena)
        {
            return cdOrdenPedido.StoreProcedures(opcion, codigo, store, cadena);
        }
        public DataTable SeleccionarGratificacion(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            return cdOrdenPedido.SeleccionarGratificacion(empresa, tipo, numero, fecha, fechaini, fechafin);
        }
        public DataTable InsertarCuentasReflejo(int asiento, int empresa, string cuenta, decimal monto, string lado)
        {
            return cdOrdenPedido.InsertarCuentasReflejo(asiento, empresa, cuenta, monto, lado);
        }
        public DataTable BalanceParametros(int opcion, int pos, string codigoreal, string codigo, string nombre, string cuenta, int usuario)
        {
            return cdOrdenPedido.BalanceParametros(opcion, pos, codigoreal, codigo, nombre, cuenta, usuario);
        }
        public DataTable BalanceGananciasParametros(int opcion, int pos, string codigoreal, string codigo, string nombre, string cuenta, int usuario, string signo)
        {
            return cdOrdenPedido.BalanceGananciasParametros(opcion, pos, codigoreal, codigo, nombre, cuenta, usuario, signo);
        }
        public DataTable BalanceGananciasParametros()
        {
            return cdOrdenPedido.BalanceGananciasParametros(0, 0, "", "", "", "", 0, "");
        }
        public DataTable SeleccionarPagoCts(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin)
        {
            return cdOrdenPedido.SeleccionarPagoCts(empresa, tipo, numero, fecha, fechaini, fechafin);
        }
        public DataTable GenerarBoletasMensuales(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            return cdOrdenPedido.GenerarBoletasMensuales(empresa, tipo, numero, fecha, fechaini, fechafin, usuario);
        }
        public DataTable GenerarAsientodeBoletasGeneradas(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            return cdOrdenPedido.GenerarAsientodeBoletasGeneradas(empresa, tipo, numero, fecha, fechaini, fechafin, usuario);
        }
        public DataTable TipodeCambio(int opcion, int año, int mes, int dia, decimal compra, decimal venta, byte[] img)
        {
            return cdOrdenPedido.TipodeCambio(opcion, año, mes, dia, compra, venta, img);
        }
        public DataTable GenerarGratificaciones(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            return cdOrdenPedido.GenerarGratificaciones(empresa, tipo, numero, fecha, fechaini, fechafin, usuario);
        }
        public DataTable Generarcts(int empresa, int tipo, string numero, int fecha, DateTime fechaini, DateTime fechafin, int usuario)
        {
            return cdOrdenPedido.Generarcts(empresa, tipo, numero, fecha, fechaini, fechafin, usuario);
        }
        public DataRow getMinMaxContrato()
        {
            return cdOrdenPedido.getMinMaxContrato();
        }
        public DataTable TablaSolicitudes(int opcion, int jefe, string accion, string valor, int estado, int solicita, string observacion)
        {
            return cdOrdenPedido.TablaSolicitudes(opcion, jefe, accion, valor, estado, solicita, observacion);
        }
        public DataTable EmpresasExternas(int opcion, int registro, int codigo, string ruc, string empresa, int certificado, decimal importe, decimal renta, byte[] foto, string nombrefoto, int usuario, DateTime fecha)
        {
            return cdOrdenPedido.EmpresasExternas(opcion, registro, codigo, ruc, empresa, certificado, importe, renta, foto, nombrefoto, usuario, fecha);
        }
        public DataTable DesvinculacionOtrosDscto(int opcion, int registro, int tipo, string numero, string motivo, decimal importe, byte[] descuento, string nombredesc, int usuario)
        {
            return cdOrdenPedido.DesvinculacionOtrosDscto(opcion, registro, tipo, numero, motivo, importe, descuento, nombredesc, usuario);
        }
        public DataTable AbonosExternos(int opcion, DateTime fecha, int empresa, int codigo, string ruc, decimal importe, int usuario)
        {
            return cdOrdenPedido.AbonosExternos(opcion, fecha, empresa, codigo, ruc, importe, usuario);
        }
        public DataTable SolicitudEmpleadoExt(int numero, int area, string servicio, string observacion, int estado, int usuario)
        {
            return cdOrdenPedido.SolicitudEmpleadoExt(numero, area, servicio, observacion, estado, usuario);
        }
        public DataRow EmpresaEPsMOntosMaximos(int numero, int codigo)
        {
            return cdOrdenPedido.EmpresaEPsMOntosMaximos(numero, codigo);
        }
        public DataTable ActualizarMemoPremio(int codigo, int tipoid, string numero, int tipo, string observacion)
        {
            return cdOrdenPedido.ActualizarMemoPremio(codigo, tipoid, numero, tipo, observacion);
        }
        public DataTable ReporteBoletas(int empresa, int tipo, string numero, int fecha, DateTime fecinicio, DateTime fecfin)
        {
            return cdOrdenPedido.ReporteBoletas(empresa, tipo, numero, fecha, fecinicio, fecfin);
        }
        public DataTable BuscarBoletasPOrPAgar(int empresa, int tipo, string numero, int fecha, DateTime fecinicio, DateTime fecfin)
        {
            return cdOrdenPedido.BuscarBoletasPOrPAgar(empresa, tipo, numero, fecha, fecinicio, fecfin);
        }
        public DataTable CargosAreas(int opcion, int cargo, int area, string cadena)
        {
            return cdOrdenPedido.CargosAreas(opcion, cargo, area, cadena);
        }
        public DataRow EmpleadoFamiliaExiste(int Tipo_ID_Emp, string Nro_ID_Emp, int Tipo_ID_Fam_Old, string Nro_ID_Fam_Old)
        {
            return cdOrdenPedido.EmpleadoFamiliaExiste(Tipo_ID_Emp, Nro_ID_Emp, Tipo_ID_Fam_Old, Nro_ID_Fam_Old);
        }
        public DataRow CalcularEdad(DateTime fecha, DateTime hoy, int opcion)
        {
            return cdOrdenPedido.CalcularEdad(fecha, hoy, opcion);
        }
        public DataRow AprobarPostulantePrevia(int Tipo_ID_Postulante, string Nro_ID_Postulante, int Id_SolicitaEmpleado, int opcion)
        {
            return cdOrdenPedido.AprobarPostulantePrevia(Tipo_ID_Postulante, Nro_ID_Postulante, Id_SolicitaEmpleado, opcion);
        }
        public DataTable Periodos(int opcion)
        {
            return cdOrdenPedido.Periodos(opcion, 0, DateTime.Now);
        }
        public DataTable Periodos(int opcion, int empresa)
        {
            return cdOrdenPedido.Periodos(opcion, empresa, DateTime.Now);
        }
        public DataTable Periodos(int opcion, int empresa, DateTime fechas)
        {
            return cdOrdenPedido.Periodos(opcion, empresa, fechas);
        }
        public DataTable ListarAsientosAbiertos(int opcion, int empresa, DateTime fecha)
        {
            return cdOrdenPedido.ListarAsientosAbiertos(opcion, empresa, fecha);
        }
        public DataTable Detraciones(int opcion, int id, string cod, string anexo, string descripcion, decimal porcentaje, int usuario, DateTime fechas)
        {
            return cdOrdenPedido.Detraciones(opcion, id, cod, anexo, descripcion, porcentaje, usuario, fechas);
        }
        public DataTable DetraccionesFiltrar(string cod, string anexo, string desc)
        {
            return cdOrdenPedido.DetraccionesFiltrar(cod, anexo, desc);
        }
        public DataTable Detraciones(int opcion)
        {
            return cdOrdenPedido.Detraciones(opcion, 0, "", "", "", 0, 0, DateTime.Now);
        }
        public DataTable ListarAbonosFacturas(int opcion, string numfac, int tipoid, string proveedor)

        {
            return cdOrdenPedido.ListarAbonosFacturas(opcion, numfac, tipoid, proveedor);
        }
        public DataTable ComprobanteDePago(int opcion, int id, string descripcion, int usuario, int codigosunat, DateTime fechas)
        {
            return cdOrdenPedido.ComprobanteDePago(opcion, id, descripcion, usuario, codigosunat, fechas);
        }
        public DataTable ComprobanteDePago()
        {
            return cdOrdenPedido.ComprobanteDePago(0, 0, "", 0, 0, DateTime.Now);
        }
        public DataTable ComprobanteDePagoConCodigo()
        {
            return cdOrdenPedido.ComprobanteDePago(10, 0, "", 0, 0, DateTime.Now);
        }
        public DataTable DetraccionesPorPAgar(int empresa)
        {
            return cdOrdenPedido.DetraccionesPorPAgar(empresa);
        }
        public DataTable DetraccionesPorPAgarVentas(int empresa)
        {
            return cdOrdenPedido.DetraccionesPorPAgarVentas(empresa);
        }
        public DataTable Detracciones(int @Opcion, string @Nrofac, string @Proveedor, decimal @ImporteMo, decimal @ImportePEN, decimal @tc, decimal importepagar, decimal diferencia, string @nroopbanco, string @banco, string @ctabanco, DateTime @fechapago, int @Usuario, int @idComprobante)
        {
            return cdOrdenPedido.Detracciones(@Opcion, @Nrofac, @Proveedor, @ImporteMo, @ImportePEN, @tc, importepagar, diferencia, @nroopbanco, @banco, @ctabanco, @fechapago, @Usuario, @idComprobante);
        }
        public DataTable DetraccionesVenta(int opcion, string nroboleta, int tipo, string idcliente, decimal importemo, decimal importepen, decimal tc, decimal importepagado, decimal diferencia, string nropago, string banco, string nrocuenta, DateTime fechapago, int usuario, int fkempresa, int idcomprobante)
        {
            return cdOrdenPedido.DetraccionesVenta(opcion, nroboleta, tipo, idcliente, importemo, importepen, tc, importepagado, diferencia, nropago, banco, nrocuenta, fechapago, usuario, fkempresa, idcomprobante);
        }
        public DataTable PagarDetracionesCabecera(int asiento, string cuo, int empresa, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string ruc, string nrofac, string cuenta, string cuentaredondeo, DateTime fechapago, DateTime fechacontablem, string glosa, int idcomprobante)
        {
            return cdOrdenPedido.PagarDetracionesCabecera(asiento, cuo, empresa, montoTotal, montoredondeo, montodiferencia, ruc, nrofac, cuenta, cuentaredondeo, fechapago, fechacontablem, glosa, idcomprobante);
        }
        public DataTable PagarDetracionesVentaCabecera(int asiento, string cuo, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string nroboleta, string cuentaContableNacion, string cuentacontablebanco, string cuentaredondeo, DateTime fechacontable, string glosa, int fkempresa, DateTime fechapago, int idcomprobante)
        {
            return cdOrdenPedido.PagarDetracionesVentaCabecera(asiento, cuo, montoTotal, montoredondeo, montodiferencia, nroboleta, cuentaContableNacion, cuentacontablebanco, cuentaredondeo, fechacontable, glosa, fkempresa, fechapago, idcomprobante);
        }
        public DataTable PagarDetracionesDetalle(int @Asiento, string @Cuo, int @Empresa, decimal montoTotal, decimal montoredondeo, decimal montodiferencia, string @Ruc, string @Codfac, string @Numfac, decimal @Total, decimal @tc, int @Idcuenta, string @Cuentacontablebanco, string cuentaredondeo, DateTime @fechaContable, string @glosa, int @Usuario, int @idcomprobante)
        {
            return cdOrdenPedido.PagarDetracionesDetalle(@Asiento, @Cuo, @Empresa, montoTotal, montoredondeo, montodiferencia, @Ruc, @Codfac, @Numfac, @Total, @tc, @Idcuenta, @Cuentacontablebanco, @cuentaredondeo, @fechaContable, @glosa, @Usuario, @idcomprobante);
        }
        public DataTable PagarDetracionesVentaDetalle(int @Asiento, int @tipodoc, string @numdoc, string @nombreCliente, int @idcomprobante, string @Codfac, string @Numfac, string @nroBoleta, decimal montototal, decimal montoredondeo, decimal montodiferencia, decimal @tc, string @CuentaContableNacion, string @CuentaContableBanco, int @cuentaBanco, DateTime @fechaContable, string cuentaredondeo, string @glosa, int @Usuario, int fkempresa)
        {
            return cdOrdenPedido.PagarDetracionesVentaDetalle(@Asiento, @tipodoc, @numdoc, @nombreCliente, @idcomprobante, @Codfac, @Numfac, @nroBoleta, montototal, montoredondeo, montodiferencia, @tc, @CuentaContableNacion, @CuentaContableBanco, @cuentaBanco, cuentaredondeo, @fechaContable, @glosa, @Usuario, fkempresa);
        }
        public DataTable ReversarAsientos(int idasiento, int proyecto, int usuario, DateTime Fecha)
        {
            return cdOrdenPedido.ReversarAsientos(idasiento, proyecto, usuario, Fecha);
        }
        public DataTable ReversarAsientosSoloEstado(int idasiento, int proyecto, DateTime Fecha)
        {
            return cdOrdenPedido.ReversarAsientosSoloEstado(idasiento, proyecto, Fecha);

        }
        public DataTable Clientes(int Opcion, int Codigo, int Tipoid, string Nroid, string Apepat, string Apemat, string Nombres, int Tipo, int Sexo, int Civil, string Direcion, int Distrito, int Provincia, int Departamento, string Telfijo, string Telcelular, string Email, string Ocupacion, int Usuario, DateTime Fecha)
        {
            return cdOrdenPedido.Clientes(Opcion, Codigo, Tipoid, Nroid, Apepat, Apemat, Nombres, Tipo, Sexo, Civil, Direcion, Distrito, Provincia, Departamento, Telfijo, Telcelular, Email, Ocupacion, Usuario, Fecha);
        }
        public DataTable Clientes()
        {
            return cdOrdenPedido.Clientes(0, 0, 0, "", "", "", "", 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable ClienteSiguienteCodigo()
        {
            return cdOrdenPedido.Clientes(4, 0, 0, "", "", "", "", 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable ClienteBuscarExiste(int tipoid, string nroid)
        {
            return cdOrdenPedido.Clientes(3, 0, tipoid, nroid, "", "", "", 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable ClientesBusqueda(string codigo, string nrodoc, string nombres, string estadocivil)
        {
            return cdOrdenPedido.ClientesBusqueda(codigo, nrodoc, nombres, estadocivil);
        }
        public DataTable ClienteBuscarExiste(int codigo, int tipoid, string nroid)
        {
            return cdOrdenPedido.Clientes(5, codigo, tipoid, nroid, "", "", "", 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable Clientes(int opciones, string cadena)
        {
            return cdOrdenPedido.Clientes(0, opciones, 0, "", "", "", cadena, 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable BuscarCliente(int tipoid, string nroid)
        {
            return cdOrdenPedido.Clientes(10, 0, tipoid, nroid, "", "", "", 0, 0, 0, "", 0, 0, 0, "", "", "", "", 0, DateTime.Now);
        }
        public DataTable UnidadMedida(int opcion, int codigo, string descripcion, int usuario)
        {
            return cdOrdenPedido.UnidadMedida(opcion, codigo, descripcion, usuario);
        }
        public DataTable UnidadMedida()
        {
            return cdOrdenPedido.UnidadMedida(0, 0, "", 0);
        }
        public DataTable ListarProductosVender(string valor, int empresa, int proyecto)
        {
            return cdOrdenPedido.ListarProductosVender(valor, empresa, proyecto);
        }
        public DataTable ListarNroOpBancaria(int banco, string nrocuenta, string ruc, string razon, string nroop, DateTime fecha1, DateTime fecha2)
        {
            return cdOrdenPedido.ListarNroOpBancaria(banco, nrocuenta, ruc, razon, nroop, fecha1, fecha2);
        }
        public DataTable ActualizarNroOperacion(int codigo, string valor, int tipodet, int fkempresa)
        {
            return cdOrdenPedido.ActualizarNroOperacion(codigo, valor, tipodet, fkempresa);
        }
        public DataTable Vendedor(int opcion, int codigo, string nrocod, int estado, int usuario)
        {
            return cdOrdenPedido.Vendedor(0, opcion, codigo, nrocod, estado, usuario);
        }
        public DataTable Vendedor(int codvende, int opcion, int codigo, string nrocod, int estado, int usuario)
        {
            return cdOrdenPedido.Vendedor(codvende, opcion, codigo, nrocod, estado, usuario);
        }
        public DataTable Vendedor()
        {
            return cdOrdenPedido.Vendedor(0, 0, 0, "", 0, 0);
        }
        public DataTable Vendedor(int Codigo)
        {
            return cdOrdenPedido.Vendedor(Codigo, 100, 0, "", 0, 0);
        }
        public DataTable CotizacionDetalle(out int num, int opcion)
        {
            return cdOrdenPedido.CotizacionDetalle(out num, opcion);
        }
        public DataTable CotizacionDetalleNroCod(out int num)
        {
            return CotizacionDetalle(out num, 100);
        }
        public void CotizacionesCLienteCabecera(out int nume, int Opcion, int @Codvend, DateTime @Fechavence, decimal subtotal, decimal igv, decimal total, int @Tipoidcliente, string @Nroidcliente, int @Estado, string @Observacion, int @Usuario, decimal inicial)
        {
            cdOrdenPedido.CotizacionesCLienteCabecera(out nume, Opcion, @Codvend, @Fechavence, subtotal, igv, total, @Tipoidcliente, @Nroidcliente, @Estado, @Observacion, @Usuario, inicial);
        }
        public DataTable CotizacionesCLienteCabecera(int Opcion, int @Codvend, DateTime @Fechavence, decimal subtotal, decimal igv, decimal total, int @Tipoidcliente, string @Nroidcliente, int @Estado, string @Observacion, int @Usuario)
        {
            return cdOrdenPedido.CotizacionesCLienteCabecera(Opcion, @Codvend, @Fechavence, subtotal, igv, total, @Tipoidcliente, @Nroidcliente, @Estado, @Observacion, @Usuario);
        }
        public DataTable CotizacionesCLienteCabeceraDetalle(int Opcion, int cod, int empresa, int proyecto, string etapa, int idarticulo, decimal cantidad, decimal preciobase, decimal tc, int tipodesc, decimal valordesc, decimal preciofina, decimal subtotal, decimal igv, int moneda, decimal inicial, int tipoinicial, decimal valorinicial)
        {
            return cdOrdenPedido.CotizacionesCLienteCabeceraDetalle(Opcion, cod, empresa, proyecto, etapa, idarticulo, cantidad, preciobase, tc, tipodesc, valordesc, preciofina, subtotal, igv, moneda, inicial, tipoinicial, valorinicial);
        }
        public DataTable CotizacionesCLienteCabeceraDetalle(int cod)
        {
            return cdOrdenPedido.CotizacionesCLienteCabeceraDetalle(0, cod, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
        public DataTable CotizacionesCLienteCabeceraDetalleBorrar(int cod)
        {
            return cdOrdenPedido.CotizacionesCLienteCabeceraDetalle(5, cod, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
        //busqueda de cotizaciones de cliente
        public DataTable CotizacionCLiente(string nrocot, string tipoid, string nroid, string nombre)
        {
            return cdOrdenPedido.CotizacionCLiente(nrocot, tipoid, nroid, nombre);
        }
        public DataTable SeparacionVenta(int opcion, int numcot)
        {
            return cdOrdenPedido.SeparacionVenta(opcion, numcot, 0, 0, 0, null, "", DateTime.Now, 0);
        }
        public DataTable SeparacionVentaDarBajaAbono(int numRegistro)
        {
            return cdOrdenPedido.SeparacionVenta(3, numRegistro, 0, 0, 0, null, "", DateTime.Now, 0);
        }
        public DataTable SeparacionVenta(int numcot)
        {
            return cdOrdenPedido.SeparacionVenta(0, numcot, 0, 0, 0, null, "", DateTime.Now, 0);
        }
        public DataTable SeparacionVenta(int opcion, int numcot, decimal importe, decimal tipocambio, int moneda, byte[] img, string nombre, DateTime fecha, int usuario)
        {
            return cdOrdenPedido.SeparacionVenta(opcion, numcot, importe, tipocambio, moneda, img, nombre, fecha, usuario);
        }
        public DataTable VerificarStockProductosDeCotizacion(int numcot)
        {
            return cdOrdenPedido.VerificarStockProductosDeCotizacion(numcot);
        }
        public DataTable CronogramaVtaCabecera(int @Opcion, int @Fkcoti, decimal @Saldo, int @Moneda, decimal @Tc, int @Nrocuota, int @Usuario)
        {
            return cdOrdenPedido.CronogramaVtaCabecera(@Opcion, @Fkcoti, @Saldo, @Moneda, @Tc, @Nrocuota, @Usuario);
        }
        public DataTable CronogramaVtaCabecera(int @Fkcoti)
        {
            return cdOrdenPedido.CronogramaVtaCabecera(10, @Fkcoti, 0, 0, 0, 0, 0);
        }
        public DataTable CronogramaVtaDetalle(int @Opcion, int @Fkcronocab, int @Fkcoti, int @Nrocuota, DateTime @Fechavencecuota, decimal @Valorcuotas, int @Monedas, DateTime? @Fechapago, byte[] @Imgpago, string @Nombrepago, DateTime @Fecha, int @Usuario)
        {
            return cdOrdenPedido.CronogramaVtaDetalle(@Opcion, @Fkcronocab, @Fkcoti, @Nrocuota, @Fechavencecuota, @Valorcuotas, @Monedas, @Fechapago, @Imgpago, @Nombrepago, @Fecha, @Usuario);
        }
        public DataTable CronogramaVtaDetalle(int @Fkcoti)
        {
            return cdOrdenPedido.CronogramaVtaDetalle(10, 0, @Fkcoti, 0, DateTime.Now, 0, 0, DateTime.Now, null, "", DateTime.Now, 0);
        }
        public DataTable CronogramaVtaDetalleCotizacion(int @Fkcoti)
        {
            return cdOrdenPedido.CronogramaVtaDetalle(0, 0, @Fkcoti, 0, DateTime.Now, 0, 0, DateTime.Now, null, "", DateTime.Now, 0);
        }
        public DataTable CronogramaVtaDetalleResumen(int @Fkcoti)
        {
            return cdOrdenPedido.CronogramaVtaDetalle(5, 0, @Fkcoti, 0, DateTime.Now, 0, 0, DateTime.Now, null, "", DateTime.Now, 0);
        }
        public DataTable CronogramaVtaDetalleResumenPago(int IdDetalle)
        {
            return cdOrdenPedido.CronogramaVtaDetalle(7, 0, IdDetalle, 0, DateTime.Now, 0, 0, DateTime.Now, null, "", DateTime.Now, 0);
        }
        public DataTable CuentaBancaria(int @Opcion, int @Id, int @Empresa, int @Banco, int @Moneda, int @Tipo, string @Nrocuenta, string @Nrocuentacci, int @Usuario)
        {
            return cdOrdenPedido.CuentaBancaria(@Opcion, @Id, @Empresa, @Banco, @Moneda, @Tipo, @Nrocuenta, @Nrocuentacci, @Usuario);
        }
        public DataTable CuentaBancaria(int empresa, string cuenta)
        {
            return cdOrdenPedido.CuentaBancaria(8, 0, empresa, 0, 0, 0, cuenta, "", 0);
        }
        public DataTable CuentaBancaria()
        {
            return cdOrdenPedido.CuentaBancaria(0, 0, 0, 0, 0, 0, "", "", 0);
        }
        public DataTable TipoCuentaBancaria(int @Opcion, int @Id, string @Descripcion, int @usuario)
        {
            return cdOrdenPedido.TipoCuentaBancaria(@Opcion, @Id, Descripcion, usuario);
        }
        public DataTable TipoCuentaBancaria()
        {
            return cdOrdenPedido.TipoCuentaBancaria(0, 0, "", 0);
        }
        public DataTable CuentasBancariasBusqueda(string empresa, string banco, string moneda, string cuenta, string cci)
        {
            return cdOrdenPedido.CuentasBancariasBusqueda(empresa, banco, moneda, cuenta, cci);
        }
        public DataTable delproducto(int abc, out int con, out int stocc)
        {
            //con = 1;stocc = 1;
            return cdOrdenPedido.delproducto(abc, out con, out stocc);
        }
        public decimal TipoCambioDia(string VentaCompra, DateTime fecha)
        {
            if (VentaCompra == "") VentaCompra = "Compra";
            DataTable Ttipo = TipodeCambioxDia(fecha);
            if (Ttipo.Rows.Count > 0)
                return (decimal)Ttipo.Rows[0][VentaCompra];
            else return 0;
        }
        public DataTable TipodeCambioxDia(DateTime fecha)
        {
            //con = 1;stocc = 1;
            return cdOrdenPedido.TipodeCambioxDia(fecha);
        }
        public DataTable FacturaManualCabecera(int @opcion, int @idfac, int @id, string @nro, string @nroRef, string @ruc, int @empresa, int @proyecto, int @etapa, int @compensa, int @moneda, decimal @tc, decimal @total, decimal @igv, int @gravaigv, DateTime @fechaemision, DateTime @fecharecepcion, DateTime @fechavence, DateTime @fechacontable, int @estado, int @tipopago, string @nrodocpago, string coddet, decimal porcentaje, decimal @detracion, byte[] @imgfac, string @glosa, int @usuario)
        {
            return cdOrdenPedido.FacturaManualCabecera(@opcion, idfac, @id, @nro, @nroRef, @ruc, @empresa, @proyecto, @etapa, @compensa, @moneda, @tc, @total, @igv, @gravaigv, @fechaemision, @fecharecepcion, @fechavence, fechacontable, @estado, @tipopago, @nrodocpago, coddet, porcentaje, @detracion, @imgfac, @glosa, @usuario);
        }
        public DataTable FacturaManualCabeceraRemover(int idfac, int Tipo)
        {
            DateTime F = DateTime.Now;
            return cdOrdenPedido.FacturaManualCabecera(Tipo, idfac, 0, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, F, F, F, F, 0, 0, "", "", 0, 0, null, "", 0);
        }
        public DataTable FacturaManualCabecera(string proveedor, string nrodoc, int TipoDoc)
        {
            DateTime F = DateTime.Now;
            return cdOrdenPedido.FacturaManualCabecera(5, 0, TipoDoc, nrodoc, "", proveedor, 0, 0, 0, 0, 0, 0, 0, 0, 0, F, F, F, F, 0, 0, "", "", 0, 0, null, "", 0);
        }
        public DataTable FacturaManualCabecera(int idfac, byte[] imagen)
        {
            DateTime f = DateTime.Now;
            return cdOrdenPedido.FacturaManualCabecera(10, idfac, 0, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, f, f, f, f, 0, 0, "", "", 0, 0, imagen, "", 0);
        }
        public DataTable FacturaManualCabecera(string proveedor, string nrodoc, int idfac, int TipoDoc, int opcionbusqueda)
        {
            DateTime F = DateTime.Now;
            //opcionbusqueda ==empresa
            return cdOrdenPedido.FacturaManualCabecera(6, idfac, TipoDoc, nrodoc, "", proveedor, opcionbusqueda, 0, 0, 0, 0, 0, 0, 0, 0, F, F, F, F, 0, 0, "", "", 0, 0, null, "", 0);
        }
        public DataTable FacturaManualVentaCabecera(int @opcion, int @idfac, int @id, string @nro, string @nroRef, int @tipoid, string @nroid, int @empresa, int @proyecto, int @etapa, int @moneda, decimal @tc, decimal @total, decimal @igv, DateTime @fechaemision, DateTime @fechavence, DateTime @fechacontable, int @estado, int @tipopago, string @nrodocpago, string coddet, decimal porcentaje, decimal @detracion, byte[] @imgfac, string @glosa, int @usuario)
        {
            return cdOrdenPedido.FacturaManualVentaCabecera(@opcion, @idfac, @id, @nro, @nroRef, @tipoid, @nroid, @empresa, @proyecto, @etapa, @moneda, @tc, @total, @igv, @fechaemision, @fechavence, @fechacontable, @estado, @tipopago, @nrodocpago, coddet, porcentaje, @detracion, @imgfac, @glosa, @usuario);
        }
        public DataTable FacturaManualVentaCabecera(int idfac, byte[] imagen, int idcomprobante, string tiponroid)
        {
            DateTime f = DateTime.Now;
            return cdOrdenPedido.FacturaManualVentaCabecera(10, idfac, idcomprobante, "", "", 0, tiponroid, 0, 0, 0, 0, 0, 0, 0, f, f, f, 0, 0, "", "", 0, 0, imagen, "", 0);
        }
        public DataTable FacturaManualVentaCabeceraRemover(int idfac, int opcion, int idcomprobante, string tiponroid)
        {
            DateTime f = DateTime.Now;
            return cdOrdenPedido.FacturaManualVentaCabecera(opcion, idfac, idcomprobante, "", "", 0, tiponroid, 0, 0, 0, 0, 0, 0, 0, f, f, f, 0, 0, "", "", 0, 0, null, "", 0);
        }
        public DataTable FacturaManualVentaCabecera()
        {
            DateTime F = DateTime.Now;
            return cdOrdenPedido.FacturaManualVentaCabecera(0, 0, 0, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, F, F, F, 0, 0, "", "", 0, 0, null, "", 0);
        }
        public DataTable FacturaManualVentaCabecera(string nrodoc, int opcion, int Empresa, int idcomprobante)
        {
            DateTime F = DateTime.Now;
            return cdOrdenPedido.FacturaManualVentaCabecera(5, 0, idcomprobante, nrodoc, "", 0, "", Empresa, 0, 0, 0, 0, 0, 0, F, F, F, 0, 0, "", "", 0, 0, null, "", opcion);
        }
        public DataTable FacturaManualVentaCabecera(string nrodoc, int idfac, int opcion, int Empresa, int idcomprobante)
        {
            DateTime F = DateTime.Now;
            return cdOrdenPedido.FacturaManualVentaCabecera(6, idfac, idcomprobante, nrodoc, "", 0, "", Empresa, 0, 0, 0, 0, 0, 0, F, F, F, 0, 0, "", "", 0, 0, null, "", opcion);
        }
        public DataTable FacturaManualDetalle(int @opcion, int @idfac, int @id, string @nro, string @ruc, string @debehaber, string @cuenta, string @ceco, int @tipoigv, decimal @importemn, decimal @importeme, string @glosa, string @cuo, int @usuario)
        {
            return cdOrdenPedido.FacturaManualDetalle(@opcion, @idfac, @id, @nro, @ruc, @debehaber, @cuenta, @ceco, @tipoigv, @importemn, @importeme, @glosa, @cuo, @usuario);
        }
        public DataTable FacturaManualVentaDetalle(int @opcion, int @idfac, int @id, string @nro, int tipoid, string nroid, string @debehaber, string @cuenta, int @tipoigv, decimal @importemn, decimal @importeme, string @glosa, string @cuo, int @usuario, int fkempresa)
        {
            return cdOrdenPedido.FacturaManualVentaDetalle(@opcion, @idfac, @id, @nro, tipoid, nroid, @debehaber, @cuenta, @tipoigv, @importemn, @importeme, @glosa, @cuo, @usuario, fkempresa);
        }
        public DataTable FacturaManualDetalleRemover(string @nrofa, string @ruc, int Tipo, int idcomprobante)
        {
            return cdOrdenPedido.FacturaManualDetalle(Tipo, idcomprobante, 0, @nrofa, @ruc, "", "", "", 0, 0, 0, "", "", 0);
        }
        public DataTable FacturaManualVentaDetalleRemover(string @nrofa, int fkempresa, int @opcion, int idcomprobante, string tiponroidcliente)
        {
            return cdOrdenPedido.FacturaManualVentaDetalle(opcion, idcomprobante, 0, @nrofa, 1, tiponroidcliente, "", "", 0, 0, 0, "", "", 0, fkempresa);
        }
        public DataTable FacturaManualBusqueda(string proveedor, string nrodoc, string empresa, int idcomprobante)
        {
            return cdOrdenPedido.FacturaManualBusqueda(proveedor, nrodoc, empresa, idcomprobante);
        }
        public DataTable BuscarImagenFacturasCompras(string proveedor, string nrodoc, int tipo, int @opcion, int fkempresa, int @idcomprobante)
        {
            return cdOrdenPedido.BuscarImagenFacturasCompras(proveedor, nrodoc, tipo, @opcion, fkempresa, @idcomprobante);
        }
        public DataTable FacturaManualVentaBusqueda(string proveedor, string nrodoc, string empresa)
        {
            return cdOrdenPedido.FacturaManualVentaBusqueda(proveedor, nrodoc, empresa);
        }
        public DataTable FacturaManualDetalleBusqueda(string proveedor, string nrodoc, int idcomprobante)
        {
            return cdOrdenPedido.FacturaManualDetalleBusqueda(proveedor, nrodoc, idcomprobante);
        }
        public DataTable FacturaManualVentaDetalleBusqueda(string proveedor, string nrodoc, int fkempresa, int idcomprobante)
        {
            return cdOrdenPedido.FacturaManualVentaDetalleBusqueda(proveedor, nrodoc, fkempresa, idcomprobante);
        }
        public DataTable VerFacturasPagadasCompras(string proveedor, string nrofac, int @idcomprobante)
        {
            return cdOrdenPedido.VerFacturasPagadasCompras(proveedor, nrofac, @idcomprobante);
        }
        public DataTable VerFacturasPagadasVentas(string TipoYIdCliente, string nrofac, int @idcomprobante)
        {
            return cdOrdenPedido.VerFacturasPagadasVentas(TipoYIdCliente, nrofac, @idcomprobante);
        }
        public DataTable VerPeriodoAbierto(int empresa, DateTime Fecha)
        {
            return cdOrdenPedido.VerPeriodoAbierto(empresa, Fecha);
        }
        public DataTable CreaciondeCuentasReflejo(string cuenta)
        {
            return cdOrdenPedido.CreaciondeCuentasReflejo(cuenta);
        }
        public DataTable BusquedaVentasManuales(int empresa, DateTime fecha1, DateTime fecha2, string cliente, string nroboleta)
        {
            return cdOrdenPedido.BusquedaVentasManuales(empresa, fecha1, fecha2, cliente, nroboleta);
        }
        public DataTable BusquedaVentasManualesAbonados(int empresa, DateTime fecha1, DateTime fecha2, string cliente, string nroboleta)
        {
            return cdOrdenPedido.BusquedaVentasManualesAbonados(empresa, fecha1, fecha2, cliente, nroboleta);
        }
        public DataTable FacturaVentaManualPago(int @opcion, int @id, string @comprobante, string @nroopbanco, int @tipoid, string @cliente, int @empresa, decimal @importe, decimal @tc, string @banco, string @cuentabanco, DateTime @fechapago, string @cuo, int @usuario)
        {
            return cdOrdenPedido.FacturaVentaManualPago(@opcion, @id, @comprobante, @nroopbanco, @tipoid, @cliente, @empresa, @importe, @tc, @banco, @cuentabanco, @fechapago, @cuo, @usuario);
        }
        public DataTable InsertarAsientoFacturaCabecera(int opcion, int @Id, int @Asiento, DateTime @fechaContable, string @Cuenta, decimal @Debe, decimal @Haber, decimal @tc, int @proyecto, int @etapa, string @cuo, int @Fkmoneda, string @glosa, DateTime FechaAbono)
        {
            return cdOrdenPedido.InsertarAsientoFacturaCabecera(opcion, @Id, @Asiento, @fechaContable, @Cuenta, @Debe, @Haber, @tc, @proyecto, @etapa, @cuo, @Fkmoneda, glosa, FechaAbono);
        }
        public DataTable InsertarAsientoFacturaDetalle(int @opcion, int @Id, int @Asiento, DateTime @fechaContable, string @Cuenta, int @proyecto, int @tipodoc, string @numdoc, string @razon, int @idcomprobante, string @codcomprobante, string @numcomprobante, int @cc, DateTime @fechaemision, DateTime @fechavencimiento, DateTime @fecharecepcion, decimal @impormn, decimal @importeme, decimal @tc, int @Fkmoneda, string @cuentabanco, string @nroopbanco, string @glosa, DateTime @fechaasiento, int @usuario)
        {
            return cdOrdenPedido.InsertarAsientoFacturaDetalle(@opcion, @Id, @Asiento, @fechaContable, @Cuenta, @proyecto, @tipodoc, @numdoc, @razon, @idcomprobante, @codcomprobante, @numcomprobante, @cc, @fechaemision, @fechavencimiento, @fecharecepcion, @impormn, @importeme, @tc, @Fkmoneda, @cuentabanco, @nroopbanco, @glosa, @fechaasiento, @usuario);
        }
        public DataTable BuscarFacturasManualesToNcNd(string ruc, string NumComprobante)
        {
            return cdOrdenPedido.BuscarFacturasManualesToNcNd(ruc, NumComprobante);
        }
        public DataTable BuscarVentasManualesToNcNd(string numdoc, int tipoid, string NumComprobante)
        {
            return cdOrdenPedido.BuscarVentasManualesToNcNd(numdoc, tipoid, NumComprobante);
        }
        public DataTable BuscarFacturasManualesToNcNdDEtalle(int opcion, string ruc, string NumComprobante)
        {
            return cdOrdenPedido.BuscarFacturasManualesToNcNdDEtalle(opcion, ruc, NumComprobante);
        }
        public DataTable BuscarVentasManualesToNcNdDEtalle(int opcion, string ruc, int tipoid, string NumComprobante)
        {
            return cdOrdenPedido.BuscarVentasManualesToNcNdDEtalle(opcion, ruc, tipoid, NumComprobante);
        }
        public DataTable FormatodeCompras8_1(int empresa, int periodo, int anio)
        {
            return cdOrdenPedido.FormatodeCompras8_1(empresa, periodo, anio);
        }
        public DataTable FormatodeVentas14_1(int empresa, int periodo, int anio)
        {
            return cdOrdenPedido.FormatodeVentas14_1(empresa, periodo, anio);
        }
        public DataTable MayorCuentasxEmpresas(int empresa, int periodo, int anio)
        {
            return cdOrdenPedido.MayorCuentasxEmpresas(empresa, periodo, anio);
        }
        public DataTable MayorPorCuentas(DateTime fechaini, DateTime fechafin, string cuentas, string glosas, string nrodoc, string ruc, string empresa, string razon)
        {
            return cdOrdenPedido.MayorPorCuentas(fechaini, fechafin, cuentas, glosas, nrodoc, ruc, empresa, razon);
        }
        public DataTable ReporteFacturasComprasIncompletas(DateTime fechaini, DateTime fechafin, int Fecha)
        {
            return cdOrdenPedido.ReporteFacturasComprasIncompletas(fechaini, fechafin, Fecha);
        }
        public DataTable VerificarCuadredeAsiento(string cuo, int proyecto)
        {
            return cdOrdenPedido.VerificarCuadredeAsiento(cuo, proyecto);
        }
        public DataTable CuadrarAsiento(string cuo, int proyecto, DateTime FechaAsiento)
        {
            return cdOrdenPedido.CuadrarAsiento(cuo, proyecto, FechaAsiento);
        }
        public DataTable LimpiezaDetalleAsientos(string cuo, int proyecto)
        {
            return cdOrdenPedido.LimpiezaDetalleAsientos(cuo, proyecto);
        }
    }
}