using System.Data.SqlClient;

namespace Library.ManagedConnectivity
{
    public class ManagedConnection : IDisposable
    {
        public SqlConnection Connection { get; private set; }

        public ManagedConnection(SqlConnectionStringBuilder builder)
        {
            Connection = new SqlConnection(builder.ToString());
            Connection.Open();
        }

        public ManagedConnection(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public ManagedReader ExecuteReader(string sqlText)
        {
            return new ManagedReader(sqlText, Connection);
        }

        public void Dispose()
        {
            try
            {
                Connection.Close();
            }
            catch { }
        }
    }
}
