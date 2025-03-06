using System;
using System.Collections.Generic;
using pe.com.Matricula.dal;
using pe.com.Matricula.bo;
using System.Data.SqlClient;



namespace pe.com.Matricula.bal
{
    public class GradoBAL
    {
        GradoDAL datos = new GradoDAL();

        public List<GradoBO> ObtenerGradosPorNivel(int idNivel)
        {
            return datos.ListarPorNivel(idNivel);
        }

        public List<GradoBO> ObtenerGrados()
        {
            GradoDAL datos = new GradoDAL();
            return datos.ObtenerGrados();
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

