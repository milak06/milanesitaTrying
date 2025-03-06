using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.bal
{
    public class UtilidadBAL
    {
       
        UtilidadBO utilidad = new UtilidadBO();
        public void MostrarMensaje(string m, string t, int tp, int i)
        {
            utilidad.MostrarMensaje(m, t, tp, i);
        }
    }
}
