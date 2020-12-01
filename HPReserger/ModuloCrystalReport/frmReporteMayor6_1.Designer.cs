namespace HPReserger.ModuloCrystalReport
{
    partial class frmReporteMayor6_1
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
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporte.Location = new System.Drawing.Point(0, 0);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.ReuseParameterValuesOnRefresh = true;
            this.crvReporte.ShowLogo = false;
            this.crvReporte.ShowParameterPanelButton = false;
            this.crvReporte.Size = new System.Drawing.Size(799, 481);
            this.crvReporte.TabIndex = 1;
            this.crvReporte.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvReporte_ReportRefresh);
            // 
            // frmReporteMayor6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.crvReporte);
            this.Name = "frmReporteMayor6_1";
            this.Nombre = "Reporte del Libro Mayor 6.1";
            this.Text = "Reporte del Libro Mayor 6.1";
            this.Load += new System.EventHandler(this.frmReporteMayor6_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
    }
}