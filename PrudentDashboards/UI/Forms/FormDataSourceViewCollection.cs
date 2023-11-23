using Library;
using Library.Models;

namespace UI.Forms
{
    public partial class FormDataSourceViewCollection : Form
    {
        private readonly DataSourceModelCollection _dataSources = DataSourceModelCollection.Load();

        public FormDataSourceViewCollection()
        {
            InitializeComponent();

            listViewDataViews.MouseDoubleClick += (object? sender, MouseEventArgs e) => EditSelectedItem();
        }

        private void FormDataSourceViewCollection_Load(object sender, EventArgs e)
        {
            foreach (var dataView in DataSourceViewModelCollection.Load())
            {
                var dataSourcename = _dataSources.Where(o => o.Id == dataView.DataSourceId).Select(o => o.Name).FirstOrDefault();

                var item = new ListViewItem(dataView.Name);
                item.SubItems.Add(dataSourcename);
                item.Tag = dataView;
                listViewDataViews.Items.Add(item);
            }
        }

        private void SaveGrid()
        {
            var dataViews = new DataSourceViewModelCollection();

            foreach (ListViewItem item in listViewDataViews.Items)
            {
                Utility.EnsureNotNull(item.Tag);
                dataViews.Add((DataSourceViewModel)item.Tag);
            }

            dataViews.Save();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var formDataView = new FormDataSourceView())
            {
                if (formDataView.ShowDialog(this) == DialogResult.OK)
                {
                    var dataSourcename = _dataSources.Where(o => o.Id == formDataView.DataSourceView.DataSourceId).Select(o => o.Name).FirstOrDefault();

                    var item = new ListViewItem(formDataView.DataSourceView.Name);
                    item.SubItems.Add(dataSourcename);
                    item.Tag = formDataView.DataSourceView;
                    listViewDataViews.Items.Add(item);

                    SaveGrid();
                }
            }
        }

        private void EditSelectedItem()
        {
            if (listViewDataViews.SelectedItems?.Count != 1)
            {
                return;
            }

            var selectedItem = listViewDataViews.SelectedItems[0];

            var dataView = selectedItem.Tag as DataSourceViewModel;
            Utility.EnsureNotNull(dataView);

            using (var formDataView = new FormDataSourceView(dataView))
            {
                if (formDataView.ShowDialog(this) == DialogResult.OK)
                {
                    var dataSourcename = _dataSources.Where(o => o.Id == formDataView.DataSourceView.DataSourceId).Select(o => o.Name).FirstOrDefault();

                    selectedItem.SubItems.Clear();
                    selectedItem.Text = formDataView.DataSourceView.Name;
                    selectedItem.SubItems.Add(dataSourcename);
                    selectedItem.Tag = formDataView.DataSourceView;

                    SaveGrid();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e) => EditSelectedItem();

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewDataViews.SelectedItems?.Count != 1)
            {
                return;
            }

            var item = listViewDataViews.SelectedItems[0];
            if (MessageBox.Show($"Delete '{item.Text}'?", Constants.TitleCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            listViewDataViews.Items.Remove(item);
            SaveGrid();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
