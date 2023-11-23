using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Library;
using Library.ManagedConnectivity;
using Library.Models;
using PrudentDashboards.UI;
using System.Windows.Forms.Integration;
using System.Xml;
using UI.Classes;
using UI.Properties;

namespace UI
{
    public partial class FormDataSourceView : Form
    {
        public TextEditor Editor { get; private set; }
        public DataSourceView DataSourceView { get; private set; }

        private DataSource? _dataSource;

        public FormDataSourceView(DataSourceView? dataSourceView = null)
        {
            InitializeComponent();

            Editor = new TextEditor
            {
                ShowLineNumbers = true,
                FontFamily = new System.Windows.Media.FontFamily("Courier New"),
                FontSize = 16f,
                WordWrap = false,
            };

            using (StringReader stringReader = new StringReader(Resources.MSSQLSyntaxHighlighter))
            {
                using (XmlReader reader = XmlReader.Create(stringReader))
                {
                    Editor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
                    reader.Close();
                }
                stringReader.Close();
            }

            splitContainerHoriz.Panel1.Controls.Add(new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = Editor
            });

            Editor.KeyUp += (object sender, System.Windows.Input.KeyEventArgs e) =>
            {
                if (e.Key == System.Windows.Input.Key.F5)
                {
                    SampleData();
                }
            };

            comboBoxDatasource.SelectedIndexChanged += (object? sender, EventArgs e) =>
            {
                _dataSource = (comboBoxDatasource.SelectedItem as DataSourceComboItem)?.DataSource;
            };

            if (dataSourceView == null)
            {
                DataSourceView = new DataSourceView()
                {
                    Name = "",
                    SQLText = "SELECT\r\n\t*\r\nFROM\r\n\t"
                };
#if DEBUG
                DataSourceView.SQLText = "select\r\n\tST.[Name] as [SalesTerritory],\r\n\tST.[CountryRegionCode] as [Country],\r\n\tST.[Group] as [Region],\r\n\tSOH.OrderDate,\r\n\tSOH.TotalDue,\r\n\tSOH.Freight,\r\n\tSOH.TaxAmt,\r\n\tSOH.SubTotal\r\nfrom\r\n\t[Sales].[SalesOrderHeader] as SOH\r\nINNER JOIN [Sales].[SalesTerritory] as ST\r\n\tON ST.TerritoryID = SOH.TerritoryID\r\n\r\n";
#endif
            }
            else
            {
                DataSourceView = dataSourceView;
            }
        }

        private void FormEditDataView_Load(object sender, EventArgs e)
        {
            foreach (var dataSource in DataSourceCollection.Load())
            {
                var item = new DataSourceComboItem(dataSource);
                comboBoxDatasource.Items.Add(item);

                if (DataSourceView.DataSourceId == dataSource.Id)
                {
                    comboBoxDatasource.SelectedItem = item;
                }
            }

            textBoxName.Text = DataSourceView.Name;
            textBoxDescription.Text = DataSourceView.Description;
            Editor.Text = DataSourceView.SQLText;

            DataSourceView.Fields.ForEach(o => AddTypeToList(o));
        }

        private void SampleData()
        {
            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();
            listViewFields.Items.Clear();

            if (_dataSource == null)
            {
                return;
            }

            string sqlText = $"SELECT TOP 100 * FROM ({Editor.Text}) as dq";

            using (var formProgress = new FormProgress())
            {
                var thread = new Thread(() =>
                {
                    formProgress.WaitForVisible();

                    using var connection = new ManagedConnection(_dataSource.GetSqlServerConnectionString());
                    using var reader = connection.ExecuteReader(sqlText);

                    foreach (var field in reader.Fields)
                    {
                        AddTypeToList(new DataSourceField(field.Name, field.Type.Name) { Enabled = true });
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
        }

        private void AddTypeToList(DataSourceField dataSourceField)
        {
            if (dataGridViewResults.InvokeRequired)
            {
                dataGridViewResults.Invoke(new Action(() => AddTypeToList(dataSourceField)));
            }
            else
            {
                var item = listViewFields.Items.Add(dataSourceField.Name);
                item.SubItems.Add(dataSourceField.Name);
                item.SubItems.Add(dataSourceField.Type);
                item.Checked = dataSourceField.Enabled;
            }
        }

        private void ToolStripButtonRun_Click(object sender, EventArgs e)
        {
            SampleData();
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (_dataSource == null)
            {
                MessageBox.Show("Before you can save, you must select a data source and execute it at least once.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("You must enter a data view name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            DataSourceView.DataSourceId = _dataSource.Id;
            DataSourceView.Name = textBoxName.Text;
            DataSourceView.Description = textBoxDescription.Text;
            DataSourceView.SQLText = Editor.Text;

            DataSourceView.Fields.Clear();
            foreach (ListViewItem item in listViewFields.Items)
            {
                DataSourceView.Fields.Add(new DataSourceField()
                {
                    Name = item.Text,
                    Type = item.SubItems[0].Text,
                    Enabled = item.Checked
                });
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}