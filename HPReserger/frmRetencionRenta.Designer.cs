namespace HPReserger
{
    partial class frmRetencionRenta
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
            this.crvRetencionRenta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptRetencionRemta1 = new HPReserger.rptRetencionRemta();
            this.SuspendLayout();
            // 
            // crvRetencionRenta
            // 
            this.crvRetencionRenta.ActiveViewIndex = -1;
            this.crvRetencionRenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRetencionRenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRetencionRenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRetencionRenta.Location = new System.Drawing.Point(0, 0);
            this.crvRetencionRenta.Name = "crvRetencionRenta";
            this.crvRetencionRenta.ShowLogo = false;
            this.crvRetencionRenta.Size = new System.Drawing.Size(885, 740);
            this.crvRetencionRenta.TabIndex = 0;
            this.crvRetencionRenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRetencionRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 740);
            this.Controls.Add(this.crvRetencionRenta);
            this.Name = "frmRetencionRenta";
            this.Text = "  Retención Renta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRetencionRenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRetencionRenta;
        private rptRetencionRemta rptRetencionRemta1;
    }
}