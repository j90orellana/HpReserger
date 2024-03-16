namespace SISGEM.CRM
{
    partial class frmAddTipoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTipoCliente));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ID_Tipo_ClienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cRMTipoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detalle_Tipo_ClienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID_Tipo_Cliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_Tipo_Cliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Tipo_ClienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMTipoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_Tipo_ClienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Tipo_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_Tipo_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ID_Tipo_ClienteTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_Tipo_ClienteTextEdit);
            this.dataLayoutControl1.DataSource = this.cRMTipoClienteBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 26);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(574, 120);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ID_Tipo_ClienteTextEdit
            // 
            this.ID_Tipo_ClienteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cRMTipoClienteBindingSource, "ID_Tipo_Cliente", true));
            this.ID_Tipo_ClienteTextEdit.Location = new System.Drawing.Point(71, 12);
            this.ID_Tipo_ClienteTextEdit.Name = "ID_Tipo_ClienteTextEdit";
            this.ID_Tipo_ClienteTextEdit.Properties.ReadOnly = true;
            this.ID_Tipo_ClienteTextEdit.Size = new System.Drawing.Size(491, 20);
            this.ID_Tipo_ClienteTextEdit.StyleController = this.dataLayoutControl1;
            this.ID_Tipo_ClienteTextEdit.TabIndex = 4;
            // 
            // cRMTipoClienteBindingSource
            // 
            this.cRMTipoClienteBindingSource.DataSource = typeof(HpResergerNube.CRM_Tipo_Cliente);
            // 
            // Detalle_Tipo_ClienteTextEdit
            // 
            this.Detalle_Tipo_ClienteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cRMTipoClienteBindingSource, "Detalle_Tipo_Cliente", true));
            this.Detalle_Tipo_ClienteTextEdit.Location = new System.Drawing.Point(71, 36);
            this.Detalle_Tipo_ClienteTextEdit.Name = "Detalle_Tipo_ClienteTextEdit";
            this.Detalle_Tipo_ClienteTextEdit.Size = new System.Drawing.Size(491, 20);
            this.Detalle_Tipo_ClienteTextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_Tipo_ClienteTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(574, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID_Tipo_Cliente,
            this.ItemForDetalle_Tipo_Cliente});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(554, 100);
            // 
            // ItemForID_Tipo_Cliente
            // 
            this.ItemForID_Tipo_Cliente.Control = this.ID_Tipo_ClienteTextEdit;
            this.ItemForID_Tipo_Cliente.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_Tipo_Cliente.Name = "ItemForID_Tipo_Cliente";
            this.ItemForID_Tipo_Cliente.Size = new System.Drawing.Size(554, 24);
            this.ItemForID_Tipo_Cliente.Text = "ID";
            this.ItemForID_Tipo_Cliente.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForDetalle_Tipo_Cliente
            // 
            this.ItemForDetalle_Tipo_Cliente.Control = this.Detalle_Tipo_ClienteTextEdit;
            this.ItemForDetalle_Tipo_Cliente.Location = new System.Drawing.Point(0, 24);
            this.ItemForDetalle_Tipo_Cliente.Name = "ItemForDetalle_Tipo_Cliente";
            this.ItemForDetalle_Tipo_Cliente.Size = new System.Drawing.Size(554, 76);
            this.ItemForDetalle_Tipo_Cliente.Text = "Tipo Cliente";
            this.ItemForDetalle_Tipo_Cliente.TextSize = new System.Drawing.Size(56, 13);
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(432, 133);
            this.bar2.FloatSize = new System.Drawing.Size(169, 44);
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
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
            this.btnGuardar,
            this.btnCerrar});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 2;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 0;
            this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(574, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 146);
            this.barDockControlBottom.Size = new System.Drawing.Size(574, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 120);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(574, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 120);
            // 
            // frmAddTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 146);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTipoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Tipo Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddTipoCliente_FormClosed);
            this.Load += new System.EventHandler(this.frmAddTipoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID_Tipo_ClienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMTipoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_Tipo_ClienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Tipo_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_Tipo_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit ID_Tipo_ClienteTextEdit;
        private System.Windows.Forms.BindingSource cRMTipoClienteBindingSource;
        private DevExpress.XtraEditors.TextEdit Detalle_Tipo_ClienteTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_Tipo_Cliente;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDetalle_Tipo_Cliente;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}