namespace HpResergerUserControls
{
    partial class frmImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImagenes));
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnizquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.Color.Transparent;
            this.pbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(553, 401);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbfoto.TabIndex = 112;
            this.pbfoto.TabStop = false;
            this.pbfoto.Click += new System.EventHandler(this.pbfoto_Click);
            this.pbfoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmImagenes_MouseClick);
            this.pbfoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseMove_1);
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(188)))));
            this.btndescargar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Image = ((System.Drawing.Image)(resources.GetObject("btndescargar.Image")));
            this.btndescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescargar.Location = new System.Drawing.Point(212, 365);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(73, 25);
            this.btndescargar.TabIndex = 114;
            this.btndescargar.Text = "Guardar";
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btndescargar_KeyDown);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove_1);
            // 
            // btnizquierda
            // 
            this.btnizquierda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnizquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(188)))));
            this.btnizquierda.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnizquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizquierda.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnizquierda.ForeColor = System.Drawing.Color.White;
            this.btnizquierda.Image = ((System.Drawing.Image)(resources.GetObject("btnizquierda.Image")));
            this.btnizquierda.Location = new System.Drawing.Point(288, 365);
            this.btnizquierda.Name = "btnizquierda";
            this.btnizquierda.Size = new System.Drawing.Size(25, 25);
            this.btnizquierda.TabIndex = 115;
            this.btnizquierda.UseVisualStyleBackColor = false;
            this.btnizquierda.Click += new System.EventHandler(this.btnizquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(188)))));
            this.btnDerecha.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.ForeColor = System.Drawing.Color.White;
            this.btnDerecha.Image = ((System.Drawing.Image)(resources.GetObject("btnDerecha.Image")));
            this.btnDerecha.Location = new System.Drawing.Point(316, 365);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(25, 25);
            this.btnDerecha.TabIndex = 115;
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // frmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 401);
            this.Colores = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))))};
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnizquierda);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.pbfoto);
            this.Name = "frmImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmFoto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImagenes_KeyDown);
            this.Leave += new System.EventHandler(this.FrmFoto_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnizquierda;
        private System.Windows.Forms.Button btnDerecha;
    }
}