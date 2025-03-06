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
   public class EstadoMatBAL
    {
        private EstadoMatDAL estadoMatriculaDAL = new EstadoMatDAL();

        public List<EstadoMatBO> ObtenerEstadosMatricula(SqlConnection connection, SqlTransaction transaction)
        {
            return estadoMatriculaDAL.ObtenerEstadosMatricula(connection, transaction);
        }
    }
}
