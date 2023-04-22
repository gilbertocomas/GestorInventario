using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Usuarios
    {
        private readonly ConnectionBD conn = ConnectionBD.Instance;

        public void D_crearUsuario (E_Usuarios usuario)
        {
            SqlCommand command = new SqlCommand("sp_crear_usuario", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@login_usuario", usuario.LoginUsuario);
            command.Parameters.AddWithValue("@password_usuario", usuario.PasswordUsuario);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@correo", usuario.Correo);
            command.Parameters.AddWithValue("@rol_usuario", usuario.RolUsuario);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public void D_actualizarUsuario(E_Usuarios usuario)
        {
            SqlCommand command = new SqlCommand("sp_actualizar_usuario", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@cod_usuario", usuario.CodUsuario);
            command.Parameters.AddWithValue("@login_usuario", usuario.LoginUsuario);
            command.Parameters.AddWithValue("@password_usuario", usuario.PasswordUsuario);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@correo", usuario.Correo);
            command.Parameters.AddWithValue("@rol_usuario", usuario.RolUsuario);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public void D_eliminarUsuario(E_Usuarios usuario)
        {
            SqlCommand command = new SqlCommand("sp_eliminar_usuario", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@cod_usuario", usuario.CodUsuario);
            command.ExecuteNonQuery();
            conn.CloseConnection();
        }

        public DataTable D_consultarUsuarios(E_Usuarios usuario)
        {
            SqlCommand command = new SqlCommand("sp_consultar_usuarios", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;       
        }

        public DataTable D_consultarUsuarioPorId(E_Usuarios usuario)
        {
            SqlCommand command = new SqlCommand("sp_consultar_usuario_by_id", conn.Connection);
            command.CommandType = CommandType.StoredProcedure;
            conn.OpenConnection();
            command.Parameters.AddWithValue("@cod_usuario", usuario.CodUsuario);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.CloseConnection();
            return dt;
        }

        public string D_validarUsuario(E_Usuarios usuario)
        {
            using (SqlCommand command = new SqlCommand("ps_verificar_usuario", conn.Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@login_usuario", usuario.LoginUsuario));
                command.Parameters.Add(new SqlParameter("@password_usuario", usuario.PasswordUsuario));
                conn.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                // Verificar si hay resultados y obtener el valor de la columna "Rol" o "Error"
                if (reader.HasRows)
                {
                    reader.Read();
                    string result = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    reader.Close(); //En este metodo me vi en la obligacion de cerrar el reader.
                    conn.CloseConnection(); 
                    return result;
                }
                else
                {
                    reader.Close(); 
                    conn.CloseConnection(); 
                    return "error";
                }

            }

        }

    }
}
