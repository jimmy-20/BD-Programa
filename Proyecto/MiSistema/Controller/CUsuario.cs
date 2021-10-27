using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiSistema.Model;

namespace MiSistema.Controller
{
    class CUsuario
    {

        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return new MUsuario().Validar_acceso(usuario, contraseña);
        }
        public static DataTable Mostrar_Usuario()
        {
            return new MUsuario().Mostrar_Usuario();
        }
        public static string Insertar(string usuario, string contraseña, string rol)
        {
            MUsuario obj = new MUsuario();
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;
            obj.Rol = rol;
            return new MUsuario().InsertarUsuario(obj);
        }

    }
}
