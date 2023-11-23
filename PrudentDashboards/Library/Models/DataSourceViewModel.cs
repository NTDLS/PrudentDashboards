namespace Library.Models
{
    public class DataSourceViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid DataSourceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SQLText { get; set; } = string.Empty;
        public DataSourceFieldModelCollection Fields { get; set; } = new();
    }
}
