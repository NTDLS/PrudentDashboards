using Library.Models;

namespace UI.Classes
{
    internal class DataSourceViewComboItem
    {
        public DataSourceViewModel DataSourceView { get; set; }

        public DataSourceViewComboItem(DataSourceViewModel dataSourceView)
        {
            DataSourceView = dataSourceView;
        }

        public override string ToString() => DataSourceView.Name;
    }
}
