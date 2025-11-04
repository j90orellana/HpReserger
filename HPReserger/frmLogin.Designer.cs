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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogueo = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txtgit = new DevExpress.XtraEditors.TextEdit();
            this.pbdatagit = new DevExpress.XtraEditors.PictureEdit();
            this.txtEmpresaData = new System.Windows.Forms.TextBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.ChkCRM = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.cboBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdatagit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario o Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(314, 196);
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
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(403, 164);
            this.txtUsuario.MaxLength = 100;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUsuario_DragDrop);
            this.txtUsuario.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtUsuario_DragEnter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(403, 193);
            this.txtContraseña.MaxLength = 100;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(205, 22);
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
            this.btnLogueo.Location = new System.Drawing.Point(359, 252);
            this.btnLogueo.Name = "btnLogueo";
            this.btnLogueo.Size = new System.Drawing.Size(171, 28);
            this.btnLogueo.TabIndex = 4;
            this.btnLogueo.Text = "&Aceptar";
            this.btnLogueo.UseVisualStyleBackColor = false;
            this.btnLogueo.Click += new System.EventHandler(this.btnLogueo_Click);
            this.btnLogueo.MouseLeave += new System.EventHandler(this.btnLogueo_MouseLeave);
            this.btnLogueo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogueo_MouseMove);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.txtgit);
            this.panel.Controls.Add(this.pbdatagit);
            this.panel.Controls.Add(this.txtEmpresaData);
            this.panel.Controls.Add(this.pbclose);
            this.panel.Controls.Add(this.ChkCRM);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.lblVersion);
            this.panel.Controls.Add(this.lblmsg);
            this.panel.Controls.Add(this.cboBase);
            this.panel.Controls.Add(this.txtUsuario);
            this.panel.Controls.Add(this.txtContraseña);
            this.panel.Controls.Add(this.btnLogueo);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(654, 365);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // txtgit
            // 
            this.txtgit.Location = new System.Drawing.Point(13, 22);
            this.txtgit.Name = "txtgit";
            this.txtgit.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtgit.Properties.Appearance.Options.UseBackColor = true;
            this.txtgit.Size = new System.Drawing.Size(170, 20);
            this.txtgit.TabIndex = 12;
            this.txtgit.Visible = false;
            // 
            // pbdatagit
            // 
            this.pbdatagit.EditValue = ((object)(resources.GetObject("pbdatagit.EditValue")));
            this.pbdatagit.Location = new System.Drawing.Point(189, 12);
            this.pbdatagit.Name = "pbdatagit";
            this.pbdatagit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbdatagit.Size = new System.Drawing.Size(42, 44);
            this.pbdatagit.TabIndex = 11;
            this.pbdatagit.Visible = false;
            this.pbdatagit.Click += new System.EventHandler(this.pbdatagit_Click);
            // 
            // txtEmpresaData
            // 
            this.txtEmpresaData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.txtEmpresaData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpresaData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresaData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaData.ForeColor = System.Drawing.Color.White;
            this.txtEmpresaData.Location = new System.Drawing.Point(403, 222);
            this.txtEmpresaData.MaxLength = 100;
            this.txtEmpresaData.Name = "txtEmpresaData";
            this.txtEmpresaData.ReadOnly = true;
            this.txtEmpresaData.Size = new System.Drawing.Size(205, 22);
            this.txtEmpresaData.TabIndex = 10;
            this.txtEmpresaData.Text = "A & A ASCENSORES S.A.C.";
            this.txtEmpresaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmpresaData.Visible = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = global::SISGEM.Properties.Resources.XCloseRed;
            this.pbclose.InitialImage = global::SISGEM.Properties.Resources.xCloseBlue;
            this.pbclose.Location = new System.Drawing.Point(607, 20);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(30, 23);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 6;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            this.pbclose.MouseLeave += new System.EventHandler(this.pbclose_MouseLeave);
            this.pbclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbclose_MouseMove);
            // 
            // ChkCRM
            // 
            this.ChkCRM.Location = new System.Drawing.Point(576, 61);
            this.ChkCRM.Name = "ChkCRM";
            this.ChkCRM.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ChkCRM.Properties.Appearance.Options.UseForeColor = true;
            this.ChkCRM.Properties.Caption = "Otros";
            this.ChkCRM.Size = new System.Drawing.Size(75, 19);
            this.ChkCRM.TabIndex = 2;
            this.ChkCRM.Visible = false;
            this.ChkCRM.CheckedChanged += new System.EventHandler(this.ChkCRM_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Location = new System.Drawing.Point(595, 282);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.ToolTip = "Ver Contenido de la Versión";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(530, 261);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(101, 19);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version:3.2.0.12";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmsg
            // 
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(307, 282);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmsg.Size = new System.Drawing.Size(309, 19);
            this.lblmsg.TabIndex = 6;
            this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBase
            // 
            this.cboBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.cboBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBase.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBase.ForeColor = System.Drawing.Color.White;
            this.cboBase.FormattingEnabled = true;
            this.cboBase.Location = new System.Drawing.Point(403, 222);
            this.cboBase.MaxLength = 100;
            this.cboBase.Name = "cboBase";
            this.cboBase.Size = new System.Drawing.Size(205, 24);
            this.cboBase.TabIndex = 3;
            this.cboBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBase_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(472, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "AutoGest";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido a";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 365);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoGest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLogin_Paint);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdatagit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogueo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cboBase;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblVersion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ChkCRM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.TextBox txtEmpresaData;
        private DevExpress.XtraEditors.PictureEdit pbdatagit;
        private DevExpress.XtraEditors.TextEdit txtgit;
    }
}