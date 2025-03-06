using pe.com.Matricula.bal;
using pe.com.Matricula.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pe.com.Matriculaa.ui
{
    public partial class frmConsultaMatricula : System.Web.UI.Page
    {
        private List<EstudianteBO> Estudiante = new List<EstudianteBO>();
        private List<MatriculaBO> Matricula = new List<MatriculaBO>();
        private List<ApoderadoBO> Apoderado = new List<ApoderadoBO>();
        private MatriculaBAL balMa = new MatriculaBAL();
        private ApoderadoBAL balAp = new ApoderadoBAL();
        private MatriculaBAL balMat = new MatriculaBAL();
        private EstudianteBAL bal = new EstudianteBAL();
        private SexoBAL balsexo = new SexoBAL();
        private DistritoBAL balDis = new DistritoBAL();
        private NivelBAL balNivel = new NivelBAL();
        private GradoBAL balGrado = new GradoBAL();
        private EstadoMatBAL balEstMAT = new EstadoMatBAL();



        private EstudianteBO obj = new EstudianteBO();
        private EstadoMatBO objestmat = new EstadoMatBO();
        private SexoBO objsexo = new SexoBO();
        private DistritoBO objDis = new DistritoBO();
        private NivelBO objNivel = new NivelBO();
        private GradoBO objGrado = new GradoBO();
        private ApoderadoBO objA = new ApoderadoBO();
        private MatriculaBO objMa = new MatriculaBO();

        //Variables 
        //Estudiante
        private int IdEstudiante = 0;
        private int idsexo = 0;
        private int iddistrito = 0;
        private int idnivel = 0;
        private int idgrado = 0;
        private int indice = -1;
        private string nom = "";
        private string ape = "";
        private string dni = "";
        private string direccion = "";
        private string telefono = "";
        private string correo = "";
        private DateTime fechanac;
        private DateTime fechains;
        //private DateTime FechaNac = DateTime.MinValue;
        //private DateTime fechaIns = DateTime.MinValue;
        private char est = 'F';
        private bool res = false;
        //Apoderado
        private int idapo = 0;
        private string nomA = "";
        private string apeA = "";
        private DateTime fechanacA;
        private string dniA = "";
        private string fonoA = "";
        private string corrA = "";
        private char estA = 'F';
        //Matricula
        private int idEstmat = 0;
        private char visible = 'S';
        private string vacante = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bloquear();
                CargarMatricula();
                SoloLectura();
                CargarCombos();
                
            }
        }
        private void Bloquear()
        {
            //Estudiante
            txtCodE.Enabled = false;
            txtName.Enabled = false;
            txtLName.Enabled = false;
            txtDNI.Enabled = false;
            txtDireccion.Enabled = false;
            txtFono.Enabled = false;
            txtCorreo.Enabled = false;
            cFechaNac.Enabled = false;
            cFechaIns.Enabled = false;
            ddlSexo.Enabled = false;
            ddlDistritos.Enabled = false;
            ddlGrado.Enabled = false;
            ddlNivel.Enabled = false;
            chkEst.Enabled = false;
            //Apoderado
            txtCodA.Enabled = false;
            txtCorreoA.Enabled = false;
            txtDireA.Enabled = false;
            txtDniA.Enabled = false;
            txtFonoA.Enabled = false;
            txtNamEA.Enabled = false;
            txtNameLA.Enabled = false;
            CfechaNacA.Enabled = false;
            chkEstA.Enabled = false;
            //Matricula
            ddlestMat.Enabled = false;
            chkEstMat.Enabled = false;
            //Botones
            BtnOt.Enabled = false;
            BtnSer.Enabled = false;
            BtnUp.Enabled = false;
            BtnDel.Enabled = false;
        }

        private void Desbloquear()
        {
            txtCodE.Enabled = true;
            txtName.Enabled = true;
            txtLName.Enabled = true;
            txtDNI.Enabled = true;
            txtDireccion.Enabled = true;
            txtFono.Enabled = true;
            txtCorreo.Enabled = true;
            cFechaNac.Enabled = true;
            cFechaIns.Enabled = true;
            ddlSexo.Enabled = true;
            ddlDistritos.Enabled = true;
            ddlGrado.Enabled = true;
            ddlNivel.Enabled = true;
            chkEst.Enabled = true;
            //Apoderado
            txtCodA.Enabled = true;
            txtCorreoA.Enabled = true;
            txtDireA.Enabled = true;
            txtDniA.Enabled = true;
            txtFonoA.Enabled = true;
            txtNamEA.Enabled = true;
            txtNameLA.Enabled = true;
            CfechaNacA.Enabled = true;
            chkEstA.Enabled = true;
            //Matricula
            ddlestMat.Enabled = true;
            chkEstMat.Enabled = true;
            //Botones
            BtnOt.Enabled = true;
            BtnSer.Enabled = true;
            BtnUp.Enabled = true;
            BtnDel.Enabled = true;

        }

        private void CargarMatricula()
        {
            List<MatriculaBO> Matriculas = balMat.SP_MostrarMatriculas();

            if (Matriculas == null || Matriculas.Count == 0)
            {
                Console.WriteLine("No hay matrículas disponibles.");
                return;
            }

            // Imprimir datos en la consola
            foreach (var mat in Matriculas)
            {
                Console.WriteLine($"Estudiante: {mat.NombreEstudiante} {mat.ApellidoEstudiante} - Apoderado: {mat.NombreApoderado}");
            }

            // Asignar la lista al DataGridView (WinForms)
            dgvStu.DataSource = Matriculas;
            dgvStu.DataBind();
        }
        private void Limpiar()
        {
            // estudainte
            txtCodE.Text = "";
            txtName.Text = "";
            txtLName.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtFono.Text = "";
            ddlDistritos.SelectedIndex = 0;
            ddlGrado.SelectedIndex = 0;
            ddlNivel.SelectedIndex = 0;
            ddlSexo.SelectedIndex = 0;
            cFechaIns.SelectedDates.Clear();
            cFechaNac.SelectedDates.Clear();
            chkEst.Checked = false;
            //apodrado
            txtCodA.Text = "";
            txtCorreoA.Text = "";
            txtDireA.Text = "";
            txtDniA.Text = "";
            txtFonoA.Text = "";
            txtNamEA.Text = "";
            txtNameLA.Text = "";
            CfechaNacA.SelectedDates.Clear();
            chkEstA.Checked = false;
            //Matricula
            txtIdMat.Text = "";
            ddlestMat.SelectedIndex = 0;
            chkEstMat.Checked = false;
            txtName.Focus();
        }

        private void CargarCombos()
        {
            string connectionString = "Data Source=MILAGROS-LP\\MILAGROS;Initial Catalog=ProcesoMatricula;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // CARGAR SEXOS
                    List<SexoBO> sexos = balsexo.ObtenerSexos(connection, transaction);
                    SexoBO opcionSexoPorDefecto = new SexoBO
                    {
                        idSexo = 0,
                        nombre = "Seleccione un sexo",
                        estado = 'f'
                    };
                    sexos.Insert(0, opcionSexoPorDefecto);
                    ddlSexo.DataSource = sexos;
                    ddlSexo.DataTextField = "nombre";
                    ddlSexo.DataValueField = "idSexo";
                    ddlSexo.DataBind();

                    // CARGAR DISTRITOS
                    List<DistritoBO> distritos = balDis.ObtenerDistritos(connection, transaction);
                    DistritoBO opcionDistritoPorDefecto = new DistritoBO
                    {
                        idDistrito = 0,
                        nombre = "Seleccione un distrito"
                    };
                    distritos.Insert(0, opcionDistritoPorDefecto);
                    ddlDistritos.DataSource = distritos;
                    ddlDistritos.DataTextField = "nombre";
                    ddlDistritos.DataValueField = "idDistrito";
                    ddlDistritos.DataBind();

                    // CARGAR NIVELES
                    List<NivelBO> niveles = balNivel.ObtenerNiveles();
                    NivelBO opcionNivelPorDefecto = new NivelBO
                    {
                        IdNivel = 0,
                        Nombre = "Seleccione un nivel"
                    };
                    niveles.Insert(0, opcionNivelPorDefecto);
                    ddlNivel.DataSource = niveles;
                    ddlNivel.DataTextField = "Nombre";
                    ddlNivel.DataValueField = "IdNivel";
                    ddlNivel.DataBind();

                    // CARGAR GRADOS
                    List<GradoBO> grados = balGrado.ObtenerGrados();
                    GradoBO opcionGradoPorDefecto = new GradoBO
                    {
                        IdGrado = 0,
                        Nombre = "Seleccione un grado"
                    };
                    grados.Insert(0, opcionGradoPorDefecto);
                    ddlGrado.DataSource = grados;
                    ddlGrado.DataTextField = "Nombre";
                    ddlGrado.DataValueField = "IdGrado";
                    ddlGrado.DataBind();

                    // CARGAR ESTADOS DE MATRÍCULA
                    List<EstadoMatBO> estadosMatricula =  balEstMAT.ObtenerEstadosMatricula(connection, transaction);
                    EstadoMatBO opcionEstadoPorDefecto = new EstadoMatBO
                    {
                        idEstadoMatricula = 0,
                        descripcion = "Seleccione un estado"
                    };
                    estadosMatricula.Insert(0, opcionEstadoPorDefecto);
                    ddlestMat.DataSource = estadosMatricula;
                    ddlestMat.DataTextField = "descripcion";
                    ddlestMat.DataValueField = "idEstadoMatricula";
                    ddlestMat.DataBind();

                    // Confirmar la transacción si todo está correcto
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
        }

        private void SoloLectura()
        {
            txtCodE.ReadOnly = true;
            txtCodA.ReadOnly = true;
            txtIdMat.ReadOnly = true;
        }

        protected void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Desbloquear();
                BtnNew.Enabled = false;
                txtCodE.Text = bal.MostrarCodigoEstudiante().ToString();
                //txtCodA.Text = balAp.MostrarCodigoApoderado().ToString();
                Limpiar();
            }
            catch (Exception ex)
            {
                // Log del error y mostrar mensaje en la página
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }


        protected void BtnOt_Click(object sender, EventArgs e)
        {
            // Validaciones estudiante
            if (txtName.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtName.Focus();
                return;
            }
            if (txtLName.Text == "")
            {
                Response.Write("<script>alert('Ingrese apellidos.');</script>");
                txtLName.Focus();
                return;
            }
            if (txtFono.Text == "")
            {
                Response.Write("<script>alert('Ingrese un número de celular.');</script>");
                txtFono.Focus();
                return;
            }
            if (txtDNI.Text == "")
            {
                Response.Write("<script>alert('Ingrese un número de DNI.');</script>");
                txtDNI.Focus();
                return;
            }
            if (txtDireccion.Text == "")
            {
                Response.Write("<script>alert('Ingrese una dirección.');</script>");
                txtDireccion.Focus();
                return;
            }
            if (txtCorreo.Text == "")
            {
                Response.Write("<script>alert('Ingrese un correo.');</script>");
                txtCorreo.Focus();
                return;
            }
            if (ddlDistritos.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Seleccione un distrito.');</script>");
                ddlDistritos.Focus();
                return;
            }
            if (ddlGrado.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Seleccione un grado.');</script>");
                ddlGrado.Focus();
                return;
            }
            if (ddlNivel.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Seleccione un nivel.');</script>");
                ddlNivel.Focus();
                return;
            }
            if (ddlSexo.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Seleccione un sexo.');</script>");
                ddlSexo.Focus();
                return;
            }
            if (cFechaNac.SelectedDate == DateTime.MinValue)
            {
                Response.Write("<script>alert('Seleccione una fecha de nacimiento.');</script>");
                cFechaNac.Focus();
                return;
            }
            if (cFechaIns.SelectedDate == DateTime.MinValue)
            {
                Response.Write("<script>alert('Seleccione una fecha de inscripción.');</script>");
               cFechaIns.Focus();
               return;
            }
            //Validacion apoderado
            if (txtNamEA.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtNamEA.Focus();
                return;
            }
            if (txtNameLA.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtNameLA.Focus();
                return;
            }
            if (CfechaNacA.SelectedDate == DateTime.MinValue)
            {
                Response.Write("<script>alert('Seleccione una fecha de nacimiento.');</script>");
                CfechaNacA.Focus();
                return;
            }
            if (txtDniA.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtDniA.Focus();
                return;
            }
            if (txtFonoA.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtFonoA.Focus();
                return;
            }
            if (txtCorreoA.Text == "")
            {
                Response.Write("<script>alert('Ingrese un nombre.');</script>");
                txtCorreoA.Focus();
                return;
            }

            // Capturando valores
             // estduiante
            nom = txtName.Text;
            ape = txtLName.Text;
            telefono = txtFono.Text;
            dni = txtDNI.Text;
            direccion = txtDireccion.Text;
            correo = txtCorreo.Text;
            fechanac = cFechaNac.SelectedDate;
            iddistrito = Convert.ToInt32(ddlDistritos.SelectedValue.ToString());
            idgrado = Convert.ToInt32(ddlGrado.SelectedValue.ToString());
            idnivel = Convert.ToInt32(ddlNivel.SelectedValue.ToString());
            idsexo = Convert.ToInt32(ddlSexo.SelectedValue.ToString());
            if (chkEst.Checked == true)
            {
                est = 'H';
            }
            else
            {
                est = 'D';
            }
            //apoderado
            nomA = txtNamEA.Text;
            apeA = txtNameLA.Text;
            fechanacA = CfechaNacA.SelectedDate;
            dniA = txtDniA.Text;
            fonoA = txtFonoA.Text;
            corrA = txtCorreoA.Text;
            if (chkEstA.Checked == true)
            {
                estA = 'H';
            }
            else
            {
                estA = 'D';
            }
            //Matricula
            idEstmat =  Convert.ToInt32(ddlestMat.SelectedValue.ToString());
            vacante = txtVacante.Text;
            if (chkEstMat.Checked == true)
            {
                estA = 'S';
            }
            else
            {
                estA = 'N';
            }
            //eNVIANDO
            //eSTDUAINTES
            obj.Nombre = txtName.Text;
            obj.Apellido = txtLName.Text;
            obj.Dni = txtDNI.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = txtFono.Text;
            obj.CorreoElectronico = txtCorreo.Text;
            obj.Estado = chkEst.Checked ? '1' : '0';
            obj.FechaNacimiento = cFechaNac.SelectedDate;
            obj.FechaInscripcion = cFechaIns.SelectedDate;
            objDis.idDistrito = iddistrito;
            obj.NombreDistrito = ddlDistritos.SelectedItem.Text;
            objGrado.IdGrado = idgrado;
            obj.NombreGrado = ddlGrado.SelectedItem.Text;
            objNivel.IdNivel = idnivel;
            obj.NombreNivel = ddlNivel.SelectedItem.Text;
            objsexo.idSexo = idsexo;
            obj.NombreSexo = ddlSexo.SelectedItem.Text;
            //Apoderado 
            objA.Nombre = txtNamEA.Text;
            objA.Apellido = txtNameLA.Text;
            objA.FechaNacimiento = CfechaNacA.SelectedDate;
            objA.Dni = txtDniA.Text;
            objA.Telefono = txtFonoA.Text;
            objA.CorreoElectronico = txtCorreoA.Text;
            objA.Estado = chkEst.Checked ? '1' : '0';
            //Matricula
            objMa.NombreEstudiante = txtName.Text;
            objMa.ApellidoEstudiante = txtLName.Text;
            objMa.NombreApoderado = txtNamEA.Text;
            objMa.FechaMatricula = cFechaIns.SelectedDate;
            objMa.TipoVacante = txtVacante.Text;
            objMa.NombreNivel = ddlNivel.SelectedItem.Text;
            objMa.NombreGrado = ddlGrado.SelectedItem.Text;
            objMa.EstadoMatricula = ddlestMat.SelectedItem.Text;
            objMa.Visible = chkEstMat.Checked ? 'S' : 'N';
            balMa.RegistrarMatricula(obj, objA);
            res = bal.RegistrarEstudiante(obj);
            res = balAp.RegistrarApoderado(objA);
            
            if (res == true)
            {
                Response.Write("<script>alert('Se registró el estudiante y el apoderado');</script>");
                CargarMatricula();
                // Limpiamos los controles
                Limpiar();
                // Bloqueamos
                Bloquear();
                // Desbloqueamos el botón nuevo
                BtnNew.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert('No se puede registrar el estudiante');</script>");
                Limpiar();

            } 
        }
        protected void BtnUp_Click(object sender, EventArgs e)
        {
            // Capturando los valores de los controles
            IdEstudiante = Convert.ToInt32(txtCodE.Text);
            nom = txtName.Text;
            ape = txtLName.Text;
            dni = txtDNI.Text;
            direccion = txtDireccion.Text;
            telefono = txtFono.Text;
            correo = txtCorreo.Text;
            fechanac = cFechaNac.SelectedDate;
            fechains = cFechaIns.SelectedDate;

            obj.Estado = chkEst.Checked ? '1' : '0';
            // Enviamos los datos al objeto Estudiante
            obj.IdEstudiante = IdEstudiante;
            obj.Nombre = nom;
            obj.Apellido = ape;
            obj.Dni = dni;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.CorreoElectronico = correo;
            obj.FechaInscripcion = fechains;
            obj.FechaNacimiento = fechanac;


            res = bal.ActualizarEstudiante(obj);
            if (res)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se actualizo el estudiante')", true);
                CargarMatricula();
                Limpiar();
                Bloquear();
                BtnNew.Enabled = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se actualizo el estudiante')", true);
                Limpiar();
            }
        }
        protected void BtnDel_Click(object sender, EventArgs e)
        {
            // Capturando el código del estudiante a eliminar
            IdEstudiante = Convert.ToInt32(txtCodE.Text);
            obj.IdEstudiante = IdEstudiante;
            // Cuadro de diálogo para confirmar la eliminación
                // Ejecutamos la función de eliminación
                res = bal.EliminarEstudiante(obj);
                if (res)
                {
                ClientScript.RegisterStartupScript(this.GetType(),"alert","alert('Se elimino al estudiante')", true);
                CargarMatricula();
                    Limpiar();
                    Bloquear();
                    BtnNew.Enabled = true;
                }
                else
                {
                ClientScript.RegisterStartupScript(this.GetType(),"alert","alert('No se pudo eliminar al estudiante')", true);
                Limpiar();
                }
        }
        protected void BtnSer_Click(object sender, EventArgs e)
        {

            // Capturando el código del estudiante a habilitar
            IdEstudiante = Convert.ToInt32(txtCodE.Text);
            obj.IdEstudiante = IdEstudiante;
                // Ejecutamos la función de habilitación
                res = bal.HabilitarEstudiante(obj);
                if (res)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se encontro al estudiante')", true);
                    CargarMatricula();
                    Limpiar();
                    Bloquear();
                    BtnNew.Enabled = true;
                }
                else
                {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se encontro el estudiante')", true);
                Limpiar();
                }
            
        }
        protected void dgvStu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //cuando seleccionamos una fila de la tabla
            if (e.CommandName == "Seleccionar")
            {
                //desbloquear
                Desbloquear();
                //bloqueamos el boton registrar
                BtnOt.Enabled = false;
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = dgvStu.Rows[index];
                //asignamos los valores a los controles
                txtIdMat.Text = selectedRow.Cells[0].Text;
                txtName.Text = selectedRow.Cells[1].Text;
                txtLName.Text = selectedRow.Cells[2].Text;
                txtNamEA.Text = selectedRow.Cells[3].Text;
                cFechaIns.SelectedDate = DateTime.Parse(selectedRow.Cells[4].Text);
                txtVacante.Text = selectedRow.Cells[5].Text;
                // Asignación de ddlNivel
                string nivelSeleccionado = selectedRow.Cells[6].Text.Trim();
                ListItem itemNivel = ddlNivel.Items.FindByText(nivelSeleccionado);
                ddlNivel.SelectedValue = itemNivel != null ? itemNivel.Value : ddlNivel.Items[0].Value;

                // Asignación de ddlGrado
                string gradoSeleccionado = selectedRow.Cells[7].Text.Trim();
                ListItem itemGrado = ddlGrado.Items.FindByText(gradoSeleccionado);
                ddlGrado.SelectedValue = itemGrado != null ? itemGrado.Value : ddlGrado.Items[0].Value;

                // Asignación de ddlestMat
                string estadoSeleccionado = selectedRow.Cells[8].Text.Trim();
                ListItem itemEstado = ddlestMat.Items.FindByText(estadoSeleccionado);
                ddlestMat.SelectedValue = itemEstado != null ? itemEstado.Value : ddlestMat.Items[0].Value;

                ////para el valor del rol
                //string rolSeleccionado = selectedRow.Cells[13].Text;
                //// Buscar el objeto en la lista
                //List<EstudianteBO> estudiantes = balEstudiante.Mo();
                //RolBO rolEncontrado = roles.FirstOrDefault(r => r.nombre.Equals(rolSeleccionado, StringComparison.OrdinalIgnoreCase));
                //int cod = -1;
                //// Verificar si se encontró el rol
                //if (rolEncontrado != null)
                //{
                //    cod = rolEncontrado.codigo;
                //}
                //seleccionamos el combo
                //ddlDistritos.SelectedValue = cod.ToString();
                //ddlGrado.SelectedValue = cod.ToString();
                //ddlNivel.SelectedValue = cod.ToString();
                //ddlSexo.SelectedValue = cod.ToString();
                ////para el checkbox
                if (((selectedRow.Cells[9].Controls[0] as DataBoundLiteralControl).Text).Trim().Equals("Habilitado"))
                {
                    chkEst.Checked = true;
                }
                else
                {
                    chkEst.Checked = false;
                }
            }
        }
    }
}

