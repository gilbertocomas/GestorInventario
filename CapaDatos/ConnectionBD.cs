using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConnectionBD
    {
        private static ConnectionBD instance = new ConnectionBD();
        private string connectionString = "Data Source=LENOVO-LEGION\\SQLEXPRESS; Initial Catalog=bd_control_inventario ; integrated security = true";
        private SqlConnection sqlConnection;

        private ConnectionBD()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public static ConnectionBD Instance
        {
            get
            {
                return instance;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return sqlConnection;
            }
        }

        public void OpenConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}