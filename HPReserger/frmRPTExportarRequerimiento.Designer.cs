namespace HPReserger
{
    partial class frmRPTExportarRequerimiento
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
            this.rptreporterequerimientos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptreporterequerimientos
            // 
            this.rptreporterequerimientos.ActiveViewIndex = -1;
            this.rptreporterequerimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rptreporterequerimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptreporterequerimientos.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptreporterequerimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptreporterequerimientos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptreporterequerimientos.Location = new System.Drawing.Point(0, 0);
            this.rptreporterequerimientos.Name = "rptreporterequerimientos";
            this.rptreporterequerimientos.ReuseParameterValuesOnRefresh = true;
            this.rptreporterequerimientos.ShowCloseButton = false;
            this.rptreporterequerimientos.ShowGotoPageButton = false;
            this.rptreporterequerimientos.ShowGroupTreeButton = false;
            this.rptreporterequerimientos.ShowLogo = false;
            this.rptreporterequerimientos.ShowPageNavigateButtons = false;
            this.rptreporterequerimientos.ShowParameterPanelButton = false;
            this.rptreporterequerimientos.Size = new System.Drawing.Size(844, 732);
            this.rptreporterequerimientos.TabIndex = 0;
            this.rptreporterequerimientos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRPTExportarRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(844, 732);
            this.Controls.Add(this.rptreporterequerimientos);
            this.Name = "frmRPTExportarRequerimiento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Requerimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRPTExportarRequerimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptreporterequerimientos;
    }
}