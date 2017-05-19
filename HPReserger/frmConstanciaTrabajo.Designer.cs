namespace HPReserger
{
    partial class frmConstanciaTrabajo
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
            this.crvConstanciaTrabajo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptConstanciaTrabajo1 = new HPReserger.rptConstanciaTrabajo();
            this.rptConstanciaTrabajo2 = new HPReserger.rptConstanciaTrabajo();
            this.rptConstanciaTrabajo3 = new HPReserger.rptConstanciaTrabajo();
            this.rptConstanciaTrabajo4 = new HPReserger.rptConstanciaTrabajo();
            this.SuspendLayout();
            // 
            // crvConstanciaTrabajo
            // 
            this.crvConstanciaTrabajo.ActiveViewIndex = -1;
            this.crvConstanciaTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConstanciaTrabajo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConstanciaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvConstanciaTrabajo.Location = new System.Drawing.Point(0, 0);
            this.crvConstanciaTrabajo.Name = "crvConstanciaTrabajo";
            this.crvConstanciaTrabajo.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
            this.crvConstanciaTrabajo.ShowLogo = false;
            this.crvConstanciaTrabajo.ShowParameterPanelButton = false;
            this.crvConstanciaTrabajo.Size = new System.Drawing.Size(868, 626);
            this.crvConstanciaTrabajo.TabIndex = 0;
            this.crvConstanciaTrabajo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvConstanciaTrabajo.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvConstanciaTrabajo_ReportRefresh);
            // 
            // frmConstanciaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 626);
            this.Controls.Add(this.crvConstanciaTrabajo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConstanciaTrabajo";
            this.Text = "  Constancia de Trabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConstanciaTrabajo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConstanciaTrabajo;
        private rptConstanciaTrabajo rptConstanciaTrabajo1;
        private rptConstanciaTrabajo rptConstanciaTrabajo2;
        private rptConstanciaTrabajo rptConstanciaTrabajo3;
        private rptConstanciaTrabajo rptConstanciaTrabajo4;
    }
}