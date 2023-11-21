using Library.ManagedConnectivity;
using System.Data.SqlClient;

namespace UI
{
    public partial class FormEditDataView : Form
    {
        private SqlConnectionStringBuilder _connectionBuilder;

        public FormEditDataView()
        {
            InitializeComponent();

            _connectionBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "AdventureWorks",
                IntegratedSecurity = true,
            };
        }

        private void SampleData()
        {
            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();
            listViewFields.Items.Clear();

            string sqlText = $"SELECT TOP 100 * FROM ({textBoxSQLText.Text}) as dq";

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
    }
}
