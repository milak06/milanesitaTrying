using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.dal
{
        public class ConexionDAL
        {
            private string cadena = "Server=MILAGROS-LP\\MILAGROS;Database=ProcesoMatricula;Trusted_Connection=True;";

        private SqlConnection xcon;

        public SqlConnection Conectar()
        {

            xcon = new SqlConnection(cadena);
            xcon.Open();
            return xcon;
        }
            public void CerrarConexion()
            {
                xcon.Close();
                xcon.Dispose();
            }
        }
 
}
