namespace SISGEM.ModuloReportes
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldcodigo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xdescripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xRUC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xDireccion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xSector_Empresarial = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldcodigo,
            this.xdescripcion,
            this.xRUC,
            this.xDireccion,
            this.xSector_Empresarial});
            pivotGridGroup1.Fields.Add(this.xSector_Empresarial);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(956, 560);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldcodigo
            // 
            this.fieldcodigo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldcodigo.AreaIndex = 0;
            this.fieldcodigo.FieldName = "codigo";
            this.fieldcodigo.Name = "fieldcodigo";
            // 
            // xdescripcion
            // 
            this.xdescripcion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xdescripcion.AreaIndex = 1;
            this.xdescripcion.FieldName = "descripcion";
            this.xdescripcion.Name = "xdescripcion";
            // 
            // xRUC
            // 
            this.xRUC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xRUC.AreaIndex = 0;
            this.xRUC.FieldName = "RUC";
            this.xRUC.Name = "xRUC";
            // 
            // xDireccion
            // 
            this.xDireccion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xDireccion.AreaIndex = 2;
            this.xDireccion.FieldName = "Direccion";
            this.xDireccion.Name = "xDireccion";
            // 
            // xSector_Empresarial
            // 
            this.xSector_Empresarial.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xSector_Empresarial.AreaIndex = 1;
            this.xSector_Empresarial.FieldName = "Sector_Empresarial";
            this.xSector_Empresarial.Name = "xSector_Empresarial";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(880, 31);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 560);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldcodigo;
        private DevExpress.XtraPivotGrid.PivotGridField xdescripcion;
        private DevExpress.XtraPivotGrid.PivotGridField xRUC;
        private DevExpress.XtraPivotGrid.PivotGridField xDireccion;
        private DevExpress.XtraPivotGrid.PivotGridField xSector_Empresarial;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
    }
}