using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using pe.com.Matricula.bo;
using pe.com.Matricula.bal;
using pe.com.Matricula.dal;


namespace pe.com.Matricula.ui
{
    public partial class FrmCrearMatricula: Form
    {
        private NivelBAL nivelBAL = new NivelBAL();
        private GradoBAL gradoBAL = new GradoBAL();
        private int vacantesDisponibles = 0;


        public FrmCrearMatricula()
        {
            InitializeComponent();
            this.Load += FrmCrearMatricula_Load;
        }

        private void FrmCrearMatricula_Load(object sender, EventArgs e)
        {
            CargarNiveles();
        }

        private void CargarNiveles()
        {
            cbonivel.DataSource = nivelBAL.ObtenerNiveles();
            cbonivel.DisplayMember = "Nombre";
            cbonivel.ValueMember = "IdNivel";
        }



        private void cbonivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonivel.SelectedItem is NivelBO nivelSeleccionado)
            {
                CargarGrados(nivelSeleccionado.IdNivel);
            }
        }

        private void CargarGrados(int idNivel)
        {
            cbogrado.DataSource = gradoBAL.ObtenerGradosPorNivel(idNivel);
            cbogrado.DisplayMember = "Nombre";
            cbogrado.ValueMember = "IdGrado";
        }
       
        private void cbogrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtvacantes_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbogrado.SelectedItem is GradoBO gradoSeleccionado)
            {
                int idGrado = gradoSeleccionado.IdGrado;
                GradoDAL gradoDAL = new GradoDAL();
                vacantesDisponibles = gradoDAL.ObtenerVacantesDisponibles(idGrado);
                txtvacantes.Text = vacantesDisponibles.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un grado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtvacantes.Text) || int.Parse(txtvacantes.Text) <= 0)
            {
                MessageBox.Show("No hay vacantes disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbogrado.SelectedItem is GradoBO gradoSeleccionado && cbonivel.SelectedItem is NivelBO nivelSeleccionado)
            {
                int idGrado = gradoSeleccionado.IdGrado;
                bool actualizado = DisminuirVacante(idGrado);

                if (actualizado)
                {

                    FrmRegistroMatricula frm = new FrmRegistroMatricula();

                    frm.NombreGrado = gradoSeleccionado.Nombre;
                    frm.IdGrado = gradoSeleccionado.IdGrado;
                    frm.NombreNivel = nivelSeleccionado.Nombre;  
                    frm.IdNivel = nivelSeleccionado.IdNivel;    

                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la vacante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grado y un nivel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool DisminuirVacante(int idGrado)
        {
            string query = "UPDATE Vacante SET cantidad = cantidad - 1 WHERE idGrado = @idGrado AND cantidad > 0";

            using (SqlConnection con = new ConexionDAL().Conectar()) // Usa tu clase de conexión
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idGrado", idGrado);
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0; 
            }
        }
    }
}
