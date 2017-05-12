namespace HPReserger
{
    partial class frmgerencia
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
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtgerencia = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.Location = new System.Drawing.Point(13, 69);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(262, 133);
            this.dtgconten.TabIndex = 6;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(296, 65);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(296, 38);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(193, 208);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(95, 208);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(296, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtgerencia
            // 
            this.txtgerencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgerencia.Location = new System.Drawing.Point(87, 43);
            this.txtgerencia.Name = "txtgerencia";
            this.txtgerencia.Size = new System.Drawing.Size(188, 20);
            this.txtgerencia.TabIndex = 13;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(87, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(188, 20);
            this.txtcodigo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gerencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // frmgerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 246);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtgerencia);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmgerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerencia";
            this.Load += new System.EventHandler(this.frmgerencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtgerencia;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tipmsg;
    }
}