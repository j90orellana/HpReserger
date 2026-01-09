using HpResergerUserControls;

namespace HPReserger
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboarea = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.codigox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gerenciax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCostox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btngermas = new System.Windows.Forms.Button();
            this.cboccosto = new System.Windows.Forms.ComboBox();
            this.btnccostomas = new System.Windows.Forms.Button();
            this.dtgareas = new System.Windows.Forms.DataGridView();
            this.Txtbusca = new HpResergerUserControls.txtBuscar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgareas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboarea
            // 
            this.cboarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboarea.FormattingEnabled = true;
            this.cboarea.Location = new System.Drawing.Point(101, 12);
            this.cboarea.Name = "cboarea";
            this.cboarea.Size = new System.Drawing.Size(193, 21);
            this.cboarea.TabIndex = 63;
            this.cboarea.TextChanged += new System.EventHandler(this.cboarea_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(372, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 62;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Gerencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(101, 36);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(371, 21);
            this.txtdescripcion.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Centro de Costo";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(478, 59);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 70;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(478, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 71;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(478, 11);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 69;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(478, 462);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 72;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(390, 462);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 73;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.CheckColumna = null;
            this.dtgconten.CheckValor = 1;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigox,
            this.Gerenciax,
            this.Descripcionx,
            this.Costox,
            this.CentroCostox,
            this.Codx});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 118);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(545, 338);
            this.dtgconten.TabIndex = 74;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // codigox
            // 
            this.codigox.DataPropertyName = "codigo";
            this.codigox.HeaderText = "Codigo";
            this.codigox.Name = "codigox";
            this.codigox.ReadOnly = true;
            this.codigox.Visible = false;
            // 
            // Gerenciax
            // 
            this.Gerenciax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gerenciax.DataPropertyName = "gerencia";
            this.Gerenciax.HeaderText = "Gerencia";
            this.Gerenciax.Name = "Gerenciax";
            this.Gerenciax.ReadOnly = true;
            this.Gerenciax.Width = 77;
            // 
            // Descripcionx
            // 
            this.Descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descripcionx.DataPropertyName = "descripcion";
            this.Descripcionx.HeaderText = "Descripción";
            this.Descripcionx.Name = "Descripcionx";
            this.Descripcionx.ReadOnly = true;
            this.Descripcionx.Width = 93;
            // 
            // Costox
            // 
            this.Costox.DataPropertyName = "costo";
            this.Costox.HeaderText = "Costo";
            this.Costox.Name = "Costox";
            this.Costox.ReadOnly = true;
            this.Costox.Visible = false;
            // 
            // CentroCostox
            // 
            this.CentroCostox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CentroCostox.DataPropertyName = "centro de costo";
            this.CentroCostox.HeaderText = "Centro De Costo";
            this.CentroCostox.MinimumWidth = 100;
            this.CentroCostox.Name = "CentroCostox";
            this.CentroCostox.ReadOnly = true;
            // 
            // Codx
            // 
            this.Codx.DataPropertyName = "cod";
            this.Codx.HeaderText = "Cod";
            this.Codx.Name = "Codx";
            this.Codx.ReadOnly = true;
            this.Codx.Visible = false;
            // 
            // btngermas
            // 
            this.btngermas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngermas.Image = ((System.Drawing.Image)(resources.GetObject("btngermas.Image")));
            this.btngermas.Location = new System.Drawing.Point(300, 12);
            this.btngermas.Name = "btngermas";
            this.btngermas.Size = new System.Drawing.Size(20, 21);
            this.btngermas.TabIndex = 78;
            this.btngermas.UseVisualStyleBackColor = true;
            this.btngermas.Click += new System.EventHandler(this.btndepmas_Click);
            // 
            // cboccosto
            // 
            this.cboccosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboccosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboccosto.FormattingEnabled = true;
            this.cboccosto.Location = new System.Drawing.Point(101, 60);
            this.cboccosto.Name = "cboccosto";
            this.cboccosto.Size = new System.Drawing.Size(345, 21);
            this.cboccosto.TabIndex = 79;
            this.cboccosto.TextChanged += new System.EventHandler(this.cboccosto_TextChanged);
            // 
            // btnccostomas
            // 
            this.btnccostomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnccostomas.Image = ((System.Drawing.Image)(resources.GetObject("btnccostomas.Image")));
            this.btnccostomas.Location = new System.Drawing.Point(452, 60);
            this.btnccostomas.Name = "btnccostomas";
            this.btnccostomas.Size = new System.Drawing.Size(20, 21);
            this.btnccostomas.TabIndex = 80;
            this.btnccostomas.UseVisualStyleBackColor = true;
            this.btnccostomas.Click += new System.EventHandler(this.btnccostomas_Click);
            // 
            // dtgareas
            // 
            this.dtgareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgareas.Location = new System.Drawing.Point(596, 178);
            this.dtgareas.Name = "dtgareas";
            this.dtgareas.Size = new System.Drawing.Size(350, 150);
            this.dtgareas.TabIndex = 81;
            this.dtgareas.Visible = false;
            // 
            // Txtbusca
            // 
            this.Txtbusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Txtbusca.FondoBoton = ((System.Drawing.Image)(resources.GetObject("Txtbusca.FondoBoton")));
            this.Txtbusca.ImgBotonCerrar = null;
            this.Txtbusca.Location = new System.Drawing.Point(15, 90);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(457, 22);
            this.Txtbusca.TabIndex = 82;
            this.Txtbusca.BuscarClick += new System.EventHandler(this.Txtbusca_TextChanged);
            this.Txtbusca.ClickLimpiarboton += new System.EventHandler(this.btnlimpiar_Click);
            this.Txtbusca.BuscarTextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 493);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgareas);
            this.Controls.Add(this.btnccostomas);
            this.Controls.Add(this.cboccosto);
            this.Controls.Add(this.btngermas);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboarea);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(584, 532);
            this.Name = "frmArea";
            this.Nombre = "Area";
            this.Text = "Area";
            this.Activated += new System.EventHandler(this.frmArea_Activated_1);
            this.Load += new System.EventHandler(this.frmArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboarea;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btngermas;
        private System.Windows.Forms.ComboBox cboccosto;
        private System.Windows.Forms.Button btnccostomas;
        private System.Windows.Forms.DataGridView dtgareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gerenciax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCostox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codx;
        public txtBuscar Txtbusca;
    }
}