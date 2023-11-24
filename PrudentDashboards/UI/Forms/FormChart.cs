using Library;
using Library.Models;
using System.Windows.Forms;
using UI.Classes;

namespace UI
{
    public partial class FormChart : Form
    {
        public ChartModel Chart { get; private set; }

        private DataSourceViewModel? _dataSourceView;

        public FormChart(ChartModel? chart = null)
        {
            InitializeComponent();

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
            listViewRows.AllowDrop = true;
            listViewColumns.AllowDrop = true;

            // Subscribe to the necessary events for drag-and-drop
            listViewDataSourceViewFields.ItemDrag += ListViewSource_ItemDrag;

            listViewValues.DragEnter += ListViewTarget_DragEnter;
            listViewFilters.DragEnter += ListViewTarget_DragEnter;
            listViewRows.DragEnter += ListViewTarget_DragEnter;
            listViewColumns.DragEnter += ListViewTarget_DragEnter;

            listViewValues.DragDrop += ListViewTarget_DragDrop;
            listViewFilters.DragDrop += ListViewTarget_DragDrop;
            listViewRows.DragDrop += ListViewTarget_DragDrop;
            listViewColumns.DragDrop += ListViewTarget_DragDrop;

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
                // Event handler for allowing the drop operation in the target ListView

                if (e.Data != null)
                {
                    // Check if the data being dragged is valid for the drop operation
                    if (e.Data.GetDataPresent(typeof(ListViewItem)))
                    {
                        e.Effect = DragDropEffects.Copy; // Set the cursor to indicate a copy operation
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None; // Disable the drop operation
                    }
                }
            }

            void ListViewTarget_DragDrop(object? sender, DragEventArgs e)
            {
                // Event handler for handling the drop operation in the target ListView
                var listview = (ListView?)sender;

                if (listview != null && e.Data != null && e.Data.GetDataPresent(typeof(ListViewItem)))
                {
                    var item = (ListViewItem?)e.Data.GetData(typeof(ListViewItem));
                    if (item != null)
                    {
                        listview.Items.Add((ListViewItem)item.Clone()); // Clone and add the item to the target ListView
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

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {

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