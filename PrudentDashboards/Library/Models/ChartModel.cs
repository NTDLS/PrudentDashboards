using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace Library.Models
{
    public class ChartModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ChartType ChartType { get; set; } = ChartType.Pie;
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid DataSourceViewId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
