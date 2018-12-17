namespace HPReserger
{
    partial class FrmCambioContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioContra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtactual = new System.Windows.Forms.TextBox();
            this.txtnueva = new System.Windows.Forms.TextBox();
            this.txtnueva2 = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reingrese Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese Contraseña Nueva:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtactual
            // 
            this.txtactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactual.Location = new System.Drawing.Point(168, 10);
            this.txtactual.Name = "txtactual";
            this.txtactual.Size = new System.Drawing.Size(161, 21);
            this.txtactual.TabIndex = 3;
            this.txtactual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtactual.UseSystemPasswordChar = true;
            this.txtactual.TextChanged += new System.EventHandler(this.txtactual_TextChanged);
            this.txtactual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtactual_KeyDown);
            // 
            // txtnueva
            // 
            this.txtnueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnueva.Location = new System.Drawing.Point(168, 34);
            this.txtnueva.Name = "txtnueva";
            this.txtnueva.Size = new System.Drawing.Size(161, 21);
            this.txtnueva.TabIndex = 4;
            this.txtnueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnueva.UseSystemPasswordChar = true;
            this.txtnueva.TextChanged += new System.EventHandler(this.txtnueva_TextChanged);
            this.txtnueva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnueva_KeyDown);
            // 
            // txtnueva2
            // 
            this.txtnueva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnueva2.Location = new System.Drawing.Point(168, 58);
            this.txtnueva2.Name = "txtnueva2";
            this.txtnueva2.Size = new System.Drawing.Size(161, 21);
            this.txtnueva2.TabIndex = 5;
            this.txtnueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnueva2.UseSystemPasswordChar = true;
            this.txtnueva2.TextChanged += new System.EventHandler(this.txtnueva2_TextChanged);
            this.txtnueva2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnueva2_KeyDown);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(86, 86);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(171, 86);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FrmCambioContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 118);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtnueva2);
            this.Controls.Add(this.txtnueva);
            this.Controls.Add(this.txtactual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(354, 157);
            this.MinimumSize = new System.Drawing.Size(354, 157);
            this.Name = "FrmCambioContra";
            this.Nombre = "Cambio de Contraseña";
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.FrmCambioContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtactual;
        private System.Windows.Forms.TextBox txtnueva;
        private System.Windows.Forms.TextBox txtnueva2;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}