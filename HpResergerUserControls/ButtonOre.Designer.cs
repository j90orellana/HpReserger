namespace HpResergerUserControls
{
    partial class ButtonOre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonOre));
            this.pbfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoto
            // 
            this.pbfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbfoto.ErrorImage")));
            this.pbfoto.Image = ((System.Drawing.Image)(resources.GetObject("pbfoto.Image")));
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(44, 39);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 0;
            this.pbfoto.TabStop = false;
            this.pbfoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseDown);
            this.pbfoto.MouseLeave += new System.EventHandler(this.pbfoto_MouseLeave);
            this.pbfoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseMove);
            this.pbfoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseUp);
            // 
            // ButtonOre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbfoto);
            this.DoubleBuffered = true;
            this.Name = "ButtonOre";
            this.Size = new System.Drawing.Size(44, 39);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfoto;
    }
}
