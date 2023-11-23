namespace Library
{
    public class DataSourceFieldModel
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool Enabled { get; set; }

        public DataSourceFieldModel()
        {
        }

        public DataSourceFieldModel(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
