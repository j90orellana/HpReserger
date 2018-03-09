namespace HPReserger
{
    partial class frmReporteEstadoPerdidas
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
            this.crvreporte.Size = new System.Drawing.Size(897, 675);
            this.crvreporte.TabIndex = 0;
            // 
            // frmReporteEstadoPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 675);
            this.Controls.Add(this.crvreporte);
            this.Name = "frmReporteEstadoPerdidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado De Resultado Integral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteEstadoPerdidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvreporte;
    }
}