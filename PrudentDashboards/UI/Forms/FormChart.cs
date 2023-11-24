using Library;
using Library.ManagedConnectivity;
using Library.Models;
using OxyPlot;
using OxyPlot.Series;
using System.Text;
using UI.Classes;

namespace UI
{
    public partial class FormChart : Form
    {
        public ChartModel Chart { get; private set; }

        private bool _firstShown = true;
        private DataSourceViewModel? _dataSourceView;
        private readonly DataSourceModelCollection _dataSourceCollection = DataSourceModelCollection.Load();

        public FormChart(ChartModel? chart = null)
        {
            InitializeComponent();

            Shown += (object? sender, EventArgs e) =>
            {
                if (_firstShown)
                {
                    _firstShown = false;
                    BuildChart();
                }
            };

            comboBoxDataSourceView.SelectedIndexChanged += (object? sender, EventArgs e) =>
            {
                _dataSourceView = (comboBoxDataSourceView.SelectedItem as DataSourceViewComboItem)?.DataSourceView;

                listViewDataSourceViewFields.Items.Clear();

                if (_dataSourceView != null)
                {
                    foreach (var field in _dataSourceView.Fields.Where(o => o.Enabled == true))
                    {
                        var item = listViewDataSourceViewFields.Items.Add(field.Alias);
                        item.SubItems.Add(field.Type);
                        item.Checked = field.Enabled;
                    }
                }
            };

            if (chart == null)
            {
                Chart = new ChartModel()
                {
                    Name = ""
                };
            }
            else
            {
                Chart = chart;
            }

            listViewSeries.Items.Add("Region");
            listViewSeries.Items.Add("Country");
            listViewValue.Items.Add("TotalDue");

            splitContainerHorzFieldSelction.SplitterDistance = splitContainerHorzFieldSelction.Height / 2;
            splitContainerTopFieldSelector.SplitterDistance = splitContainerTopFieldSelector.Width / 2;
            splitContainerBottomFieldSelector.SplitterDistance = splitContainerBottomFieldSelector.Width / 2;

            listViewValue.AllowDrop = true;
            listViewFilter.AllowDrop = true;
            listViewAxis.AllowDrop = true;
            listViewSeries.AllowDrop = true;

            listViewDataSourceViewFields.ItemDrag += ListViewSource_ItemDrag;

            listViewValue.DragEnter += ListViewTarget_DragEnter;
            listViewFilter.DragEnter += ListViewTarget_DragEnter;
            listViewAxis.DragEnter += ListViewTarget_DragEnter;
            listViewSeries.DragEnter += ListViewTarget_DragEnter;

            listViewValue.DragDrop += ListViewTarget_DragDrop;
            listViewFilter.DragDrop += ListViewTarget_DragDrop;
            listViewAxis.DragDrop += ListViewTarget_DragDrop;
            listViewSeries.DragDrop += ListViewTarget_DragDrop;

            void ListViewSource_ItemDrag(object? sender, ItemDragEventArgs e)
            {
                var listview = (ListView?)sender;
                if (listview != null && e.Item != null)
                {
                    listview.DoDragDrop(e.Item, DragDropEffects.Copy);
                }
            }

            void ListViewTarget_DragEnter(object? sender, DragEventArgs e)
            {
                if (e.Data != null)
                {
                    if (e.Data.GetDataPresent(typeof(ListViewItem)))
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
                e.Effect = DragDropEffects.None;
            }

            void ListViewTarget_DragDrop(object? sender, DragEventArgs e)
            {
                var listview = (ListView?)sender;
                if (listview != null && e.Data != null && e.Data.GetDataPresent(typeof(ListViewItem)))
                {
                    var item = (ListViewItem?)e.Data.GetData(typeof(ListViewItem));
                    if (item != null)
                    {
                        listview.Items.Add((ListViewItem)item.Clone());
                        BuildChart();
                    }
                }
            }

            foreach (var dataSourceView in DataSourceViewModelCollection.Load())
            {
                var item = new DataSourceViewComboItem(dataSourceView);
                comboBoxDataSourceView.Items.Add(item);
                if (Chart.DataSourceViewId == dataSourceView.Id)
                {
                    comboBoxDataSourceView.SelectedItem = item;
                }
            }

            textBoxName.Text = Chart.Name;
            textBoxDescription.Text = Chart.Description;

            if (Owner == null)
            {
                StartPosition = FormStartPosition.CenterScreen;
                ShowInTaskbar = true;
            }
        }

        private void FormEditDataView_Load(object sender, EventArgs e) { }

        private void BuildChart()
        {
            ChartType chartType = ChartType.Bar;

            if (_dataSourceView == null)
            {
                return;
            }

            var dataSource = _dataSourceCollection.Where(o => o.Id == _dataSourceView.DataSourceId).FirstOrDefault();
            if (dataSource == null)
            {
                return;
            }

            var seriesFields = ChartHelpers.GetListViewFields(listViewSeries);
            var axisFields = ChartHelpers.GetListViewFields(listViewAxis);
            var valueFields = ChartHelpers.GetListViewFields(listViewValue);
            var filterFields = ChartHelpers.GetListViewFields(listViewFilter);

            var plotModel = new PlotModel
            {
                Title = textBoxName.Text,
                Subtitle = textBoxDescription.Text
            };

            if (valueFields.Count == 0 || seriesFields.Count == 0)
            {
                plotView.Model = plotModel;
                return;
            }

            var seriesCache = new Dictionary<string, Series>();

            StringBuilder sqlSelectFields = new();
            foreach (var valueField in valueFields)
            {
                sqlSelectFields.Append($"SUM(dq.[{valueField}]) as [{valueField}],");
            }

            StringBuilder sqlGroupFields = new();
            foreach (var seriesField in seriesFields)
            {
                sqlSelectFields.Append($"dq.[{seriesField}] as [{seriesField}],");
                sqlGroupFields.Append($"dq.[{seriesField}],");
            }

            sqlSelectFields.Length -= 1; //Kill the trailing comma.
            sqlGroupFields.Length -= 1; //Kill the trailing comma.

            string sqlText = $"SELECT TOP 1000 {sqlSelectFields} FROM ({_dataSourceView.SQLText}) as dq GROUP BY {sqlGroupFields}";

            using var connection = new ManagedConnection(dataSource.GetSqlServerConnectionString());
            using var reader = connection.ExecuteReader(sqlText);
            foreach (var row in reader)
            {
                string seriesCacheKey = string.Empty;
                for (int i = 0; i < seriesFields.Count; i++)
                {
                    seriesCacheKey += $"[{row.AsString(seriesFields[i], "")}]";
                    if (i < seriesFields.Count - 1) seriesCacheKey += '-';
                }

                if (seriesCache.TryGetValue(seriesCacheKey, out var cachedSeries) == false)
                {
                    cachedSeries = ChartHelpers.CreateSeries(chartType, seriesCacheKey);
                    seriesCache.Add(seriesCacheKey, cachedSeries);
                }

                foreach (var valueField in valueFields)
                {
                    var seriesValue = row.AsDecimal(valueField, 0);
                    ChartHelpers.AddSeriesDataPoint(chartType, cachedSeries, (double)seriesValue);
                }
            }

            foreach (var series in seriesCache)
            {
                plotModel.Series.Add(series.Value);
            }

            plotView.Model = plotModel;
        }


        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            BuildChart();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (_dataSourceView == null)
            {
                MessageBox.Show("Before you can save, you must select a datasource view.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("You must enter a chart name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Chart.Name = textBoxName.Text;
            Chart.Description = textBoxDescription.Text;
            Chart.DataSourceViewId = _dataSourceView.Id;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}