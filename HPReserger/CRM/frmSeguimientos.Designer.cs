namespace SISGEM.CRM
{
    partial class frmSeguimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xID_Proyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XNombre_Proyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XDetalle_Tipo_Seguimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xSaldo_Dolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNombre_Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFecha_Seguimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFecha_Prox_Seguimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtpFechaa = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechade = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaa.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechade.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Personalizada 2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Exportar Excel";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cerrar";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1099, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1099, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1099, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnFiltrar);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dtpFechade);
            this.layoutControl1.Controls.Add(this.dtpFechaa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1099, 454);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1099, 454);
            this.Root.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1087, 418);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xID_Proyecto,
            this.XNombre_Proyecto,
            this.XDetalle_Tipo_Seguimiento,
            this.xSaldo_Dolares,
            this.xNombre_Usuario,
            this.xContacto,
            this.xFecha_Seguimiento,
            this.xFecha_Prox_Seguimiento,
            this.xDescripcion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xID_Proyecto
            // 
            this.xID_Proyecto.Caption = "ID";
            this.xID_Proyecto.FieldName = "ID_Proyecto";
            this.xID_Proyecto.MaxWidth = 60;
            this.xID_Proyecto.MinWidth = 60;
            this.xID_Proyecto.Name = "xID_Proyecto";
            this.xID_Proyecto.OptionsColumn.ReadOnly = true;
            this.xID_Proyecto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID_Proyecto", "{0}", 0)});
            this.xID_Proyecto.Visible = true;
            this.xID_Proyecto.VisibleIndex = 0;
            this.xID_Proyecto.Width = 60;
            // 
            // XNombre_Proyecto
            // 
            this.XNombre_Proyecto.Caption = "Nombre Proyecto";
            this.XNombre_Proyecto.FieldName = "Nombre_Proyecto";
            this.XNombre_Proyecto.MinWidth = 200;
            this.XNombre_Proyecto.Name = "XNombre_Proyecto";
            this.XNombre_Proyecto.OptionsColumn.ReadOnly = true;
            this.XNombre_Proyecto.Visible = true;
            this.XNombre_Proyecto.VisibleIndex = 1;
            this.XNombre_Proyecto.Width = 201;
            // 
            // XDetalle_Tipo_Seguimiento
            // 
            this.XDetalle_Tipo_Seguimiento.Caption = "Tipo Seg.";
            this.XDetalle_Tipo_Seguimiento.FieldName = "Detalle_Tipo_Seguimiento\r\n";
            this.XDetalle_Tipo_Seguimiento.MinWidth = 100;
            this.XDetalle_Tipo_Seguimiento.Name = "XDetalle_Tipo_Seguimiento";
            this.XDetalle_Tipo_Seguimiento.OptionsColumn.ReadOnly = true;
            this.XDetalle_Tipo_Seguimiento.Visible = true;
            this.XDetalle_Tipo_Seguimiento.VisibleIndex = 2;
            this.XDetalle_Tipo_Seguimiento.Width = 104;
            // 
            // xSaldo_Dolares
            // 
            this.xSaldo_Dolares.Caption = "SaldoDolares";
            this.xSaldo_Dolares.FieldName = "Saldo_Dolares";
            this.xSaldo_Dolares.MaxWidth = 100;
            this.xSaldo_Dolares.MinWidth = 80;
            this.xSaldo_Dolares.Name = "xSaldo_Dolares";
            this.xSaldo_Dolares.OptionsColumn.AllowEdit = false;
            this.xSaldo_Dolares.Width = 95;
            // 
            // xNombre_Usuario
            // 
            this.xNombre_Usuario.Caption = "Nombre Usuario";
            this.xNombre_Usuario.FieldName = "Nombre_Usuario";
            this.xNombre_Usuario.MinWidth = 100;
            this.xNombre_Usuario.Name = "xNombre_Usuario";
            this.xNombre_Usuario.OptionsColumn.ReadOnly = true;
            this.xNombre_Usuario.Visible = true;
            this.xNombre_Usuario.VisibleIndex = 3;
            this.xNombre_Usuario.Width = 112;
            // 
            // xContacto
            // 
            this.xContacto.Caption = "Contacto";
            this.xContacto.FieldName = "Contacto";
            this.xContacto.MinWidth = 80;
            this.xContacto.Name = "xContacto";
            this.xContacto.OptionsColumn.ReadOnly = true;
            this.xContacto.Visible = true;
            this.xContacto.VisibleIndex = 4;
            this.xContacto.Width = 104;
            // 
            // xFecha_Seguimiento
            // 
            this.xFecha_Seguimiento.Caption = "Fecha Seg.";
            this.xFecha_Seguimiento.DisplayFormat.FormatString = "d";
            this.xFecha_Seguimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFecha_Seguimiento.FieldName = "Fecha_Seguimiento\r\n";
            this.xFecha_Seguimiento.MaxWidth = 80;
            this.xFecha_Seguimiento.MinWidth = 80;
            this.xFecha_Seguimiento.Name = "xFecha_Seguimiento";
            this.xFecha_Seguimiento.OptionsColumn.ReadOnly = true;
            this.xFecha_Seguimiento.Visible = true;
            this.xFecha_Seguimiento.VisibleIndex = 5;
            this.xFecha_Seguimiento.Width = 80;
            // 
            // xFecha_Prox_Seguimiento
            // 
            this.xFecha_Prox_Seguimiento.Caption = "Prox Seg.";
            this.xFecha_Prox_Seguimiento.DisplayFormat.FormatString = "d";
            this.xFecha_Prox_Seguimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFecha_Prox_Seguimiento.FieldName = "Fecha_Prox_Seguimiento\r\n";
            this.xFecha_Prox_Seguimiento.MaxWidth = 80;
            this.xFecha_Prox_Seguimiento.MinWidth = 80;
            this.xFecha_Prox_Seguimiento.Name = "xFecha_Prox_Seguimiento";
            this.xFecha_Prox_Seguimiento.OptionsColumn.ReadOnly = true;
            this.xFecha_Prox_Seguimiento.Visible = true;
            this.xFecha_Prox_Seguimiento.VisibleIndex = 6;
            this.xFecha_Prox_Seguimiento.Width = 80;
            // 
            // xDescripcion
            // 
            this.xDescripcion.Caption = "Descripcion\r\n";
            this.xDescripcion.ColumnEdit = this.repositoryItemMemoEdit1;
            this.xDescripcion.FieldName = "Descripcion\r\n";
            this.xDescripcion.MinWidth = 200;
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.OptionsColumn.ReadOnly = true;
            this.xDescripcion.Visible = true;
            this.xDescripcion.VisibleIndex = 7;
            this.xDescripcion.Width = 233;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Actualizar", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Actualizar nombre", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1089, 420);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dtpFechaa
            // 
            this.dtpFechaa.EditValue = null;
            this.dtpFechaa.Location = new System.Drawing.Point(301, 6);
            this.dtpFechaa.Name = "dtpFechaa";
            this.dtpFechaa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaa.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaa.StyleController = this.layoutControl1;
            this.dtpFechaa.TabIndex = 4;
            // 
            // dtpFechade
            // 
            this.dtpFechade.EditValue = null;
            this.dtpFechade.Location = new System.Drawing.Point(81, 6);
            this.dtpFechade.Name = "dtpFechade";
            this.dtpFechade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechade.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechade.Size = new System.Drawing.Size(135, 20);
            this.dtpFechade.StyleController = this.layoutControl1;
            this.dtpFechade.TabIndex = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtpFechade;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "Fechas Desde:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(220, 22);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(220, 22);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Fechas Desde:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpFechaa;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Fecha Hasta:";
            this.layoutControlItem2.Location = new System.Drawing.Point(220, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(220, 22);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(220, 22);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Fecha Hasta:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem3.Location = new System.Drawing.Point(500, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(589, 24);
            this.emptySpaceItem3.Text = "emptySpaceItem1";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(446, 6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(58, 22);
            this.btnFiltrar.StyleController = this.layoutControl1;
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnFiltrar;
            this.layoutControlItem3.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(60, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(60, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(60, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.WordWrap = false;
            // 
            // frmSeguimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 478);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSeguimientos.IconOptions.Icon")));
            this.Name = "frmSeguimientos";
            this.Text = "Listado de Seguimientos";
            this.Load += new System.EventHandler(this.frmSeguimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaa.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechade.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xID_Proyecto;
        private DevExpress.XtraGrid.Columns.GridColumn XNombre_Proyecto;
        private DevExpress.XtraGrid.Columns.GridColumn XDetalle_Tipo_Seguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn xSaldo_Dolares;
        private DevExpress.XtraGrid.Columns.GridColumn xNombre_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn xContacto;
        private DevExpress.XtraGrid.Columns.GridColumn xFecha_Seguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn xFecha_Prox_Seguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn xDescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dtpFechade;
        private DevExpress.XtraEditors.DateEdit dtpFechaa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}