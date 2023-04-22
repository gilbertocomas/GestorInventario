using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public string RolUsuario { get; set; }
        public frmPrincipal(string rolUsuario)
        {
            InitializeComponent();
            this.RolUsuario = rolUsuario;
        }

        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarios FormaUsuario = new frmUsuarios();
            FormaUsuario.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos FormaProductos = new frmProductos(this.RolUsuario);
            FormaProductos.Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosProductos FormaMovimientos = new frmMovimientosProductos(this.RolUsuario);
            FormaMovimientos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes FormaReportes = new frmReportes();
            FormaReportes.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(this.RolUsuario == "user")
            {
                btnUsuario.Enabled = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
