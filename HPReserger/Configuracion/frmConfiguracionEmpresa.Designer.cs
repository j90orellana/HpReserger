namespace SISGEM.Configuracion
{
    partial class frmConfiguracionEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionEmpresa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xTabEmpresa = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cboCuentaComision = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xcuentacontable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDetallePagoBancos = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chkfacturasConPartida = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xTabEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetallePagoBancos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkfacturasConPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(734, 519);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xTabEmpresa;
            this.xtraTabControl1.Size = new System.Drawing.Size(722, 507);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabEmpresa});
            // 
            // xTabEmpresa
            // 
            this.xTabEmpresa.Controls.Add(this.layoutControl2);
            this.xTabEmpresa.Name = "xTabEmpresa";
            this.xTabEmpresa.Size = new System.Drawing.Size(720, 486);
            this.xTabEmpresa.Text = "Finanzas";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.chkfacturasConPartida);
            this.layoutControl2.Controls.Add(this.cboCuentaComision);
            this.layoutControl2.Controls.Add(this.chkDetallePagoBancos);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(720, 486);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cboCuentaComision
            // 
            this.cboCuentaComision.Location = new System.Drawing.Point(309, 27);
            this.cboCuentaComision.Name = "cboCuentaComision";
            this.cboCuentaComision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCuentaComision.Properties.NullText = "";
            this.cboCuentaComision.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboCuentaComision.Size = new System.Drawing.Size(405, 20);
            this.cboCuentaComision.StyleController = this.layoutControl2;
            this.cboCuentaComision.TabIndex = 6;
            this.cboCuentaComision.EditValueChanged += new System.EventHandler(this.cboCuentaComision_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xid,
            this.xcuentacontable});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // xid
            // 
            this.xid.Caption = "Cuenta";
            this.xid.FieldName = "id";
            this.xid.MaxWidth = 100;
            this.xid.Name = "xid";
            this.xid.OptionsColumn.ReadOnly = true;
            this.xid.Visible = true;
            this.xid.VisibleIndex = 0;
            // 
            // xcuentacontable
            // 
            this.xcuentacontable.Caption = "Cuenta Contable";
            this.xcuentacontable.FieldName = "cuentacontable";
            this.xcuentacontable.Name = "xcuentacontable";
            this.xcuentacontable.OptionsColumn.AllowEdit = false;
            this.xcuentacontable.Visible = true;
            this.xcuentacontable.VisibleIndex = 1;
            // 
            // chkDetallePagoBancos
            // 
            this.chkDetallePagoBancos.Location = new System.Drawing.Point(6, 6);
            this.chkDetallePagoBancos.Name = "chkDetallePagoBancos";
            this.chkDetallePagoBancos.Properties.Caption = "Mostrar detalle de comprobantes de pago en los pagos de cuenta bancaria";
            this.chkDetallePagoBancos.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkDetallePagoBancos.Size = new System.Drawing.Size(708, 19);
            this.chkDetallePagoBancos.StyleController = this.layoutControl2;
            this.chkDetallePagoBancos.TabIndex = 4;
            this.chkDetallePagoBancos.CheckedChanged += new System.EventHandler(this.chkDetallePagoBancos_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(720, 486);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkDetallePagoBancos;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(710, 21);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboCuentaComision;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 21);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(710, 22);
            this.layoutControlItem4.Text = "Código de cuenta contable para registrar comisiones bancarias";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(300, 13);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(734, 519);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(724, 509);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // chkfacturasConPartida
            // 
            this.chkfacturasConPartida.Location = new System.Drawing.Point(6, 49);
            this.chkfacturasConPartida.Name = "chkfacturasConPartida";
            this.chkfacturasConPartida.Properties.Caption = "Trabajar Facturas con Partidas Presupuestarias";
            this.chkfacturasConPartida.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkfacturasConPartida.Size = new System.Drawing.Size(708, 19);
            this.chkfacturasConPartida.StyleController = this.layoutControl2;
            this.chkfacturasConPartida.TabIndex = 7;
            this.chkfacturasConPartida.CheckedChanged += new System.EventHandler(this.chkfacturasConPartida_CheckedChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkfacturasConPartida;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(710, 433);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmConfiguracionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 519);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmConfiguracionEmpresa.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmConfiguracionEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones Empresa";
            this.Load += new System.EventHandler(this.frmConfiguracionEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xTabEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetallePagoBancos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkfacturasConPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xTabEmpresa;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cboCuentaComision;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit chkDetallePagoBancos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn xid;
        private DevExpress.XtraGrid.Columns.GridColumn xcuentacontable;
        private DevExpress.XtraEditors.CheckEdit chkfacturasConPartida;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}