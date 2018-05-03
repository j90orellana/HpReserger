namespace HPReserger
{
    partial class frmprovisionarQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprovisionarQuestion));
            this.cboigv = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.numdetraccion = new System.Windows.Forms.NumericUpDown();
            this.lblporcentajedetraccion = new System.Windows.Forms.Label();
            this.cbodetraccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numdetraccion)).BeginInit();
            this.SuspendLayout();
            // 
            // cboigv
            // 
            this.cboigv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboigv.FormattingEnabled = true;
            this.cboigv.Items.AddRange(new object[] {
            "SI (IGV Incluido)",
            "SI (IGV No Incluido)"});
            this.cboigv.Location = new System.Drawing.Point(79, 16);
            this.cboigv.Name = "cboigv";
            this.cboigv.Size = new System.Drawing.Size(123, 21);
            this.cboigv.TabIndex = 15;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.Location = new System.Drawing.Point(63, 77);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 24);
            this.btnaceptar.TabIndex = 16;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(144, 77);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // numdetraccion
            // 
            this.numdetraccion.Location = new System.Drawing.Point(208, 42);
            this.numdetraccion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numdetraccion.Name = "numdetraccion";
            this.numdetraccion.Size = new System.Drawing.Size(38, 20);
            this.numdetraccion.TabIndex = 26;
            this.numdetraccion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblporcentajedetraccion
            // 
            this.lblporcentajedetraccion.AutoSize = true;
            this.lblporcentajedetraccion.Location = new System.Drawing.Point(248, 47);
            this.lblporcentajedetraccion.Name = "lblporcentajedetraccion";
            this.lblporcentajedetraccion.Size = new System.Drawing.Size(15, 13);
            this.lblporcentajedetraccion.TabIndex = 27;
            this.lblporcentajedetraccion.Text = "%";
            // 
            // cbodetraccion
            // 
            this.cbodetraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodetraccion.FormattingEnabled = true;
            this.cbodetraccion.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cbodetraccion.Location = new System.Drawing.Point(79, 43);
            this.cbodetraccion.Name = "cbodetraccion";
            this.cbodetraccion.Size = new System.Drawing.Size(123, 21);
            this.cbodetraccion.TabIndex = 25;
            this.cbodetraccion.SelectedIndexChanged += new System.EventHandler(this.cbodetraccion_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Detracción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Grava IGV:";
            // 
            // frmprovisionarQuestion
            // 
            this.AcceptButton = this.btnaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(273, 111);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numdetraccion);
            this.Controls.Add(this.lblporcentajedetraccion);
            this.Controls.Add(this.cbodetraccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cboigv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 150);
            this.Name = "frmprovisionarQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HpReserger";
            ((System.ComponentModel.ISupportInitialize)(this.numdetraccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.ComboBox cboigv;
        private System.Windows.Forms.Label lblporcentajedetraccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numdetraccion;
        public System.Windows.Forms.ComboBox cbodetraccion;
    }
}