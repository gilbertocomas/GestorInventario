using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMovimientosProductos : Form
    {
        public string RolUsuario { get; set; }
        public frmMovimientosProductos(string rolUsuario)
        {
            InitializeComponent();
            RolUsuario = rolUsuario;
        }

        N_Productos productos = new N_Productos();
        E_MovimientosProductos objEntidad = new E_MovimientosProductos();
        N_MovimientosProductos objNegocio = new N_MovimientosProductos();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos()
        {
            cbProducto.Text = "";
            txtCantidad.Text = "";
        }

        private void listarMovimientos()
        {
            DataTable dt = objNegocio.N_consultarMovimientos();
            bdgvMovimientos.DataSource = dt;

        }

        private void obtenerProductos()
        {
            DataTable dt = productos.N_buscarProductos();
            dt.Columns.Add("CodDesc", typeof(string), "CODPROD + ' _ ' + DESCRIPCION");
            cbProducto.DataSource = dt;
            cbProducto.DisplayMember = "CodDesc";
        }

        private void frmMovimientosProductos_Load(object sender, EventArgs e)
        {
            if(this.RolUsuario == "user")
            {
                btnIngresar.Enabled = false;
                btnSustraer.Enabled = false;
            }
            obtenerProductos();
            listarMovimientos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cbProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Por favor completar campos, para poder realizar movimiento!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textoComboBox = cbProducto.Text;
            int posisicion = textoComboBox.IndexOf(" ");
            string subCadena = textoComboBox.Substring(0, posisicion + 1);
            int codigoProducto = Convert.ToInt32(subCadena);

            objEntidad.CodProducto = codigoProducto;
            objEntidad.Cantidad = Convert.ToInt32(txtCantidad.Text);

            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que desea agregar un nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objNegocio.N_incrementarProducto(objEntidad);
                limpiarCampos();
                MessageBox.Show("Registro Agregado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarMovimientos();
            }
            else
            {
                limpiarCampos();
            }
        }

        private void btnSustraer_Click(object sender, EventArgs e)
        {
            if (cbProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Por favor completar campos, para poder realizar movimiento!", "Error campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textoComboBox = cbProducto.Text;
            int posisicion = textoComboBox.IndexOf(" ");
            string subCadena = textoComboBox.Substring(0, posisicion + 1);
            int codigoProducto = Convert.ToInt32(subCadena);

            objEntidad.CodProducto = codigoProducto;
            objEntidad.Cantidad = Convert.ToInt32(txtCantidad.Text);

            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que desea agregar un nuevo registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objNegocio.N_decrementarProducto(objEntidad);
                limpiarCampos();
                MessageBox.Show("Registro Restado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarMovimientos();
            }
            else
            {
                limpiarCampos();
            }
        }

        
    }
}
