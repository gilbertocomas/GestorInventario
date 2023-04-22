using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        E_Usuarios objetoEntidad = new E_Usuarios();
        N_Usuarios objetoNegocio = new N_Usuarios();

        private void seleccionarRegistro(DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            if (nRow != -1)
            {
                txtCodUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtLoginUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                cbRolUsuario.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarRegistro(e);
        }
        private void limpiarCampos()
        {
            txtCodUsuario.Text = "";
            txtLoginUsuario.Text = "";
            txtCorreo.Text = "";
            txtPasswordUsuario.Text = "";
            txtNombre.Text = "";
            cbRolUsuario.Text = "";
        }

        private void listarUsuarios()
        {
            DataTable dt = objetoNegocio.N_consultarUsuarios(objetoEntidad);
            dgvUsuarios.DataSource = dt;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "" || txtCorreo.Text == "" || txtPasswordUsuario.Text == "" || txtNombre.Text == "" || cbRolUsuario.Text == "")
            {
                MessageBox.Show("Por favor completar campos, excepto Id para agregar un usuario!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            objetoEntidad.LoginUsuario = txtLoginUsuario.Text;
            objetoEntidad.Correo = txtCorreo.Text;
            objetoEntidad.PasswordUsuario = txtPasswordUsuario.Text;
            objetoEntidad.Nombre = txtNombre.Text;
            objetoEntidad.RolUsuario = cbRolUsuario.Text;

            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que desea agregar un nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objetoNegocio.N_crearUsuario(objetoEntidad);
                limpiarCampos();
                MessageBox.Show("Registro Agregado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarUsuarios();
            }
            else
            {
                limpiarCampos();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCodUsuario.Text == "" || txtLoginUsuario.Text == "" || txtCorreo.Text == "" || txtPasswordUsuario.Text == "" || txtNombre.Text == "" || cbRolUsuario.Text == "")
            {
                MessageBox.Show("Por favor completar campos, excepto Id para agregar un usuario!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.CodUsuario = Convert.ToInt32(txtCodUsuario.Text);
            objetoEntidad.LoginUsuario = txtLoginUsuario.Text;
            objetoEntidad.Correo = txtCorreo.Text;
            objetoEntidad.PasswordUsuario = txtPasswordUsuario.Text;
            objetoEntidad.Nombre = txtNombre.Text;
            objetoEntidad.RolUsuario = cbRolUsuario.Text;

            DialogResult respuesta;
            respuesta = MessageBox.Show("Estás seguro de querer actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objetoNegocio.N_actualizarUsuario(objetoEntidad);
                listarUsuarios();
                MessageBox.Show("Registro Actualizado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
            else
            {
                limpiarCampos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodUsuario.Text == "")
            {
                MessageBox.Show("Por favor completar campos, excepto Id para agregar un usuario!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.CodUsuario = Convert.ToInt32(txtCodUsuario.Text);

            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objetoNegocio.N_eliminarUsuario(objetoEntidad);
                listarUsuarios();
                MessageBox.Show("Registro Eliminado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarCampos();
            }
            else
            {
                limpiarCampos();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtCodUsuario.Text != "")
            {
                objetoEntidad.CodUsuario = Convert.ToInt32(txtCodUsuario.Text.Trim());
                DataTable dt = objetoNegocio.N_consultarUsuarioPorId(objetoEntidad);
                dgvUsuarios.DataSource = dt;
                limpiarCampos();
            } else
            {
                listarUsuarios();
                limpiarCampos();
            }
        }

        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarRegistro(e);
        }
    }
}
