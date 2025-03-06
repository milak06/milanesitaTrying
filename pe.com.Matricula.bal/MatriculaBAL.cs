// MatriculaBAL.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using pe.com.Matricula.bo;
using pe.com.Matricula.dal;


namespace pe.com.Matricula.bal
{
    public class MatriculaBAL
    {
        private readonly string _connectionString;
        private readonly EstudianteDAL _estudianteDAL;
        private readonly ApoderadoDAL _apoderadoDAL;
        private readonly MatriculaDAL _matriculaDAL;

        public MatriculaBAL()
        {
            _connectionString = "Server=MILAGROS-LP\\MILAGROS;Database=ProcesoMatricula;Trusted_Connection=True;";
            _estudianteDAL = new EstudianteDAL();
            _apoderadoDAL = new ApoderadoDAL();
            _matriculaDAL = new MatriculaDAL();
        }
        private readonly MatriculaDAL dal = new MatriculaDAL();

        public List<MatriculaBO> SP_MostrarMatriculas()
        {
            // Llamamos al método de la capa DAL
            return dal.MostrarMatriculas();
        }
        // BAL - Registrar Matricula
        public void RegistrarMatricula(EstudianteBO estudiante, ApoderadoBO apoderado)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar Apoderado y obtener el ID generado
                        int idApoderado = _apoderadoDAL.InsertarApoderado(apoderado, connection, transaction);

                        // Insertar Estudiante y obtener el ID generado
                        int idEstudiante = _estudianteDAL.InsertarEstudiante(estudiante, connection, transaction);

                        // Crear el objeto de Matricula
                        MatriculaBO matricula = new MatriculaBO
                        {
                            IdEstudiante = idEstudiante,
                            IdApoderado = idApoderado,
                            FechaMatricula = DateTime.Now,
                            TipoVacante = "Regular",
                            IdNivel = estudiante.IdNivel,
                            IdGrado = estudiante.IdGrado,
                            IdEstadoMatricula = 1, // Ej: 1 para Activo
                            Visible = 'S'          // Corregido: Ahora es un char
                        };

                        // Insertar la matrícula
                        _matriculaDAL.InsertarMatricula(matricula, connection, transaction);

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (SqlException ex)
                    {
                        // Si ocurre un error relacionado con SQL, se revierte la transacción
                        transaction.Rollback();
                        Console.WriteLine("Error de SQL: " + ex.Message);
                        throw new Exception("Error al registrar la matrícula en la base de datos.", ex);
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre otro tipo de error, también se revierte la transacción
                        transaction.Rollback();
                        Console.WriteLine("Error general: " + ex.Message);
                        throw new Exception("Ocurrió un error al registrar la matrícula.", ex);
                    }
                }
            }
        }




        public class ApoderadoBAL
        {
            private readonly ApoderadoDAL _apoderadoDAL;

            public ApoderadoBAL()
            {
                _apoderadoDAL = new ApoderadoDAL();
            }
        }
    }
}