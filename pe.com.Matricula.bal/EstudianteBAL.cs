using pe.com.Matricula.bo;
using pe.com.Matricula.dal;
using System.Collections.Generic;

namespace pe.com.Matricula.bal
{
    public class EstudianteBAL
    {
        private EstudianteDAL _estudianteDAL;
        public EstudianteBAL()
        {
            _estudianteDAL = new EstudianteDAL();
        }
        public EstudianteBO BuscarPorDNI(string dni)
        {
            return _estudianteDAL.BuscarPorDNI(dni);
        }
        EstudianteDAL dal = new EstudianteDAL();
        public List<EstudianteBO> MostrarEstudiantes()
        {
            return dal.MostrarEstudiantes();
        }

        //public List<EstudianteBO> MostrarEstudianteTodo()
        //{
        //    return dal.MostrarEstudianteTodo();
        //}

        public List<EstudianteBO> BuscarEstudianteXCodigo(EstudianteBO r)
        {
            return dal.BuscarEstudianteXCodigo(r);
        }

        public int MostrarCodigoEstudiante()
        {
            return dal.MostrarCodigoEstudiante();
        }

        public bool RegistrarEstudiante(EstudianteBO r)
        {
            return dal.RegistrarEstudiante(r );
        }

        public bool ActualizarEstudiante(EstudianteBO r)
        {
            return dal.ActualizarEstudiante(r);
        }

        public bool EliminarEstudiante(EstudianteBO r)
        {
            return dal.EliminarEstudiante(r);
        }

        public bool HabilitarEstudiante(EstudianteBO r)
        {
            return dal.HabilitarEstudiante(r);
        }

    }
}