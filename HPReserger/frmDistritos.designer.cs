﻿namespace HPReserger
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbodepartamento = new System.Windows.Forms.ComboBox();
            this.cboprovincia = new System.Windows.Forms.ComboBox();
            this.cbodistrito = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btndepmas = new System.Windows.Forms.Button();
            this.dtgdistritos = new System.Windows.Forms.DataGridView();
            this.btnpromas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdistritos)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(551, 76);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 21);
            this.btneliminar.TabIndex = 44;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(551, 49);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 21);
            this.btnmodificar.TabIndex = 45;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(551, 23);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 20);
            this.btnnuevo.TabIndex = 43;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
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
            this.dtgconten.Location = new System.Drawing.Point(12, 146);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(621, 266);
            this.dtgconten.TabIndex = 48;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(551, 418);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 49;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Location = new System.Drawing.Point(453, 418);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 50;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(165, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(146, 20);
            this.txtcodigo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código";
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(165, 120);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(468, 20);
            this.Txtbusca.TabIndex = 53;
            this.tipmsg.SetToolTip(this.Txtbusca, "Busca Distrito");
            this.Txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "BUSCAR";
            // 
            // cbodepartamento
            // 
            this.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodepartamento.FormattingEnabled = true;
            this.cbodepartamento.Location = new System.Drawing.Point(165, 45);
            this.cbodepartamento.Name = "cbodepartamento";
            this.cbodepartamento.Size = new System.Drawing.Size(197, 21);
            this.cbodepartamento.TabIndex = 55;
            this.cbodepartamento.TextChanged += new System.EventHandler(this.cbodepartamento_TextChanged);
            this.cbodepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbodepartamento_KeyPress);
            // 
            // cboprovincia
            // 
            this.cboprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboprovincia.FormattingEnabled = true;
            this.cboprovincia.Location = new System.Drawing.Point(165, 68);
            this.cboprovincia.Name = "cboprovincia";
            this.cboprovincia.Size = new System.Drawing.Size(197, 21);
            this.cboprovincia.TabIndex = 56;
            this.cboprovincia.SelectedIndexChanged += new System.EventHandler(this.cboprovincia_SelectedIndexChanged);
            this.cboprovincia.TextChanged += new System.EventHandler(this.cboprovincia_TextChanged);
            this.cboprovincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboprovincia_KeyPress);
            // 
            // cbodistrito
            // 
            this.cbodistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodistrito.FormattingEnabled = true;
            this.cbodistrito.Location = new System.Drawing.Point(165, 94);
            this.cbodistrito.Name = "cbodistrito";
            this.cbodistrito.Size = new System.Drawing.Size(197, 21);
            this.cbodistrito.TabIndex = 57;
            this.cbodistrito.SelectedIndexChanged += new System.EventHandler(this.cbodistrito_SelectedIndexChanged);
            this.cbodistrito.TextChanged += new System.EventHandler(this.cbodistrito_TextChanged);
            this.cbodistrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbodistrito_KeyPress);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(134, 119);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(25, 21);
            this.btnlimpiar.TabIndex = 59;
            this.btnlimpiar.Text = "";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btndepmas
            // 
            this.btndepmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepmas.Location = new System.Drawing.Point(369, 47);
            this.btndepmas.Name = "btndepmas";
            this.btndepmas.Size = new System.Drawing.Size(20, 18);
            this.btndepmas.TabIndex = 60;
            this.btndepmas.Text = "...";
            this.btndepmas.UseVisualStyleBackColor = true;
            this.btndepmas.Click += new System.EventHandler(this.btndepmas_Click);
            // 
            // dtgdistritos
            // 
            this.dtgdistritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdistritos.Location = new System.Drawing.Point(693, 146);
            this.dtgdistritos.Name = "dtgdistritos";
            this.dtgdistritos.Size = new System.Drawing.Size(240, 150);
            this.dtgdistritos.TabIndex = 61;
            // 
            // btnpromas
            // 
            this.btnpromas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpromas.Location = new System.Drawing.Point(369, 71);
            this.btnpromas.Name = "btnpromas";
            this.btnpromas.Size = new System.Drawing.Size(20, 18);
            this.btnpromas.TabIndex = 62;
            this.btnpromas.Text = "...";
            this.btnpromas.UseVisualStyleBackColor = true;
            this.btnpromas.Click += new System.EventHandler(this.btnpromas_Click);
            // 
            // frmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 483);
            this.Controls.Add(this.btnpromas);
            this.Controls.Add(this.dtgdistritos);
            this.Controls.Add(this.btndepmas);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.cbodistrito);
            this.Controls.Add(this.cboprovincia);
            this.Controls.Add(this.cbodepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgconten);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDistritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtbusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbodepartamento;
        private System.Windows.Forms.ComboBox cboprovincia;
        private System.Windows.Forms.ComboBox cbodistrito;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btndepmas;
        private System.Windows.Forms.DataGridView dtgdistritos;
        private System.Windows.Forms.Button btnpromas;
    }
}