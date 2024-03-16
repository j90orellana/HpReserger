namespace HPReserger
{
    partial class frmCuadreAsientos
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
            this.buttonPer1 = new HpResergerUserControls.ButtonPer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPer2 = new HpResergerUserControls.ButtonPer();
            this.buttonPer3 = new HpResergerUserControls.ButtonPer();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPer1
            // 
            this.buttonPer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(188)))));
            this.buttonPer1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPer1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer1.ForeColor = System.Drawing.Color.White;
            this.buttonPer1.Location = new System.Drawing.Point(15, 46);
            this.buttonPer1.Name = "buttonPer1";
            this.buttonPer1.Size = new System.Drawing.Size(149, 54);
            this.buttonPer1.TabIndex = 0;
            this.buttonPer1.Text = "Cuadrar\r\nAjuste x Redondeo\r\n";
            this.buttonPer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer1.UseVisualStyleBackColor = false;
            this.buttonPer1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "El Asiento esta Descuadrado. Elija una Opción.";
            // 
            // buttonPer2
            // 
            this.buttonPer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(188)))));
            this.buttonPer2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPer2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer2.ForeColor = System.Drawing.Color.White;
            this.buttonPer2.Location = new System.Drawing.Point(172, 46);
            this.buttonPer2.Name = "buttonPer2";
            this.buttonPer2.Size = new System.Drawing.Size(149, 54);
            this.buttonPer2.TabIndex = 0;
            this.buttonPer2.Text = "Cuadrar\r\nAjuste de Tipo Cambio\r\n";
            this.buttonPer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer2.UseVisualStyleBackColor = false;
            this.buttonPer2.Click += new System.EventHandler(this.buttonPer2_Click);
            // 
            // buttonPer3
            // 
            this.buttonPer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.buttonPer3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPer3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer3.ForeColor = System.Drawing.Color.White;
            this.buttonPer3.Location = new System.Drawing.Point(329, 46);
            this.buttonPer3.Name = "buttonPer3";
            this.buttonPer3.Size = new System.Drawing.Size(149, 54);
            this.buttonPer3.TabIndex = 0;
            this.buttonPer3.Text = "Continuar\r\nRevisando Asiento";
            this.buttonPer3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer3.UseVisualStyleBackColor = false;
            this.buttonPer3.Click += new System.EventHandler(this.buttonPer3_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblmensaje.Location = new System.Drawing.Point(15, 30);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(53, 13);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "Mensaje:";
            // 
            // frmCuadreAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 106);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPer3);
            this.Controls.Add(this.buttonPer2);
            this.Controls.Add(this.buttonPer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 145);
            this.Name = "frmCuadreAsientos";
            this.Nombre = "Mensaje de Cuadre de Asientos";
            this.Text = "Mensaje de Cuadre de Asientos";
            this.Load += new System.EventHandler(this.frmCuadreAsientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.ButtonPer buttonPer1;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.ButtonPer buttonPer2;
        private HpResergerUserControls.ButtonPer buttonPer3;
        private System.Windows.Forms.Label lblmensaje;
    }
}