using Library;
using Library.ManagedConnectivity;
using Library.Models;
using OxyPlot;
using OxyPlot.Series;
using PrudentDashboards.UI;
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

            splitContainerHorzFieldSelction.SplitterDistance = splitContainerHorzFieldSelction.Height / 2;
            splitContainerTopFieldSelector.SplitterDistance = splitContainerTopFieldSelector.Width / 2;
            splitContainerBottomFieldSelector.SplitterDistance = splitContainerBottomFieldSelector.Width / 2;

            listViewValues.AllowDrop = true;
            listViewFilters.AllowDrop = true;
            listViewAxis.AllowDrop = true;
            listViewLegend.AllowDrop = true;

            listViewDataSourceViewFields.ItemDrag += ListViewSource_ItemDrag;

            listViewValues.DragEnter += ListViewTarget_DragEnter;
            listViewFilters.DragEnter += ListViewTarget_DragEnter;
            listViewAxis.DragEnter += ListViewTarget_DragEnter;
            listViewLegend.DragEnter += ListViewTarget_DragEnter;

            listViewValues.DragDrop += ListViewTarget_DragDrop;
            listViewFilters.DragDrop += ListViewTarget_DragDrop;
            listViewAxis.DragDrop += ListViewTarget_DragDrop;
            listViewLegend.DragDrop += ListViewTarget_DragDrop;

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
            }
        }

        private void FormEditDataView_Load(object sender, EventArgs e) { }

        private void BuildChart()
        {
            if (_dataSourceView == null)
            {
                return;
            }

            var dataSource = _dataSourceCollection.Where(o=> o.Id == _dataSourceView.DataSourceId).FirstOrDefault();

            if (dataSource == null)
            {
                return;
            }

            var plotModel = new PlotModel
            {
                Title = textBoxName.Text,
                Subtitle = textBoxDescription.Text                 
            };

            //foreach(ListViewItem 


            var series = new LineSeries
            {
                Title = "Data Series",
            };

            series.Points.Add(new DataPoint(1, 10));
            series.Points.Add(new DataPoint(2, 20));
            series.Points.Add(new DataPoint(3, 30));
            series.Points.Add(new DataPoint(4, 25));
            series.Points.Add(new DataPoint(5, 35));

            plotModel.Series.Add(series);

            string sqlText = $"SELECT TOP 100 * FROM ({_dataSourceView.SQLText}) as dq";

            using (var formProgress = new FormProgress())
            {
                var thread = new Thread(() =>
                {
                    formProgress.WaitForVisible();

                    using var connection = new ManagedConnection(dataSource.GetSqlServerConnectionString());
                    using var reader = connection.ExecuteReader(sqlText);

                    foreach (var field in reader.Fields)
                    {
                        AddGridColumn(field.Name);
                    }

                    foreach (var row in reader)
                    {
                        AddGridRow(row.Select(r => r.ToString()).ToList());
                    }

                    formProgress.Close();
                });

                thread.Start();

                formProgress.ShowDialog();
            }

            void AddGridRow(List<string?> values)
            {
                if (dataGridViewResults.InvokeRequired)
                {
                    dataGridViewResults.Invoke(new Action(() => AddGridRow(values)));
                }
                else
                {
                    dataGridViewResults.Rows.Add(values.ToArray());
                }
            }

            void AddGridColumn(string name)
            {
                if (dataGridViewResults.InvokeRequired)
                {
                    dataGridViewResults.Invoke(new Action(() => AddGridColumn(name)));
                }
                else
                {
                    dataGridViewResults.Columns.Add(name, name);
                }
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