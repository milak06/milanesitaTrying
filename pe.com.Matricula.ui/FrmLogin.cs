using pe.com.Matricula.bo;
using pe.com.Matricula.bal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.Matricula.ui
{
    public partial class FrmLogin: Form
    {

        UsuarioBO objusuario = new UsuarioBO();
        UsuarioBAL objusubal = new UsuarioBAL();
        UtilidadBAL objutibal = new UtilidadBAL();

        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        { 

            if(txtUsu.Text == "")
            {
                objutibal.MostrarMensaje("Ingrese Usuario", "INGRESE AL SISTEMA", 1, 1);
                txtUsu.Focus();
                return;
            }
            else if (txtCon.Text == "")
            {
                objutibal.MostrarMensaje("Ingrese Contraseña", "INGRESE AL SISTEMA", 1, 1);
                txtCon.Focus();
                return;
            }
            else
            {
                String Usua="", contra = "";
                Usua = txtUsu.Text;
                contra = txtCon.Text;
                objusuario.usuario = Usua;
                objusuario.clave = contra;

                if (objusubal.VerificarUsuario(objusuario))
                {
                    objutibal.MostrarMensaje("Bienvenido al Sistema", "INGRESE AL SISTEMA", 1, 2);
                    FrmMenuPrincipal frm = new FrmMenuPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    objutibal.MostrarMensaje("Usuario o Contraseña Incorrecta", "INGRESE AL SISTEMA", 1, 1);
                    txtUsu.Text = "";
                    txtCon.Text = "";
                    txtUsu.Focus();
                }
            }


        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
