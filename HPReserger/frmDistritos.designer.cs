using HpResergerUserControls;

namespace HPReserger
{
    partial class frmDistritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbodepartamento = new System.Windows.Forms.ComboBox();
            this.cboprovincia = new System.Windows.Forms.ComboBox();
            this.cbodistrito = new System.Windows.Forms.ComboBox();
            this.btndepmas = new System.Windows.Forms.Button();
            this.btnpromas = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.coddepx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddisx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distritox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgdistritos = new HpResergerUserControls.Dtgconten();
            this.Txtbusca = new HpResergerUserControls.txtBuscar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdistritos)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(551, 67);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 24);
            this.btneliminar.TabIndex = 44;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(551, 42);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 24);
            this.btnmodificar.TabIndex = 45;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(551, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 24);
            this.btnnuevo.TabIndex = 43;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(551, 451);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(463, 451);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 24);
            this.btnaceptar.TabIndex = 50;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(96, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(273, 21);
            this.txtcodigo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Distrito";
            // 
            // cbodepartamento
            // 
            this.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbodepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodepartamento.FormattingEnabled = true;
            this.cbodepartamento.Location = new System.Drawing.Point(96, 44);
            this.cbodepartamento.Name = "cbodepartamento";
            this.cbodepartamento.Size = new System.Drawing.Size(273, 21);
            this.cbodepartamento.TabIndex = 55;
            this.cbodepartamento.TextChanged += new System.EventHandler(this.cbodepartamento_TextChanged);
            this.cbodepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbodepartamento_KeyPress);
            // 
            // cboprovincia
            // 
            this.cboprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboprovincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprovincia.FormattingEnabled = true;
            this.cboprovincia.Location = new System.Drawing.Point(96, 69);
            this.cboprovincia.Name = "cboprovincia";
            this.cboprovincia.Size = new System.Drawing.Size(273, 21);
            this.cboprovincia.TabIndex = 56;
            this.cboprovincia.SelectedIndexChanged += new System.EventHandler(this.cboprovincia_SelectedIndexChanged);
            this.cboprovincia.TextChanged += new System.EventHandler(this.cboprovincia_TextChanged);
            this.cboprovincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboprovincia_KeyPress);
            // 
            // cbodistrito
            // 
            this.cbodistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbodistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodistrito.FormattingEnabled = true;
            this.cbodistrito.Location = new System.Drawing.Point(96, 94);
            this.cbodistrito.Name = "cbodistrito";
            this.cbodistrito.Size = new System.Drawing.Size(273, 21);
            this.cbodistrito.TabIndex = 57;
            this.cbodistrito.SelectedIndexChanged += new System.EventHandler(this.cbodistrito_SelectedIndexChanged);
            this.cbodistrito.TextChanged += new System.EventHandler(this.cbodistrito_TextChanged);
            this.cbodistrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbodistrito_KeyPress);
            // 
            // btndepmas
            // 
            this.btndepmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepmas.Image = ((System.Drawing.Image)(resources.GetObject("btndepmas.Image")));
            this.btndepmas.Location = new System.Drawing.Point(376, 42);
            this.btndepmas.Name = "btndepmas";
            this.btndepmas.Size = new System.Drawing.Size(24, 24);
            this.btndepmas.TabIndex = 60;
            this.btndepmas.UseVisualStyleBackColor = true;
            this.btndepmas.Click += new System.EventHandler(this.btndepmas_Click);
            // 
            // btnpromas
            // 
            this.btnpromas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromas.Image = ((System.Drawing.Image)(resources.GetObject("btnpromas.Image")));
            this.btnpromas.Location = new System.Drawing.Point(376, 67);
            this.btnpromas.Name = "btnpromas";
            this.btnpromas.Size = new System.Drawing.Size(24, 24);
            this.btnpromas.TabIndex = 62;
            this.btnpromas.UseVisualStyleBackColor = true;
            this.btnpromas.Click += new System.EventHandler(this.btnpromas_Click);
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
            this.coddepx,
            this.departamentox,
            this.codprox,
            this.provinciax,
            this.coddisx,
            this.Distritox});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 146);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(620, 299);
            this.dtgconten.TabIndex = 74;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter_1);
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
            this.codprox.DataPropertyName = "codprov";
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
            // coddisx
            // 
            this.coddisx.DataPropertyName = "coddis";
            this.coddisx.HeaderText = "Coddis";
            this.coddisx.Name = "coddisx";
            this.coddisx.Visible = false;
            // 
            // Distritox
            // 
            this.Distritox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Distritox.DataPropertyName = "Distrito";
            this.Distritox.HeaderText = "Distrito";
            this.Distritox.Name = "Distritox";
            // 
            // dtgdistritos
            // 
            this.dtgdistritos.AllowUserToOrderColumns = true;
            this.dtgdistritos.AllowUserToResizeColumns = false;
            this.dtgdistritos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgdistritos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgdistritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdistritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdistritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgdistritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdistritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgdistritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgdistritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgdistritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgdistritos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgdistritos.EnableHeadersVisualStyles = false;
            this.dtgdistritos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgdistritos.Location = new System.Drawing.Point(693, 146);
            this.dtgdistritos.Name = "dtgdistritos";
            this.dtgdistritos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgdistritos.RowHeadersVisible = false;
            this.dtgdistritos.Size = new System.Drawing.Size(240, 150);
            this.dtgdistritos.TabIndex = 61;
            // 
            // Txtbusca
            // 
            this.Txtbusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Txtbusca.FondoBoton = ((System.Drawing.Image)(resources.GetObject("Txtbusca.FondoBoton")));
            this.Txtbusca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbusca.ForeColor = System.Drawing.Color.Black;
            this.Txtbusca.ImgBotonCerrar = null;
            this.Txtbusca.Location = new System.Drawing.Point(12, 119);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(388, 22);
            this.Txtbusca.TabIndex = 82;
            this.Txtbusca.BuscarClick += new System.EventHandler(this.txtbusca_TextChanged);
            this.Txtbusca.ClickLimpiarboton += new System.EventHandler(this.btnlimpiar_Click);
            this.Txtbusca.BuscarTextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // frmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 483);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnpromas);
            this.Controls.Add(this.dtgdistritos);
            this.Controls.Add(this.btndepmas);
            this.Controls.Add(this.cbodistrito);
            this.Controls.Add(this.cboprovincia);
            this.Controls.Add(this.cbodepartamento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.MaximumSize = new System.Drawing.Size(660, 522);
            this.MinimumSize = new System.Drawing.Size(660, 522);
            this.Name = "frmDistritos";
            this.Nombre = "Distritos";
            this.Text = "Distritos";
            this.Activated += new System.EventHandler(this.frmDistritos_Activated);
            this.Load += new System.EventHandler(this.frmDistritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdistritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbodepartamento;
        private System.Windows.Forms.ComboBox cboprovincia;
        private System.Windows.Forms.ComboBox cbodistrito;
        private System.Windows.Forms.Button btndepmas;
        private Dtgconten dtgdistritos;
        private System.Windows.Forms.Button btnpromas;
        private Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddepx;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciax;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddisx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distritox;
        private txtBuscar Txtbusca;
    }
}