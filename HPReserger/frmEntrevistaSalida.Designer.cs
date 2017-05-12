namespace HPReserger
{
    partial class frmEntrevistaSalida
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
            this.crvEntrevistaSalida = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvEntrevistaSalida
            // 
            this.crvEntrevistaSalida.ActiveViewIndex = -1;
            this.crvEntrevistaSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEntrevistaSalida.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEntrevistaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEntrevistaSalida.Location = new System.Drawing.Point(0, 0);
            this.crvEntrevistaSalida.Name = "crvEntrevistaSalida";
            this.crvEntrevistaSalida.Size = new System.Drawing.Size(791, 684);
            this.crvEntrevistaSalida.TabIndex = 0;
            this.crvEntrevistaSalida.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmEntrevistaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 684);
            this.Controls.Add(this.crvEntrevistaSalida);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrevistaSalida";
            this.Text = "  Entrevista de Salida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEntrevistaSalida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEntrevistaSalida;
    }
}