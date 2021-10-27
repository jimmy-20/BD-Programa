using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiSistema.Model
{
    class MFactura
    {

        public DataTable MostrarFactura(int idFactura)
        {
            DataTable DtResultado = new DataTable("MostrarFactura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@IdFactura";
                ParDato.SqlDbType = SqlDbType.Int;
                ParDato.Value = idFactura;
                SqlCmd.Parameters.Add(ParDato);

              


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable InsertarFactura(int idCliente, int idUsuario)
        {
            DataTable DtResultado = new DataTable("InsertarFactura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@IdUsuario";
                ParDato.SqlDbType = SqlDbType.Int;
                //ParDato.Size = 60;
                ParDato.Value = idUsuario;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@IdCliente";
                ParDato1.SqlDbType = SqlDbType.Int;
                //ParDato.Size = 60;
                ParDato1.Value = idCliente;
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
        public void InsertarDetalleFactura(int idFactura, int idServicio, float precio, float cantidad)
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
                SqlCmd.CommandText = "Insertar_DetalleFactura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdFactura = new SqlParameter();
                ParIdFactura.ParameterName = "@IdFactura";
                ParIdFactura.SqlDbType = SqlDbType.Int;
                //ParPrimerNombre.Size = 60;
                ParIdFactura.Value = idFactura;
                SqlCmd.Parameters.Add(ParIdFactura);


                SqlParameter ParIdServicio= new SqlParameter();
                ParIdServicio.ParameterName = "@IdServicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                //ParPrimerNombre.Size = 60;
                ParIdServicio.Value = idServicio;
                SqlCmd.Parameters.Add(ParIdServicio);

                SqlParameter ParPrecio= new SqlParameter();
                ParPrecio.ParameterName = "@Precio";
                ParPrecio.SqlDbType = SqlDbType.Float;
                //ParPrimerNombre.Size = 60;
                ParPrecio.Value = precio;
                SqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Float;
                //ParPrimerNombre.Size = 60;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);




                //Ejecutamos nuestro comando

                SqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
                MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
         

        }
    }
}
