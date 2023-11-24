using Library;
using Library.Models;

namespace UI.Forms
{
    public partial class FormChartCollection : Form
    {
        private readonly DataSourceViewModelCollection _dataViews = DataSourceViewModelCollection.Load();

        public FormChartCollection()
        {
            InitializeComponent();

            listViewCharts.MouseDoubleClick += (object? sender, MouseEventArgs e) => EditSelectedItem();
        }

        private void FormChartCollection_Load(object sender, EventArgs e)
        {
            foreach (var chart in ChartModelCollection.Load())
            {
                var dataViewName = _dataViews.Where(o => o.Id == chart.DataSourceViewId).Select(o => o.Name).FirstOrDefault();

                var item = new ListViewItem(chart.Name);
                item.SubItems.Add(dataViewName);
                item.Tag = chart;
                listViewCharts.Items.Add(item);
            }
        }

        private void SaveGrid()
        {
            var charts = new ChartModelCollection();

            foreach (ListViewItem item in listViewCharts.Items)
            {
                Utility.EnsureNotNull(item.Tag);
                charts.Add((ChartModel)item.Tag);
            }

            charts.Save();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (var formChart = new FormChart())
            {
                if (formChart.ShowDialog() == DialogResult.OK)
                {
                    var dataViewName = _dataViews.Where(o => o.Id == formChart.Chart.DataSourceViewId).Select(o => o.Name).FirstOrDefault();

                    var item = new ListViewItem(formChart.Chart.Name);
                    item.SubItems.Add(dataViewName);
                    item.Tag = formChart.Chart;
                    listViewCharts.Items.Add(item);

                    SaveGrid();
                }
            }
        }

        private void EditSelectedItem()
        {
            if (listViewCharts.SelectedItems?.Count != 1)
            {
                return;
            }

            var selectedItem = listViewCharts.SelectedItems[0];

            var chart = selectedItem.Tag as ChartModel;
            Utility.EnsureNotNull(chart);

            using (var formChart = new FormChart(chart))
            {
                if (formChart.ShowDialog() == DialogResult.OK)
                {
                    var dataSourcename = _dataViews.Where(o => o.Id == formChart.Chart.DataSourceViewId).Select(o => o.Name).FirstOrDefault();

                    selectedItem.SubItems.Clear();
                    selectedItem.Text = formChart.Chart.Name;
                    selectedItem.SubItems.Add(dataSourcename);
                    selectedItem.Tag = formChart.Chart;

                    SaveGrid();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e) => EditSelectedItem();

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewCharts.SelectedItems?.Count != 1)
            {
                return;
            }

            var item = listViewCharts.SelectedItems[0];
            if (MessageBox.Show($"Delete '{item.Text}'?", Constants.TitleCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            listViewCharts.Items.Remove(item);
            SaveGrid();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
