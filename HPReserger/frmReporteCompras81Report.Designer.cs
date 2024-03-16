using System.Drawing;

namespace HPReserger
{
    partial class frmReporteCompras81Report
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
            this.crvreporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvreporte
            // 
            this.crvreporte.ActiveViewIndex = -1;
            this.crvreporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvreporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvreporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvreporte.Location = new System.Drawing.Point(0, 0);
            this.crvreporte.Name = "crvreporte";
            this.crvreporte.ShowCloseButton = false;
            this.crvreporte.ShowLogo = false;
            this.crvreporte.ShowParameterPanelButton = false;
            this.crvreporte.Size = new System.Drawing.Size(1132, 601);
            this.crvreporte.TabIndex = 345;
            this.crvreporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvreporte.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crpreporte_ReportRefresh);
            crvreporte.BackColor = Color.Transparent;
            // 
            // frmReporteCompras81Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 601);
            this.Controls.Add(this.crvreporte);
            this.Name = "frmReporteCompras81Report";
            this.Nombre = "Formato 8.1: Registro de Compras";
            this.Text = "Formato 8.1: Registro de Compras";
            this.Load += new System.EventHandler(this.frmReporteCompras81Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvreporte;
    }
}