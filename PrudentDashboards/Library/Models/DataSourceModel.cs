using System.Data.SqlClient;

namespace Library.Models
{
    public class DataSourceModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ServerName { get; set; }
        public string? DatabaseName { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IntegratedSecurity { get; set; }

        public string GetSqlServerConnectionString()
        {
            var connectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource = ServerName,
                InitialCatalog = DatabaseName,
                IntegratedSecurity = IntegratedSecurity,
                UserID = UserName,
                Password = Password
            };

            return connectionBuilder.ToString();
        }
    }
}
