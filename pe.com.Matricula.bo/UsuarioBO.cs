using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.Matricula.bo
{
    public class UsuarioBO
    {
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool VerificarUsuario(UsuarioBO u)
        {
            if (u.usuario == "Admin" && u.clave == "Admin12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
