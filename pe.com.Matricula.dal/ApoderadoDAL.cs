using System;
using System.Data;
using System.Data.SqlClient;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.dal
{
    public class ApoderadoDAL
    {
        public int InsertarApoderado(ApoderadoBO apoderado, SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"INSERT INTO Apoderado (nombre, apellido, fechaNacimiento, dni, direccion, telefono, correoElectronico, estado) 
                             VALUES (@nombre, @apellido, @fechaNacimiento, @dni, @direccion, @telefono, @correoElectronico, @estado);
                             SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@nombre", apoderado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", apoderado.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", apoderado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", apoderado.Dni);
                cmd.Parameters.AddWithValue("@direccion", apoderado.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", apoderado.Telefono);
                cmd.Parameters.AddWithValue("@correoElectronico", apoderado.CorreoElectronico);
                cmd.Parameters.AddWithValue("@estado", apoderado.Estado);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        //objeto de la clase conexion
        private ConexionDAL objconexion = new ConexionDAL();
        //comando SqlCommand -> ejecutar sentencias SQL
        private SqlCommand cmd;
        //SqlDataReader -> para almacenar los resultados de una consulta
        private SqlDataReader dr;
        //una variable para almecenar el resultado de la ejecucion de consultas de actualizacion
        int res = 0;
        //funcion que muestra todos los roles
        public int MostrarCodigoApoderado()
        {
            int codigoApoderado = 0;
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_CodigoApoderado";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta escalar y asignamos al object resultado
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    codigoApoderado = (int)resultado;
                }
                //devolvemos la lista
                return codigoApoderado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool RegistrarApoderado(ApoderadoBO a)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarApoderado";
                cmd.Connection = objconexion.Conectar();

                // Pasamos los datos como parámetros
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50)).Value = a.Nombre;
                cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar, 50)).Value = a.Apellido;
                cmd.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.Date)).Value = a.FechaNacimiento;
                cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 100)).Value = a.Direccion ?? (object)DBNull.Value;
                cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.Bit)).Value = a.Estado;


                // Ejecutamos el procedimiento almacenado
                int res = cmd.ExecuteNonQuery();

                return res > 0; // Retorna true si la inserción fue exitosa
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar apoderado: " + ex.Message);
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

    }


}
