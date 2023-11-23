namespace Library.Models
{
    public class DataSourceView
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid DataSourceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SQLText { get; set; } = string.Empty;
        public List<DataSourceField> Fields { get; set; } = new();
    }
}
