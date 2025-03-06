using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace pe.com.Matricula.bo
    {
        public class MatriculaBO
    { // ID de la matrícula
        public int IdMatricula { get; set; }

        // Datos del Estudiante
        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }

        // Datos del Apoderado
        public int IdApoderado { get; set; }
        public string NombreApoderado { get; set; }

        // Información de la matrícula
        public DateTime FechaMatricula { get; set; }
        public string TipoVacante { get; set; }

        // Información del Nivel y Grado
        public int IdNivel { get; set; }
        public string NombreNivel { get; set; }
        
        public int IdGrado { get; set; }
        public string NombreGrado { get; set; }

        // Estado de la matrícula
        public int IdEstadoMatricula { get; set; }
        public string EstadoMatricula { get; set; }

        // Visibilidad de la matrícula
        public char Visible { get; set; }
    }

    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem() { }

        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}