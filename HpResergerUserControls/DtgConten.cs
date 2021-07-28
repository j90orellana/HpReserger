using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class Dtgconten : DataGridView
    {
        public string CheckColumna { get; set; }
        public int CheckValor { get; set; }
        public Dtgconten()
        {
            CheckValor = 1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            //AllowUserToAddRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            //GRILLAS ALTERNATIVAS
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(220, 230, 241);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
            AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            BackgroundColor = System.Drawing.Color.FromArgb(204, 218, 231);
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //COLUMNAS
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(78, 129, 189);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            //GRILLAS
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.NotSet;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DefaultCellStyle = dataGridViewCellStyle3;
            EnableHeadersVisualStyles = false;
            Location = new System.Drawing.Point(12, 84);
            Name = "dtgconten";
            GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            RowHeadersVisible = false;
            RowTemplate.Height = 18;
            Size = new System.Drawing.Size(400, 400);
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AllowUserToOrderColumns = false;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
        {
            base.OnEditingControlShowing(e);
            e.Control.KeyDown += Control_KeyDown; ;
        }
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if (CheckColumna != "" && CheckColumna != null)
            {
                if (e.RowIndex >= 0)
                {
                    if ((int)this[CheckColumna, e.RowIndex].Value == CheckValor)
                        HPResergerFunciones.Utilitarios.ColorFilaSeleccionada(this.Rows[e.RowIndex], Configuraciones.ColorFilaSeleccionada);
                    //else
                       // HPResergerFunciones.Utilitarios.ColorFilaDefecto(this.Rows[e.RowIndex]);
                }
            }
            base.OnCellFormatting(e);
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.CurrentCell != null)
            {
                if (this.CurrentCell.RowIndex >= 1)
                {
                    if (CurrentCell.IsInEditMode)

                        if (e.KeyCode == Keys.F6)
                        {
                            this[CurrentCell.ColumnIndex, CurrentCell.RowIndex].Value = this[CurrentCell.ColumnIndex, CurrentCell.RowIndex - 1].Value;
                            this.EndEdit();
                            this.RefreshEdit();
                        }
                }
            }
            //base.OnKeyDown(e);
        }
        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e)
        {
            if (CheckColumna != "" && CheckColumna != null)
                if (e.RowIndex == -1 && e.ColumnIndex == this.Columns[CheckColumna].Index)
                {
                    if (this.Rows.Count > 0)
                    {
                        int val = (int)this[CheckColumna, 0].Value;
                        foreach (DataGridViewRow item in this.Rows)
                        {
                            item.Cells[CheckColumna].Value = val == 1 ? 0 : 1;
                        }
                    }
                }
            base.OnCellDoubleClick(e);
        }
    }
}
