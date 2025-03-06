using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.dal
{
    public class NivelDAL
    {
        private string cadena = "Server=MILAGROS-LP\\MILAGROS;Database=ProcesoMatricula;Trusted_Connection=True;";


        public List<NivelBO> Listar()
        {
            List<NivelBO> lista = new List<NivelBO>();

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idNivel, nombre FROM Nivel", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new NivelBO()
                    {
                        IdNivel = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    });
                }
            }
            return lista;
        }
    }
}

