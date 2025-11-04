namespace SISGEM.ModuloContable
{
    partial class frmRazonesSocialesAsientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRazonesSocialesAsientos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.btnReemplazarTodo = new DevExpress.XtraBars.BarButtonItem();
            this.chkAgruparRucs = new DevExpress.XtraBars.BarCheckItem();
            this.btnExpandir = new DevExpress.XtraBars.BarCheckItem();
            this.chkFiltrarDatos = new DevExpress.XtraBars.BarCheckItem();
            this.lbldatos = new DevExpress.XtraBars.BarStaticItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRazonSocialReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRazonSocialGuardada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReemplazarFila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar6,
            this.bar7});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCerrar,
            this.lbldatos,
            this.chkAgruparRucs,
            this.chkFiltrarDatos,
            this.btnExpandir,
            this.btnRefrescar,
            this.btnReemplazarTodo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar7;
            // 
            // bar2
            // 
            this.bar2.BarName = "MainMenu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.HideWhenMerging = DevExpress.Utils.DefaultBoolean.False;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefrescar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReemplazarTodo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkAgruparRucs, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExpandir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chkFiltrarDatos, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbldatos, true)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "MainMenu";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Id = 0;
            this.btnCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.Image")));
            this.btnCerrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ImageOptions.LargeImage")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Caption = "Recargar";
            this.btnRefrescar.Id = 8;
            this.btnRefrescar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.Image")));
            this.btnRefrescar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.ImageOptions.LargeImage")));
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrescar_ItemClick);
            // 
            // btnReemplazarTodo
            // 
            this.btnReemplazarTodo.Caption = "Reemplazar Todo";
            this.btnReemplazarTodo.Id = 9;
            this.btnReemplazarTodo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReemplazarTodo.ImageOptions.Image")));
            this.btnReemplazarTodo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReemplazarTodo.ImageOptions.LargeImage")));
            this.btnReemplazarTodo.Name = "btnReemplazarTodo";
            this.btnReemplazarTodo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReemplazarTodo_ItemClick);
            // 
            // chkAgruparRucs
            // 
            this.chkAgruparRucs.Caption = "Agrupar Rucs";
            this.chkAgruparRucs.Id = 5;
            this.chkAgruparRucs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkAgruparRucs.ImageOptions.Image")));
            this.chkAgruparRucs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkAgruparRucs.ImageOptions.LargeImage")));
            this.chkAgruparRucs.Name = "chkAgruparRucs";
            this.chkAgruparRucs.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkAgruparRucs_CheckedChanged);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Caption = "Expandir Grupo";
            this.btnExpandir.Id = 7;
            this.btnExpandir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.ImageOptions.Image")));
            this.btnExpandir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExpandir.ImageOptions.LargeImage")));
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpandir_CheckedChanged);
            // 
            // chkFiltrarDatos
            // 
            this.chkFiltrarDatos.Caption = "Filtrar";
            this.chkFiltrarDatos.Id = 6;
            this.chkFiltrarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chkFiltrarDatos.ImageOptions.Image")));
            this.chkFiltrarDatos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("chkFiltrarDatos.ImageOptions.LargeImage")));
            this.chkFiltrarDatos.Name = "chkFiltrarDatos";
            this.chkFiltrarDatos.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkFiltrarDatos_CheckedChanged);
            // 
            // lbldatos
            // 
            this.lbldatos.Caption = "Datos:";
            this.lbldatos.Id = 3;
            this.lbldatos.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldatos.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.ItemAppearance.Disabled.Options.UseFont = true;
            this.lbldatos.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.lbldatos.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbldatos.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.ItemAppearance.Normal.Options.UseFont = true;
            this.lbldatos.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bar6
            // 
            this.bar6.BarName = "Tools";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 1;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.Text = "Tools";
            this.bar6.Visible = false;
            // 
            // bar7
            // 
            this.bar7.BarName = "StatusBar";
            this.bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "StatusBar";
            this.bar7.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(644, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 436);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(644, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(644, 42);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 42);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(644, 394);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(632, 382);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xTipo,
            this.xRUC,
            this.xRazonSocialReal,
            this.xRazonSocialGuardada,
            this.btnReemplazarFila});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xTipo
            // 
            this.xTipo.Caption = "Tipo";
            this.xTipo.FieldName = "Tipo";
            this.xTipo.MinWidth = 120;
            this.xTipo.Name = "xTipo";
            this.xTipo.OptionsColumn.AllowEdit = false;
            this.xTipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Tipo", "{0}", 0)});
            this.xTipo.Visible = true;
            this.xTipo.VisibleIndex = 0;
            this.xTipo.Width = 142;
            // 
            // xRUC
            // 
            this.xRUC.Caption = "RUC";
            this.xRUC.FieldName = "RUC";
            this.xRUC.MaxWidth = 100;
            this.xRUC.MinWidth = 100;
            this.xRUC.Name = "xRUC";
            this.xRUC.OptionsColumn.AllowEdit = false;
            this.xRUC.Visible = true;
            this.xRUC.VisibleIndex = 1;
            this.xRUC.Width = 100;
            // 
            // xRazonSocialReal
            // 
            this.xRazonSocialReal.Caption = "RazonSocialReal";
            this.xRazonSocialReal.FieldName = "RazonSocialReal";
            this.xRazonSocialReal.MinWidth = 100;
            this.xRazonSocialReal.Name = "xRazonSocialReal";
            this.xRazonSocialReal.OptionsColumn.AllowEdit = false;
            this.xRazonSocialReal.Visible = true;
            this.xRazonSocialReal.VisibleIndex = 2;
            this.xRazonSocialReal.Width = 124;
            // 
            // xRazonSocialGuardada
            // 
            this.xRazonSocialGuardada.Caption = "RazonSocialGuardada";
            this.xRazonSocialGuardada.FieldName = "RazonSocialGuardada";
            this.xRazonSocialGuardada.MinWidth = 100;
            this.xRazonSocialGuardada.Name = "xRazonSocialGuardada";
            this.xRazonSocialGuardada.OptionsColumn.AllowEdit = false;
            this.xRazonSocialGuardada.Visible = true;
            this.xRazonSocialGuardada.VisibleIndex = 3;
            this.xRazonSocialGuardada.Width = 160;
            // 
            // btnReemplazarFila
            // 
            this.btnReemplazarFila.Caption = "Reemplazar Fila";
            this.btnReemplazarFila.ColumnEdit = this.repositoryItemButtonEdit1;
            this.btnReemplazarFila.MaxWidth = 85;
            this.btnReemplazarFila.Name = "btnReemplazarFila";
            this.btnReemplazarFila.Visible = true;
            this.btnReemplazarFila.VisibleIndex = 4;
            this.btnReemplazarFila.Width = 85;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Actualizar", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Actualizar nombre", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(644, 394);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(634, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmRazonesSocialesAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 456);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmRazonesSocialesAsientos.IconOptions.Icon")));
            this.Name = "frmRazonesSocialesAsientos";
            this.Text = "Revisión de Razon Social en Asientos Contables";
            this.Load += new System.EventHandler(this.frmRazonesSocialesAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarCheckItem chkAgruparRucs;
        private DevExpress.XtraBars.BarCheckItem chkFiltrarDatos;
        private DevExpress.XtraBars.BarStaticItem lbldatos;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xTipo;
        private DevExpress.XtraGrid.Columns.GridColumn xRazonSocialReal;
        private DevExpress.XtraGrid.Columns.GridColumn xRazonSocialGuardada;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn xRUC;
        private DevExpress.XtraBars.BarCheckItem btnExpandir;
        private DevExpress.XtraBars.BarButtonItem btnRefrescar;
        private DevExpress.XtraBars.BarButtonItem btnReemplazarTodo;
        private DevExpress.XtraGrid.Columns.GridColumn btnReemplazarFila;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}