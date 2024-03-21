using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmAddCotizacionCRM : Form
    {
        internal string _idcotizacion;
        private bool calcular;

        public frmAddCotizacionCRM()
        {
            this._idcotizacion = "";

            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oCotizador.Apellido1 = "";
            oCotizador.Apellido2 = "";
            oCotizador.Cod_proyecto = Cod_proyectoTextEdit.EditValue.ToString();
            oCotizador.Costo = CostoTextEdit.EditValue.ToString();
            oCotizador.Detalle_Producto = "";
            oCotizador.Fecha = DateTime.Now;
            oCotizador.Fecha_registro = (DateTime)Fecha_registroDateEdit.EditValue;
            oCotizador.ID_Moneda = ID_MonedaTextEdit.EditValue.ToString();
            oCotizador.ID_Numero_Doc = 0m;
            oCotizador.ID_Producto = "";
            oCotizador.ID_Tipo_Documento = "";
            oCotizador.ID_Tipo_persona = ID_Tipo_personaTextEdit.EditValue.ToString();
            oCotizador.IGV = IGVTextEdit.EditValue.ToString();
            oCotizador.Nombre = "";
            oCotizador.Nombre_Proyecto = Cod_proyectoTextEdit.Text;
            oCotizador.Precio_venta = Precio_ventaTextEdit.EditValue.ToString();
            oCotizador.Razon_Social = "";
            oCotizador.Usuario = UsuarioTextEdit.EditValue.ToString();

            if (_idcotizacion == "")
            {
                //INSERT               

                // Guardado de los datos de los ítems de la cotización
                oCotizador.ID_Cotización = oCotizador.InsertCotizacion(oCotizador);


                if (oCotizador.ID_Cotización != "")
                {
                    //Guardado los datos de los items de la cotizacion
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {
                        HpResergerNube.CRM_Items_Cotizador oitemx = new HpResergerNube.CRM_Items_Cotizador();

                        // Obtener los valores de las celdas una vez y reutilizarlos
                        object cantidadProducto = gridView3.GetRowCellValue(i, xCantidad_Producto);
                        object costoUnitProducto = gridView3.GetRowCellValue(i, xCosto_Unit_Producto);
                        object idProducto = gridView3.GetRowCellValue(i, xID_Producto);
                        object igvProducto = gridView3.GetRowCellValue(i, xIGV_Producto);
                        object precioVentaProducto = gridView3.GetRowCellValue(i, xPrecio_venta_Producto);

                        // Asignar valores comunes a ambos tipos de items
                        oitemx.Cantidad_Producto = cantidadProducto?.ToString() ?? "";
                        oitemx.Cantidad_Servicio = cantidadProducto?.ToString() ?? "";
                        oitemx.Costo_Item_Producto = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Item_Servicio = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Unit_Producto = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Unit_Servicio = costoUnitProducto?.ToString() ?? "";
                        oitemx.Detalle_Producto = "";
                        oitemx.Detalle_Servicio = "";
                        oitemx.Fecha = DateTime.Now;
                        oitemx.Fecha_registro = oCotizador.Fecha_registro;
                        oitemx.ID_Cotización = oCotizador.ID_Cotización;
                        oitemx.ID_Item_Cotización = "";
                        oitemx.ID_Moneda = "";
                        oitemx.ID_Producto = idProducto?.ToString() ?? "";
                        oitemx.ID_Servicio = idProducto?.ToString() ?? "";
                        oitemx.ID_Tipo_PS = "";
                        oitemx.IGV_Producto = igvProducto?.ToString() ?? "";
                        oitemx.IGV_Servicio = igvProducto?.ToString() ?? "";
                        oitemx.Precio_venta_Producto = precioVentaProducto?.ToString() ?? "";
                        oitemx.Precio_venta_Servicio = precioVentaProducto?.ToString() ?? "";
                        oitemx.Usuario = oCotizador.Usuario;

                        oitemx.InsertItemCotizacion(oitemx);
                    }


                    XtraMessageBox.Show("Cotización guardada con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un problema al guardar la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_idcotizacion != "")
            {
                //UPDATE
                if (oCotizador.UpdateCotizacion(oCotizador))
                {
                    oCotizador.DeleteItemsCotizacion(_idcotizacion);

                    // Guardado de los datos de los ítems de la cotización
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {
                        HpResergerNube.CRM_Items_Cotizador oitemx = new HpResergerNube.CRM_Items_Cotizador();

                        // Obtener los valores de las celdas una vez y reutilizarlos
                        object cantidadProducto = gridView3.GetRowCellValue(i, xCantidad_Producto);
                        object costoUnitProducto = gridView3.GetRowCellValue(i, xCosto_Unit_Producto);
                        object idProducto = gridView3.GetRowCellValue(i, xID_Producto);
                        object igvProducto = gridView3.GetRowCellValue(i, xIGV_Producto);
                        object precioVentaProducto = gridView3.GetRowCellValue(i, xPrecio_venta_Producto);

                        // Asignar valores comunes a ambos tipos de items
                        oitemx.Cantidad_Producto = cantidadProducto?.ToString() ?? "";
                        oitemx.Cantidad_Servicio = cantidadProducto?.ToString() ?? "";
                        oitemx.Costo_Item_Producto = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Item_Servicio = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Unit_Producto = costoUnitProducto?.ToString() ?? "";
                        oitemx.Costo_Unit_Servicio = costoUnitProducto?.ToString() ?? "";
                        oitemx.Detalle_Producto = "";
                        oitemx.Detalle_Servicio = "";
                        oitemx.Fecha = DateTime.Now;
                        oitemx.Fecha_registro = oCotizador.Fecha_registro;
                        oitemx.ID_Cotización = oCotizador.ID_Cotización;
                        oitemx.ID_Item_Cotización = "";
                        oitemx.ID_Moneda = "";
                        oitemx.ID_Producto = idProducto?.ToString() ?? "";
                        oitemx.ID_Servicio = idProducto?.ToString() ?? "";
                        oitemx.ID_Tipo_PS = "";
                        oitemx.IGV_Producto = igvProducto?.ToString() ?? "";
                        oitemx.IGV_Servicio = igvProducto?.ToString() ?? "";
                        oitemx.Precio_venta_Producto = precioVentaProducto?.ToString() ?? "";
                        oitemx.Precio_venta_Servicio = precioVentaProducto?.ToString() ?? "";
                        oitemx.Usuario = oCotizador.Usuario;

                        oitemx.InsertItemCotizacion(oitemx);
                    }


                    XtraMessageBox.Show("Cotización actualizada con éxito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un problema al guardar la cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        HpResergerNube.CRM_Cotizador oCotizador = new HpResergerNube.CRM_Cotizador();
        private void frmAddCotizacionCRM_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Fecha_registroDateEdit.EditValue = DateTime.Now;
            bindingSource1.DataSource = typeof(HpResergerNube.CRM_Items_Cotizador);

            if (_idcotizacion != "")
            {
                oCotizador = oCotizador.ReadCotizacion(_idcotizacion);
                if (oCotizador != null)
                {
                    ID_CotizaciónTextEdit.EditValue = oCotizador.ID_Cotización;
                    ID_Tipo_personaTextEdit.EditValue = oCotizador.ID_Tipo_persona;
                    Cod_proyectoTextEdit.EditValue = oCotizador.Cod_proyecto;
                    ID_MonedaTextEdit.EditValue = oCotizador.ID_Moneda;
                    CostoTextEdit.EditValue = oCotizador.Costo;
                    IGVTextEdit.EditValue = oCotizador.IGV;
                    Precio_ventaTextEdit.EditValue = oCotizador.Precio_venta;
                    UsuarioTextEdit.EditValue = oCotizador.Usuario;
                    Fecha_registroDateEdit.EditValue = oCotizador.Fecha_registro;

                    HpResergerNube.CRM_Items_Cotizador oitem = new HpResergerNube.CRM_Items_Cotizador();
                    DataTable Titem = oitem.ReadItemsCotizacion(_idcotizacion);
                    if (Titem.Rows.Count > 0)
                    {
                        for (int i = 0; i < Titem.Rows.Count; i++)
                        {
                            btnAgregarITem.PerformClick();
                            HpResergerNube.CRM_Items_Cotizador xa = new HpResergerNube.CRM_Items_Cotizador();
                            xa.ID_Producto = Titem.Rows[i]["ID_Producto"].ToString();
                            xa.Cantidad_Producto = Titem.Rows[i]["Cantidad_Producto"].ToString();
                            xa.Costo_Unit_Producto = Titem.Rows[i]["Costo_Unit_Producto"].ToString();
                            xa.IGV_Producto = Titem.Rows[i]["IGV_Producto"].ToString();
                            xa.Precio_venta_Producto = Titem.Rows[i]["Precio_venta_Producto"].ToString();
                            bindingSource1.Add(xa);

                            //gridView3.SetRowCellValue(i, xID_Producto, Titem.Rows[i]["ID_Producto"]);
                            //gridView3.SetRowCellValue(i, xCantidad_Producto, Titem.Rows[i]["Cantidad_Producto"]);
                            //gridView3.SetRowCellValue(i, xCosto_Unit_Producto, Titem.Rows[i]["Costo_Unit_Producto"]);
                            //gridView3.SetRowCellValue(i, xIGV_Producto, Titem.Rows[i]["IGV_Producto"]);
                            //gridView3.SetRowCellValue(i, xPrecio_venta_Producto, Titem.Rows[i]["Precio_venta_Producto"]);


                        }
                    }
                }
            }


            calcular = true;

        }

        private void CargarCombos()
        {
            //cliejte
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable Tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            ID_Tipo_personaTextEdit.Properties.DataSource = Tcliente;
            ID_Tipo_personaTextEdit.Properties.ValueMember = "ID_Cliente";
            ID_Tipo_personaTextEdit.Properties.DisplayMember = "nombrecompleto";
            ID_Tipo_personaTextEdit.EditValue = Tcliente.Rows.Count > 0 ? Tcliente.Rows[0]["ID_Cliente"] : null;

            ID_Tipo_personaTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("nombrecompleto", "Nombre Completo");
            ID_Tipo_personaTextEdit.Properties.View.BestFitColumns();


            //proyectos
            HpResergerNube.CRM_ProyectoRepository oproyecto = new HpResergerNube.CRM_ProyectoRepository();
            DataTable tproyecto = oproyecto.GetAllProyectos();
            Cod_proyectoTextEdit.Properties.DataSource = tproyecto;
            Cod_proyectoTextEdit.Properties.ValueMember = "ID_Proyecto";
            Cod_proyectoTextEdit.Properties.DisplayMember = "Nombre_Proyecto";
            Cod_proyectoTextEdit.EditValue = tproyecto.Rows.Count > 0 ? tproyecto.Rows[0]["ID_Proyecto"] : null;

            Cod_proyectoTextEdit.Properties.View.Columns.Clear();
            Cod_proyectoTextEdit.Properties.View.Columns.AddVisible("Nombre_Proyecto", "Nombre Proyecto");
            Cod_proyectoTextEdit.Properties.View.Columns.AddVisible("Requerimiento", "Requerimiento");
            Cod_proyectoTextEdit.Properties.View.BestFitColumns();


            //MONEDA    
            HpResergerNube.CRM_MonedaRepository oMoneda = new HpResergerNube.CRM_MonedaRepository();
            DataTable TMoneda = oMoneda.GetAllMonedas();
            ID_MonedaTextEdit.Properties.DataSource = TMoneda;
            ID_MonedaTextEdit.Properties.ValueMember = "ID_Moneda";
            ID_MonedaTextEdit.Properties.DisplayMember = "Detalle_Moneda";
            ID_MonedaTextEdit.EditValue = TMoneda.Rows.Count > 0 ? TMoneda.Rows[0]["ID_Moneda"] : null;

            ID_MonedaTextEdit.Properties.View.Columns.Clear();
            ID_MonedaTextEdit.Properties.View.Columns.AddVisible("ID_Moneda", "Id");
            ID_MonedaTextEdit.Properties.View.Columns.AddVisible("Detalle_Moneda", "Moneda");
            ID_MonedaTextEdit.Properties.View.BestFitColumns();

            //usuario   
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();
            DataTable tusuario = ousuario.GetAllUsuarios();
            UsuarioTextEdit.Properties.DataSource = tusuario;
            UsuarioTextEdit.Properties.ValueMember = "ID_Usuario";
            UsuarioTextEdit.Properties.DisplayMember = "Nombre_Completo";
            UsuarioTextEdit.EditValue = tusuario.Rows.Count > 0 ? HPReserger.frmLogin.CodigoUsuario.ToString() : null;

            UsuarioTextEdit.Properties.View.Columns.Clear();
            UsuarioTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            UsuarioTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            UsuarioTextEdit.Properties.View.BestFitColumns();


            HpResergerNube.CRM_ProductoRepository oProducto = new HpResergerNube.CRM_ProductoRepository();
            repositoryItemSearchLookUpEdit1.DataSource = oProducto.ObtenerProductosYServicios();
            repositoryItemSearchLookUpEdit1.DisplayMember = "nombre";
            repositoryItemSearchLookUpEdit1.ValueMember = "id";
            repositoryItemSearchLookUpEdit1.View.Columns.AddField("id").Visible = true;
            repositoryItemSearchLookUpEdit1.View.Columns.AddField("nombre").Visible = true;
            repositoryItemSearchLookUpEdit1.View.Columns.AddField("precio").Visible = true;

            //repositoryItemSearchLookUpEdit1.View.col"codigo").Width = 100;
            //repositoryItemSearchLookUpEdit1.View.Columns("descripcion").Width = 300;
        }

        private void btnAgregarITem_Click(object sender, EventArgs e)
        {
            gridView3.AddNewRow();
            gridView3.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
            gridView3.Focus();

            foreach (GridColumn column in gridView3.VisibleColumns)
            {
                gridView3.FocusedColumn = column;
                gridView3.ShowEditor();
                if (gridView3.ActiveEditor != null)
                {
                    break;
                }
            }

        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (calcular)
            {
                if (e.Column == xID_Producto)
                {
                    string id = e.Value.ToString(); // Obtener el valor de la celda
                    HpResergerNube.CRM_ProductoRepository oproducto = new HpResergerNube.CRM_ProductoRepository();
                    DataTable TDatos = oproducto.ObtenerProductosYServiciosPorID(id, id); // Obtener datos por ID
                    if (TDatos.Rows.Count > 0)
                    {
                        // Asignar valores a otra celda
                        decimal.TryParse(TDatos.Rows[0]["Precio"].ToString(), out decimal valorDecimal);
                        decimal val = valorDecimal * 1m;
                        gridView3.SetRowCellValue(e.RowHandle, xCosto_Unit_Producto, val);
                    }
                }
                if (e.Column == xCantidad_Producto || e.Column == xCosto_Unit_Producto)
                {
                    if (decimal.TryParse(gridView3.GetRowCellValue(e.RowHandle, xCantidad_Producto)?.ToString(), out decimal cantidad) &&
                        decimal.TryParse(gridView3.GetRowCellValue(e.RowHandle, xCosto_Unit_Producto)?.ToString(), out decimal preciouni))
                    {
                        decimal igv = cantidad * preciouni * 0.18m;
                        decimal total = cantidad * preciouni * 1.18m;

                        gridView3.SetRowCellValue(e.RowHandle, xIGV_Producto, igv);
                        gridView3.SetRowCellValue(e.RowHandle, xPrecio_venta_Producto, total);

                        CostoTextEdit.EditValue = total - igv;
                        IGVTextEdit.EditValue = igv;
                        Precio_ventaTextEdit.EditValue = total;
                    }
                    else
                    {
                        // Manejar caso en que no se pueda convertir a decimal
                    }
                }
                gridControl1.BeginUpdate();
                gridControl1.Refresh();
                gridControl1.EndUpdate();
                calcularTotal();
            }

        }

        private void calcularTotal()
        {
            decimal totalcosto = 0;
            decimal totaligv = 0;
            decimal totalsuma = 0;

            // Iterar sobre cada fila del GridView
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                // Obtener el valor de la celda en la columna de interés (supongamos que es la columna xPrecio)
                object valorCelda = gridView3.GetRowCellValue(i, xPrecio_venta_Producto);
                object valorCelda1 = gridView3.GetRowCellValue(i, xIGV_Producto);
                object valorCelda2 = gridView3.GetRowCellValue(i, xCosto_Unit_Producto);
                // Verificar si el valor de la celda no es nulo y si es convertible a decimal
                if (valorCelda != null && decimal.TryParse(valorCelda.ToString(), out decimal valorDecimal))
                {
                    // Sumar el valor al total
                    totalsuma += valorDecimal;
                }
                if (valorCelda1 != null && decimal.TryParse(valorCelda1.ToString(), out decimal valorigv))
                {
                    // Sumar el valor al total
                    totaligv += valorigv;
                }
                if (valorCelda2 != null && decimal.TryParse(valorCelda2.ToString(), out decimal valorcosto))
                {
                    // Sumar el valor al total
                    totalcosto += valorcosto;
                }
            }
            if (totalsuma != 0)
            {
                // Utiliza el totalSuma como necesites
                CostoTextEdit.EditValue = totalcosto;
                IGVTextEdit.EditValue = totaligv;
                Precio_ventaTextEdit.EditValue = totalsuma;
            }
        }
    }
}
