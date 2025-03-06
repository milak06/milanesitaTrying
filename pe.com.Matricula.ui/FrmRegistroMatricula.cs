using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pe.com.Matricula.bal;
using pe.com.Matricula.bo;

namespace pe.com.Matricula.ui
{
    public partial class FrmRegistroMatricula : Form
    {
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.ComboBox cbogrado;

        private readonly MatriculaBAL _matriculaBAL;
        private readonly EstudianteBAL _estudianteBAL;
        private readonly ApoderadoBAL _apoderadoBAL;
        public string nombre;

        public string NombreNivel { get; set; }  
        public string NombreGrado { get; set; }     
        public int IdNivel { get; set; }            
        public int IdGrado { get; set; }
        public FrmRegistroMatricula()
        {
            InitializeComponent();
            _matriculaBAL = new MatriculaBAL();
            _estudianteBAL = new EstudianteBAL();
            _apoderadoBAL = new ApoderadoBAL();
        }
        private void FrmRegistroMatricula_Load(object sender, EventArgs e)
        {
            
                ConfigurarControlesIniciales();
                CargarDistritos();
                CargarComboBoxes();

                
                txtNivelAca.Text = NombreNivel; 
                txtGrado.Text = NombreGrado;           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdocumentoidentidad_alu.Text))
                {
                    MessageBox.Show("Ingrese el documento de identidad del alumno para buscar",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EstudianteBO estudiante = _estudianteBAL.BuscarPorDNI(txtdocumentoidentidad_alu.Text);

                if (estudiante != null)
                {
                    txtidalumno.Text = estudiante.IdEstudiante.ToString();
                    txtdocumentoidentidad_alu.Text = estudiante.Dni;
                    txtnombres_alu.Text = estudiante.Nombre;
                    txtapellidos_alu.Text = estudiante.Apellido;
                    txtfechanacimiento_alu.Value = estudiante.FechaNacimiento;
                    txtdireccion_alu.Text = estudiante.Direccion;
                    txtTelf_est.Text = estudiante.Telefono;
                    txtCorreo_est.Text = estudiante.CorreoElectronico;

                    cbosexo_alu.SelectedIndex = estudiante.IdSexo - 1; 

                    txtdocumentoidentidad_alu.Enabled = false;
                    txtnombres_alu.Enabled = false;
                    txtapellidos_alu.Enabled = false;
                    txtfechanacimiento_alu.Enabled = false;
                    cbosexo_alu.Enabled = false;
                    txtdireccion_alu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el alumno con el documento de identidad proporcionado.",
                                    "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar alumno: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarControlesIniciales()
        {
            try
            {
                txtfechanacimiento_alu.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
                txtfechanacimiento_apo.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));

                txtidalumno.Text = "0";
                txtNivelAca.Text = nombre;
                txtGrado.Text = nombre;
                txtcodigomatricula.Text = "Autogenerado";

                btnregistrar.Enabled = true;
                btnbuscar.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar controles: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxes()
        {
            try
            {
                // Situación del Alumno
                cbosituacion.Items.Clear();
                cbosituacion.Items.Add(new ComboBoxItem("Nuevo", "Nuevo"));
                cbosituacion.Items.Add(new ComboBoxItem("Antiguo", "Antiguo"));
                cbosituacion.DisplayMember = "Text";
                cbosituacion.ValueMember = "Value";
                cbosituacion.SelectedIndex = 0;

                // Repitente
                cboRepitente.Items.Add(new ComboBoxItem("NO", "NO"));
                cboRepitente.Items.Add(new ComboBoxItem("SI", "SI"));
                cboRepitente.DisplayMember = "Text";
                cboRepitente.ValueMember = "Value";
                cboRepitente.SelectedIndex = 0;

                // Sexo Alumno
                cbosexo_alu.Items.Clear();
                cbosexo_alu.Items.Add(new ComboBoxItem("Masculino", "Masculino"));
                cbosexo_alu.Items.Add(new ComboBoxItem("Femenino", "Femenino"));
                cbosexo_alu.DisplayMember = "Text";
                cbosexo_alu.ValueMember = "Value";
                cbosexo_alu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ComboBoxes: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario()) return;

                // Crear objeto Estudiante
                EstudianteBO estudiante = new EstudianteBO
                {
                    Nombre = txtnombres_alu.Text.Trim(),
                    Apellido = txtapellidos_alu.Text.Trim(),
                    FechaNacimiento = txtfechanacimiento_alu.Value,
                    Dni = txtdocumentoidentidad_alu.Text.Trim(),
                    Direccion = txtdireccion_alu.Text.Trim(),
                    Telefono = "",
                    CorreoElectronico = "",
                    FechaInscripcion = DateTime.Now,
                    IdGrado = ObtenerIdGrado(),
                    IdNivel = ObtenerIdNivel(),
                    IdDistrito = 1,
                    Estado = '1'
                };

                // Crear objeto Apoderado
                ApoderadoBO apoderado = new ApoderadoBO
                {
                    Nombre = txtnombres_apo.Text.Trim(),
                    Apellido = txtapellidos_apo.Text.Trim(),
                    FechaNacimiento = txtfechanacimiento_apo.Value,
                    Dni = txtdocumentoidentidad_apo.Text.Trim(),
                    Direccion = txtdireccion_apo.Text.Trim(),
                    Telefono = txtTelf_Apo.Text.Trim(),
                    CorreoElectronico= txtCorreo_Apo.Text.Trim(),
                    Estado = '1'
                };

                // Registrar matrícula
                _matriculaBAL.RegistrarMatricula(estudiante, apoderado);

                MessageBox.Show("Matrícula registrada exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar matrícula: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtnombres_alu.Text) ||
                string.IsNullOrWhiteSpace(txtapellidos_alu.Text) ||
                string.IsNullOrWhiteSpace(txtdocumentoidentidad_alu.Text))
            {
                MessageBox.Show("Debe completar todos los datos del alumno", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtdocumentoidentidad_apo.Text) ||
                string.IsNullOrWhiteSpace(txtnombres_apo.Text) ||
                string.IsNullOrWhiteSpace(txtapellidos_apo.Text))
            {
                MessageBox.Show("Debe completar todos los datos del apoderado", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // Lista de distritos predefinidos
        List<string> distritos = new List<string>
{
    "--Seleccione distrito--","Ate", "Barranco", "Breña", "Callao", "Cercado de Lima", "Chaclacayo", "Chorrillos",
    "Cieneguilla", "Comas", "El Agustino", "Independencia", "Jesús María", "La Molina",
    "La Victoria", "Lince", "Lurigancho", "Lurin", "Magdalena del Mar", "Miraflores",
    "Pueblo Libre", "Puente Piedra", "San Bartolo", "San Borja", "San Isidro", "San Juan de Lurigancho",
    "San Juan de Miraflores", "San Luis", "San Martin de Porres", "San Miguel", "Santa Anita",
    "Santa María del Mar", "Santiago de Surco", "Surquillo", "Villa El Salvador", "Villa María del Triunfo"
};


        // Cargar los distritos al ComboBox cuando se carga el formulario
        private void CargarDistritos()
        {
            cboDistrito_alu.Items.Clear();  
            foreach (var distrito in distritos)
            {
                cboDistrito_alu.Items.Add(distrito);
            }
        }

        private void MostrarListadoDistritos()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (var distrito in distritos)
                {
                    sb.AppendLine(distrito);
                }

                MessageBox.Show(sb.ToString(), "Listado de Distritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los distritos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarDistritos_Click(object sender, EventArgs e)
        {
            MostrarListadoDistritos();
        }

        private void btnAgregarDistrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDistrito_alu.SelectedIndex != -1)
                {
                    string distritoSeleccionado = cboDistrito_alu.SelectedItem.ToString();

                    if (!distritos.Contains(distritoSeleccionado))
                    {
                        distritos.Add(distritoSeleccionado); 
                        cboDistrito_alu.Items.Add(distritoSeleccionado);
                        MessageBox.Show($"Distrito '{distritoSeleccionado}' agregado al ComboBox.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El distrito '{distritoSeleccionado}' ya existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un distrito antes de agregarlo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar distrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarFormulario()
        {
            txtdocumentoidentidad_alu.Clear();
            txtnombres_alu.Clear();
            txtapellidos_alu.Clear();
            cboDistrito_alu.SelectedIndex = 0;
            txtdireccion_alu.Clear();
            txtTelf_est.Clear();
            txtCorreo_est.Clear();
            txtfechanacimiento_alu.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
            cbosexo_alu.SelectedIndex = -1;

            txtdocumentoidentidad_apo.Clear();
            txtnombres_apo.Clear();
            txtapellidos_apo.Clear();
            txtdireccion_apo.Clear();
            txtTelf_Apo.Clear();
            txtCorreo_Apo.Clear();
            txtfechanacimiento_apo.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));


            cbosituacion.SelectedIndex = 0;
            cboRepitente.SelectedIndex = -1;
            cboDistrito_alu.SelectedIndex = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbosituacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((ComboBoxItem)cbosituacion.SelectedItem).Value.ToString() == "Antiguo")
            {
                btnbuscar.BackColor = Color.DodgerBlue;
                btnlimpiar.BackColor = Color.DodgerBlue;
                btnbuscar.Cursor = Cursors.Hand;
                btnlimpiar.Cursor = Cursors.Hand;
            }
            else
            {
                btnbuscar.BackColor = Color.LightGray;
                btnlimpiar.BackColor = Color.LightGray;
                btnbuscar.Cursor = Cursors.No;
                btnlimpiar.Cursor = Cursors.No;
            }
            limpiardata();
        }
        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            if (btnlimpiar.Cursor == Cursors.No)
                return;

            LimpiarFormulario();
        }
        private void limpiardata()
        {
            txtidalumno.Text = "0";
            txtdocumentoidentidad_alu.Enabled = true;
            txtnombres_alu.Enabled = true;
            txtapellidos_alu.Enabled = true;
            txtfechanacimiento_alu.Enabled = true;
            cbosexo_alu.Enabled = true;
            cboDistrito_alu.SelectedIndex = 0;
            txtdireccion_alu.Enabled = true;

            txtdocumentoidentidad_alu.Text = "";
            txtnombres_alu.Text = "";
            txtapellidos_alu.Text = "";
            txtfechanacimiento_alu.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
            cbosexo_alu.SelectedIndex = 0;
            txtdireccion_alu.Text = "";


        }
        private int ObtenerIdGrado()
        {
            if (cbogrado.SelectedItem is GradoBO gradoSeleccionado)
            {
                return gradoSeleccionado.IdGrado; 
            }

            return 0;
        }

        private int ObtenerIdNivel()
        {
            if (cbonivel.SelectedItem is NivelBO nivelSeleccionado)
            {
                return nivelSeleccionado.IdNivel;  
            }

            return -1;
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdocumentoidentidad_alu.Text))
                {
                    MessageBox.Show("Ingrese el documento de identidad del alumno para buscar",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear instancia de búsqueda (suponiendo que tienes un método de búsqueda en el BAL)
                EstudianteBO estudiante = _estudianteBAL.BuscarPorDNI(txtdocumentoidentidad_alu.Text);

                if (estudiante != null)
                {
                    // Llenar campos del alumno
                    txtidalumno.Text = estudiante.IdEstudiante.ToString();
                    txtdocumentoidentidad_alu.Text = estudiante.Dni;
                    txtnombres_alu.Text = estudiante.Nombre;
                    txtapellidos_alu.Text = estudiante.Apellido;
                    txtfechanacimiento_alu.Value = estudiante.FechaNacimiento;

                    // Sexo
                    foreach (ComboBoxItem item in cbosexo_alu.Items)
                    {
                        string sexoString = estudiante.IdSexo == 1 ? "Masculino" : "Femenino";

                        if ((string)item.Value == sexoString)
                        {
                            cbosexo_alu.SelectedItem = item;
                            break;
                        }
                    }

                    txtdireccion_alu.Text = estudiante.Direccion;

                    // Deshabilitar campos para que no se editen
                    txtdocumentoidentidad_alu.Enabled = false;
                    txtnombres_alu.Enabled = false;
                    txtapellidos_alu.Enabled = false;
                    txtfechanacimiento_alu.Enabled = false;
                    cbosexo_alu.Enabled = false;
                    txtdireccion_alu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el alumno con el documento de identidad proporcionado.",
                                    "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar alumno: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void cboDistrito_alu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un distrito
                if (cboDistrito_alu.SelectedIndex != -1)
                {
                    // Obtener el distrito seleccionado
                    string distritoSeleccionado = cboDistrito_alu.SelectedItem.ToString();

                    // Mostrar un mensaje con el distrito seleccionado (puedes realizar alguna acción)
                    MessageBox.Show($"Distrito seleccionado: {distritoSeleccionado}", "Distrito Seleccionado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Si necesitas hacer alguna acción adicional con el distrito seleccionado
                    // como actualizar otros campos o realizar cálculos, puedes agregar el código aquí
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un distrito.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar distrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}