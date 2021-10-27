using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiSistema.Model;
namespace MiSistema.Controller

{
    class CFactura
    {
        public static DataTable InsertarFactura(int idCliente, int idUsuario)
        {
            return new MFactura().InsertarFactura(idCliente, idUsuario);
        }
        public static void InsertarDetalleFactura(int idFactura, int idServicio, float precio, float cantidad)
        {

            new MFactura().InsertarDetalleFactura(idFactura, idServicio, precio, cantidad);
        }
        public static DataTable MostrarFactura(int idFactura)
        {
            return new MFactura().MostrarFactura(idFactura);
        }
    }
}
