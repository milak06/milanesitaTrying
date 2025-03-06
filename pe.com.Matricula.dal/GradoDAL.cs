using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.dal
{
    public class GradoDAL
    {
        private string cadena = "Server=MILAGROS-LP\\MILAGROS;Database=ProcesoMatricula;Trusted_Connection=True;";

        public List<GradoBO> ListarPorNivel(int idNivel)
        {
            List<GradoBO> lista = new List<GradoBO>();

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idGrado, nombre FROM Grado WHERE idNivel = @idNivel", con);
                cmd.Parameters.AddWithValue("@idNivel", idNivel);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new GradoBO()
                    {
                        IdGrado = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        IdNivel = idNivel
                    });
                }
            }
            return lista;
        }


        // Método para obtener los grados por nivel
        public List<GradoBO> ObtenerGrados()
        {
            List<GradoBO> listaGrados = new List<GradoBO>();

            // Se establece la conexión usando el connectionString definido arriba
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();

                // Consulta para obtener todos los grados SIN FILTRAR POR NIVEL
                string query = @"SELECT idGrado, nombre FROM Grado";

                // Se utiliza SqlCommand para ejecutar la consulta
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Se ejecuta la consulta y se obtiene el SqlDataReader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Se recorren los resultados
                        while (reader.Read())
                        {
                            // Se crea un objeto GradoBO y se asignan sus propiedades
                            GradoBO grado = new GradoBO
                            {
                                IdGrado = Convert.ToInt32(reader["idGrado"]),
                                Nombre = reader["nombre"].ToString()
                            };

                            // Se agrega el objeto a la lista
                            listaGrados.Add(grado);
                        }
                    }
                }
            }

            // Se retorna la lista con los datos obtenidos
            return listaGrados;
        }

        public int ObtenerVacantesDisponibles(int idGrado)
        {
            int vacantes = 0;
            string query = "SELECT cantidad FROM Vacante WHERE idGrado = @idGrado";

            ConexionDAL conexion = new ConexionDAL();
            using (SqlConnection con = conexion.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idGrado", idGrado);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    vacantes = Convert.ToInt32(result);
                }
            }

            conexion.CerrarConexion();
            return vacantes;
        }
    }
}
