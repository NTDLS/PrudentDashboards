using Library;
using PrudentDashboards.UI;
using System.Data.SqlClient;

namespace UI.Forms
{
    public partial class FormEstablishSQLServerConnection : Form
    {
        public SqlServerConnectionInfo ConnectionInfo { get; set; }

        public FormEstablishSQLServerConnection()
        {
            InitializeComponent();
            ConnectionInfo = new SqlServerConnectionInfo()
            {
                IntegratedSecurity = true,
            };
        }

        public FormEstablishSQLServerConnection(SqlServerConnectionInfo connectionInfo)
        {
            ConnectionInfo = connectionInfo;
            InitializeComponent();
        }

        private void EstablishSQLServerConnection_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            textboxUsername.Text = ConnectionInfo.UserName;
            textboxPassword.Text = ConnectionInfo.Password;
            textboxServerName.Text = ConnectionInfo.ServerName;
            textboxDatabaseName.Text = ConnectionInfo.DatabaseName;
            checkboxIntegratedSecurity.Checked = ConnectionInfo.IntegratedSecurity;

            CheckboxIntegratedSecurity_CheckedChanged(this, new EventArgs());
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textboxServerName.Text))
                {
                    MessageBox.Show("You must enter a server name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (string.IsNullOrWhiteSpace(textboxDatabaseName.Text))
                {
                    MessageBox.Show("You must enter a database name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (checkboxIntegratedSecurity.Checked == false)
                {
                    if (string.IsNullOrWhiteSpace(textboxUsername.Text))
                    {
                        MessageBox.Show("You must enter a user name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }

                using (var progressForm = new FormProgress())
                {
                    var thread = new Thread(() =>
                    {
                        progressForm.WaitForVisible();

                        var builder = new SqlConnectionStringBuilder()
                        {
                            DataSource = textboxServerName.Text,
                            InitialCatalog = textboxDatabaseName.Text,
                            UserID = textboxUsername.Text,
                            Password = textboxPassword.Text,
                            IntegratedSecurity = checkboxIntegratedSecurity.Checked
                        };

                        using (var sqlConnection = new SqlConnection(builder.ToString()))
                        {
                            try
                            {
                                sqlConnection.Open();
                                progressForm.Close();

                                ConnectionInfo = new SqlServerConnectionInfo()
                                {
                                    ServerName = textboxServerName.Text,
                                    DatabaseName = textboxDatabaseName.Text,
                                    UserName = textboxUsername.Text,
                                    Password = textboxPassword.Text,
                                    IntegratedSecurity = checkboxIntegratedSecurity.Checked
                                };

                                Close(DialogResult.OK);
                            }
                            catch(Exception ex)
                            {
                                ShowErrorMessage(ex.Message);
                            }
                            finally
                            {
                                Utility.TryAndIgnore(sqlConnection.Close);
                            }
                        }

                        progressForm.Close();
                    });

                    thread.Start();

                    progressForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ShowErrorMessage(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowErrorMessage(text)));
                return;
            }
            MessageBox.Show(text, Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void Close(DialogResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Close(result)));
                return;
            }
            DialogResult = result;
            base.Close();
        }

        private void CheckboxIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            textboxUsername.Enabled = !checkboxIntegratedSecurity.Checked;
            textboxPassword.Enabled = !checkboxIntegratedSecurity.Checked;
        }
    }
}
