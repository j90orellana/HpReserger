namespace HPReserger
{
    partial class frmmarcamodelo
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnmodelomas = new System.Windows.Forms.Button();
            this.btnmarcamas = new System.Windows.Forms.Button();
            this.cbomodelo = new System.Windows.Forms.ComboBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(370, 66);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 85;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(370, 39);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 86;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(370, 13);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 84;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.Location = new System.Drawing.Point(11, 93);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(353, 287);
            this.dtgconten.TabIndex = 89;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(282, 386);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 87;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Location = new System.Drawing.Point(194, 386);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 88;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnmodelomas
            // 
            this.btnmodelomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelomas.Location = new System.Drawing.Point(344, 38);
            this.btnmodelomas.Name = "btnmodelomas";
            this.btnmodelomas.Size = new System.Drawing.Size(20, 21);
            this.btnmodelomas.TabIndex = 104;
            this.btnmodelomas.Text = "+";
            this.btnmodelomas.UseVisualStyleBackColor = true;
            this.btnmodelomas.Click += new System.EventHandler(this.btnmodelomas_Click);
            // 
            // btnmarcamas
            // 
            this.btnmarcamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarcamas.Location = new System.Drawing.Point(344, 11);
            this.btnmarcamas.Name = "btnmarcamas";
            this.btnmarcamas.Size = new System.Drawing.Size(20, 21);
            this.btnmarcamas.TabIndex = 103;
            this.btnmarcamas.Text = "+";
            this.btnmarcamas.UseVisualStyleBackColor = true;
            this.btnmarcamas.Click += new System.EventHandler(this.btnmarcamas_Click);
            // 
            // cbomodelo
            // 
            this.cbomodelo.FormattingEnabled = true;
            this.cbomodelo.Location = new System.Drawing.Point(83, 39);
            this.cbomodelo.Name = "cbomodelo";
            this.cbomodelo.Size = new System.Drawing.Size(255, 21);
            this.cbomodelo.TabIndex = 102;
            this.cbomodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomodelo_KeyPress);
            // 
            // cbomarca
            // 
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(83, 12);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(255, 21);
            this.cbomarca.TabIndex = 101;
            this.cbomarca.TextChanged += new System.EventHandler(this.cbomarca_TextChanged);
            this.cbomarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomarca_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Marca";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(344, 66);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 109;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(83, 66);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(255, 20);
            this.Txtbusca.TabIndex = 107;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(7, 402);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 110;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // frmmarcamodelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 420);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnmodelomas);
            this.Controls.Add(this.btnmarcamas);
            this.Controls.Add(this.cbomodelo);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmmarcamodelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca/Modelo";
            this.Activated += new System.EventHandler(this.frmmarcamodelo_Activated);
            this.Load += new System.EventHandler(this.frmmarcacodigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnmodelomas;
        private System.Windows.Forms.Button btnmarcamas;
        private System.Windows.Forms.ComboBox cbomodelo;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.Label lblmsg;
    }
}