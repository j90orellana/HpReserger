namespace HpResergerUserControls
{
    partial class PostITMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostITMessage));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnprueba = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(282, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(20, 20);
            this.btnclose.TabIndex = 5;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnprueba
            // 
            this.btnprueba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnprueba.FlatAppearance.BorderSize = 0;
            this.btnprueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprueba.Image = ((System.Drawing.Image)(resources.GetObject("btnprueba.Image")));
            this.btnprueba.Location = new System.Drawing.Point(251, 3);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(25, 25);
            this.btnprueba.TabIndex = 7;
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Visible = false;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(93, 82);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 8;
            this.pbFoto.TabStop = false;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(96, 53);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(51, 17);
            this.lblObservacion.TabIndex = 11;
            this.lblObservacion.Text = "Detalle:";
            this.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.Location = new System.Drawing.Point(96, 32);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(47, 17);
            this.lblcargo.TabIndex = 10;
            this.lblcargo.Text = "Cargo:";
            this.lblcargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(96, 11);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 17);
            this.lblnombre.TabIndex = 9;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PostITMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnprueba);
            this.Controls.Add(this.btnclose);
            this.Name = "PostITMessage";
            this.Size = new System.Drawing.Size(305, 82);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnprueba;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
    }
}
