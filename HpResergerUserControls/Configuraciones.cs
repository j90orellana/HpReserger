using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public class Configuraciones
    {
        public static Color ColordeEnabledReadOnly = Color.FromArgb(204, 218, 231);
        /// <param name="cadena">Palabra a la que vamos hacer Tipo Oración</param>
        public static string MayusculaCadaPalabra(string cadena)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cadena.ToLower());
        }
        /// <param name="Datagrid">Grilla con la que vamos a trabajar</param>
        /// <param name="ColumnaImporte">Columna a la que vamos a Asignar Valores</param>
        /// <param name="MontoaRepartir">Monto que vamos a Dividir</param>    
        public static void RellenarGrillasAutomatico(Dtgconten Datagrid, DataGridViewTextBoxColumn ColumnaImporte, decimal MontoaRepartir)
        {
            Datagrid.EndEdit();
            decimal Valor = 0;
            int contador = 0;
            foreach (DataGridViewRow item in Datagrid.Rows)
            {
                if (item.Index != Datagrid.CurrentCell.RowIndex)
                {
                    if (item.Cells[ColumnaImporte.Name].Value != null)
                    {
                        if (Decimal(item.Cells[ColumnaImporte.Name].Value.ToString()) > 0)
                            Valor += Decimal(item.Cells[ColumnaImporte.Name].Value.ToString());
                        else contador++;
                    }
                    else contador++;
                }
            }
            if (contador > 0)
            {
                Valor = (MontoaRepartir - Valor) / contador;
                foreach (DataGridViewRow item in Datagrid.Rows)
                {
                    if (item.Cells[ColumnaImporte.Name].Value != null)
                        if (Decimal(item.Cells[ColumnaImporte.Name].Value.ToString()) == 0)
                            item.Cells[ColumnaImporte.Name].Value = Valor;
                    if (item.Index == Datagrid.CurrentCell.RowIndex)
                        item.Cells[ColumnaImporte.Name].Value = Valor;
                }
                Datagrid.RefreshEdit();
                Datagrid.EndEdit();
            }
        }
        /// <param name="Datagrid">Grilla con la que vamos a trabajar</param>
        /// <param name="ColumnaOrigen">Columna con la que vamos a sacar datos</param>
        /// <param name="ColumnaDestino">Columna a la que vamos asignar valores</param>
        public static void RellenarGrillasAutomatico(Dtgconten Datagrid, DataGridViewTextBoxColumn ColumnaOrigen, DataGridViewTextBoxColumn ColumnaDestino)
        {
            Datagrid.EndEdit();
            decimal ValorOrigen = 0, ValorDestino = 0;
            int contador = 1;
            foreach (DataGridViewRow item in Datagrid.Rows)
            {
                if (item.Index != Datagrid.CurrentCell.RowIndex)
                {
                    if (item.Cells[ColumnaDestino.Name].Value != null)
                    {
                        if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) > 0)
                            ValorDestino += Decimal(item.Cells[ColumnaDestino.Name].Value.ToString());
                    }
                    if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) == 0 && Decimal(item.Cells[ColumnaOrigen.Name].Value.ToString()) == 0)
                        contador++;
                }
                ValorOrigen += Decimal(item.Cells[ColumnaOrigen.Name].Value.ToString());
            }
            if (Decimal(Datagrid[ColumnaOrigen.Name, Datagrid.CurrentCell.RowIndex].Value.ToString()) > 0) contador--;
            if (contador > 0)
            {
                ValorOrigen = (ValorOrigen - ValorDestino) / contador;
                if (ValorOrigen > 0)
                {
                    foreach (DataGridViewRow item in Datagrid.Rows)
                    {
                        if ((decimal)item.Cells[ColumnaOrigen.Name].Value == 0)
                        {
                            if (item.Cells[ColumnaDestino.Name].Value != null)
                                if (Decimal(item.Cells[ColumnaDestino.Name].Value.ToString()) == 0)
                                    item.Cells[ColumnaDestino.Name].Value = ValorOrigen;
                            if (item.Index == Datagrid.CurrentCell.RowIndex)
                                item.Cells[ColumnaDestino.Name].Value = ValorOrigen;
                        }
                    }
                }
                Datagrid.RefreshEdit();
                Datagrid.EndEdit();
            }
        }
        /// <param name="datetime">Fecha que vamos a convertir a FechaSQL</param>
        public static String ToFechaSql(DateTime datetime)
        {
            string cadena = "";
            cadena = $"{datetime.Year}-{datetime.Month}-{datetime.Day}";
            return cadena;
        }
        public static decimal Decimal(string cadena)
        {
            try
            {
                if (cadena == "" || cadena == ".") cadena = "0";
                return decimal.Parse(cadena);
            }
            catch (Exception e) { return 0; }
        }
        /// <param name="cadena">cadena a convertirse en formato n2</param>
        /// <returns>Regreso un decimal en formato N2</returns>
        public static string ReturnDecimal(string cadena)
        {
            return decimal.Parse(cadena).ToString("n2");
        }
        public static void Activar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = false;
                    //((TextBox)x).BackColor = Color.White;
                }
                else
                    ((Control)x).Enabled = true;
            }
        }
        public static void Desactivar(params object[] control)
        {
            foreach (object x in control)
            {
                if (((Control)x).AccessibilityObject.Role == AccessibleRole.Text)
                {
                    ((TextBox)x).ReadOnly = true;
                    // ((TextBox)x).BackColor = Color.FromArgb(204, 218, 231);
                }
                else
                    ((Control)x).Enabled = false;
            }
        }
    }

}
