namespace HPReserger
{
    partial class frmReporteAdendaNecesidad
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
            this.crvadendaNecesidad = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvadendaNecesidad
            // 
            this.crvadendaNecesidad.ActiveViewIndex = -1;
            this.crvadendaNecesidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvadendaNecesidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvadendaNecesidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvadendaNecesidad.Location = new System.Drawing.Point(0, 0);
            this.crvadendaNecesidad.Name = "crvadendaNecesidad";
            this.crvadendaNecesidad.ReuseParameterValuesOnRefresh = true;
            this.crvadendaNecesidad.ShowCloseButton = false;
            this.crvadendaNecesidad.ShowGroupTreeButton = false;
            this.crvadendaNecesidad.ShowLogo = false;
            this.crvadendaNecesidad.ShowParameterPanelButton = false;
            this.crvadendaNecesidad.Size = new System.Drawing.Size(954, 607);
            this.crvadendaNecesidad.TabIndex = 0;
            this.crvadendaNecesidad.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteAdendaNecesidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 607);
            this.Controls.Add(this.crvadendaNecesidad);
            this.Name = "frmReporteAdendaNecesidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adenda de Contrato de Necesidad de Mercado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteAdendaNecesidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvadendaNecesidad;
    }
}