using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiSistema.Model
{
    class MUsuario
    {
        int idUsuario;
        string usuario;
        string contraseña;
        string rol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Rol { get => rol; set => rol = value; }

        public DataTable Validar_acceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;
        //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@usuario";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = usuario;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@contraseña";
                ParDato1.SqlDbType = SqlDbType.VarChar;
                ParDato1.Size = 100;
                ParDato1.Value = contraseña;
                SqlCmd.Parameters.Add(ParDato1);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable Mostrar_Usuario()
        {
            DataTable DtResultado = new DataTable("MostrarUsuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
               

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public string InsertarUsuario(MUsuario usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@usuario";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 50;
                ParPrimerNombre.Value = usuario.Usuario;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@contraseña";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 50;
                ParSegundoNombre.Value = usuario.Contraseña;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@rol";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 50;
                ParPrimerApellido.Value = usuario.Rol;
                SqlCmd.Parameters.Add(ParPrimerApellido);

            
                


             


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }





    }
}
