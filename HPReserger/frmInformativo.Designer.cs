namespace HPReserger
{
    partial class frmInformativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformativo));
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.btnAsiento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.White;
            this.lblmensaje.Location = new System.Drawing.Point(0, 109);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(480, 79);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "Cabecera del Mensaje";
            this.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldetalle
            // 
            this.lbldetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldetalle.BackColor = System.Drawing.Color.Transparent;
            this.lbldetalle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.Color.DimGray;
            this.lbldetalle.Location = new System.Drawing.Point(0, 180);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(480, 73);
            this.lbldetalle.TabIndex = 0;
            this.lbldetalle.Text = "La Operación Finalizo Exitosamente";
            this.lbldetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Controls.Add(this.lblmensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 182);
            this.panel1.TabIndex = 1;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(190, 9);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 100);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(181, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 38);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInformativo_KeyDown);
            this.btnOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInformativo_KeyPress);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "icons8_checkmark_filled_100px.png");
            this.ImgList.Images.SetKeyName(1, "icons8_delete_sign_filled_100px.png");
            // 
            // btnAsiento
            // 
            this.btnAsiento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiento.ForeColor = System.Drawing.Color.White;
            this.btnAsiento.Location = new System.Drawing.Point(350, 255);
            this.btnAsiento.Name = "btnAsiento";
            this.btnAsiento.Size = new System.Drawing.Size(118, 37);
            this.btnAsiento.TabIndex = 3;
            this.btnAsiento.Text = "Ver Asiento";
            this.btnAsiento.UseVisualStyleBackColor = false;
            this.btnAsiento.Visible = false;
            // 
            // frmInformativo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.btnAsiento);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldetalle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "frmInformativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISGEM";
            this.Load += new System.EventHandler(this.frmInformativo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInformativo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInformativo_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button btnAsiento;
    }
}