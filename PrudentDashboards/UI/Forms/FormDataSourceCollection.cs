using Library;
using Library.Models;

namespace UI.Forms
{
    public partial class FormDataSourceCollection : Form
    {
        public FormDataSourceCollection()
        {
            InitializeComponent();

            listViewDataSources.MouseDoubleClick += (object? sender, MouseEventArgs e) => EditSelectedItem();
        }

        private void FormDataSourceCollection_Load(object sender, EventArgs e)
        {
            foreach (var dataSource in DataSourceModelCollection.Load())
            {
                var item = new ListViewItem(dataSource.Name);
                item.SubItems.Add(dataSource.ServerName);
                item.SubItems.Add(dataSource.DatabaseName);
                item.Tag = dataSource;
                listViewDataSources.Items.Add(item);
            }
        }

        private void SaveGrid()
        {
            var dataSources = new DataSourceModelCollection();

            foreach (ListViewItem item in listViewDataSources.Items)
            {
                Utility.EnsureNotNull(item.Tag);
                dataSources.Add((DataSourceModel)item.Tag);
            }

            dataSources.Save();
        }

        private DataSourceModel? EstablishConnection(DataSourceModel? connectionInfo = null)
        {
            using var formDataSource = new FormDataSource(connectionInfo);
            if (formDataSource.ShowDialog() == DialogResult.OK)
            {
                return formDataSource.DataSource;
            }
            return null;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            DataSourceModel? dataSource = EstablishConnection();
            if (dataSource == null)
            {
                return;
            }

            var item = new ListViewItem(dataSource.Name);
            item.SubItems.Add(dataSource.ServerName);
            item.SubItems.Add(dataSource.DatabaseName);
            item.Tag = dataSource;
            listViewDataSources.Items.Add(item);

            SaveGrid();
        }

        private void EditSelectedItem()
        {
            if (listViewDataSources.SelectedItems?.Count != 1)
            {
                return;
            }

            var selectedItem = listViewDataSources.SelectedItems[0];

            var dataSource = selectedItem.Tag as DataSourceModel;
            Utility.EnsureNotNull(dataSource);

            dataSource = EstablishConnection(dataSource);
            if (dataSource == null)
            {
                return;
            }

            selectedItem.SubItems.Clear();
            selectedItem.Text = dataSource.Name;
            selectedItem.SubItems.Add(dataSource.ServerName);
            selectedItem.SubItems.Add(dataSource.DatabaseName);
            selectedItem.Tag = dataSource;

            SaveGrid();
        }

        private void ButtonEdit_Click(object sender, EventArgs e) => EditSelectedItem();

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewDataSources.SelectedItems?.Count != 1)
            {
                return;
            }

            var item = listViewDataSources.SelectedItems[0];
            if (MessageBox.Show($"Delete '{item.Text}'?", Constants.TitleCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            listViewDataSources.Items.Remove(item);
            SaveGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
