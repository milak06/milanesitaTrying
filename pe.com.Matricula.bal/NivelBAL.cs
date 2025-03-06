using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.Matricula.dal;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.bal
{
    public class NivelBAL
    {
        NivelDAL datos = new NivelDAL();

        public List<NivelBO> ObtenerNiveles()
        {
            return datos.Listar();
        }
    }
}
