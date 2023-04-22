using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Productos
    {
        private readonly ConnectionBD conn = ConnectionBD.Instance;

        public void D_crearProducto (E_Productos producto)
        {
            SqlCommand command = new SqlCommand("sp_crear_producto", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@desc_producto", producto.DesProducto);
            command.Parameters.AddWithValue("@categoria_producto", producto.Categoria);
            command.Parameters.AddWithValue("@costo_producto", producto.CostoProducto);
            command.Parameters.AddWithValue("@precio_producto", producto.PrecioProducto);
            command.Parameters.AddWithValue("@medida_producto", producto.UnidadMedidaProducto);
            command.Parameters.AddWithValue("@existencia", producto.Existencia);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public void D_actualizarProducto (E_Productos producto)
        {
            SqlCommand command = new SqlCommand("sp_actualizar_producto", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@cod_producto", producto.CodProducto);
            command.Parameters.AddWithValue("@desc_producto", producto.DesProducto);
            command.Parameters.AddWithValue("@categoria_producto", producto.Categoria);
            command.Parameters.AddWithValue("@costo_producto", producto.CostoProducto);
            command.Parameters.AddWithValue("@precio_producto", producto.PrecioProducto);
            command.Parameters.AddWithValue("@medida_producto", producto.UnidadMedidaProducto);
            command.Parameters.AddWithValue("@existencia", producto.Existencia);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public void D_eliminarProducto(E_Productos producto)
        {
            try
            {
                SqlCommand command = new SqlCommand("sp_eliminar_producto", conn.Connection);
                command.CommandType = CommandType.StoredProcedure;
                conn.OpenConnection();
                command.Parameters.AddWithValue("@cod_producto", producto.CodProducto);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.CloseConnection();
            }   
        }

        public DataTable D_buscarProductos ()
        {
            SqlCommand command = new SqlCommand("sp_consultar_productos", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

        public DataTable D_buscarProductoPorId (E_Productos producto)
        {
            SqlCommand command = new SqlCommand("sp_consultar_producto_by_id", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@cod_producto", producto.CodProducto);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }
    }
}
