using Library;
using Library.Models;
using System.Data.Common;
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
        }

        private void FormEditDataView_Load(object sender, EventArgs e)
        {
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

            //Chart.Fields.ForEach(o => AddTypeToList(o));
        }

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