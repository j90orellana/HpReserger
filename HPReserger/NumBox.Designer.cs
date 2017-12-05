namespace HPReserger
{
    partial class NumBox
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
            this.components = new System.ComponentModel.Container();
            this.Num = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num.Location = new System.Drawing.Point(0, 0);
            this.Num.MaxLength = 17;
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(148, 20);
            this.Num.TabIndex = 0;
            this.Num.Text = "00.00";
            this.Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            this.Num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            this.Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            this.Num.Leave += new System.EventHandler(this.Num_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NumBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Num);
            this.Name = "NumBox";
            this.Size = new System.Drawing.Size(148, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox Num;
    }
}
