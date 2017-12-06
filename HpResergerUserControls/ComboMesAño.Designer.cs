namespace HpResergerUserControls
{
    partial class ComboMesAño
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.combomes = new System.Windows.Forms.ComboBox();
            this.comboaño = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combomes
            // 
            this.combomes.BackColor = System.Drawing.Color.White;
            this.combomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomes.FormattingEnabled = true;
            this.combomes.Location = new System.Drawing.Point(31, 3);
            this.combomes.Name = "combomes";
            this.combomes.Size = new System.Drawing.Size(79, 21);
            this.combomes.TabIndex = 0;
            // 
            // comboaño
            // 
            this.comboaño.BackColor = System.Drawing.Color.White;
            this.comboaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboaño.FormattingEnabled = true;
            this.comboaño.Location = new System.Drawing.Point(142, 3);
            this.comboaño.Name = "comboaño";
            this.comboaño.Size = new System.Drawing.Size(52, 21);
            this.comboaño.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(3, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Mes";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(116, 6);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(26, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Año";
            // 
            // ComboMesAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.comboaño);
            this.Controls.Add(this.combomes);
            this.Name = "ComboMesAño";
            this.Size = new System.Drawing.Size(205, 29);
            this.Load += new System.EventHandler(this.ComboMesAño_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combomes;
        private System.Windows.Forms.ComboBox comboaño;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}
