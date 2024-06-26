﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmTipoCliente : XtraForm
    {
        public frmTipoCliente()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl3);
        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Tipo Clientes.xlsx";
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Exportar los datos del GridControl a un archivo de Excel
                    GridView gridView = (GridView)gridControl.MainView;
                    gridView.ExportToXlsx(saveFileDialog.FileName, new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFile });

                    // Mostrar un mensaje de éxito
                    XtraMessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el archivo de Excel guardado
                    Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje en caso de error
                    XtraMessageBox.Show("Hubo un error al exportar los datos a Excel: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje si el usuario cancela
                XtraMessageBox.Show("La exportación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            HpResergerNube.CRM_Tipo_Cliente oTipoCliente = new HpResergerNube.CRM_Tipo_Cliente();
            gridControl3.DataSource = oTipoCliente.GetAll();
        }

        private void frmTipoCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xID_Tipo_Cliente.FieldName);
                frmAddTipoCliente xcliente = new frmAddTipoCliente();
                xcliente._tipoCliente = cellValue.ToString();
                xcliente.Owner = this;
                xcliente.Show();
            }
        }

        private void frmTipoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddTipoCliente xcliente = new frmAddTipoCliente();
            xcliente._tipoCliente = "";
            xcliente.Owner = this;
            xcliente.Show();
        }
    }
}
