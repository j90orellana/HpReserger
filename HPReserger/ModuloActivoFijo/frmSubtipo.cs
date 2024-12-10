using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloAlmacen
{
    public partial class frmSubtipo : XtraForm
    {
        public frmSubtipo()
        {
            InitializeComponent();
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmTabla18_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargaDatos();

        }

        private void CargarCombos()
        {

            HPResergerCapaLogica.Contable.ClaseContable obclase = new HPResergerCapaLogica.Contable.ClaseContable();
            DataTable TablaCuentas = obclase.ListarCuentasContablesActivas();

            HPResergerCapaLogica.TiposActivoFijos ActClase = new HPResergerCapaLogica.TiposActivoFijos();


            repositoryItemSearchCtaContable.DataSource = TablaCuentas.Copy();
            repositoryItemSearchCtaContable.DisplayMember = "Cuenta_Contable";
            repositoryItemSearchCtaContable.ValueMember = "Id_Cuenta_Contable";
            //COLUMNAS
            repositoryItemSearchCtaContable.View.Columns.Clear();
            repositoryItemSearchCtaContable.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable"); // Primera columna
            repositoryItemSearchCtaContable.View.Columns.AddVisible("Id_Cuenta_Contable", "ID Cuenta Contable"); // Segunda columna
            repositoryItemSearchCtaContable.View.Columns["Id_Cuenta_Contable"].Visible = false;
            

            repositoryItemSearchCtaDepreciacion.DataSource = TablaCuentas.Copy();
            repositoryItemSearchCtaDepreciacion.DisplayMember = "Cuenta_Contable";
            repositoryItemSearchCtaDepreciacion.ValueMember = "Id_Cuenta_Contable";
            //COLUMNAS
            repositoryItemSearchCtaDepreciacion.View.Columns.Clear();
            repositoryItemSearchCtaDepreciacion.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable"); // Primera columna
            repositoryItemSearchCtaDepreciacion.View.Columns.AddVisible("Id_Cuenta_Contable", "ID Cuenta Contable"); // Segunda columna
            repositoryItemSearchCtaDepreciacion.View.Columns["Id_Cuenta_Contable"].Visible = false;


            repositoryItemSearchGastoEnajenacion.DataSource = TablaCuentas.Copy();
            repositoryItemSearchGastoEnajenacion.DisplayMember = "Cuenta_Contable";
            repositoryItemSearchGastoEnajenacion.ValueMember = "Id_Cuenta_Contable";
            //COLUMNAS
            repositoryItemSearchGastoEnajenacion.View.Columns.Clear();
            repositoryItemSearchGastoEnajenacion.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable"); // Primera columna
            repositoryItemSearchGastoEnajenacion.View.Columns.AddVisible("Id_Cuenta_Contable", "ID Cuenta Contable"); // Segunda columna
            repositoryItemSearchGastoEnajenacion.View.Columns["Id_Cuenta_Contable"].Visible = false;


            repositoryItemSearchIngresoEnajenacion.DataSource = TablaCuentas.Copy();
            repositoryItemSearchIngresoEnajenacion.DisplayMember = "Cuenta_Contable";
            repositoryItemSearchIngresoEnajenacion.ValueMember = "Id_Cuenta_Contable";
            //COLUMNAS
            repositoryItemSearchIngresoEnajenacion.View.Columns.Clear();
            repositoryItemSearchIngresoEnajenacion.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable"); // Primera columna
            repositoryItemSearchIngresoEnajenacion.View.Columns.AddVisible("Id_Cuenta_Contable", "ID Cuenta Contable"); // Segunda columna
            repositoryItemSearchIngresoEnajenacion.View.Columns["Id_Cuenta_Contable"].Visible = false;


            repositoryItemSearchContableGasto.DataSource = TablaCuentas.Copy();
            repositoryItemSearchContableGasto.DisplayMember = "Cuenta_Contable";
            repositoryItemSearchContableGasto.ValueMember = "Id_Cuenta_Contable";
            //COLUMNAS
            repositoryItemSearchContableGasto.View.Columns.Clear();
            repositoryItemSearchContableGasto.View.Columns.AddVisible("Cuenta_Contable", "Cuenta Contable"); // Primera columna
            repositoryItemSearchContableGasto.View.Columns.AddVisible("Id_Cuenta_Contable", "ID Cuenta Contable"); // Segunda columna
            repositoryItemSearchContableGasto.View.Columns["Id_Cuenta_Contable"].Visible = false;


            repositoryItemSearchTipoActivo.DataSource = ActClase.GetAll();
            repositoryItemSearchTipoActivo.DisplayMember = "Nombre";
            repositoryItemSearchTipoActivo.ValueMember = "pkid";
            //COLUMNAS
            repositoryItemSearchTipoActivo.View.Columns.Clear();
            repositoryItemSearchTipoActivo.View.Columns.AddVisible("Nombre", "Nombre"); // Primera columna
            //repositoryItemSearchTipoActivo.View.Columns.AddVisible("pkid", "pkid"); // Primera columna

        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.oSubTipo oclase = new HPResergerCapaLogica.oSubTipo
            {
                Pkid = 0,
                Descripcion = "Nuevo",
                Abreviatura = "",
                TipoActivo = 0,
                CtaContable = "",
                CtaContableDepreciacion = "",
                CtaContableGasto = "",
                PorcentajeDepreciacion = 0,
                CtaGastoEnajenacion = "",
                CtaIngresoEnajenacion = "",
                Estado = 1
            };

            // Instanciar el CRUD y actualizar la base de datos
            HPResergerCapaLogica.SubTiposActivoFijos crud = new HPResergerCapaLogica.SubTiposActivoFijos();

            if (crud.Insert(oclase))
            {
                //XtraMessageBox.Show("La Operación se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaDatos();
            }
            else
            {
                XtraMessageBox.Show("Hubo un error al intentar el Proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaDatos()
        {
            HPResergerCapaLogica.SubTiposActivoFijos oclasebaja = new HPResergerCapaLogica.SubTiposActivoFijos();

            gridControl1.DataSource = oclasebaja.GetAll();
            gridView1.BestFitColumns();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "pkid"));
            string descripcion = gridView1.GetRowCellValue(rowHandle, "Descripcion").ToString();
            string abreviatura = gridView1.GetRowCellValue(rowHandle, "Abreviatura").ToString();
            int tipoActivo = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "TipoActivo"));
            string _CtaContable = gridView1.GetRowCellValue(rowHandle, "CtaContable").ToString();
            string _CtaContableDepreciacion = gridView1.GetRowCellValue(rowHandle, "CtaContableDepreciacion").ToString();
            string _CtaContableGasto = gridView1.GetRowCellValue(rowHandle, "CtaContableGasto").ToString();
            string _CtaGastoEnajenacion = gridView1.GetRowCellValue(rowHandle, "CtaGastoEnajenacion").ToString();
            string _CtaIngresoEnajenacion = gridView1.GetRowCellValue(rowHandle, "CtaIngresoEnajenacion").ToString();
            decimal _PorcentajeDepreciacion = Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "PorcentajeDepreciacion"));


            int estado = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Estado"));
            int usuario = HPReserger.frmLogin.CodigoUsuario;
            DateTime fecha = DateTime.Now;

            // Actualizar en la base de datos
            HPResergerCapaLogica.oSubTipo oclase = new HPResergerCapaLogica.oSubTipo
            {
                Pkid = id,
                Descripcion = descripcion,
                Abreviatura = abreviatura,
                TipoActivo = tipoActivo,
                CtaContable = _CtaContable,
                CtaContableDepreciacion = _CtaContableDepreciacion,
                CtaContableGasto = _CtaContableGasto,
                PorcentajeDepreciacion = _PorcentajeDepreciacion,
                CtaGastoEnajenacion = _CtaGastoEnajenacion,
                CtaIngresoEnajenacion = _CtaIngresoEnajenacion,
                Estado = 1
            };
            // Instanciar el CRUD y actualizar la base de datos
            HPResergerCapaLogica.SubTiposActivoFijos crud = new HPResergerCapaLogica.SubTiposActivoFijos();
            if (id == 0)
            {
                crud.Insert(oclase);
                CargaDatos();
            }
            else
            {
                crud.Update(oclase);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var Fila = gridView1.GetFocusedDataRow();
            if (Fila == null)
            {
                XtraMessageBox.Show("No se ha seleccionado ningún registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                HPResergerCapaLogica.SubTiposActivoFijos crud = new HPResergerCapaLogica.SubTiposActivoFijos();
                bool eliminado = crud.EliminarxEstado((int)Fila[0]);

                if (eliminado)
                {
                    //XtraMessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaDatos();
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarCombos();
        }
    }
}
