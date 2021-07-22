namespace HpResergerUserControls
{
    partial class DuplicadorBase
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuplicadorBase));
            this.pbfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.Color.Transparent;
            this.pbfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfoto.Image = ((System.Drawing.Image)(resources.GetObject("pbfoto.Image")));
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(15, 15);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 0;
            this.pbfoto.TabStop = false;
            this.pbfoto.Click += new System.EventHandler(this.pbfoto_Click);
            // 
            // DuplicadorBase
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.Controls.Add(this.pbfoto);
            this.Name = "DuplicadorBase";
            this.Size = new System.Drawing.Size(15, 15);
            this.Load += new System.EventHandler(this.DuplicadorBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfoto;
    }
}
