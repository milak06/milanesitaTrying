using System;
using System.Data.SqlClient;

namespace pe.com.Matricula.bo
{
    public class EstudianteBO
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int IdGrado { get; set; }
        public int IdNivel { get; set; }
        public int IdDistrito { get; set; }
        public int IdSexo { get; set; }
        public char Estado { get; set; }
        public string NombreDistrito { get; set; }
        public string NombreGrado { get; set; }
        public string NombreSexo { get; set; }
        public string NombreNivel { get; set; }
    }
}
