using pe.com.Matricula.bo;
using pe.com.Matricula.dal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.bal
{
    public class DistritoBAL
    {
        private DistritoDAL distritoDAL;

        public DistritoBAL()
        {
            distritoDAL = new DistritoDAL();
        }

        public List<DistritoBO> ObtenerDistritos(SqlConnection connection, SqlTransaction transaction)
        {
            return distritoDAL.ObtenerDistritos(connection, transaction);
        }
    }

}
