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

        private ChartType _chartType = ChartType.Bar;
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
                    RefreshChart();
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
                chart = new ChartModel()
                {
                    Name = "",
                    ChartType = ChartType.Bar,
                };
            }
            Chart = chart;

            Enum.GetValues<ChartType>().ToList().ForEach(o => comboBoxChartType.Items.Add(o.ToString()));
            comboBoxChartType.SelectedIndexChanged += (object? sender, EventArgs e) =>
            {
                _chartType = Enum.Parse<ChartType>(comboBoxChartType.Text);
                RefreshChart();
            };
            comboBoxChartType.Text = chart.ChartType.ToString();
            _chartType = chart.ChartType;

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

            listViewValue.KeyUp += ListView_KeyUp;
            listViewFilter.KeyUp += ListView_KeyUp;
            listViewAxis.KeyUp += ListView_KeyUp;
            listViewSeries.KeyUp += ListView_KeyUp;

            void ListView_KeyUp(object? sender, KeyEventArgs e)
            {
                var listview = (ListView?)sender;
                if (listview != null && listview.SelectedItems?.Count == 1)
                {
                    listview.Items.Remove(listview.SelectedItems[0]);
                    RefreshChart();
                }
            }

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
                        RefreshChart();
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

#if DEBUG
            _chartType = ChartType.Line;
            comboBoxChartType.Text = chart.ChartType.ToString();

            //listViewSeries.Items.Add("Region");
            listViewSeries.Items.Add("Country");

            listViewAxis.Items.Add("OrderYear");
            listViewAxis.Items.Add("OrderMonth");

            listViewValue.Items.Add("TotalDue");
#endif
        }

        private void FormEditDataView_Load(object sender, EventArgs e) { }

        private void RefreshChart()
        {
            if (_dataSourceView == null)
            {
                return;
            }

            var dataSource = _dataSourceCollection.Where(o => o.Id == _dataSourceView.DataSourceId).FirstOrDefault();
            if (dataSource == null)
            {
                return;
            }


            if (_chartType == ChartType.Pie)
            {

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

            if (valueFields.Count == 0 || (seriesFields.Count == 0 && axisFields.Count == 0))
            {
                plotView.Model = plotModel;
                return;
            }

            if (int.TryParse(textBoxRowLimit.Text, out var rowLimit) == false)
            {
                rowLimit = 1000;
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

            StringBuilder orderByFields = new();

            foreach (var axisField in axisFields)
            {
                sqlSelectFields.Append($"dq.[{axisField}] as [{axisField}],");
                sqlGroupFields.Append($"dq.[{axisField}],");
                orderByFields.Append($"dq.[{axisField}],");
            }

            sqlSelectFields.Length -= 1; //Kill the trailing comma.
            sqlGroupFields.Length -= 1; //Kill the trailing comma.
            if (orderByFields.Length > 0)
            {
                orderByFields.Length -= 1; //Kill the trailing comma.
            }

            var sqlText = new StringBuilder($"SELECT TOP {rowLimit} {sqlSelectFields} FROM ({_dataSourceView.SQLText}) as dq");

            if (sqlGroupFields.Length > 0)
            {
                sqlText.AppendLine($" GROUP BY {sqlGroupFields}");
            }

            if (orderByFields.Length > 0)
            {
                sqlText.AppendLine($" ORDER BY {orderByFields}");
            }

            using var connection = new ManagedConnection(dataSource.GetSqlServerConnectionString());
            using var reader = connection.ExecuteReader(sqlText.ToString());
            foreach (var row in reader)
            {
                string axisLabelText = string.Empty;
                string seriesLabelText = string.Empty;
                string seriesCacheKey = string.Empty;

                //Build a series label and cache-key;
                for (int i = 0; i < seriesFields.Count; i++)
                {
                    seriesLabelText += $"[{row.AsString(seriesFields[i], "")}]";
                    if (i < seriesFields.Count - 1) seriesLabelText += '-';

                    seriesCacheKey += $"[{row.AsString(seriesFields[i], "")}]";
                    if (i < seriesFields.Count - 1) seriesCacheKey += '-';
                }

                //Build a series label and cache-key;
                for (int i = 0; i < axisFields.Count; i++)
                {
                    axisLabelText += $"[{row.AsString(axisFields[i], "")}]";
                    if (i < axisFields.Count - 1) axisLabelText += '-';

                    //seriesCacheKey += $"[{row.AsString(axisFields[i], "")}]";
                    //if (i < axisFields.Count - 1) seriesCacheKey += '-';
                }

                /*
                if (_chartType == ChartType.Pie)
                {
                    seriesCacheKey = "SinglePieSeries"; //Piecharts can only have one series.
                }
                */

                if (seriesCache.TryGetValue(seriesCacheKey, out var cachedSeries) == false)
                {
                    cachedSeries = ChartHelpers.CreateSeries(_chartType, seriesLabelText);
                    seriesCache.Add(seriesCacheKey, cachedSeries);
                }

                foreach (var valueField in valueFields)
                {
                    var seriesValue = row.AsDecimal(valueField, 0);
                    ChartHelpers.AddSeriesDataPoint(_chartType, cachedSeries, (double)seriesValue, axisLabelText);
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
            RefreshChart();
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

        private void ToolStripButtonProperties_Click(object sender, EventArgs e)
        {
            splitContainerVertChartBody.Panel1Collapsed = !splitContainerVertChartBody.Panel1Collapsed;
        }

        private void ToolStripButtonFields_Click(object sender, EventArgs e)
        {
            splitContainerVert.Panel2Collapsed = !splitContainerVert.Panel2Collapsed;
        }
    }
}