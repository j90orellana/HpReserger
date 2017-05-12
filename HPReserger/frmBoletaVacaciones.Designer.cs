namespace HPReserger
{
    partial class frmBoletaVacaciones
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
            this.crvBoletaVacaciones = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptVacaciones1 = new HPReserger.rptVacaciones();
            this.SuspendLayout();
            // 
            // crvBoletaVacaciones
            // 
            this.crvBoletaVacaciones.ActiveViewIndex = 0;
            this.crvBoletaVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBoletaVacaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBoletaVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBoletaVacaciones.Location = new System.Drawing.Point(0, 0);
            this.crvBoletaVacaciones.Name = "crvBoletaVacaciones";
            this.crvBoletaVacaciones.ReportSource = this.rptVacaciones1;
            this.crvBoletaVacaciones.Size = new System.Drawing.Size(860, 642);
            this.crvBoletaVacaciones.TabIndex = 0;
            this.crvBoletaVacaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmBoletaVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 642);
            this.Controls.Add(this.crvBoletaVacaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBoletaVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "  Boleta de Vacaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBoletaVacaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBoletaVacaciones;
        private rptVacaciones rptVacaciones1;
    }
}