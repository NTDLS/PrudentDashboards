namespace Library.Models
{
    public class ChartModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid DataSourceViewId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
