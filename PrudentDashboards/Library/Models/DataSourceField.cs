namespace Library
{
    public class DataSourceField
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool Enabled { get; set; }

        public DataSourceField()
        {
        }

        public DataSourceField(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
