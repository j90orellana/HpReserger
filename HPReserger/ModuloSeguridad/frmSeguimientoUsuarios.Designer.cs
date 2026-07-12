namespace SISGEM.ModuloSeguridad
{
    partial class frmSeguimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoUsuarios));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xIdSesion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFechaHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xAccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtpfecha = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dtpfecha);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(975, 504);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(963, 468);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xIdSesion,
            this.xFechaHora,
            this.xUsuario,
            this.xEmpresa,
            this.xModulo,
            this.xFormulario,
            this.xAccion,
            this.zDescripcion,
            this.xEquipo,
            this.xversion,
            this.xIP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Usuario", this.xUsuario, "")});
            this.gridView1.Name = "gridView1";
            // 
            // xIdSesion
            // 
            this.xIdSesion.Caption = "IdSesion";
            this.xIdSesion.FieldName = "IdSesion";
            this.xIdSesion.MinWidth = 100;
            this.xIdSesion.Name = "xIdSesion";
            this.xIdSesion.OptionsColumn.AllowEdit = false;
            this.xIdSesion.Visible = true;
            this.xIdSesion.VisibleIndex = 0;
            this.xIdSesion.Width = 102;
            // 
            // xFechaHora
            // 
            this.xFechaHora.Caption = "FechaHora";
            this.xFechaHora.DisplayFormat.FormatString = "G";
            this.xFechaHora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xFechaHora.FieldName = "FechaHora";
            this.xFechaHora.MinWidth = 80;
            this.xFechaHora.Name = "xFechaHora";
            this.xFechaHora.OptionsColumn.AllowEdit = false;
            this.xFechaHora.Visible = true;
            this.xFechaHora.VisibleIndex = 1;
            this.xFechaHora.Width = 104;
            // 
            // xUsuario
            // 
            this.xUsuario.Caption = "Usuario";
            this.xUsuario.FieldName = "Usuario";
            this.xUsuario.MinWidth = 60;
            this.xUsuario.Name = "xUsuario";
            this.xUsuario.OptionsColumn.AllowEdit = false;
            this.xUsuario.Visible = true;
            this.xUsuario.VisibleIndex = 2;
            this.xUsuario.Width = 85;
            // 
            // xEmpresa
            // 
            this.xEmpresa.Caption = "Empresa";
            this.xEmpresa.FieldName = "Empresa";
            this.xEmpresa.MinWidth = 70;
            this.xEmpresa.Name = "xEmpresa";
            this.xEmpresa.OptionsColumn.AllowEdit = false;
            this.xEmpresa.Visible = true;
            this.xEmpresa.VisibleIndex = 3;
            this.xEmpresa.Width = 76;
            // 
            // xModulo
            // 
            this.xModulo.Caption = "Modulo";
            this.xModulo.FieldName = "Modulo";
            this.xModulo.MinWidth = 50;
            this.xModulo.Name = "xModulo";
            this.xModulo.OptionsColumn.AllowEdit = false;
            this.xModulo.Visible = true;
            this.xModulo.VisibleIndex = 4;
            this.xModulo.Width = 54;
            // 
            // xFormulario
            // 
            this.xFormulario.Caption = "Formulario";
            this.xFormulario.FieldName = "Formulario";
            this.xFormulario.MinWidth = 70;
            this.xFormulario.Name = "xFormulario";
            this.xFormulario.OptionsColumn.AllowEdit = false;
            this.xFormulario.Visible = true;
            this.xFormulario.VisibleIndex = 5;
            this.xFormulario.Width = 76;
            // 
            // xAccion
            // 
            this.xAccion.Caption = "Accion";
            this.xAccion.FieldName = "Accion";
            this.xAccion.MinWidth = 60;
            this.xAccion.Name = "xAccion";
            this.xAccion.OptionsColumn.AllowEdit = false;
            this.xAccion.Visible = true;
            this.xAccion.VisibleIndex = 6;
            this.xAccion.Width = 65;
            // 
            // zDescripcion
            // 
            this.zDescripcion.Caption = "Descripcion";
            this.zDescripcion.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.zDescripcion.FieldName = "Descripcion";
            this.zDescripcion.MinWidth = 100;
            this.zDescripcion.Name = "zDescripcion";
            this.zDescripcion.OptionsColumn.AllowEdit = false;
            this.zDescripcion.Visible = true;
            this.zDescripcion.VisibleIndex = 10;
            this.zDescripcion.Width = 219;
            // 
            // xEquipo
            // 
            this.xEquipo.Caption = "Equipo";
            this.xEquipo.FieldName = "Equipo";
            this.xEquipo.MinWidth = 50;
            this.xEquipo.Name = "xEquipo";
            this.xEquipo.OptionsColumn.AllowEdit = false;
            this.xEquipo.Visible = true;
            this.xEquipo.VisibleIndex = 7;
            this.xEquipo.Width = 54;
            // 
            // xversion
            // 
            this.xversion.Caption = "Version";
            this.xversion.FieldName = "Version";
            this.xversion.MinWidth = 50;
            this.xversion.Name = "xversion";
            this.xversion.OptionsColumn.AllowEdit = false;
            this.xversion.Visible = true;
            this.xversion.VisibleIndex = 8;
            this.xversion.Width = 54;
            // 
            // xIP
            // 
            this.xIP.Caption = "IP";
            this.xIP.FieldName = "IP";
            this.xIP.MinWidth = 40;
            this.xIP.Name = "xIP";
            this.xIP.OptionsColumn.AllowEdit = false;
            this.xIP.Visible = true;
            this.xIP.VisibleIndex = 9;
            this.xIP.Width = 40;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(237, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(69, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Reportar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.EditValue = null;
            this.dtpfecha.Location = new System.Drawing.Point(45, 6);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";
            this.dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpfecha.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpfecha.Size = new System.Drawing.Size(190, 20);
            this.dtpfecha.StyleController = this.layoutControl1;
            this.dtpfecha.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(975, 504);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpfecha;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Periodo";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(231, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Periodo";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(302, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(663, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(231, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(71, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(71, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(71, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(965, 470);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.ReadOnly = true;
            this.repositoryItemMemoExEdit1.ShowIcon = false;
            // 
            // frmSeguimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 504);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSeguimientoUsuarios.IconOptions.Icon")));
            this.Name = "frmSeguimientoUsuarios";
            this.Text = "Seguimientos Usuarios";
            this.Load += new System.EventHandler(this.frmSeguimientoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit dtpfecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn xIdSesion;
        private DevExpress.XtraGrid.Columns.GridColumn xFechaHora;
        private DevExpress.XtraGrid.Columns.GridColumn xUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn xEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn xModulo;
        private DevExpress.XtraGrid.Columns.GridColumn xFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn xAccion;
        private DevExpress.XtraGrid.Columns.GridColumn zDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn xEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn xIP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn xversion;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}