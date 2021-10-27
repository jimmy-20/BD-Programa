using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiSistema.Model;
using System.Data;

namespace MiSistema.Controller
{
    class CServicio
    {
        public static DataTable MostrarServicio()
        {
            return MServicio.MostrarServicio();
        }

    }
}
