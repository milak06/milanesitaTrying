using pe.com.Matricula.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.dal
{
   public class DistritoDAL
    {
        private string connectionString = "Data Source=MILAGROS-LP\\MILAGROS;Initial Catalog=ProcesoMatricula;Integrated Security=True";
        public List<DistritoBO> ObtenerDistritos(SqlConnection connection, SqlTransaction transaction)
        {
            // Consulta para obtener los datos de la tabla Distrito
            string query = @"SELECT idDistrito, nombre, provincia, departamento FROM Distrito";
            // Lista para almacenar los resultados
            List<DistritoBO> listaDistritos = new List<DistritoBO>();
            // Usamos SqlCommand para ejecutar la consulta
            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Recorremos cada fila de los resultados
                    while (reader.Read())
                    {
                        // Creamos un objeto DistritoBO y asignamos sus propiedades
                        DistritoBO distrito = new DistritoBO
                        {
                            idDistrito = Convert.ToInt32(reader["idDistrito"]),
                            nombre = reader["nombre"].ToString(),
                            provincia = reader["provincia"].ToString(),
                            departamento = reader["departamento"].ToString()
                        };

                        // Agregamos el objeto a la lista
                        listaDistritos.Add(distrito);
                    }
                }
            }
            // Retornamos la lista con los datos
            return listaDistritos;
        }
    }
}
