namespace HPReserger
{
    partial class frmReporteLocacionServicios
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
            this.crvLocacionServicios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvLocacionServicios
            // 
            this.crvLocacionServicios.ActiveViewIndex = -1;
            this.crvLocacionServicios.AutoScroll = true;
            this.crvLocacionServicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLocacionServicios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLocacionServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLocacionServicios.Location = new System.Drawing.Point(0, 0);
            this.crvLocacionServicios.Name = "crvLocacionServicios";
            this.crvLocacionServicios.ReuseParameterValuesOnRefresh = true;
            this.crvLocacionServicios.ShowCloseButton = false;
            this.crvLocacionServicios.ShowLogo = false;
            this.crvLocacionServicios.ShowParameterPanelButton = false;
            this.crvLocacionServicios.Size = new System.Drawing.Size(1057, 695);
            this.crvLocacionServicios.TabIndex = 0;
            // 
            // frmReporteLocacionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 695);
            this.Controls.Add(this.crvLocacionServicios);
            this.Name = "frmReporteLocacionServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de Locacion de Servicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteLocacionServicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLocacionServicios;
    }
}