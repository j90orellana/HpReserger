﻿namespace HPReserger
{
    partial class frmEmpleadoCTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoCTS));
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.pnlconten = new System.Windows.Forms.Panel();
            this.txtCuentaCCI = new HpResergerUserControls.TextBoxPer();
            this.txtCuenta = new HpResergerUserControls.TextBoxPer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlconten.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBanco
            // 
            this.cboBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(3, 15);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(210, 21);
            this.cboBanco.TabIndex = 0;
            // 
            // cboMoneda
            // 
            this.cboMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(3, 47);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de Cuenta CCI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moneda";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(376, 19);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(376, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(376, 149);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(295, 149);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 20;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // pnlconten
            // 
            this.pnlconten.BackColor = System.Drawing.Color.Transparent;
            this.pnlconten.Controls.Add(this.txtCuentaCCI);
            this.pnlconten.Controls.Add(this.txtCuenta);
            this.pnlconten.Controls.Add(this.cboBanco);
            this.pnlconten.Controls.Add(this.cboMoneda);
            this.pnlconten.Location = new System.Drawing.Point(134, 0);
            this.pnlconten.Name = "pnlconten";
            this.pnlconten.Size = new System.Drawing.Size(226, 140);
            this.pnlconten.TabIndex = 22;
            // 
            // txtCuentaCCI
            // 
            this.txtCuentaCCI.BackColor = System.Drawing.Color.White;
            this.txtCuentaCCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuentaCCI.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtCuentaCCI.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtCuentaCCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaCCI.ForeColor = System.Drawing.Color.Black;
            this.txtCuentaCCI.Format = null;
            this.txtCuentaCCI.Location = new System.Drawing.Point(3, 112);
            this.txtCuentaCCI.MaxLength = 20;
            this.txtCuentaCCI.Name = "txtCuentaCCI";
            this.txtCuentaCCI.NextControlOnEnter = this.btnaceptar;
            this.txtCuentaCCI.Size = new System.Drawing.Size(210, 21);
            this.txtCuentaCCI.TabIndex = 236;
            this.txtCuentaCCI.Text = "0";
            this.txtCuentaCCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuentaCCI.TextoDefecto = "0";
            this.txtCuentaCCI.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtCuentaCCI.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.toolTip1.SetToolTip(this.txtCuentaCCI, "Tamaño 20 Digitos\r\npor defecto \"0\"");
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            this.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuenta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtCuenta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.ForeColor = System.Drawing.Color.Black;
            this.txtCuenta.Format = null;
            this.txtCuenta.Location = new System.Drawing.Point(3, 80);
            this.txtCuenta.MaxLength = 10;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.NextControlOnEnter = this.txtCuentaCCI;
            this.txtCuenta.Size = new System.Drawing.Size(210, 21);
            this.txtCuenta.TabIndex = 236;
            this.txtCuenta.Text = "0";
            this.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuenta.TextoDefecto = "0";
            this.txtCuenta.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtCuenta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // frmEmpleadoCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(458, 179);
            this.Controls.Add(this.pnlconten);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(474, 218);
            this.MinimumSize = new System.Drawing.Size(474, 218);
            this.Name = "frmEmpleadoCTS";
            this.Nombre = "  Empleado Pago CTS";
            this.Text = "  Empleado Pago CTS";
            this.Load += new System.EventHandler(this.frmEmpleadoCTS_Load);
            this.pnlconten.ResumeLayout(false);
            this.pnlconten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Panel pnlconten;
        private HpResergerUserControls.TextBoxPer txtCuentaCCI;
        private HpResergerUserControls.TextBoxPer txtCuenta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}