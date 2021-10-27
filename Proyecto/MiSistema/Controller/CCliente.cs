using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiSistema.Model;

namespace MiSistema.Controller
{
    class CCliente
    {
        
       

        public static DataTable MostrarCliente()
        {
            return MCliente.MostrarCliente();
        }
        public static DataTable BuscarCliente(string dato)
        {
            return MCliente.BuscarCliente(dato);
        }
        public static DataTable CambioEstado(int idCliente)
        {
            return MCliente.CambioEstado(idCliente);
        }
        public static string Insertar(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            MCliente Obj = new MCliente();
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idCliente, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            MCliente Obj = new MCliente();
            Obj.Id_cliente = idCliente;
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Editar(Obj);
        }


    }
}
