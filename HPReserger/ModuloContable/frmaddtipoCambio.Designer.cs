namespace HPReserger
{
    partial class frmaddtipoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddtipoCambio));
            this.comboMesAño1 = new HpResergerUserControls.ComboMesAño();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdia = new HpResergerUserControls.TextBoxPer();
            this.txtcompra = new HpResergerUserControls.TextBoxPer();
            this.txtventa = new HpResergerUserControls.TextBoxPer();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboMesAño1
            // 
            this.comboMesAño1.AutoSize = true;
            this.comboMesAño1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboMesAño1.BackColor = System.Drawing.Color.Transparent;
            this.comboMesAño1.FechaConDiaActual = new System.DateTime(2019, 7, 4, 0, 0, 0, 0);
            this.comboMesAño1.FechaFinMes = new System.DateTime(2019, 7, 31, 0, 0, 0, 0);
            this.comboMesAño1.FechaInicioMes = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            this.comboMesAño1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesAño1.Location = new System.Drawing.Point(12, 18);
            this.comboMesAño1.Name = "comboMesAño1";
            this.comboMesAño1.Size = new System.Drawing.Size(203, 24);
            this.comboMesAño1.TabIndex = 0;
            this.comboMesAño1.VerAño = true;
            this.comboMesAño1.VerMes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Día";
            // 
            // txtdia
            // 
            this.txtdia.BackColor = System.Drawing.Color.White;
            this.txtdia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdia.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdia.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdia.ForeColor = System.Drawing.Color.Black;
            this.txtdia.Format = null;
            this.txtdia.Location = new System.Drawing.Point(246, 20);
            this.txtdia.MaxLength = 100;
            this.txtdia.Name = "txtdia";
            this.txtdia.NextControlOnEnter = this.txtcompra;
            this.txtdia.Size = new System.Drawing.Size(59, 21);
            this.txtdia.TabIndex = 1;
            this.txtdia.Text = "0";
            this.txtdia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdia.TextoDefecto = "0";
            this.txtdia.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtdia.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtcompra
            // 
            this.txtcompra.BackColor = System.Drawing.Color.White;
            this.txtcompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompra.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcompra.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompra.ForeColor = System.Drawing.Color.Black;
            this.txtcompra.Format = null;
            this.txtcompra.Location = new System.Drawing.Point(356, 20);
            this.txtcompra.MaxLength = 100;
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.NextControlOnEnter = this.txtventa;
            this.txtcompra.Size = new System.Drawing.Size(59, 21);
            this.txtcompra.TabIndex = 2;
            this.txtcompra.Text = "0.00";
            this.txtcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcompra.TextoDefecto = "0.00";
            this.txtcompra.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtcompra.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtventa
            // 
            this.txtventa.BackColor = System.Drawing.Color.White;
            this.txtventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtventa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtventa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventa.ForeColor = System.Drawing.Color.Black;
            this.txtventa.Format = null;
            this.txtventa.Location = new System.Drawing.Point(460, 20);
            this.txtventa.MaxLength = 100;
            this.txtventa.Name = "txtventa";
            this.txtventa.NextControlOnEnter = this.btnaceptar;
            this.txtventa.Size = new System.Drawing.Size(59, 21);
            this.txtventa.TabIndex = 3;
            this.txtventa.Text = "0.00";
            this.txtventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtventa.TextoDefecto = "0.00";
            this.txtventa.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtventa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(179, 54);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(84, 23);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Venta";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(12, 42);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 44;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(268, 54);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 23);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmaddtipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 85);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtventa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMesAño1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 124);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 124);
            this.Name = "frmaddtipoCambio";
            this.Nombre = "Agregando Tipo de Cambio";
            this.Text = "Agregando Tipo de Cambio";
            this.Load += new System.EventHandler(this.frmaddtipoCambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ComboMesAño comboMesAño1;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtdia;
        private System.Windows.Forms.Button btnaceptar;
        private HpResergerUserControls.TextBoxPer txtcompra;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btncancelar;
    }
}