namespace HpResergerUserControls
{
    partial class frmimagen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmimagen));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.btnVer1 = new System.Windows.Forms.Button();
            this.btnDescargar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfoto
            // 
            this.pbfoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbfoto.BackColor = System.Drawing.Color.Transparent;
            this.pbfoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbfoto.ErrorImage")));
            this.pbfoto.InitialImage = null;
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(216, 193);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 113;
            this.pbfoto.TabStop = false;
            this.pbfoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbfoto_DragEnter);
            this.pbfoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pbfoto_Paint);
            this.pbfoto.DoubleClick += new System.EventHandler(this.pbfoto_DoubleClick);
            this.pbfoto.MouseLeave += new System.EventHandler(this.pbfoto_MouseLeave);
            this.pbfoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbfoto_MouseMove);
            // 
            // btnVer1
            // 
            this.btnVer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.btnVer1.FlatAppearance.BorderSize = 0;
            this.btnVer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.btnVer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer1.ForeColor = System.Drawing.Color.White;
            this.btnVer1.Image = ((System.Drawing.Image)(resources.GetObject("btnVer1.Image")));
            this.btnVer1.Location = new System.Drawing.Point(23, 164);
            this.btnVer1.Name = "btnVer1";
            this.btnVer1.Size = new System.Drawing.Size(84, 24);
            this.btnVer1.TabIndex = 143;
            this.btnVer1.Text = "&Ver";
            this.btnVer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer1.UseVisualStyleBackColor = false;
            this.btnVer1.Visible = false;
            this.btnVer1.Click += new System.EventHandler(this.btnVer_Click);
            this.btnVer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVer_MouseMove);
            // 
            // btnDescargar1
            // 
            this.btnDescargar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDescargar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.btnDescargar1.FlatAppearance.BorderSize = 0;
            this.btnDescargar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(142)))), ((int)(((byte)(169)))));
            this.btnDescargar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnDescargar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar1.ForeColor = System.Drawing.Color.White;
            this.btnDescargar1.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar1.Image")));
            this.btnDescargar1.Location = new System.Drawing.Point(110, 164);
            this.btnDescargar1.Name = "btnDescargar1";
            this.btnDescargar1.Size = new System.Drawing.Size(84, 24);
            this.btnDescargar1.TabIndex = 144;
            this.btnDescargar1.Text = "&Descargar";
            this.btnDescargar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar1.UseVisualStyleBackColor = false;
            this.btnDescargar1.Visible = false;
            this.btnDescargar1.Click += new System.EventHandler(this.btndescargar_Click);
            this.btnDescargar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // frmimagen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDescargar1);
            this.Controls.Add(this.btnVer1);
            this.Controls.Add(this.pbfoto);
            this.Name = "frmimagen";
            this.Size = new System.Drawing.Size(216, 193);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmimagen_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbfoto_DragEnter);
            this.MouseLeave += new System.EventHandler(this.frmimagen_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmimagen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVer1;
        private System.Windows.Forms.Button btnDescargar1;
    }
}