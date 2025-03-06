using pe.com.Matricula.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.dal
{
   public class EstadoMatDAL
    {
        private string connectionString = "Data Source=MILAGROS-LP\\MILAGROS;Initial Catalog=ProcesoMatricula;Integrated Security=True";
        public List<EstadoMatBO> ObtenerEstadosMatricula(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"SELECT idEstadoMatricula, descripcion, fechaEstado FROM EstadoMatricula";

            List<EstadoMatBO> listaEstados = new List<EstadoMatBO>();

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EstadoMatBO estado = new EstadoMatBO
                        {
                            idEstadoMatricula = Convert.ToInt32(reader["idEstadoMatricula"]),
                            descripcion = reader["descripcion"].ToString(),
                            fechaEstado = Convert.ToDateTime(reader["fechaEstado"])
                        };

                        listaEstados.Add(estado);
                    }
                }
            }

            return listaEstados;
        }

    }
}
