namespace HPReserger
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgperfil = new System.Windows.Forms.DataGridView();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.cboperfiles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treePerfiles = new System.Windows.Forms.TreeView();
            this.btnampliar = new System.Windows.Forms.Button();
            this.btnocultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgperfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(86, 14);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(238, 21);
            this.txtcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // txtdes
            // 
            this.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdes.Enabled = false;
            this.txtdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(86, 38);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(238, 21);
            this.txtdes.TabIndex = 3;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(328, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 24);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(328, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 24);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(328, 60);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 24);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(242, 376);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 24);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(328, 376);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dtgperfil
            // 
            this.dtgperfil.AllowUserToAddRows = false;
            this.dtgperfil.AllowUserToDeleteRows = false;
            this.dtgperfil.AllowUserToResizeColumns = false;
            this.dtgperfil.AllowUserToResizeRows = false;
            this.dtgperfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgperfil.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgperfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgperfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgperfil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgperfil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgperfil.Location = new System.Drawing.Point(659, 94);
            this.dtgperfil.MultiSelect = false;
            this.dtgperfil.Name = "dtgperfil";
            this.dtgperfil.ReadOnly = true;
            this.dtgperfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgperfil.RowHeadersVisible = false;
            this.dtgperfil.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgperfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgperfil.Size = new System.Drawing.Size(262, 133);
            this.dtgperfil.TabIndex = 1;
            this.dtgperfil.Visible = false;
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // cboperfiles
            // 
            this.cboperfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperfiles.FormattingEnabled = true;
            this.cboperfiles.Location = new System.Drawing.Point(86, 62);
            this.cboperfiles.Name = "cboperfiles";
            this.cboperfiles.Size = new System.Drawing.Size(238, 21);
            this.cboperfiles.TabIndex = 4;
            this.cboperfiles.SelectedIndexChanged += new System.EventHandler(this.cboperfiles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perfiles:";
            // 
            // treePerfiles
            // 
            this.treePerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePerfiles.CheckBoxes = true;
            this.treePerfiles.Location = new System.Drawing.Point(12, 87);
            this.treePerfiles.Name = "treePerfiles";
            this.treePerfiles.Size = new System.Drawing.Size(398, 283);
            this.treePerfiles.TabIndex = 6;
            this.treePerfiles.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treePerfiles_BeforeCheck);
            this.treePerfiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePerfiles_AfterCheck);
            this.treePerfiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treePerfiles_AfterSelect);
            // 
            // btnampliar
            // 
            this.btnampliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnampliar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnampliar.Image = ((System.Drawing.Image)(resources.GetObject("btnampliar.Image")));
            this.btnampliar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnampliar.Location = new System.Drawing.Point(12, 376);
            this.btnampliar.Name = "btnampliar";
            this.btnampliar.Size = new System.Drawing.Size(118, 24);
            this.btnampliar.TabIndex = 7;
            this.btnampliar.Text = "Ampliar Todo";
            this.btnampliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnampliar.UseVisualStyleBackColor = true;
            this.btnampliar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnocultar
            // 
            this.btnocultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnocultar.Image = ((System.Drawing.Image)(resources.GetObject("btnocultar.Image")));
            this.btnocultar.Location = new System.Drawing.Point(12, 376);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(118, 24);
            this.btnocultar.TabIndex = 8;
            this.btnocultar.Text = "Ocultar Todo";
            this.btnocultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 405);
            this.Colores = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(229)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))))};
            this.Controls.Add(this.btnampliar);
            this.Controls.Add(this.treePerfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboperfiles);
            this.Controls.Add(this.dtgperfil);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnocultar);
            this.MinimumSize = new System.Drawing.Size(438, 444);
            this.Name = "FrmPerfil";
            this.Nombre = "Perfiles";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgperfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView dtgperfil;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.ComboBox cboperfiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treePerfiles;
        private System.Windows.Forms.Button btnampliar;
        private System.Windows.Forms.Button btnocultar;
    }
}