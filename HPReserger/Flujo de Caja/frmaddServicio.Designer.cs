namespace SISGEM.Flujo_de_Caja
{
    partial class frmaddServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddServicio));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRecargaCombos = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarFila = new DevExpress.XtraBars.BarButtonItem();
            this.btnCarga = new DevExpress.XtraBars.BarButtonItem();
            this.bntEliminarCargaMasiva = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.lblEstado = new DevExpress.XtraBars.BarStaticItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xNcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDescripción = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xNTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCodigoPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xPatidaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xCabecera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.btnCerrar,
            this.btnRecargaCombos,
            this.btnGuardar,
            this.btnNuevo,
            this.lblEstado,
            this.btnCarga,
            this.bntEliminarCargaMasiva,
            this.btnEliminarFila,
            this.btnExportarExcel});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRecargaCombos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarFila, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExportarExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCarga, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bntEliminarCargaMasiva, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 6;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnRecargaCombos
            // 
            this.btnRecargaCombos.Caption = "Recargar Grilla";
            this.btnRecargaCombos.Id = 4;
            this.btnRecargaCombos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargaCombos.ImageOptions.Image")));
            this.btnRecargaCombos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRecargaCombos.ImageOptions.LargeImage")));
            this.btnRecargaCombos.Name = "btnRecargaCombos";
            this.btnRecargaCombos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecargaCombos_ItemClick);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Caption = "Eliminar Fila";
            this.btnEliminarFila.Id = 10;
            this.btnEliminarFila.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFila.ImageOptions.Image")));
            this.btnEliminarFila.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarFila.ImageOptions.LargeImage")));
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarFila_ItemClick);
            // 
            // btnCarga
            // 
            this.btnCarga.Caption = "Carga Masiva";
            this.btnCarga.Id = 8;
            this.btnCarga.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCarga.ImageOptions.Image")));
            this.btnCarga.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCarga.ImageOptions.LargeImage")));
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCarga_ItemClick);
            // 
            // bntEliminarCargaMasiva
            // 
            this.bntEliminarCargaMasiva.Caption = "Eliminar Carga Masiva";
            this.bntEliminarCargaMasiva.Id = 9;
            this.bntEliminarCargaMasiva.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntEliminarCargaMasiva.ImageOptions.Image")));
            this.bntEliminarCargaMasiva.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntEliminarCargaMasiva.ImageOptions.LargeImage")));
            this.bntEliminarCargaMasiva.Name = "bntEliminarCargaMasiva";
            this.bntEliminarCargaMasiva.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bntEliminarCargaMasiva.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntEliminarCargaMasiva_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(786, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 365);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(786, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(786, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 5;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            // 
            // lblEstado
            // 
            this.lblEstado.Caption = "Nuevo Activo Fijo";
            this.lblEstado.Id = 7;
            this.lblEstado.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.ItemAppearance.Normal.Options.UseFont = true;
            this.lblEstado.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblEstado.Name = "lblEstado";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(786, 345);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(774, 333);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xId,
            this.xNTipo,
            this.xNcodigo,
            this.xCodigoPadre,
            this.xPatidaPadre,
            this.xCodigo,
            this.xDescripción,
            this.xTipo,
            this.xCabecera,
            this.xtag,
            this.xEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese Texto a Buscar";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // xId
            // 
            this.xId.Caption = "Id";
            this.xId.FieldName = "Id";
            this.xId.Name = "xId";
            // 
            // xNcodigo
            // 
            this.xNcodigo.Caption = "codigo";
            this.xNcodigo.FieldName = "Ncodigo";
            this.xNcodigo.MaxWidth = 120;
            this.xNcodigo.Name = "xNcodigo";
            // 
            // xDescripción
            // 
            this.xDescripción.Caption = "Descripcion";
            this.xDescripción.FieldName = "Descripcion";
            this.xDescripción.MinWidth = 100;
            this.xDescripción.Name = "xDescripción";
            this.xDescripción.Visible = true;
            this.xDescripción.VisibleIndex = 4;
            this.xDescripción.Width = 100;
            // 
            // xtag
            // 
            this.xtag.Caption = "tag";
            this.xtag.FieldName = "tag";
            this.xtag.Name = "xtag";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(786, 345);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(776, 335);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xNTipo
            // 
            this.xNTipo.Caption = "Tipo";
            this.xNTipo.FieldName = "NTipo";
            this.xNTipo.MaxWidth = 120;
            this.xNTipo.MinWidth = 90;
            this.xNTipo.Name = "xNTipo";
            this.xNTipo.Visible = true;
            this.xNTipo.VisibleIndex = 0;
            this.xNTipo.Width = 90;
            // 
            // xCodigoPadre
            // 
            this.xCodigoPadre.Caption = "Codigo Padre";
            this.xCodigoPadre.FieldName = "CodigoPadre";
            this.xCodigoPadre.MaxWidth = 90;
            this.xCodigoPadre.MinWidth = 90;
            this.xCodigoPadre.Name = "xCodigoPadre";
            this.xCodigoPadre.Visible = true;
            this.xCodigoPadre.VisibleIndex = 1;
            this.xCodigoPadre.Width = 90;
            // 
            // xPatidaPadre
            // 
            this.xPatidaPadre.Caption = "Partida Padre";
            this.xPatidaPadre.FieldName = "PatidaPadre";
            this.xPatidaPadre.MinWidth = 90;
            this.xPatidaPadre.Name = "xPatidaPadre";
            this.xPatidaPadre.Visible = true;
            this.xPatidaPadre.VisibleIndex = 2;
            this.xPatidaPadre.Width = 90;
            // 
            // xCodigo
            // 
            this.xCodigo.Caption = "Codigo";
            this.xCodigo.FieldName = "Codigo";
            this.xCodigo.MaxWidth = 90;
            this.xCodigo.MinWidth = 90;
            this.xCodigo.Name = "xCodigo";
            this.xCodigo.Visible = true;
            this.xCodigo.VisibleIndex = 3;
            this.xCodigo.Width = 90;
            // 
            // xTipo
            // 
            this.xTipo.Caption = "Tipo";
            this.xTipo.FieldName = "Tipo";
            this.xTipo.Name = "xTipo";
            // 
            // xCabecera
            // 
            this.xCabecera.Caption = "Cabecera";
            this.xCabecera.FieldName = "Cabecera";
            this.xCabecera.Name = "xCabecera";
            // 
            // xEstado
            // 
            this.xEstado.Caption = "Estado";
            this.xEstado.FieldName = "Estado";
            this.xEstado.Name = "xEstado";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Caption = "Exportar XLS";
            this.btnExportarExcel.Id = 11;
            this.btnExportarExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.ImageOptions.Image")));
            this.btnExportarExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.ImageOptions.LargeImage")));
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportarExcel_ItemClick);
            // 
            // frmaddServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 365);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmaddServicio.IconOptions.Icon")));
            this.Name = "frmaddServicio";
            this.Text = "Partida de Control - Servicio";
            this.Load += new System.EventHandler(this.frmaddServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnRecargaCombos;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarStaticItem lblEstado;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xId;
        private DevExpress.XtraGrid.Columns.GridColumn xNcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn xDescripción;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnCarga;
        private DevExpress.XtraGrid.Columns.GridColumn xtag;
        private DevExpress.XtraBars.BarButtonItem bntEliminarCargaMasiva;
        private DevExpress.XtraBars.BarButtonItem btnEliminarFila;
        private DevExpress.XtraGrid.Columns.GridColumn xNTipo;
        private DevExpress.XtraGrid.Columns.GridColumn xCodigoPadre;
        private DevExpress.XtraGrid.Columns.GridColumn xPatidaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn xCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn xTipo;
        private DevExpress.XtraGrid.Columns.GridColumn xCabecera;
        private DevExpress.XtraGrid.Columns.GridColumn xEstado;
        private DevExpress.XtraBars.BarButtonItem btnExportarExcel;
    }
}