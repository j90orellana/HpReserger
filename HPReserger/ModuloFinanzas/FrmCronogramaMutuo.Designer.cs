namespace SISGEM.ModuloFinanzas
{
    partial class FrmCronogramaMutuo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCronogramaMutuo));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xidMutuo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xAmortizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTransferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(831, 397);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xid,
            this.xidMutuo,
            this.xNro,
            this.xFecha,
            this.xPrincipal,
            this.xAmortizacion,
            this.xInteres,
            this.xCuota,
            this.xImpuesto,
            this.xTransferencia,
            this.xEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xid
            // 
            this.xid.Caption = "id";
            this.xid.FieldName = "id";
            this.xid.Name = "xid";
            // 
            // xidMutuo
            // 
            this.xidMutuo.Caption = "idMutuo";
            this.xidMutuo.FieldName = "idMutuo";
            this.xidMutuo.Name = "xidMutuo";
            // 
            // xNro
            // 
            this.xNro.Caption = "Nro";
            this.xNro.FieldName = "Nro";
            this.xNro.MaxWidth = 30;
            this.xNro.MinWidth = 30;
            this.xNro.Name = "xNro";
            this.xNro.OptionsColumn.ReadOnly = true;
            this.xNro.Visible = true;
            this.xNro.VisibleIndex = 0;
            this.xNro.Width = 30;
            // 
            // xFecha
            // 
            this.xFecha.Caption = "Fecha";
            this.xFecha.DisplayFormat.FormatString = "d";
            this.xFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFecha.FieldName = "Fecha";
            this.xFecha.MaxWidth = 70;
            this.xFecha.MinWidth = 70;
            this.xFecha.Name = "xFecha";
            this.xFecha.OptionsColumn.ReadOnly = true;
            this.xFecha.Visible = true;
            this.xFecha.VisibleIndex = 1;
            this.xFecha.Width = 70;
            // 
            // xPrincipal
            // 
            this.xPrincipal.Caption = "Principal";
            this.xPrincipal.DisplayFormat.FormatString = "n2";
            this.xPrincipal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xPrincipal.FieldName = "Principal";
            this.xPrincipal.MinWidth = 60;
            this.xPrincipal.Name = "xPrincipal";
            this.xPrincipal.OptionsColumn.ReadOnly = true;
            this.xPrincipal.Visible = true;
            this.xPrincipal.VisibleIndex = 2;
            this.xPrincipal.Width = 60;
            // 
            // xAmortizacion
            // 
            this.xAmortizacion.Caption = "Amortizacion";
            this.xAmortizacion.DisplayFormat.FormatString = "n2";
            this.xAmortizacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xAmortizacion.FieldName = "Amortizacion";
            this.xAmortizacion.MinWidth = 80;
            this.xAmortizacion.Name = "xAmortizacion";
            this.xAmortizacion.OptionsColumn.ReadOnly = true;
            this.xAmortizacion.Visible = true;
            this.xAmortizacion.VisibleIndex = 3;
            this.xAmortizacion.Width = 80;
            // 
            // xInteres
            // 
            this.xInteres.Caption = "Interes";
            this.xInteres.DisplayFormat.FormatString = "n2";
            this.xInteres.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xInteres.FieldName = "Interes";
            this.xInteres.MinWidth = 60;
            this.xInteres.Name = "xInteres";
            this.xInteres.OptionsColumn.ReadOnly = true;
            this.xInteres.Visible = true;
            this.xInteres.VisibleIndex = 4;
            this.xInteres.Width = 60;
            // 
            // xCuota
            // 
            this.xCuota.Caption = "Cuota";
            this.xCuota.DisplayFormat.FormatString = "n2";
            this.xCuota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xCuota.FieldName = "Cuota";
            this.xCuota.MinWidth = 50;
            this.xCuota.Name = "xCuota";
            this.xCuota.OptionsColumn.ReadOnly = true;
            this.xCuota.Visible = true;
            this.xCuota.VisibleIndex = 5;
            this.xCuota.Width = 50;
            // 
            // xImpuesto
            // 
            this.xImpuesto.Caption = "Impuesto";
            this.xImpuesto.DisplayFormat.FormatString = "n2";
            this.xImpuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xImpuesto.FieldName = "Impuesto";
            this.xImpuesto.MinWidth = 70;
            this.xImpuesto.Name = "xImpuesto";
            this.xImpuesto.OptionsColumn.ReadOnly = true;
            this.xImpuesto.Visible = true;
            this.xImpuesto.VisibleIndex = 6;
            this.xImpuesto.Width = 70;
            // 
            // xTransferencia
            // 
            this.xTransferencia.Caption = "Transferencia";
            this.xTransferencia.DisplayFormat.FormatString = "n2";
            this.xTransferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xTransferencia.FieldName = "Transferencia";
            this.xTransferencia.MinWidth = 80;
            this.xTransferencia.Name = "xTransferencia";
            this.xTransferencia.OptionsColumn.ReadOnly = true;
            this.xTransferencia.Visible = true;
            this.xTransferencia.VisibleIndex = 7;
            this.xTransferencia.Width = 80;
            // 
            // xEstado
            // 
            this.xEstado.Caption = "Estado";
            this.xEstado.FieldName = "Estado";
            this.xEstado.MinWidth = 90;
            this.xEstado.Name = "xEstado";
            this.xEstado.Visible = true;
            this.xEstado.VisibleIndex = 8;
            this.xEstado.Width = 391;
            // 
            // FrmCronogramaMutuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 397);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmCronogramaMutuo.IconOptions.Icon")));
            this.Name = "FrmCronogramaMutuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronograma del Mutuo";
            this.Load += new System.EventHandler(this.FrmCronogramaMutuo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xid;
        private DevExpress.XtraGrid.Columns.GridColumn xidMutuo;
        private DevExpress.XtraGrid.Columns.GridColumn xNro;
        private DevExpress.XtraGrid.Columns.GridColumn xFecha;
        private DevExpress.XtraGrid.Columns.GridColumn xPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn xAmortizacion;
        private DevExpress.XtraGrid.Columns.GridColumn xInteres;
        private DevExpress.XtraGrid.Columns.GridColumn xCuota;
        private DevExpress.XtraGrid.Columns.GridColumn xImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn xTransferencia;
        private DevExpress.XtraGrid.Columns.GridColumn xEstado;
    }
}