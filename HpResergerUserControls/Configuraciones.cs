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
        public static string MayusculaCadaPalabra(string cadena)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cadena.ToLower());
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
