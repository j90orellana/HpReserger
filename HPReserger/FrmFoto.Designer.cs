namespace HPReserger
{
    partial class FrmFoto
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
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoto
            // 
            this.pbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(864, 770);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbfoto.TabIndex = 0;
            this.pbfoto.TabStop = false;
            this.pbfoto.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbfoto_LoadCompleted);
            this.pbfoto.Click += new System.EventHandler(this.pbfoto_Click);
            this.pbfoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseMove);
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(389, 735);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 111;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFoto_KeyDown);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // FrmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(864, 770);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.pbfoto);
            this.Name = "FrmFoto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFoto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFoto_KeyDown);
            this.Leave += new System.EventHandler(this.FrmFoto_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Button btndescargar;
    }
}