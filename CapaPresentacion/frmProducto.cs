using System;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        string RolUsuario {  get; set; }
        public frmProductos(string rolUsuario)
        {
            InitializeComponent();
            RolUsuario = rolUsuario;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        E_Productos objetoEntidad = new E_Productos();
        N_Productos objetoNegocio = new N_Productos();

        private void seleccionarRegistro(DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            if (nRow != -1)
            {
                txtCodProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDesProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                cbCategoria.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtCostoProducto.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtPrecioProducto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                txtMedidaProducto.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                txtExistencia.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void limpiarCampos()
        {
            txtCodProducto.Text = "";
            txtDesProducto.Text = "";
            cbCategoria.Text = "";
            txtCostoProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtMedidaProducto.Text = "";
            txtExistencia.Text = "";
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if(this.RolUsuario == "user")
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            listarProductos();
        }

        private void listarProductos()
        {
            DataTable dt = objetoNegocio.N_buscarProductos();
            dgvProductos.DataSource = dt;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtCostoProducto.Text == "" || txtPrecioProducto.Text == "")
            {
                MessageBox.Show("Por favor completar campos, excepto Id para agregar un producto!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.DesProducto = txtDesProducto.Text;
            objetoEntidad.Categoria = cbCategoria.Text;
            objetoEntidad.CostoProducto = Convert.ToDouble(txtCostoProducto.Text);
            objetoEntidad.PrecioProducto = Convert.ToDouble(txtPrecioProducto.Text);
            objetoEntidad.UnidadMedidaProducto = txtMedidaProducto.Text;
            objetoEntidad.Existencia = Convert.ToInt32(txtExistencia.Text);


            if (objetoEntidad.DesProducto == "" || objetoEntidad.Categoria == "" || txtCostoProducto.Text == "" || txtPrecioProducto.Text == "" || objetoEntidad.UnidadMedidaProducto == "" || txtExistencia.Text == "")
            {
                MessageBox.Show("Por favor completar campos, excepto Id para agregar un producto!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Seguro que desea agregar un nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objetoNegocio.N_crearProducto(objetoEntidad);
                    limpiarCampos();
                    MessageBox.Show("Registro Agregado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarProductos();
                }
                else
                {
                    limpiarCampos();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtCodProducto.Text == "" || txtCostoProducto.Text == "" || txtPrecioProducto.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para actualizar un producto!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.CodProducto = Convert.ToInt32(txtCodProducto.Text);
            objetoEntidad.DesProducto = txtDesProducto.Text;
            objetoEntidad.Categoria = cbCategoria.Text;
            objetoEntidad.CostoProducto = Convert.ToDouble(txtCostoProducto.Text);
            objetoEntidad.PrecioProducto = Convert.ToDouble(txtPrecioProducto.Text);
            objetoEntidad.UnidadMedidaProducto = txtMedidaProducto.Text;
            objetoEntidad.Existencia = Convert.ToInt32(txtExistencia.Text);


            if (objetoEntidad.DesProducto == "" || objetoEntidad.Categoria == "" || txtCostoProducto.Text == "" || txtPrecioProducto.Text == "" || objetoEntidad.UnidadMedidaProducto == "" || txtExistencia.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para actualizar un producto!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Estás seguro de querer actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objetoNegocio.N_actualizarProducto(objetoEntidad);
                    listarProductos();
                    MessageBox.Show("Registro Actualizado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    limpiarCampos();
                }
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarRegistro(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtCodProducto.Text == "")
            {
                MessageBox.Show("Debe indicar un registsro válido para eliminar!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objetoEntidad.CodProducto = Convert.ToInt32(txtCodProducto.Text);
 
            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objetoNegocio.N_eliminarProducto(objetoEntidad);
                listarProductos();
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
            if (txtCodProducto.Text != "")
            {
                objetoEntidad.CodProducto = Convert.ToInt32(txtCodProducto.Text);
                DataTable dt = objetoNegocio.N_buscarProductoPorId(objetoEntidad);
                dgvProductos.DataSource = dt;
                limpiarCampos();

            } else
            {
                listarProductos();
                limpiarCampos();
            }
            


        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarRegistro(e);
        }
    }
}
