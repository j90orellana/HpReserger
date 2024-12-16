namespace SISGEM.Flujo_de_Caja
{
    partial class frmAddEstatusInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEstatusInventario));
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xIdEstatusInventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.btnEliminarFila});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 11;
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
            this.btnNuevo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Glyph")));
            this.btnNuevo.Id = 6;
            this.btnNuevo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNuevo.LargeGlyph")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnRecargaCombos
            // 
            this.btnRecargaCombos.Caption = "Recargar Grilla";
            this.btnRecargaCombos.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRecargaCombos.Glyph")));
            this.btnRecargaCombos.Id = 4;
            this.btnRecargaCombos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRecargaCombos.LargeGlyph")));
            this.btnRecargaCombos.Name = "btnRecargaCombos";
            this.btnRecargaCombos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRecargaCombos_ItemClick);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Caption = "Eliminar Fila";
            this.btnEliminarFila.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminarFila.Glyph")));
            this.btnEliminarFila.Id = 10;
            this.btnEliminarFila.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminarFila.LargeGlyph")));
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarFila_ItemClick);
            // 
            // btnCarga
            // 
            this.btnCarga.Caption = "Carga Masiva";
            this.btnCarga.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCarga.Glyph")));
            this.btnCarga.Id = 8;
            this.btnCarga.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCarga.LargeGlyph")));
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bntEliminarCargaMasiva
            // 
            this.bntEliminarCargaMasiva.Caption = "Eliminar Carga Masiva";
            this.bntEliminarCargaMasiva.Glyph = ((System.Drawing.Image)(resources.GetObject("bntEliminarCargaMasiva.Glyph")));
            this.bntEliminarCargaMasiva.Id = 9;
            this.bntEliminarCargaMasiva.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bntEliminarCargaMasiva.LargeGlyph")));
            this.bntEliminarCargaMasiva.Name = "bntEliminarCargaMasiva";
            this.bntEliminarCargaMasiva.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Glyph")));
            this.btnCerrar.Id = 1;
            this.btnCerrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCerrar.LargeGlyph")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(673, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Size = new System.Drawing.Size(673, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(673, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 477);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 5;
            this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
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
            this.lblEstado.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(673, 477);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(673, 477);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(649, 453);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xIdEstatusInventario,
            this.xEstatus,
            this.xDescripcion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese Texto a Buscar";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(653, 457);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // xIdEstatusInventario
            // 
            this.xIdEstatusInventario.Caption = "IdEstatusInventario";
            this.xIdEstatusInventario.FieldName = "IdEstatusInventario";
            this.xIdEstatusInventario.Name = "xIdEstatusInventario";
            // 
            // xEstatus
            // 
            this.xEstatus.Caption = "Estatus";
            this.xEstatus.FieldName = "Estatus";
            this.xEstatus.MaxWidth = 300;
            this.xEstatus.MinWidth = 300;
            this.xEstatus.Name = "xEstatus";
            this.xEstatus.Visible = true;
            this.xEstatus.VisibleIndex = 0;
            this.xEstatus.Width = 300;
            // 
            // xDescripcion
            // 
            this.xDescripcion.Caption = "Descripcion";
            this.xDescripcion.FieldName = "Descripcion";
            this.xDescripcion.Name = "xDescripcion";
            this.xDescripcion.Visible = true;
            this.xDescripcion.VisibleIndex = 1;
            this.xDescripcion.Width = 448;
            // 
            // frmAddEstatusInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 501);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEstatusInventario";
            this.Text = "Agregar Estatus de Inventario";
            this.Load += new System.EventHandler(this.frmAddEstatusInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnRecargaCombos;
        private DevExpress.XtraBars.BarButtonItem btnEliminarFila;
        private DevExpress.XtraBars.BarButtonItem btnCarga;
        private DevExpress.XtraBars.BarButtonItem bntEliminarCargaMasiva;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn xIdEstatusInventario;
        private DevExpress.XtraGrid.Columns.GridColumn xEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn xDescripcion;
    }
}