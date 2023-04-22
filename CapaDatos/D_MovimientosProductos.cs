using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_MovimientosProductos
    {
        private readonly ConnectionBD conn = ConnectionBD.Instance;

        public void D_incrementarProducto (E_MovimientosProductos movimientoPro)
        {
            SqlCommand command = new SqlCommand("sp_incrementar_producto", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("cod_producto", movimientoPro.CodProducto);
            command.Parameters.AddWithValue("cantidad", movimientoPro.Cantidad);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public void D_decrementarProducto(E_MovimientosProductos movimientoPro)
        {
            SqlCommand command = new SqlCommand("sp_decrementar_producto", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("cod_producto", movimientoPro.CodProducto);
            command.Parameters.AddWithValue("cantidad", movimientoPro.Cantidad);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public DataTable D_consultarMovimientos()
        {
            SqlCommand command = new SqlCommand("sp_consultar_movimientos", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

        public DataTable D_10MayoresMovimientosProductos()
        {
            SqlCommand command = new SqlCommand("sp_10_productos_con_mas_movimientos", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

        public DataTable D_reporteIncrementoProductos()
        {
            SqlCommand command = new SqlCommand("sp_reporte_incrementos", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

        public DataTable D_reporteDecrementoProductos()
        {
            SqlCommand command = new SqlCommand("sp_reporte_decrementos", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }


    }
}
