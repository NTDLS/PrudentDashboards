using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Library.ManagedConnectivity;
using System.Data.SqlClient;
using System.Windows.Forms.Integration;
using System.Xml;
using UI.Properties;

namespace UI
{
    public partial class FormEditDataView : Form
    {
        private SqlConnectionStringBuilder _connectionBuilder;
        private TextEditor _editor;

        public FormEditDataView()
        {
            InitializeComponent();

            _editor = new TextEditor
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
                    _editor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
                    reader.Close();
                }
                stringReader.Close();
            }

            splitContainerHoriz.Panel1.Controls.Add(new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = _editor
            });

            _editor.KeyUp += (object sender, System.Windows.Input.KeyEventArgs e) =>
            {
                if (e.Key == System.Windows.Input.Key.F5)
                {
                    SampleData();
                }
            };

            _connectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "AdventureWorks",
                IntegratedSecurity = true,
            };


#if DEBUG
            _editor.Text = "select\r\n\tST.[Name] as [SalesTerritory],\r\n\tST.[CountryRegionCode] as [Country],\r\n\tST.[Group] as [Region],\r\n\tSOH.OrderDate,\r\n\tSOH.TotalDue,\r\n\tSOH.Freight,\r\n\tSOH.TaxAmt,\r\n\tSOH.SubTotal\r\nfrom\r\n\t[Sales].[SalesOrderHeader] as SOH\r\nINNER JOIN [Sales].[SalesTerritory] as ST\r\n\tON ST.TerritoryID = SOH.TerritoryID\r\n\r\n";
#endif
        }

        private void SampleData()
        {
            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();
            listViewFields.Items.Clear();

            string sqlText = $"SELECT TOP 100 * FROM ({_editor.Text}) as dq";

            var thread = new Thread(() =>
            {
                using var connection = new ManagedConnection(_connectionBuilder);
                using var reader = connection.ExecuteReader(sqlText);

                foreach (var field in reader.Fields)
                {
                    AddTypeToList(field);
                    AddGridColumn(field.Name);
                }

                foreach (var row in reader)
                {
                    var values = new List<string>();
                    row.ToList().ForEach(o => values.Add($"{o}"));
                    AddGridRow(values);
                }
            });

            void AddTypeToList(ManagedField managedField)
            {
                if (dataGridViewResults.InvokeRequired)
                {
                    dataGridViewResults.Invoke(new Action(() => AddTypeToList(managedField)));
                }
                else
                {
                    var item = listViewFields.Items.Add(managedField.Name);
                    item.SubItems.Add(managedField.Name);
                    item.SubItems.Add(managedField.Type.Name);
                    item.Checked = true;
                }
            }

            void AddGridRow(List<string> values)
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

            thread.Start();
        }

        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            SampleData();
        }

        private void FormEditDataView_Load(object sender, EventArgs e)
        {

        }
    }
}
