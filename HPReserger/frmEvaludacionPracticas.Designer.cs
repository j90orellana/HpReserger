namespace HPReserger
{
    partial class frmEvaludacionPracticas
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
            this.crvEvaluacionPracticas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptEvaluacionPracticas1 = new HPReserger.rptEvaluacionPracticas();
            this.SuspendLayout();
            // 
            // crvEvaluacionPracticas
            // 
            this.crvEvaluacionPracticas.ActiveViewIndex = -1;
            this.crvEvaluacionPracticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEvaluacionPracticas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEvaluacionPracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEvaluacionPracticas.Location = new System.Drawing.Point(0, 0);
            this.crvEvaluacionPracticas.Name = "crvEvaluacionPracticas";
            this.crvEvaluacionPracticas.ShowCloseButton = false;
            this.crvEvaluacionPracticas.ShowGroupTreeButton = false;
            this.crvEvaluacionPracticas.ShowLogo = false;
            this.crvEvaluacionPracticas.ShowParameterPanelButton = false;
            this.crvEvaluacionPracticas.Size = new System.Drawing.Size(954, 725);
            this.crvEvaluacionPracticas.TabIndex = 0;
            this.crvEvaluacionPracticas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvEvaluacionPracticas.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvEvaluacionPracticas_ReportRefresh);
            // 
            // frmEvaludacionPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 725);
            this.Controls.Add(this.crvEvaluacionPracticas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvaludacionPracticas";
            this.Text = "  Evaluación de Prácticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEvaluacionPracticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEvaluacionPracticas;
        private rptEvaluacionPracticas rptEvaluacionPracticas1;
    }
}