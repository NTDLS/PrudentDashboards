using Library;
using NTDLS.Persistence;

namespace UI.Forms
{
    public partial class FormDataSources : Form
    {
        public FormDataSources()
        {
            InitializeComponent();
        }

        private void FormDataSources_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var serverConnections = ApplicationData.LoadFromDisk(Constants.TitleCaption, new List<SqlServerConnectionInfo>(), Utility.GetEncryptionProvider().Cipher);

            foreach (var serverConnection in serverConnections)
            {
                var item = new ListViewItem(serverConnection.Name);
                item.SubItems.Add(serverConnection.ServerName);
                item.SubItems.Add(serverConnection.DatabaseName);
                item.Tag = serverConnection;
                listViewDataSources.Items.Add(item);
            }
        }

        private void SaveGrid()
        {
            var serverConnections = new List<SqlServerConnectionInfo>();

            foreach (ListViewItem item in listViewDataSources.Items)
            {
                Utility.EnsureNotNull(item.Tag);
                serverConnections.Add((SqlServerConnectionInfo)item.Tag);
            }

            ApplicationData.SaveToDisk(Constants.TitleCaption, serverConnections, Utility.GetEncryptionProvider().Cipher);
        }

        private SqlServerConnectionInfo? EstablishConnection(SqlServerConnectionInfo? connectionInfo = null)
        {
            using (var formEstablishSQLServerConnection = new FormEstablishSQLServerDatasourceConnection(connectionInfo))
            {
                if (formEstablishSQLServerConnection.ShowDialog() == DialogResult.OK)
                {
                    return formEstablishSQLServerConnection.ConnectionInfo;
                }
            }
            return null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlServerConnectionInfo? serverConnection = EstablishConnection();
            if (serverConnection == null)
            {
                return;
            }

            var item = new ListViewItem(serverConnection.Name);
            item.SubItems.Add(serverConnection.ServerName);
            item.SubItems.Add(serverConnection.DatabaseName);
            item.Tag = serverConnection;
            listViewDataSources.Items.Add(item);

            SaveGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDataSources.SelectedItems?.Count != 1)
            {
                return;
            }

            var serverConnection = listViewDataSources.SelectedItems[0].Tag as SqlServerConnectionInfo;
            Utility.EnsureNotNull(serverConnection);

            serverConnection = EstablishConnection(serverConnection);
            if (serverConnection == null)
            {
                return;
            }

            var item = new ListViewItem(serverConnection.Name);
            item.SubItems.Add(serverConnection.ServerName);
            item.SubItems.Add(serverConnection.DatabaseName);
            item.Tag = serverConnection;
            listViewDataSources.Items.Add(item);

            SaveGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewDataSources.SelectedItems?.Count != 1)
            {
                return;
            }

            var item = listViewDataSources.SelectedItems[0];
            if (MessageBox.Show($"Delete {item.Text}?", Constants.TitleCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            listViewDataSources.Items.Remove(item);
            SaveGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
