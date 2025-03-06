using pe.com.Matricula.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.dal
{
   public class SexoDAL
    {
        private string connectionString = "Data Source=MILAGROS-LP\\MILAGROS;Initial Catalog=ProcesoMatricula;Integrated Security=True";
        public List<SexoBO> ObtenerSexos(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"SELECT idSexo, nombre, estado FROM Sexo";

            List<SexoBO> listaSexos = new List<SexoBO>();

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SexoBO sexo = new SexoBO
                        {
                            idSexo = Convert.ToInt32(reader["idSexo"]),
                            nombre = reader["nombre"].ToString(),
                            estado = Convert.ToChar(reader["estado"])
                        };

                        listaSexos.Add(sexo);
                    }
                }
            }

            return listaSexos;
        }

    }
}
