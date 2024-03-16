namespace HPReserger
{
    partial class frmReporteNecesidadMercado
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
            this.crvnecesidadmercado = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvnecesidadmercado
            // 
            this.crvnecesidadmercado.ActiveViewIndex = -1;
            this.crvnecesidadmercado.AutoSize = true;
            this.crvnecesidadmercado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvnecesidadmercado.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvnecesidadmercado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvnecesidadmercado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crvnecesidadmercado.Location = new System.Drawing.Point(0, 0);
            this.crvnecesidadmercado.Name = "crvnecesidadmercado";
            this.crvnecesidadmercado.ReuseParameterValuesOnRefresh = true;
            this.crvnecesidadmercado.ShowCloseButton = false;
            this.crvnecesidadmercado.ShowGroupTreeButton = false;
            this.crvnecesidadmercado.ShowLogo = false;
            this.crvnecesidadmercado.ShowParameterPanelButton = false;
            this.crvnecesidadmercado.Size = new System.Drawing.Size(781, 459);
            this.crvnecesidadmercado.TabIndex = 0;
            this.crvnecesidadmercado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvnecesidadmercado.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvnecesidadmercado_ReportRefresh);
            // 
            // frmReporteNecesidadMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 459);
            this.Controls.Add(this.crvnecesidadmercado);
            this.Name = "frmReporteNecesidadMercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de Necesidad de Mercado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteNecesidadMercado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvnecesidadmercado;
    }
}