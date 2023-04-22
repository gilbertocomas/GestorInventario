using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        E_Usuarios objetoEntidad = new E_Usuarios();
        N_Usuarios objetoNegocio = new N_Usuarios();

        private void validarUsuario()
        {
            

            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor completar campos para iniciar sesión!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.LoginUsuario = txtUsuario.Text;
            objetoEntidad.PasswordUsuario = txtPassword.Text;

            string rol = objetoNegocio.N_validarUsuario(objetoEntidad);

            if(rol == "admin" || rol == "user")
            {

                if (rol == "admin")
                {
                    frmPrincipal FormaPrincipal = new frmPrincipal(rol);
                    FormaPrincipal.Show();
                    this.Hide();
                }
                else if (rol == "user")
                {
                    frmPrincipal FormaPrincipal = new frmPrincipal(rol);
                    FormaPrincipal.Show();
                    this.Hide();
                }
            }else 
            {
                MessageBox.Show("Usuario no existe!", "Error de validación!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }
    }
}
