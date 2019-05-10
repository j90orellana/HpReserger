namespace HpResergerUserControls
{
    partial class FotoCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotoCheck));
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnprueba = new System.Windows.Forms.Button();
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.Control;
            this.pbFoto.Location = new System.Drawing.Point(21, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(93, 82);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombre.AutoEllipsis = true;
            this.lblnombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblnombre.Location = new System.Drawing.Point(115, 28);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(183, 14);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcargo
            // 
            this.lblcargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcargo.AutoEllipsis = true;
            this.lblcargo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.lblcargo.Location = new System.Drawing.Point(115, 43);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(183, 14);
            this.lblcargo.TabIndex = 2;
            this.lblcargo.Text = "Cargo:";
            this.lblcargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObservacion
            // 
            this.lblObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservacion.AutoEllipsis = true;
            this.lblObservacion.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblObservacion.Location = new System.Drawing.Point(115, 58);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(183, 14);
            this.lblObservacion.TabIndex = 3;
            this.lblObservacion.Text = "Detalle:";
            this.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(282, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(20, 20);
            this.btnclose.TabIndex = 4;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            this.btnclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnclose_MouseMove);
            // 
            // btnprueba
            // 
            this.btnprueba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnprueba.FlatAppearance.BorderSize = 0;
            this.btnprueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprueba.Image = ((System.Drawing.Image)(resources.GetObject("btnprueba.Image")));
            this.btnprueba.Location = new System.Drawing.Point(35, 30);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(25, 25);
            this.btnprueba.TabIndex = 5;
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Visible = false;
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "icons8_User_100px.png");
            this.ListaImagenes.Images.SetKeyName(1, "icons8_Curriculum_100px.png");
            this.ListaImagenes.Images.SetKeyName(2, "icons8_Person_Female_100px.png");
            // 
            // FotoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnprueba);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(0, 82);
            this.Name = "FotoCheck";
            this.Size = new System.Drawing.Size(305, 82);
            this.Click += new System.EventHandler(this.FotoCheck_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnprueba;
        private System.Windows.Forms.ImageList ListaImagenes;
    }
}
