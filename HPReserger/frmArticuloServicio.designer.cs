namespace HPReserger
{
    partial class frmArticuloServicio
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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbomodelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.btnmarcamas = new System.Windows.Forms.Button();
            this.btnmodelomas = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.veri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(478, 66);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(478, 39);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 80;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(478, 13);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 78;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(87, 165);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 86;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(113, 165);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(447, 20);
            this.Txtbusca.TabIndex = 84;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
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
            this.dtgconten.Location = new System.Drawing.Point(15, 189);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(545, 287);
            this.dtgconten.TabIndex = 83;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(478, 482);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 81;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Location = new System.Drawing.Point(390, 482);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 82;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(88, 12);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(214, 21);
            this.cbotipo.TabIndex = 87;
            this.cbotipo.TextChanged += new System.EventHandler(this.cbotipo_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(354, 13);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(117, 20);
            this.txtcodigo.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(89, 36);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(383, 20);
            this.txtdescripcion.TabIndex = 92;
            // 
            // cbomarca
            // 
            this.cbomarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbomarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(88, 62);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(357, 21);
            this.cbomarca.TabIndex = 94;
            this.cbomarca.SelectedIndexChanged += new System.EventHandler(this.cbomarca_SelectedIndexChanged);
            this.cbomarca.TextChanged += new System.EventHandler(this.cbomarca_TextChanged);
            this.cbomarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomarca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Modelo";
            // 
            // cbomodelo
            // 
            this.cbomodelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbomodelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbomodelo.FormattingEnabled = true;
            this.cbomodelo.Location = new System.Drawing.Point(88, 89);
            this.cbomodelo.Name = "cbomodelo";
            this.cbomodelo.Size = new System.Drawing.Size(357, 21);
            this.cbomodelo.TabIndex = 96;
            this.cbomodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomodelo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Observaciones";
            // 
            // txtobservacion
            // 
            this.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacion.Location = new System.Drawing.Point(88, 114);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtobservacion.Size = new System.Drawing.Size(383, 45);
            this.txtobservacion.TabIndex = 98;
            // 
            // btnmarcamas
            // 
            this.btnmarcamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarcamas.Location = new System.Drawing.Point(451, 62);
            this.btnmarcamas.Name = "btnmarcamas";
            this.btnmarcamas.Size = new System.Drawing.Size(20, 21);
            this.btnmarcamas.TabIndex = 99;
            this.btnmarcamas.Text = "+";
            this.btnmarcamas.UseVisualStyleBackColor = true;
            this.btnmarcamas.Click += new System.EventHandler(this.btnmarcamas_Click);
            // 
            // btnmodelomas
            // 
            this.btnmodelomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelomas.Location = new System.Drawing.Point(451, 89);
            this.btnmodelomas.Name = "btnmodelomas";
            this.btnmodelomas.Size = new System.Drawing.Size(20, 21);
            this.btnmodelomas.TabIndex = 100;
            this.btnmodelomas.Text = "+";
            this.btnmodelomas.UseVisualStyleBackColor = true;
            this.btnmodelomas.Click += new System.EventHandler(this.btnmodelomas_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 498);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 111;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // veri
            // 
            this.veri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veri.Location = new System.Drawing.Point(976, 394);
            this.veri.Name = "veri";
            this.veri.Size = new System.Drawing.Size(94, 119);
            this.veri.TabIndex = 112;
            // 
            // frmArticuloServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 519);
            this.Controls.Add(this.veri);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnmodelomas);
            this.Controls.Add(this.btnmarcamas);
            this.Controls.Add(this.txtobservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbomodelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmArticuloServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo/Servicio";
            this.Activated += new System.EventHandler(this.frmArticuloServicio_Activated);
            this.Load += new System.EventHandler(this.frmArticuloServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbomodelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Button btnmarcamas;
        private System.Windows.Forms.Button btnmodelomas;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridView veri;
    }
}