namespace HPReserger
{
    partial class frmCargadeDatosExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargadeDatosExcel));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btncargar = new System.Windows.Forms.Button();
            this.btncargaexcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbohojas = new System.Windows.Forms.ComboBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtRuta = new HpResergerUserControls.TextBoxPer();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.Grid.Location = new System.Drawing.Point(12, 70);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.RowTemplate.Height = 16;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(775, 536);
            this.Grid.TabIndex = 139;
            this.Grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellEndEdit);
            this.Grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Grid_RowsAdded);
            this.Grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Grid_RowsRemoved);
            this.Grid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Grid_UserAddedRow);
            this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 140;
            this.label1.Text = "Ruta del Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 142;
            this.label2.Text = "Nombre de la Hoja";
            // 
            // btncargar
            // 
            this.btncargar.Image = ((System.Drawing.Image)(resources.GetObject("btncargar.Image")));
            this.btncargar.Location = new System.Drawing.Point(470, 11);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 144;
            this.btncargar.Text = "Archivo";
            this.btncargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btncargaexcel
            // 
            this.btncargaexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargaexcel.Image = ((System.Drawing.Image)(resources.GetObject("btncargaexcel.Image")));
            this.btncargaexcel.Location = new System.Drawing.Point(712, 41);
            this.btncargaexcel.Name = "btncargaexcel";
            this.btncargaexcel.Size = new System.Drawing.Size(75, 23);
            this.btncargaexcel.TabIndex = 145;
            this.btncargaexcel.Text = "Cargar";
            this.btncargaexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargaexcel.UseVisualStyleBackColor = true;
            this.btncargaexcel.Click += new System.EventHandler(this.btncargaexcel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(320, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 146;
            this.button1.Text = "Insertar a Base de Datos";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbohojas
            // 
            this.cbohojas.BackColor = System.Drawing.Color.White;
            this.cbohojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohojas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohojas.ForeColor = System.Drawing.Color.Black;
            this.cbohojas.FormattingEnabled = true;
            this.cbohojas.Location = new System.Drawing.Point(118, 39);
            this.cbohojas.Name = "cbohojas";
            this.cbohojas.Size = new System.Drawing.Size(346, 25);
            this.cbohojas.TabIndex = 147;
            this.cbohojas.SelectedIndexChanged += new System.EventHandler(this.cbohojas_SelectedIndexChanged);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(9, 617);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(77, 13);
            this.lblmensaje.TabIndex = 148;
            this.lblmensaje.Text = "Nro Registros";
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRuta.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRuta.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtRuta.ForeColor = System.Drawing.Color.White;
            this.txtRuta.Location = new System.Drawing.Point(118, 12);
            this.txtRuta.MaxLength = 100;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.NextControlOnEnter = null;
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(346, 23);
            this.txtRuta.TabIndex = 141;
            this.txtRuta.Text = "[Ruta Del Excel]";
            this.txtRuta.TextoDefecto = "[Ruta Del Excel]";
            this.txtRuta.TextoDefectoColor = System.Drawing.Color.White;
            this.txtRuta.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // frmCargadeDatosExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 643);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.cbohojas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncargaexcel);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(573, 630);
            this.Name = "frmCargadeDatosExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Carga";
            this.Load += new System.EventHandler(this.frmCargadeDatosExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btncargaexcel;
        public HpResergerUserControls.TextBoxPer txtRuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbohojas;
        private System.Windows.Forms.Label lblmensaje;
    }
}