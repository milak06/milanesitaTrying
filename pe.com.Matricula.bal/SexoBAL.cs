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
   public class SexoBAL
    {
        private SexoDAL _SexoDAL;

        public SexoBAL()
        {
            _SexoDAL = new SexoDAL();
        }

        public List<SexoBO> ObtenerSexos(SqlConnection connection, SqlTransaction transaction)
        {
            return _SexoDAL.ObtenerSexos(connection, transaction);
        }

    }
}
