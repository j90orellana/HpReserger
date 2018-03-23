namespace HPReserger
{
    partial class frmReporteconvenioPracticas
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
            this.crvreportepracticas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvreportepracticas
            // 
            this.crvreportepracticas.ActiveViewIndex = -1;
            this.crvreportepracticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvreportepracticas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvreportepracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvreportepracticas.Location = new System.Drawing.Point(0, 0);
            this.crvreportepracticas.Name = "crvreportepracticas";
            this.crvreportepracticas.ReuseParameterValuesOnRefresh = true;
            this.crvreportepracticas.ShowCloseButton = false;
            this.crvreportepracticas.ShowGroupTreeButton = false;
            this.crvreportepracticas.ShowLogo = false;
            this.crvreportepracticas.ShowParameterPanelButton = false;
            this.crvreportepracticas.Size = new System.Drawing.Size(721, 591);
            this.crvreportepracticas.TabIndex = 0;
            this.crvreportepracticas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvreportepracticas.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvreportepracticas_ReportRefresh);
            // 
            // frmReporteconvenioPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 591);
            this.Controls.Add(this.crvreportepracticas);
            this.Name = "frmReporteconvenioPracticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenio de Practicas Pre Profesionales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteconvenioPracticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvreportepracticas;
    }
}