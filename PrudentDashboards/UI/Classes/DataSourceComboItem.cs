using Library.Models;

namespace UI.Classes
{
    internal class DataSourceComboItem
    {
        public DataSource DataSource { get; set; }

        public DataSourceComboItem(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public override string ToString() => DataSource.Name;
    }
}
