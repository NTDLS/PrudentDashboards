using Library.Models;

namespace UI.Classes
{
    internal class DataSourceComboItem
    {
        public DataSourceModel DataSource { get; set; }

        public DataSourceComboItem(DataSourceModel dataSource)
        {
            DataSource = dataSource;
        }

        public override string ToString() => DataSource.Name;
    }
}
