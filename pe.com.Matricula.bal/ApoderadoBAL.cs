using pe.com.Matricula.bo;
using pe.com.Matricula.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.bal
{
    public class ApoderadoBAL
    {
        public int MostrarCodigoApoderado()
        {
            return MostrarCodigoApoderado();
        }
        private ApoderadoDAL apoderadoDAL = new ApoderadoDAL();

        public bool RegistrarApoderado(ApoderadoBO a)
        {
            return apoderadoDAL.RegistrarApoderado(a);
        }
    }
}
