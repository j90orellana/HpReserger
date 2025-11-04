namespace SISGEM.ModuloContable
{
    partial class xBitacoraEmpleadoRegistros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xBitacoraEmpleadoRegistros));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dtpfecha = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpandirGrupo = new DevExpress.XtraBars.BarCheckItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bntMovimiento = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRegistros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 478);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dtpfecha);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Location = new System.Drawing.Point(6, 6);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(716, 466);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dtpfecha
            // 
            this.dtpfecha.EditValue = null;
            this.dtpfecha.Location = new System.Drawing.Point(91, 6);
            this.dtpfecha.MenuManager = this.barManager1;
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpfecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpfecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";
            this.dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfecha.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            this.dtpfecha.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dtpfecha.Size = new System.Drawing.Size(212, 20);
            this.dtpfecha.StyleController = this.dataLayoutControl1;
            this.dtpfecha.TabIndex = 7;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.btnCargar,
            this.bntMovimiento,
            this.btnExcel,
            this.btnExpandirGrupo});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar1.FloatSize = new System.Drawing.Size(169, 44);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCargar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExpandirGrupo, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 1;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.LargeImage")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // btnCargar
            // 
            this.btnCargar.Caption = "Cargar";
            this.btnCargar.Id = 5;
            this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
            this.btnCargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.LargeImage")));
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargar_ItemClick);
            // 
            // btnExpandirGrupo
            // 
            this.btnExpandirGrupo.Caption = "Expandir Grupo";
            this.btnExpandirGrupo.Id = 9;
            this.btnExpandirGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandirGrupo.ImageOptions.Image")));
            this.btnExpandirGrupo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExpandirGrupo.ImageOptions.LargeImage")));
            this.btnExpandirGrupo.Name = "btnExpandirGrupo";
            this.btnExpandirGrupo.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpandirGrupo_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel";
            this.btnExcel.Id = 7;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(728, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(728, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(728, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // bntMovimiento
            // 
            this.bntMovimiento.Caption = "Movimientos Sueltos";
            this.bntMovimiento.Id = 6;
            this.bntMovimiento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntMovimiento.ImageOptions.Image")));
            this.bntMovimiento.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntMovimiento.ImageOptions.LargeImage")));
            this.bntMovimiento.Name = "bntMovimiento";
            this.bntMovimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(704, 432);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xUsuario,
            this.xFecha,
            this.xHora,
            this.xRegistros});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "fecha", this.xFecha, "Registros {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "registros", this.xRegistros, "SUMA {0:#.##}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.xUsuario, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // xUsuario
            // 
            this.xUsuario.Caption = "Usuario";
            this.xUsuario.FieldName = "usuario";
            this.xUsuario.MinWidth = 80;
            this.xUsuario.Name = "xUsuario";
            this.xUsuario.OptionsColumn.AllowEdit = false;
            this.xUsuario.OptionsColumn.ReadOnly = true;
            this.xUsuario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Empresa", "{0}", 0)});
            this.xUsuario.Visible = true;
            this.xUsuario.VisibleIndex = 0;
            this.xUsuario.Width = 80;
            // 
            // xFecha
            // 
            this.xFecha.Caption = "Fecha";
            this.xFecha.DisplayFormat.FormatString = "d";
            this.xFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFecha.FieldName = "fecha";
            this.xFecha.MaxWidth = 120;
            this.xFecha.Name = "xFecha";
            this.xFecha.OptionsColumn.AllowEdit = false;
            this.xFecha.OptionsColumn.ReadOnly = true;
            this.xFecha.Visible = true;
            this.xFecha.VisibleIndex = 1;
            // 
            // xHora
            // 
            this.xHora.Caption = "Hora";
            this.xHora.FieldName = "hora";
            this.xHora.MaxWidth = 80;
            this.xHora.Name = "xHora";
            this.xHora.OptionsColumn.AllowEdit = false;
            this.xHora.OptionsColumn.ReadOnly = true;
            this.xHora.Visible = true;
            this.xHora.VisibleIndex = 2;
            // 
            // xRegistros
            // 
            this.xRegistros.Caption = "Registros";
            this.xRegistros.FieldName = "registros";
            this.xRegistros.MaxWidth = 120;
            this.xRegistros.Name = "xRegistros";
            this.xRegistros.OptionsColumn.AllowEdit = false;
            this.xRegistros.OptionsColumn.ReadOnly = true;
            this.xRegistros.Visible = true;
            this.xRegistros.VisibleIndex = 3;
            this.xRegistros.Width = 100;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(716, 466);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(706, 434);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtpfecha;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(299, 22);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(299, 22);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 22);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Mes de Registros";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(299, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(728, 478);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(718, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xBitacoraEmpleadoRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 500);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("xBitacoraEmpleadoRegistros.IconOptions.Icon")));
            this.Name = "xBitacoraEmpleadoRegistros";
            this.Text = "Registros Contables por Usuario";
            this.Load += new System.EventHandler(this.xBitacoraEmpleadoRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarButtonItem btnCargar;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bntMovimiento;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn xFecha;
        private DevExpress.XtraGrid.Columns.GridColumn xRegistros;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dtpfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn xHora;
        private DevExpress.XtraBars.BarCheckItem btnExpandirGrupo;
    }
}