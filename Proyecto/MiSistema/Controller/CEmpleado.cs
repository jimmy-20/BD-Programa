using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiSistema.Model;
using System.Data;

namespace MiSistema.Controller
{
    class CEmpleado
    {
        public static DataTable MostrarEmpleado()
        {
            return MEmpleado.MostrarEmpleado();
        }
        public static DataTable BuscarEmpleado( string dato)
        {
            return MEmpleado.BuscarEmpleado(dato);
        }
        public static string EstadoEmpleado(int IdEmpleado)
        {
            return MEmpleado.EstadoEmpleado(IdEmpleado);
        }
    }
}
