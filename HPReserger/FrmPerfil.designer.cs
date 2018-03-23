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
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(86, 14);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(236, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // txtdes
            // 
            this.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdes.Enabled = false;
            this.txtdes.Location = new System.Drawing.Point(86, 40);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(236, 20);
            this.txtdes.TabIndex = 3;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Location = new System.Drawing.Point(328, 14);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Location = new System.Drawing.Point(328, 40);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.Location = new System.Drawing.Point(328, 67);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Location = new System.Drawing.Point(240, 364);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Location = new System.Drawing.Point(328, 364);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
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
            this.cboperfiles.Location = new System.Drawing.Point(86, 67);
            this.cboperfiles.Name = "cboperfiles";
            this.cboperfiles.Size = new System.Drawing.Size(236, 21);
            this.cboperfiles.TabIndex = 4;
            this.cboperfiles.SelectedIndexChanged += new System.EventHandler(this.cboperfiles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perfiles:";
            // 
            // treePerfiles
            // 
            this.treePerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePerfiles.CheckBoxes = true;
            this.treePerfiles.Location = new System.Drawing.Point(12, 95);
            this.treePerfiles.Name = "treePerfiles";
            this.treePerfiles.Size = new System.Drawing.Size(398, 263);
            this.treePerfiles.TabIndex = 6;
            this.treePerfiles.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treePerfiles_BeforeCheck);
            this.treePerfiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePerfiles_AfterCheck);
            this.treePerfiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treePerfiles_AfterSelect);
            // 
            // btnampliar
            // 
            this.btnampliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnampliar.Location = new System.Drawing.Point(12, 364);
            this.btnampliar.Name = "btnampliar";
            this.btnampliar.Size = new System.Drawing.Size(82, 21);
            this.btnampliar.TabIndex = 7;
            this.btnampliar.Text = "Ampliar Todo";
            this.btnampliar.UseVisualStyleBackColor = true;
            this.btnampliar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnocultar
            // 
            this.btnocultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnocultar.Location = new System.Drawing.Point(12, 364);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(82, 21);
            this.btnocultar.TabIndex = 8;
            this.btnocultar.Text = "Ocultar Todo";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 405);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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