using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.Matricula.bo;
using pe.com.Matricula.dal;

namespace pe.com.Matricula.bal
{
    public class UsuarioBAL
    {
        UsuarioBO usuario = new UsuarioBO();
        public bool VerificarUsuario(UsuarioBO u)
        {
            return usuario.VerificarUsuario(u);
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

