using pe.com.Matricula.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace pe.com.Matricula.dal
{
    public class EstudianteDAL
    {
        private string connectionString = "Data Source=MILAGROS-LP\\MILAGROS;Initial Catalog=ProcesoMatricula;Integrated Security=True";

        public int InsertarEstudiante(EstudianteBO estudiante, SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"INSERT INTO Estudiante (Nombre, Apellido, FechaNacimiento, Dni, Direccion, Telefono, 
                             CorreoElectronico, FechaInscripcion, IdGrado, IdNivel, IdDistrito, IdSexo, Estado)
                             VALUES (@Nombre, @Apellido, @FechaNacimiento, @Dni, @Direccion, @Telefono, 
                             @CorreoElectronico, @FechaInscripcion, @IdGrado, @IdNivel, @IdDistrito, @IdSexo, @Estado);
                             SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Dni", estudiante.Dni);
                cmd.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                cmd.Parameters.AddWithValue("@CorreoElectronico", estudiante.CorreoElectronico);
                cmd.Parameters.AddWithValue("@FechaInscripcion", estudiante.FechaInscripcion);
                cmd.Parameters.AddWithValue("@IdGrado", estudiante.IdGrado);
                cmd.Parameters.AddWithValue("@IdNivel", estudiante.IdNivel);
                cmd.Parameters.AddWithValue("@IdDistrito", estudiante.IdDistrito);
                cmd.Parameters.AddWithValue("@IdSexo", estudiante.IdSexo);
                cmd.Parameters.AddWithValue("@Estado", estudiante.Estado);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public EstudianteBO BuscarPorDNI(string dni)
        {
            EstudianteBO estudiante = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Estudiante WHERE dni = @Dni";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Dni", dni);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estudiante = new EstudianteBO
                            {
                                IdEstudiante = Convert.ToInt32(reader["idEstudiante"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                                Dni = reader["dni"].ToString(),
                                Direccion = reader["direccion"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                CorreoElectronico = reader["correoElectronico"].ToString(),
                                FechaInscripcion = Convert.ToDateTime(reader["fechaInscripcion"]),
                                IdGrado = Convert.ToInt32(reader["idGrado"]),
                                IdNivel = Convert.ToInt32(reader["idNivel"]),
                                IdDistrito = Convert.ToInt32(reader["idDistrito"]),
                                IdSexo = Convert.ToInt32(reader["idSexo"]),
                                Estado = Convert.ToChar(reader["estado"])
                            };
                        }
                    }
                }
            }

            return estudiante;
        }


        //objeto de la clase conexion
        private ConexionDAL objconexion = new ConexionDAL();
        //comando SqlCommand -> ejecutar sentencias SQL
        private SqlCommand cmd;
        //SqlDataReader -> para almacenar los resultados de una consulta
        private SqlDataReader dr;
        //una variable para almecenar el resultado de la ejecucion de consultas de actualizacion
        int res = 0;
        //funcion que muestra todos los roles
        public List<EstudianteBO> MostrarEstudiantes()
        {
            //creamos una lista de tipo RolBO
            List<EstudianteBO> estudiantes = new List<EstudianteBO>();
            //manejo de excepciones
            try
            {
                //instanciar el SqlCommand
                cmd = new SqlCommand();
                //definir el tipo de consulta SQL que se va utilizar
                cmd.CommandType = CommandType.StoredProcedure;
                //definir el nombre del procedimiento almacenado
                cmd.CommandText = "SP_MostrarEstudiantes";
                //conectarse a la base de datos
                cmd.Connection = objconexion.Conectar();
                //ejecuto la consulta y los resultados los guardo en el SqlDataReader
                dr = cmd.ExecuteReader();
                //cargamos los datos que estan el SqlDataReader en la lista
                while (dr.Read())
                {
                    //crear un objeto de tipo rol
                    EstudianteBO obj = new EstudianteBO();
                    //asignamos los valores a los atributos del objeto
                    obj.IdEstudiante = Convert.ToInt32(dr["idEstudiante"].ToString());
                    obj.Nombre = dr["nombre"].ToString();
                    obj.Apellido = dr["apellido"].ToString();
                    obj.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]);
                    obj.Dni = dr["dni"].ToString();
                    obj.Direccion = dr["direccion"].ToString();
                    obj.Telefono = dr["telefono"].ToString();
                    obj.CorreoElectronico = dr["correoElectronico"].ToString();
                    obj.FechaInscripcion = Convert.ToDateTime(dr["fechaInscripcion"]);
                    obj.NombreGrado = dr["Grado"].ToString();
                    obj.NombreNivel = dr["Nivel"].ToString();
                    obj.NombreDistrito = dr["Distrito"].ToString();
                    obj.NombreDistrito = dr["Sexo"].ToString();

                    estudiantes.Add(obj);
                }
                return estudiantes;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                //cerramos la conexion
                objconexion.CerrarConexion();
            }
        }

        //funcion para mostrar todos los roles
        //public List<EstudianteBO> MostrarestudianteTodo()
        //{
        //    //creamos una lista de tipo RolBO
        //    List<EstudianteBO> estudiantes = new List<EstudianteBO>();
        //    //manejo de excepciones
        //    try
        //    {
        //        //instanciar el SqlCommand
        //        cmd = new SqlCommand();
        //        //definir el tipo de consulta SQL que se va utilizar
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //definir el nombre del procedimiento almacenado
        //        cmd.CommandText = "SP_MostrarRolTodo";
        //        //conectarse a la base de datos
        //        cmd.Connection = objconexion.Conectar();
        //        //ejecuto la consulta y los resultados los guardo en el SqlDataReader
        //        dr = cmd.ExecuteReader();
        //        //cargamos los datos que estan el SqlDataReader en la lista
        //        while (dr.Read())
        //        {
        //            //crear un objeto de tipo rol
        //            EstudianteBO obj = new EstudianteBO();
        //            //asignamos los valores a los atributos del objeto
        //            obj.codigo = Convert.ToInt32(dr["idEstudiante"].ToString());
        //            obj.nombre = dr["nombre"].ToString();
        //            obj.apellido = dr["apellido"].ToString();
        //            obj.fechaNacimiento = Convert.ToDateTime(dr["Fecha Nacimiento"]);
        //            obj.dni = dr["dni"].ToString();
        //            obj.direccion = dr["direccion"].ToString();
        //            obj.telefono = dr["telefono"].ToString();
        //            obj.correoElectronico = dr["Correo Electronico"].ToString();
        //            obj.fechaInscripcion = Convert.ToDateTime(dr["Fecha Inscripcion"]);
        //            obj.idGrado = Convert.ToInt32(dr["grado"].ToString());
        //            obj.idNivel = Convert.ToInt32(dr["Nivel"].ToString());
        //            obj.idDistrito = Convert.ToInt32(dr["Distrito"].ToString());
        //            obj.idSexo = Convert.ToInt32(dr["Sexo"].ToString());
        //            obj.estado = Convert.ToBoolean(dr["estado"].ToString());
        //            estudiantes.Add(obj);
        //        }
        //        return estudiantes;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        return null;
        //    }
        //    finally
        //    {
        //        //cerramos la conexion
        //        objconexion.CerrarConexion();
        //    }
        //}

        //funcion para mostrar todos los roles
        public List<EstudianteBO> BuscarEstudianteXCodigo(EstudianteBO r)
        {
            //creamos una lista de tipo RolBO
            List<EstudianteBO> estudiantes = new List<EstudianteBO>();
            //manejo de excepciones
            try
            {
                //instanciar el SqlCommand
                cmd = new SqlCommand();
                //definir el tipo de consulta SQL que se va utilizar
                cmd.CommandType = CommandType.StoredProcedure;
                //definir el nombre del procedimiento almacenado
                cmd.CommandText = "SP_BuscarEstudianteXCodigo";
                //conectarse a la base de datos
                cmd.Connection = objconexion.Conectar();
                //agregamos los procedimientos
                cmd.Parameters.AddWithValue("@codigo", r.Nombre);
                //ejecuto la consulta y los resultados los guardo en el SqlDataReader
                dr = cmd.ExecuteReader();
                //cargamos los datos que estan el SqlDataReader en la lista
                while (dr.Read())
                {
                    //crear un objeto de tipo rol
                    EstudianteBO obj = new EstudianteBO();
                    //asignamos los valores a los atributos del objeto
                    obj.IdEstudiante = Convert.ToInt32(dr["idEstudiante"].ToString());
                    obj.Nombre = dr["nombre"].ToString();
                    obj.Apellido = dr["apellido"].ToString();
                    obj.FechaNacimiento = Convert.ToDateTime(dr["Fecha Nacimiento"]);
                    obj.Dni = dr["dni"].ToString();
                    obj.Direccion = dr["direccion"].ToString();
                    obj.Telefono = dr["telefono"].ToString();
                    obj.CorreoElectronico = dr["correoElectronico"].ToString();
                    obj.FechaInscripcion = Convert.ToDateTime(dr["fechaInscripcion"]);
                    obj.IdGrado = Convert.ToInt32(dr["idGrado"].ToString());
                    obj.IdNivel = Convert.ToInt32(dr["idNivel"].ToString());
                    obj.IdDistrito = Convert.ToInt32(dr["idDistrito"].ToString());
                    obj.IdSexo = Convert.ToInt32(dr["idSexo"].ToString());
                    obj.Estado = Convert.ToChar(dr["estado"].ToString());
                    estudiantes.Add(obj);
                }
                return estudiantes;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                //cerramos la conexion
                objconexion.CerrarConexion();
            }
        }
        //funcion para mostrar el codigo del rol
        public int MostrarCodigoEstudiante()
        {
            //creamos una variable de tipo entero
            int codigoestudiante = 0;
            try
            {
                //instanciamos el SQLCommand
                cmd = new SqlCommand();
                //especificamos el tipo de SQLCommand
                cmd.CommandType = CommandType.StoredProcedure;
                //especificamos el nombre del procedimiento
                cmd.CommandText = "SP_CodigoEstudinte";
                //instanciamos la conexion
                cmd.Connection = objconexion.Conectar();
                //ejecutamos la consulta escalar y asignamos al object resultado
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    codigoestudiante = (int)resultado;
                }
                //devolvemos la lista
                return codigoestudiante;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        //creamos una funcion para registrar
        public bool RegistrarEstudiante(EstudianteBO r)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarEstudiante";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@apellido", r.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", r.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", r.Dni);
                cmd.Parameters.AddWithValue("@direccion", r.Direccion);
                cmd.Parameters.AddWithValue("@telefono", r.Telefono);
                cmd.Parameters.AddWithValue("@correoElectronico", r.CorreoElectronico);
                cmd.Parameters.AddWithValue("@fechaInscripcion", r.FechaInscripcion);
                cmd.Parameters.AddWithValue("@idGrado", r.IdGrado);
                cmd.Parameters.AddWithValue("@idDistrito", r.IdDistrito);
                cmd.Parameters.AddWithValue("@idNivel", r.IdNivel);
                cmd.Parameters.AddWithValue("@idSexo", r.IdSexo);
                cmd.Parameters.AddWithValue("@estado", r.Estado.ToString());


                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
        //creamos una funcion para actualizar
        public bool ActualizarEstudiante(EstudianteBO r)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarEstudiante";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@IdEstudiante", r.IdEstudiante);
                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@apellido", r.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimineto", r.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", r.Dni);
                cmd.Parameters.AddWithValue("@direccion", r.Direccion);
                cmd.Parameters.AddWithValue("@telefono", r.Telefono);
                cmd.Parameters.AddWithValue("@correo", r.CorreoElectronico);
                cmd.Parameters.AddWithValue("@fechaInscripcion", r.FechaInscripcion);
                cmd.Parameters.AddWithValue("@idGrado", r.IdGrado);
                cmd.Parameters.AddWithValue("@idDistrito", r.IdDistrito);
                cmd.Parameters.AddWithValue("@idSexo", r.IdSexo);
                cmd.Parameters.AddWithValue("@estado", r.Estado);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
        //creamos una funcion para actualizar
        public bool EliminarEstudiante(EstudianteBO r)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarEstudiante";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@IdEstudiante", r.IdEstudiante);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
        //creamos una funcion para habilitar
        public bool HabilitarEstudiante(EstudianteBO r)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarEstudiante";
                cmd.Connection = objconexion.Conectar();
                //pasamos los datos que registraremos por parametros
                cmd.Parameters.AddWithValue("@IdEstudiante", r.IdEstudiante);
                //ejecutamos el procedimiento almacenado
                res = cmd.ExecuteNonQuery();
                //evaluamos
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
    }


}