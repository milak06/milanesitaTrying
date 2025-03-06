// MatriculaDAL.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using pe.com.Matricula.bo;
namespace pe.com.Matricula.dal
{
    public class MatriculaDAL
    { // Declaración de objetos reutilizables
        private SqlCommand cmd;
        private SqlDataReader dr;
        private ConexionDAL objconexion = new ConexionDAL();

        // Método para insertar una matrícula
        public void InsertarMatricula(MatriculaBO matricula, SqlConnection connection, SqlTransaction transaction)
        {
            // Consulta para insertar la matrícula y obtener el ID generado
            string query = @"INSERT INTO Matricula (idEstudiante, idApoderado, fechaMatricula, tipoVacante, idNivel, idGrado, idEstadoMatricula, visible) 
                     VALUES (@idEstudiante, @idApoderado, @fechaMatricula, @tipoVacante, @idNivel, @idGrado, @idEstadoMatricula, @visible);
                     SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                // Asignar los parámetros relevantes para la tabla Matricula
                cmd.Parameters.AddWithValue("@idMatricula", matricula.IdMatricula);
                cmd.Parameters.AddWithValue("@IdEstudiante", matricula.NombreEstudiante);
                cmd.Parameters.AddWithValue("@idApoderado", matricula.NombreApoderado);
                cmd.Parameters.AddWithValue("@fechaMatricula", matricula.FechaMatricula);
                cmd.Parameters.AddWithValue("@tipoVacante", matricula.TipoVacante);
                cmd.Parameters.AddWithValue("@idNivel", matricula.NombreNivel);
                cmd.Parameters.AddWithValue("@idGrado", matricula.NombreGrado);
                cmd.Parameters.AddWithValue("@idEstadoMatricula", matricula.EstadoMatricula);
                cmd.Parameters.AddWithValue("@visible", matricula.Visible);

                // Ejecutar la consulta y obtener el ID generado
                int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                matricula.IdMatricula = idGenerado;
            }
        }



        // Método para buscar estudiante por DNI
        public EstudianteBO BuscarPorDNI(string dni)
        {
            EstudianteBO estudiante = null;
            string query = "SELECT * FROM Estudiante WHERE DNI = @dni";

            using (SqlConnection con = objconexion.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estudiante = new EstudianteBO
                        {
                            Dni = reader["DNI"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            IdGrado = Convert.ToInt32(reader["IdGrado"]),
                        };
                    }
                }
            }
            return estudiante;
        }

        // Método para mostrar las matrículas
        public List<MatriculaBO> MostrarMatriculas()

        {

            List<MatriculaBO> matriculas = new List<MatriculaBO>();

            try
            {
                // Instanciar el SqlCommand
                using (cmd = new SqlCommand())
                {
                    // Definir el tipo de consulta SQL como Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Definir el nombre del procedimiento almacenado
                    cmd.CommandText = "SP_MostrarMatriculas";
                    // Conectar a la base de datos
                    cmd.Connection = objconexion.Conectar();
                    // Ejecutar la consulta y guardar los resultados en el SqlDataReader
                    using (dr = cmd.ExecuteReader())
                    {
                        // Cargar los datos del SqlDataReader en la lista
                        while (dr.Read())
                        {
                            MatriculaBO obj = new MatriculaBO
                            {
                                IdMatricula = Convert.ToInt32(dr["idMatricula"].ToString()),
                                NombreEstudiante = dr["NombreEstudiante"].ToString(),  // Modificación aquí
                                ApellidoEstudiante = dr["ApellidoEstudiante"].ToString(),
                                NombreApoderado = dr["NombreApoderado"].ToString(),
                                FechaMatricula = Convert.ToDateTime(dr["fechaMatricula"]),
                                TipoVacante = dr["tipoVacante"].ToString(),
                                NombreNivel = dr["NombreNivel"].ToString(),
                                NombreGrado = dr["NombreGrado"].ToString(),
                                EstadoMatricula = dr["EstadoMatricula"].ToString(),
                                Visible = dr["Visible"].ToString()[0]
                            };

                            matriculas.Add(obj);
                        }

                    }
                }
                return matriculas;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                return null;
            }
            finally
            {
                // Cerrar la conexión
                objconexion.CerrarConexion();
            }
        }
    }
}
