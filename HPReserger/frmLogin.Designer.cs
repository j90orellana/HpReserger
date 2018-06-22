namespace HPReserger
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogueo = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.cboBase = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.moveControl1 = new HpResergerUserControls.MoveControl(this.components);
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(133, 90);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(171, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUsuario_DragDrop);
            this.txtUsuario.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtUsuario_DragEnter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(133, 119);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(171, 23);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // btnLogueo
            // 
            this.btnLogueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(224)))));
            this.btnLogueo.FlatAppearance.BorderSize = 0;
            this.btnLogueo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(224)))));
            this.btnLogueo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(175)))), ((int)(((byte)(250)))));
            this.btnLogueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogueo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogueo.ForeColor = System.Drawing.Color.White;
            this.btnLogueo.Location = new System.Drawing.Point(89, 165);
            this.btnLogueo.Name = "btnLogueo";
            this.btnLogueo.Size = new System.Drawing.Size(171, 28);
            this.btnLogueo.TabIndex = 3;
            this.btnLogueo.Text = "&Aceptar";
            this.btnLogueo.UseVisualStyleBackColor = false;
            this.btnLogueo.Click += new System.EventHandler(this.btnLogueo_Click);
            this.btnLogueo.MouseLeave += new System.EventHandler(this.btnLogueo_MouseLeave);
            this.btnLogueo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogueo_MouseMove);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel.Controls.Add(this.cboBase);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.txtUsuario);
            this.panel.Controls.Add(this.txtContraseña);
            this.panel.Controls.Add(this.btnLogueo);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(349, 216);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // cboBase
            // 
            this.cboBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.cboBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBase.ForeColor = System.Drawing.Color.White;
            this.cboBase.FormattingEnabled = true;
            this.cboBase.Items.AddRange(new object[] {
            "SiGE",
            "HpReserger"});
            this.cboBase.Location = new System.Drawing.Point(316, 168);
            this.cboBase.Name = "cboBase";
            this.cboBase.Size = new System.Drawing.Size(171, 24);
            this.cboBase.TabIndex = 2;
            this.cboBase.Visible = false;
            this.cboBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBase_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbclose);
            this.panel1.Controls.Add(this.pbfoto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 61);
            this.panel1.TabIndex = 5;
            // 
            // pbclose
            // 
            this.pbclose.Image = global::HPReserger.Properties.Resources.XCloseRed;
            this.pbclose.InitialImage = global::HPReserger.Properties.Resources.xCloseBlue;
            this.pbclose.Location = new System.Drawing.Point(316, 10);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(30, 23);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 6;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            this.pbclose.MouseLeave += new System.EventHandler(this.pbclose_MouseLeave);
            this.pbclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbclose_MouseMove);
            // 
            // pbfoto
            // 
            this.pbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbfoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbfoto.Image = global::HPReserger.Properties.Resources.MainFrame;
            this.pbfoto.Location = new System.Drawing.Point(0, 0);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(349, 61);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbfoto.TabIndex = 7;
            this.pbfoto.TabStop = false;
            this.pbfoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.pbfoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.pbfoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(107, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hp Reserger";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // moveControl1
            // 
            this.moveControl1.Control = this.panel1;
            // 
            // frmLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 216);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HpReserger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLogin_Paint);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogueo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.MoveControl moveControl1;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.ComboBox cboBase;
    }
}