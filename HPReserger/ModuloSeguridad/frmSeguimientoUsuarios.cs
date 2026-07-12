using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SISGEM.ModuloSeguridad
{
    public partial class frmSeguimientoUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmSeguimientoUsuarios()
        {
            InitializeComponent();
        }

        private void frmSeguimientoUsuarios_Load(object sender, EventArgs e)
        {
            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";

            dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;

            dtpfecha.EditValue = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Auditoria.CLS_LogAuditoria clAuditoria = new HPResergerCapaLogica.Auditoria.CLS_LogAuditoria();
            if (dtpfecha.EditValue != null)
                gridControl1.DataSource = clAuditoria.Listar((DateTime)dtpfecha.EditValue);

          
            gridView1.BeginUpdate();
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                col.BestFit();
            }
            gridView1.EndUpdate();
        }
    }
}