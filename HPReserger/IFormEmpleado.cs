using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPReserger
{
    interface IFormEmpleado
    {
        void CargarNroHijos(int tipo,string cod);
        void CargarContratos();
    }
}
