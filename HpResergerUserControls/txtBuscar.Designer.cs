namespace HpResergerUserControls
{
    partial class txtBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtBuscar));
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbusca
            // 
            this.txtbusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(201)))));
            this.txtbusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.ForeColor = System.Drawing.Color.White;
            this.txtbusca.Location = new System.Drawing.Point(41, 0);
            this.txtbusca.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(327, 22);
            this.txtbusca.TabIndex = 0;
            this.txtbusca.Text = "Buscar";
            this.txtbusca.WordWrap = false;
            this.txtbusca.Click += new System.EventHandler(this.txtbusca_Click);
            this.txtbusca.DoubleClick += new System.EventHandler(this.txtbusca_DoubleClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(201)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(0, -1);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(38, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusca);
            this.Name = "txtBuscar";
            this.Size = new System.Drawing.Size(368, 22);
            this.BackColorChanged += new System.EventHandler(this.txtBuscar_BackColorChanged);
            this.FontChanged += new System.EventHandler(this.txtBuscar_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.txtBuscar_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Button btnbuscar;
    }
}
