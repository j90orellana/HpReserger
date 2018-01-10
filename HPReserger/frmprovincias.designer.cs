namespace HPReserger
{
    partial class frmprovincias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbodepartamento = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.cboprovincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndepmas = new System.Windows.Forms.Button();
            this.dtgprovincias = new System.Windows.Forms.DataGridView();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.coddepx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprovincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // cbodepartamento
            // 
            this.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbodepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodepartamento.FormattingEnabled = true;
            this.cbodepartamento.Location = new System.Drawing.Point(100, 37);
            this.cbodepartamento.Name = "cbodepartamento";
            this.cbodepartamento.Size = new System.Drawing.Size(366, 21);
            this.cbodepartamento.TabIndex = 59;
            this.cbodepartamento.TextChanged += new System.EventHandler(this.cbodepartamento_TextChanged);
            this.cbodepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbodepartamento_KeyPress);
            this.cbodepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbodepartamento_KeyUp);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(100, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(366, 20);
            this.txtcodigo.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Código";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(100, 90);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(25, 21);
            this.btnlimpiar.TabIndex = 62;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(131, 90);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(335, 20);
            this.Txtbusca.TabIndex = 60;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(498, 63);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 64;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(498, 36);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 65;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(498, 10);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 63;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(498, 391);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 67;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Location = new System.Drawing.Point(400, 391);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 68;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // cboprovincia
            // 
            this.cboprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprovincia.FormattingEnabled = true;
            this.cboprovincia.Location = new System.Drawing.Point(100, 63);
            this.cboprovincia.Name = "cboprovincia";
            this.cboprovincia.Size = new System.Drawing.Size(366, 21);
            this.cboprovincia.TabIndex = 70;
            this.cboprovincia.TextChanged += new System.EventHandler(this.cboprovincia_TextChanged);
            this.cboprovincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboprovincia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Provincia";
            // 
            // btndepmas
            // 
            this.btndepmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepmas.Location = new System.Drawing.Point(472, 37);
            this.btndepmas.Name = "btndepmas";
            this.btndepmas.Size = new System.Drawing.Size(20, 18);
            this.btndepmas.TabIndex = 71;
            this.btndepmas.Text = "...";
            this.btndepmas.UseVisualStyleBackColor = true;
            this.btndepmas.Click += new System.EventHandler(this.btndepmas_Click);
            // 
            // dtgprovincias
            // 
            this.dtgprovincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgprovincias.Location = new System.Drawing.Point(665, 130);
            this.dtgprovincias.Name = "dtgprovincias";
            this.dtgprovincias.Size = new System.Drawing.Size(240, 150);
            this.dtgprovincias.TabIndex = 72;
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coddepx,
            this.departamentox,
            this.codprox,
            this.provinciax});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(12, 116);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F);
            this.dtgconten.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(568, 269);
            this.dtgconten.TabIndex = 73;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // coddepx
            // 
            this.coddepx.DataPropertyName = "coddep";
            this.coddepx.HeaderText = "coddep";
            this.coddepx.Name = "coddepx";
            this.coddepx.Visible = false;
            // 
            // departamentox
            // 
            this.departamentox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departamentox.DataPropertyName = "departamento";
            this.departamentox.HeaderText = "Departamento ";
            this.departamentox.Name = "departamentox";
            // 
            // codprox
            // 
            this.codprox.DataPropertyName = "codpro";
            this.codprox.HeaderText = "codpro";
            this.codprox.Name = "codprox";
            this.codprox.Visible = false;
            // 
            // provinciax
            // 
            this.provinciax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.provinciax.DataPropertyName = "provincia";
            this.provinciax.HeaderText = "Provincia";
            this.provinciax.Name = "provinciax";
            // 
            // frmprovincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.dtgprovincias);
            this.Controls.Add(this.btndepmas);
            this.Controls.Add(this.cboprovincia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.cbodepartamento);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(610, 471);
            this.MinimumSize = new System.Drawing.Size(610, 471);
            this.Name = "frmprovincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.frmprovincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgprovincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbodepartamento;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.ComboBox cboprovincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndepmas;
        private System.Windows.Forms.DataGridView dtgprovincias;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddepx;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciax;
    }
}