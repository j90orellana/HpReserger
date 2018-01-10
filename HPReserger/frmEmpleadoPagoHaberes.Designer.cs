namespace HPReserger
{
    partial class frmEmpleadoPagoHaberes
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pnlconten = new System.Windows.Forms.Panel();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtCuentaCCI = new System.Windows.Forms.TextBox();
            this.pnlconten.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(359, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número de Cuenta CCI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número de Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Banco";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(359, 50);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(278, 149);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 18;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(359, 149);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pnlconten
            // 
            this.pnlconten.Controls.Add(this.cboBanco);
            this.pnlconten.Controls.Add(this.cboMoneda);
            this.pnlconten.Controls.Add(this.txtCuenta);
            this.pnlconten.Controls.Add(this.txtCuentaCCI);
            this.pnlconten.Location = new System.Drawing.Point(134, 12);
            this.pnlconten.Name = "pnlconten";
            this.pnlconten.Size = new System.Drawing.Size(219, 131);
            this.pnlconten.TabIndex = 20;
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(3, 3);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(210, 21);
            this.cboBanco.TabIndex = 10;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(3, 38);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 11;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(3, 73);
            this.txtCuenta.MaxLength = 20;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(168, 20);
            this.txtCuenta.TabIndex = 12;
            this.txtCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuenta_KeyDown);
            this.txtCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta_KeyPress);
            // 
            // txtCuentaCCI
            // 
            this.txtCuentaCCI.Location = new System.Drawing.Point(3, 105);
            this.txtCuentaCCI.MaxLength = 20;
            this.txtCuentaCCI.Name = "txtCuentaCCI";
            this.txtCuentaCCI.Size = new System.Drawing.Size(210, 20);
            this.txtCuentaCCI.TabIndex = 13;
            this.txtCuentaCCI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuentaCCI_KeyDown);
            this.txtCuentaCCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaCCI_KeyPress);
            // 
            // frmEmpleadoPagoHaberes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 182);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlconten);
            this.MaximumSize = new System.Drawing.Size(464, 221);
            this.MinimumSize = new System.Drawing.Size(464, 221);
            this.Name = "frmEmpleadoPagoHaberes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Empleado Pago de Haberes";
            this.Load += new System.EventHandler(this.frmEmpleadoPagoHaberes_Load);
            this.pnlconten.ResumeLayout(false);
            this.pnlconten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel pnlconten;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtCuentaCCI;
    }
}