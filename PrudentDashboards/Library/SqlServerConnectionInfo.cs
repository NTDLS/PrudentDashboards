namespace Library
{
    public class SqlServerConnectionInfo
    {
        public string? ServerName { get; set; }
        public string? DatabaseName { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IntegratedSecurity { get; set; }
    }
}
